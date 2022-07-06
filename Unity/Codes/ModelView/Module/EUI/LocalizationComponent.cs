using System;
using System.Collections;
using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class LocalizationComponent : Entity, IAwake
    {
        public static LocalizationComponent Instance;
    }
}

