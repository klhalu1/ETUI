namespace ET
{
    public enum SpaceShipState
    {
        Idle = 0,
        Destroy,
        Battle,
        Flying,
    }
    public sealed class SpaceShip : Entity,IAwake,IUnitCache
    {
        public long ConfigId { get; set; }
        public long RoldId { get; set; }
        public SpaceShipState SpaceShipState { get; set; }
    }
}