namespace ET
{
#if SERVER
    public class Item : Entity,IAwake<int>,IDestroy,ISerializeToEntity
#else
    public class Item : Entity,IAwake<int>,IDestroy
#endif
    {
        //物品配置ID
        public int ConfigId = 0;

        public int Quality = 0;
    }
}