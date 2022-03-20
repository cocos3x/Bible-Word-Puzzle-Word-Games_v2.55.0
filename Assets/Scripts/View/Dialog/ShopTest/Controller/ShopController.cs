using UnityEngine;

namespace View.Dialog.ShopTest.Controller
{
    public class ShopController : Singleton<View.Dialog.ShopTest.Controller.ShopController>
    {
        // Fields
        private Data.Bean.ProductsBean _productsBean;
        private bool <IsShowShopping>k__BackingField;
        private bool <IsClickBuyProduct>k__BackingField;
        private int <NowCurLevelPurchaseCount>k__BackingField;
        
        // Properties
        public bool IsShowShopping { get; set; }
        public bool IsClickBuyProduct { get; set; }
        public int NowCurLevelPurchaseCount { get; set; }
        
        // Methods
        public void set_IsShowShopping(bool value)
        {
            this.<IsShowShopping>k__BackingField = value;
        }
        public bool get_IsShowShopping()
        {
            return (bool)this.<IsShowShopping>k__BackingField;
        }
        public void set_IsClickBuyProduct(bool value)
        {
            this.<IsClickBuyProduct>k__BackingField = value;
        }
        public bool get_IsClickBuyProduct()
        {
            return (bool)this.<IsClickBuyProduct>k__BackingField;
        }
        public int get_NowCurLevelPurchaseCount()
        {
            return (int)this.<NowCurLevelPurchaseCount>k__BackingField;
        }
        public void set_NowCurLevelPurchaseCount(int value)
        {
            this.<NowCurLevelPurchaseCount>k__BackingField = value;
        }
        public void AddPackageShowTimeForName(string name)
        {
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.AddPackageShowTimeForName(name:  name);
        }
        public int GetPackageShowTimeForName(string name)
        {
            return Common.Singleton<Data.Shop.ShopDataManager>.Instance.GetPackageShowTimeForName(name:  name);
        }
        public void SetOverdueSecondForName(string name, System.DateTime overdueTime)
        {
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.SetOverdueSecondForName(name:  name, overdueTime:  new System.DateTime() {dateData = overdueTime.dateData});
        }
        public void ClearOverdueSecondForName(string name)
        {
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.ClearOverdueSecondForName(name:  name);
            Message.Messager.Dispatch(cmd:  79);
        }
        public long GetOverdueSecondForName(string name)
        {
            return Common.Singleton<Data.Shop.ShopDataManager>.Instance.GetOverdueSecondForName(name:  name);
        }
        public void PlayLevel()
        {
            Data.Shop.ShopDataManager val_1 = Common.Singleton<Data.Shop.ShopDataManager>.Instance;
            int val_2 = val_1.<PlayLevelCount>k__BackingField;
            val_2 = val_2 + 1;
            val_1.<PlayLevelCount>k__BackingField = val_2;
        }
        public System.Collections.Generic.List<Data.Bean.ProductBean> SortShortestTimePack(System.Collections.Generic.List<Data.Bean.ProductBean> packs)
        {
            if(1152921512672237568 < 1)
            {
                goto label_2;
            }
            
            var val_8 = 0;
            if(1152921512672237568 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.Void System.Array::InternalArray__Insert<Dictionary.Entry<System.Int32, System.Int64>>(int index, Dictionary.Entry<System.Int32, System.Int64> item).__il2cppRuntimeField_30.Equals(value:  "63")) != false)
            {
                    if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == true)
            {
                goto label_11;
            }
            
            }
            
