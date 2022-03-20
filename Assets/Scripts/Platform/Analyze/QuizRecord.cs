using UnityEngine;

namespace Platform.Analyze
{
    public struct QuizRecord : IAnalyticsBundle
    {
        // Fields
        public Platform.Analyze.QuizRecord.AnswerStateEnum AnswerState;
        public string CurLevel;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
            return "quiz_record";
        }
        public bool MakeTransaction(long tid)
        {
            bool val_2 = UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "cur_level", value:  this.CurLevel);
            val_2 = (UnityAnalytics.GameAnalytics.AddEventPairString(transactionId:  tid, key:  "answer_state", value:  new Platform.Analyze.QuizRecord())) & val_2;
            return (bool)val_2;
        }
    
    }

}
