using UnityEngine;

namespace Data.LifeActivities
{
    public class LifeActivitiesDataManager : Singleton<Data.LifeActivities.LifeActivitiesDataManager>
    {
        // Properties
        public int AllConnectWord { get; set; }
        public int UseHintCount { get; set; }
        public int ShowDailyCount { get; set; }
        public int ShowLevelPassVideoCount { get; set; }
        public int StartLevelCount { get; set; }
        public int BonusWordsCount { get; set; }
        public int LevelPassCount { get; set; }
        public bool IsHaveNoviceBankruptcy { get; set; }
        public bool IsHaveNoviceReward { get; set; }
        public int DailyLotteryCount { get; set; }
        public int FailCountCurLevel { get; set; }
        private int FailCountLastLevel { set; }
        public int CombosCount { get; set; }
        public float LevelPassTime { get; set; }
        public float LevelPassDailyTime { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public int get_AllConnectWord()
        {
            return (int)Store.LifeActivitiesData.__il2cppRuntimeField_name;
        }
        private void set_AllConnectWord(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_10 = value;
        }
        public int get_UseHintCount()
        {
            return (int)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_14;
        }
        private void set_UseHintCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_14 = value;
        }
        public int get_ShowDailyCount()
        {
            return (int)Store.LifeActivitiesData.__il2cppRuntimeField_namespaze;
        }
        private void set_ShowDailyCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_18 = value;
        }
        public int get_ShowLevelPassVideoCount()
        {
            return (int)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_1C;
        }
        private void set_ShowLevelPassVideoCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_1C = value;
        }
        public int get_StartLevelCount()
        {
            return (int)Store.LifeActivitiesData.__il2cppRuntimeField_byval_arg;
        }
        private void set_StartLevelCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_20 = value;
        }
        public int get_BonusWordsCount()
        {
            return (int)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_24;
        }
        private void set_BonusWordsCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_24 = value;
        }
        public int get_LevelPassCount()
        {
            return (int)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_28;
        }
        private void set_LevelPassCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_28 = value;
        }
        public bool get_IsHaveNoviceBankruptcy()
        {
            return (bool)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_2C;
        }
        private void set_IsHaveNoviceBankruptcy(bool value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_2C = value;
        }
        public bool get_IsHaveNoviceReward()
        {
            return (bool)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_2D;
        }
        private void set_IsHaveNoviceReward(bool value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_2D = value;
        }
        public int get_DailyLotteryCount()
        {
            return (int)Store.LifeActivitiesData.__il2cppRuntimeField_this_arg;
        }
        private void set_DailyLotteryCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_30 = value;
        }
        public int get_FailCountCurLevel()
        {
            return (int)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_34;
        }
        private void set_FailCountCurLevel(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_34 = value;
        }
        private void set_FailCountLastLevel(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_38 = value;
        }
        public int get_CombosCount()
        {
            return (int)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_3C;
        }
        private void set_CombosCount(int value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_3C = value;
        }
        public float get_LevelPassTime()
        {
            return (float)Store.LifeActivitiesData.__il2cppRuntimeField_element_class;
        }
        private void set_LevelPassTime(float value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_40 = value;
        }
        public float get_LevelPassDailyTime()
        {
            return (float)typeof(Store.LifeActivitiesData).__il2cppRuntimeField_44;
        }
        private void set_LevelPassDailyTime(float value)
        {
            typeof(Store.LifeActivitiesData).__il2cppRuntimeField_44 = value;
        }
        public int GetAllConnectWord()
        {
            Logic.Game.GameLevel val_7;
            if(this.AllConnectWord != 1)
            {
                    return val_6.AllConnectWord;
            }
            
            val_7 = Logic.Game.GameManager.gameLevel;
            int val_6 = val_7.GetAllConnectWords(unlockSectionIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex, unlockLevelIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex);
            val_6.AllConnectWord = val_6;
            return val_6.AllConnectWord;
        }
        public void AddAllConnectWord()
        {
            int val_1 = this.AllConnectWord;
            val_1.AllConnectWord = val_1 + 1;
        }
        public void AddUseHintCount()
        {
            int val_1 = this.UseHintCount;
            val_1.UseHintCount = val_1 + 1;
        }
        public void AddShowDailyCount()
        {
            int val_1 = this.ShowDailyCount;
            val_1.ShowDailyCount = val_1 + 1;
        }
        public void AddShowLevelPassVideoCount()
        {
            int val_1 = this.ShowLevelPassVideoCount;
            val_1.ShowLevelPassVideoCount = val_1 + 1;
        }
        public void AddStartLevelCount()
        {
            int val_1 = this.StartLevelCount;
            val_1.StartLevelCount = val_1 + 1;
        }
        public void AddBonusWordsCount()
        {
            int val_1 = this.BonusWordsCount;
            val_1.BonusWordsCount = val_1 + 1;
        }
        public void AddLevelPassCount()
        {
            int val_1 = this.LevelPassCount;
            val_1.LevelPassCount = val_1 + 1;
        }
        public void SetHaveNoviceBankruptcy(bool isHave)
        {
            this.IsHaveNoviceBankruptcy = isHave;
        }
        public void SetHaveNoviceReward(bool isHave)
        {
            this.IsHaveNoviceReward = isHave;
        }
        public void AddDailyLotteryCount()
        {
            int val_1 = this.DailyLotteryCount;
            val_1.DailyLotteryCount = val_1 + 1;
        }
        public void AddFailCountCurLevel(int count)
        {
            int val_1 = this.FailCountCurLevel;
            count = val_1 + count;
            val_1.FailCountCurLevel = count;
        }
        public void SetFailCountCurLevel(int count)
        {
            this.FailCountCurLevel = count;
        }
        public void SetFailCountLastLevel(int count)
        {
            this.FailCountLastLevel = count;
        }
        public void AddCombos()
        {
            int val_1 = this.CombosCount;
            val_1.CombosCount = val_1 + 1;
            Platform.Analytics.EzAnalytics.CombosTimes();
        }
        public int GetCombos()
        {
            return this.CombosCount;
        }
        public void SetLevelPassTime(float time)
        {
            this.LevelPassTime = time;
        }
        public void SetLevelPassDailyTime(float time)
        {
            this.LevelPassDailyTime = time;
        }
        public LifeActivitiesDataManager()
        {
        
        }
    
    }

}
