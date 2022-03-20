using UnityEngine;

namespace I2.Loc
{
    public class CustomLocalizeCallback : MonoBehaviour
    {
        // Fields
        public UnityEngine.Events.UnityEvent _OnLocalize;
        
        // Methods
        public void OnEnable()
        {
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize();
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  null);
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize();
            I2.Loc.LocalizationManager.add_OnLocalizeEvent(value:  null);
        }
        public void OnDisable()
        {
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize();
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  null);
        }
        public void OnLocalize()
        {
            if(this._OnLocalize != null)
            {
                    this._OnLocalize.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        public CustomLocalizeCallback()
        {
            this._OnLocalize = new UnityEngine.Events.UnityEvent();
        }
    
    }

}
