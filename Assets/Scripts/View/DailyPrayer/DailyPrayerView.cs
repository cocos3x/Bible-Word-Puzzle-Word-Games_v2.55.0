using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerView : UIView
    {
        // Fields
        private static View.DailyPrayer.DailyPrayerView _instance;
        
        // Methods
        public static View.DailyPrayer.DailyPrayerView Create(UnityEngine.Transform parent)
        {
            if(View.DailyPrayer.DailyPrayerView._instance != 0)
            {
                    return (View.DailyPrayer.DailyPrayerView)View.DailyPrayer.DailyPrayerView._instance;
            }
            
            View.DailyPrayer.DailyPrayerView._instance = View.GameViewFactory.CreateDailyPrayerView(parent:  parent);
            return (View.DailyPrayer.DailyPrayerView)View.DailyPrayer.DailyPrayerView._instance;
        }
        public void ShowDailyPrayerView(Logic.Define.OpenDailyPrayerFrom dailyPrayerFrom)
        {
            Logic.Gameplay.GameplayController val_1 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            val_1.<GameSceneShouldAd>k__BackingField = false;
            this.gameObject.SetActive(value:  true);
        }
        public void HideDailyPrayerView()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        private void RestartNextGame()
        {
        
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerView::RestartNextGame()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerView::RestartNextGame()));
        }
        public DailyPrayerView()
        {
        
        }
    
    }

}
