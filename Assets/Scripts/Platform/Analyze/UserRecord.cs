using UnityEngine;

namespace Platform.Analyze
{
    public struct UserRecord : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.UserRecord.PurHistoryEnum PurHistory;
        public Platform.Analyze.UserRecord.NoadStateEnum NoadState;
        public Platform.Analyze.UserRecord.MusicStateEnum MusicState;
        public Platform.Analyze.UserRecord.SoundStateEnum SoundState;
        public Platform.Analyze.UserRecord.NetStateEnum NetState;
        public string DevMem;
        public string CurLevel;
        public string CurCurrency;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "user_record";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_11 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "pur_history", value:  new Platform.Analyze.UserRecord());
            val_11 = val_11 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "noad_state", value:  this.NoadState));
            val_11 = val_11 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "music_state", value:  this.MusicState));
            val_11 = val_11 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "sound_state", value:  this.SoundState));
            val_11 = val_11 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "net_state", value:  this.NetState));
            val_11 = val_11 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "dev_mem", value:  this.DevMem));
            bool val_9 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_currency", value:  this.CurCurrency);
            val_9 = (val_11 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel))) & val_9;
            return (bool)val_9;
        }
    
    }

}
