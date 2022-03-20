using UnityEngine;

namespace Data.Shop
{
    public class ShopDataManager : Singleton<Data.Shop.ShopDataManager>
    {
        // Fields
        private int <PlayLevelCount>k__BackingField;
        
        // Properties
        public int PlayLevelCount { get; set; }
        public bool IsBuyItem { get; set; }
        public bool IsBuyAnyItem { get; set; }
        public string FirstBuyTime { get; set; }
        public System.Collections.Generic.Dictionary<string, int> PackageShowTime { get; }
        public System.Collections.Generic.Dictionary<string, string> PackageOverdue { get; }
        
        // Methods
        public void set_PlayLevelCount(int value)
        {
            this.<PlayLevelCount>k__BackingField = value;
        }
        public int get_PlayLevelCount()
        {
            return (int)this.<PlayLevelCount>k__BackingField;
        }
        public void Init()
        {
            bool val_1 = this.IsBuyItem;
            if(val_1 != false)
            {
                    bool val_2 = val_1.IsBuyAnyItem;
                if(val_2 != true)
            {
                    val_2.IsBuyAnyItem = true;
            }
            
            }
            
            this.<PlayLevelCount>k__BackingField = 0;
        }
        public bool get_IsBuyItem()
        {
            return (bool)Store.ShopData.__il2cppRuntimeField_name;
        }
        private void set_IsBuyItem(bool value)
        {
            typeof(Store.ShopData).__il2cppRuntimeField_10 = value;
        }
        public bool get_IsBuyAnyItem()
        {
            return (bool)typeof(Store.ShopData).__il2cppRuntimeField_11;
        }
        private void set_IsBuyAnyItem(bool value)
        {
            typeof(Store.ShopData).__il2cppRuntimeField_11 = value;
        }
        public string get_FirstBuyTime()
        {
            return (string)Store.ShopData.__il2cppRuntimeField_namespaze;
        }
        private void set_FirstBuyTime(string value)
        {
            typeof(Store.ShopData).__il2cppRuntimeField_18 = value;
        }
        public System.Collections.Generic.Dictionary<string, int> get_PackageShowTime()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)Store.ShopData.__il2cppRuntimeField_byval_arg;
        }
        public System.Collections.Generic.Dictionary<string, string> get_PackageOverdue()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)typeof(Store.ShopData).__il2cppRuntimeField_28;
        }
        public void SetBuyItem(bool isBuy)
        {
            bool val_4 = isBuy;
            isBuy = val_4;
            this.IsBuyItem = isBuy;
            if(val_4 == false)
            {
                    return;
            }
            
            Platform.Ad.GameAdManager.<Instance>k__BackingField.HideBannerAd();
            val_4 = View.Game.GameController.GetInstance();
            if(val_4 == 0)
            {
                    return;
            }
            
            View.Game.GameController val_3 = View.Game.GameController.GetInstance();
            val_3._isBannerShowed = false;
        }
        public void SetBuyAnyItem(bool isBuy)
        {
            this.IsBuyAnyItem = isBuy;
        }
        public void AddPackageShowTimeForName(string name)
        {
            var val_8;
            string val_1 = this.ChangePackName(name:  name);
            bool val_3 = val_1.PackageShowTime.ContainsKey(key:  val_1);
            val_8 = val_3.PackageShowTime;
            if(val_3 != true)
            {
                    val_8.Add(key:  val_1, value:  0);
                val_8 = val_8.PackageShowTime;
            }
            
            val_8.set_Item(key:  val_1, value:  val_8.Item[val_1] + 1);
        }
        public int GetPackageShowTimeForName(string name)
        {
            string val_1 = this.ChangePackName(name:  name);
            bool val_3 = val_1.PackageShowTime.ContainsKey(key:  val_1);
            if(val_3 == true)
            {
                    return val_4.PackageShowTime.Item[val_1];
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = val_3.PackageShowTime;
            val_4.Add(key:  val_1, value:  0);
            return val_4.PackageShowTime.Item[val_1];
        }
        public void SetOverdueSecondForName(string name, System.DateTime overdueTime)
        {
            string val_1 = this.ChangePackName(name:  name);
            bool val_3 = val_1.PackageOverdue.ContainsKey(key:  val_1);
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = val_3.PackageOverdue;
            if(val_3 != false)
            {
                    bool val_6 = System.String.IsNullOrEmpty(value:  val_4.Item[val_1]);
                if(val_6 == false)
            {
                    return;
            }
            
                val_6.PackageOverdue.set_Item(key:  val_1, value:  Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = overdueTime.dateData}, format:  0));
                return;
            }
            
            val_4.Add(key:  val_1, value:  Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = overdueTime.dateData}, format:  0));
        }
        public void ClearOverdueSecondForName(string name)
        {
            string val_1 = this.ChangePackName(name:  name);
            bool val_3 = val_1.PackageOverdue.ContainsKey(key:  val_1);
            if(val_3 == false)
            {
                    return;
            }
            
            bool val_5 = val_3.PackageOverdue.Remove(key:  val_1);
        }
        public long GetOverdueSecondForName(string name)
        {
            long val_18;
            string val_1 = this.ChangePackName(name:  name);
            bool val_3 = val_1.PackageOverdue.ContainsKey(key:  val_1);
            if(val_3 != false)
            {
                    val_18 = 0;
                if((System.String.IsNullOrEmpty(value:  val_3.PackageOverdue.Item[val_1])) == true)
            {
                    return (long)val_18;
            }
            
                System.DateTime val_9 = Utils.Csharp.StringExtension.ToDateTime(self:  this.PackageOverdue.Item[val_1], defaultValue:  new System.DateTime());
                System.DateTime val_10 = System.DateTime.Now;
                val_18 = 0;
                if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_9.dateData}, t2:  new System.DateTime() {dateData = val_10.dateData})) == false)
            {
                    return (long)val_18;
            }
            
                System.DateTime val_14 = Utils.Csharp.StringExtension.ToDateTime(self:  this.PackageOverdue.Item[val_1], defaultValue:  new System.DateTime());
                System.DateTime val_15 = System.DateTime.Now;
                System.TimeSpan val_16 = val_14.dateData.Subtract(value:  new System.DateTime() {dateData = val_15.dateData});
                val_18 = (long)val_16._ticks.TotalSeconds;
                return (long)val_18;
            }
            
            val_18 = 0;
            return (long)val_18;
        }
        public void SetFirstBuyProductTime()
        {
            if((System.String.IsNullOrEmpty(value:  this.FirstBuyTime)) == false)
            {
                    return;
            }
            
            System.DateTime val_3 = System.DateTime.Now;
            string val_4 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = val_3.dateData}, format:  0);
            val_4.FirstBuyTime = val_4;
        }
        public string GetFirstBuyProductTime()
        {
            return this.FirstBuyTime;
        }
        private string ChangePackName(string name)
        {
            return name.Replace(oldValue:  " ", newValue:  "_");
        }
        public ShopDataManager()
        {
        
        }
    
    }

}
