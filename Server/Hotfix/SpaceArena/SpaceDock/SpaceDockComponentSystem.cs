namespace ET
{
    [FriendClass(typeof(SpaceDockComponent))]
    public class SpaceDockComponentAwakeSystem: AwakeSystem<SpaceDockComponent>
    {
        public override void Awake(SpaceDockComponent self)
        {
        }
    }
    
    public class SpaceDockComponentDestroySystem: DestroySystem<SpaceDockComponent>
    {
        public override void Destroy(SpaceDockComponent self)
        {
        }
    }
    
    [FriendClass(typeof(SpaceDockComponent))]
    public static class SpaceDockComponentSystem
    {
        public static void UnLockSpaceDock(this SpaceDockComponent self, int index)
        {
            if (self.DockIds[index] == (int)SpaceDockState.Locked)
            {
                self.DockIds[index] = (int)SpaceDockState.Idle;
            }
        }

        public static SpaceShip AddSpaceShip(this SpaceDockComponent self, int index, int Id)
        {
            long spaceShipId = IdGenerater.Instance.GenerateInstanceId();
            SpaceShip spaceShip = self.AddChildWithId<SpaceShip,int>(spaceShipId,Id);
            if (spaceShip == null)
            {
                Log.Error($"位置{index}的船坞添加飞船失败！");
                return null; 
            }
            if (self.DockIds[index] != (int)SpaceDockState.Idle)
            {
                Log.Error($"位置{index}的船坞非闲置状态，添加飞船失败！");
                return null;
            }

            self.DockIds[index] = spaceShipId;
            return spaceShip;
        }

        public static void RemoveSpaceShip(this SpaceDockComponent self, int index)
        {
            if(self.DockIds[index] <= 0)
                return;
            SpaceShip spaceShip = self.GetChild<SpaceShip>(self.DockIds[index]);
            spaceShip.SpaceShipState = SpaceShipState.Destroy;
            
            self.DockIds[index] = (int)SpaceDockState.Idle;
        }

        public static void InitSpaceDock(this SpaceDockComponent self)
        {
            for (int i = 0; i < 5; i++)
            {
                self.DockIds.Add(i,(int)SpaceDockState.Locked);
            }
        }
    }
}