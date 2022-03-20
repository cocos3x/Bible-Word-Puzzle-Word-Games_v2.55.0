using UnityEngine;

namespace Data.Bean
{
    [Serializable]
    public class BibleBeans
    {
        // Fields
        public System.Collections.Generic.List<Data.Bean.BibleBean> bibles;
        
        // Methods
        public BibleBeans()
        {
            this.bibles = new System.Collections.Generic.List<Data.Bean.BibleBean>();
        }
    
    }

}
