using UnityEngine;

namespace View.Controller
{
    public class MainController : SingletonController<View.Controller.MainController>
    {
        // Fields
        private UnityEngine.Canvas _gameCanvas;
        private UnityEngine.UI.GraphicRaycaster _gameRaycaster;
        private View.Game.BibleViews _bibleViews;
        private Logic.Define.GameState _bibleGameState;
        private Logic.Define.GameState _lastGameState;
        private bool _isShowLoading;
        
        // Properties
        public Logic.Define.GameState BibleGameState { get; set; }
        public Logic.Define.GameState LastGameState { get; }
        
        // Methods
        public void set_BibleGameState(Logic.Define.GameState value)
        {
            this._bibleGameState = value;
            this._lastGameState = this._bibleGameState;
        }
        public Logic.Define.GameState get_BibleGameState()
        {
            return (Logic.Define.GameState)this._bibleGameState;
        }
        public Logic.Define.GameState get_LastGameState()
        {
            return (Logic.Define.GameState)this._lastGameState;
        }
        public void Init()
        {
            this._gameCanvas = UnityEngine.GameObject.Find(name:  "GameCanvas").GetComponent<UnityEngine.Canvas>();
            this._gameRaycaster = UnityEngine.GameObject.Find(name:  "GameCanvas").GetComponent<UnityEngine.UI.GraphicRaycaster>();
            this._bibleViews = Utils.Extensions.GameObjectExtension.GetOrAddComponent<View.Game.BibleViews>(target:  UnityEngine.GameObject.Find(name:  "BibleViews"));
        }
        public void SetGameCanvasVisible(bool isVisible)
        {
            bool val_1 = isVisible;
            this._gameCanvas.enabled = val_1;
            this._gameRaycaster.enabled = val_1;
        }
        public void ShowLoading()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            val_1._bibleGameState = 1;
            val_1._lastGameState = val_1._bibleGameState;
            if((System.String.op_Inequality(a:  Logic.Game.GameManager.gameScene.CurrentSceneName, b:  "Game")) != false)
            {
                    Logic.Game.GameManager.gameScene.LoadScene(name:  "Game", useLoadingScreen:  false, callBack:  new System.Action(object:  this, method:  System.Void View.Controller.MainController::<ShowLoading>b__14_0()));
                return;
            }
            
            this._bibleViews.OnOpenLoadingView();
            this._isShowLoading = true;
        }
        public void OpenGame(Logic.Define.OpenGameFrom gameFrom = 1)
        {
            object val_1 = new System.Object();
            typeof(MainController.<>c__DisplayClass15_0).__il2cppRuntimeField_10 = this;
            typeof(MainController.<>c__DisplayClass15_0).__il2cppRuntimeField_18 = gameFrom;
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            val_2._bibleGameState = 3;
            val_2._lastGameState = val_2._bibleGameState;
            if((System.String.op_Inequality(a:  mem[7241314862805].CurrentSceneName, b:  "Game")) != false)
            {
                    mem[7241314862805].LoadScene(name:  "Game", useLoadingScreen:  true, callBack:  new System.Action(object:  val_1, method:  System.Void MainController.<>c__DisplayClass15_0::<OpenGame>b__0()));
                return;
            }
            
            if(((gameFrom - 1)) <= 2)
            {
                    mem[7241314862805].DoAnimation(closeFinishAction:  new System.Action(object:  val_1, method:  System.Void MainController.<>c__DisplayClass15_0::<OpenGame>b__1()));
                return;
            }
            
            Message.Messager.Dispatch(cmd:  97);
            this._bibleViews.OnOpenGameView(gameFrom:  typeof(MainController.<>c__DisplayClass15_0).__il2cppRuntimeField_18);
        }
        public void OpenHome(Logic.Define.OpenHomeFrom homeFrom = 3)
        {
            System.Action val_9;
            object val_1 = new System.Object();
            typeof(MainController.<>c__DisplayClass16_0).__il2cppRuntimeField_10 = this;
            typeof(MainController.<>c__DisplayClass16_0).__il2cppRuntimeField_18 = homeFrom;
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            val_2._bibleGameState = 2;
            val_2._lastGameState = val_2._bibleGameState;
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._lastGameState == 3)
            {
                    typeof(MainController.<>c__DisplayClass16_0).__il2cppRuntimeField_18 = 2;
            }
            
            val_9 = 1152921504818933760;
            if((System.String.op_Inequality(a:  Logic.Game.GameManager.gameScene.CurrentSceneName, b:  "Game")) != false)
            {
                    System.Action val_6 = null;
                val_9 = val_6;
                val_6 = new System.Action(object:  val_1, method:  System.Void MainController.<>c__DisplayClass16_0::<OpenHome>b__0());
                Logic.Game.GameManager.gameScene.LoadScene(name:  "Game", useLoadingScreen:  ((typeof(MainController.<>c__DisplayClass16_0).__il2cppRuntimeField_18) == 3) ? 1 : 0, callBack:  val_9);
            }
            else
            {
                    System.Action val_8 = null;
                val_9 = val_8;
                val_8 = new System.Action(object:  val_1, method:  System.Void MainController.<>c__DisplayClass16_0::<OpenHome>b__1());
                Logic.Game.GameManager.gameScene.DoAnimation(closeFinishAction:  val_9);
            }
            
