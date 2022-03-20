using UnityEngine;

namespace View.Dialog.ResultDaily
{
    public class ResultDailyDialog : Dialog
    {
        // Fields
        private const float TimeAlpha = 0.5;
        public View.Dialog.ResultDaily.ResultDailyLevelContent LevelContent;
        public View.Dialog.ResultDaily.ResultDailyBibleContent BibleContent;
        public UnityEngine.CanvasGroup CanvasGroupAnimator;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.CanvasGroupAnimator.alpha = 0f;
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupAnimator, endValue:  1f, duration:  null);
            Message.Messager.Add(cmd:  1, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::OnLevelPass()));
            Message.Messager.Add(cmd:  2, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::OnLevelPassVideoReward()));
            Message.Messager.Add(cmd:  80, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::ShowResultBibleContent()));
            Message.Messager.Add(cmd:  81, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::CollectResultBible()));
            Message.Messager.Dispatch<System.Boolean>(cmd:  67, t:  true);
            this.UpdateResultDialog();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  1, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::OnLevelPass()));
            Message.Messager.Remove(cmd:  2, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::OnLevelPassVideoReward()));
            Message.Messager.Remove(cmd:  80, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::ShowResultBibleContent()));
            Message.Messager.Remove(cmd:  81, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::CollectResultBible()));
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
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.AddDailySignRecordFromDate();
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.AddDailySignCollectStarRecord();
            if((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.IsAllPassLevelFromCurrentDay()) != false)
            {
                    Data.DailyRecord.DailyRecordDataManager val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                val_5.<DailySignBeforeCollectStar>k__BackingField = (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord) - (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyDayStarCollectNum());
                View.Dialog.Common.Dialog val_11 = Logic.Game.GameManager.gameDialog.Open(name:  "DailySignDialog", type:  0);
            }
            else
            {
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
        private void ShowResultBibleContent()
        {
            this.LevelContent.HideLevelContent(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyDialog::<ShowResultBibleContent>b__9_0()), isToBible:  true);
        }
        private void CollectResultBible()
        {
            if(this.LevelContent != null)
            {
                    this.LevelContent.ShowChapterContent();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void HideResult()
        {
            DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupAnimator, endValue:  0f, duration:  0.5f), action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(View.Dialog.ResultDaily.ResultDailyDialog).__il2cppRuntimeField_1E8));
        }
        private void UpdateResultDialog()
        {
            var val_6;
            var val_7;
            Message.Messager.Dispatch(cmd:  70);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "level_pass", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            this.BibleContent.SetActive(active:  false);
            this.LevelContent.SetActive(active:  true);
            this.LevelContent.ShowLevelContent();
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameLevelResultDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingAuto});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "level_finish", label:  (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex()) + 1.ToString(), value:  0);
            Store.StoreManager.FileName.Save();
        }
        public ResultDailyDialog()
        {
        
        }
        private void <ShowResultBibleContent>b__9_0()
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
