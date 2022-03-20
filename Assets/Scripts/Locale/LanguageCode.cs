using UnityEngine;

namespace Locale
{
    public class LanguageCode
    {
        // Fields
        public static readonly System.Collections.Generic.Dictionary<string, Locale.LocaleE> AllLanguageCode;
        
        // Methods
        private static LanguageCode()
        {
            Add(key:  "en-US", value:  0);
            Add(key:  "pt", value:  1);
            Add(key:  "es", value:  2);
            Add(key:  "fr", value:  3);
            Locale.LanguageCode.AllLanguageCode = new System.Collections.Generic.Dictionary<System.String, Locale.LocaleE>();
        }
    
    }

}
