using UnityEngine;

namespace Platform.Iap
{
    public class IAP : IStoreListener
    {
        // Fields
        private static UnityEngine.Purchasing.IStoreController m_StoreController;
        private static UnityEngine.Purchasing.IExtensionProvider m_StoreExtensionProvider;
        private bool m_PurchaseInProgress;
        public System.Action<UnityEngine.Purchasing.Product> onPurchaseSuccess;
        public System.Action<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason> onPurchaseFailed;
        private static readonly string[] IsoCurrencyCode;
        
        // Methods
        public void Init()
        {
            this.InitUnityPurchase();
        }
        private bool IsInitialized()
        {
            var val_2;
            var val_4;
            val_2 = null;
            val_2 = null;
            if(Platform.Iap.IAP.m_StoreController != null)
            {
                    var val_1 = (Platform.Iap.IAP.m_StoreExtensionProvider != 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private void InitUnityPurchase()
        {
            System.String[] val_21;
            var val_22;
            System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> val_23;
            var val_27;
            var val_28;
            var val_29;
            if(this.IsInitialized() != false)
            {
                    return;
            }
            
            val_22 = mem[public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302];
            val_22 = public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302;
            val_22 = mem[public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302];
            val_22 = public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 302;
            val_23 = mem[public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30];
            val_23 = public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30;
            UnityEngine.Purchasing.ConfigurationBuilder val_3 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  UnityEngine.Purchasing.StandardPurchasingModule.Instance(), rest:  public static T[] System.Array::Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>().__il2cppRuntimeField_30 + 184);
            if(UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog() == null)
            {
                    throw new NullReferenceException();
            }
            
            val_23 = val_4.products;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_23 = val_23.GetEnumerator();
            label_67:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_23.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            T val_10 = val_23.Current;
            val_27 = val_10;
            if(val_10 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_10 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_32 = val_10 + 32;
            if((val_10 + 32 + 294) == 0)
            {
                goto label_31;
            }
            
            var val_30 = val_10 + 32 + 176;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_30:
            if(((val_10 + 32 + 176 + 8) + -8) == null)
            {
                goto label_29;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (val_10 + 32 + 294))
            {
                goto label_30;
            }
            
            goto label_31;
            label_29:
            val_32 = val_32 + (((val_10 + 32 + 176 + 8)) << 4);
            val_28 = val_32 + 304;
            label_31:
            if((val_10 + 32.Count) >= 1)
            {
                goto label_32;
            }
            
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Purchasing.ConfigurationBuilder val_12 = val_3.AddProduct(id:  val_10 + 16, type:  val_10 + 24);
            goto label_67;
            label_32:
            if((val_10 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_35 = val_10 + 32;
            if((val_10 + 32 + 294) == 0)
            {
                goto label_39;
            }
            
            var val_33 = val_10 + 32 + 176;
            var val_34 = 0;
            val_33 = val_33 + 8;
            label_38:
            if(((val_10 + 32 + 176 + 8) + -8) == null)
            {
                goto label_37;
            }
            
            val_34 = val_34 + 1;
            val_33 = val_33 + 16;
            if(val_34 < (val_10 + 32 + 294))
            {
                goto label_38;
            }
            
            goto label_39;
            label_37:
            val_35 = val_35 + (((val_10 + 32 + 176 + 8)) << 4);
            val_29 = val_35 + 304;
            label_39:
            System.Collections.Generic.IEnumerator<T> val_14 = val_10 + 32.GetEnumerator();
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            label_56:
            var val_36 = 0;
            val_36 = val_36 + 1;
            if(val_14.MoveNext() == false)
            {
                goto label_45;
            }
            
            var val_37 = 0;
            val_37 = val_37 + 1;
            if(val_14.Current == 0)
            {
                    throw new NullReferenceException();
            }
            
            string[] val_19 = new string[1];
            val_21 = val_19;
            if(val_19 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_21[0] = val_18 + 16;
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(id:  val_18 + 24, stores:  val_19);
            goto label_56;
            label_45:
            var val_38 = 0;
            val_21 = 0;
            val_38 = val_38 + 1;
            mem2[0] = 149;
            if(val_14 != null)
            {
                    var val_39 = 0;
                val_39 = val_39 + 1;
                val_14.Dispose();
            }
            
            if(val_21 != 0)
            {
                goto label_73;
            }
            
            var val_40 = val_38;
            if(val_40 == 1)
            {
                goto label_63;
            }
            
            val_21 = -97499616;
            var val_21 = ((val_21 + ((0 + 1)) << 2) == 149) ? 1 : 0;
            val_21 = ((val_40 >= 0) ? 1 : 0) & val_21;
            val_40 = val_40 - val_21;
            if(val_3 != null)
            {
                goto label_64;
            }
            
            throw new NullReferenceException();
            label_63:
            val_21 = -97499616;
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            label_64:
            UnityEngine.Purchasing.ConfigurationBuilder val_23 = val_3.AddProduct(id:  val_10 + 16, type:  val_10 + 24, storeIDs:  new UnityEngine.Purchasing.IDs());
            goto label_67;
            label_21:
            val_27 = 0;
            var val_24 = 0 + 1;
            mem2[0] = 213;
            if(val_23 != null)
            {
                    var val_41 = 0;
                val_41 = val_41 + 1;
                val_23.Dispose();
            }
            
            if(val_27 != 0)
            {
                    throw val_27;
            }
            
            UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  this, builder:  val_3);
            Platform.Iap.IAPShopListener val_26 = Common.Singleton<Platform.Iap.IAPShopListener>.Instance;
            if(val_26 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_26.Init();
            return;
            label_73:
            throw null;
        }
        public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
        {
            var val_1;
            UnityEngine.Debug.Log(message:  "IAP OnInitialized Success");
            val_1 = null;
            val_1 = null;
            Platform.Iap.IAP.m_StoreController = controller;
            Platform.Iap.IAP.m_StoreExtensionProvider = extensions;
        }
        public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
        {
            object val_1;
            if(error == 0)
            {
                goto label_1;
            }
            
            if(error == 1)
            {
                goto label_2;
            }
            
            if(error != 2)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "IAP init fail, Is your App correctly uploaded on the relevant publisher console?");
            return;
            label_1:
            val_1 = "IAP init fail, Billing disabled! Ask the user if billing is disabled in device settings.";
            goto label_8;
            label_2:
            val_1 = "IAP init fail, No products available for purchase! Developer configuration error; check product metadata!";
            label_8:
            UnityEngine.Debug.Log(message:  val_1);
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs args)
        {
            this.m_PurchaseInProgress = false;
            UnityEngine.Debug.Log(message:  "IAP Purchase OK: "("IAP Purchase OK: ") + args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField(args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField));
            if(this.onPurchaseSuccess == null)
            {
                    return 0;
            }
            
            this.onPurchaseSuccess.Invoke(obj:  args.<purchasedProduct>k__BackingField);
            return 0;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
        {
            this.m_PurchaseInProgress = false;
            if(this.onPurchaseFailed != null)
            {
                    this.onPurchaseFailed.Invoke(arg1:  product, arg2:  failureReason);
            }
            
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "IAP OnPurchaseFailed: FAIL. Product: \'{0}\', PurchaseFailureReason: {1}", arg0:  product.<definition>k__BackingField.<storeSpecificId>k__BackingField, arg1:  failureReason));
        }
        public bool BuyProductByID(string productId)
        {
            var val_8;
            Logic.Define.DialogType val_10;
            var val_11;
            if(this.IsInitialized() != false)
            {
                    if(this.m_PurchaseInProgress == true)
            {
                    return false;
            }
            
                val_8 = null;
                val_8 = null;
                var val_9 = 0;
                val_9 = val_9 + 1;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  "IAP Purchasing fail. Not initialized.");
                return false;
            }
            
            UnityEngine.Purchasing.ProductCollection val_3 = Platform.Iap.IAP.m_StoreController.products;
            UnityEngine.Debug.Log(message:  "IAP productCollection:"("IAP productCollection:") + val_3);
            if(val_3 == null)
            {
                    return false;
            }
            
            UnityEngine.Purchasing.Product val_5 = val_3.WithID(id:  productId);
            if(val_5 == null)
            {
                    return false;
            }
            
            if((val_5.<availableToPurchase>k__BackingField) == false)
            {
                    return false;
            }
            
            val_10 = 0;
            View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.Open(name:  "LoadingDialog", type:  val_10);
            View.Dialog.ShopTest.Controller.ShopController val_7 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
            val_7.<IsClickBuyProduct>k__BackingField = true;
            val_11 = null;
            val_11 = null;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 1;
            Platform.Iap.IAP.m_StoreController.InitiatePurchase(product:  val_5);
            this.m_PurchaseInProgress = true;
            return false;
        }
        public void RestorePurchases()
        {
            if(this.IsInitialized() != false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "IAP Purchasing fail. Not initialized.");
        }
        public string GetLocalizedPriceString(string productId)
        {
            string val_4;
            var val_5;
            UnityEngine.Purchasing.IStoreController val_6;
            var val_8;
            System.String[] val_9;
            string val_10;
            val_4 = productId;
            val_5 = null;
            val_5 = null;
            val_6 = Platform.Iap.IAP.m_StoreController;
            if(val_6 == null)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_6 = Platform.Iap.IAP.m_StoreController;
            var val_5 = 0;
            val_5 = val_5 + 1;
            UnityEngine.Purchasing.Product val_3 = val_6.products.WithID(id:  val_4);
            var val_6 = 0;
            do
            {
                val_8 = null;
                val_8 = null;
                val_9 = Platform.Iap.IAP.IsoCurrencyCode;
                if(val_6 >= Platform.Iap.IAP.IsoCurrencyCode.Length)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
                val_4 = val_3.<metadata>k__BackingField.<isoCurrencyCode>k__BackingField;
                val_9 = Platform.Iap.IAP.IsoCurrencyCode;
                val_6 = val_6 + 1;
            }
            while((System.String.op_Equality(a:  val_4, b:  Platform.Iap.IAP.IsoCurrencyCode + 32)) == false);
            
            val_10 = val_3.<metadata>k__BackingField.<localizedPriceString>k__BackingField;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public IAP()
        {
        
        }
        private static IAP()
        {
            int val_2;
            string[] val_1 = new string[2];
            val_2 = val_1.Length;
            val_1[0] = "EUR";
            val_2 = val_1.Length;
            val_1[1] = "BRL";
            Platform.Iap.IAP.IsoCurrencyCode = val_1;
        }
    
    }

}
