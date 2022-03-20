using UnityEngine;

namespace View.Game
{
    public class GameController : BaseController
    {
        // Fields
        public View.CommonItem.Combo.Combo comboHelper;
        public View.Game.WordContent wordContent;
        public View.Game.LetterContent letterContent;
        public View.Game.QuizContent QuizContentTop;
        public View.Game.QuizOptionContent QuizOptionContentBottom;
        public View.Game.GameBottomFit BottomFit;
        public View.Game.GameLevelPanel LevelPanel;
        public UnityEngine.Transform dynamicParent;
        public UnityEngine.Transform SlotBible;
        private bool <isGameComplete>k__BackingField;
        private bool _isBannerShowed;
        
        // Properties
        public bool isGameComplete { get; set; }
        public bool isBannerShowed { get; set; }
        
        // Methods
        public static View.Game.GameController GetInstance()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            return 0;
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
            this._isBannerShowed = value;
        }
        private void BeginGame(float delay)
        {
            System.Action val_6;
            System.Action val_7;
            IntPtr val_8;
            this.OnClearGameView();
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_1.<IsHideBanner>k__BackingField = false;
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != false)
            {
                    this.BeginQuizLevel();
                val_6 = 1152921504611106816;
                val_7 = null;
                val_8 = 1152921512621777152;
            }
            else
            {
                    this.DoAwakeGame();
                val_6 = 1152921504611106816;
                val_7 = null;
                val_8 = 1152921512621778176;
            }
            
