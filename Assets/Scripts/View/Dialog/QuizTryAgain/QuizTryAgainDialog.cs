using UnityEngine;

namespace View.Dialog.QuizTryAgain
{
    public class QuizTryAgainDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text TextTips;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text PassText;
        public TMPro.TMP_Text RetryText;
        private int _rewardCount;
        private bool isClaimClicked;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.isClaimClicked = false;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() != null)
            {
                    Data.Bean.PropertyBean val_2 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                this._rewardCount = val_2.quizReward;
            }
            
            string val_4 = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "42"), arg0:  this._rewardCount);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "201");
            this.PassText.text = Locale.LocaleManager.Translate(key:  "160");
            this.RetryText.text = Locale.LocaleManager.Translate(key:  "161");
        }
        public void OnClickPassButton()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNamePassBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceQuizWrongDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "quiz", action:  "level", label:  "pass", value:  0);
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameMgScr}, curLevel:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceResultScr});
            Message.Messager.Dispatch(cmd:  45);
            goto typeof(View.Dialog.QuizTryAgain.QuizTryAgainDialog).__il2cppRuntimeField_1E0;
        }
        public void OnClickRetryButton()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameRetryBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceQuizWrongDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "quiz", action:  "level", label:  "retry", value:  0);
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SetInQuizLevel(isIn:  true);
            Message.Messager.Dispatch(cmd:  45);
            goto typeof(View.Dialog.QuizTryAgain.QuizTryAgainDialog).__il2cppRuntimeField_1E0;
        }
        public QuizTryAgainDialog()
        {
            this._rewardCount = 40;
        }
    
    }

}
