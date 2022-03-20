using UnityEngine;

namespace I2.Loc
{
    public static class GoogleTranslation
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest> mCurrentTranslations;
        private static System.Collections.Generic.List<I2.Loc.TranslationJob> mTranslationJobs;
        
        // Methods
        public static string UppercaseFirst(string s)
        {
            if((System.String.IsNullOrEmpty(value:  s)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            System.Char[] val_3 = s.ToLower().ToCharArray();
            val_3[0] = System.Char.ToUpper(c:  val_3[0]);
            return 0.CreateString(val:  val_3);
        }
        public static string TitleCase(string s)
        {
            if((System.String.IsNullOrEmpty(value:  s)) == false)
            {
                    return System.Globalization.CultureInfo.CurrentCulture.ToTitleCase(str:  s);
            }
            
            return (string)System.String.alignConst;
        }
        private static GoogleTranslation()
        {
            I2.Loc.GoogleTranslation.mCurrentTranslations = new System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest>();
            I2.Loc.GoogleTranslation.mTranslationJobs = new System.Collections.Generic.List<I2.Loc.TranslationJob>();
        }
    
    }

}
