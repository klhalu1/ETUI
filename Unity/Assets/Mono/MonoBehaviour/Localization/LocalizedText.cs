using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    /// <summary>
    /// ¾²Ì¬ÎÄ±¾
    /// </summary>
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("Localization/LocalizedText")]
    public class LocalizedText : MonoBehaviour
    {
        public int key;

        private void Awake()
        {
            OnLocalization();
            LocalizationService.OnLanguageChanged += OnLocalization;
        }

        private void OnDestroy()
        {
            LocalizationService.OnLanguageChanged -= OnLocalization;
        }

        public void OnLocalization()
        {
            var label = GetComponent<Text>();

            label.text = (string)CodeLoader.Instance.localizationFunc.Run(key);
        }

    }
}