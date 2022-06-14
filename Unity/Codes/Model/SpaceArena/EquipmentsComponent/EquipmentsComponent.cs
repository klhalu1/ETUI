using System.Collections.Generic;
#if SERVER
using MongoDB.Bson.Serialization.Attributes;
#endif

namespace ET
{
    [ChildType(typeof(Item))]
#if SERVER
    public class EquipmentsComponent : Entity,IAwake,IDestroy,ITransfer,IDeserialize,IUnitCache
#else
    public class EquipmentsComponent : Entity,IAwake,IDestroy
#endif
    {
#if SERVER
        [BsonIgnore]
#endif
        public Dictionary<int, Item> EquipItems = new Dictionary<int, Item>();
#if SERVER
        //[BsonIgnore]
#endif
    }
}