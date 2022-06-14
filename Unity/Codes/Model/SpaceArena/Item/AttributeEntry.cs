namespace ET
{
    public enum EntryType
    {
        Common = 1,
        Special = 2,
    }
#if SERVER
    public class AttributeEntry : Entity,IAwake,IDestroy,ISerializeToEntity
#else
    public class AttributeEntry : Entity,IAwake,IDestroy
#endif
    {
        public int Key;
        public long Value;
        public EntryType Type;
    }
}