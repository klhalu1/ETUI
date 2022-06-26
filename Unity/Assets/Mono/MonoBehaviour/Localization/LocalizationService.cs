using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace ET
{
   
    public class LocalizationService
    {
        #region static
        private static LocalizationService _instance;
        public static LocalizationService Instance
        {
            get { return _instance ?? (_instance = new LocalizationService()); }
        }
        
        #endregion

        #region event
        /// <summary>
        /// 语言改变事件
        /// </summary>
        public static Action OnLanguageChanged;
        #endregion

        #region properties

        /// <summary>
        /// 存储所有语言信息
        /// </summary>
        public Dictionary<long, string> Strings = new Dictionary<long, string>();      

        /// <summary>
        /// 默认显示静态文本语言
        /// </summary>
        [HideInInspector]
        public LanguageInfo DefaultLanguage;

        /// <summary>
        /// 当前语言
        /// </summary>
        [HideInInspector]
        private LanguageInfo _language = LanguageInfo.Chinese;
        public LanguageInfo Language
        {
            get { return _language; }
            set
            {
                if (!HasLanguage(value))
                {
                    Debug.LogError("Invalid Language " + value);
                }

                _language = value;

                RaiseLanguageChanged();

                SaveToPrefs();
            }
        }

        /// <summary>
        /// 所有支持的语言
        /// </summary>
        [SerializeField]
        public LanguageInfo[] Languages = LanguageInfo.All;
        #endregion

        #region LocalizationService       

        public void Init()
        {
            LoadLanguage();

#if UNITY_EDITOR
            if (!UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
            {
                return;
            }
#endif
         //   ReadFiles();
        }

        /// <summary>
        /// 默认加载语言
        /// </summary>
        void LoadLanguage()
        {
            var raw = PlayerPrefs.GetString("CurrentLanguage");
            if (string.IsNullOrEmpty(raw))
            {
                bool hasLan = false;
                for (int i = 0; i < Languages.Length; i++)
                {
                    if (Application.systemLanguage == Languages[i].lan)
                    {
                        hasLan = true;
                        Language = Languages[i];
                        break;
                    }
                }
                if (!hasLan)
                {
                    Language = LanguageInfo.Chinese;
                }
                return;
            }


            var lan = Languages.FirstOrDefault(o => o.Name == raw);
            if (lan == null)
            {
                Debug.LogError("Unknown language saved to prefs : " + raw);
                Language = LanguageInfo.Chinese;
            }
            else
            {
                Language = lan;
            }
        }

        /// <summary>
        /// 保存到本地
        /// </summary>
        void SaveToPrefs()
        {
            PlayerPrefs.SetString("CurrentLanguage", Language.Name);
            PlayerPrefs.Save();
        }

        #endregion

        /// <summary>
        /// 是否有配置该语言
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        bool HasLanguage(LanguageInfo language)
        {
            foreach (var systemLanguage in Languages)
            {
                if (systemLanguage.Equals(language))
                    return true;
            }
            return false;
        }


        /// <summary>
        /// 切换语言
        /// </summary>
        private void RaiseLanguageChanged()
        {           
            if (Application.isPlaying)
            {
                if (OnLanguageChanged != null)
                    OnLanguageChanged();
            }
        }
       

    }
}