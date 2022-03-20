using UnityEngine;

namespace View.Dialog.PurchaseSuccess
{
    public class PurchaseSuccessDialog : Dialog
    {
        // Fields
        private readonly UnityEngine.Vector3 BigScale;
        public UnityEngine.Sprite[] SpriteIcons;
        public UnityEngine.UI.Image ImageIcon;
        public UnityEngine.Transform TransformFlyStart;
        public UnityEngine.Transform RewardContent;
        public View.Dialog.PurchaseSuccess.PurchaseRewardItem RewardItemPrefab;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text ClaimText;
        private System.Collections.Generic.List<View.Dialog.PurchaseSuccess.PurchaseRewardItem> _items;
        private View.Dialog.PurchaseSuccess.PurchaseRewardItem _tempItem;
        private Data.Bean.ProductBean _productBean;
        private Data.Bean.ProductBean _productBeanPack;
        private int _coinNum;
        
        // Methods
        public void OnClickCollectButton()
        {
            if(this._coinNum >= 1)
            {
                    UnityEngine.Vector3 val_2 = this.TransformFlyStart.position;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  0, from:  "iap", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  5);
            }
        
        }
        public override void OnTransmitParams(object[] pars)
        {
            var val_22;
            var val_23;
            var val_24;
            UnityEngine.Sprite val_25;
            val_22 = this;
            val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            this.OnTransmitParams(pars:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            string val_1 = Common.GlobalMethods.GetBaseVale<System.String>(inputs:  pars, idx:  0, defaultVal:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "item_purchase", label:  val_1, value:  0);
            Data.Bean.ProductBean val_3 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetProductInfoForProductId(productId:  val_1);
            this._productBean = val_3;
            this._coinNum = 0;
            if(val_3 == null)
            {
                    return;
            }
            
            this.ClearRewardContent();
            if(this._productBean < 1)
            {
                goto label_12;
            }
            
            val_24 = 0;
            label_37:
            if(val_24 >= this._productBean)
            {
                goto label_12;
            }
            
            if(this._productBean <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Data.Bean.ProductBean.__il2cppRuntimeField_byval_arg + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_NO_ADS)) != true)
            {
                    if(this._productBean <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((Data.Bean.ProductBean.__il2cppRuntimeField_byval_arg + 16.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_COIN)) != false)
            {
                    if(this._productBean <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this._coinNum = Data.Bean.ProductBean.__il2cppRuntimeField_byval_arg + 24;
            }
            
                View.Dialog.PurchaseSuccess.PurchaseRewardItem val_6 = View.Dialog.PurchaseSuccess.PurchaseRewardItem.Create(parent:  this.RewardContent, prefab:  this.RewardItemPrefab);
                this._tempItem = val_6;
                this._items.Add(item:  val_6);
                if(this._productBean <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this._tempItem.SetRewardItemInfo(data:  Data.Bean.ProductBean.__il2cppRuntimeField_byval_arg);
            }
            
            val_24 = val_24 + 1;
            if(this._productBean.rewards != null)
            {
                goto label_37;
            }
            
            throw new NullReferenceException();
            label_12:
            this.RewardContent.gameObject.SetActive(value:  (this._items > 0) ? 1 : 0);
            this.ImageIcon.gameObject.SetActive(value:  true);
            this.ImageIcon.transform.localScale = new UnityEngine.Vector3() {x = this.BigScale};
            if((this._productBean.name.Equals(value:  "60")) != false)
            {
                    val_25 = this.SpriteIcons[0];
            }
            else
            {
                    if((this._productBean.name.Equals(value:  "64")) != false)
            {
                    val_25 = this.SpriteIcons[1];
            }
            else
            {
                    if((this._productBean.name.Equals(value:  "63")) != false)
            {
                    val_25 = this.SpriteIcons[2];
            }
            else
            {
                    if((this._productBean.name.Equals(value:  "65")) != true)
            {
                    if((this._productBean.name.Equals(value:  "46")) == false)
            {
                goto label_71;
            }
            
            }
            
                val_25 = this.SpriteIcons[3];
            }
            
            }
            
            }
            
            label_111:
            this.ImageIcon.sprite = val_25;
            val_22 = ???;
            goto typeof(UnityEngine.UI.Image).__il2cppRuntimeField_3F0;
            label_71:
            if((val_22 + 176 + 48.Equals(value:  "48")) == false)
            {
                goto label_78;
            }
            
            goto label_111;
            label_78:
            if((val_22 + 176 + 48.Equals(value:  "53")) == false)
            {
                goto label_85;
            }
            
            goto label_111;
            label_85:
            if((val_22 + 176 + 48.Equals(value:  "54")) == false)
            {
                goto label_92;
            }
            
            goto label_111;
            label_92:
            if((val_22 + 176 + 48.Equals(value:  "49")) == false)
            {
                goto label_99;
            }
            
            goto label_111;
            label_99:
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
            val_22 + 112.transform.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            goto label_111;
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "203");
            this.ClaimText.text = Locale.LocaleManager.Translate(key:  "44");
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
            
            View.Dialog.PurchaseSuccess.PurchaseRewardItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.PurchaseSuccess.PurchaseRewardItem>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
            val_2 = val_2 + 1;
            this._items.Clear();
        }
        public PurchaseSuccessDialog()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  1.1f);
            this.BigScale = val_2;
            mem[1152921512722290828] = val_2.y;
            mem[1152921512722290832] = val_2.z;
            this._items = new System.Collections.Generic.List<View.Dialog.PurchaseSuccess.PurchaseRewardItem>();
        }
    
    }

}
