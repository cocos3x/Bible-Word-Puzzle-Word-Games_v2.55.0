using UnityEngine;

namespace Platform.Analyze
{
    public struct PushClick : IAnalyticsBundle
    {
        // Fields
        public string PushId;
        public string PushTime;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "push_click";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_2 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "push_time", value:  this.PushTime);
            val_2 = (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "push_id", value:  new Platform.Analyze.PushClick())) & val_2;
            return (bool)val_2;
        }
    
    }

}
