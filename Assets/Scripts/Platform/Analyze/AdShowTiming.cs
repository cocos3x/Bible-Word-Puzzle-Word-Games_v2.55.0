using UnityEngine;

namespace Platform.Analyze
{
    public struct AdShowTiming : IAnalyticsBundle
    {
        // Fields
        public string AdShowId;
        public Platform.Analyze.AdShowTiming.PlacementEnum Placement;
        public Platform.Analyze.AdShowTiming.PositionEnum Position;
        public Platform.Analyze.AdShowTiming.PlacementTypeEnum PlacementType;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "ad_show_timing";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_7 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "ad_show_id", value:  new Platform.Analyze.AdShowTiming());
            val_7 = val_7 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement", value:  this.Placement));
            bool val_5 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement_type", value:  this.PlacementType);
            val_5 = (val_7 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "position", value:  this.Position))) & val_5;
            return (bool)val_5;
        }
    
    }

}
