using UnityEngine;

namespace Platform.Ad
{
    public class GameAdPosition
    {
        // Fields
        public static readonly string GameButton;
        public static readonly string LevelPass;
        public static readonly string LevelStart;
        public static readonly string ShopClose;
        public static readonly string WatchMore5s;
        public static readonly string WatchMoreReward;
        public static readonly string Wrong4TimesGift;
        public static readonly string DailyGiftFormat;
        public static readonly string DailyGift;
        public static readonly string DailyReward;
        public static readonly string Banner;
        
        // Methods
        private static GameAdPosition()
        {
            Platform.Ad.GameAdPosition.GameButton = "game_button";
            Platform.Ad.GameAdPosition.LevelPass = "level_pass";
            Platform.Ad.GameAdPosition.LevelStart = "level_start";
            Platform.Ad.GameAdPosition.ShopClose = "shop_close";
            Platform.Ad.GameAdPosition.WatchMore5s = "watch_more_5s";
            Platform.Ad.GameAdPosition.WatchMoreReward = "watch_more_reward";
            Platform.Ad.GameAdPosition.Wrong4TimesGift = "wrong_4times_gift";
            Platform.Ad.GameAdPosition.DailyGiftFormat = "daily_gift_";
            Platform.Ad.GameAdPosition.DailyGift = "daily_gift";
            Platform.Ad.GameAdPosition.DailyReward = "daily_reward";
            Platform.Ad.GameAdPosition.Banner = "Banner";
        }
    
    }

}
