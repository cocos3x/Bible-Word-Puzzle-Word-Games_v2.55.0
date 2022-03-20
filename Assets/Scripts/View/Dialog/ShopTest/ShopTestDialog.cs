using UnityEngine;

namespace View.Dialog.ShopTest
{
    public class ShopTestDialog : Dialog
    {
        // Fields
        private const float TimeIntervalShow = 0.05;
        private const float TimeIntervalHide = 0.03;
        public UnityEngine.Animator AnimatorTop;
        public UnityEngine.Transform TransformContents;
        public View.Dialog.ShopTest.ShopLimitTimePackage LimitTimePackagePrefab;
        public View.Dialog.ShopTest.ShopFixedPackage FixedPackagePrefab;
        public View.Dialog.ShopTest.ShopItem ItemPrefab;
        public View.Dialog.ShopTest.ShopMoreOffers MoreOffersPrefab;
        public View.Dialog.ShopTest.ShopRestore RestorePrefab;
        public UnityEngine.UI.Text TitleText;
        private Data.Bean.ProductsBean _productsBean;
        private System.Collections.Generic.List<View.Dialog.ShopTest.ShopLimitTimePackage> _limitTimePackages;
        private System.Collections.Generic.List<View.Dialog.ShopTest.ShopFixedPackage> _fixedPackages;
        private System.Collections.Generic.List<View.Dialog.ShopTest.ShopItem> _items;
        private View.Dialog.ShopTest.ShopMoreOffers _moreOffers;
        private View.Dialog.ShopTest.ShopRestore _restore;
        private View.Dialog.ShopTest.ShopLimitTimePackage _tempLimitTimePackage;
        private View.Dialog.ShopTest.ShopFixedPackage _tempFixedPackage;
        private View.Dialog.ShopTest.ShopItem _tempItem;
        private bool _isBuyAnyThing;
        private bool _isCloseAniing;
        private string _buyProductId;
        
