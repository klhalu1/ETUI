using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace ET
{
    public enum SpaceDockState
    {
        Locked = -1,
        Idle = 0,
    }
    
    [ComponentOf(typeof(Unit))]
    [ChildType(typeof(SpaceShip))]
#if SERVER
    public class SpaceDockComponent: Entity,IAwake,IDestroy,IUnitCache
#else
    public class SpaceDockComponent: Entity, IAwake, IDestroy
#endif
    {
#if SERVER
        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
#endif
        public Dictionary<int,long> DockIds = new Dictionary<int,long>();
    }
}