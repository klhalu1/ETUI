namespace ET
{
    public class SpaceDockComponent
    {
#if SERVER
        public class SpaceDockCompont: Entity,IAwake,IDestroy,IUnitCache
#else
        public class SpaceDockCompont: Entity, IAwake, IDestroy
#endif
        {
            
        }
    }
}