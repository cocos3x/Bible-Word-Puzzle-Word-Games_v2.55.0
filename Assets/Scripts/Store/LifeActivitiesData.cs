using UnityEngine;

namespace Store
{
    public class LifeActivitiesData : IStoreData
    {
        // Fields
        public int AllConnectWord;
        public int UseHintCount;
        public int ShowDailyCount;
        public int ShowLevelPassVideoCount;
        public int StartLevelCount;
        public int BonusWordsCount;
        public int LevelPassCount;
        public bool IsHaveNoviceBankruptcy;
        public bool IsHaveNoviceReward;
        public int DailyLotteryCount;
        public int FailCountCurLevel;
        public int FailCountLastLevel;
        public int CombosCount;
        public float LevelPassTime;
        public float LevelPassDailyTime;
        
        // Methods
        public void Reset()
        {
            this.BonusWordsCount = 0;
            this.LevelPassCount = 0;
            this.ShowLevelPassVideoCount = 0;
            this.StartLevelCount = 0;
            this.UseHintCount = 0;
            this.ShowDailyCount = 0;
            this.FailCountLastLevel = 0;
            this.CombosCount = 0;
            this.LevelPassTime = 0f;
            this.LevelPassDailyTime = 0f;
            this.AllConnectWord = 0;
            this.IsHaveNoviceBankruptcy = true;
            this.IsHaveNoviceReward = true;
            this.DailyLotteryCount = 0;
            this.FailCountCurLevel = 0;
        }
        public LifeActivitiesData()
        {
        
        }
    
    }

}
