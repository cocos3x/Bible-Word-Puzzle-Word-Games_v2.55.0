using UnityEngine;

namespace Platform
{
    public class PlatformDefine
    {
        // Fields
        private static string <StreamingPath>k__BackingField;
        private static string <Platform>k__BackingField;
        private static string <RateUsLangKey>k__BackingField;
        private static string <RateUsUrl>k__BackingField;
        private static string <FeedbackTag>k__BackingField;
        private static string <ProductionId>k__BackingField;
        private static string <AppId>k__BackingField;
        
        // Properties
        set; }
        public static string Platform { get; set; }
        private static string RateUsLangKey { set; }
        private static string RateUsUrl { set; }
        private static string FeedbackTag { set; }
        public static string ProductionId { get; set; }
        public static string AppId { get; set; }
        
        // Methods
        private static void set_StreamingPath(string value)
        {
            Platform.PlatformDefine.<StreamingPath>k__BackingField = value;
        }
        public static string get_Platform()
        {
            return (string)Platform.PlatformDefine.<Platform>k__BackingField;
        }
        private static void set_Platform(string value)
        {
            Platform.PlatformDefine.<Platform>k__BackingField = value;
        }
        private static void set_RateUsLangKey(string value)
        {
            Platform.PlatformDefine.<RateUsLangKey>k__BackingField = value;
        }
        private static void set_RateUsUrl(string value)
        {
            Platform.PlatformDefine.<RateUsUrl>k__BackingField = value;
        }
        private static void set_FeedbackTag(string value)
        {
            Platform.PlatformDefine.<FeedbackTag>k__BackingField = value;
        }
        public static string get_ProductionId()
        {
            return (string)Platform.PlatformDefine.<ProductionId>k__BackingField;
        }
        private static void set_ProductionId(string value)
        {
            Platform.PlatformDefine.<ProductionId>k__BackingField = value;
        }
        public static string get_AppId()
        {
            return (string)Platform.PlatformDefine.<AppId>k__BackingField;
        }
        private static void set_AppId(string value)
        {
            Platform.PlatformDefine.<AppId>k__BackingField = value;
        }
        public static void Init()
        {
            Platform.PlatformDefine.InitAndroid();
        }
        private static void InitAndroid()
        {
            var val_5;
            var val_6;
            Platform.PlatformDefine.<StreamingPath>k__BackingField = UnityEngine.Application.streamingAssetsPath;
            Platform.PlatformDefine.<Platform>k__BackingField = "Android";
            val_5 = null;
            Platform.PlatformDefine.<AppId>k__BackingField = UnityEngine.Application.identifier;
            val_5 = 1152921504826388664;
            Platform.PlatformDefine.<RateUsLangKey>k__BackingField = "62";
            val_6 = null;
            Platform.PlatformDefine.<RateUsUrl>k__BackingField = "https://play.google.com/store/apps/details?id="("https://play.google.com/store/apps/details?id=") + UnityEngine.Application.identifier + "&referrer=utm_source%3DAboutRateUs%26utm_medium%3Dcpi"("&referrer=utm_source%3DAboutRateUs%26utm_medium%3Dcpi");
            val_6 = 1152921504826388664;
            val_6 = null;
            Platform.PlatformDefine.<FeedbackTag>k__BackingField = Platform.PlatformDefine.<Platform>k__BackingField;
            val_6 = 1152921504826388664;
            Platform.PlatformDefine.<ProductionId>k__BackingField = "5b18faf53e70cb00010315f6";
        }
    
    }

}
