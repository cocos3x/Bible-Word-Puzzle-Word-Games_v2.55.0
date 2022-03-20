using UnityEngine;

namespace View.CommonItem.Combo
{
    public class Combo : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, View.CommonItem.Combo.ComboNormal> _dicCombos;
        private View.CommonItem.Combo.ComboNormal _tempNormal;
        
        // Methods
        public View.CommonItem.Combo.ComboNormal Create(UnityEngine.Transform parent, int combo)
        {
            var val_6;
            string val_8;
            var val_9;
            string val_10;
            var val_12;
            val_6 = null;
            val_6 = null;
            if((combo - 1) <= 3)
            {
                    var val_6 = 15720588 + ((combo - 1)) << 2;
                val_6 = val_6 + 15720588;
            }
            else
            {
                    if(combo == 20)
            {
                    val_9 = 20;
                val_12 = "Prefab/CommonItem/Combo/TCombo20";
            }
            else
            {
                    val_8 = "Prefab/CommonItem/Combo/TCombo8";
                val_9 = 4;
                val_10 = 1046544344 + 8;
                Platform.Analytics.EzAnalytics.SendComboShow(comboType:  new ComboTypeEnum() {<Value>k__BackingField = val_10}, comboNum:  combo);
            }
            
                if((this._dicCombos.TryGetValue(key:  val_8, value: out  this._tempNormal)) != true)
            {
                    View.CommonItem.Combo.ComboNormal val_4 = View.GameViewFactory.CreateComboNormal(parent:  parent, path:  val_8);
                this._tempNormal = val_4;
                this._dicCombos.Add(key:  val_8, value:  val_4);
            }
            
                if(mem[this._tempNormal] == 0)
            {
                    return (View.CommonItem.Combo.ComboNormal)mem[this._tempNormal];
            }
            
                mem[this._tempNormal].SetComboInfo(index:  4);
                mem[this._tempNormal].PlayComboAni(combo:  combo);
                return (View.CommonItem.Combo.ComboNormal)mem[this._tempNormal];
            }
        
        }
        public Combo()
        {
            this._dicCombos = new System.Collections.Generic.Dictionary<System.String, View.CommonItem.Combo.ComboNormal>();
        }
    
    }

}
