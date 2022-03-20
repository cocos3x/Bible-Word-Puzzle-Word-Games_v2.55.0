using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultDialog : Dialog
    {
        // Fields
        private const float TimeAlpha = 0.5;
        public View.Dialog.Result.ResultBookAni BookAni;
        public View.Dialog.Result.ResultLevelContent LevelContent;
        public View.Dialog.Result.ResultBibleContent BibleContent;
        public View.Dialog.Result.ResultSideContent SideContent;
        public UnityEngine.CanvasGroup CanvasGroupAnimator;
        private int _sectionLevelCount;
        private bool _isLastLevel;
        private bool _isSectionPass;
        private Data.Bean.BibleSection _bibleSection;
        
        // Methods
        public override void OnTransmitParams(object[] pars)
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            this.OnTransmitParams(pars:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            UnityEngine.Vector3 val_1 = Common.GlobalMethods.GetBaseVale<UnityEngine.Vector3>(inputs:  pars, idx:  0, defaultVal:  0);
            this.UpdateResultDialog(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.CanvasGroupAnimator.alpha = 0f;
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupAnimator, endValue:  1f, duration:  null);
            Message.Messager.Add(cmd:  1, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::OnLevelPass()));
            Message.Messager.Add(cmd:  2, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::OnLevelPassVideoReward()));
            Message.Messager.Add<System.Boolean>(cmd:  3, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::OnSectionPass(bool isBibleLastChapter)));
            Message.Messager.Add(cmd:  80, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::ShowResultBibleContent()));
            Message.Messager.Add(cmd:  81, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::CollectResultBible()));
            Message.Messager.Add(cmd:  82, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::NextLevel()));
            Message.Messager.Add(cmd:  84, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::PlayCollectBookEffect()));
            Message.Messager.Dispatch<System.Boolean>(cmd:  67, t:  true);
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddLevelPassCount();
            Platform.Analytics.EzAnalytics.LevelPassCountTimes();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  1, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::OnLevelPass()));
            Message.Messager.Remove(cmd:  2, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::OnLevelPassVideoReward()));
            Message.Messager.Remove<System.Boolean>(cmd:  3, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::OnSectionPass(bool isBibleLastChapter)));
            Message.Messager.Remove(cmd:  80, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::ShowResultBibleContent()));
            Message.Messager.Remove(cmd:  81, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::CollectResultBible()));
            Message.Messager.Remove(cmd:  82, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::NextLevel()));
            Message.Messager.Remove(cmd:  84, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::PlayCollectBookEffect()));
            Message.Messager.Dispatch<System.Boolean>(cmd:  67, t:  false);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            this.LevelContent.LocaleTranslate();
            this.BibleContent.LocaleTranslate();
        }
        private void OnLevelPass()
        {
            int val_10;
            var val_11;
            var val_12;
            if(this._isLastLevel != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a4_button_next_click", label:  "", value:  0);
            }
            
            if((this._isSectionPass != false) && (this._isLastLevel != false))
            {
                    Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                if((val_1.<CurrentSectionIndex>k__BackingField) == 1)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "user_guide", action:  "a8_chapter_bonus3_pass", label:  "", value:  0);
            }
            
            }
            
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            val_10 = val_2.<CurrentSectionIndex>k__BackingField;
            Data.UserPlayer.UserPlayerDataManager val_3 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((Logic.Game.GameManager.gameLevel.IsAllLevelPass(section:  val_10, level:  (val_3.<CurrentLevelIndex>k__BackingField) + 1)) != false)
            {
                    Message.Messager.Dispatch(cmd:  34);
                Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  3);
            }
            else
            {
                    if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != true)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
                val_12 = null;
                val_12 = null;
                Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameMgScr}, curLevel:  val_10, source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceResultScr});
            }
            
                Message.Messager.Dispatch(cmd:  45);
            }
            
            this.HideResult();
        }
        private void OnLevelPassVideoReward()
        {
            if(Platform.AbTest.GameABTestManager.IsRewardLevelAd() != false)
            {
                    return;
            }
            
            Message.Messager.Dispatch(cmd:  1);
        }
        private void OnSectionPass(bool isBibleLastChapter)
        {
            this.ChapterPass(isBibleLastChapter:  false);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "chapter_clear", value:  0);
            Common.Singleton<Data.Bible.BibleDataManager>.Instance.SetBookCollectCount(count:  Logic.Game.GameManager.gameBible.GetCollectBookCount());
            Common.Singleton<Data.Bible.BibleDataManager>.Instance.SetVerseCollectCount(count:  Logic.Game.GameManager.gameBible.GetCollectVerseCount());
        }
        private void ChapterPass(bool isBibleLastChapter)
        {
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == 1)
            {
                    Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetShouldShowHomeDailyDialog(isShould:  true);
            }
            
            object[] val_4 = new object[1];
            val_4[0] = 0;
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MainBibleBookTestDialog", pars:  val_4);
            this.HideResult();
        }
        private void NextLevel()
        {
            if(this._isSectionPass != false)
            {
                    this.OnSectionPass(isBibleLastChapter:  false);
                return;
            }
            
            this.OnLevelPass();
        }
        private void ShowResultBibleContent()
        {
            this.LevelContent.HideLevelContent(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::<ShowResultBibleContent>b__19_0()), isToBible:  true);
        }
        private void CollectResultBible()
        {
            if(this.LevelContent != null)
            {
                    this.LevelContent.ShowChapterContent(bibleSection:  null);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void BookAniCallback()
        {
            if(this.LevelContent != null)
            {
                    this.LevelContent.ShowLevelContent(isSectionPass:  this._isSectionPass, sectionLevelCount:  this._sectionLevelCount, isLastLevel:  this._isLastLevel);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void HideResult()
        {
            Message.Messager.Dispatch<System.Boolean>(cmd:  67, t:  false);
            this.SideContent.ChrysalisProgress.HideSideEffect();
            DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupAnimator, endValue:  0f, duration:  0.5f), action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(View.Dialog.Result.ResultDialog).__il2cppRuntimeField_1E8));
            this.LevelContent.Books.PlayHideBookAni();
        }
        private void PlayBookAni(UnityEngine.Vector3 pos)
        {
            this.BookAni.PlayBookAni(pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, callBack:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultDialog::BookAniCallback()));
        }
        private void LevelPassUpdateData()
        {
            var val_22;
            if(this._isLastLevel != false)
            {
                    if(this._isSectionPass == true)
            {
                goto label_2;
            }
            
            }
            
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.SetFailCountLastLevel(count:  Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.FailCountCurLevel);
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.SetFailCountCurLevel(count:  0);
            label_2:
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddCurrentLevelIndex(sectionLevelCount:  this._sectionLevelCount);
            if(this._isSectionPass != false)
            {
                    Data.UserPlayer.UserPlayerDataManager val_6 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                int val_22 = val_6.<CurrentSectionIndex>k__BackingField;
                val_22 = val_22 + 1;
                val_6.<CurrentSectionIndex>k__BackingField = val_22;
            }
            
            if(this._isLastLevel == false)
            {
                    return;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_8 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUnlockSectionIndex(index:  val_8.<CurrentSectionIndex>k__BackingField);
            Data.UserPlayer.UserPlayerDataManager val_10 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUnlockLevelIndex(index:  val_10.<CurrentLevelIndex>k__BackingField);
            if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) >= 2) && ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) == 0))
            {
                    if((Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.ShouldRate()) != false)
            {
                    Logic.Gameplay.GameplayController val_17 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
                val_17.<ShouldShowRate>k__BackingField = true;
            }
            
            }
            
            Data.GameRecord.GameRecordDataManager val_18 = Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance;
            Data.UserPlayer.UserPlayerDataManager val_19 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_19.<CurrentLevelIndex>k__BackingField) != 2)
            {
                goto label_22;
            }
            
            val_22 = 1;
            if(val_18 != null)
            {
                goto label_23;
            }
            
            return;
            label_22:
            Data.UserPlayer.UserPlayerDataManager val_20 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            label_23:
            val_18.SetInQuizLevel(isIn:  ((val_20.<CurrentLevelIndex>k__BackingField) == 5) ? 1 : 0);
        }
        private void ChapterPassUpdateData()
        {
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddCurrentLevelIndex(sectionLevelCount:  this._sectionLevelCount);
            if(this._isSectionPass != false)
            {
                    Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                int val_15 = val_2.<CurrentSectionIndex>k__BackingField;
                val_15 = val_15 + 1;
                val_2.<CurrentSectionIndex>k__BackingField = val_15;
            }
            
            if(this._isLastLevel != false)
            {
                    Data.UserPlayer.UserPlayerDataManager val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUnlockSectionIndex(index:  val_4.<CurrentSectionIndex>k__BackingField);
                this = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                Data.UserPlayer.UserPlayerDataManager val_6 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                this.SetUnlockLevelIndex(index:  val_6.<CurrentLevelIndex>k__BackingField);
                if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) >= 2) && ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) == 0))
            {
                    if((Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.ShouldRate()) != false)
            {
                    Logic.Gameplay.GameplayController val_13 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
                val_13.<ShouldShowRate>k__BackingField = true;
            }
            
            }
            
            }
            
            Common.Singleton<Data.Bible.BibleDataManager>.Instance.AddLastCompleteBible();
        }
        private void PlayCollectBookEffect()
        {
            this.LevelContent.Books.PlayBookEffect();
        }
        private void UpdateResultDialog(UnityEngine.Vector3 pos)
        {
            var val_26;
            var val_27;
            var val_28;
            long val_29;
            string val_30;
            var val_31;
            string val_32;
            string val_33;
            Message.Messager.Dispatch(cmd:  70);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "level_pass", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            this._sectionLevelCount = Logic.Game.GameManager.gameLevel.GetCount(section:  val_2.<CurrentSectionIndex>k__BackingField);
            this._isLastLevel = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0);
            Data.UserPlayer.UserPlayerDataManager val_7 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            int val_26 = val_7.<CurrentLevelIndex>k__BackingField;
            val_26 = val_26 + 1;
            this._isSectionPass = (val_26 == this._sectionLevelCount) ? 1 : 0;
            Common.SingletonController<Logic.Game.GameControllers>.Instance.ScoreUpdateData(score:  0);
            if(this._isSectionPass != false)
            {
                    this._bibleSection = Logic.Game.GameManager.gameBible.GetBibleSection();
                this.ChapterPassUpdateData();
            }
            else
            {
                    this.LevelPassUpdateData();
            }
            
            if((Common.SingletonController<Logic.PiggyBank.PiggyBankController>.Instance.ShouldHavePiggyBankForResult()) != false)
            {
                    Common.SingletonController<Logic.Game.GameControllers>.Instance.PiggyBankCoinUpdateData();
            }
            
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpenForResult()) != false)
            {
                    if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) != true)
            {
                    Common.SingletonController<Logic.Game.GameControllers>.Instance.ChrysalisUpdateData();
            }
            
            }
            
            this.BibleContent.SetActive(active:  false);
            this.SideContent.HideSideButton();
            if(this._isLastLevel == false)
            {
                goto label_26;
            }
            
            this.LevelContent.SetActive(active:  false);
            this.PlayBookAni(pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
            val_26 = null;
            val_26 = null;
            val_27 = null;
            val_27 = null;
            Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameLevelResultDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingAuto});
            Platform.Analytics.EzAnalytics.ChapterFinishTimes();
            Data.UserPlayer.UserPlayerDataManager val_19 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_19.<CurrentSectionIndex>k__BackingField) != 0)
            {
                goto label_34;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_20 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_20.<CurrentLevelIndex>k__BackingField) > 2)
            {
                goto label_34;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_21 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            int val_27 = val_21.<CurrentLevelIndex>k__BackingField;
            val_27 = val_27 + 1;
            val_28 = "a3_level" + val_27 + "_pass";
            val_29 = 0;
            val_30 = "";
            val_31 = "user_guide";
            goto label_36;
            label_34:
            Data.UserPlayer.UserPlayerDataManager val_23 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_23.<CurrentSectionIndex>k__BackingField) == 0)
            {
                goto label_38;
            }
            
            label_47:
            Data.UserPlayer.UserPlayerDataManager val_24 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if(((val_24.<CurrentSectionIndex>k__BackingField) != 1) || (this._isSectionPass == false))
            {
                goto label_46;
            }
            
            val_32 = "user_guide";
            val_33 = "a3_level10_pass";
            goto label_42;
            label_26:
            this.LevelContent.SetActive(active:  true);
            this.LevelContent.ShowLevelContent(isSectionPass:  this._isSectionPass, sectionLevelCount:  this._sectionLevelCount, isLastLevel:  this._isLastLevel);
            this.BookAni.gameObject.SetActive(value:  false);
            goto label_46;
            label_38:
            if(this._isSectionPass == false)
            {
                goto label_47;
            }
            
            val_32 = "user_guide";
            val_33 = "a7_chapter_pass";
            label_42:
            val_29 = 0;
            val_30 = "";
            label_36:
            Platform.Analytics.EzAnalytics.LogEvent(category:  val_32, action:  val_33, label:  val_30, value:  val_29);
            label_46:
            Store.StoreManager.FileName.Save();
        }
        public ResultDialog()
        {
        
        }
        private void <ShowResultBibleContent>b__19_0()
        {
            if(this.BibleContent != null)
            {
                    this.BibleContent.ShowBibleContent();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
