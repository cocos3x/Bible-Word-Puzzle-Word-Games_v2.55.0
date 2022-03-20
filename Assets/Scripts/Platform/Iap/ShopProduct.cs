using UnityEngine;

namespace Platform.Iap
{
    public class ShopProduct
    {
        // Fields
        private string <productId>k__BackingField;
        private float <price>k__BackingField;
        private int <coin>k__BackingField;
        private int <hintHour>k__BackingField;
        private bool <isRemoveAds>k__BackingField;
        public static readonly System.Collections.Generic.List<Platform.Iap.ShopProduct> normalProductList;
        
        // Properties
        set; }
        protected float price { set; }
        protected int coin { set; }
        protected int hintHour { set; }
        protected bool isRemoveAds { set; }
        
        // Methods
        protected void set_productId(string value)
        {
            this.<productId>k__BackingField = value;
        }
        protected void set_price(float value)
        {
            this.<price>k__BackingField = value;
        }
        protected void set_coin(int value)
        {
            this.<coin>k__BackingField = value;
        }
        protected void set_hintHour(int value)
        {
            this.<hintHour>k__BackingField = value;
        }
        protected void set_isRemoveAds(bool value)
        {
            this.<isRemoveAds>k__BackingField = value;
        }
        private static ShopProduct()
        {
            Platform.Iap.ShopProduct.normalProductList = new System.Collections.Generic.List<Platform.Iap.ShopProduct>();
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1065185444;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 1.18575755001899E-321;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "rubies_usd_0_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 0;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1077894185;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 3.55727265005698E-321;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "rubies_usd_2_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 0;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1084206612;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "rubies_usd_4_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 6.52166652510445E-321;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 1;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1092605706;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 1.42290906002279E-320;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "rubies_usd_9_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 1;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1100999557;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "rubies_usd_19_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 3.08296963004938E-320;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 1;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1112012227;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 8.89318162514244E-320;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "rubies_usd_49_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 1;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1065185444;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 2.37151510003798E-321;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "special_offer_usd_0_99";
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 0;
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1073657938;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 6.52166652510445E-321;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 1;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "one_time_offer_usd_1_99";
            Add(item:  new System.Object());
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_1C = 0;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_20 = 0;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_18 = 1077894185;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_24 = 1;
            typeof(Platform.Iap.ShopProduct).__il2cppRuntimeField_10 = "no_ads_usd_2_99";
            Add(item:  new System.Object());
            Platform.Iap.ShopProduct.normalProductList = new System.Collections.Generic.List<Platform.Iap.ShopProduct>();
        }
        public ShopProduct()
        {
        
        }
    
    }

}
