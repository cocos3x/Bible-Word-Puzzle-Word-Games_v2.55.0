using UnityEngine;

namespace Platform.Analyze
{
    public struct PropUse : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.PropUse.SourceEnum Source;
        public Platform.Analyze.PropUse.PropNameEnum PropName;
        public int PropNum;
        public int PropLeft;
        public string CurLevel;
        public string CurCurrency;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "prop_use";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_9 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  new Platform.Analyze.PropUse());
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "prop_name", value:  this.PropName));
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairInt(transactionId:  tid, key:  "prop_num", value:  this.PropNum));
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairInt(transactionId:  tid, key:  "prop_left", value:  this.PropLeft));
            bool val_7 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_currency", value:  this.CurCurrency);
            val_7 = (val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel))) & val_7;
            return (bool)val_7;
        }
    
    }

}
