using UnityEngine;

namespace I2.Loc
{
    public class SetLanguageDropdown : MonoBehaviour
    {
        // Methods
        private void OnEnable()
        {
            var val_9;
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_9 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) == 0)
            {
                    bool val_4 = I2.Loc.LocalizationManager.UpdateSources();
                val_9 = null;
            }
            
            System.Collections.Generic.List<System.String> val_5 = I2.Loc.LocalizationManager.GetAllLanguages(SkipDisabled:  true);
            val_1.ClearOptions();
            val_1.AddOptions(options:  val_5);
            val_1.value = val_5.IndexOf(item:  I2.Loc.LocalizationManager.CurrentLanguage);
            val_1.m_OnValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void I2.Loc.SetLanguageDropdown::OnValueChanged(int index)));
            val_1.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void I2.Loc.SetLanguageDropdown::OnValueChanged(int index)));
        }
        private void OnValueChanged(int index)
        {
            int val_3 = index;
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if((val_3 & 2147483648) == 0)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            val_1.value = 0;
            val_3 = 0;
            label_2:
            System.Collections.Generic.List<OptionData> val_2 = val_1.options;
            if(1152921513208542624 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            I2.Loc.LocalizationManager.CurrentLanguage = System.Int32 System.Array::InternalArray__IndexOf<ParamValue>(ParamValue item).__il2cppRuntimeField_10;
        }
        public SetLanguageDropdown()
        {
        
        }
    
    }

}
