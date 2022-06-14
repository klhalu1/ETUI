namespace ET
{
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
    
    public static class SpaceDockComponentSystem
    {
        
    }
}