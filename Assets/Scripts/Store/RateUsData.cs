using UnityEngine;

namespace Store
{
    public class RateUsData : IStoreData
    {
        // Fields
        public string LastRateTime;
        public bool IsRate;
        public bool IsFeedback;
        public int RateCloseCount;
        public bool IsCCPAAccepted;
        public bool IsRateIOSFirst;
        
        // Methods
        public void Reset()
        {
            this.IsRate = false;
            this.IsFeedback = false;
            this.RateCloseCount = 0;
            this.IsCCPAAccepted = false;
            this.IsRateIOSFirst = false;
            this.LastRateTime = System.String.alignConst;
        }
        public RateUsData()
        {
        
        }
    
    }

}
