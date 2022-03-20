using UnityEngine;

namespace Platform.Analyze
{
    public struct BtnClick : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.BtnClick.SourceEnum Source;
        public Platform.Analyze.BtnClick.BtnNameEnum BtnName;
        public string AdShowId;
        public Platform.Analyze.BtnClick.PlacementEnum Placement;
        public Platform.Analyze.BtnClick.PlacementTypeEnum PlacementType;
        public Platform.Analyze.BtnClick.PositionEnum Position;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "btn_click";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_9 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  new Platform.Analyze.BtnClick());
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "btn_name", value:  this.BtnName));
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "ad_show_id", value:  this.AdShowId));
            val_9 = val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement", value:  this.Placement));
            bool val_7 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "position", value:  this.Position);
            val_7 = (val_9 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "placement_type", value:  this.PlacementType))) & val_7;
            return (bool)val_7;
        }
    
    }

}
