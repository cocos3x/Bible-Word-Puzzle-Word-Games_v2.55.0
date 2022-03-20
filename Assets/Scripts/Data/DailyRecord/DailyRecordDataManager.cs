using UnityEngine;

namespace Data.DailyRecord
{
    public class DailyRecordDataManager : Singleton<Data.DailyRecord.DailyRecordDataManager>
    {
        // Fields
        public readonly int[] StarBoxProgress;
        public readonly int[] RewardCounts;
        private bool <DailySignIsOpened>k__BackingField;
        private bool <DailySignIsCanOperate>k__BackingField;
        private int <DailySignBeforeCollectStar>k__BackingField;
        private string <DailyLevel>k__BackingField;
        private int _currentDailyLevelIndex;
        private int _unlockDailyLevelIndex;
        private int <CurrentDailyDay>k__BackingField;
        private int <CurrentMonth>k__BackingField;
        
        // Properties
        public bool DailySignIsOpened { get; set; }
        public bool DailySignIsCanOperate { get; set; }
        public string DailySignDateRecord { get; set; }
        public System.Collections.Generic.List<int> DailySignRecord { get; set; }
        public System.Collections.Generic.List<int> DailySignBeforeRecord { get; set; }
        public int DailySignCollectStarRecord { get; set; }
        public int DailySignBeforeCollectStarRecord { get; set; }
        public System.Collections.Generic.List<string> DailyRightAnswerList { get; }
        public System.Collections.Generic.List<string> DailyPrayerBoxProgress { get; set; }
        public System.Collections.Generic.List<string> DailyPrayerBoxProgressTest { get; set; }
        public string IsTestDailyPrayerBoxProgress { get; set; }
        public string DailyPrayerOpenDate { get; set; }
        public int DailySignBeforeCollectStar { get; set; }
        public string DailyLevel { get; set; }
        public int CurrentDailyDay { get; set; }
        public int CurrentMonth { get; set; }
        public int SignToday { get; }
        
