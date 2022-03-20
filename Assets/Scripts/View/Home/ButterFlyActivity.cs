using UnityEngine;

namespace View.Home
{
    public class ButterFlyActivity : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshProUGUI TextTips;
        private long _surplusSeconds;
        
        // Methods
        public void OnClickActivityButton()
        {
            var val_2;
            var val_3;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "enter_click", label:  "main", value:  0);
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendActivScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = ActivScrShow.ScrNameEnum.ScrNameButterflyScr}, source:  new SourceEnum() {<Value>k__BackingField = ActivScrShow.SourceEnum.SourceHomeScr});
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyDialog", type:  0);
        }
        private void OnEnable()
        {
            this._surplusSeconds = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityCloseTimeSpan();
            this.CountDown();
            Common.TimerEvent.Add(time:  1f, callback:  new System.Action(object:  this, method:  System.Void View.Home.ButterFlyActivity::CountDown()), isrepeat:  true);
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Home.ButterFlyActivity::CountDown()));
        }
        private void CountDown()
        {
            if((this._surplusSeconds >= 1) && ((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpenForHome()) != false))
            {
                    this.TextTips.text = Common.GlobalMethods.TransTimeSecondToDayString(second:  this._surplusSeconds);
            }
            else
            {
                    Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Home.ButterFlyActivity::CountDown()));
                this.TextTips.text = Locale.LocaleManager.Translate(key:  "232");
                this.gameObject.SetActive(value:  Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.HomeIsShowButterFlyActivity());
            }
            
            long val_10 = this._surplusSeconds;
            val_10 = val_10 - 1;
            this._surplusSeconds = val_10;
        }
        public ButterFlyActivity()
        {
        
        }
    
    }

}
