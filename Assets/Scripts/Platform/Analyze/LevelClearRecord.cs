using UnityEngine;

namespace Platform.Analyze
{
    public struct LevelClearRecord : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.LevelClearRecord.SourceEnum Source;
        public string CurLevel;
        public string CurCurrency;
        public string ExtraWordNum;
        public string PassTime;
        public string HintNum;
        public string RefreshNum;
        public string FireworkNum;
        public string PurState;
        public string WrongNum;
        public string MaxComboNum;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "level_clear_record";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_14 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "source", value:  new Platform.Analyze.LevelClearRecord());
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_currency", value:  this.CurCurrency));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "extra_word_num", value:  this.ExtraWordNum));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "pass_time", value:  this.PassTime));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "hint_num", value:  this.HintNum));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "refresh_num", value:  this.RefreshNum));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "firework_num", value:  this.FireworkNum));
            val_14 = val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "pur_state", value:  this.PurState));
            bool val_12 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "max_combo_num", value:  this.MaxComboNum);
            val_12 = (val_14 & (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "wrong_num", value:  this.WrongNum))) & val_12;
            return (bool)val_12;
        }
    
    }

}
