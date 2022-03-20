using UnityEngine;

namespace Platform.Analyze
{
    public struct IapItemClick : IAnalyticsBundle
    {
        // Fields
        public string ItemName;
        public Platform.Analyze.IapItemClick.SourceEnum Source;
        public string CurLevel;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "iap_item_click";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_4 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel);
            val_4 = ((UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "item_name", value:  new Platform.Analyze.IapItemClick())) & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source))) & val_4;
            return (bool)val_4;
        }
    
    }

}
