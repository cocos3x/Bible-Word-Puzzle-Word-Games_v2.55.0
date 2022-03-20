using UnityEngine;

namespace Platform.Analyze
{
    public struct IapDlgShow : IAnalyticsBundle
    {
        // Fields
        public string DlgName;
        public Platform.Analyze.IapDlgShow.TimingEnum Timing;
        public Platform.Analyze.IapDlgShow.SourceEnum Source;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "iap_dlg_show";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_4 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source);
            val_4 = ((UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "dlg_name", value:  new Platform.Analyze.IapDlgShow())) & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "timing", value:  this.Timing))) & val_4;
            return (bool)val_4;
        }
    
    }

}
