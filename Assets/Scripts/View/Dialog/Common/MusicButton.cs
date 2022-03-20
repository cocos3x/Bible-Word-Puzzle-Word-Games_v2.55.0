using UnityEngine;

namespace View.Dialog.Common
{
    public class MusicButton : MonoBehaviour
    {
        // Fields
        private View.CommonItem.ImageSwitch funSwitch;
        
        // Methods
        private void Awake()
        {
            this.funSwitch = this.GetComponent<View.CommonItem.ImageSwitch>();
            UnityEngine.UI.Button val_2 = this.GetComponent<UnityEngine.UI.Button>();
            val_2.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Common.MusicButton::<Awake>b__1_0()));
        }
        private void OnEnable()
        {
            this.funSwitch.isOn = Common.Singleton<Data.Settings.SettingsDataManager>.Instance.IsMusicOn;
        }
        public MusicButton()
        {
        
        }
        private void <Awake>b__1_0()
        {
            var val_6;
            var val_7;
            string val_8;
            string val_9;
            this.funSwitch.isOn = (this.funSwitch._isOn == false) ? 1 : 0;
            Common.Singleton<Data.Settings.SettingsDataManager>.Instance.ChangeMusicOn(isOn:  this.funSwitch._isOn);
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameMusicBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceMenuDlg});
            if(View.Game.GameController.GetInstance() != 0)
            {
                    val_8 = "a2_button_music_switch_click";
                val_9 = "game_menu_dialog";
            }
            else
            {
                    val_8 = "click_button_music";
                val_9 = "dlg_home_menu";
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  val_9, action:  val_8, label:  (this.funSwitch._isOn == true) ? "on" : "off", value:  0);
        }
    
    }

}
