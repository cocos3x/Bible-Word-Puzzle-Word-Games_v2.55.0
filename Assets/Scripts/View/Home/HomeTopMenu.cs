using UnityEngine;

namespace View.Home
{
    public class HomeTopMenu : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Button ButtonLottery;
        public UnityEngine.Animator AnimatorLottery;
        private System.Collections.Generic.List<string> _lotteryProgress;
        
        // Methods
        public void OnClickPersonalButton()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameFaithBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceHomeScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_mydata", action:  "show_from", label:  "main", value:  0);
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "PersonalInfoDialog", type:  0);
        }
        public void OnClickLotteryButton()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameDrBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceHomeScr});
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameDrDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingClick});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "daily_reward", action:  "click_home_enter", label:  "", value:  0);
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "DailyLotteryTestDialog", type:  0);
        }
        public void OnClickSettingButton()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameMenuBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceHomeScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "settings", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_prepare", action:  "a1_button_menu_click", label:  "", value:  0);
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "HomeSettingDialog", type:  0);
        }
        public void UpdateLotteryState()
        {
            if((Logic.Game.GameManager.gameLevel.IsPassLevelForUnlockLevel(sectionIndex:  1, levelIndex:  2)) != true)
            {
                    1 = Logic.Game.GameManager.gameLevel.IsAllLevelPass(section:  0, level:  0);
            }
            
            this.ButtonLottery.gameObject.SetActive(value:  1);
            System.Collections.Generic.List<System.String> val_6 = Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.GetDailyGiftBoxProgress();
            this._lotteryProgress = val_6;
            if((public static Data.DailyLottery.DailyLotteryDataManager Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>::get_Instance()) != 0)
            {
                    if(((val_6.IndexOf(item:  "off")) & 2147483648) != 0)
            {
                goto label_9;
            }
            
            }
            
            label_11:
            this.AnimatorLottery.Play(stateName:  "LotteryHighLight");
            return;
            label_9:
            if(this.AnimatorLottery != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  43, action:  new System.Action(object:  this, method:  public System.Void View.Home.HomeTopMenu::UpdateLotteryState()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  43, action:  new System.Action(object:  this, method:  public System.Void View.Home.HomeTopMenu::UpdateLotteryState()));
        }
        public HomeTopMenu()
        {
        
        }
    
    }

}