            val_7 = new System.Action(object:  this, method:  val_8);
            Common.TimerEvent.remove(callback:  val_7);
            val_6 = new System.Action(object:  this, method:  System.Void View.Game.GameController::InitGame());
            Common.TimerEvent.Add(time:  delay, callback:  val_6, isrepeat:  false);
        }
        private void RestartNextGame()
        {
            Message.Messager.Dispatch<System.Single>(cmd:  44, t:  0.1f);
        }
        private void SetContent(bool isGame)
        {
            this.wordContent.gameObject.SetActive(value:  isGame);
            this.letterContent.gameObject.SetActive(value:  isGame);
            bool val_6 = isGame ^ 1;
            this.QuizContentTop.gameObject.SetActive(value:  val_6);
            this.QuizOptionContentBottom.gameObject.SetActive(value:  val_6);
            this.BottomFit.gameObject.SetActive(value:  isGame);
        }
        private void DoAwakeGame()
        {
            Common.SingletonController<Logic.Game.GameControllers>.Instance.SetCurrentLevelBean(bean:  Logic.Game.GameManager.gameLevel.CurrentLevel());
            Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_3._levelBean == null)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_4 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_4.<NowCurLevelName>k__BackingField = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
            this.SetContent(isGame:  true);
            Data.UserPlayer.UserPlayerDataManager val_6 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            string val_7 = Logic.Game.GameManager.gameBible.GetBibleProgress(sectionIndex:  val_6.<CurrentSectionIndex>k__BackingField);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_page_game_show", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
                Platform.Analytics.EzAnalytics.LogEvent(eventName:  "level_start_rubies", parameterName:  "level_" + Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), parameterValue:  (long)Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin);
                Platform.Analytics.EzAnalytics.LevelPassTimes(levelName:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName());
            }
            
            Data.UserPlayer.UserPlayerDataManager val_16 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Logic.Game.GameManager.gameMusic.PlayGame(useNewMusic:  ((val_16.<CurrentLevelIndex>k__BackingField) == 0) ? 1 : 0);
        }
        private void BeginQuizLevel()
        {
            Common.SingletonController<Logic.Game.GameControllers>.Instance.SetCurrentQuizLevelBean(bean:  Logic.Game.GameManager.gameQuizLevel.GetUnlockQuizLevelBean());
            this.SetContent(isGame:  false);
            string val_3 = Locale.LocaleManager.Translate(key:  "41");
            Data.UserPlayer.UserPlayerDataManager val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Logic.Game.GameManager.gameMusic.PlayGame(useNewMusic:  ((val_4.<CurrentLevelIndex>k__BackingField) == 0) ? 1 : 0);
        }
        private void InitGame()
        {
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._levelBean == null)
            {
                    return;
            }
            
            Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.PlayLevel();
            this.wordContent.InitWordContent();
            this.letterContent.InitLetterContent();
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "level_start", value:  0);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    val_5._temp = 0f;
                val_5.isInGameScene = true;
                Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStart();
            }
            
            this.ShowBanner();
            this.ShowMainBibleNextDialog();
            Logic.Gameplay.GameplayController val_6 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            val_6.<GameSceneShouldAd>k__BackingField = true;
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddStartLevelCount();
            Platform.Analytics.EzAnalytics.StartLevelTimes();
        }
        private void InitQuizGame()
        {
            var val_14;
            var val_15;
            var val_16;
            val_14 = this;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._quizLevelBean == null)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            this.QuizContentTop.InitContent(bean:  val_2._quizLevelBean);
            Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            this.QuizOptionContentBottom.InitContent(bean:  val_3._quizLevelBean);
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddShowQuizCount();
            Platform.Analytics.EzAnalytics.FinishQuizTimes();
            val_15 = null;
            val_15 = null;
            Logic.Game.GameControllers val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_16 = null;
            val_16 = null;
            Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameQuizScr}, curLevel:  "quiz_" + val_5._quizLevelBean.id, source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceMgScr});
            Logic.Game.GameControllers val_7 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "quiz", action:  "level", label:  val_7._quizLevelBean.id + "_show", value:  0);
            this.ShowBanner();
            val_14 = 1152921512622648928;
            Logic.Gameplay.GameplayController val_9 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            if(((val_9.<GameSceneShouldAd>k__BackingField) != false) && ((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) != true))
            {
                    bool val_12 = Logic.Game.GameManager.gameLevel.IsPassLevelForUnlockLevel(sectionIndex:  2, levelIndex:  0);
                if(val_12 != false)
            {
                    val_12.ShowLevelPassAdFromBegin();
            }
            
            }
            
            Logic.Gameplay.GameplayController val_13 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            val_13.<GameSceneShouldAd>k__BackingField = true;
        }
        private void ShowBanner()
        {
            var val_10;
            var val_11;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._levelBean == null)
            {
                    Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if(val_2._quizLevelBean == null)
            {
                    return;
            }
            
            }
            
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == true)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameLevel.IsPassLevelForCurrentLevel(sectionIndex:  1, levelIndex:  1)) == false)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            Platform.Ad.BannerPlacement val_6 = new Platform.Ad.BannerPlacement(placementID:  Platform.Ad.GameAdID.BannerID);
            Platform.Ad.ADPlacementLogProcessor val_8 = RegisterLogEvent(category:  "game_page_ad_banner").AddLogEvent(adEventType:  1, action:  "a1_ad_call", lable:  "");
            val_11 = null;
            val_11 = null;
            Logic.Game.GameControllers val_9 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_9.<IsHideBanner>k__BackingField = false;
            this._isBannerShowed = true;
        }
        private void HideBanner()
        {
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_1.<IsHideBanner>k__BackingField = true;
            this.DestroyAd();
        }
        private void ShowLevelPassAdFromBegin()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Action<System.String> val_12;
            var val_13;
            System.Action val_15;
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
            val_10 = null;
            val_10 = null;
            val_12 = GameController.<>c.<>9__27_0;
            if(val_12 == null)
            {
                    System.Action<System.String> val_4 = null;
                val_12 = val_4;
                val_4 = new System.Action<System.String>(object:  GameController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameController.<>c::<ShowLevelPassAdFromBegin>b__27_0(string adTaskID));
                val_10 = null;
                GameController.<>c.<>9__27_0 = val_12;
            }
            
            typeof(Platform.Ad.InterstitialPlacement).__il2cppRuntimeField_30 = val_12;
            val_13 = null;
            val_13 = null;
            val_10 = null;
            val_10 = null;
            val_15 = GameController.<>c.<>9__27_1;
            if(val_15 == null)
            {
                    System.Action val_5 = null;
                val_15 = val_5;
                val_5 = new System.Action(object:  GameController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameController.<>c::<ShowLevelPassAdFromBegin>b__27_1());
                GameController.<>c.<>9__27_1 = val_15;
            }
        
        }
        private void ShowMainBibleNextDialog()
        {
            Logic.Game.GameDiglog val_51;
            var val_52;
            System.Object[] val_53;
            string val_55;
            Logic.Define.DialogType val_56;
            var val_57;
            string val_58;
            val_51 = 1152921512608190960;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                goto label_2;
            }
            
            if(Logic.Game.GameManager.gameBible.IsDataEmpty() != true)
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == 1)
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) == 0)
            {
                goto label_8;
            }
            
            }
            
            }
            
            if((((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.IsHaveNoviceReward) == false) || ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) != 2)) || ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) != 2))
            {
                goto label_14;
            }
            
            val_51 = Logic.Game.GameManager.gameDialog;
            val_52 = 1152921504612384768;
            val_53 = new object[1];
            goto label_15;
            label_2:
            Logic.Gameplay.GameplayController val_15 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            if((val_15.<GameSceneShouldAd>k__BackingField) == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == true)
            {
                    return;
            }
            
            label_63:
            bool val_18 = Logic.Game.GameManager.gameLevel.IsPassLevelForCurrentLevel(sectionIndex:  2, levelIndex:  0);
            if(val_18 == false)
            {
                    return;
            }
            
            val_18.ShowLevelPassAdFromBegin();
            return;
            label_14:
            if(((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.IsHaveNoviceBankruptcy) == false) || ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin) > 99))
            {
                goto label_25;
            }
            
            val_51 = Logic.Game.GameManager.gameDialog;
            object[] val_23 = new object[1];
            val_52 = 1152921504612384768;
            val_53 = val_23;
            label_15:
            val_53[0] = true;
            label_58:
            View.Dialog.Common.Dialog val_24 = val_51.OpenAddParams(name:  "NoviceRewardDialog", pars:  val_23);
            return;
            label_25:
            Logic.Gameplay.GameplayController val_25 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            if((val_25.<ShouldShowRate>k__BackingField) == false)
            {
                goto label_32;
            }
            
            val_55 = "RateIOSDialog";
            val_56 = 0;
            goto label_34;
            label_32:
            val_57 = Common.Singleton<Common.EnterShow.EnterShow>.Instance;
            if((Common.Singleton<Common.EnterShow.EnterShow>.Instance.CheckStarterPack(isHasBonus:  Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonus())) == false)
            {
                goto label_37;
            }
            
            val_58 = "64";
            goto label_44;
            label_37:
            val_57 = Common.Singleton<Common.EnterShow.EnterShow>.Instance;
            if((val_57.CheckDoubleCoins(isHasBonus:  Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonus())) == false)
            {
                goto label_42;
            }
            
            val_58 = "60";
            goto label_44;
            label_8:
            val_55 = "VerseClickGuideDialog";
            val_56 = 2;
            label_34:
            View.Dialog.Common.Dialog val_37 = Logic.Game.GameManager.gameDialog.Open(name:  val_55, type:  val_56);
            return;
            label_42:
            val_57 = Common.Singleton<Common.EnterShow.EnterShow>.Instance;
            if((val_57.CheckSurpriseSuperBundle(isHasBonus:  Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonus())) == false)
            {
                goto label_48;
            }
            
            val_58 = "65";
            label_44:
            val_57.ShowLimitTimePackForName(name:  val_58);
            return;
            label_48:
            if((val_57.CheckPiggyBank(isHasBonus:  Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonus())) == false)
            {
                goto label_52;
            }
            
            new object[1][0] = null;
            goto label_58;
            label_52:
            Logic.Gameplay.GameplayController val_48 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            if((val_48.<GameSceneShouldAd>k__BackingField) == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == true)
            {
                    return;
            }
            
            goto label_63;
        }
        protected virtual void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  0)) == true)
            {
                    return;
            }
            
            if((this.<isGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            if(this.wordContent.isComplete != false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "SettingDialog", type:  0);
        }
        private void GameComplete(float delay)
        {
            var val_20;
            object val_21;
            if((this.<isGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            this.<isGameComplete>k__BackingField = true;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_1.<IsGameComplete>k__BackingField = true;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "level_end", volumeScale:  0.5f, loop:  false, delay:  0f);
            }
            
            this.DestroyAd();
            val_20 = 1152921512608190960;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    int val_6 = Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStop();
                Platform.Analytics.EzAnalytics.SendLevelClearRecord(time:  val_6);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a2_level_pass", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
                val_21 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a2_level_pass_time", label:  val_21 + "_" + val_6, value:  0);
            }
            
            if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false) && ((Common.Singleton<Data.Login.LoginDataManager>.Instance.IsIn7Day()) != false))
            {
                    Data.UserPlayer.UserPlayerDataManager val_14 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                if((val_14.<CurrentSectionIndex>k__BackingField) == 10)
            {
                    Data.UserPlayer.UserPlayerDataManager val_15 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                if((val_15.<CurrentLevelIndex>k__BackingField) == 2)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_level_pass", platform:  2);
                Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_level_pass", platform:  1);
                val_21 = "";
                Platform.Analytics.EzAnalytics.LogEvent(category:  "marketing_user", action:  "level_pass_user", label:  "", value:  0);
                val_20 = "grt_retention_level_pass_user";
                Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_level_pass_user", platform:  2);
                Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_level_pass_user", platform:  1);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "grt_retention", action:  "level_pass_user", label:  "", value:  0);
            }
            
            }
            
            }
            
            float val_20 = 0.32f;
            val_20 = ((float)Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelLettersLength()) * val_20;
            val_20 = val_20 + delay;
            UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  this.ShowWinVerseDialog(delay:  val_20));
        }
        private void DoChapterWin()
        {
            var val_7;
            var val_8;
            Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((Logic.Game.GameManager.gameLevel.IsAllLevelPass(section:  val_1.<CurrentSectionIndex>k__BackingField, level:  (val_2.<CurrentLevelIndex>k__BackingField) + 1)) != false)
            {
                    Message.Messager.Dispatch(cmd:  34);
                Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  3);
                return;
            }
            
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameMgScr}, curLevel:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceResultScr});
            Message.Messager.Dispatch(cmd:  45);
        }
        private System.Collections.IEnumerator ShowWinVerseDialog(float delay)
        {
            typeof(GameController.<ShowWinVerseDialog>d__32).__il2cppRuntimeField_10 = 0;
            typeof(GameController.<ShowWinVerseDialog>d__32).__il2cppRuntimeField_20 = this;
            typeof(GameController.<ShowWinVerseDialog>d__32).__il2cppRuntimeField_28 = delay;
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
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Common.Singleton<View.Game.LevelPassTime>.Instance.TimingPause();
                val_3.isInGameScene = false;
            }
            
            Message.Messager.Dispatch<System.Boolean>(cmd:  63, t:  ((this.<isGameComplete>k__BackingField) == true) ? 1 : 0);
            Message.Messager.Dispatch(cmd:  54);
        }
        public void DestroyAd()
        {
            Platform.Ad.GameAdManager.<Instance>k__BackingField.HideBannerAd();
            this._isBannerShowed = false;
        }
        public override void OnApplicationPause(bool pause)
        {
            if(pause == false)
            {
                goto label_1;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                goto label_8;
            }
            
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingPause();
            goto label_8;
            label_1:
            Common.Singleton<Data.Login.LoginDataManager>.Instance.UpdateDataFromDay();
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStart();
            }
            
            label_8:
            this.OnApplicationPause(pause:  pause);
        }
        private void OnClearGameView()
        {
            this.letterContent.ClearLetterContent(isGameComplete:  false);
            this.wordContent.ClearWordContent();
            this.QuizOptionContentBottom.ResetOption();
            this.QuizContentTop.ClearContent();
            this.<isGameComplete>k__BackingField = false;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_1.<IsGameComplete>k__BackingField = false;
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_2.<NowCurLevelUseFireworkCount>k__BackingField = 0;
            View.Dialog.ShopTest.Controller.ShopController val_3 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_3.<NowCurLevelPurchaseCount>k__BackingField = 0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add<System.Single>(cmd:  44, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameController::BeginGame(float delay)));
            Message.Messager.Add(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::RestartNextGame()));
            Message.Messager.Add<System.Single>(cmd:  46, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameController::GameComplete(float delay)));
            Message.Messager.Add(cmd:  50, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::DoChapterWin()));
            Message.Messager.Add(cmd:  56, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::OnClearGameView()));
            Message.Messager.Add(cmd:  74, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::ShowBanner()));
            Message.Messager.Add(cmd:  75, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::HideBanner()));
            Message.Messager.Add(cmd:  35, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::PrepareLeaveGameScene()));
            this.BeginGame(delay:  0.58f);
        }
        protected override void OnDisable()
        {
            Message.Messager.Remove<System.Single>(cmd:  44, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameController::BeginGame(float delay)));
            Message.Messager.Remove(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::RestartNextGame()));
            Message.Messager.Remove<System.Single>(cmd:  46, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameController::GameComplete(float delay)));
            Message.Messager.Remove(cmd:  50, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::DoChapterWin()));
            Message.Messager.Remove(cmd:  56, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::OnClearGameView()));
            Message.Messager.Remove(cmd:  74, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::ShowBanner()));
            Message.Messager.Remove(cmd:  75, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::HideBanner()));
            Message.Messager.Remove(cmd:  35, action:  new System.Action(object:  this, method:  System.Void View.Game.GameController::PrepareLeaveGameScene()));
            this.DestroyAd();
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.GameController::InitQuizGame()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.GameController::InitGame()));
            Logic.Game.GameControllers val_11 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_11.<IsGameComplete>k__BackingField = false;
        }
        public GameController()
        {
        
        }
    
    }

}
