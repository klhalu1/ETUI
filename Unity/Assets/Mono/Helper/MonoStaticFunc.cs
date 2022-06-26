using System;
using System.Reflection;

namespace ET
{
    public class MonoStaticFunc : IStaticFunc
    {
        private readonly MethodInfo methodInfo;

        private readonly object[] param;

        public MonoStaticFunc(Assembly assembly, string typeName, string methodName)
        {
            this.methodInfo = assembly.GetType(typeName).GetMethod(methodName);
            this.param = new object[this.methodInfo.GetParameters().Length];
        }

        public override object Run()
        {
            return this.methodInfo.Invoke(null, param);
        }

        public override object Run(object a)
        {
            this.param[0] = a;
            return this.methodInfo.Invoke(null, param);
        }

        public override object Run(object a, object b)
        {
            this.param[0] = a;
            this.param[1] = b;
            return this.methodInfo.Invoke(null, param);
        }

        public override object Run(object a, object b, object c)
        {
            this.param[0] = a;
            this.param[1] = b;
            this.param[2] = c;
            return this.methodInfo.Invoke(null, param);
        }
    }
}

