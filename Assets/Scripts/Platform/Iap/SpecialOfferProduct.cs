using UnityEngine;

namespace Platform.Iap
{
    [Serializable]
    public abstract class SpecialOfferProduct : ShopProduct
    {
        // Fields
        protected Platform.Iap.SpecialOfferProduct.Type type;
        private float <priceOff>k__BackingField;
        protected string SPECIALOFF_SHOWTIME;
        protected System.DateTime _showTime;
        protected string SPECIALOFF_ISBUY;
        protected bool _isBuy;
        private static System.DateTime _showTimeTypeA;
        public static readonly System.Collections.Generic.List<Platform.Iap.SpecialOfferProduct> productList;
        
        // Properties
        public float priceOff { get; }
        private System.DateTime showTime { set; }
        private bool isBuy { set; }
        private static System.DateTime showTimeTypeA { set; }
        
        // Methods
        public float get_priceOff()
        {
            return (float)this.<priceOff>k__BackingField;
        }
        private void set_showTime(System.DateTime value)
        {
            this._showTime = value;
            UnityEngine.PlayerPrefs.SetString(key:  this.SPECIALOFF_SHOWTIME, value:  Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0));
        }
        private void set_isBuy(bool value)
        {
            bool val_1 = value;
            this._isBuy = val_1;
            UnityEngine.PlayerPrefs.SetInt(key:  this.SPECIALOFF_ISBUY, value:  val_1);
        }
        public void Reset()
        {
            null = null;
            this.showTime = new System.DateTime() {dateData = Common.EzDate.defaultDateTime};
            this._isBuy = false;
            UnityEngine.PlayerPrefs.SetInt(key:  this.SPECIALOFF_ISBUY, value:  0);
        }
        private static void set_showTimeTypeA(System.DateTime value)
        {
            null = null;
            Platform.Iap.SpecialOfferProduct._showTimeTypeA = value.dateData;
            UnityEngine.PlayerPrefs.SetString(key:  "SPECTIALOFF_SHOWTIME_TYPEA", value:  Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0));
        }
        private static SpecialOfferProduct()
        {
            System.DateTime val_2 = Common.EzDate.GetDateTime(dateString:  UnityEngine.PlayerPrefs.GetString(key:  "SPECTIALOFF_SHOWTIME_TYPEA"), format:  0);
            Platform.Iap.SpecialOfferProduct._showTimeTypeA = val_2.dateData;
            Platform.Iap.SpecialOfferProduct.productList = new System.Collections.Generic.List<Platform.Iap.SpecialOfferProduct>();
            Sort(comparison:  new System.Comparison<Platform.Iap.SpecialOfferProduct>(object:  0, method:  public static System.Int32 Platform.Iap.SpecialOfferProduct::PriceShowCompare(Platform.Iap.SpecialOfferProduct item1, Platform.Iap.SpecialOfferProduct item2)));
        }
        public static void ClearShowTimeTypeA()
        {
            null = null;
            Platform.Iap.SpecialOfferProduct.showTimeTypeA = new System.DateTime() {dateData = Common.EzDate.defaultDateTime};
        }
        public static void ResetProducts()
        {
            null = null;
            List.Enumerator<T> val_1 = Platform.Iap.SpecialOfferProduct.productList.GetEnumerator();
            label_6:
            if(0.MoveNext() == false)
            {
                goto label_4;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            this.Reset();
            goto label_6;
            label_4:
            0.Dispose();
        }
        public static int PriceShowCompare(Platform.Iap.SpecialOfferProduct item1, Platform.Iap.SpecialOfferProduct item2)
        {
            var val_4;
            var val_5;
            var val_6;
            val_5 = item1;
            if(val_5 == null)
            {
                goto label_1;
            }
            
            if(item2 == null)
            {
                goto label_2;
            }
            
            val_4 = item2;
            mem2[0] = item1.type;
            if((item1.type.Equals(obj:  item2.type)) == false)
            {
                goto label_4;
            }
            
            val_6 = item2.<priceOff>k__BackingField.CompareTo(value:  item1.<priceOff>k__BackingField);
            return (int)val_6;
            label_1:
            val_6 = 1;
            return (int)val_6;
            label_2:
            val_6 = 0;
            return (int)val_6;
            label_4:
            val_5 = item2 + 40;
            val_6 = item2 + 40.CompareTo(target:  item1.type);
            mem2[0] = item2 + 40;
            return (int)val_6;
        }
        protected SpecialOfferProduct()
        {
            this = new System.Object();
        }
    
    }

}
