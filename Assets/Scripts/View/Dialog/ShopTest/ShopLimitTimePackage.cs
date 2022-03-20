using UnityEngine;

namespace View.Dialog.ShopTest
{
    public class ShopLimitTimePackage : RecyclableItem
    {
        // Fields
        public UnityEngine.Animator AnimatorPack;
        public UnityEngine.UI.Text TextName;
        public UnityEngine.UI.Text TextLabel;
        public UnityEngine.UI.Image ImageNoAds;
        public UnityEngine.Sprite[] SpriteIcons;
        public UnityEngine.UI.Image ImageIcon;
        public View.CommonItem.ShopRewardItem RewardItemPrefab;
        public UnityEngine.Transform RewardContent;
        public TMPro.TextMeshProUGUI TextPrice;
        public View.CommonItem.ShopLimitedTime LimitedTime;
        public UnityEngine.UI.Text ValueText;
        private System.Collections.Generic.List<View.CommonItem.ShopRewardItem> _items;
        private View.CommonItem.ShopRewardItem _tempItem;
        private Data.Bean.ProductBean _productBean;
        private string _productId;
        
        // Methods
        public static View.Dialog.ShopTest.ShopLimitTimePackage Create(UnityEngine.Transform parent, View.Dialog.ShopTest.ShopLimitTimePackage prefab)
        {
            View.Dialog.ShopTest.ShopLimitTimePackage val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.ShopTest.ShopLimitTimePackage>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            return val_1;
        }
        public void OnClickBuyButton()
        {
            var val_7;
            if((System.String.IsNullOrEmpty(value:  this._productId)) != false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "item_click", label:  this._productId, value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a2_item_click", label:  this._productBean.name, value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "sale_popup", action:  "click", label:  this._productId + "_store", value:  0);
            val_7 = null;
            val_7 = null;
            Platform.Analytics.EzAnalytics.SendIapItemClick(name:  this._productId, source:  new SourceEnum() {<Value>k__BackingField = IapItemClick.SourceEnum.SourceShopScr});
            if(Common.EzNetwork.IsNetworkAvailable() != false)
            {
                    if((Logic.Game.GameManager.iap.BuyProductByID(productId:  this._productId)) == true)
            {
                    return;
            }
            
                View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.Open(name:  "PurchaseFailedDialog", type:  0);
                return;
            }
            
            Logic.Game.GameManager.gameDialog.Open(name:  "NetErrorDialog", type:  0).ActiveBlackBG(isActive:  true);
        }
        public void SetLimitTimePackageInfo(Data.Bean.ProductBean data, long seconds)
        {
            UnityEngine.UI.Image val_14;
            UnityEngine.Sprite val_15;
            string val_16;
            this._productBean = data;
            this._productId = data.productId;
            this.ClearRewardContent();
            this.ImageNoAds.gameObject.SetActive(value:  false);
            if(data.productId >= 1)
            {
                    var val_14 = 0;
                do
            {
                if(data.productId <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((System.String.__il2cppRuntimeField_byval_arg + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS)) != false)
            {
                    this.ImageNoAds.gameObject.SetActive(value:  true);
            }
            else
            {
                    View.CommonItem.ShopRewardItem val_4 = View.CommonItem.ShopRewardItem.Create(parent:  this.RewardContent, prefab:  this.RewardItemPrefab);
                this._tempItem = val_4;
                this._items.Add(item:  val_4);
                if(this._items <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this._tempItem.SetRewardItemInfo(data:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg);
            }
            
                val_14 = val_14 + 1;
            }
            while(val_14 < null);
            
            }
            
            if((data.name.Equals(value:  "60")) == false)
            {
                goto label_22;
            }
            
            val_14 = this;
            val_15 = this.SpriteIcons[0];
            goto label_38;
            label_22:
            if((data.name.Equals(value:  "64")) == false)
            {
                goto label_28;
            }
            
            val_14 = this;
            val_15 = this.SpriteIcons[1];
            goto label_38;
            label_28:
            if((data.name.Equals(value:  "63")) == false)
            {
                goto label_34;
            }
            
            val_14 = this;
            val_15 = this.SpriteIcons[2];
            goto label_38;
            label_34:
            val_14 = this.ImageIcon;
            if((data.name.Equals(value:  "65")) == false)
            {
                goto label_40;
            }
            
            val_15 = this.SpriteIcons[3];
            label_38:
            this.ImageIcon.sprite = val_15;
            label_40:
            string val_9 = Locale.LocaleManager.Translate(key:  data.name);
            string val_10 = Locale.LocaleManager.Translate(key:  "61");
            string val_11 = Logic.Game.GameManager.iap.GetLocalizedPriceString(productId:  data.productId);
            val_16 = val_11;
            if((System.String.op_Equality(a:  val_11, b:  System.String.alignConst)) != false)
            {
                    val_16 = "$" + data.price;
            }
            
            this.TextPrice.text = val_16;
            this.LimitedTime.SetLimitedTimeCountDown(seconds:  seconds);
        }
        public void HideItem()
        {
            this.PlayHideAni();
        }
        private void PlayHideAni()
        {
            this.AnimatorPack.Play(stateName:  "LimitTimePackageHide");
        }
        private void ClearRewardContent()
        {
            if(this._items < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            if(val_2 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            View.CommonItem.ShopRewardItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.CommonItem.ShopRewardItem>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
            val_2 = val_2 + 1;
            this._items.Clear();
        }
        public ShopLimitTimePackage()
        {
            this._items = new System.Collections.Generic.List<View.CommonItem.ShopRewardItem>();
        }
    
    }

}
