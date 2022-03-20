using UnityEngine;

namespace View.Dialog.RateIOS
{
    public class RateIOSDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text contentText;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public TMPro.TMP_Text RateUsText;
        public UnityEngine.UI.Text NotNowText;
        private bool _isRate;
        private bool _isIos;
        
        // Methods
        private void Start()
        {
            var val_7;
            var val_8;
            this._isIos = false;
            string val_1 = Locale.LocaleManager.Translate(key:  "206");
            Logic.Gameplay.GameplayController val_2 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            val_2.<ShouldShowRate>k__BackingField = false;
            System.DateTime val_4 = System.DateTime.Now;
            Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.LastRateDateTime = new System.DateTime() {dateData = val_4.dateData};
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameRateDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingAuto});
            Platform.Analytics.EzAnalytics.LogEvent(category:  (this._isIos == true) ? "dlg_rateus_ios" : "rateus", action:  (this._isIos == true) ? "show" : "a1_dialog_rateus_show", label:  "", value:  0);
        }
        public override void Cancel()
        {
            this.Cancel();
            Common.Singleton<Common.EnterShow.EnterShow>.Instance.CheckAndShowLimitTimePack();
        }
        public void OnClickNotNowButton()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameRefuseBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceRateDlg});
            goto typeof(View.Dialog.RateIOS.RateIOSDialog).__il2cppRuntimeField_1E0;
        }
        public void OnRateUsClick()
        {
            var val_3;
            var val_4;
            Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.SetRate(isRate:  true);
            val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameAllowBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceRateDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  (this._isIos == false) ? "dlg_rateus" : "dlg_rateus_ios", action:  "click_btn_yes", label:  "", value:  0);
            Common.EzRate.RateGame();
            this._isRate = true;
            goto typeof(View.Dialog.RateIOS.RateIOSDialog).__il2cppRuntimeField_1E0;
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "200");
            string val_2 = Locale.LocaleManager.Translate(key:  "128");
            this.RateUsText.text = Locale.LocaleManager.Translate(key:  "200");
            string val_4 = Locale.LocaleManager.Translate(key:  "130");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void OnDisable()
        {
            bool val_4;
            if(this._isRate != false)
            {
                    val_4 = this._isIos;
            }
            else
            {
                    Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.AddRateCloseCount();
                val_4 = this;
                Platform.Analytics.EzAnalytics.LogEvent(category:  (this._isIos == false) ? "dlg_rateus" : "dlg_rateus_ios", action:  "click_btn_no", label:  "", value:  0);
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  (this._isIos == false) ? "dlg_rateus" : "dlg_rateus_ios", action:  "close", label:  "", value:  0);
        }
        public RateIOSDialog()
        {
        
        }
    
    }

}
