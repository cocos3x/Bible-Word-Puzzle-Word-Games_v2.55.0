using UnityEngine;

namespace Common
{
    public static class GlobalProperty
    {
        // Fields
        public static bool isUserFirstLogin;
        
        // Methods
        public static int GetComboReward(int comboCount)
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = comboCount;
            int val_1 = val_8 - 2;
            if()
            {
                goto label_1;
            }
            
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() == null)
            {
                    return (int)val_9;
            }
            
            Data.Bean.PropertyBean val_3 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            Data.Bean.PropertyBean val_4 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            int val_5 = val_8 - 1;
            if(val_5 <= W23)
            {
                goto label_9;
            }
            
            Data.Bean.PropertyBean val_6 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            val_8 = val_6.comboReward - 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = val_6.comboReward + (val_8 << 2);
            goto label_15;
            label_1:
            val_9 = 0;
            return (int)val_9;
            label_9:
            if(val_5 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_5 + (val_1 << 2);
            label_15:
            val_9 = mem[((comboCount - 1) + ((comboCount - 2)) << 2) + 32];
            val_9 = ((comboCount - 1) + ((comboCount - 2)) << 2) + 32;
            return (int)val_9;
        }
        public static int GetBonusReward()
        {
            int val_10;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() != null)
            {
                    Data.Bean.PropertyBean val_2 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                val_10 = val_2.bonusReward.fixedNum;
                if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) > 99)
            {
                    return (int)val_10;
            }
            
                Data.Bean.PropertyBean val_5 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                if(val_5.bonusReward.rangeNum != 2)
            {
                    return (int)val_10;
            }
            
                Data.Bean.PropertyBean val_6 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                if(val_6.bonusReward <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Data.Bean.PropertyBean val_7 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                if(val_7.bonusReward == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Data.Bean.PropertyBean val_8 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                if(val_8.bonusReward == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Data.Bean.PropertyBean val_9 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                if(val_9.bonusReward > 1)
            {
                    return UnityEngine.Random.Range(min:  Logic.Game.GameManager.gameDailyPrayer, max:  0);
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                return UnityEngine.Random.Range(min:  Logic.Game.GameManager.gameDailyPrayer, max:  0);
            }
            
            val_10 = 14;
            return (int)val_10;
        }
    
    }

}
