using UnityEngine;

namespace Logic.DailyPrayer
{
    public class DailyPrayerControllers : SingletonController<Logic.DailyPrayer.DailyPrayerControllers>
    {
        // Fields
        private bool <IsGameComplete>k__BackingField;
        private int <NowCurLevelUseHintCount>k__BackingField;
        private int <NowCurLevelUseRefreshCount>k__BackingField;
        private int <NowCurLevelUseFireworkCount>k__BackingField;
        private int <NowCurLevelWrongCount>k__BackingField;
        private int <NowCurLevelMaxComboCount>k__BackingField;
        private string <NowCurLevelName>k__BackingField;
        
        // Properties
        public bool IsGameComplete { get; set; }
        public int NowCurLevelUseHintCount { get; set; }
        public int NowCurLevelUseRefreshCount { get; set; }
        public int NowCurLevelUseFireworkCount { get; set; }
        public int NowCurLevelWrongCount { get; set; }
        public int NowCurLevelMaxComboCount { get; set; }
        public string NowCurLevelName { get; set; }
        
        // Methods
        public bool get_IsGameComplete()
        {
            return (bool)this.<IsGameComplete>k__BackingField;
        }
        public void set_IsGameComplete(bool value)
        {
            this.<IsGameComplete>k__BackingField = value;
        }
        public int get_NowCurLevelUseHintCount()
        {
            return (int)this.<NowCurLevelUseHintCount>k__BackingField;
        }
        public void set_NowCurLevelUseHintCount(int value)
        {
            this.<NowCurLevelUseHintCount>k__BackingField = value;
        }
        public int get_NowCurLevelUseRefreshCount()
        {
            return (int)this.<NowCurLevelUseRefreshCount>k__BackingField;
        }
        public void set_NowCurLevelUseRefreshCount(int value)
        {
            this.<NowCurLevelUseRefreshCount>k__BackingField = value;
        }
        public int get_NowCurLevelUseFireworkCount()
        {
            return (int)this.<NowCurLevelUseFireworkCount>k__BackingField;
        }
        public void set_NowCurLevelUseFireworkCount(int value)
        {
            this.<NowCurLevelUseFireworkCount>k__BackingField = value;
        }
        public int get_NowCurLevelWrongCount()
        {
            return (int)this.<NowCurLevelWrongCount>k__BackingField;
        }
        public void set_NowCurLevelWrongCount(int value)
        {
            this.<NowCurLevelWrongCount>k__BackingField = value;
        }
        public int get_NowCurLevelMaxComboCount()
        {
            return (int)this.<NowCurLevelMaxComboCount>k__BackingField;
        }
        public void set_NowCurLevelMaxComboCount(int value)
        {
            this.<NowCurLevelMaxComboCount>k__BackingField = value;
        }
        public string get_NowCurLevelName()
        {
            return (string)this.<NowCurLevelName>k__BackingField;
        }
        public void set_NowCurLevelName(string value)
        {
            this.<NowCurLevelName>k__BackingField = value;
        }
        public string GetCurDailyName()
        {
            string val_8;
            Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_7 = val_1.<CurrentMonth>k__BackingField;
            val_7 = val_7 + 180;
            Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            Data.DailyRecord.DailyRecordDataManager val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if((val_2.<CurrentDailyDay>k__BackingField) > 9)
            {
                    val_8 = "{0} {1}";
                return (string)System.String.Format(format:  val_8 = "{0} 0{1}", arg0:  Locale.LocaleManager.Translate(key:  val_7.ToString()), arg1:  val_5.<CurrentDailyDay>k__BackingField);
            }
            
            return (string)System.String.Format(format:  val_8, arg0:  Locale.LocaleManager.Translate(key:  val_7.ToString()), arg1:  val_5.<CurrentDailyDay>k__BackingField);
        }
        public string GetCurDailyLevel()
        {
            return (string)System.String.Format(format:  "{0}_{1}", arg0:  this.GetCurDailyName().Replace(oldValue:  " ", newValue:  ""), arg1:  (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex()) + 1);
        }
        public DailyPrayerControllers()
        {
        
        }
    
    }

}
