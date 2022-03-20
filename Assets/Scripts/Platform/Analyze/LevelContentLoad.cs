using UnityEngine;

namespace Platform.Analyze
{
    public struct LevelContentLoad : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.LevelContentLoad.StateEnum State;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "level_content_load";
        }
        public bool MakeTransaction(long tid)
        {
            return UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "state", value:  new Platform.Analyze.LevelContentLoad());
        }
    
    }

}
