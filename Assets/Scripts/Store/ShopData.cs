using UnityEngine;

namespace Store
{
    public class ShopData : IStoreData
    {
        // Fields
        public bool IsBuyItem;
        public bool IsBuyAnyItem;
        public string FirstBuyTime;
        public System.Collections.Generic.Dictionary<string, int> PackageShowTime;
        public System.Collections.Generic.Dictionary<string, string> PackageOverdue;
        
        // Methods
        public void Reset()
        {
            this.IsBuyItem = false;
            this.IsBuyAnyItem = false;
            this.FirstBuyTime = System.String.alignConst;
            this.PackageShowTime.Clear();
            this.PackageOverdue.Clear();
        }
        public ShopData()
        {
            this.PackageShowTime = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.PackageOverdue = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
