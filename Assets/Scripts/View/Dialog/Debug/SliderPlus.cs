using UnityEngine;

namespace View.Dialog.Debug
{
    public class SliderPlus : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text text;
        public UnityEngine.UI.Slider slider;
        public UnityEngine.UI.Button buttonMinus;
        public UnityEngine.UI.Button buttonAdd;
        protected int value;
        protected System.Action<int> onValueChange;
        
        // Methods
        protected virtual void Awake()
        {
            this.value = (int)S0;
            this.slider.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  typeof(View.Dialog.Debug.SliderPlus).__il2cppRuntimeField_198));
            this.buttonMinus.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Debug.SliderPlus::<Awake>b__6_0()));
            this.buttonAdd.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Debug.SliderPlus::<Awake>b__6_1()));
        }
        public virtual void Init(int min, int max, System.Action<int> onValueChange, int value = -1)
        {
            int val_11 = value;
            this.slider.minValue = (float)min;
            this.slider.maxValue = (float)max;
            this.slider.wholeNumbers = true;
            if(val_11 != 1)
            {
                    if((System.String.op_Equality(a:  this.gameObject.name, b:  "Content_PiggyBank")) != false)
            {
                    Data.PiggyBank.PiggyBankDataManager val_4 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
                int val_6 = UnityEngine.Mathf.Clamp(value:  val_11 = value, min:  min, max:  val_4.PiggyBankCollectNum * max);
                this.value = val_6;
                string val_7 = val_6.ToString();
                val_11 = val_6;
                Data.PiggyBank.PiggyBankDataManager val_8 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
                int val_11 = val_8.PiggyBankCollectNum;
                val_11 = val_11 / val_11;
            }
            else
            {
                    int val_9 = UnityEngine.Mathf.Clamp(value:  val_11, min:  min, max:  max);
                this.value = val_9;
                val_11 = this.text;
                string val_10 = val_9.ToString();
            }
            
            }
            
            this.onValueChange = onValueChange;
        }
        protected virtual void OnValueChange(float value)
        {
            this.value = (int)value;
            if((System.String.op_Equality(a:  this.gameObject.name, b:  "Content_PiggyBank")) != false)
            {
                    Data.PiggyBank.PiggyBankDataManager val_4 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
                int val_6 = val_4.PiggyBankCollectNum;
                val_6 = val_6 * this.value;
                mem[1152921512769437400] = val_6;
            }
            
            if(this.onValueChange != null)
            {
                    this.onValueChange.Invoke(obj:  mem[1152921512769437400]);
            }
            
            string val_5 = mem[1152921512769437400].ToString();
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        public SliderPlus()
        {
        
        }
        private void <Awake>b__6_0()
        {
            float val_1 = S0 + (-1f);
            goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_420;
        }
        private void <Awake>b__6_1()
        {
            float val_1 = S0 + 1f;
            goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_420;
        }
    
    }

}
