using UnityEngine;

namespace Data.Shop
{
    public class ShopRewardItemName
    {
        // Fields
        public static string ITEM_NO_ADS;
        public static string ITEM_COIN;
        public static string ITEM_HINT;
        public static string ITEM_FIREWORK;
        
        // Methods
        private static ShopRewardItemName()
        {
            Data.Shop.ShopRewardItemName.ITEM_NO_ADS = "item_no_ads";
            Data.Shop.ShopRewardItemName.ITEM_COIN = "item_coin";
            Data.Shop.ShopRewardItemName.ITEM_HINT = "item_hint";
            Data.Shop.ShopRewardItemName.ITEM_FIREWORK = "item_firework";
        }
    
    }

}
