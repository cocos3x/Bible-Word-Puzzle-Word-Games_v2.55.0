using UnityEngine;

namespace View.Dialog.ShopTest
{
    public class ShopFixedPackage : RecyclableItem
    {
        // Fields
        public UnityEngine.Animator AnimatorPack;
        public UnityEngine.UI.Text TextName;
        public UnityEngine.Transform TransformLabel;
        public TMPro.TextMeshProUGUI TextLabel;
        public UnityEngine.Sprite[] SpriteIcons;
        public UnityEngine.UI.Image ImageIcon;
        public View.CommonItem.ShopRewardItem RewardItemPrefab;
        public UnityEngine.Transform RewardContent;
        public TMPro.TextMeshProUGUI TextPrice;
        private System.Collections.Generic.List<View.CommonItem.ShopRewardItem> _items;
        private View.CommonItem.ShopRewardItem _tempItem;
        private Data.Bean.ProductBean _productBean;
        private string _productId;
        
        // Methods
        public static View.Dialog.ShopTest.ShopFixedPackage Create(UnityEngine.Transform parent, View.Dialog.ShopTest.ShopFixedPackage prefab)
        {
            View.Dialog.ShopTest.ShopFixedPackage val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.ShopTest.ShopFixedPackage>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            return val_1;
        }
        public void OnClickBuyButton()
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  this._productId)) != false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "item_click", label:  this._productId, value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a2_item_click", label:  this._productBean.name, value:  0);
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendIapItemClick(name:  this._productId, source:  new SourceEnum() {<Value>k__BackingField = IapItemClick.SourceEnum.SourceShopScr});
            if(Common.EzNetwork.IsNetworkAvailable() != false)
            {
                    if((Logic.Game.GameManager.iap.BuyProductByID(productId:  this._productId)) == true)
            {
                    return;
            }
            
                View.Dialog.Common.Dialog val_4 = Logic.Game.GameManager.gameDialog.Open(name:  "PurchaseFailedDialog", type:  0);
                return;
            }
            
            Logic.Game.GameManager.gameDialog.Open(name:  "NetErrorDialog", type:  0).ActiveBlackBG(isActive:  true);
        }
        public void SetFixedPackageInfo(Data.Bean.ProductBean data)
        {
            UnityEngine.UI.Image val_14;
            UnityEngine.Sprite val_15;
            string val_16;
            this._productBean = data;
            this._productId = data.productId;
            this.ClearRewardContent();
            if(data.rewards >= 1)
            {
                    var val_14 = 0;
                do
            {
                View.CommonItem.ShopRewardItem val_1 = View.CommonItem.ShopRewardItem.Create(parent:  this.RewardContent, prefab:  this.RewardItemPrefab);
                this._tempItem = val_1;
                this._items.Add(item:  val_1);
                if(val_14 >= this._items)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this._tempItem.SetRewardItemInfo(data:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg);
                val_14 = val_14 + 1;
            }
            while(val_14 < data.rewards);
            
            }
            
            if((data.name.Equals(value:  "46")) == false)
            {
                goto label_11;
            }
            
            val_14 = this;
            val_15 = this.SpriteIcons[0];
            goto label_27;
            label_11:
            if((data.name.Equals(value:  "48")) == false)
            {
                goto label_17;
            }
            
            val_14 = this;
            val_15 = this.SpriteIcons[1];
            goto label_27;
            label_17:
            if((data.name.Equals(value:  "53")) == false)
            {
                goto label_23;
            }
            
            val_14 = this;
            val_15 = this.SpriteIcons[2];
            goto label_27;
            label_23:
            val_14 = this.ImageIcon;
            if((data.name.Equals(value:  "54")) == false)
            {
                goto label_29;
            }
            
            val_15 = this.SpriteIcons[3];
            label_27:
            this.ImageIcon.sprite = val_15;
            label_29:
            string val_6 = Locale.LocaleManager.Translate(key:  data.name);
            this.TransformLabel.gameObject.SetActive(value:  (~(System.String.IsNullOrEmpty(value:  data.desc))) & 1);
            this.TextLabel.text = Locale.LocaleManager.Translate(key:  data.desc);
            string val_11 = Logic.Game.GameManager.iap.GetLocalizedPriceString(productId:  data.productId);
            val_16 = val_11;
            if((System.String.op_Equality(a:  val_11, b:  System.String.alignConst)) != false)
            {
                    val_16 = "$" + data.price;
            }
            
            this.TextPrice.text = val_16;
        }
        public void HideItem()
        {
            this.PlayHideAni();
        }
        private void PlayHideAni()
        {
            this.AnimatorPack.Play(stateName:  "FixedPackageHide");
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
        public ShopFixedPackage()
        {
            this._items = new System.Collections.Generic.List<View.CommonItem.ShopRewardItem>();
        }
    
    }

}
