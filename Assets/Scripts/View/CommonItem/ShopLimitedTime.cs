using UnityEngine;

namespace View.CommonItem
{
    public class ShopLimitedTime : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TextTime;
        private long ResidueSeconds;
        
        // Methods
        public void SetLimitedTimeCountDown(long seconds)
        {
            this.ResidueSeconds = seconds;
            this.CountDown();
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopLimitedTime::CountDown()));
            Common.TimerEvent.Add(time:  1f, callback:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopLimitedTime::CountDown()), isrepeat:  true);
        }
        private void CountDown()
        {
            if(this.ResidueSeconds <= 0)
            {
                    this.ResidueSeconds = 0;
                Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopLimitedTime::CountDown()));
                Message.Messager.Dispatch(cmd:  79);
            }
            
            string val_4 = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "62"), arg0:  Common.GlobalMethods.TransTimeSecondIntToString(second:  this.ResidueSeconds));
            long val_5 = this.ResidueSeconds;
            val_5 = val_5 - 1;
            this.ResidueSeconds = val_5;
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopLimitedTime::CountDown()));
        }
        public ShopLimitedTime()
        {
        
        }
    
    }

}
