using UnityEngine;

namespace Data.ButterFly
{
    public class ButterFlyDataManager : Singleton<Data.ButterFly.ButterFlyDataManager>
    {
        // Fields
        public int[] ButterFlyActivityOpenTimes;
        public System.DayOfWeek[] DayOfWeekTimes;
        public string[] ButterFlyNames;
        public int[] ChrysalisProgress;
        public int ChrysalisOnceMaxCount;
        public int ChrysalisMaxCount;
        public int ButterFlyMaxCount;
        public int SampleShowButterFlyMaxCount;
        private int <LevelChrysalisMaxCount>k__BackingField;
        private System.Collections.Generic.List<int> _collectButterFlyList;
        
        // Properties
        public int LevelChrysalisMaxCount { get; set; }
        public int LevelChrysalisCount { get; set; }
        public int ChrysalisCount { get; set; }
        public System.Collections.Generic.List<int> ButterFlyList { get; set; }
        public bool ShouldShowButterFlyGuide { get; set; }
        public int OldCollectButterFly { get; set; }
        
        // Methods
        public int get_LevelChrysalisMaxCount()
        {
            return (int)this.<LevelChrysalisMaxCount>k__BackingField;
        }
        public void set_LevelChrysalisMaxCount(int value)
        {
            this.<LevelChrysalisMaxCount>k__BackingField = value;
        }
        public void Init()
        {
            var val_3;
            if(true != 0)
            {
                    return;
            }
            
            do
            {
                this.ButterFlyList.ButterFlyList.Add(item:  0);
                val_3 = 0 + 1;
            }
            while(val_3 < 11);
        
        }
        public int get_LevelChrysalisCount()
        {
            return (int)Store.ButterFlyData.__il2cppRuntimeField_name;
        }
        private void set_LevelChrysalisCount(int value)
        {
            typeof(Store.ButterFlyData).__il2cppRuntimeField_10 = value;
        }
        public int get_ChrysalisCount()
        {
            return (int)typeof(Store.ButterFlyData).__il2cppRuntimeField_14;
        }
        private void set_ChrysalisCount(int value)
        {
            typeof(Store.ButterFlyData).__il2cppRuntimeField_14 = value;
        }
        public System.Collections.Generic.List<int> get_ButterFlyList()
        {
            return (System.Collections.Generic.List<System.Int32>)Store.ButterFlyData.__il2cppRuntimeField_namespaze;
        }
        private void set_ButterFlyList(System.Collections.Generic.List<int> value)
        {
            typeof(Store.ButterFlyData).__il2cppRuntimeField_18 = value;
        }
        public bool get_ShouldShowButterFlyGuide()
        {
            return (bool)Store.ButterFlyData.__il2cppRuntimeField_byval_arg;
        }
        private void set_ShouldShowButterFlyGuide(bool value)
        {
            typeof(Store.ButterFlyData).__il2cppRuntimeField_20 = value;
        }
        public int get_OldCollectButterFly()
        {
            return (int)typeof(Store.ButterFlyData).__il2cppRuntimeField_24;
        }
        private void set_OldCollectButterFly(int value)
        {
            typeof(Store.ButterFlyData).__il2cppRuntimeField_24 = value;
        }
        public void AddLevelChrysalisCount()
        {
            int val_1 = this.LevelChrysalisCount;
            val_1.LevelChrysalisCount = val_1 + 1;
        }
        public void SetLevelChrysalisCount(int count)
        {
            this.LevelChrysalisCount = count;
        }
        public void AddChrysalisCount(int count)
        {
            int val_1 = this.ChrysalisCount;
            count = val_1 + count;
            val_1.ChrysalisCount = count;
            int val_2 = val_1.ChrysalisCount;
            if(val_2 <= this.ChrysalisMaxCount)
            {
                    return;
            }
            
            val_2.ChrysalisCount = this.ChrysalisMaxCount;
        }
        public void SetChrysalisCount(int count)
        {
            this.ChrysalisCount = count;
        }
        public void SetButterFlyList(System.Collections.Generic.List<int> value)
        {
            this.ButterFlyList = value;
        }
        public void SetShouldShowButterFlyGuide(bool isShould)
        {
            this.ShouldShowButterFlyGuide = isShould;
        }
        public void SetOldCollectButterFly(int value)
        {
            this.OldCollectButterFly = value;
        }
        public int GetCollectButterFlyCount()
        {
            return (int)this.GetCollectButterFlyList();
        }
        public System.Collections.Generic.List<int> GetCollectButterFlyList()
        {
            this._collectButterFlyList.Clear();
            var val_4 = 0;
            do
            {
                if(val_4 >= 1152921512594517776)
            {
                    return (System.Collections.Generic.List<System.Int32>)this._collectButterFlyList;
            }
            
                System.Collections.Generic.List<System.Int32> val_2 = this._collectButterFlyList.ButterFlyList.ButterFlyList;
                if(val_4 >= 1152921512594517776)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((System.Int32 System.Collections.Generic.Dictionary<IntAndAtlasRegionKey, System.Object>::FindEntry(IntAndAtlasRegionKey key)) == 1)
            {
                    this._collectButterFlyList.Add(item:  0);
            }
            
                val_4 = val_4 + 1;
            }
            while(this._collectButterFlyList.ButterFlyList != null);
            
            throw new NullReferenceException();
        }
        public ButterFlyDataManager()
        {
            int val_6;
            int[] val_1 = new int[3];
            val_1[0] = 5;
            val_1[0] = 6;
            this.ButterFlyActivityOpenTimes = val_1;
            this.DayOfWeekTimes = new System.DayOfWeek[7];
            string[] val_3 = new string[12];
            val_6 = val_3.Length;
            val_3[0] = "145";
            val_6 = val_3.Length;
            val_3[1] = "146";
            val_6 = val_3.Length;
            val_3[2] = "147";
            val_6 = val_3.Length;
            val_3[3] = "148";
            val_6 = val_3.Length;
            val_3[4] = "149";
            val_6 = val_3.Length;
            val_3[5] = "150";
            val_6 = val_3.Length;
            val_3[6] = "151";
            val_6 = val_3.Length;
            val_3[7] = "152";
            val_6 = val_3.Length;
            val_3[8] = "153";
            val_6 = val_3.Length;
            val_3[9] = "154";
            val_6 = val_3.Length;
            val_3[10] = "155";
            val_6 = val_3.Length;
            val_3[11] = "156";
            this.ButterFlyNames = val_3;
            this.ChrysalisProgress = new int[4] {20, 50, 120, 250};
            this.ChrysalisOnceMaxCount = ;
            this.ChrysalisMaxCount = ;
            this.ButterFlyMaxCount = 17179869196;
            this.SampleShowButterFlyMaxCount = 4;
            this._collectButterFlyList = new System.Collections.Generic.List<System.Int32>();
        }
    
    }

}
