using UnityEngine;

namespace Store
{
    public class DailyLotteryData : IStoreData
    {
        // Fields
        public System.Collections.Generic.List<string> DailyGiftBoxProgress;
        public System.Collections.Generic.List<int> DailyGiftRewardCount;
        
        // Methods
        public void Reset()
        {
            this.DailyGiftBoxProgress.Clear();
            this.DailyGiftRewardCount.Clear();
        }
        public DailyLotteryData()
        {
            this.DailyGiftBoxProgress = new System.Collections.Generic.List<System.String>();
            this.DailyGiftRewardCount = new System.Collections.Generic.List<System.Int32>();
        }
    
    }

}
