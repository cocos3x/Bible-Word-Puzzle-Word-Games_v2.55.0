using UnityEngine;

namespace Data.Bean
{
    [Serializable]
    public class PropertyBean
    {
        // Fields
        public int defaultCoin;
        public int dailyChallenge;
        public System.Collections.Generic.List<int> dailySign;
        public int freeHint;
        public System.Collections.Generic.List<int> gameGift;
        public int resultVideo;
        public int resultDailyVideo;
        public System.Collections.Generic.List<int> comboReward;
        public Data.Bean.PropertyBonusBean bonusReward;
        public int extraReward;
        public int extraProgressCount;
        public int extraLeft5ProgressCount;
        public int quizReward;
        
        // Methods
        public PropertyBean()
        {
        
        }
    
    }

}
