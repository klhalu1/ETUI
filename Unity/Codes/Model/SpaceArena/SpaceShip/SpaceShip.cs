using MongoDB.Bson.Serialization.Attributes;

namespace ET
{
    public enum SpaceShipState
    {
        Destroy = 0,
        Idle,
        Battle,
        Flying,
    }
#if SERVER
    public sealed class SpaceShip : Entity,IAwake<int>,IUnitCache
#else
    public sealed class SpaceShip : Entity,IAwake
#endif
    {
        public int ConfigId { get; set; }
        public long RoldId { get; set; }
        public SpaceShipState SpaceShipState { get; set; }
#if SERVER        
        [BsonIgnore]
        public SpaceShipConfig Config => SpaceShipConfigCategory.Instance.Get(this.ConfigId);
#endif
    }
}