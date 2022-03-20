using UnityEngine;

namespace Logic.Define
{
    public static class ApplicationConfig
    {
        // Fields
        private static readonly string CachePath;
        public static readonly string TextureCachePath;
        public static string BonusIdentifier;
        public static string ExtrasIdentifier;
        public static string DynamicIdentifier;
        
        // Methods
        private static ApplicationConfig()
        {
            int val_6;
            int val_7;
            string[] val_1 = new string[2];
            val_6 = val_1.Length;
            val_1[0] = UnityEngine.Application.persistentDataPath;
            val_6 = val_1.Length;
            val_1[1] = "Cache";
            Logic.Define.ApplicationConfig.CachePath = Utils.Util.PathUtil.Combine(paths:  val_1);
            string[] val_4 = new string[2];
            val_7 = val_4.Length;
            val_4[0] = Logic.Define.ApplicationConfig.CachePath;
            val_7 = val_4.Length;
            val_4[1] = "Image";
            Logic.Define.ApplicationConfig.TextureCachePath = Utils.Util.PathUtil.Combine(paths:  val_4);
            Logic.Define.ApplicationConfig.BonusIdentifier = "b";
            Logic.Define.ApplicationConfig.ExtrasIdentifier = "e";
            Logic.Define.ApplicationConfig.DynamicIdentifier = "dynamic";
        }
    
    }

}
