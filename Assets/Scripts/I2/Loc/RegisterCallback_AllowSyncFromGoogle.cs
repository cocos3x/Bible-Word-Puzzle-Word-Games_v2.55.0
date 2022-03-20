using UnityEngine;

namespace I2.Loc
{
    public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
    {
        // Methods
        public void Awake()
        {
            var val_2 = null;
            I2.Loc.LocalizationManager.Callback_AllowSyncFromGoogle = new System.Func<I2.Loc.LanguageSourceData, System.Boolean>(object:  this, method:  typeof(I2.Loc.RegisterCallback_AllowSyncFromGoogle).__il2cppRuntimeField_178);
        }
        public void OnEnable()
        {
            var val_2 = null;
            I2.Loc.LocalizationManager.Callback_AllowSyncFromGoogle = new System.Func<I2.Loc.LanguageSourceData, System.Boolean>(object:  this, method:  typeof(I2.Loc.RegisterCallback_AllowSyncFromGoogle).__il2cppRuntimeField_178);
        }
        public void OnDisable()
        {
            null = null;
            I2.Loc.LocalizationManager.Callback_AllowSyncFromGoogle = 0;
        }
        public virtual bool AllowSyncFromGoogle(I2.Loc.LanguageSourceData Source)
        {
            return true;
        }
        public RegisterCallback_AllowSyncFromGoogle()
        {
        
        }
    
    }

}
