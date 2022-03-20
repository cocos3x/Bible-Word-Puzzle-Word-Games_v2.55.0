using UnityEngine;

namespace Platform.Analyze
{
    public struct BtnShow : IAnalyticsBundle
    {
        // Fields
        public string AdShowId;
        public Platform.Analyze.BtnShow.PlacementEnum Placement;
        public Platform.Analyze.BtnShow.PlacementTypeEnum PlacementType;
        public Platform.Analyze.BtnShow.PositionEnum Position;
        public Platform.Analyze.BtnShow.BtnNameEnum BtnName;
        public Platform.Analyze.BtnShow.SourceEnum Source;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "btn_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_9 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "ad_show_id", value:  new Platform.Analyze.BtnShow());
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement", value:  this.Placement));
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement_type", value:  this.PlacementType));
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "position", value:  this.Position));
            bool val_7 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source);
            val_7 = (val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "btn_name", value:  this.BtnName))) & val_7;
            return (bool)val_7;
        }
    
    }

}
