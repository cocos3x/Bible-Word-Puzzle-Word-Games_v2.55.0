using UnityEngine;

namespace Data.Bean
{
    [Serializable]
    public class ProductBean
    {
        // Fields
        public string productId;
        public float price;
        public System.Collections.Generic.List<Data.Bean.RewardItem> rewards;
        public int continiesTime;
        public string name;
        public string desc;
        
        // Methods
        public ProductBean()
        {
        
        }
    
    }

}
