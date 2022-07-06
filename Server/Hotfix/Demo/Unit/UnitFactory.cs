using System;
using UnityEngine;

namespace ET
{
    [FriendClass(typeof(Unit))]
    public static class UnitFactory
    {
        public static Unit Create(Scene scene, long id, UnitType unitType)
        {
            UnitComponent unitComponent = scene.GetComponent<UnitComponent>();
            switch (unitType)
            {
                case UnitType.Player:
                {
                    Unit unit = unitComponent.AddChildWithId<Unit, int>(id, 1001);
                    unit.AddComponent<SpaceDockComponent>().InitSpaceDock();
                    //ChildType测试代码 取消注释 编译Server.hotfix 可发现报错
                    //unitComponent.AddChild<Player, string>("Player");

                    NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
                    numericComponent.Set(NumericType.Exp, 0); 
                    numericComponent.Set(NumericType.Gold, 1000);
                    numericComponent.Set(NumericType.Level, 1);
                    numericComponent.Set(NumericType.Money, 10);
                    
                    unitComponent.Add(unit);
                    return unit;
                }
                default:
                    throw new Exception($"not such unit type: {unitType}");
            }
        }
    }
}