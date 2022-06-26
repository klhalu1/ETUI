using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LocalizationCategory : ProtoObject, IMerge
    {
        public static LocalizationCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, Localization> dict = new Dictionary<int, Localization>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<Localization> list = new List<Localization>();
		
        public LocalizationCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LocalizationCategory s = o as LocalizationCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (Localization config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public Localization Get(int id)
        {
            this.dict.TryGetValue(id, out Localization item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (Localization)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, Localization> GetAll()
        {
            return this.dict;
        }

        public Localization GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class Localization: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>中文</summary>
		[ProtoMember(2)]
		public string Chinese { get; set; }
		/// <summary>英文</summary>
		[ProtoMember(3)]
		public string English { get; set; }
		/// <summary>西班牙</summary>
		[ProtoMember(4)]
		public string Spanish { get; set; }

	}
}
