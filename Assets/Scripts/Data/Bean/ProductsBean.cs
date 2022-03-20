using UnityEngine;

namespace Data.Bean
{
    [Serializable]
    public class ProductsBean
    {
        // Fields
        public System.Collections.Generic.List<Data.Bean.ProductBean> limitedTimePackage;
        public System.Collections.Generic.List<Data.Bean.ProductBean> fixedPackage;
        public System.Collections.Generic.List<Data.Bean.ProductBean> products;
        
        // Methods
        public ProductsBean()
        {
        
        }
    
    }

}
