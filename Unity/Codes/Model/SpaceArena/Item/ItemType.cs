namespace ET
{
    public enum ItemType
    {
        Weapon = 1,
        Defense = 2,
        Utility = 3,
        Ballistic = 11, //弹道火力
        Missile = 12,   //导弹
        Laser = 13,     //激光
        Armor = 21,     //装甲
        Shield = 22,    //护盾
        System = 23,    //系统
        Engine = 31,    //引擎
        Power = 32,     //动力
        Support = 33,   //支援
    }

    /// <summary>
    /// 物品操作
    /// </summary>
    public enum ItemOp
    {
        Add = 0,
        Remove = 1,
    } 
    /// <summary>
    /// 物品容器类型
    /// </summary>
    public enum ItemContainerType
    {
        Bag = 0,
        SpaceShip = 1,
    }
}