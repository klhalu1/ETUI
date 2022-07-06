using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [FriendClass(typeof(Unit))]
    [FriendClass(typeof(NumericComponent))]
    [FriendClass(typeof(SpaceDockComponent))]
    [FriendClass(typeof(GateMapComponent))]
    public static class UnitHelper
    {
        public static UnitInfo CreateUnitInfo(Unit unit)
        {
            UnitInfo unitInfo = new UnitInfo();
            unitInfo.UnitId = unit.Id;
            unitInfo.ConfigId = unit.ConfigId;
            unitInfo.Type = (int)unit.Type;
            unitInfo.Name = unit.Name;

            NumericComponent nc = unit.GetComponent<NumericComponent>();
            if (nc != null)
            {
                foreach ((int key, long value) in nc.NumericDic)
                {
                    unitInfo.Ks.Add(key);
                    unitInfo.Vs.Add(value);
                }
            }
            SpaceDockComponent sc = unit.GetComponent<SpaceDockComponent>();
            if (sc != null)
            {
                foreach ((int key, long value) in sc.DockIds)
                {
                    unitInfo.DockIds.Add(value);
                }
            }

            return unitInfo;
        }
        
        // 获取看见unit的玩家，主要用于广播
        public static Dictionary<long, AOIEntity> GetBeSeePlayers(this Unit self)
        {
            return self.GetComponent<AOIEntity>().GetBeSeePlayers();
        }
        
        public static void NoticeUnitAdd(Unit unit, Unit sendUnit)
        {
            M2C_CreateUnits createUnits = new M2C_CreateUnits();
            createUnits.Units.Add(CreateUnitInfo(sendUnit));
            MessageHelper.SendToClient(unit, createUnits);
        }
        
        public static void NoticeUnitRemove(Unit unit, Unit sendUnit)
        {
            M2C_RemoveUnits removeUnits = new M2C_RemoveUnits();
            removeUnits.Units.Add(sendUnit.Id);
            MessageHelper.SendToClient(unit, removeUnits);
        }

        public static async ETTask<(bool, Unit)> LoadUnit(Player player)
        {
             GateMapComponent gateMapComponent = player.AddComponent<GateMapComponent>();
            gateMapComponent.Scene = await SceneFactory.Create(gateMapComponent, "GateMap", SceneType.Map);

            Unit unit = await UnitCacheHelper.GetUnitCache<Unit>(gateMapComponent.Scene, player.UnitId);

            bool isNewUnit = unit == null;
            if (isNewUnit)
            {
                unit = UnitFactory.Create(gateMapComponent.Scene,player.Id,UnitType.Player);
                
                var roleInfos = await DBManagerComponent.Instance.GetZoneDB(player.DomainZone()).Query<RoleInfo>(d => d.Id == player.UnitId);
                unit.AddComponent(roleInfos[0]);
                
                UnitCacheHelper.AddOrUpdateUnitAllCache(unit);
            }

            return (isNewUnit, unit);
        }

        public static async ETTask InitUnit(Unit unit, bool isNew)
        {
            //初始化
            if (isNew)
            {

            }
            await ETTask.CompletedTask;
        }
    }
}