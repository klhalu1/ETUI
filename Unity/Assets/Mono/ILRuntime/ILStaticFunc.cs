using ILRuntime.CLR.Method;
using UnityEngine;

namespace ET
{
    public class ILStaticFunc : IStaticFunc
    {
        private readonly ILRuntime.Runtime.Enviorment.AppDomain appDomain;
        private readonly IMethod method;
        private readonly object[] param;

        public ILStaticFunc(ILRuntime.Runtime.Enviorment.AppDomain appDomain, string typeName, string methodName, int paramsCount)
        {
            this.appDomain = appDomain;
            this.method = appDomain.GetType(typeName).GetMethod(methodName, paramsCount);
            this.param = new object[paramsCount];
        }

        public override object Run()
        {
            return this.appDomain.Invoke(this.method, null, this.param);
        }

        public override object Run(object a)
        {
            this.param[0] = a;
            return this.appDomain.Invoke(this.method, null, param);
        }

        public override object Run(object a, object b)
        {
            this.param[0] = a;
            this.param[1] = b;
            return this.appDomain.Invoke(this.method, null, param);
        }

        public override object Run(object a, object b, object c)
        {
            this.param[0] = a;
            this.param[1] = b;
            this.param[2] = c;
            return this.appDomain.Invoke(this.method, null, param);
        }
    }
}


