using UnityEngine;

namespace Data.Treasure
{
    [Serializable]
    public class MissionBean
    {
        // Fields
        public int totalQuantity;
        public System.Collections.Generic.List<Data.Treasure.MissionItem> items;
        
        // Methods
        public MissionBean()
        {
        
        }
    
    }

}
