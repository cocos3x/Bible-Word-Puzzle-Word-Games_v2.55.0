using UnityEngine;

namespace Platform.Analyze
{
    public struct IapItemPurchase : IAnalyticsBundle
    {
        // Fields
        public string ItemName;
        public Platform.Analyze.IapItemPurchase.SourceEnum Source;
        public string PurResult;
        public string CurLevel;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "iap_item_purchase";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_7 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "item_name", value:  new Platform.Analyze.IapItemPurchase());
            val_7 = val_7 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source));
            bool val_5 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel);
            val_5 = (val_7 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "pur_result", value:  this.PurResult))) & val_5;
            return (bool)val_5;
        }
    
    }

}
