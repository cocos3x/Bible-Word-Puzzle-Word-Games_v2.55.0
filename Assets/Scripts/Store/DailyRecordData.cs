using UnityEngine;

namespace Store
{
    public class DailyRecordData : IStoreData
    {
        // Fields
        public string DailySignDateRecord;
        public System.Collections.Generic.List<int> DailySignRecord;
        public System.Collections.Generic.List<int> DailySignBeforeRecord;
        public int DailySignCollectStarRecord;
        public int DailySignBeforeCollectStarRecord;
        public System.Collections.Generic.List<string> DailyRightAnswerList;
        public System.Collections.Generic.List<string> DailyPrayerBoxProgress;
        public System.Collections.Generic.List<string> DailyPrayerBoxProgressTest;
        public string IsTestDailyPrayerBoxProgress;
        public string DailyPrayerOpenDate;
        
        // Methods
        public void Reset()
        {
            this.DailySignDateRecord = System.String.alignConst;
            this.DailySignRecord.Clear();
            this.DailySignBeforeRecord.Clear();
            this.DailySignCollectStarRecord = 0;
            this.DailySignBeforeCollectStarRecord = 0;
            this.DailyRightAnswerList.Clear();
            this.DailyPrayerBoxProgress.Clear();
            this.DailyPrayerBoxProgressTest.Clear();
            this.IsTestDailyPrayerBoxProgress = "contrast";
            this.DailyPrayerOpenDate = System.String.alignConst;
        }
        public DailyRecordData()
        {
            this.DailySignRecord = new System.Collections.Generic.List<System.Int32>();
            this.DailySignBeforeRecord = new System.Collections.Generic.List<System.Int32>();
            this.DailyRightAnswerList = new System.Collections.Generic.List<System.String>();
            this.DailyPrayerBoxProgress = new System.Collections.Generic.List<System.String>();
            this.DailyPrayerBoxProgressTest = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
