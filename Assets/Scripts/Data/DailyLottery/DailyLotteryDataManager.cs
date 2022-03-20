using UnityEngine;

namespace Data.DailyLottery
{
    public class DailyLotteryDataManager : Singleton<Data.DailyLottery.DailyLotteryDataManager>
    {
        // Properties
        public System.Collections.Generic.List<string> DailyGiftBoxProgress { get; set; }
        public System.Collections.Generic.List<int> DailyGiftRewardCount { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public System.Collections.Generic.List<string> get_DailyGiftBoxProgress()
        {
            return (System.Collections.Generic.List<System.String>)Store.DailyLotteryData.__il2cppRuntimeField_name;
        }
        private void set_DailyGiftBoxProgress(System.Collections.Generic.List<string> value)
        {
            typeof(Store.DailyLotteryData).__il2cppRuntimeField_10 = value;
        }
        public System.Collections.Generic.List<int> get_DailyGiftRewardCount()
        {
            return (System.Collections.Generic.List<System.Int32>)Store.DailyLotteryData.__il2cppRuntimeField_namespaze;
        }
        private void set_DailyGiftRewardCount(System.Collections.Generic.List<int> value)
        {
            typeof(Store.DailyLotteryData).__il2cppRuntimeField_18 = value;
        }
        public void SaveDailyGiftBoxProgress(System.Collections.Generic.List<string> data)
        {
            if(data != null)
            {
                    this.DailyGiftBoxProgress = data;
                return;
            }
            
            this.DailyGiftBoxProgress.Clear();
        }
        public System.Collections.Generic.List<string> GetDailyGiftBoxProgress()
        {
            return this.DailyGiftBoxProgress;
        }
        public void SaveDailyGiftRewardCount(System.Collections.Generic.List<int> data)
        {
            if(data != null)
            {
                    this.DailyGiftRewardCount = data;
                return;
            }
            
            this.DailyGiftRewardCount.Clear();
        }
        public System.Collections.Generic.List<int> GetDailyGiftRewardCount()
        {
            return this.DailyGiftRewardCount;
        }
        public DailyLotteryDataManager()
        {
        
        }
    
    }

}
