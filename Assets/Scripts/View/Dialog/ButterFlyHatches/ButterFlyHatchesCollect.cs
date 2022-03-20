using UnityEngine;

namespace View.Dialog.ButterFlyHatches
{
    public class ButterFlyHatchesCollect : MonoBehaviour
    {
        // Fields
        public ButterFlyIcon Icon;
        
        // Methods
        public void SetButterFlyIcon(int index)
        {
            if(this.Icon != null)
            {
                    this.Icon.SetButterFlyIcon(index:  index, isCollect:  true);
                return;
            }
            
            throw new NullReferenceException();
        }
        public ButterFlyHatchesCollect()
        {
        
        }
    
    }

}
