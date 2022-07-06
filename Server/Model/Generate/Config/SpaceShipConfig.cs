using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SpaceShipConfigCategory : ProtoObject, IMerge
    {
        public static SpaceShipConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SpaceShipConfig> dict = new Dictionary<int, SpaceShipConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SpaceShipConfig> list = new List<SpaceShipConfig>();
		
        public SpaceShipConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SpaceShipConfigCategory s = o as SpaceShipConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SpaceShipConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SpaceShipConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SpaceShipConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SpaceShipConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SpaceShipConfig> GetAll()
        {
            return this.dict;
        }

        public SpaceShipConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SpaceShipConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(3)]
		public string Desc { get; set; }
		/// <summary>类型</summary>
		[ProtoMember(4)]
		public int Type { get; set; }
		/// <summary>解锁等级</summary>
		[ProtoMember(5)]
		public int UnlockLv { get; set; }
		/// <summary>速度</summary>
		[ProtoMember(6)]
		public double Speed { get; set; }
		/// <summary>转向</summary>
		[ProtoMember(7)]
		public double Turning { get; set; }
		/// <summary>格子数</summary>
		[ProtoMember(8)]
		public int CellNum { get; set; }
		/// <summary>格子数</summary>
		[ProtoMember(9)]
		public int MaxCellNum { get; set; }
		/// <summary>规模X</summary>
		[ProtoMember(10)]
		public int SizeX { get; set; }
		/// <summary>规模Y</summary>
		[ProtoMember(11)]
		public int SizeY { get; set; }
		/// <summary>子飞船id</summary>
		[ProtoMember(12)]
		public int[] SubShipId { get; set; }
		/// <summary>格子列表</summary>
		[ProtoMember(13)]
		public int[] CellList { get; set; }

	}
}
