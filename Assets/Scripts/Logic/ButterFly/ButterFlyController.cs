using UnityEngine;

namespace Logic.ButterFly
{
    public class ButterFlyController : Singleton<Logic.ButterFly.ButterFlyController>
    {
        // Methods
        public bool ButterFlyActivityIsOpen()
        {
            var val_5 = null;
            if((null.IsPassLevelForUnlockLevel(sectionIndex:  4, levelIndex:  1)) == false)
            {
                    return false;
            }
            
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount) >= val_4.ChrysalisMaxCount)
            {
                    return false;
            }
            
            return Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.IsInActivityTime();
        }
        public bool ButterFlyActivityIsOpenForResult()
        {
            var val_10;
            var val_11;
            var val_12;
            val_11 = null;
            if((null.IsPassLevelForUnlockLevel(sectionIndex:  4, levelIndex:  2)) != false)
            {
                    val_10 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount;
                Data.ButterFly.ButterFlyDataManager val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
                if(val_10 < val_4.ChrysalisMaxCount)
            {
                    int val_6 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount;
                if(val_6 >= 1)
            {
                    if(val_6.IsInActivityTime() != true)
            {
                    if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) <= 0)
            {
                goto label_12;
            }
            
            }
            
                val_12 = 1;
                return (bool)val_12;
            }
            
            }
            
            }
            
            label_12:
            val_12 = 0;
            return (bool)val_12;
        }
        public bool ButterFlyActivityIsOpenForHome()
        {
            var val_2 = null;
            bool val_1 = null.IsPassLevelForUnlockLevel(sectionIndex:  4, levelIndex:  1);
            if(val_1 == false)
            {
                    return false;
            }
            
            return val_1.IsInActivityTime();
        }
        public bool HomeIsShowButterFlyActivity()
        {
            var val_5;
            var val_6;
            val_5 = null;
            if(null.ButterFlyActivityIsOpenForHome() == false)
            {
                    return (bool)((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount()) > 0) ? 1 : 0;
            }
            
            val_6 = 1;
            return (bool)((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount()) > 0) ? 1 : 0;
        }
        public bool IsCollectAllButterFly()
        {
            Data.ButterFly.ButterFlyDataManager val_3 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            return (bool)((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount()) >= val_3.ButterFlyMaxCount) ? 1 : 0;
        }
        public long ButterFlyActivityCloseTimeSpan()
        {
            System.DateTime val_1 = this.GetActivityEndTime();
            System.DateTime val_2 = System.DateTime.Now;
            System.TimeSpan val_3 = val_1.dateData.Subtract(value:  new System.DateTime() {dateData = val_2.dateData});
            return (long)(long)val_3._ticks.TotalSeconds;
        }
        public int CollectNextButterFlyNeedChrysalis()
        {
            return (int)val_1.ChrysalisProgress[Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyLevel()];
        }
        public int GetCollectChrysalisLevel()
        {
            var val_8;
            var val_8 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount;
            Data.ButterFly.ButterFlyDataManager val_3 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            Data.ButterFly.ButterFlyDataManager val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            val_8 = 0;
            val_8 = val_8 - ((val_8 / val_3.ChrysalisOnceMaxCount) * val_3.ChrysalisOnceMaxCount);
            label_10:
            if(val_8 >= val_4.ChrysalisProgress.Length)
            {
                goto label_5;
            }
            
            Data.ButterFly.ButterFlyDataManager val_6 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            if(val_8 < val_6.ChrysalisProgress[val_8])
            {
                    return (int)val_8;
            }
            
            val_8 = val_8 + 1;
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance) != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_5:
            val_8 = 0;
            return (int)val_8;
        }
        public int GetCollectButterFlyLevel()
        {
            int val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount();
            Data.ButterFly.ButterFlyDataManager val_3 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            return (int)val_2 - ((val_2 / val_3.ChrysalisProgress.Length) * val_3.ChrysalisProgress.Length);
        }
        public void CollectChrysalis(int count)
        {
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.AddChrysalisCount(count:  count);
        }
        public float GetCollectChrysalisProgress(int oldCount = 0)
        {
            int val_3 = oldCount;
            int val_1 = this.CollectNextButterFlyNeedChrysalis();
            if(val_3 == 0)
            {
                    val_3 = val_1.GetNowRoundChrysalisCount();
            }
            
            float val_3 = (float)val_3;
            val_3 = val_3 / (float)val_1;
            return (float)val_3;
        }
        public bool IsCanCollectButterFly()
        {
            var val_6;
            int val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount();
            if(val_2.GetCollectButterFlyForAllChrysalis() > val_2)
            {
                    Data.ButterFly.ButterFlyDataManager val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
                var val_5 = (val_2 < val_4.ButterFlyMaxCount) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public int CollectButterFlyForChrysalisLevel(int level)
        {
            int val_8;
            var val_9;
            int val_10;
            var val_11;
            System.Collections.Generic.List<System.Int32> val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ButterFlyList;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            int val_4 = level + (level << 1);
            do
            {
                val_8 = (val_4 + 0) + 1;
                if(val_8 < val_4)
            {
                    if(val_4 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + (val_8 << 2);
                if((((level + (level) << 1) + ((((level + (level) << 1) + 0) + 1)) << 2) + 32) == 0)
            {
                    Add(item:  val_8);
            }
            
            }
            
                val_9 = 0 + 1;
            }
            while(val_9 < 2);
            
            val_8 = UnityEngine.Random.Range(min:  0, max:  672637872);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = (long)val_8;
            val_10 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 2) + 32];
            val_10 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 2) + 32;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((long)(int)(val_6)) << 2) + 32];
            val_10 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((long)(int)(val_6)) << 2) + 32;
            val_2.set_Item(index:  val_10, value:  1);
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.SetButterFlyList(value:  val_2);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((long)(int)(val_6)) << 2) + 32];
            val_11 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((long)(int)(val_6)) << 2) + 32;
            return (int);
        }
        public bool ShouldShowResultEntranceGuide()
        {
            return Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ShouldShowButterFlyGuide;
        }
        public bool IsHaveCollectChrysalisAni()
        {
            var val_4;
            bool val_1 = this.ButterFlyActivityIsOpen();
            if(val_1 != false)
            {
                    val_4 = val_1.IsCollectAllButterFly() ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        public int GetNowRoundChrysalisCount()
        {
            var val_11;
            var val_12;
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount) >= 1)
            {
                    val_11 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount();
                Data.ButterFly.ButterFlyDataManager val_5 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
                Data.ButterFly.ButterFlyDataManager val_8 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
                val_12 = (Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount) - (val_8.ChrysalisOnceMaxCount * (val_11 / val_5.SampleShowButterFlyMaxCount));
                return (int)val_12;
            }
            
            val_12 = 0;
            return (int)val_12;
        }
        private int GetCollectButterFlyForAllChrysalis()
        {
            var val_12;
            Data.ButterFly.ButterFlyDataManager val_1 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            Data.ButterFly.ButterFlyDataManager val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            var val_12 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount;
            Data.ButterFly.ButterFlyDataManager val_7 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            float val_11 = (float)Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount;
            val_11 = val_11 / (float)val_4.ChrysalisOnceMaxCount;
            val_12 = (public static Data.ButterFly.ButterFlyDataManager Common.Singleton<Data.ButterFly.ButterFlyDataManager>::get_Instance()) * val_1.ChrysalisProgress.Length;
            if(val_1.ChrysalisProgress.Length < 1)
            {
                    return (int)(val_12 >= val_9.ChrysalisProgress[val_14]) ? (val_12 + 1) : (val_12);
            }
            
            var val_14 = 0;
            val_12 = val_12 - ((val_12 / val_7.ChrysalisOnceMaxCount) * val_7.ChrysalisOnceMaxCount);
            do
            {
                Data.ButterFly.ButterFlyDataManager val_9 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
                val_14 = val_14 + 1;
            }
            while(val_14 < (long)val_1.ChrysalisProgress.Length);
            
            return (int)(val_12 >= val_9.ChrysalisProgress[val_14]) ? (val_12 + 1) : (val_12);
        }
        private bool IsInActivityTime()
        {
            System.Int32[] val_8;
            System.Collections.Generic.IEnumerable<TSource> val_9;
            val_8 = 1152921512618525072;
            Data.ButterFly.ButterFlyDataManager val_1 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            if(val_1.ButterFlyActivityOpenTimes.Length != 0)
            {
                    Data.ButterFly.ButterFlyDataManager val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
                val_8 = val_2.ButterFlyActivityOpenTimes;
                System.DateTime val_3 = System.DateTime.Today;
                val_9 = val_8;
                bool val_7 = System.Linq.Enumerable.Contains<System.Int32>(source:  val_9, value:  System.Convert.ToInt32(value:  val_3.dateData.DayOfWeek.ToString(format:  "d")));
            }
            else
            {
                    val_9 = 0;
            }
            
            val_9 = val_9 & 1;
            return (bool)val_9;
        }
        private System.DateTime GetActivityEndTime()
        {
            var val_15;
            System.DateTime val_1 = System.DateTime.Now;
            val_15 = val_1.dateData;
            Data.ButterFly.ButterFlyDataManager val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            if(val_2.ButterFlyActivityOpenTimes.Length == 0)
            {
                    return (System.DateTime)val_15;
            }
            
            Data.ButterFly.ButterFlyDataManager val_3 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            Data.ButterFly.ButterFlyDataManager val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            int val_15 = val_4.ButterFlyActivityOpenTimes.Length;
            val_15 = val_15 - 1;
            int val_16 = val_3.ButterFlyActivityOpenTimes[val_15];
            Data.ButterFly.ButterFlyDataManager val_5 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            if(val_16 >= val_5.DayOfWeekTimes.Length)
            {
                    return (System.DateTime)val_15;
            }
            
            System.DateTime val_9 = new System.DateTime(year:  val_1.dateData.Year, month:  val_1.dateData.Month, day:  val_1.dateData.Day);
            Data.ButterFly.ButterFlyDataManager val_11 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            System.DayOfWeek val_17 = val_11.DayOfWeekTimes[(val_3.ButterFlyActivityOpenTimes[(val_4.ButterFlyActivityOpenTimes.Length - 1)][0]) << 2];
            val_17 = val_1.dateData.DayOfWeek - val_17;
            val_17 = 8 - val_17;
            System.DateTime val_13 = val_9.dateData.AddDays(value:  (double)(val_16 != val_11.DayOfWeekTimes.Length) ? (val_17) : (0 + 1));
            System.DateTime val_14 = val_13.dateData.AddSeconds(value:  -1);
            val_15 = val_14.dateData;
            return (System.DateTime)val_15;
        }
        public ButterFlyController()
        {
        
        }
    
    }

}
