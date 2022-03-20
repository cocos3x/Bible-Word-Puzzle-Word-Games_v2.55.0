using UnityEngine;

namespace Platform.Analyze
{
    public struct ActivScrShow : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.ActivScrShow.ScrNameEnum ScrName;
        public Platform.Analyze.ActivScrShow.SourceEnum Source;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "activ_scr_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_2 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source);
            val_2 = (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "scr_name", value:  new Platform.Analyze.ActivScrShow())) & val_2;
            return (bool)val_2;
        }
    
    }

}
