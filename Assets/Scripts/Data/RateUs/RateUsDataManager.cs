using UnityEngine;

namespace Data.RateUs
{
    public class RateUsDataManager : Singleton<Data.RateUs.RateUsDataManager>
    {
        // Fields
        private System.DateTime _lastRateDateTime;
        
        // Properties
        public string LastRateTime { get; set; }
        public bool IsRate { get; set; }
        public bool IsFeedback { get; set; }
        public int RateCloseCount { get; set; }
        public bool IsCCPAAccepted { get; set; }
        public System.DateTime LastRateDateTime { get; set; }
        
        // Methods
        public void Init()
        {
            System.DateTime val_2 = Common.EzDate.GetDateTime(dateString:  this.LastRateTime, format:  0);
            this._lastRateDateTime = val_2;
        }
        public string get_LastRateTime()
        {
            return (string)Store.RateUsData.__il2cppRuntimeField_name;
        }
        private void set_LastRateTime(string value)
        {
            typeof(Store.RateUsData).__il2cppRuntimeField_10 = value;
        }
        public bool get_IsRate()
        {
            return (bool)Store.RateUsData.__il2cppRuntimeField_namespaze;
        }
        private void set_IsRate(bool value)
        {
            typeof(Store.RateUsData).__il2cppRuntimeField_18 = value;
        }
        public bool get_IsFeedback()
        {
            return (bool)typeof(Store.RateUsData).__il2cppRuntimeField_19;
        }
        private void set_IsFeedback(bool value)
        {
            typeof(Store.RateUsData).__il2cppRuntimeField_19 = value;
        }
        public int get_RateCloseCount()
        {
            return (int)typeof(Store.RateUsData).__il2cppRuntimeField_1C;
        }
        private void set_RateCloseCount(int value)
        {
            typeof(Store.RateUsData).__il2cppRuntimeField_1C = value;
        }
        public bool get_IsCCPAAccepted()
        {
            return (bool)Store.RateUsData.__il2cppRuntimeField_byval_arg;
        }
        private void set_IsCCPAAccepted(bool value)
        {
            typeof(Store.RateUsData).__il2cppRuntimeField_20 = value;
        }
        public System.DateTime get_LastRateDateTime()
        {
            return (System.DateTime)this._lastRateDateTime;
        }
        public void set_LastRateDateTime(System.DateTime value)
        {
            this._lastRateDateTime = value;
            string val_1 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0);
            val_1.LastRateTime = val_1;
        }
        public void SetRate(bool isRate)
        {
            this.IsRate = isRate;
        }
        public void SetFeedback(bool isFeedback)
        {
            this.IsFeedback = isFeedback;
        }
        public void AddRateCloseCount()
        {
            int val_1 = this.RateCloseCount;
            val_1.RateCloseCount = val_1 + 1;
        }
        public bool ShouldRate()
        {
            var val_8;
            bool val_1 = Common.GlobalMethods.IsToday(des:  new System.DateTime() {dateData = this._lastRateDateTime}, res:  new System.Nullable<System.DateTime>() {HasValue = false});
            if(val_1 != true)
            {
                    bool val_2 = val_1.IsRate;
                if(val_2 != true)
            {
                    bool val_3 = val_2.IsFeedback;
                if(val_3 != true)
            {
                    if(val_3.RateCloseCount <= 2)
            {
                    var val_7 = ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) < 4) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public void SetCCPAAccepted(bool isCcp)
        {
            this.IsCCPAAccepted = isCcp;
        }
        public RateUsDataManager()
        {
        
        }
    
    }

}
