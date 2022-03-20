using UnityEngine;

namespace View.Dialog.ShopActivity
{
    public class ShopActivityDialog : Dialog
    {
        // Fields
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
        public void OnClickBuyButton()
        {
            var val_7;
            if((System.String.IsNullOrEmpty(value:  this._productId)) != false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "sale_popup", action:  "click", label:  this._productId + "_popup", value:  0);
            val_7 = null;
            val_7 = null;
            Platform.Analytics.EzAnalytics.SendIapItemClick(name:  this._productId, source:  new SourceEnum() {<Value>k__BackingField = IapItemClick.SourceEnum.SourceSaleDlg});
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
        public void OnClickCloseButton()
        {
            goto typeof(View.Dialog.ShopActivity.ShopActivityDialog).__il2cppRuntimeField_1E0;
        }
        public override void Cancel()
        {
            this.Cancel();
            Message.Messager.Dispatch(cmd:  79);
        }
        public override void OnTransmitParams(object[] pars)
        {
            var val_10;
            var val_11;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            this.OnTransmitParams(pars:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            string val_1 = Common.GlobalMethods.GetBaseVale<System.String>(inputs:  pars, idx:  0, defaultVal:  0);
            Data.Bean.ProductBean val_3 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackForName(name:  val_1);
            this._productBean = val_3;
            if(val_3 == null)
            {
                    return;
            }
            
            val_11 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            System.DateTime val_5 = System.DateTime.Now;
            System.DateTime val_6 = val_5.dateData.AddHours(value:  (double)this._productBean.continiesTime);
            val_6.dateData.SetOverdueSecondForName(name:  val_1, overdueTime:  new System.DateTime() {dateData = val_6.dateData});
            Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.AddPackageShowTimeForName(name:  val_1);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "sale_popup", action:  "show", label:  this._productBean.productId, value:  0);
            this.SetPackageInfo(data:  this._productBean, seconds:  Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetOverdueSecondForName(name:  this._productBean.name));
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add<UnityEngine.Purchasing.Product>(cmd:  105, action:  new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  System.Void View.Dialog.ShopActivity.ShopActivityDialog::PurchaseSuccess(UnityEngine.Purchasing.Product product)));
            Message.Messager.Add<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(cmd:  106, action:  new System.Action<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(object:  this, method:  System.Void View.Dialog.ShopActivity.ShopActivityDialog::PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<UnityEngine.Purchasing.Product>(cmd:  105, action:  new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  System.Void View.Dialog.ShopActivity.ShopActivityDialog::PurchaseSuccess(UnityEngine.Purchasing.Product product)));
            Message.Messager.Remove<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(cmd:  106, action:  new System.Action<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(object:  this, method:  System.Void View.Dialog.ShopActivity.ShopActivityDialog::PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)));
        }
        private void PurchaseSuccess(UnityEngine.Purchasing.Product product)
        {
            if((System.String.op_Equality(a:  product.<definition>k__BackingField.<id>k__BackingField, b:  this._productId)) == false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "sale_popup", action:  "purchase", label:  product.<definition>k__BackingField.<id>k__BackingField(product.<definition>k__BackingField.<id>k__BackingField) + "_popup", value:  0);
            this = ???;
            goto typeof(View.Dialog.ShopActivity.ShopActivityDialog).__il2cppRuntimeField_1E0;
        }
        private void PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
        {
            if((System.String.op_Equality(a:  product.<definition>k__BackingField.<id>k__BackingField, b:  this._productId)) == false)
            {
                    return;
            }
            
            goto typeof(View.Dialog.ShopActivity.ShopActivityDialog).__il2cppRuntimeField_1E0;
        }
        private void SetPackageInfo(Data.Bean.ProductBean data, long seconds)
        {
            UnityEngine.UI.Image val_14;
            UnityEngine.Sprite val_15;
            string val_16;
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
            Platform.Analytics.EzAnalytics.SendIapDlgShow(name:  this._productId);
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
        public ShopActivityDialog()
        {
            this._items = new System.Collections.Generic.List<View.CommonItem.ShopRewardItem>();
        }
    
    }

}
