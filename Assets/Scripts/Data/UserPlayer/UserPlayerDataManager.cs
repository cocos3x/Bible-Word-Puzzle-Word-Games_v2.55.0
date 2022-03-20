using UnityEngine;

namespace Data.UserPlayer
{
    public class UserPlayerDataManager : Singleton<Data.UserPlayer.UserPlayerDataManager>
    {
        // Fields
        private int <CurrentSectionIndex>k__BackingField;
        private int <CurrentLevelIndex>k__BackingField;
        
        // Properties
        public int Coin { get; set; }
        public int CoinTemp { get; set; }
        public float UserPay { get; set; }
        public int UnlockSectionIndex { get; set; }
        public int UnlockLevelIndex { get; set; }
        public int HintFreeStatus { get; set; }
        public int GameScore { get; set; }
        public int FireworkCount { get; set; }
        public int UnlockQuizLevelIndex { get; set; }
        public int ShowQuizCount { get; set; }
        public int CurrentSectionIndex { get; set; }
        public int CurrentLevelIndex { get; set; }
        
        // Methods
        public void Init()
        {
            int val_1 = this.UnlockSectionIndex;
            this.<CurrentSectionIndex>k__BackingField = val_1;
            this.<CurrentLevelIndex>k__BackingField = val_1.UnlockLevelIndex;
        }
        public int get_Coin()
        {
            return (int)Store.UserPlayerData.__il2cppRuntimeField_name;
        }
        private void set_Coin(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_10 = value;
        }
        public int get_CoinTemp()
        {
            return (int)typeof(Store.UserPlayerData).__il2cppRuntimeField_14;
        }
        private void set_CoinTemp(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_14 = value;
        }
        public float get_UserPay()
        {
            return (float)Store.UserPlayerData.__il2cppRuntimeField_namespaze;
        }
        private void set_UserPay(float value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_18 = value;
        }
        public int get_UnlockSectionIndex()
        {
            return (int)typeof(Store.UserPlayerData).__il2cppRuntimeField_1C;
        }
        private void set_UnlockSectionIndex(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_1C = value;
        }
        public int get_UnlockLevelIndex()
        {
            return (int)Store.UserPlayerData.__il2cppRuntimeField_byval_arg;
        }
        private void set_UnlockLevelIndex(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_20 = value;
        }
        public int get_HintFreeStatus()
        {
            return (int)typeof(Store.UserPlayerData).__il2cppRuntimeField_24;
        }
        private void set_HintFreeStatus(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_24 = value;
        }
        public int get_GameScore()
        {
            return (int)typeof(Store.UserPlayerData).__il2cppRuntimeField_28;
        }
        private void set_GameScore(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_28 = value;
        }
        public int get_FireworkCount()
        {
            return (int)typeof(Store.UserPlayerData).__il2cppRuntimeField_2C;
        }
        private void set_FireworkCount(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_2C = value;
        }
        public int get_UnlockQuizLevelIndex()
        {
            return (int)Store.UserPlayerData.__il2cppRuntimeField_this_arg;
        }
        private void set_UnlockQuizLevelIndex(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_30 = value;
        }
        public int get_ShowQuizCount()
        {
            return (int)typeof(Store.UserPlayerData).__il2cppRuntimeField_34;
        }
        private void set_ShowQuizCount(int value)
        {
            typeof(Store.UserPlayerData).__il2cppRuntimeField_34 = value;
        }
        public int get_CurrentSectionIndex()
        {
            return (int)this.<CurrentSectionIndex>k__BackingField;
        }
        public void set_CurrentSectionIndex(int value)
        {
            this.<CurrentSectionIndex>k__BackingField = value;
        }
        public int get_CurrentLevelIndex()
        {
            return (int)this.<CurrentLevelIndex>k__BackingField;
        }
        private void set_CurrentLevelIndex(int value)
        {
            this.<CurrentLevelIndex>k__BackingField = value;
        }
        public void SetCoin(int value)
        {
            this.Coin = value;
        }
        public void GainCoins(int value, string from = "")
        {
            int val_9;
            Logic.Game.GameSound val_10;
            val_9 = value;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_rubbies", action:  "a1_earn", label:  from + "_" + val_9, value:  0);
            val_10 = 0;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
            {
                    val_10 = Logic.Game.GameManager.gameSound;
                val_10.Play(clipName:  "get_rubbies", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            int val_3 = val_10.CoinTemp;
            int val_4 = val_3.Coin;
            if(val_3 > val_4)
            {
                    int val_5 = val_4.CoinTemp;
                int val_6 = val_5.Coin;
                val_9 = val_5 - val_6;
                val_6.CoinTemp = 0;
            }
            
            int val_7 = val_6.Coin;
            val_7.Coin = val_7 + val_9;
        }
        public void SetCoinTemp(int value)
        {
            this.CoinTemp = value;
        }
        public void GainCoinsTemp(int value)
        {
            int val_1 = this.Coin;
            value = val_1 + value;
            val_1.CoinTemp = value;
        }
        public bool CostCoins(int value, string from = "")
        {
            var val_7;
            int val_1 = this.CoinTemp;
            int val_2 = val_1.Coin;
            if(val_1 > val_2)
            {
                    int val_3 = val_2.CoinTemp;
                val_3.Coin = val_3;
                val_3.CoinTemp = 0;
            }
            
            if(val_3.Coin < value)
            {
                    val_7 = 0;
                return (bool)val_7;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_rubbies", action:  "a1_cost", label:  from, value:  (long)value);
            int val_5 = Coin;
            val_5.Coin = val_5 - value;
            val_7 = 1;
            return (bool)val_7;
        }
        public float UserPayAdd(float price)
        {
            float val_1 = this.UserPay;
            val_1 = val_1 + price;
            this.UserPay = val_1;
            return this.UserPay;
        }
        public void SetUserPay(float value)
        {
            this.UserPay = value;
        }
        public bool IsLast(int section = -1, int level = -1)
        {
            int val_8;
            var val_9;
            if(section == 1)
            {
                goto label_0;
            }
            
            val_8 = level;
            int val_1 = this.UnlockSectionIndex;
            val_9 = ((val_8 == 1) ? 1 : 0) & ((val_1 == section) ? 1 : 0);
            if(val_8 == 1)
            {
                    return (bool)val_9;
            }
            
            if(val_1 != section)
            {
                    return (bool)val_9;
            }
            
            int val_4 = val_9.UnlockLevelIndex;
            goto label_3;
            label_0:
            val_8 = this.<CurrentSectionIndex>k__BackingField;
            int val_5 = this.UnlockSectionIndex;
            if(val_8 != val_5)
            {
                goto label_4;
            }
            
            val_8 = this.<CurrentLevelIndex>k__BackingField;
            label_3:
            var val_7 = (val_8 == val_5.UnlockLevelIndex) ? 1 : 0;
            return (bool)val_9;
            label_4:
            val_9 = 0;
            return (bool)val_9;
        }
        public void AddCurrentLevelIndex(int sectionLevelCount)
        {
            int val_2 = this.<CurrentLevelIndex>k__BackingField;
            val_2 = val_2 + 1;
            val_2 = val_2 - ((val_2 / sectionLevelCount) * sectionLevelCount);
            this.<CurrentLevelIndex>k__BackingField = val_2;
        }
        public void SetCurrentLevelIndex(int index)
        {
            this.<CurrentLevelIndex>k__BackingField = index;
        }
        public void SetUnlockSectionIndex(int index)
        {
            this.UnlockSectionIndex = index;
        }
        public void SetUnlockLevelIndex(int index)
        {
            this.UnlockLevelIndex = index;
        }
        public void AddHintFreeStatus(int hint)
        {
            int val_1 = this.HintFreeStatus;
            hint = val_1 + hint;
            val_1.HintFreeStatus = hint;
        }
        public void ReduceHintFreeStatus(int hint)
        {
            int val_1 = this.HintFreeStatus;
            hint = val_1 - hint;
            val_1.HintFreeStatus = hint;
        }
        public void SetHintFreeStatus(int hint)
        {
            this.HintFreeStatus = hint;
        }
        public void SetGameScore(int score)
        {
            this.GameScore = score;
        }
        public void AddFireworkCount(int count)
        {
            int val_1 = this.FireworkCount;
            count = val_1 + count;
            val_1.FireworkCount = count;
        }
        public void ReduceFireworkCount(int count)
        {
            int val_1 = this.FireworkCount;
            count = val_1 - count;
            val_1.FireworkCount = count;
        }
        public void AddUnlockQuizLevelIndex(int maxLevel)
        {
            int val_1 = this.UnlockQuizLevelIndex;
            val_1.UnlockQuizLevelIndex = val_1 + 1;
            int val_3 = val_1.UnlockQuizLevelIndex;
            val_3.UnlockQuizLevelIndex = val_3 - ((val_3 / maxLevel) * maxLevel);
        }
        public void SetUnlockQuizLevelIndex(int level)
        {
            this.UnlockQuizLevelIndex = level;
        }
        public void AddShowQuizCount()
        {
            int val_1 = this.ShowQuizCount;
            val_1.ShowQuizCount = val_1 + 1;
        }
        public void SetShowQuizCount(int count)
        {
            this.ShowQuizCount = count;
        }
        public UserPlayerDataManager()
        {
        
        }
    
    }

}
