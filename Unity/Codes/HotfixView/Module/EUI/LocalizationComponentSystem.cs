namespace ET
{
    [ObjectSystem]
    public class LocaliztaionAwakeSystem : AwakeSystem<LocalizationComponent>
    {
        public override void Awake(LocalizationComponent self)
        {
            LocalizationComponent.Instance = self;
            LocalizationService.Instance.Init();
        }
    }
    
    public static class LocalizationComponentSystem
    {
        /// <summary>
        /// 获取文本
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetTextByKey(int key)
        {
            return LocalizationHelper.GetStrByLanguage(key);
        }

        /// <summary>
        /// 切换语言
        /// </summary>
        /// <param name="info"></param>
        public static void ChangeLanguage(this LocalizationComponent self,LanguageInfo info)
        {
            LocalizationService.Instance.Language = info;
        }

        /// <summary>
        /// 动态文本如果切换语言时没有手动刷新界面的话，需要加上这个回调强制刷新
        /// </summary>
        /// <param name="act"></param>
        public static void OnLanguageChanged(System.Action act)
        {
            LocalizationService.OnLanguageChanged += act;
        }
    }
}