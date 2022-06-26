namespace ET
{
    public abstract class IStaticFunc
    {
        public abstract object Run();
        public abstract object Run(object a);
        public abstract object Run(object a, object b);
        public abstract object Run(object a, object b, object c);
    }
}