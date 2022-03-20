using UnityEngine;

namespace Platform.Analyze
{
    public struct ActivBtnClick : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.ActivBtnClick.BtnNameEnum BtnName;
        public Platform.Analyze.ActivBtnClick.SourceEnum Source;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "activ_btn_click";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_2 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  this.Source);
            val_2 = (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "btn_name", value:  new Platform.Analyze.ActivBtnClick())) & val_2;
            return (bool)val_2;
        }
    
    }

}