        // Methods
        public void OnClickCloseButton()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameCloseBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceShopScr});
            this.PlayCloseAni();
        }
        public override void Cancel()
        {
            string val_7;
            var val_8;
            var val_9;
            val_7 = this;
            this.Cancel();
            if((System.String.IsNullOrEmpty(value:  this._buyProductId)) == false)
            {
                goto label_1;
            }
            
            if((Common.SingletonController<Logic.Game.GameControllers>.Instance.IsRewardAdStarted()) == false)
            {
                goto label_4;
            }
            
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "game_ad_reward", action:  "ad_enter_show", lable:  "shop_close");
            ShowFreeHint();
            goto label_4;
            label_1:
            object[] val_4 = new object[1];
            val_7 = this._buyProductId;
            val_4[0] = val_7;
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "PurchaseSuccessDialog", pars:  val_4);
            label_4:
            View.Controller.MainController val_6 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_6._bibleGameState == 2)
            {
                    val_8 = null;
                val_8 = null;
                val_9 = null;
                val_7 = ScrShow.ScrNameEnum.ScrNameHomeScr;
                val_9 = null;
                Platform.Analytics.EzAnalytics.SendScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = val_7}, source:  new SourceEnum() {<Value>k__BackingField = ScrShow.SourceEnum.SourceShopScr});
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a2_button_close", label:  "", value:  0);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "45");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        protected override void OnEnable()
        {
            var val_11;
            var val_13;
            var val_14;
            this.OnEnable();
            Message.Messager.Add(cmd:  104, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::ShowMoreOffers()));
            Message.Messager.Add<UnityEngine.Purchasing.Product>(cmd:  105, action:  new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::PurchaseSuccess(UnityEngine.Purchasing.Product product)));
            Message.Messager.Add<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(cmd:  106, action:  new System.Action<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)));
            View.Dialog.ShopTest.Controller.ShopController val_4 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_4.<IsShowShopping>k__BackingField = true;
            View.Controller.MainController val_5 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_5._bibleGameState == 2)
            {
                    val_11 = "home";
            }
            else
            {
                    View.Controller.MainController val_6 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_6._bibleGameState == 3)
            {
                    val_11 = "game";
            }
            else
            {
                    View.Controller.MainController val_7 = Common.SingletonController<View.Controller.MainController>.Instance;
            }
            
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameShopDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingClick});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a1_dialog_shop_show", label:  (val_7._bibleGameState == 4) ? "daily_prayer" : "", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a1_dialog_shop_level", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            this.UpdateShopInfo(isMore:  false);
            this._isCloseAniing = false;
            this._buyProductId = System.String.alignConst;
            Message.Messager.Dispatch(cmd:  75);
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  false);
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  104, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::ShowMoreOffers()));
            Message.Messager.Remove<UnityEngine.Purchasing.Product>(cmd:  105, action:  new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::PurchaseSuccess(UnityEngine.Purchasing.Product product)));
            Message.Messager.Remove<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(cmd:  106, action:  new System.Action<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)));
            View.Dialog.ShopTest.Controller.ShopController val_4 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_4.<IsShowShopping>k__BackingField = false;
            Message.Messager.Dispatch(cmd:  74);
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  true);
        }
        private void PurchaseSuccess(UnityEngine.Purchasing.Product product)
        {
            if((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetProductInfoForProductId(productId:  product.<definition>k__BackingField.<id>k__BackingField)) == null)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a3_buy_result", label:  "1_" + val_2.name, value:  0);
            if((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackForName(name:  val_2.name)) != null)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "sale_popup", action:  "purchase", label:  val_5.productId + "_store", value:  0);
            }
            
            this._isBuyAnyThing = true;
            this._buyProductId = product.<definition>k__BackingField.<id>k__BackingField;
            this.PlayCloseAni();
        }
        private void PurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
        {
            if((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetProductInfoForProductId(productId:  product.<definition>k__BackingField.<id>k__BackingField)) == null)
            {
                    return;
            }
            
            product = failureReason;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "a3_buy_result", label:  "0_" + failureReason.ToString(), value:  0);
        }
        private void UpdateShopInfo(bool isMore)
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this.ClearShopContent();
            this._productsBean = Logic.Game.GameManager.gameConfig._productsBean;
            if(null != 0)
            {
                    this.CreateProducts(isMore:  isMore);
            }
        
        }
        private void CreateProducts(bool isMore)
        {
            System.Collections.Generic.List<Data.Bean.ProductBean> val_26;
            bool val_27;
            object val_28;
            var val_29;
            val_27 = isMore;
            object val_1 = new System.Object();
            typeof(ShopTestDialog.<>c__DisplayClass30_0).__il2cppRuntimeField_10 = this;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            typeof(ShopTestDialog.<>c__DisplayClass30_0).__il2cppRuntimeField_18 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.SortShortestTimePack(packs:  this._productsBean.limitedTimePackage);
            if(this._productsBean < 1)
            {
                goto label_7;
            }
            
            val_26 = 1152921504801787904;
            var val_25 = 0;
            label_11:
            object val_6 = null;
            val_28 = val_6;
            val_6 = new System.Object();
            typeof(ShopTestDialog.<>c__DisplayClass30_1).__il2cppRuntimeField_18 = val_1;
            typeof(ShopTestDialog.<>c__DisplayClass30_1).__il2cppRuntimeField_10 = val_25;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_28, method:  System.Void ShopTestDialog.<>c__DisplayClass30_1::<CreateProducts>b__1()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.05f);
            if(val_27 == false)
            {
                goto label_9;
            }
            
            val_25 = val_25 + 1;
            if(val_25 < (val_5 + 24))
            {
                goto label_11;
            }
            
            label_9:
            val_29 = 1;
            goto label_12;
            label_7:
            val_29 = 0;
            label_12:
            typeof(ShopTestDialog.<>c__DisplayClass30_0).__il2cppRuntimeField_20 = this._productsBean.fixedPackage;
            if(this._productsBean.fixedPackage < 1)
            {
                goto label_17;
            }
            
            val_27 = val_27 ^ 1;
            val_26 = 1152921512667094832;
            var val_26 = 0;
            label_19:
            object val_10 = null;
            val_28 = val_10;
            val_10 = new System.Object();
            typeof(ShopTestDialog.<>c__DisplayClass30_2).__il2cppRuntimeField_18 = val_1;
            typeof(ShopTestDialog.<>c__DisplayClass30_2).__il2cppRuntimeField_10 = val_26;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_28, method:  System.Void ShopTestDialog.<>c__DisplayClass30_2::<CreateProducts>b__2()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.05f);
            var val_14 = (val_26 != 0) ? 1 : 0;
            val_14 = val_14 | val_29;
            val_14 = val_14 & val_27;
            if(val_14 == true)
            {
                goto label_17;
            }
            
            val_26 = val_26 + 1;
            if(val_26 < (this._productsBean.fixedPackage + 24))
            {
                goto label_19;
            }
            
            label_17:
            typeof(ShopTestDialog.<>c__DisplayClass30_0).__il2cppRuntimeField_28 = this._productsBean.products;
            if(this._productsBean.products < 1)
            {
                goto label_32;
            }
            
            val_29 = val_27 ^ 1;
            val_27 = 1152921512620728192;
            var val_28 = 0;
            label_34:
            typeof(ShopTestDialog.<>c__DisplayClass30_3).__il2cppRuntimeField_18 = val_1;
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == false)
            {
                goto label_25;
            }
            
            val_26 = typeof(ShopTestDialog.<>c__DisplayClass30_0).__il2cppRuntimeField_28;
            if(val_28 >= (this._productsBean.products + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = this._productsBean.products + 16;
            val_27 = val_27 + 0;
            if(((this._productsBean.products + 16 + 0) + 32 + 16.Equals(value:  "products_no_ads_2.99")) == true)
            {
                goto label_31;
            }
            
            label_25:
            typeof(ShopTestDialog.<>c__DisplayClass30_3).__il2cppRuntimeField_10 = val_28;
            DG.Tweening.TweenCallback val_19 = null;
            val_28 = val_19;
            val_19 = new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ShopTestDialog.<>c__DisplayClass30_3::<CreateProducts>b__3());
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_28);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.05f);
            var val_22 = (val_28 > 1) ? 1 : 0;
            val_22 = val_22 & val_29;
            if(val_22 == true)
            {
                goto label_32;
            }
            
            label_31:
            val_28 = val_28 + 1;
            if(val_28 < (this._productsBean.products + 24))
            {
                goto label_34;
            }
            
            label_32:
            if(val_27 != false)
            {
                    return;
            }
            
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ShopTestDialog.<>c__DisplayClass30_0::<CreateProducts>b__0()));
        }
        private void ShowMoreOffers()
        {
            this.UpdateShopInfo(isMore:  true);
        }
        private void ShowFreeHint()
        {
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "FreeHintsTest2Dialog", type:  0);
            mem2[0] = 0;
        }
        private void PlayCloseAni()
        {
            var val_31;
            System.Collections.Generic.List<View.Dialog.ShopTest.ShopLimitTimePackage> val_32;
            if(this._isCloseAniing != false)
            {
                    return;
            }
            
            this._isCloseAniing = true;
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            if(this._restore != 0)
            {
                    DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::<PlayCloseAni>b__33_0()));
                DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.03f);
            }
            
            if(this._moreOffers != 0)
            {
                    DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::<PlayCloseAni>b__33_1()));
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.03f);
            }
            
            System.Collections.Generic.List<View.Dialog.ShopTest.ShopItem> val_11 = this._items - 1;
            if()
            {
                    val_31 = 1152921504732246016;
                do
            {
                typeof(ShopTestDialog.<>c__DisplayClass33_0).__il2cppRuntimeField_18 = this;
                typeof(ShopTestDialog.<>c__DisplayClass33_0).__il2cppRuntimeField_10 = val_11;
                DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ShopTestDialog.<>c__DisplayClass33_0::<PlayCloseAni>b__3()));
                DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.03f);
                val_11 = val_11 - 1;
            }
            while(>=0);
            
            }
            
            System.Collections.Generic.List<View.Dialog.ShopTest.ShopFixedPackage> val_16 = this._fixedPackages - 1;
            if()
            {
                    val_31 = 1152921504732246016;
                do
            {
                typeof(ShopTestDialog.<>c__DisplayClass33_1).__il2cppRuntimeField_18 = this;
                typeof(ShopTestDialog.<>c__DisplayClass33_1).__il2cppRuntimeField_10 = val_16;
                DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ShopTestDialog.<>c__DisplayClass33_1::<PlayCloseAni>b__4()));
                DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.03f);
                val_16 = val_16 - 1;
            }
            while(>=0);
            
            }
            
            val_32 = this._limitTimePackages - 1;
            if()
            {
                    val_31 = 1152921504732246016;
                do
            {
                typeof(ShopTestDialog.<>c__DisplayClass33_2).__il2cppRuntimeField_18 = this;
                typeof(ShopTestDialog.<>c__DisplayClass33_2).__il2cppRuntimeField_10 = val_32;
                DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ShopTestDialog.<>c__DisplayClass33_2::<PlayCloseAni>b__5()));
                DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.03f);
                val_32 = val_32 - 1;
            }
            while(>=0);
            
            }
            
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ShopTest.ShopTestDialog::<PlayCloseAni>b__33_2()));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.4f);
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(View.Dialog.ShopTest.ShopTestDialog).__il2cppRuntimeField_1E8));
        }
        private void ClearShopContent()
        {
            var val_4;
            var val_5;
            if(this._limitTimePackages >= 1)
            {
                    val_4 = 1152921512667814416;
                if(0 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                View.Dialog.ShopTest.ShopLimitTimePackage val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.ShopTest.ShopLimitTimePackage>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
                val_5 = 0 + 1;
                this._limitTimePackages.Clear();
            }
            
            if(this._fixedPackages >= 1)
            {
                    val_4 = 1152921512667832848;
                if(0 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                View.Dialog.ShopTest.ShopFixedPackage val_2 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.ShopTest.ShopFixedPackage>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
                val_5 = 0 + 1;
                this._fixedPackages.Clear();
            }
            
            if(this._items >= 1)
            {
                    val_4 = 1152921512667851280;
                if(0 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                View.Dialog.ShopTest.ShopItem val_3 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.ShopTest.ShopItem>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
                val_5 = 0 + 1;
                this._items.Clear();
            }
            
            this.ClearMoreOffers();
            this.ClearRestore();
        }
        private void ClearMoreOffers()
        {
            if(this._moreOffers == 0)
            {
                    return;
            }
            
            View.Dialog.ShopTest.ShopMoreOffers val_2 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.ShopTest.ShopMoreOffers>(obj:  this._moreOffers, isUi:  true);
            this._moreOffers = 0;
        }
        private void ClearRestore()
        {
            if(this._restore == 0)
            {
                    return;
            }
            
            View.Dialog.ShopTest.ShopRestore val_2 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.ShopTest.ShopRestore>(obj:  this._restore, isUi:  true);
            this._restore = 0;
        }
        public ShopTestDialog()
        {
            this._limitTimePackages = new System.Collections.Generic.List<View.Dialog.ShopTest.ShopLimitTimePackage>();
            this._fixedPackages = new System.Collections.Generic.List<View.Dialog.ShopTest.ShopFixedPackage>();
            this._items = new System.Collections.Generic.List<View.Dialog.ShopTest.ShopItem>();
        }
        private void <PlayCloseAni>b__33_0()
        {
            if(this._restore != null)
            {
                    this._restore.HideItem();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <PlayCloseAni>b__33_1()
        {
            if(this._moreOffers != null)
            {
                    this._moreOffers.HideItem();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <PlayCloseAni>b__33_2()
        {
            this.AnimatorTop.Play(stateName:  "FitPanelTopHide");
        }
    
    }

}
