using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerController : BaseController
    {
        // Fields
        public View.CommonItem.Combo.Combo comboHelper;
        public View.DailyPrayer.DailyPrayerWordContent wordContent;
        public View.DailyPrayer.DailyPrayerLetterContent letterContent;
        public UnityEngine.UI.Text TextSignProgress;
        public View.DailyPrayer.DailyPrayerDate SignDate;
        public UnityEngine.Transform dynamicParent;
        public View.DailyPrayer.DailyPrayerDoves Doves;
        private Data.DailyPrayer.DailyPrayerBean <levelBean>k__BackingField;
        private bool <isGameComplete>k__BackingField;
        public int StarNum;
        private bool _isBannerShowed;
        
        // Properties
        public Data.DailyPrayer.DailyPrayerBean levelBean { get; set; }
        public bool isGameComplete { get; set; }
        public bool isBannerShowed { get; set; }
        
        // Methods
        public static View.DailyPrayer.DailyPrayerController GetInstance()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            return 0;
        }
        public Data.DailyPrayer.DailyPrayerBean get_levelBean()
        {
            return (Data.DailyPrayer.DailyPrayerBean)this.<levelBean>k__BackingField;
        }
        public void set_levelBean(Data.DailyPrayer.DailyPrayerBean value)
        {
            this.<levelBean>k__BackingField = value;
        }
        public bool get_isGameComplete()
        {
            return (bool)this.<isGameComplete>k__BackingField;
        }
        public void set_isGameComplete(bool value)
        {
            this.<isGameComplete>k__BackingField = value;
        }
        public bool get_isBannerShowed()
        {
            return (bool)this._isBannerShowed;
        }
        public void set_isBannerShowed(bool value)
        {
            bool val_4;
            if(this.letterContent != 0)
            {
                    val_4 = value;
                this.letterContent._hasAd = val_4;
            }
            else
            {
                    val_4 = value;
            }
            
            this._isBannerShowed = val_4;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add<System.Single>(cmd:  91, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::BeginDailyPrayer(float delay)));
            Message.Messager.Add(cmd:  92, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::ClearDailyPrayerView()));
            Message.Messager.Add(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::RestartNextGame()));
            Message.Messager.Add(cmd:  74, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::ShowBanner()));
            Message.Messager.Add(cmd:  75, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::HideBanner()));
            Message.Messager.Add(cmd:  35, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::PrepareLeaveGameScene()));
            this.BeginDailyPrayer(delay:  0.45f);
        }
        protected override void OnDisable()
        {
            Message.Messager.Remove<System.Single>(cmd:  91, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::BeginDailyPrayer(float delay)));
            Message.Messager.Remove(cmd:  92, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::ClearDailyPrayerView()));
            Message.Messager.Remove(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::RestartNextGame()));
            Message.Messager.Remove(cmd:  74, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::ShowBanner()));
            Message.Messager.Remove(cmd:  75, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::HideBanner()));
            Message.Messager.Remove(cmd:  35, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::PrepareLeaveGameScene()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::InitGame()));
            Logic.DailyPrayer.DailyPrayerControllers val_8 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_8.<IsGameComplete>k__BackingField = false;
            this.DestroyAd();
        }
        private void BeginDailyPrayer(float delay)
        {
            this.ClearDailyPrayerView();
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SetDailySignDefaultRecordFromDate();
            Data.DailyPrayer.DailyPrayerBean val_2 = Logic.Game.GameManager.gameDailyPrayer.GetDailyPrayerBeanBySignDate();
            this.<levelBean>k__BackingField = val_2;
            if(val_2 == null)
            {
                    return;
            }
            
            string val_7 = System.String.Format(format:  "{0}/{1}", arg0:  (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex()) + 1, arg1:  Logic.Game.GameManager.gameDailyPrayer.GetDailyPrayerLevelCountBySignDate());
            System.DateTime val_8 = System.DateTime.Now;
            this.SignDate.UpdateSignDate();
            Logic.DailyPrayer.DailyPrayerControllers val_11 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_11.<NowCurLevelName>k__BackingField = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyLevel();
            Data.DailyRecord.DailyRecordDataManager val_14 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_14.<DailyLevel>k__BackingField = val_8.dateData.ToString(format:  "dd MMM", provider:  System.Globalization.CultureInfo.CreateSpecificCulture(name:  "en-GB"));
            Data.UserPlayer.UserPlayerDataManager val_15 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Logic.Game.GameManager.gameMusic.PlayGame(useNewMusic:  ((val_15.<CurrentLevelIndex>k__BackingField) == 0) ? 1 : 0);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::InitGame()));
            Common.TimerEvent.Add(time:  delay, callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::InitGame()), isrepeat:  false);
            this.StarNum = 0;
        }
        private void ShowSideButton()
        {
            Message.Messager.Dispatch(cmd:  52);
            Message.Messager.Dispatch(cmd:  53);
        }
        private void InitGame()
        {
            Logic.Game.GameDiglog val_34;
            object val_35;
            var val_36;
            string val_37;
            val_34 = this;
            Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.PlayLevel();
            this.wordContent._levelItem = this.<levelBean>k__BackingField;
            this.wordContent.InitWordContent();
            this.letterContent._levelItem = this.<levelBean>k__BackingField;
            this.letterContent.InitLetterContent();
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "level_start", value:  0);
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingInGameStart();
            this.ShowBanner();
            this.ShowSideButton();
            if((((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false) || ((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.IsHaveNoviceBankruptcy) == false)) || ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin) > 99))
            {
                goto label_10;
            }
            
            val_34 = Logic.Game.GameManager.gameDialog;
            object[] val_9 = new object[1];
            val_35 = true;
            val_9[0] = val_35;
            View.Dialog.Common.Dialog val_10 = val_34.OpenAddParams(name:  "NoviceRewardDialog", pars:  val_9);
            goto label_44;
            label_10:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                goto label_20;
            }
            
            Logic.Gameplay.GameplayController val_13 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            if((val_13.<ShouldShowRate>k__BackingField) == false)
            {
                goto label_20;
            }
            
            View.Dialog.Common.Dialog val_14 = Logic.Game.GameManager.gameDialog.Open(name:  "RateIOSDialog", type:  0);
            goto label_44;
            label_20:
            val_35 = Common.Singleton<Common.EnterShow.EnterShow>.Instance.CheckStarterPack(isHasBonus:  this.<levelBean>k__BackingField.HasBonus());
            val_36 = Common.Singleton<Common.EnterShow.EnterShow>.Instance;
            if(val_35 == false)
            {
                goto label_25;
            }
            
            val_37 = "64";
            goto label_27;
            label_25:
            val_35 = val_36.CheckDoubleCoins(isHasBonus:  this.<levelBean>k__BackingField.HasBonus());
            val_36 = Common.Singleton<Common.EnterShow.EnterShow>.Instance;
            if(val_35 == false)
            {
                goto label_30;
            }
            
            val_37 = "60";
            label_27:
            label_39:
            val_36.ShowLimitTimePackForName(name:  val_37);
            label_44:
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyPrayerOpenDate();
            View.Dialog.GameDictionary.Controller.GameDictionaryController val_25 = Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance;
            mem2[0] = 1;
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddShowDailyCount();
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "show_daily_puzzle", label:  "fly", value:  0);
            Platform.Analytics.EzAnalytics.DailyShowTimes();
            return;
            label_30:
            if((val_36.CheckSurpriseSuperBundle(isHasBonus:  this.<levelBean>k__BackingField.HasBonus())) == false)
            {
                goto label_37;
            }
            
            Common.EnterShow.EnterShow val_30 = Common.Singleton<Common.EnterShow.EnterShow>.Instance;
            goto label_39;
            label_37:
            Logic.Gameplay.GameplayController val_31 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            if(((val_31.<GameSceneShouldAd>k__BackingField) == false) || ((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == true))
            {
                goto label_44;
            }
            
            this.ShowLevelPassAdFromBegin();
            goto label_44;
        }
        private void ShowBanner()
        {
            var val_12;
            var val_13;
            if((Logic.Game.GameManager.gameLevel.GetLevel(sectionIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex, levelIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex)) == null)
            {
                    return;
            }
            
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == true)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameLevel.IsPassLevelForCurrentLevel(sectionIndex:  1, levelIndex:  1)) == false)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            Platform.Ad.BannerPlacement val_9 = new Platform.Ad.BannerPlacement(placementID:  Platform.Ad.GameAdID.BannerID);
            Platform.Ad.ADPlacementLogProcessor val_11 = RegisterLogEvent(category:  "game_page_ad_banner").AddLogEvent(adEventType:  1, action:  "a1_ad_call", lable:  "");
            val_13 = null;
            val_13 = null;
            this.isBannerShowed = true;
        }
        private void HideBanner()
        {
            this.DestroyAd();
        }
        private void ShowLevelPassAdFromBegin()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Action val_12;
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.LevelStart, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeInterstitial}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionLevelStart});
            val_9 = null;
            val_9 = null;
            Platform.Ad.InterstitialPlacement val_1 = new Platform.Ad.InterstitialPlacement(placementID:  Platform.Ad.GameAdID.InterstitalLevelPassID);
            Platform.Ad.ADPlacementLogProcessor val_3 = RegisterLogEvent(category:  "level_pass_ad_interstitial").AddLogEvent(adEventType:  1, action:  "a1_ad_call", lable:  "");
            typeof(Platform.Ad.InterstitialPlacement).__il2cppRuntimeField_30 = new System.Action<System.String>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerController::<ShowLevelPassAdFromBegin>b__28_0(string adTaskID));
            val_10 = null;
            val_10 = null;
            val_12 = DailyPrayerController.<>c.<>9__28_1;
            if(val_12 == null)
            {
                    System.Action val_5 = null;
                val_12 = val_5;
                val_5 = new System.Action(object:  DailyPrayerController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DailyPrayerController.<>c::<ShowLevelPassAdFromBegin>b__28_1());
                DailyPrayerController.<>c.<>9__28_1 = val_12;
            }
        
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  0)) == true)
            {
                    return;
            }
            
            if((this.<isGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "SettingDialog", type:  0);
        }
        public void GameComplete(float delay)
        {
            if((this.<isGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            this.<isGameComplete>k__BackingField = true;
            Logic.DailyPrayer.DailyPrayerControllers val_1 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_1.<IsGameComplete>k__BackingField = true;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "level_end", volumeScale:  0.5f, loop:  false, delay:  0f);
            }
            
            this.DestroyAd();
            Platform.Analytics.EzAnalytics.SendLevelClearRecord(time:  Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStop());
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.ShowBibleDialog(delay:  delay));
        }
        private System.Collections.IEnumerator ShowBibleDialog(float delay)
        {
            typeof(DailyPrayerController.<ShowBibleDialog>d__31).__il2cppRuntimeField_10 = 0;
            typeof(DailyPrayerController.<ShowBibleDialog>d__31).__il2cppRuntimeField_20 = this;
            typeof(DailyPrayerController.<ShowBibleDialog>d__31).__il2cppRuntimeField_28 = delay;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public View.CommonItem.Combo.ComboNormal CreatYouMadeIt()
        {
            if(this.comboHelper != null)
            {
                    return this.comboHelper.Create(parent:  this.dynamicParent, combo:  20);
            }
            
            throw new NullReferenceException();
        }
        public View.CommonItem.Combo.ComboNormal CreateCombo(int comboCount)
        {
            if(this.comboHelper != null)
            {
                    return this.comboHelper.Create(parent:  this.dynamicParent, combo:  comboCount);
            }
            
            throw new NullReferenceException();
        }
        private void PrepareLeaveGameScene()
        {
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingLeaveGameScene();
            Message.Messager.Dispatch<System.Boolean>(cmd:  63, t:  ((this.<isGameComplete>k__BackingField) == true) ? 1 : 0);
            Message.Messager.Dispatch(cmd:  54);
        }
        public void DestroyWords()
        {
            if(this.wordContent != null)
            {
                    this.wordContent.DestroyBoxes();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void DestroyAd()
        {
            Platform.Ad.GameAdManager.<Instance>k__BackingField.HideBannerAd();
            this.isBannerShowed = false;
        }
        public override void OnApplicationPause(bool pause)
        {
            if(pause != false)
            {
                    Common.Singleton<View.Game.LevelPassTime>.Instance.TimingPause();
            }
            else
            {
                    Common.Singleton<Data.Login.LoginDataManager>.Instance.UpdateDataFromDay();
                Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStart();
            }
            
            this.OnApplicationPause(pause:  pause);
        }
        private void ClearDailyPrayerView()
        {
            this.wordContent.ClearWordContent();
            this.letterContent.ClearLetterContent();
            this.<isGameComplete>k__BackingField = false;
            Logic.DailyPrayer.DailyPrayerControllers val_1 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_1.<IsGameComplete>k__BackingField = false;
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_2.<NowCurLevelUseFireworkCount>k__BackingField = 0;
            View.Dialog.ShopTest.Controller.ShopController val_3 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_3.<NowCurLevelPurchaseCount>k__BackingField = 0;
        }
        private void RestartNextGame()
        {
            Message.Messager.Dispatch<System.Single>(cmd:  91, t:  0.45f);
        }
        public DailyPrayerController()
        {
        
        }
        private void <ShowLevelPassAdFromBegin>b__28_0(string adTaskID)
        {
            if((Common.Singleton<Common.EnterShow.EnterShow>.Instance.CheckRemoveAdsBundle(isHasBonus:  this.<levelBean>k__BackingField.HasBonus())) == false)
            {
                    return;
            }
            
            Common.Singleton<Common.EnterShow.EnterShow>.Instance.ShowLimitTimePackForName(name:  "63");
        }
    
    }

}
