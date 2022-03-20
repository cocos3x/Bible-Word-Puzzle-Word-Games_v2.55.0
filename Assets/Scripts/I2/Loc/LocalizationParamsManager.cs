using UnityEngine;

namespace I2.Loc
{
    public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
    {
        // Fields
        public System.Collections.Generic.List<I2.Loc.LocalizationParamsManager.ParamValue> _Params;
        public bool _IsGlobalManager;
        
        // Methods
        public string GetParameterValue(string ParamName)
        {
            var val_2;
            bool val_2 = true;
            if((this._Params == null) || (W23 < 1))
            {
                    return 0;
            }
            
            val_2 = 0;
            var val_3 = 0;
            label_6:
            if(val_3 >= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + val_2;
            if((System.String.op_Equality(a:  (true + val_2) + 32, b:  ParamName)) == true)
            {
                goto label_4;
            }
            
            val_3 = val_3 + 1;
            if(val_3 >= X23)
            {
                    return 0;
            }
            
            val_2 = val_2 + 16;
            if(this._Params != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_4:
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + val_2;
            return 0;
        }
        public void SetParameterValue(string ParamName, string ParamValue, bool localize = True)
        {
            var val_3;
            System.Collections.Generic.List<ParamValue> val_4;
            var val_5;
            val_4 = this._Params;
            if(W26 < 1)
            {
                goto label_2;
            }
            
            val_3 = 0;
            val_5 = 32;
            label_6:
            if(val_3 >= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Equality(a:  64, b:  ParamName)) == true)
            {
                goto label_5;
            }
            
            val_4 = this._Params;
            val_3 = val_3 + 1;
            val_5 = val_5 + 16;
            var val_2 = (val_4 == 0) ? 1 : 0;
            if(val_3 < X26)
            {
                goto label_6;
            }
            
            label_2:
            val_4.Add(item:  new ParamValue() {Name = ParamName, Value = ParamValue});
            if(localize == false)
            {
                    return;
            }
            
            label_12:
            this.OnLocalize();
            return;
            label_5:
            if(0 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this._Params.set_Item(index:  0, value:  new ParamValue() {Name = 64, Value = ParamValue});
            if(localize == true)
            {
                goto label_12;
            }
        
        }
        public void OnLocalize()
        {
            I2.Loc.Localize val_1 = this.GetComponent<I2.Loc.Localize>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.OnLocalize(Force:  true);
        }
        public virtual void OnEnable()
        {
            if(this._IsGlobalManager == false)
            {
                    return;
            }
            
            this.DoAutoRegister();
        }
        public void DoAutoRegister()
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
        public void OnDisable()
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.ParamManagers.Remove(item:  this);
        }
        public LocalizationParamsManager()
        {
            this._Params = new System.Collections.Generic.List<ParamValue>();
        }
    
    }

}
