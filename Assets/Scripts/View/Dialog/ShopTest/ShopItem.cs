using UnityEngine;

namespace View.Dialog.ShopTest
{
    public class ShopItem : RecyclableItem
    {
        // Fields
        public UnityEngine.Animator AnimatorItem;
        public UnityEngine.Transform TransformNoAds;
        public UnityEngine.Transform TransformCoins;
        public UnityEngine.UI.Text TextCount;
        public UnityEngine.UI.Text TextDesc;
        public TMPro.TMP_Text RemoveAdTitle1;
        public TMPro.TMP_Text RemoveAdTitle2;
        public TMPro.TextMeshProUGUI TextPrice;
        private Data.Bean.ProductBean _productBean;
        private string _productId;
        
        // Methods
        public static View.Dialog.ShopTest.ShopItem Create(UnityEngine.Transform parent, View.Dialog.ShopTest.ShopItem prefab)
        {
            View.Dialog.ShopTest.ShopItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.ShopTest.ShopItem>(prefab:  prefab, bufferSize:  10);
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
        public void SetItemInfo(Data.Bean.ProductBean data)
        {
            TMPro.TextMeshProUGUI val_14;
            string val_15;
            if(data.rewards == null)
            {
                goto label_3;
            }
            
            this._productBean = data;
            this._productId = data.productId;
            if(data.productId == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_2 = this.TransformNoAds.gameObject;
            if((X22 + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS)) == false)
            {
                goto label_12;
            }
            
            val_2.SetActive(value:  true);
            this.RemoveAdTitle1.text = Locale.LocaleManager.Translate(key:  "49");
            this.RemoveAdTitle2.text = Locale.LocaleManager.Translate(key:  "50");
            this.TransformCoins.gameObject.SetActive(value:  false);
            goto label_17;
            label_3:
            this._productId = System.String.alignConst;
            return;
            label_12:
            val_2.SetActive(value:  false);
            this.TransformCoins.gameObject.SetActive(value:  true);
            string val_7 = "x" + X22 + 24(X22 + 24);
            if((System.String.IsNullOrEmpty(value:  data.desc)) != false)
            {
                    if(this.TextDesc != null)
            {
                goto label_23;
            }
            
            }
            
            string val_10 = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "55"), arg0:  data.desc);
            label_23:
            label_17:
            string val_11 = Logic.Game.GameManager.iap.GetLocalizedPriceString(productId:  data.productId);
            val_14 = this.TextPrice;
            val_15 = val_11;
            if((System.String.op_Equality(a:  val_11, b:  System.String.alignConst)) != false)
            {
                    val_15 = "$" + data.price;
            }
            
            val_14.text = val_15;
            this.PlayShowAni();
        }
        public void HideItem()
        {
            this.PlayHideAni();
        }
        private void PlayShowAni()
        {
            this.AnimatorItem.Play(stateName:  "ShopItemShow");
        }
        private void PlayHideAni()
        {
            this.AnimatorItem.Play(stateName:  "ShopItemHide");
        }
        public ShopItem()
        {
        
        }
    
    }

}
