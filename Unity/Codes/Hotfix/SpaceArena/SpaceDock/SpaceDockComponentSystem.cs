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
        public static void Set(this SpaceDockComponent self, int index, long value)
        {
            self.DockIds.Add(index,value);
        }
    }
}