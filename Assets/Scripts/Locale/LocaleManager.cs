using UnityEngine;

namespace Locale
{
    public class LocaleManager
    {
        // Fields
        private static string CurLanguageCode;
        
        // Methods
        public static void Create()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  Resource.ResManager.Load<UnityEngine.GameObject>(path:  "Prefab/Locale/LanguageSource", parent:  0)));
            Locale.LocaleManager.CurLanguageCode = Locale.LocaleManager.GetLanguageCode();
        }
        public static void UpdateCurLanguageCode()
        {
            string val_4;
            if((System.String.IsNullOrEmpty(value:  Locale.LocaleManager.CurLanguageCode)) == true)
            {
                    return;
            }
            
            val_4 = Locale.LocaleManager.CurLanguageCode;
            if((System.String.op_Inequality(a:  val_4, b:  I2.Loc.LocalizationManager.CurrentLanguageCode)) == false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.CurrentLanguageCode = Locale.LocaleManager.CurLanguageCode;
        }
        public static string Translate(string key)
        {
            return (string)I2.Loc.LocalizationManager.GetTranslation(Term:  key, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0, allowLocalizedParameters:  true);
        }
        public static string GetLanguageCode()
        {
            return I2.Loc.LocalizationManager.CurrentLanguageCode;
        }
        public static Locale.LocaleE GetCurLanguage()
        {
            var val_4;
            var val_5;
            Locale.LocaleE val_2 = 0;
            val_4 = 0;
            if((System.String.IsNullOrEmpty(value:  Locale.LocaleManager.CurLanguageCode)) == true)
            {
                    return (Locale.LocaleE)val_4;
            }
            
            val_5 = null;
            val_5 = null;
            if((Locale.LanguageCode.AllLanguageCode.TryGetValue(key:  Locale.LocaleManager.CurLanguageCode, value: out  val_2)) != false)
            {
                    val_4 = val_2;
                return (Locale.LocaleE)val_4;
            }
            
            val_4 = 0;
            return (Locale.LocaleE)val_4;
        }
    
    }

}
