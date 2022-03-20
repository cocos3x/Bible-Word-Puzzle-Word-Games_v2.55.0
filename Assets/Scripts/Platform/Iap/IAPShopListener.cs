using UnityEngine;

namespace Platform.Iap
{
    public class IAPShopListener : Singleton<Platform.Iap.IAPShopListener>
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, Platform.Iap.IapFromInfo> iapFromDic;
        private bool isInited;
        
        // Methods
        public void Init()
        {
            if(this.isInited == true)
            {
                    return;
            }
            
            this.isInited = true;
            System.Delegate val_2 = System.Delegate.Combine(a:  Logic.Game.GameManager.iap.onPurchaseSuccess, b:  new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  System.Void Platform.Iap.IAPShopListener::PurchaseSuccess(UnityEngine.Purchasing.Product product)));
            if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_7;
            }
            
            }
            
            Logic.Game.GameManager.iap.onPurchaseSuccess = val_2;
            System.Delegate val_4 = System.Delegate.Combine(a:  Logic.Game.GameManager.iap.onPurchaseFailed, b:  new System.Action<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(object:  this, method:  System.Void Platform.Iap.IAPShopListener::PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)));
            if(val_4 != null)
            {
                    if(null != null)
            {
                goto label_7;
            }
            
            }
            
            Logic.Game.GameManager.iap.onPurchaseFailed = val_4;
            return;
            label_7:
        }
        private void PurchaseSuccess(UnityEngine.Purchasing.Product product)
        {
            Message.Messager.Dispatch(cmd:  38);
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.SetFirstBuyProductTime();
            View.Dialog.ShopTest.Controller.ShopController val_2 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            if((val_2.<IsClickBuyProduct>k__BackingField) != false)
            {
                    Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.PurchaseSuccessGrantRewards(productId:  product.<definition>k__BackingField.<id>k__BackingField);
                View.Dialog.ShopTest.Controller.ShopController val_4 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
                if((val_4.<IsShowShopping>k__BackingField) != true)
            {
                    object[] val_5 = new object[1];
                val_5[0] = product.<definition>k__BackingField.<id>k__BackingField;
                View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "PurchaseSuccessDialog", pars:  val_5);
            }
            
                View.Dialog.ShopTest.Controller.ShopController val_7 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
                val_7.<IsClickBuyProduct>k__BackingField = false;
                Message.Messager.Dispatch<UnityEngine.Purchasing.Product>(cmd:  105, t:  product);
                return;
            }
            
            if((product.<definition>k__BackingField.<id>k__BackingField.Equals(value:  "products_no_ads_2.99")) != true)
            {
                    if((product.<definition>k__BackingField.<id>k__BackingField.Equals(value:  "products_remove_ads_bundle_2.99")) == false)
            {
                    return;
            }
            
            }
            
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.SetBuyItem(isBuy:  true);
        }
        private void PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
        {
            Message.Messager.Dispatch(cmd:  38);
            Message.Messager.Dispatch<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(cmd:  106, t:  product, u:  failureReason);
            Platform.Analytics.EzAnalytics.SendIapItemPurchase(name:  product.<definition>k__BackingField.<id>k__BackingField, purResult:  failureReason.ToString());
        }
        public IAPShopListener()
        {
            this.iapFromDic = new System.Collections.Generic.Dictionary<System.String, Platform.Iap.IapFromInfo>();
        }
    
    }

}