            Store.StoreManager.FileName.Save();
        }
        public void OpenDailyPrayer(Logic.Define.OpenDailyPrayerFrom dailyPrayerFrom = 1)
        {
            typeof(MainController.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = this;
            typeof(MainController.<>c__DisplayClass17_0).__il2cppRuntimeField_18 = dailyPrayerFrom;
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            val_2._bibleGameState = 4;
            val_2._lastGameState = val_2._bibleGameState;
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._lastGameState == 2)
            {
                    typeof(MainController.<>c__DisplayClass17_0).__il2cppRuntimeField_18 = 0;
            }
            
            if((System.String.op_Inequality(a:  Logic.Game.GameManager.gameScene.CurrentSceneName, b:  "Game")) != false)
            {
                    Logic.Game.GameManager.gameScene.LoadScene(name:  "Game", useLoadingScreen:  true, callBack:  new System.Action(object:  new System.Object(), method:  System.Void MainController.<>c__DisplayClass17_0::<OpenDailyPrayer>b__0()));
                return;
            }
            
            Message.Messager.Dispatch(cmd:  97);
            this._bibleViews.OnOpenDailyPrayerView(dailyPrayerFrom:  typeof(MainController.<>c__DisplayClass17_0).__il2cppRuntimeField_18);
        }
        public void InitAssets()
        {
            var val_3;
            var val_4;
            if(this._isShowLoading != true)
            {
                    this._bibleViews.OnOpenLoadingView();
                this._isShowLoading = true;
            }
            
            val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            Platform.Analytics.EzAnalytics.SendScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = ScrShow.ScrNameEnum.ScrNameLoadScr}, source:  new SourceEnum() {<Value>k__BackingField = ScrShow.SourceEnum.SourceAppStart});
            UnityEngine.Coroutine val_2 = public static Logic.Game.GameManager Common.MonoSingleton<Logic.Game.GameManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.StartCoroutine(routine:  this.StarInitAssets());
        }
        private System.Collections.IEnumerator StarInitAssets()
        {
            typeof(MainController.<StarInitAssets>d__19).__il2cppRuntimeField_10 = 0;
            typeof(MainController.<StarInitAssets>d__19).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void InitGame()
        {
            string val_6;
            Common.Singleton<Logic.Treasure.TreasureController>.Instance.InitMissionData();
            Data.Login.LoginDataManager val_2 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            if((val_2.<ShouldLogPrepareCreate>k__BackingField) == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName())) != false)
            {
                    val_6 = "allpass";
            }
            else
            {
                    val_6 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_prepare", action:  "a0_game_prepare_create", label:  val_6, value:  0);
        }
        private void GameLoadingEnd()
        {
            var val_11;
            var val_12;
            this.LogStartUpUserStatus();
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.CoinTemp) > (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin))
            {
                    Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetCoin(value:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.CoinTemp);
                Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetCoinTemp(value:  0);
            }
            
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide()) != false)
            {
                    this.OpenGame(gameFrom:  4);
                return;
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = null;
            val_12 = null;
            Platform.Analytics.EzAnalytics.SendScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = ScrShow.ScrNameEnum.ScrNameHomeScr}, source:  new SourceEnum() {<Value>k__BackingField = ScrShow.SourceEnum.SourceAppStart});
            Logic.Game.GameManager.gameSound.Play(clipName:  "eff_splash_to_home", volumeScale:  1f, loop:  false, delay:  0f);
            this.OpenHome(homeFrom:  0);
        }
        private void LogStartUpUserStatus()
        {
            Platform.Analytics.EzAnalytics.SendUserRecord();
            Data.Login.LoginDataManager val_1 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            Platform.Analytics.AnalyzerUStatus.InstallDays(days:  val_1._userInstallDays);
            Platform.Analytics.AnalyzerUStatus.OpenDays(days:  Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginDays);
            Platform.Analytics.AnalyzerUStatus.CurrentCurrency(count:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin);
            Platform.Analytics.AnalyzerUStatus.CurrentLevel(chapter:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) + 1, index:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) + 1);
            Platform.Analytics.AnalyzerUStatus.Purchased(value:  ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UserPay) > 0f) ? 1 : 0);
            Platform.Analytics.AnalyzerUStatus.RemoveAds(value:  Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "network", action:  "status", label:  (Common.EzNetwork.IsNetworkAvailable() != true) ? "yes" : "no", value:  0);
            float val_26 = 1000f;
            val_26 = (float)UnityEngine.SystemInfo.systemMemorySize / val_26;
            Platform.Analytics.AnalyzerUStatus.PhoneInfo(info:  UnityEngine.Mathf.CeilToInt(f:  val_26).ToString());
            char[] val_24 = new char[1];
            val_24[0] = '/';
            if(val_25.Length == 0)
            {
                    return;
            }
            
            Platform.Analytics.AnalyzerUStatus.PhoneInfo(info:  UnityEngine.SystemInfo.operatingSystem.Split(separator:  val_24)[0]);
        }
        public MainController()
        {
        
        }
        private void <ShowLoading>b__14_0()
        {
            if(this._isShowLoading == true)
            {
                    return;
            }
            
            this._bibleViews.OnOpenLoadingView();
            this._isShowLoading = true;
        }
    
    }

}
