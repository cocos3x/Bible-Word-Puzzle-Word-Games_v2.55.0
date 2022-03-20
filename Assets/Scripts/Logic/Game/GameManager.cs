using UnityEngine;

namespace Logic.Game
{
    public class GameManager : MonoSingleton<Logic.Game.GameManager>
    {
        // Fields
        private bool <debug>k__BackingField;
        public static Logic.Game.GameConfig gameConfig;
        public static Logic.Game.GameLevel gameLevel;
        public static Logic.Game.GameBible gameBible;
        public static Logic.Game.GameQuizLevel gameQuizLevel;
        public static Logic.Game.GameDailyPrayer gameDailyPrayer;
        public static Logic.Game.GameDiglog gameDialog;
        public static Logic.Game.GameMusic gameMusic;
        public static Logic.Game.GameSound gameSound;
        public static Logic.Game.GameScene gameScene;
        public static Platform.Iap.IAP iap;
        private bool _isClickOldPP;
        private bool _hasInit;
        public UnityEngine.Rect attRect;
        
        // Properties
        public bool debug { get; set; }
        
        // Methods
        public bool get_debug()
        {
            return (bool)this.<debug>k__BackingField;
        }
        public void set_debug(bool value)
        {
            this.<debug>k__BackingField = value;
        }
        protected override void Awake()
        {
            Common.SingletonController<View.Controller.MainController>.Instance.Init();
            if((public static Logic.Game.GameManager Common.MonoSingleton<Logic.Game.GameManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184) == 0)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
                if((System.String.IsNullOrEmpty(value:  UnityEngine.PlayerPrefs.GetString(key:  "APP_VERSION"))) != false)
            {
                    Common.GlobalProperty.isUserFirstLogin = true;
            }
            
                Platform.PlatformDefine.Init();
                UnityEngine.Application.targetFrameRate = 60;
                Platform.Device.DeviceDefine.Init();
                this.InitGameScene();
                Locale.LocaleManager.Create();
                Common.SingletonController<View.Controller.MainController>.Instance.BibleGameState = 0;
                Common.SingletonController<View.Controller.MainController>.Instance.ShowLoading();
                UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.InitGame());
                this.Awake();
                return;
            }
            
            if((public static Logic.Game.GameManager Common.MonoSingleton<Logic.Game.GameManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184) == this)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private System.Collections.IEnumerator InitGame()
        {
            typeof(GameManager.<InitGame>d__17).__il2cppRuntimeField_10 = 0;
            typeof(GameManager.<InitGame>d__17).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private System.Collections.IEnumerator HideSplash()
        {
            typeof(GameManager.<HideSplash>d__18).__il2cppRuntimeField_10 = 0;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void InitGameConfig()
        {
            Logic.Game.GameManager.gameConfig = Utils.Unity.ComponentExtension.GetOrAddComponent<Logic.Game.GameConfig>(target:  this.transform);
        }
        private void InitIAP()
        {
            Logic.Game.GameManager.iap = new Platform.Iap.IAP();
            Init();
        }
        private void InitGameDialog()
        {
            Logic.Game.GameManager.gameDialog = Utils.Unity.ComponentExtension.GetOrAddComponent<Logic.Game.GameDiglog>(target:  this.transform);
        }
        private void InitGameLevel()
        {
            Logic.Game.GameManager.gameLevel = new System.Object();
        }
        private void InitGameBible()
        {
            Logic.Game.GameManager.gameBible = new System.Object();
        }
        private void InitGameQuizLevel()
        {
            Logic.Game.GameManager.gameQuizLevel = new System.Object();
        }
        private void InitGameDailyPrayer()
        {
            Logic.Game.GameManager.gameDailyPrayer = new System.Object();
        }
        private void InitGameMusic()
        {
            Logic.Game.GameManager.gameMusic = Utils.Unity.ComponentExtension.GetOrAddComponent<Logic.Game.GameMusic>(target:  this.transform);
        }
        private void InitGameSound()
        {
            Logic.Game.GameManager.gameSound = Utils.Unity.ComponentExtension.GetOrAddComponent<Logic.Game.GameSound>(target:  this.transform);
        }
        private void InitGameScene()
        {
            Logic.Game.GameManager.gameScene = Utils.Unity.ComponentExtension.GetOrAddComponent<Logic.Game.GameScene>(target:  this.transform);
        }
        protected override void OnDestroy()
        {
        
        }
        private void InitLocalNotification()
        {
            Platform.Notification.LocalNotificationManager.Init();
        }
        private void InitLuid(bool isDebug)
        {
            Platform.Luid.GameLuidManager.Create(isDebug:  isDebug);
        }
        private void FaceBookStartUpLog()
        {
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if((val_1.<IsActiveUserIn7>k__BackingField) == false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_active", platform:  4);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "marketing_user", action:  "active_user", label:  "", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_active_user", platform:  2);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "grt_retention", action:  "active_user", label:  "", value:  0);
        }
        private System.Collections.IEnumerator DelayPrivacyPolicy()
        {
            typeof(GameManager.<DelayPrivacyPolicy>d__34).__il2cppRuntimeField_10 = 0;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void InitAnalytics()
        {
            Platform.Analytics.EzAnalytics.Create();
            Platform.Analytics.EzAnalytics.SessionTimes();
        }
        private void InitABTest(bool debug, string luid)
        {
            Platform.AbTest.GameABTestManager.Init(isDebug:  debug, luid:  luid);
        }
        private void InitPropertyOfAbTest()
        {
            Platform.Analytics.EzAnalytics.SetPropertyOfAbTest();
        }
        private void InitAd()
        {
            Platform.Ad.GameAdManager.Create(isDebug:  false, isDebugConfig:  false);
        }
        private void OnApplicationPause(bool pauseStatus)
        {
            if(this._hasInit == false)
            {
                    return;
            }
            
            if(pauseStatus != true)
            {
                    View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_1._bibleGameState == 3)
            {
                    Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if((val_2.<IsGameComplete>k__BackingField) != false)
            {
                    bool val_3 = Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "MainBibleBookTestDialog");
            }
            
            }
            
            }
            
            Logic.Game.GameManager.gameMusic.Pause(pause:  pauseStatus);
            if(pauseStatus != false)
            {
                    Store.StoreManager.FileName.Save();
                Platform.Notification.NotificationUtil.ScheduleAllNotify();
                System.DateTime val_6 = System.DateTime.Now;
                Common.Singleton<Data.Login.LoginDataManager>.Instance.SetLastPauseTime(dateTime:  new System.DateTime() {dateData = val_6.dateData});
                return;
            }
            
            Platform.Notification.NotificationUtil.CleanAllNotification();
            Locale.LocaleManager.UpdateCurLanguageCode();
        }
        private void OnApplicationQuit()
        {
            if(Store.StoreManager.FileName == null)
            {
                    return;
            }
            
            Store.StoreManager.FileName.Save();
        }
        public void StartDelegateCoroutine(System.Collections.IEnumerator coroutine)
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  coroutine);
        }
        private void Update()
        {
            Common.TimerEvent.Update();
        }
        public GameManager()
        {
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  0f, y:  0f, width:  0f, height:  0f);
            this.attRect = val_1.m_XMin;
        }
    
    }

}
