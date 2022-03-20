using UnityEngine;

namespace Platform.Analyze
{
    public struct DlgShow : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.DlgShow.SourceEnum Source;
        public Platform.Analyze.DlgShow.DlgNameEnum DlgName;
        public Platform.Analyze.DlgShow.TimingEnum Timing;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "dlg_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_4 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "timing", value:  this.Timing);
            val_4 = ((UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  new Platform.Analyze.DlgShow())) & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "dlg_name", value:  this.DlgName))) & val_4;
            return (bool)val_4;
        }
    
    }

}
