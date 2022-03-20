using UnityEngine;

namespace View.CommonItem
{
    public class SettingButton : MonoBehaviour
    {
        // Methods
        private void Awake()
        {
            var val_3;
            UnityEngine.Events.UnityAction val_5;
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            val_3 = null;
            val_3 = null;
            val_5 = SettingButton.<>c.<>9__0_0;
            if(val_5 == null)
            {
                    UnityEngine.Events.UnityAction val_2 = null;
                val_5 = val_2;
                val_2 = new UnityEngine.Events.UnityAction(object:  SettingButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SettingButton.<>c::<Awake>b__0_0());
                SettingButton.<>c.<>9__0_0 = val_5;
            }
            
            val_1.m_OnClick.AddListener(call:  val_5);
        }
        public SettingButton()
        {
        
        }
    
    }

}
