using UnityEngine;

namespace View.Dialog.QuitGame
{
    public class QuitGameDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text YesText;
        public TMPro.TMP_Text NoText;
        
        // Methods
        protected override void OnEnable()
        {
            var val_1;
            var val_2;
            this.OnEnable();
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameQuitDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingAuto});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_quit_game", action:  "show", label:  "", value:  0);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "84");
            string val_2 = Locale.LocaleManager.Translate(key:  "85");
            this.YesText.text = Locale.LocaleManager.Translate(key:  "86");
            this.NoText.text = Locale.LocaleManager.Translate(key:  "87");
        }
        public void OnYesClick()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameYesBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceQuitDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_quit_game", action:  "click_btn_yes", label:  "", value:  0);
            Common.EzQuit.Quit();
        }
        public void OnNoClick()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameNoBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceQuitDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_quit_game", action:  "click_btn_no", label:  "", value:  0);
            goto typeof(View.Dialog.QuitGame.QuitGameDialog).__il2cppRuntimeField_1E0;
        }
        public QuitGameDialog()
        {
        
        }
    
    }

}
