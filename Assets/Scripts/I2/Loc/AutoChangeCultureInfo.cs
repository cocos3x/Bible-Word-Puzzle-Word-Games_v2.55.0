using UnityEngine;

namespace I2.Loc
{
    public class AutoChangeCultureInfo : MonoBehaviour
    {
        // Methods
        public void Start()
        {
            I2.Loc.LocalizationManager.EnableChangingCultureInfo(bEnable:  true);
        }
        public AutoChangeCultureInfo()
        {
        
        }
    
    }

}
