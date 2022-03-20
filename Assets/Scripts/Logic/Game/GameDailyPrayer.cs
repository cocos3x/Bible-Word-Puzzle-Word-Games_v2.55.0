using UnityEngine;

namespace Logic.Game
{
    public class GameDailyPrayer
    {
        // Fields
        private Data.DailyPrayer.DailyPrayerSignAllBeans _dailyPrayerSignAllBeans;
        private Data.DailyPrayer.DailyPrayerSignBeans _dailyPrayerSignBeans;
        private Data.DailyPrayer.DailyPrayerSignBean _currentSignBean;
        
        // Methods
        public void Init()
        {
            this._dailyPrayerSignAllBeans = UnityEngine.JsonUtility.FromJson<Data.DailyPrayer.DailyPrayerSignAllBeans>(json:  Common.EzFile.RijndaelDecrypt(pString:  Resource.ResManager.GetConfig(configName:  this.GetDailyConfigName()).text, pKey:  ""));
        }
        private string GetDailyConfigName()
        {
            var val_2;
            var val_3;
            val_2 = "Config/Game/DailyPrayer/daily_verse";
            Locale.LocaleE val_1 = Locale.LocaleManager.GetCurLanguage();
            if(val_1 == 3)
            {
                goto label_1;
            }
            
            if(val_1 == 2)
            {
                goto label_2;
            }
            
            if(val_1 != 1)
            {
                    return (string)val_3;
            }
            
            val_3 = "Config/Game/DailyPrayer/daily_verse_pt";
            return (string)val_3;
            label_1:
            val_3 = "Config/Game/DailyPrayer/daily_verse_fr";
            return (string)val_3;
            label_2:
            val_3 = "Config/Game/DailyPrayer/daily_verse_es";
            return (string)val_3;
        }
        public Data.DailyPrayer.DailyPrayerBean GetDailyPrayerBeanBySignDate()
        {
            var val_9;
            var val_10;
            val_9 = this;
            this._dailyPrayerSignBeans = this.GetDailyPrayerBeanByMonth();
            Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_5 = UnityEngine.Mathf.Clamp(value:  (val_2.<CurrentDailyDay>k__BackingField) - 1, min:  0, max:  W23 - 1);
            Data.DailyPrayer.DailyPrayerSignBeans val_9 = this._dailyPrayerSignBeans;
            if(val_9 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (val_5 << 3);
            this._currentSignBean = val_9;
            int val_7 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex();
            if(val_7 < 1152921512608795232)
            {
                    int val_8 = UnityEngine.Mathf.Clamp(value:  val_7, min:  0, max:  21201647);
                Data.DailyPrayer.DailyPrayerSignBean val_10 = this._currentSignBean;
                val_9 = val_8;
                if(val_10 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_10 = val_10 + (val_9 << 3);
                return (Data.DailyPrayer.DailyPrayerBean)val_10;
            }
            
            val_10 = 0;
            return (Data.DailyPrayer.DailyPrayerBean)val_10;
        }
        public int GetDailyPrayerLevelCountBySignDate()
        {
            this._dailyPrayerSignBeans = this.GetDailyPrayerBeanByMonth();
            Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_5 = UnityEngine.Mathf.Clamp(value:  (val_2.<CurrentDailyDay>k__BackingField) - 1, min:  0, max:  W21 - 1);
            Data.DailyPrayer.DailyPrayerSignBeans val_6 = this._dailyPrayerSignBeans;
            if(val_6 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_5 << 3);
            this._currentSignBean = val_6;
            return 0;
        }
        private Data.DailyPrayer.DailyPrayerSignBeans GetDailyPrayerBeanByMonth()
        {
            System.Collections.Generic.List<Data.DailyPrayer.DailyPrayerSignBeans> val_7;
            var val_8;
            val_7 = this;
            if(W21 != 0)
            {
                    Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                System.DateTime val_2 = System.DateTime.Now;
                val_1.<CurrentMonth>k__BackingField = val_2.dateData.Month;
                Data.DailyRecord.DailyRecordDataManager val_4 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                val_7 = this._dailyPrayerSignAllBeans.months;
                int val_7 = val_4.<CurrentMonth>k__BackingField;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_7 = val_7 + ((val_7 - ((val_7 / W21) * W21)) << 3);
                val_8 = mem[(val_4.<CurrentMonth>k__BackingField + (val_4.<CurrentMonth>k__BackingField - ((val_4.<CurrentMonth>k__BackingField / W21) * W21)) << 3) + 32];
                val_8 = (val_4.<CurrentMonth>k__BackingField + (val_4.<CurrentMonth>k__BackingField - ((val_4.<CurrentMonth>k__BackingField / W21) * W21)) << 3) + 32;
                return (Data.DailyPrayer.DailyPrayerSignBeans)val_8;
            }
            
            val_8 = 0;
            return (Data.DailyPrayer.DailyPrayerSignBeans)val_8;
        }
        public GameDailyPrayer()
        {
        
        }
    
    }

}
