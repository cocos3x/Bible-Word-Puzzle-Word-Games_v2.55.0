using UnityEngine;

namespace Store
{
    public class UserPlayerData : IStoreData
    {
        // Fields
        public int Coin;
        public int CoinTemp;
        public float UserPay;
        public int UnlockSectionIndex;
        public int UnlockLevelIndex;
        public int HintFreeStatus;
        public int GameScore;
        public int FireworkCount;
        public int UnlockQuizLevelIndex;
        public int ShowQuizCount;
        
        // Methods
        public void Reset()
        {
            this.Coin = 500;
            this.UnlockSectionIndex = 0;
            this.UnlockLevelIndex = 0;
            this.CoinTemp = 0;
            this.UserPay = 0f;
            this.HintFreeStatus = 0;
            this.GameScore = ;
            this.FireworkCount = ;
            this.UnlockQuizLevelIndex = 0;
            this.ShowQuizCount = 0;
        }
        public UserPlayerData()
        {
        
        }
    
    }

}
