using UnityEngine;

namespace Platform.Ad
{
    public class GameAdID
    {
        // Fields
        public static readonly string BannerID;
        public static readonly string RewardID;
        public static readonly string InterstitalLevelPassID;
        
        // Methods
        private static GameAdID()
        {
            Platform.Ad.GameAdID.BannerID = "gamepage";
            Platform.Ad.GameAdID.RewardID = "game";
            Platform.Ad.GameAdID.InterstitalLevelPassID = "levelPass";
        }
    
    }

}
