using UnityEngine;

namespace I2.Loc
{
    public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
    {
        // Methods
        public virtual void OnEnable()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((I2.Loc.LocalizationManager.ParamManagers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            I2.Loc.LocalizationManager.ParamManagers.Add(item:  this);
            I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
        }
        public virtual void OnDisable()
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.ParamManagers.Remove(item:  this);
        }
        public virtual string GetParameterValue(string ParamName)
        {
            return 0;
        }
        public RegisterGlobalParameters()
        {
        
        }
    
    }

}