        // Methods
        public void set_DailySignIsOpened(bool value)
        {
            this.<DailySignIsOpened>k__BackingField = value;
        }
        public bool get_DailySignIsOpened()
        {
            return (bool)this.<DailySignIsOpened>k__BackingField;
        }
        public void set_DailySignIsCanOperate(bool value)
        {
            this.<DailySignIsCanOperate>k__BackingField = value;
        }
        public bool get_DailySignIsCanOperate()
        {
            return (bool)this.<DailySignIsCanOperate>k__BackingField;
        }
        public void Init()
        {
            this.SetDailySignRecord(value:  this.DailySignRecord);
            this.SetDailySignBeforeRecord(value:  this.DailySignBeforeRecord);
            System.DateTime val_3 = System.DateTime.Now;
            this.SetDailySignDateRecord(value:  val_3.dateData.GetDateYearAndMonth(dateTime:  new System.DateTime() {dateData = val_3.dateData}));
        }
        public string get_DailySignDateRecord()
        {
            return (string)Store.DailyRecordData.__il2cppRuntimeField_name;
        }
        private void set_DailySignDateRecord(string value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_10 = value;
        }
        public System.Collections.Generic.List<int> get_DailySignRecord()
        {
            return (System.Collections.Generic.List<System.Int32>)Store.DailyRecordData.__il2cppRuntimeField_namespaze;
        }
        private void set_DailySignRecord(System.Collections.Generic.List<int> value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_18 = value;
        }
        public System.Collections.Generic.List<int> get_DailySignBeforeRecord()
        {
            return (System.Collections.Generic.List<System.Int32>)Store.DailyRecordData.__il2cppRuntimeField_byval_arg;
        }
        private void set_DailySignBeforeRecord(System.Collections.Generic.List<int> value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_20 = value;
        }
        public int get_DailySignCollectStarRecord()
        {
            return (int)typeof(Store.DailyRecordData).__il2cppRuntimeField_28;
        }
        private void set_DailySignCollectStarRecord(int value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_28 = value;
        }
        public int get_DailySignBeforeCollectStarRecord()
        {
            return (int)typeof(Store.DailyRecordData).__il2cppRuntimeField_2C;
        }
        private void set_DailySignBeforeCollectStarRecord(int value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_2C = value;
        }
        public System.Collections.Generic.List<string> get_DailyRightAnswerList()
        {
            return (System.Collections.Generic.List<System.String>)Store.DailyRecordData.__il2cppRuntimeField_this_arg;
        }
        public System.Collections.Generic.List<string> get_DailyPrayerBoxProgress()
        {
            return (System.Collections.Generic.List<System.String>)typeof(Store.DailyRecordData).__il2cppRuntimeField_38;
        }
        private void set_DailyPrayerBoxProgress(System.Collections.Generic.List<string> value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_38 = value;
        }
        public System.Collections.Generic.List<string> get_DailyPrayerBoxProgressTest()
        {
            return (System.Collections.Generic.List<System.String>)Store.DailyRecordData.__il2cppRuntimeField_element_class;
        }
        private void set_DailyPrayerBoxProgressTest(System.Collections.Generic.List<string> value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_40 = value;
        }
        public string get_IsTestDailyPrayerBoxProgress()
        {
            return (string)Store.DailyRecordData.__il2cppRuntimeField_castClass;
        }
        private void set_IsTestDailyPrayerBoxProgress(string value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_48 = value;
        }
        public string get_DailyPrayerOpenDate()
        {
            return (string)Store.DailyRecordData.__il2cppRuntimeField_declaringType;
        }
        private void set_DailyPrayerOpenDate(string value)
        {
            typeof(Store.DailyRecordData).__il2cppRuntimeField_50 = value;
        }
        public void AddDailySignCollectStarRecord()
        {
            int val_1 = this.DailySignCollectStarRecord;
            val_1.DailySignCollectStarRecord = val_1 + 1;
        }
        public void SetDailySignBeforeCollectStarRecord(int value)
        {
            this.DailySignBeforeCollectStarRecord = value;
        }
        public void SaveDailyRightAnswerList(System.Collections.Generic.List<string> data)
        {
            System.Collections.Generic.List<System.String> val_1 = this.DailyRightAnswerList;
            val_1.Clear();
            if(data == null)
            {
                    return;
            }
            
            if(1152921508357928576 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                if(val_3 >= 1152921508357928576)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1.DailyRightAnswerList.Add(item:  "mission");
                val_3 = val_3 + 1;
            }
            while(val_3 < 21133048);
        
        }
        public System.Collections.Generic.List<string> GetDailyRightAnswerList()
        {
            return this.DailyRightAnswerList;
        }
        public void SaveDailyPrayerBoxProgress(System.Collections.Generic.List<string> data)
        {
            if(data != null)
            {
                    this.DailyPrayerBoxProgress = data;
                return;
            }
            
            this.DailyPrayerBoxProgress.Clear();
        }
        public System.Collections.Generic.List<string> GetDailyPrayerBoxProgress()
        {
            return this.DailyPrayerBoxProgress;
        }
        public void SaveDailyPrayerBoxProgressTest(System.Collections.Generic.List<string> data)
        {
            if(data != null)
            {
                    this.DailyPrayerBoxProgressTest = data;
                return;
            }
            
            this.DailyPrayerBoxProgressTest.Clear();
        }
        public System.Collections.Generic.List<string> GetDailyPrayerBoxProgressTest()
        {
            return this.DailyPrayerBoxProgressTest;
        }
        public void SaveDailyPrayerBoxProgressIsTest(string data)
        {
            this.IsTestDailyPrayerBoxProgress = data;
        }
        public bool GetDailyPrayerBoxProgressIsTest()
        {
            return System.String.op_Equality(a:  this.IsTestDailyPrayerBoxProgress, b:  "TestMonth");
        }
        public void SaveDailyPrayerOpenDate()
        {
            System.DateTime val_1 = System.DateTime.Now;
            string val_3 = val_1.dateData.GetDateYearAndMonth(dateTime:  new System.DateTime() {dateData = val_1.dateData})(val_1.dateData.GetDateYearAndMonth(dateTime:  new System.DateTime() {dateData = val_1.dateData})) + this.<CurrentDailyDay>k__BackingField(this.<CurrentDailyDay>k__BackingField);
            val_3.DailyPrayerOpenDate = val_3;
        }
        public bool IsTodayDailyPrayerOpened()
        {
            System.DateTime val_1 = System.DateTime.Now;
            string val_3 = val_1.dateData.GetDateYearAndMonth(dateTime:  new System.DateTime() {dateData = val_1.dateData})(val_1.dateData.GetDateYearAndMonth(dateTime:  new System.DateTime() {dateData = val_1.dateData})) + this.<CurrentDailyDay>k__BackingField(this.<CurrentDailyDay>k__BackingField);
            return (bool)val_3.DailyPrayerOpenDate.Equals(value:  val_3);
        }
        public void SynchronizationDailySignRecord()
        {
            var val_6;
            var val_7;
            System.Collections.Generic.List<System.Int32> val_1 = this.DailySignBeforeRecord;
            val_1.Clear();
            val_7 = 0;
            do
            {
                if(val_7 >= 1152921512594517776)
            {
                    return;
            }
            
                System.Collections.Generic.List<System.Int32> val_3 = val_1.DailySignRecord.DailySignBeforeRecord;
                val_6 = val_3;
                System.Collections.Generic.List<System.Int32> val_4 = val_3.DailySignRecord;
                if(val_7 >= 1152921512594517776)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6.Add(item:  -144359168);
                val_7 = val_7 + 1;
            }
            while(val_6.DailySignRecord != null);
            
            throw new NullReferenceException();
        }
        public int get_DailySignBeforeCollectStar()
        {
            return (int)this.<DailySignBeforeCollectStar>k__BackingField;
        }
        public void set_DailySignBeforeCollectStar(int value)
        {
            this.<DailySignBeforeCollectStar>k__BackingField = value;
        }
        public string get_DailyLevel()
        {
            return (string)this.<DailyLevel>k__BackingField;
        }
        public void set_DailyLevel(string value)
        {
            this.<DailyLevel>k__BackingField = value;
        }
        public int GetCurrentDailyLevelIndex()
        {
            int val_1 = this.GetDailySignRecordFromDate(day:  this.<CurrentDailyDay>k__BackingField);
            this._currentDailyLevelIndex = val_1;
            val_1 = val_1 & (~(val_1 >> 31));
            this._currentDailyLevelIndex = val_1;
            return val_1;
        }
        public int GetCurrentDailyLevelIndex(int day)
        {
            int val_1 = this.GetDailySignRecordFromDate(day:  day);
            this._currentDailyLevelIndex = val_1;
            val_1 = val_1 & (~(val_1 >> 31));
            this._currentDailyLevelIndex = val_1;
            return val_1;
        }
        public int GetUnlockDailyLevelIndex()
        {
            int val_1 = this.SignToday;
            int val_2 = val_1.GetDailySignRecordFromDate(day:  val_1);
            this._unlockDailyLevelIndex = val_2;
            return val_2;
        }
        public int get_CurrentDailyDay()
        {
            return (int)this.<CurrentDailyDay>k__BackingField;
        }
        public void set_CurrentDailyDay(int value)
        {
            this.<CurrentDailyDay>k__BackingField = value;
        }
        public int get_CurrentMonth()
        {
            return (int)this.<CurrentMonth>k__BackingField;
        }
        public void set_CurrentMonth(int value)
        {
            this.<CurrentMonth>k__BackingField = value;
        }
        public int get_SignToday()
        {
            System.DateTime val_1 = System.DateTime.Now;
            return (int)val_1.dateData.Day;
        }
        public int GetCurrentLevelReward()
        {
            int val_1 = this.GetCurrentDailyLevelIndex();
            val_1 = (val_1 * 10) + 10;
            return (int)val_1;
        }
        public bool IsAllPassLevelFromCurrentDay()
        {
            return (bool)(this.GetCurrentDailyLevelIndex() == Logic.Game.GameManager.gameDailyPrayer.GetDailyPrayerLevelCountBySignDate()) ? 1 : 0;
        }
        public int GetDailySignRecordFromDate(int day)
        {
            var val_5;
            var val_6;
            val_5 = day;
            if(true >= 1)
            {
                    var val_5 = this.DailySignRecord.DailySignRecord;
                int val_3 = val_5 - 1;
                val_6 = 0;
                if(true < 1)
            {
                    return (int)val_6;
            }
            
                if(val_5 < val_5)
            {
                    return (int)val_6;
            }
            
                val_5 = this.DailySignRecord;
                if(val_5 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + (val_3 << 2);
                return (int)val_6;
            }
            
            val_6 = 0;
            return (int)val_6;
        }
        public int GetDailySignBeforeRecordFromDate(int day)
        {
            var val_6;
            var val_7;
            val_6 = day;
            System.Collections.Generic.List<System.Int32> val_1 = this.DailySignBeforeRecord;
            if((val_1 != null) && (true >= 1))
            {
                    var val_6 = val_1.DailySignBeforeRecord.DailySignBeforeRecord;
                int val_4 = val_6 - 1;
                val_7 = 0;
                if(true < 1)
            {
                    return (int)val_7;
            }
            
                if(val_6 < val_6)
            {
                    return (int)val_7;
            }
            
                val_6 = this.DailySignBeforeRecord;
                if(val_6 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + (val_4 << 2);
                return (int)val_7;
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        public int GetCurrentDailyDayStarCollectNum()
        {
            int val_1 = this.GetDailySignBeforeRecordFromDate(day:  this.<CurrentDailyDay>k__BackingField);
            int val_2 = val_1.GetDailySignRecordFromDate(day:  this.<CurrentDailyDay>k__BackingField);
            int val_4 = this.<CurrentDailyDay>k__BackingField;
            val_2 = val_2 - (val_1 & (~(val_1 >> 31)));
            val_4 = val_4 & (~(val_4 >> 31));
            this.<CurrentDailyDay>k__BackingField = val_4;
            return (int)val_2;
        }
        public void SetDailySignDefaultRecordFromDate()
        {
            if(true < 1)
            {
                    return;
            }
            
            if((this.<CurrentDailyDay>k__BackingField) > true)
            {
                    return;
            }
            
            if((this.<CurrentDailyDay>k__BackingField) < 1)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.Int32> val_3 = this.DailySignRecord.DailySignRecord.DailySignRecord;
            int val_7 = this.<CurrentDailyDay>k__BackingField;
            int val_4 = val_7 - 1;
            if(W9 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (val_4 << 2);
            if((((this.<CurrentDailyDay>k__BackingField + ((this.<CurrentDailyDay>k__BackingField - 1)) << 2) + 32) & 2147483648) == 0)
            {
                    return;
            }
            
            this.DailySignRecord.set_Item(index:  (this.<CurrentDailyDay>k__BackingField) - 1, value:  0);
        }
        public void AddDailySignRecordFromDate()
        {
            if(true < 1)
            {
                    return;
            }
            
            if((this.<CurrentDailyDay>k__BackingField) > true)
            {
                    return;
            }
            
            if((this.<CurrentDailyDay>k__BackingField) < 1)
            {
                    return;
            }
            
            int val_6 = this.<CurrentDailyDay>k__BackingField;
            int val_4 = val_6 - 1;
            if(W9 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_4 << 2);
            this.DailySignRecord.DailySignRecord.DailySignRecord.set_Item(index:  val_4, value:  ((this.<CurrentDailyDay>k__BackingField + ((this.<CurrentDailyDay>k__BackingField - 1)) << 2) + 32) + 1);
        }
        private string GetDateYearAndMonth(System.DateTime dateTime)
        {
            return (string)dateTime.dateData.GetDateTimeFormats(format:  'y')[0];
        }
        private void SetDailySignDateRecord(string value)
        {
            bool val_2 = System.String.IsNullOrEmpty(value:  this.DailySignDateRecord);
            if(val_2 != true)
            {
                    if((val_2.DailySignDateRecord.Equals(value:  value)) != true)
            {
                    this.SetDailySignRecord(value:  0);
                this.SetDailySignBeforeRecord(value:  0);
                this.DailySignCollectStarRecord = 0;
                this.DailySignBeforeCollectStarRecord = 0;
            }
            
            }
            
            this.DailySignDateRecord = value;
        }
        private void SetDailySignRecord(System.Collections.Generic.List<int> value)
        {
            System.Collections.Generic.List<System.Int32> val_5 = value;
            if(val_5 != null)
            {
                    this.DailySignRecord = val_5;
            }
            else
            {
                    System.Collections.Generic.List<System.Int32> val_1 = this.DailySignRecord;
                val_1.Clear();
            }
            
            if(1152921512594517776 > 30)
            {
                    return;
            }
            
            if(1152921512594517776 > 30)
            {
                    return;
            }
            
            do
            {
                val_1.DailySignRecord.DailySignRecord.DailySignRecord.Add(item:  0);
                val_5 = 21166176;
            }
            while(val_5 < 30);
        
        }
        private void SetDailySignBeforeRecord(System.Collections.Generic.List<int> value)
        {
            System.Collections.Generic.List<System.Int32> val_5 = value;
            if(val_5 != null)
            {
                    this.DailySignBeforeRecord = val_5;
            }
            else
            {
                    System.Collections.Generic.List<System.Int32> val_1 = this.DailySignBeforeRecord;
                val_1.Clear();
            }
            
            if(1152921512594517776 > 30)
            {
                    return;
            }
            
            if(1152921512594517776 > 30)
            {
                    return;
            }
            
            do
            {
                val_1.DailySignBeforeRecord.DailySignBeforeRecord.DailySignBeforeRecord.Add(item:  0);
                val_5 = 21166176;
            }
            while(val_5 < 30);
        
        }
        public DailyRecordDataManager()
        {
            this.StarBoxProgress = new int[4] {8, 30, 60, 80};
            this.RewardCounts = new int[4] {40, 60, 80, 100};
        }
    
    }

}
