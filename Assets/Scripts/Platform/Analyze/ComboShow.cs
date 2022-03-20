using UnityEngine;

namespace Platform.Analyze
{
    public struct ComboShow : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.ComboShow.SourceEnum Source;
        public Platform.Analyze.ComboShow.ComboTypeEnum ComboType;
        public string ComboNum;
        public string CurLevel;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "combo_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_7 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  new Platform.Analyze.ComboShow());
            val_7 = val_7 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "combo_type", value:  this.ComboType));
            bool val_5 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel);
            val_5 = (val_7 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "combo_num", value:  this.ComboNum))) & val_5;
            return (bool)val_5;
        }
    
    }

}
