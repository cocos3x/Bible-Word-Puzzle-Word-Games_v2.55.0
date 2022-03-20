using UnityEngine;

namespace Platform.Analyze
{
    public struct GameBtnClick : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.GameBtnClick.BtnNameEnum BtnName;
        public Platform.Analyze.GameBtnClick.SourceEnum Source;
        public string CurLevel;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "game_btn_click";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_4 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel);
            val_4 = ((UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "btn_name", value:  new Platform.Analyze.GameBtnClick())) & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source))) & val_4;
            return (bool)val_4;
        }
    
    }

}
