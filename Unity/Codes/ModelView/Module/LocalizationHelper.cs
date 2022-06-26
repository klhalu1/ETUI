using System;

namespace ET
{
    public static class LocalizationHelper
    {
        public static string GetStrByLanguage(int id)
        {
            Localization config = LocalizationCategory.Instance.Get(id);
            if (config == null)
            {
                Log.Error("Localization id is not found");
                return "";
            }
            if (LocalizationService.Instance.Language == LanguageInfo.Chinese)
                return config.Chinese;
            else if (LocalizationService.Instance.Language == LanguageInfo.English)
                return config.English;
            else if (LocalizationService.Instance.Language == LanguageInfo.Spanish)
                return config.Spanish;
            else
                return config.Chinese;
        }
    }
}
