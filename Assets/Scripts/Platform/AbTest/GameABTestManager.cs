using UnityEngine;

namespace Platform.AbTest
{
    public class GameABTestManager
    {
        // Fields
        private static string ConfigPath;
        private static string _groupId;
        private static Platform.AbTest.ABTestData _abTestData;
        private static string _abTestTag;
        private static string _abTestTagPlus;
        
        // Methods
        public static void Init(bool isDebug, string luid)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            string val_14 = 0;
            string val_13 = 0;
            val_18 = null;
            val_18 = null;
            Platform.AbTest.GameABTestManager.ConfigPath = (isDebug != true) ? "Config/AbTest/android_abtest_config_debug" : "Config/AbTest/android_abtest_config_release";
            ABTest.ABTestSettings val_4 = SetDebug(debug:  isDebug);
            ABTest.ABTestSettings val_5 = SetDefaultConfigPath(defaultConfigPath:  Platform.AbTest.GameABTestManager.ConfigPath);
            ABTest.ABTestSettings val_7 = SetEventListener(eventListener:  new Platform.AbTest.ABTestEventListener());
            ABTest.ABTestSettings val_8 = SetProductId(productId:  Platform.PlatformDefine.<ProductionId>k__BackingField);
            ABTest.ABTestSettings val_9 = SetLuid(luid:  luid);
            val_19 = null;
            val_19 = null;
            ABTest.ABTestManager val_10 = ABTestManager.SingletonHandler.Instance.Init(settings:  new ABTest.ABTestSettings(isNewUser:  true));
            Platform.AbTest.GameABTestManager._groupId = ABTest.ABTestManager.GetPlayerId().ToString();
            val_20 = null;
            val_20 = null;
            ABTestManager.SingletonHandler.Instance.GetTag(tag: out  val_13, tagPlus: out  val_14);
            val_21 = null;
            val_21 = null;
            Platform.AbTest.GameABTestManager.InitAbTestData(dataJson:  ABTestManager.SingletonHandler.Instance.GetData(), tag:  val_13, tagPlus:  val_14);
            UnityEngine.Coroutine val_17 = public static Logic.Game.GameManager Common.MonoSingleton<Logic.Game.GameManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.StartCoroutine(routine:  Platform.AbTest.GameABTestManager.Request());
        }
        private static System.Collections.IEnumerator Request()
        {
            typeof(GameABTestManager.<Request>d__3).__il2cppRuntimeField_10 = 0;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void InitAbTestData(string dataJson, string tag, string tagPlus)
        {
            var val_5;
            var val_6;
            UnityEngine.Debug.Log(message:  "[Level Test]" + dataJson);
            if(dataJson != null)
            {
                    UnityEngine.Debug.Log(message:  "[ABTest] init json: "("[ABTest] init json: ") + dataJson);
                val_5 = null;
                val_5 = null;
                Platform.AbTest.GameABTestManager._abTestData = Platform.AbTest.ConfigParser.ParseData<Platform.AbTest.ABTestData>(json:  dataJson);
                Platform.AbTest.GameABTestManager._abTestTagPlus = tagPlus;
                Platform.AbTest.GameABTestManager._abTestTag = tag;
                if((System.String.IsNullOrEmpty(value:  Platform.AbTest.GameABTestManager._abTestTag)) == false)
            {
                    return;
            }
            
                val_6 = null;
                val_6 = null;
                Platform.AbTest.GameABTestManager._abTestTag = "Unknown";
                return;
            }
            
            UnityEngine.Debug.Log(message:  "[ABTest] Cannot find abtest config!~");
        }
        public static string GetTag()
        {
            null = null;
            return (string)Platform.AbTest.GameABTestManager._abTestTag;
        }
        public static string GetTagPlus()
        {
            null = null;
            return (string)Platform.AbTest.GameABTestManager._abTestTagPlus;
        }
        public static string GetId()
        {
            string val_3;
            var val_4 = null;
            if(Platform.AbTest.GameABTestManager._groupId == null)
            {
                    val_4 = null;
                val_3 = ABTest.ABTestManager.GetPlayerId().ToString();
                val_4 = null;
                Platform.AbTest.GameABTestManager._groupId = val_3;
            }
            
            val_4 = null;
            return (string)Platform.AbTest.GameABTestManager._groupId;
        }
        public static bool IsRewardCoins2()
        {
            return true;
        }
        public static bool IsRewardCoins3()
        {
            return false;
        }
        public static bool IsRewardAd_UI()
        {
            return true;
        }
        public static bool IsReward()
        {
            return true;
        }
        public static bool IsRewardLevelAd()
        {
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            return (bool)(val_1._userInstallDays > 10) ? 1 : 0;
        }
        public static bool IsPiggyBank()
        {
            return false;
        }
        public static bool IsButterFly()
        {
            return true;
        }
        public static bool IsCombo8()
        {
            return false;
        }
        public static bool IsPushContentTest()
        {
            return true;
        }
        public static bool IsPushTest()
        {
            return false;
        }
        public static bool IsActMission()
        {
            return true;
        }
        public static bool IsGameSoundTest()
        {
            return true;
        }
        public GameABTestManager()
        {
        
        }
        private static GameABTestManager()
        {
            object val_1 = null;
            typeof(Platform.AbTest.ABTestData).__il2cppRuntimeField_10 = 1;
            typeof(Platform.AbTest.ABTestData).__il2cppRuntimeField_20 = 1;
            typeof(Platform.AbTest.ABTestData).__il2cppRuntimeField_30 = 4294967297;
            typeof(Platform.AbTest.ABTestData).__il2cppRuntimeField_38 = 1;
            val_1 = new System.Object();
            Platform.AbTest.GameABTestManager._abTestData = val_1;
            Platform.AbTest.GameABTestManager._abTestTag = System.String.alignConst;
            Platform.AbTest.GameABTestManager._abTestTagPlus = "|||";
        }
    
    }

}
