using UnityEngine;

namespace Platform.Analyze
{
    public struct GameScrShow : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.GameScrShow.ScrNameEnum ScrName;
        public Platform.Analyze.GameScrShow.SourceEnum Source;
        public string CurLevel;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "game_scr_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_4 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel);
            val_4 = ((UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "scr_name", value:  new Platform.Analyze.GameScrShow())) & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source))) & val_4;
            return (bool)val_4;
        }
    
    }

}
