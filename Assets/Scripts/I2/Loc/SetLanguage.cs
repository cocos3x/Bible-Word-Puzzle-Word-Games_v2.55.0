using UnityEngine;

namespace I2.Loc
{
    public class SetLanguage : MonoBehaviour
    {
        // Fields
        public string _Language;
        
        // Methods
        private void OnClick()
        {
            this.ApplyLanguage();
        }
        public void ApplyLanguage()
        {
            if((I2.Loc.LocalizationManager.HasLanguage(Language:  this._Language, AllowDiscartingRegion:  true, Initialize:  true, SkipDisabled:  true)) == false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.CurrentLanguage = this._Language;
        }
        public SetLanguage()
        {
        
        }
    
    }

}
