using UnityEngine;

namespace Platform.Ad
{
    public class ADPlacementLogEvent
    {
        // Fields
        public string category;
        public string action;
        public string lable;
        
        // Methods
        public ADPlacementLogEvent(string category, string action, string lable)
        {
            val_1 = new System.Object();
            this.category = (category == null) ? "" : category;
            this.action = (val_1 == null) ? "" : (val_1);
            this.lable = (lable == null) ? "" : lable;
        }
    
    }

}
