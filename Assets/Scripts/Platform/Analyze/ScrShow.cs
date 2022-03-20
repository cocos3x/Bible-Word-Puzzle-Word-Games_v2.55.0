using UnityEngine;

namespace Platform.Analyze
{
    public struct ScrShow : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.ScrShow.SourceEnum Source;
        public Platform.Analyze.ScrShow.ScrNameEnum ScrName;
        public string AdShowId;
        public Platform.Analyze.ScrShow.PlacementEnum Placement;
        public Platform.Analyze.ScrShow.PlacementTypeEnum PlacementType;
        public Platform.Analyze.ScrShow.PositionEnum Position;
        public Platform.Analyze.ScrShow.TimingEnum Timing;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "scr_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_10 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  new Platform.Analyze.ScrShow());
            val_10 = val_10 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "scr_name", value:  this.ScrName));
            val_10 = val_10 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "ad_show_id", value:  this.AdShowId));
            val_10 = val_10 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement", value:  this.Placement));
            val_10 = val_10 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement_type", value:  this.PlacementType));
            bool val_8 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "timing", value:  this.Timing);
            val_8 = (val_10 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "position", value:  this.Position))) & val_8;
            return (bool)val_8;
        }
    
    }

}
