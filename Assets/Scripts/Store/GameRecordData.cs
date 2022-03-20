using UnityEngine;

namespace Store
{
    public class GameRecordData : IStoreData
    {
        // Fields
        public string IsTestLevelBoxProgress;
        public System.Collections.Generic.List<string> LevelBoxProgress;
        public System.Collections.Generic.List<string> LevelBoxProgressTest;
        public System.Collections.Generic.List<string> GameRightAnswerList;
        public bool IsInQuizLevel;
        public int DifficultyPartyIndex;
        public int DifficultyLevelIndex;
        public int ContinuousSuccessCount;
        public int ContinuousFailCount;
        
        // Methods
        public void Reset()
        {
            this.IsTestLevelBoxProgress = "contrast";
            this.LevelBoxProgress.Clear();
            this.LevelBoxProgressTest.Clear();
            this.GameRightAnswerList.Clear();
            this.IsInQuizLevel = false;
            this.ContinuousSuccessCount = 0;
            this.ContinuousFailCount = 0;
            this.DifficultyPartyIndex = 0;
            this.DifficultyLevelIndex = 0;
        }
        public GameRecordData()
        {
            this.LevelBoxProgress = new System.Collections.Generic.List<System.String>();
            this.LevelBoxProgressTest = new System.Collections.Generic.List<System.String>();
            this.GameRightAnswerList = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
