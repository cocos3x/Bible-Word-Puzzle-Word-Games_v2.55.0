using UnityEngine;

namespace View.Dialog.GameDictionary.Controller
{
    public class LimiTimePackageComparer : IComparer<Data.Bean.ProductBean>
    {
        // Methods
        public int Compare(Data.Bean.ProductBean x, Data.Bean.ProductBean y)
        {
            var val_5;
            if(x == null)
            {
                goto label_1;
            }
            
            if(y == null)
            {
                goto label_2;
            }
            
            val_5 = (Common.Singleton<Data.Shop.ShopDataManager>.Instance.GetOverdueSecondForName(name:  x.name)) - (Common.Singleton<Data.Shop.ShopDataManager>.Instance.GetOverdueSecondForName(name:  y.name));
            return (int)val_5;
            label_1:
            val_5 = 0;
            return (int)val_5;
            label_2:
            val_5 = 1;
            return (int)val_5;
        }
        public LimiTimePackageComparer()
        {
        
        }
    
    }

}
