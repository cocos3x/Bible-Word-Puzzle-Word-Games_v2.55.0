using UnityEngine;

namespace View.Dialog.HomeSetting
{
    public class HomeSettingDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text NotificationText;
        public UnityEngine.UI.Text MusicText;
        public UnityEngine.UI.Text SoundText;
        public TMPro.TMP_Text ContactUsText;
        public TMPro.TMP_Text PPText;
        
        // Methods
        protected override void OnEnable()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_home_menu", action:  "show_home_menu", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            this.OnEnable();
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "88");
            string val_2 = Locale.LocaleManager.Translate(key:  "89");
            string val_3 = Locale.LocaleManager.Translate(key:  "79");
            string val_4 = Locale.LocaleManager.Translate(key:  "80");
            this.ContactUsText.text = Locale.LocaleManager.Translate(key:  "81");
            this.PPText.text = Locale.LocaleManager.Translate(key:  "90");
        }
        public void OnContactClick()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameContactUsBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceMenuDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_home_menu", action:  "click_contact", label:  "", value:  0);
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "ContactUsDialog", type:  0);
        }
        public void OnPrivacyPolicyClick()
        {
            UnityEngine.Application.OpenURL(url:  "https://idailybread.org/pp.html");
        }
        public void OnCloseClick()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_home_menu", action:  "click_btn_close", label:  "", value:  0);
        }
        public HomeSettingDialog()
        {
        
        }
    
    }

}
