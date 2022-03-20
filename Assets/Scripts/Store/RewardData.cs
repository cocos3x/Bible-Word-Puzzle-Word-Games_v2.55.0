using UnityEngine;

namespace Store
{
    public class RewardData : IStoreData
    {
        // Fields
        public string LastRewardDate;
        public int RewardDayCount;
        public int RewardVideoCount;
        public int BoxLowestRewardTotal1;
        public int BoxLowestRewardTotal2;
        public System.DateTime RecallRewardTime;
        
        // Methods
        public void Reset()
        {
            var val_1;
            this.RewardDayCount = 0;
            this.RewardVideoCount = 0;
            this.BoxLowestRewardTotal1 = 0;
            this.BoxLowestRewardTotal2 = 0;
            this.LastRewardDate = System.String.alignConst;
            val_1 = null;
            val_1 = null;
            this.RecallRewardTime = System.DateTime.MinValue;
        }
        public RewardData()
        {
            null = null;
            this.RecallRewardTime = System.DateTime.MinValue;
        }
    
    }

}
