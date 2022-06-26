using System;
using UnityEngine;

namespace ET
{
    
    [Serializable]
    public class LanguageInfo : IEquatable<LanguageInfo>
    {
        public string Name;//名字
        public SystemLanguage lan;//系统语言

        public LanguageInfo()
        {

        }

        public LanguageInfo(string name, SystemLanguage sl)
        {
            Name = name;
            lan = sl;
        }

        /// <summary>
        /// 代码添加语言
        /// </summary>
        public static readonly LanguageInfo Chinese = new LanguageInfo("Chinese", SystemLanguage.Chinese);
        public static readonly LanguageInfo English = new LanguageInfo("English", SystemLanguage.English);
        public static readonly LanguageInfo Spanish = new LanguageInfo("Spanish", SystemLanguage.Spanish);
        

        public static readonly LanguageInfo[] All = {
            Chinese,
            English,
            Spanish,
        };

        public bool Equals(LanguageInfo other)
        {
            return other.Name == Name;
        }
    }
}