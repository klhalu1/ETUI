using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ET
{
    [ChildType(typeof(Item))]
#if SERVER
    public class BagComponent : Entity, IAwake, IDestroy, IDeserialize, ITransfer, IUnitCache
#else
    public class BagComponent : Entity, IAwake, IDestroy
#endif
    {
#if SERVER
        [BsonIgnore]
#endif
        public Dictionary<long, Item> ItemsDict = new Dictionary<long, Item>();
        
#if SERVER
        [BsonIgnore]
#endif
        public MultiMap<int, Item> ItemsMap = new MultiMap<int, Item>();
    }
}