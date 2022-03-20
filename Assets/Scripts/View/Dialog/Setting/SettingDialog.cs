using UnityEngine;

namespace View.Dialog.Setting
{
    public class SettingDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text HomeText;
        public UnityEngine.UI.Text MusicText;
        public UnityEngine.UI.Text SoundText;
        public TMPro.TMP_Text ContactUsText;
        
        // Methods
        protected override void OnEnable()
        {
            mem[1152921512675684572] = 1;
            this.OnEnable();
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_menu_dialog", action:  "a1_dialog_menu_show", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "76");
            string val_2 = Locale.LocaleManager.Translate(key:  "77");
            string val_3 = Locale.LocaleManager.Translate(key:  "79");
            string val_4 = Locale.LocaleManager.Translate(key:  "80");
            this.ContactUsText.text = Locale.LocaleManager.Translate(key:  "81");
        }
        public void OnHomeClick()
        {
            var val_4;
            var val_5;
            ScrShow.ScrNameEnum val_6;
            ScrShow.SourceEnum val_7;
            var val_8;
            var val_9;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                goto label_2;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_6 = ScrShow.ScrNameEnum.ScrNameHomeScr;
            val_5 = null;
            val_7 = ScrShow.SourceEnum.SourceMgScr;
            goto label_7;
            label_2:
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState != 4)
            {
                goto label_9;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_6 = ScrShow.ScrNameEnum.ScrNameHomeScr;
            val_9 = null;
            val_7 = ScrShow.SourceEnum.SourceDcScr;
            label_7:
            Platform.Analytics.EzAnalytics.SendScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = val_6}, source:  new SourceEnum() {<Value>k__BackingField = val_7});
            label_9:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_menu_dialog", action:  "a2_button_to_home_click", label:  "", value:  0);
            Message.Messager.Dispatch(cmd:  34);
            Message.Messager.Dispatch(cmd:  35);
            Message.Messager.Dispatch(cmd:  70);
            mem[1152921512676015596] = 0;
            Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  3);
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
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "ContactUsDialog", type:  0);
        }
        public void OnClickQuitButton()
        {
            UnityEngine.Object val_5;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_menu_dialog", action:  "a2_button_quit_click", label:  "", value:  0);
            val_5 = 0;
            if(View.Game.GameController.GetInstance() != val_5)
            {
                    View.Game.GameController.GetInstance().DestroyAd();
                val_5 = 0;
                Message.Messager.Dispatch(cmd:  70);
            }
            
            View.Dialog.Common.Dialog val_4 = Logic.Game.GameManager.gameDialog.Open(name:  "QuitGameDialog", type:  0);
        }
        public SettingDialog()
        {
        
        }
    
    }

}
