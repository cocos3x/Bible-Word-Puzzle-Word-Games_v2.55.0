using UnityEngine;

namespace Platform.Analytics
{
    public class EzAnalytics
    {
        // Fields
        private static Platform.Analytics.EzAnalytics <Instance>k__BackingField;
        private static bool _dependencyReady;
        private static bool _hasSampleInit;
        private bool _isDependencyStatus;
        private string _luid;
        private string _firebaseAppName;
        private Platform.Analytics.AfData _afData;
        private bool _afDataHasSuccessCallback;
        private System.Action<Platform.Analytics.AfData> _afDataCallback;
        
        // Properties
        public static Platform.Analytics.EzAnalytics Instance { get; set; }
        
        // Methods
        public static Platform.Analytics.EzAnalytics get_Instance()
        {
            return (Platform.Analytics.EzAnalytics)Platform.Analytics.EzAnalytics.<Instance>k__BackingField;
        }
        private static void set_Instance(Platform.Analytics.EzAnalytics value)
        {
            Platform.Analytics.EzAnalytics.<Instance>k__BackingField = value;
        }
        public static void Create()
        {
            Platform.Analytics.EzAnalytics.<Instance>k__BackingField = new System.Object();
            Init();
        }
        private static void SampleInit()
        {
            if(Platform.Analytics.EzAnalytics._hasSampleInit != false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics._hasSampleInit = true;
            UnityAnalytics.AnalyticsSettings val_2 = SetDebug(value:  false);
            UnityAnalytics.AnalyticsSettings val_3 = SetProductionId(value:  Platform.PlatformDefine.<ProductionId>k__BackingField);
            UnityAnalytics.AnalyticsSettings val_5 = SetVersion(value:  UnityEngine.Application.version);
            UnityAnalytics.AnalyticsSettings val_6 = SetDefaultConfigPath(value:  "Config/Analyze/AnalyzeConfigAndroid");
            UnityAnalytics.AnalyticsSettings val_7 = EnableController(value:  true);
            UnityAnalytics.GameAnalytics.Init(settings:  new UnityAnalytics.AnalyticsSettings());
        }
        public void Init()
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            this.InitAppsFlyer();
            this.InitFirebase();
            this.InitFacebook();
            Platform.Luid.GameLuidManager.<Instance>k__BackingField.GetLuid(callback:  new System.Action<System.String>(object:  this, method:  System.Void Platform.Analytics.EzAnalytics::LuidCallback(string luid)));
            Platform.Analytics.EzAnalytics.SetUuid();
            UnityAnalytics.AFConversionDataListener.SetListener(action:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  this, method:  System.Void Platform.Analytics.EzAnalytics::OnAfDataSuccess(System.Collections.Generic.Dictionary<string, object> dic)), failAction:  new System.Action<System.String>(object:  this, method:  System.Void Platform.Analytics.EzAnalytics::OnAfDataFail(string info)));
            UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  this, method:  System.Void Platform.Analytics.EzAnalytics::OnReceiveLogMessage(string condition, string stackTrace, UnityEngine.LogType type)));
        }
        public static void SendEvent(string eventName, System.Collections.Generic.Dictionary<string, object> args, UnityAnalytics.AnalyticsPlatform platform = 4)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  eventName, paramsDict:  args, platform:  platform);
        }
        public static void SendEvent(UnityAnalytics.IAnalyticsBundle bundle)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  bundle);
        }
        public static void LogEvent(string category, string action, string label = "", long value = -1)
        {
            string val_11;
            System.Collections.Generic.IEnumerable<TSource> val_4 = ((System.String.IsNullOrWhiteSpace(value:  label)) != true) ? "null" : label;
            string val_5 = ((System.String.IsNullOrWhiteSpace(value:  action)) != true) ? "null" : action.Replace(oldValue:  "-", newValue:  "_");
            if((System.Linq.Enumerable.Any<System.Char>(source:  val_4)) != false)
            {
                    val_11 = val_4.Replace(oldValue:  "-", newValue:  "_");
            }
            
            if(value != 1)
            {
                    Add(key:  val_11, value:  value);
                Platform.Analytics.EzAnalytics.SampleInit();
                UnityAnalytics.GameAnalytics.SendEvent(eventName:  category + "_" + val_5, paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  4);
                return;
            }
            
            Add(key:  val_5, value:  val_11);
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  category, paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  4);
        }
        public static void LogEvent(string eventName, string parameterName, long parameterValue)
        {
            Add(key:  ((System.String.IsNullOrWhiteSpace(value:  parameterName)) != true) ? "null" : parameterName.Replace(oldValue:  "-", newValue:  "_"), value:  parameterValue);
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  eventName.Replace(oldValue:  "-", newValue:  "_"), paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  4);
        }
        public static void LogEvent(string eventName, UnityAnalytics.AnalyticsPlatform platform = 4)
        {
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  eventName, eventValues:  0, platform:  platform);
        }
        public static void LogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> eventValues, UnityAnalytics.AnalyticsPlatform platform = 4)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_6 = eventValues;
            if(val_6 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
            label_5:
            if(0.MoveNext() == false)
            {
                goto label_3;
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(key:  0, value:  0);
            goto label_5;
            label_3:
            0.Dispose();
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  eventName, paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  Count), platform:  platform);
        }
        private void InitAppsFlyer()
        {
            UnityAnalytics.GameAnalytics.SetAppId(appId:  Platform.PlatformDefine.<AppId>k__BackingField);
            UnityAnalytics.GameAnalytics.SetAppsflyerDevKey(devKey:  "qNsTSFixbaPufCv5sQ6yJV");
            UnityAnalytics.GameAnalytics.InstallPlatform(platform:  1);
        }
        private void InitFacebook()
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    Platform.Analytics.EzAnalytics.OnFaceBookInited();
                return;
            }
            
            Facebook.Unity.FB.Init(onInitComplete:  new Facebook.Unity.InitDelegate(object:  0, method:  static System.Void Platform.Analytics.EzAnalytics::FBInitCallback()), onHideUnity:  new Facebook.Unity.HideUnityDelegate(object:  0, method:  static System.Void Platform.Analytics.EzAnalytics::OnHideUnity(bool isGameShown)), authResponse:  0);
        }
        private static void OnFaceBookInited()
        {
            Facebook.Unity.FB.ActivateApp();
            bool val_1 = FB.Mobile.SetAdvertiserTrackingEnabled(advertiserTrackingEnabled:  true);
            UnityAnalytics.GameAnalytics.InstallPlatform(platform:  2);
        }
        private static void FBInitCallback()
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    Platform.Analytics.EzAnalytics.OnFaceBookInited();
                return;
            }
            
            UnityEngine.Debug.Log(message:  "Failed to Initialize the Facebook SDK");
        }
        private static void OnHideUnity(bool isGameShown)
        {
        
        }
        private void InitFirebase()
        {
            UnityAnalytics.GameAnalytics.InstallPlatform(platform:  4);
            this._isDependencyStatus = false;
            System.Threading.Tasks.Task val_3 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction:  new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  this, method:  System.Void Platform.Analytics.EzAnalytics::<InitFirebase>b__38_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)));
        }
        private void SetLuidForCrashlytics()
        {
            if(this._isDependencyStatus == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this._luid)) != false)
            {
                    return;
            }
            
            Firebase.Crashlytics.Crashlytics.SetUserId(identifier:  this._luid);
        }
        private void OnReceiveLogMessage(string condition, string stackTrace, UnityEngine.LogType type)
        {
            string val_3 = stackTrace;
            if(type != 0)
            {
                    return;
            }
            
            if(this._isDependencyStatus == false)
            {
                    return;
            }
            
            val_3 = condition + "-"("-") + val_3;
            Firebase.Crashlytics.Crashlytics.LogException(exception:  new System.Exception(message:  val_3));
        }
        private void LuidCallback(string luid)
        {
            this._luid = luid;
            UnityAnalytics.GameAnalytics.SetUserId(id:  luid, platform:  4);
            this.SetLuidForCrashlytics();
        }
        private static void SetUuid()
        {
            UnityAnalytics.GameAnalytics.SetUserId(id:  Luid.LuidManager._currentUuid, platform:  1);
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SetUserProperty(name:  "client_uuid", value:  Luid.LuidManager._currentUuid, platform:  7);
        }
        public Platform.Analytics.AfData GetAfData()
        {
            Platform.Analytics.AfData val_2;
            var val_3;
            val_2 = this._afData;
            if(val_2 != null)
            {
                    return val_1;
            }
            
            val_3 = null;
            val_3 = null;
            Platform.Analytics.AfData val_1 = Platform.Analytics.EzAnalytics.UpdateAfData(dic:  UnityAnalytics.AFConversionDataListener._savedData);
            this._afData = val_1;
            return val_1;
        }
        private static Platform.Analytics.AfData UpdateAfData(System.Collections.Generic.Dictionary<string, object> dic)
        {
            int val_9;
            int val_10;
            int val_11;
            object val_2 = 0;
            object val_6 = 0;
            object val_4 = 0;
            if(dic == null)
            {
                    return (Platform.Analytics.AfData)new System.Object();
            }
            
            bool val_3 = dic.TryGetValue(key:  "af_status", value: out  val_2);
            bool val_5 = dic.TryGetValue(key:  "media_source", value: out  val_4);
            if((dic.TryGetValue(key:  "campaign_id", value: out  val_6)) != true)
            {
                    bool val_8 = dic.TryGetValue(key:  "af_c_id", value: out  val_6);
            }
            
            val_9 = val_2;
            if(val_9 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_4;
            }
            
            }
            
            val_9 = System.String.alignConst;
            label_4:
            typeof(Platform.Analytics.AfData).__il2cppRuntimeField_10 = val_9;
            val_10 = val_6;
            if(val_10 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_7;
            }
            
            }
            
            val_10 = System.String.alignConst;
            label_7:
            typeof(Platform.Analytics.AfData).__il2cppRuntimeField_18 = val_10;
            val_11 = val_4;
            if(val_11 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_9;
            }
            
            }
            
            val_11 = System.String.alignConst;
            label_9:
            typeof(Platform.Analytics.AfData).__il2cppRuntimeField_20 = val_11;
            return (Platform.Analytics.AfData)new System.Object();
        }
        public void GetAfDataAsync(System.Action<Platform.Analytics.AfData> callback)
        {
            if(this._afDataHasSuccessCallback != false)
            {
                    if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  this._afData);
                return;
            }
            
            if(callback == null)
            {
                    return;
            }
            
            System.Delegate val_1 = System.Delegate.Combine(a:  this._afDataCallback, b:  callback);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_5;
            }
            
            }
            
            this._afDataCallback = val_1;
            return;
            label_5:
        }
        private void OnAfDataSuccess(System.Collections.Generic.Dictionary<string, object> dic)
        {
            this._afDataHasSuccessCallback = true;
            Platform.Analytics.AfData val_1 = Platform.Analytics.EzAnalytics.UpdateAfData(dic:  dic);
            this._afData = val_1;
            if(this._afDataCallback != null)
            {
                    this._afDataCallback.Invoke(obj:  val_1);
            }
            
            this._afDataCallback = 0;
        }
        private void OnAfDataFail(string info)
        {
            var val_2;
            System.Action<System.String> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = EzAnalytics.<>c.<>9__47_0;
            if(val_4 == null)
            {
                    System.Action<System.String> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Action<System.String>(object:  EzAnalytics.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EzAnalytics.<>c::<OnAfDataFail>b__47_0(string luid));
                EzAnalytics.<>c.<>9__47_0 = val_4;
            }
            
            Platform.Luid.GameLuidManager.<Instance>k__BackingField.GetLuid(callback:  val_4);
        }
        public static void SetPropertyOfAbTest()
        {
            var val_3;
            var val_4;
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SetUserProperty(name:  "abTestGroupId", value:  Platform.AbTest.GameABTestManager.GetId(), platform:  4);
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SetUserProperty(name:  "abTestLanguage", value:  Util.ABTestLocalHelper.GetLanguage(), platform:  4);
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SetUserProperty(name:  "abTestTag", value:  Platform.AbTest.GameABTestManager._abTestTag, platform:  4);
            val_4 = null;
            val_4 = null;
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SetUserProperty(name:  "abTestTagPlus", value:  Platform.AbTest.GameABTestManager._abTestTagPlus, platform:  4);
        }
        public static void SetUserProperty(string key, string value, UnityAnalytics.AnalyticsPlatform platform = 4)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SetUserProperty(name:  key, value:  value, platform:  platform);
        }
        public static void SendPushClick(string pushId, string pushTime)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  pushId);
        }
        public static void SendUserRecord()
        {
            var val_17;
            var val_18;
            UserRecord.PurHistoryEnum val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            UserRecord.MusicStateEnum val_27;
            var val_28;
            var val_29;
            var val_30;
            UserRecord.SoundStateEnum val_31;
            var val_32;
            var val_33;
            var val_34;
            UserRecord.NetStateEnum val_35;
            var val_36;
            string val_1 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            string val_4 = System.String.Format(format:  "coin_{0}", arg0:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin);
            val_17 = null;
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyAnyItem) != false)
            {
                    val_18 = null;
            }
            else
            {
                    val_20 = null;
                val_19 = 1152921504831770632;
            }
            
            val_21 = null;
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) != false)
            {
                    val_22 = null;
                val_23 = 1152921504831823880;
            }
            else
            {
                    val_24 = null;
            }
            
            val_25 = null;
            if((Common.Singleton<Data.Settings.SettingsDataManager>.Instance.IsMusicOn) != false)
            {
                    val_26 = null;
            }
            else
            {
                    val_28 = null;
                val_27 = 1152921504831877128;
            }
            
            val_29 = null;
            if((Common.Singleton<Data.Settings.SettingsDataManager>.Instance.IsSoundOn) != false)
            {
                    val_30 = null;
            }
            else
            {
                    val_32 = null;
                val_31 = 1152921504831930376;
            }
            
            val_33 = null;
            if(Common.EzNetwork.IsNetworkAvailable() != false)
            {
                    val_34 = null;
            }
            else
            {
                    val_36 = null;
                val_35 = 1152921504831983624;
            }
            
            float val_17 = 1000f;
            val_17 = (float)UnityEngine.SystemInfo.systemMemorySize / val_17;
            string val_16 = System.String.Format(format:  "device_{0}", arg0:  UnityEngine.Mathf.CeilToInt(f:  val_17));
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  val_19);
        }
        public static void SendScrShow(Platform.Analyze.ScrShow.ScrNameEnum scrName, Platform.Analyze.ScrShow.SourceEnum source)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  source.<Value>k__BackingField);
        }
        public static void SendGameScrShow(Platform.Analyze.GameScrShow.ScrNameEnum scrName, string curLevel, Platform.Analyze.GameScrShow.SourceEnum source)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  scrName.<Value>k__BackingField);
        }
        public static void SendActivScrShow(Platform.Analyze.ActivScrShow.ScrNameEnum scrName, Platform.Analyze.ActivScrShow.SourceEnum source)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  scrName.<Value>k__BackingField);
        }
        public static void SendDlgShow(Platform.Analyze.DlgShow.DlgNameEnum dlgName, Platform.Analyze.DlgShow.TimingEnum timing)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState == 2)
            {
                    val_4 = null;
                val_4 = null;
                val_5 = 1152921504829427736;
            }
            else
            {
                    View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_2._bibleGameState == 3)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = 1152921504829427720;
            }
            else
            {
                    View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_3._bibleGameState != 4)
            {
                goto label_15;
            }
            
                val_7 = null;
                val_7 = null;
            }
            
            }
            
            label_15:
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  DlgShow.SourceEnum.__il2cppRuntimeField_static_fields);
        }
        public static void SendBtnClick(Platform.Analyze.BtnClick.BtnNameEnum btnName, Platform.Analyze.BtnClick.SourceEnum source)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  source.<Value>k__BackingField);
        }
        public static void SendBtnClick(Platform.Analyze.BtnClick.BtnNameEnum btnName, Platform.Analyze.BtnClick.SourceEnum source, string adShowId, Platform.Analyze.BtnClick.PlacementTypeEnum placementType, Platform.Analyze.BtnClick.PositionEnum position)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            if((placementType.<Value>k__BackingField.Equals(obj:  BtnClick.PlacementTypeEnum.PlacementTypeInterstitial)) != false)
            {
                    val_4 = null;
                val_5 = 1152921504829747208;
            }
            else
            {
                    val_6 = null;
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  source.<Value>k__BackingField);
        }
        public static void SendBtnShow(Platform.Analyze.BtnShow.BtnNameEnum btnName, Platform.Analyze.BtnShow.SourceEnum source, string adShowId, Platform.Analyze.BtnShow.PlacementTypeEnum placementType, Platform.Analyze.BtnShow.PositionEnum position)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            if((placementType.<Value>k__BackingField.Equals(obj:  BtnShow.PlacementTypeEnum.PlacementTypeInterstitial)) != false)
            {
                    val_4 = null;
                val_5 = 1152921504829960200;
            }
            else
            {
                    val_6 = null;
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  adShowId);
        }
        public static void SendGameBtnClick(Platform.Analyze.GameBtnClick.BtnNameEnum btnName, string levelName = "")
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState == 4)
            {
                    val_8 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyLevel();
                val_9 = null;
                val_9 = null;
            }
            else
            {
                    View.Controller.MainController val_4 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_4._bibleGameState == 3)
            {
                    val_8 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
                val_11 = null;
                val_11 = null;
                val_10 = 1152921504831504392;
            }
            else
            {
                    val_12 = 0;
                val_8 = 0;
            }
            
            }
            
            var val_7 = ((System.String.IsNullOrEmpty(value:  levelName)) != true) ? (val_8) : levelName;
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  btnName.<Value>k__BackingField);
        }
        public static void SendActivBtnClick(Platform.Analyze.ActivBtnClick.BtnNameEnum btnName, Platform.Analyze.ActivBtnClick.SourceEnum source)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  btnName.<Value>k__BackingField);
        }
        public static void SendIapDlgShow(string name)
        {
            var val_4;
            var val_5;
            IapDlgShow.SourceEnum val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = null;
            val_4 = null;
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState == 2)
            {
                    val_5 = null;
                val_5 = null;
                val_6 = 1152921504831344656;
            }
            else
            {
                    View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
                val_7 = null;
                if(val_3._bibleGameState == 4)
            {
                    val_8 = null;
            }
            else
            {
                    val_9 = null;
                val_6 = 1152921504831344648;
            }
            
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  name + "_sale_dlg");
        }
        public static void SendIapItemClick(string name, Platform.Analyze.IapItemClick.SourceEnum source)
        {
            string val_1 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  name);
        }
        public static void SendIapItemPurchase(string name, string purResult)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            string val_1 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            val_3 = null;
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "ShopActivityDialog")) != false)
            {
                    val_4 = null;
                val_5 = 1152921504831078408;
            }
            else
            {
                    val_6 = null;
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  name);
        }
        public static void SendLevelClearRecord(int time)
        {
            var val_36;
            LevelClearRecord.SourceEnum val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            int val_44;
            var val_45;
            var val_46;
            string val_3 = System.String.Format(format:  "coin_{0}", arg0:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin);
            System.Collections.Generic.List<System.String> val_5 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.GetWords();
            string val_6 = public static Data.ExtraWord.ExtraWordDataManager Common.Singleton<Data.ExtraWord.ExtraWordDataManager>::get_Instance().ToString();
            string val_7 = time.ToString();
            View.Controller.MainController val_8 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_8._bibleGameState != 4)
            {
                goto label_5;
            }
            
            val_36 = null;
            val_36 = null;
            val_37 = LevelClearRecord.SourceEnum.SourceDcScr;
            val_38 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyLevel();
            Logic.DailyPrayer.DailyPrayerControllers val_11 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_39 = val_11.<NowCurLevelUseHintCount>k__BackingField.ToString();
            Logic.DailyPrayer.DailyPrayerControllers val_13 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_40 = val_13.<NowCurLevelUseRefreshCount>k__BackingField.ToString();
            Logic.DailyPrayer.DailyPrayerControllers val_15 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_41 = val_15.<NowCurLevelUseFireworkCount>k__BackingField.ToString();
            View.Dialog.ShopTest.Controller.ShopController val_17 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_42 = val_17.<NowCurLevelPurchaseCount>k__BackingField.ToString();
            Logic.DailyPrayer.DailyPrayerControllers val_19 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_43 = val_19.<NowCurLevelWrongCount>k__BackingField.ToString();
            Logic.DailyPrayer.DailyPrayerControllers val_21 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_44 = val_21.<NowCurLevelMaxComboCount>k__BackingField;
            goto label_15;
            label_5:
            View.Controller.MainController val_22 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_22._bibleGameState != 3)
            {
                goto label_17;
            }
            
            val_45 = null;
            val_45 = null;
            val_37 = LevelClearRecord.SourceEnum.SourceMgScr;
            val_38 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            Logic.Game.GameControllers val_24 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_39 = val_24.<NowCurLevelUseHintCount>k__BackingField.ToString();
            Logic.Game.GameControllers val_26 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_40 = val_26.<NowCurLevelUseRefreshCount>k__BackingField.ToString();
            Logic.Game.GameControllers val_28 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_41 = val_28.<NowCurLevelUseFireworkCount>k__BackingField.ToString();
            View.Dialog.ShopTest.Controller.ShopController val_30 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_42 = val_30.<NowCurLevelPurchaseCount>k__BackingField.ToString();
            Logic.Game.GameControllers val_32 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_43 = val_32.<NowCurLevelWrongCount>k__BackingField.ToString();
            Logic.Game.GameControllers val_34 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_44 = val_34.<NowCurLevelMaxComboCount>k__BackingField;
            label_15:
            string val_35 = val_44.ToString();
            goto label_27;
            label_17:
            val_46 = 0;
            val_43 = 0;
            val_42 = 0;
            val_41 = 0;
            val_40 = 0;
            val_39 = 0;
            val_38 = 0;
            val_37 = 0;
            label_27:
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  val_37);
        }
        public static void SendComboShow(Platform.Analyze.ComboShow.ComboTypeEnum comboType, int comboNum)
        {
            var val_7;
            ComboShow.SourceEnum val_8;
            var val_9;
            string val_1 = comboNum.ToString();
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState == 4)
            {
                    val_7 = null;
                val_7 = null;
                val_8 = ComboShow.SourceEnum.SourceDcScr;
                string val_4 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyLevel();
            }
            else
            {
                    View.Controller.MainController val_5 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_5._bibleGameState == 3)
            {
                    val_8 = ComboShow.SourceEnum.SourceMgScr;
                string val_6 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            }
            else
            {
                    val_8 = 0;
                val_9 = 0;
            }
            
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  val_8);
        }
        public static void SendQuizRecord(string curLevel, Platform.Analyze.QuizRecord.AnswerStateEnum answerState)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  answerState.<Value>k__BackingField);
        }
        public static void SendPropUse(Platform.Analyze.PropUse.PropNameEnum propName)
        {
            var val_9;
            PropUse.SourceEnum val_10;
            var val_11;
            string val_3 = System.String.Format(format:  "coin_{0}", arg0:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin);
            View.Controller.MainController val_4 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_4._bibleGameState == 4)
            {
                    val_9 = null;
                val_9 = null;
                val_10 = PropUse.SourceEnum.SourceDcScr;
                string val_6 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyLevel();
            }
            else
            {
                    View.Controller.MainController val_7 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_7._bibleGameState == 3)
            {
                    val_10 = PropUse.SourceEnum.SourceMgScr;
                string val_8 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            }
            else
            {
                    val_10 = 0;
                val_11 = 0;
            }
            
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  val_10);
        }
        public static void SendCalendarRewardGain(Platform.Analyze.CalendarRewardGain.RewardIndexEnum rewardIndex)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  rewardIndex.<Value>k__BackingField);
        }
        public static void SendLevelContentLoad(Platform.Analyze.LevelContentLoad.StateEnum state)
        {
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  state.<Value>k__BackingField);
        }
        public static void SendAdShowTiming(string adPosition, Platform.Analyze.AdShowTiming.PlacementTypeEnum placementType, Platform.Analyze.AdShowTiming.PositionEnum position)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            Common.Singleton<Platform.Ad.AdShowId>.Instance.UpdateAdShowId(position:  adPosition);
            val_5 = null;
            val_5 = null;
            val_6 = null;
            if((placementType.<Value>k__BackingField.Equals(obj:  AdShowTiming.PlacementTypeEnum.PlacementTypeInterstitial)) != false)
            {
                    val_7 = null;
                val_8 = 1152921504828841992;
            }
            else
            {
                    val_9 = null;
            }
            
            Platform.Analytics.EzAnalytics.SampleInit();
            UnityAnalytics.GameAnalytics.SendEvent(bundle:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  adPosition));
        }
        public static void DailyRewardFirstTime()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays == 1)
            {
                    if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.DailyLotteryCount) == 1)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = null;
                val_10 = val_4;
                val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                set_Item(key:  "fb_content_id", value:  "1");
                set_Item(key:  "fb_level", value:  "1");
                UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_level_achieved -- "("[UAC]:fb_mobile_level_achieved -- ") + "1");
                UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_level_achieved", paramsDict:  val_10, platform:  2);
                Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_daily_reward_1time_1d_us");
            }
            
            }
            
            Data.Login.LoginDataManager val_6 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_6._userInstallDays > 3)
            {
                    return;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.DailyLotteryCount) != 3)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_rate ");
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_rate", paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  2);
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_7r_daily_reward_3time_3d_us");
        }
        public static void ExtraWordsTimers()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays == 1)
            {
                    if(Data.ExtraWordData.ExtraWordDataMngr.GetTotalProgress() == 6)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
                val_9 = val_3;
                val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_add_to_cart");
                UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_add_to_cart", paramsDict:  val_9, platform:  2);
                Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_extra_words_6times_1d_us");
            }
            
            }
            
            Data.Login.LoginDataManager val_4 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_4._userInstallDays <= 3)
            {
                    if(Data.ExtraWordData.ExtraWordDataMngr.GetTotalProgress() == 20)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = null;
                val_9 = val_6;
                val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_tutorial_completion");
                UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_tutorial_completion", paramsDict:  val_9, platform:  2);
                Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_7r_extra_words_20times_3d_us");
            }
            
            }
            
            if(Data.ExtraWordData.ExtraWordDataMngr.GetTotalProgress() < 1)
            {
                    return;
            }
            
            int val_8 = Data.ExtraWordData.ExtraWordDataMngr.GetTotalProgress();
            if(0 != 0)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_extra_words_6times_every_us");
        }
        public static void CombosTimes()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays == 1)
            {
                    if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.GetCombos()) == 18)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = null;
                val_9 = val_4;
                val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_add_to_wishlist ");
                UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_add_to_wishlist", paramsDict:  val_9, platform:  2);
                Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_combos_18times_1d_us");
            }
            
            }
            
            Data.Login.LoginDataManager val_5 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_5._userInstallDays > 3)
            {
                    return;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.GetCombos()) != 180)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_search ");
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_search", paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  2);
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_7r_combos_180times_3d_us");
        }
        public static void StartLevelTimes()
        {
        
        }
        public static void HintTipsTimes()
        {
            string val_31;
            string val_32;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays != 1)
            {
                goto label_18;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 1)
            {
                goto label_4;
            }
            
            UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_complete_registration ");
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_complete_registration", paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  2);
            val_31 = "grt_1r_hint_1time_1d_us";
            goto label_16;
            label_4:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 5)
            {
                goto label_9;
            }
            
            val_31 = "grt_1r_hint_5times_1d_us";
            goto label_16;
            label_9:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 10)
            {
                goto label_12;
            }
            
            val_31 = "grt_1r_hint_10times_1d_us";
            goto label_16;
            label_12:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 20)
            {
                goto label_15;
            }
            
            val_31 = "grt_1r_hint_20times_1d_us";
            goto label_16;
            label_15:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 29)
            {
                goto label_18;
            }
            
            val_31 = "grt_1r_hint_29times_1d_us";
            label_16:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_31);
            label_18:
            Data.Login.LoginDataManager val_13 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_13._userInstallDays > 3)
            {
                goto label_33;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 24)
            {
                goto label_22;
            }
            
            val_32 = "grt_7r_hint_24times_3d_us";
            goto label_31;
            label_22:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 36)
            {
                goto label_25;
            }
            
            UnityEngine.Debug.Log(message:  "[UAC]:fb_mobile_achievement_unlocked ");
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  "fb_mobile_achievement_unlocked", paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(), platform:  2);
            val_32 = "grt_7r_hint_36times_3d_us";
            goto label_31;
            label_25:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 60)
            {
                goto label_30;
            }
            
            val_32 = "grt_7r_hint_60times_3d_us";
            goto label_31;
            label_30:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) != 18)
            {
                goto label_33;
            }
            
            val_32 = "grt_7r_hint_18times_3d_us";
            label_31:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_32);
            label_33:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) >= 1)
            {
                    if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) == 0)
            {
                    Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_hint_5times_every_us");
            }
            
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount) < 1)
            {
                    return;
            }
            
            int val_30 = Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.UseHintCount;
            if(0 != 0)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_hint_20times_every_us");
        }
        public static void SessionTimes()
        {
            string val_21;
            string val_22;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays != 1)
            {
                goto label_10;
            }
            
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 4)
            {
                goto label_4;
            }
            
            val_21 = "grt_1r_session_4times_1d_us";
            goto label_8;
            label_4:
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 5)
            {
                goto label_7;
            }
            
            val_21 = "grt_1r_session_5times_1d_us";
            goto label_8;
            label_7:
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 6)
            {
                goto label_10;
            }
            
            val_21 = "grt_1r_session_6times_1d_us";
            label_8:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_21);
            label_10:
            Data.Login.LoginDataManager val_8 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_8._userInstallDays > 3)
            {
                goto label_23;
            }
            
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 7)
            {
                goto label_14;
            }
            
            val_22 = "grt_7r_session_7times_3d_us";
            goto label_21;
            label_14:
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 9)
            {
                goto label_17;
            }
            
            val_22 = "grt_7r_session_9times_3d_us";
            goto label_21;
            label_17:
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 11)
            {
                goto label_20;
            }
            
            val_22 = "grt_7r_session_11times_3d_us";
            goto label_21;
            label_20:
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) != 14)
            {
                goto label_23;
            }
            
            val_22 = "grt_7r_session_14times_3d_us";
            label_21:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_22);
            label_23:
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount) < 1)
            {
                    return;
            }
            
            int val_20 = Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginCount;
            if(0 != 0)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_session_6times_every_us");
        }
        public static void ChapterFinishTimes()
        {
            string val_17;
            string val_18;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) != 0)
            {
                    return;
            }
            
            Data.Login.LoginDataManager val_3 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_3._userInstallDays != 1)
            {
                goto label_9;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) != 7)
            {
                goto label_6;
            }
            
            val_17 = "grt_1r_chapter_finish_7times_1d_us";
            goto label_7;
            label_6:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) != 9)
            {
                goto label_9;
            }
            
            val_17 = "grt_1r_chapter_finish_9times_1d_us";
            label_7:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_17);
            label_9:
            Data.Login.LoginDataManager val_8 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_8._userInstallDays > 3)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == 8)
            {
                    val_18 = "grt_7r_chapter_finish_8times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == 11)
            {
                    val_18 = "grt_7r_chapter_finish_11times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == 15)
            {
                    val_18 = "grt_7r_chapter_finish_15times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) != 23)
            {
                    return;
            }
            
                val_18 = "grt_7r_chapter_finish_23times_3d_us";
            }
            
            }
            
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_18);
        }
        public static void DailyShowTimes()
        {
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays != 1)
            {
                    return;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowDailyCount) != 2)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_daily_show_2times_1d_us");
        }
        public static void LevelPassVideoTimes()
        {
            string val_21;
            string val_22;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays != 1)
            {
                goto label_13;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 3)
            {
                goto label_4;
            }
            
            val_21 = "grt_1r_level_pass_video_3times_1d_us";
            goto label_11;
            label_4:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 7)
            {
                goto label_7;
            }
            
            val_21 = "grt_1r_level_pass_video_7times_1d_us";
            goto label_11;
            label_7:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 5)
            {
                goto label_10;
            }
            
            val_21 = "grt_1r_level_pass_video_5times_1d_us";
            goto label_11;
            label_10:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 2)
            {
                goto label_13;
            }
            
            val_21 = "grt_1r_level_pass_video_2times_1d_us";
            label_11:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_21);
            label_13:
            Data.Login.LoginDataManager val_10 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_10._userInstallDays > 3)
            {
                goto label_23;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 5)
            {
                goto label_17;
            }
            
            val_22 = "grt_7r_level_pass_video_5times_3d_us";
            goto label_21;
            label_17:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 8)
            {
                goto label_20;
            }
            
            val_22 = "grt_7r_level_pass_video_8times_3d_us";
            goto label_21;
            label_20:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 12)
            {
                goto label_23;
            }
            
            val_22 = "grt_7r_level_pass_video_12times_3d_us";
            label_21:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_22);
            label_23:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) < 1)
            {
                    return;
            }
            
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.ShowLevelPassVideoCount) != 0)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  "grt_1r_level_pass_video_3times_every_us");
        }
        public static void LevelPassTimes(string levelName)
        {
            string val_10;
            string val_11;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays != 1)
            {
                goto label_10;
            }
            
            if((levelName.Equals(value:  "7-2")) == false)
            {
                goto label_4;
            }
            
            val_10 = "grt_1r_level_7_2_1time_1d_us";
            goto label_9;
            label_4:
            if((levelName.Equals(value:  "9-1")) == false)
            {
                goto label_6;
            }
            
            val_10 = "grt_1r_level_9_1_1time_1d_us";
            goto label_9;
            label_6:
            if((levelName.Equals(value:  "10-1")) == false)
            {
                goto label_8;
            }
            
            val_10 = "grt_1r_level_10_1_1time_1d_us";
            goto label_9;
            label_8:
            if((levelName.Equals(value:  "12-1")) == false)
            {
                goto label_10;
            }
            
            val_10 = "grt_1r_level_12_1_1time_1d_us";
            label_9:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_10);
            label_10:
            Data.Login.LoginDataManager val_6 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_6._userInstallDays > 3)
            {
                    return;
            }
            
            if((levelName.Equals(value:  "10-5")) != false)
            {
                    val_11 = "grt_7r_level_10_5_1time_3d_us";
            }
            else
            {
                    if((levelName.Equals(value:  "12-1")) != false)
            {
                    val_11 = "grt_7r_level_12_1_1time_3d_us";
            }
            else
            {
                    if((levelName.Equals(value:  "15-1")) == false)
            {
                    return;
            }
            
                val_11 = "grt_7r_level_15_1_1time_3d_us";
            }
            
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_11);
        }
        public static void BonusWordsTimes()
        {
        
        }
        public static void FailTimes(int failCount)
        {
        
        }
        public static void LevelPassCountTimes()
        {
        
        }
        public static void FinishQuizTimes()
        {
            var val_27;
            string val_28;
            string val_29;
            val_27 = 1152921512609403200;
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_1._userInstallDays != 1)
            {
                goto label_19;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 15)
            {
                goto label_4;
            }
            
            val_28 = "grt_1r_quiz_15_times_1d_us";
            goto label_17;
            label_4:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 12)
            {
                goto label_7;
            }
            
            val_28 = "grt_1r_quiz_12_times_1d_us";
            goto label_17;
            label_7:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 10)
            {
                goto label_10;
            }
            
            val_28 = "grt_1r_quiz_10_times_1d_us";
            goto label_17;
            label_10:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 19)
            {
                goto label_13;
            }
            
            val_28 = "grt_1r_quiz_19_times_1d_us";
            goto label_17;
            label_13:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 25)
            {
                goto label_16;
            }
            
            val_28 = "grt_1r_quiz_25_times_1d_us";
            goto label_17;
            label_16:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 33)
            {
                goto label_19;
            }
            
            val_28 = "grt_1r_quiz_33_times_1d_us";
            label_17:
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_28);
            label_19:
            Data.Login.LoginDataManager val_14 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if(val_14._userInstallDays > 3)
            {
                    return;
            }
            
            val_27 = 1152921512608190960;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) == 25)
            {
                    val_29 = "grt_7r_quiz_25_times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) == 32)
            {
                    val_29 = "grt_7r_quiz_32_times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) == 40)
            {
                    val_29 = "grt_7r_quiz_40_times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) == 52)
            {
                    val_29 = "grt_7r_quiz_52_times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) == 70)
            {
                    val_29 = "grt_7r_quiz_70_times_3d_us";
            }
            else
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount) != 95)
            {
                    return;
            }
            
                val_29 = "grt_7r_quiz_95_times_3d_us";
            }
            
            }
            
            }
            
            }
            
            }
            
            Platform.Analytics.EzAnalytics.LogEventGrt(eventName:  val_29);
        }
        private static void LogEventGrt(string eventName)
        {
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.LimitFirstVersion(version:  "2.31.0")) == false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  eventName, eventValues:  0, platform:  7);
        }
        public EzAnalytics()
        {
        
        }
        private void <InitFirebase>b__38_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)
        {
            if(task.Result == 0)
            {
                    this._firebaseAppName = Firebase.FirebaseApp.DefaultInstance.Name;
                Platform.Analytics.EzAnalytics._dependencyReady = true;
            }
            
            this._isDependencyStatus = true;
            this.SetLuidForCrashlytics();
        }
    
    }

}
