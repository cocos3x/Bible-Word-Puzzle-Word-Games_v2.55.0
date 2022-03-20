using UnityEngine;

namespace Platform.Iap
{
    public struct IapFromInfo : IEquatable<Platform.Iap.IapFromInfo>
    {
        // Fields
        public string productId;
        public string from;
        public System.Func<string, UnityEngine.Vector3> flyStart;
        public System.Action<UnityEngine.Purchasing.Product, Platform.Iap.ShopProduct> onPurchaseSuccess;
        public System.Action<UnityEngine.Purchasing.Product, Platform.Iap.ShopProduct, UnityEngine.Purchasing.PurchaseFailureReason> onPurchaseFailed;
        public System.Action onCoinFlyFinish;
        
        // Methods
        public bool Equals(Platform.Iap.IapFromInfo other)
        {
            if(new Platform.Iap.IapFromInfo() != 0)
            {
                    return 1152921504826867712.Equals(value:  other.productId);
            }
            
            throw new NullReferenceException();
        }
        public override string ToString()
        {
            return System.String.Format(format:  "[IapFrom] {0}, {1}", arg0:  new Platform.Iap.IapFromInfo(), arg1:  this.from);
        }
    
    }

}
