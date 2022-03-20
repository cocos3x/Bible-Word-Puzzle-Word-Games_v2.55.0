using UnityEngine;

namespace I2.Loc
{
    public class LocalizeDropdown : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<string> _Terms;
        
        // Methods
        public void Start()
        {
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            I2.Loc.LocalizationManager.add_OnLocalizeEvent(value:  null);
            this.OnLocalize();
        }
        public void OnDestroy()
        {
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  null);
        }
        private void OnEnable()
        {
            if(this._Terms == null)
            {
                    this.FillValues();
            }
            
            this.OnLocalize();
        }
        public void OnLocalize()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.CurrentLanguage)) != false)
            {
                    return;
            }
            
            this.UpdateLocalization();
        }
        private void FillValues()
        {
            System.Collections.Generic.List<System.String> val_7;
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(val_1 == 0)
            {
                    if(UnityEngine.Application.isPlaying != false)
            {
                    this.FillValuesTMPro();
                return;
            }
            
            }
            
            List.Enumerator<T> val_5 = val_1.options.GetEnumerator();
            label_11:
            if(0.MoveNext() == false)
            {
                goto label_8;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_7 = this._Terms;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7.Add(item:  11993091);
            goto label_11;
            label_8:
            0.Dispose();
        }
        public void UpdateLocalization()
        {
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(val_1 == 0)
            {
                    this.UpdateLocalizationTMPro();
                return;
            }
            
            val_1.options.Clear();
            List.Enumerator<T> val_4 = this._Terms.GetEnumerator();
            label_12:
            if(0.MoveNext() == false)
            {
                goto label_8;
            }
            
            System.Collections.Generic.List<OptionData> val_7 = val_1.options;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7.Add(item:  new Dropdown.OptionData(text:  I2.Loc.LocalizationManager.GetTranslation(Term:  0, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0, allowLocalizedParameters:  true)));
            goto label_12;
            label_8:
            0.Dispose();
            val_1.RefreshShownValue();
        }
        public void UpdateLocalizationTMPro()
        {
            TMPro.TMP_Dropdown val_1 = this.GetComponent<TMPro.TMP_Dropdown>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.options.Clear();
            List.Enumerator<T> val_4 = this._Terms.GetEnumerator();
            label_11:
            if(0.MoveNext() == false)
            {
                goto label_7;
            }
            
            System.Collections.Generic.List<OptionData> val_7 = val_1.options;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7.Add(item:  new TMP_Dropdown.OptionData(text:  I2.Loc.LocalizationManager.GetTranslation(Term:  0, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0, allowLocalizedParameters:  true)));
            goto label_11;
            label_7:
            0.Dispose();
            val_1.RefreshShownValue();
        }
        private void FillValuesTMPro()
        {
            System.Collections.Generic.List<System.String> val_6;
            TMPro.TMP_Dropdown val_1 = this.GetComponent<TMPro.TMP_Dropdown>();
            if(val_1 == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_4 = val_1.options.GetEnumerator();
            label_9:
            if(0.MoveNext() == false)
            {
                goto label_6;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_6 = this._Terms;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6.Add(item:  11993091);
            goto label_9;
            label_6:
            0.Dispose();
        }
        public LocalizeDropdown()
        {
            this._Terms = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