            if((System.Void System.Array::InternalArray__Insert<Dictionary.Entry<System.Int32, System.Int64>>(int index, Dictionary.Entry<System.Int32, System.Int64> item)) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this.GetOverdueSecondForName(name:  System.Void System.Array::InternalArray__Insert<Dictionary.Entry<System.Int32, System.Int64>>(int index, Dictionary.Entry<System.Int32, System.Int64> item).__il2cppRuntimeField_20 + 48)) >= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                Add(item:  (System.Void System.Array::InternalArray__Insert<Dictionary.Entry<System.Int32, System.Int64>>(int index, Dictionary.Entry<System.Int32, System.Int64> item).__il2cppRuntimeField_20 + 0) + 32);
            }
            
            label_11:
            val_8 = val_8 + 1;
            label_2:
            Sort(comparer:  new View.Dialog.GameDictionary.Controller.LimiTimePackageComparer());
            return (System.Collections.Generic.List<Data.Bean.ProductBean>)new System.Collections.Generic.List<Data.Bean.ProductBean>();
        }
        public bool IsHaveLimitedTimePack()
        {
            this._productsBean = Logic.Game.GameManager.gameConfig._productsBean;
            if(null != 0)
            {
                    var val_3 = 0;
                do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if((this.GetOverdueSecondForName(name:  (ProductsBean.__il2cppRuntimeField_10 + 0) + 32 + 48)) > 0)
            {
                    return false;
            }
            
                val_3 = val_3 + 1;
            }
            while(this._productsBean.limitedTimePackage != null);
            
                throw new NullReferenceException();
            }
            
            return false;
        }
        public bool IsHaveSurpriseSuperBundle()
        {
            var val_10;
            string val_2 = Common.Singleton<Data.Shop.ShopDataManager>.Instance.GetFirstBuyProductTime();
            if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    System.DateTime val_4 = System.DateTime.Now;
                System.DateTime val_5 = Utils.Csharp.StringExtension.ToDateTime(self:  val_2, defaultValue:  new System.DateTime());
                System.TimeSpan val_6 = val_4.dateData.Subtract(value:  new System.DateTime() {dateData = val_5.dateData});
                if(val_6._ticks.TotalHours > 48)
            {
                    Data.Shop.ShopDataManager val_8 = Common.Singleton<Data.Shop.ShopDataManager>.Instance;
                var val_9 = ((val_8.<PlayLevelCount>k__BackingField) > 1) ? 1 : 0;
                return (bool)val_10;
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public Data.Bean.ProductBean GetPackForName(string name)
        {
            var val_3;
            var val_4;
            this._productsBean = Logic.Game.GameManager.gameConfig._productsBean;
            if(null == 0)
            {
                goto label_7;
            }
            
            val_4 = 0;
            if((System.String.IsNullOrEmpty(value:  name)) == true)
            {
                    return (Data.Bean.ProductBean)val_4;
            }
            
            if(this._productsBean < 1)
            {
                goto label_7;
            }
            
            val_3 = 0;
            label_13:
            if(val_3 >= this._productsBean)
            {
                goto label_7;
            }
            
            if(this._productsBean <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg + 48.Equals(value:  name)) == true)
            {
                goto label_11;
            }
            
            val_3 = val_3 + 1;
            if(this._productsBean.limitedTimePackage != null)
            {
                goto label_13;
            }
            
            label_7:
            val_4 = 0;
            return (Data.Bean.ProductBean)val_4;
            label_11:
            if(this._productsBean > val_3)
            {
                    return (Data.Bean.ProductBean)val_4;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return (Data.Bean.ProductBean)val_4;
        }
        public Data.Bean.ProductBean GetProductInfoForProductId(string productId)
        {
            var val_5;
            string val_6;
            var val_7;
            val_6 = productId;
            this._productsBean = Logic.Game.GameManager.gameConfig._productsBean;
            val_7 = 0;
            if((System.String.IsNullOrEmpty(value:  val_6)) == true)
            {
                    return (Data.Bean.ProductBean)Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg;
            }
            
            if(W9 < 1)
            {
                goto label_6;
            }
            
            val_5 = 0;
            label_12:
            if(val_5 >= W9)
            {
                goto label_6;
            }
            
            if(W9 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg + 16.Equals(value:  val_6)) == true)
            {
                goto label_10;
            }
            
            val_5 = val_5 + 1;
            if(this._productsBean.limitedTimePackage != null)
            {
                goto label_12;
            }
            
            label_6:
            if(W9 < 1)
            {
                goto label_16;
            }
            
            val_5 = 0;
            label_22:
            if(val_5 >= W9)
            {
                goto label_16;
            }
            
            if(W9 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg + 16.Equals(value:  val_6)) == true)
            {
                goto label_20;
            }
            
            val_5 = val_5 + 1;
            if(this._productsBean.fixedPackage != null)
            {
                goto label_22;
            }
            
            label_16:
            if(this._productsBean < 1)
            {
                goto label_26;
            }
            
            val_5 = 0;
            label_32:
            if(val_5 >= this._productsBean)
            {
                goto label_26;
            }
            
            if(this._productsBean <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg + 16.Equals(value:  val_6)) == true)
            {
                goto label_30;
            }
            
            val_5 = val_5 + 1;
            if(this._productsBean.products != null)
            {
                goto label_32;
            }
            
            label_26:
            val_7 = 0;
            return (Data.Bean.ProductBean)Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg;
            label_10:
            val_6 = this._productsBean.limitedTimePackage;
            if(val_6 != null)
            {
                goto label_39;
            }
            
            label_20:
            val_6 = this._productsBean.fixedPackage;
            if(val_6 != null)
            {
                goto label_39;
            }
            
            label_30:
            val_6 = this._productsBean.products;
            label_39:
            if(this._productsBean > val_5)
            {
                    return (Data.Bean.ProductBean)Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return (Data.Bean.ProductBean)Data.Bean.ProductsBean.__il2cppRuntimeField_byval_arg;
        }
        public void PurchaseSuccessGrantRewards(string productId)
        {
            var val_19;
            System.Collections.Generic.List<Data.Bean.RewardItem> val_20;
            var val_21;
            bool val_19 = true;
            Data.Bean.ProductBean val_1 = this.GetProductInfoForProductId(productId:  productId);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_19 = val_1;
            if(val_19 < 1)
            {
                goto label_3;
            }
            
            var val_20 = 0;
            goto label_53;
            label_45:
            if(val_19 <= val_20)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + ((X28) << 3);
            if(((true + (X28) << 3) + 32 + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS)) == false)
            {
                goto label_24;
            }
            
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.SetBuyItem(isBuy:  true);
            Platform.Analytics.AnalyzerUStatus.RemoveAds(value:  true);
            goto label_24;
            label_53:
            if(val_19 <= val_20)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + 0;
            if(((true + 0) + 32 + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_COIN)) == false)
            {
                goto label_19;
            }
            
            val_20 = val_1.rewards;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS.__il2cppRuntimeField_20 + 24);
            goto label_24;
            label_19:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((Data.Shop.ShopRewardItemName.ITEM_NO_ADS.__il2cppRuntimeField_20 + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_HINT)) == false)
            {
                goto label_31;
            }
            
            val_20 = val_1.rewards;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddHintFreeStatus(hint:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS.__il2cppRuntimeField_20 + 24);
            val_21 = 71;
            goto label_38;
            label_31:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((Data.Shop.ShopRewardItemName.ITEM_NO_ADS.__il2cppRuntimeField_20 + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_FIREWORK)) == false)
            {
                goto label_45;
            }
            
            val_20 = val_1.rewards;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddFireworkCount(count:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS.__il2cppRuntimeField_20 + 24);
            val_21 = 72;
            label_38:
            Message.Messager.Dispatch(cmd:  72);
            label_24:
            val_20 = val_20 + 1;
            label_3:
            Platform.Analytics.EzAnalytics.SendIapItemPurchase(name:  productId, purResult:  "success");
            productId.PurchaseSuccessAddEvent(price:  val_1.price);
            Data.Bean.ProductBean val_10 = this.GetPackForName(name:  val_1.name);
            if(val_10 == null)
            {
                goto label_58;
            }
            
            val_10.ClearOverdueSecondForName(name:  val_10.name);
            goto label_58;
            label_1:
            val_19 = 1152921512673088384;
            Data.PiggyBank.PiggyBankDataManager val_11 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            if((productId.Equals(value:  val_11.ProductId)) != false)
            {
                    Platform.Analytics.EzAnalytics.SendIapItemPurchase(name:  productId, purResult:  "success");
                Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.PurchaseSuccessAddEvent(price:  val_13.PiggyBankPrice);
                Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.GetPiggyBankCoinNumber());
                Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.SetPiggyBankCoinNumber(num:  0);
                Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.SetPiggyBankFullUnPop(isUnPop:  true);
            }
            
            label_58:
            int val_21 = this.<NowCurLevelPurchaseCount>k__BackingField;
            val_21 = val_21 + 1;
            this.<NowCurLevelPurchaseCount>k__BackingField = val_21;
            Store.StoreManager.FileName.Save();
        }
        private void PurchaseSuccessAddEvent(float price)
        {
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.SetBuyAnyItem(isBuy:  true);
            Platform.Analytics.AnalyzerUStatus.Purchased(value:  ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UserPay) > 0f) ? 1 : 0);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UserPay) >= 0)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UserPayAdd(price:  price)) < 20f)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_pay", platform:  2);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_pay", platform:  1);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "marketing_user", action:  "pay_user", label:  "", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_pay_user", platform:  2);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_pay_user", platform:  1);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "grt_retention", action:  "pay_user", label:  "", value:  0);
        }
        public ShopController()
        {
        
        }
    
    }

}
