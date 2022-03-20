using UnityEngine;

namespace Platform.Analyze
{
    public struct CalendarRewardGain : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.CalendarRewardGain.RewardIndexEnum RewardIndex;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "calendar_reward_gain";
        }
        public bool MakeTransaction(long tid)
        {
            return UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "reward_index", value:  new Platform.Analyze.CalendarRewardGain());
        }
    
    }

}
