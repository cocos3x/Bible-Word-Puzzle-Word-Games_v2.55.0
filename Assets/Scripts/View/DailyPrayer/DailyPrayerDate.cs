using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerDate : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TextDate;
        
        // Methods
        public void OnClickSignButton()
        {
            var val_8;
            var val_9;
            Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_1.<DailySignBeforeCollectStar>k__BackingField = (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord) - (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyDayStarCollectNum());
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            Platform.Analytics.EzAnalytics.SendScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = ScrShow.ScrNameEnum.ScrNameDcScr}, source:  new SourceEnum() {<Value>k__BackingField = ScrShow.SourceEnum.SourceDacScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "calender", label:  "click", value:  0);
            View.Dialog.Common.Dialog val_7 = Logic.Game.GameManager.gameDialog.Open(name:  "DailySignDialog", type:  0);
        }
        public void UpdateSignDate()
        {
            string val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyName();
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        public DailyPrayerDate()
        {
        
        }
    
    }

}
