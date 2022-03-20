using UnityEngine;

namespace View.Dialog.Debug
{
    public class SliderPlusCoin : SliderPlus
    {
        // Fields
        private int coin;
        
        // Methods
        public void Init(System.Action<int> onValueChange, int coin)
        {
            var val_5 = 0;
            this.coin = coin;
            if(coin != 0)
            {
                    do
            {
                var val_4 = (X10 >> 34) + (X10 >> 63);
                val_5 = val_5 + 1;
            }
            while((coin + 9) > 18);
            
            }
            
            mem[1152921512769930456] = val_5;
            this.Init(min:  1, max:  6, onValueChange:  onValueChange, value:  0);
        }
        protected override void OnValueChange(float value)
        {
            int val_3;
            float val_1 = (int)value - 1;
            val_3 = 1;
            mem[1152921512770050648] = (int)value;
            if(val_1 >= (1.401298E-45f))
            {
                    do
            {
                val_1 = val_1 - 1;
                val_3 = 0;
            }
            while(val_1 > 0f);
            
            }
            
            this.coin = val_3;
            if(13712 != 0)
            {
                    13712.Invoke(obj:  10);
            }
            
            string val_2 = this.coin.ToString();
            goto typeof(View.Dialog.Debug.SliderPlusCoin).__il2cppRuntimeField_5A0;
        }
        private int Coin2Value(int coin)
        {
            var val_5 = 0;
            if(coin == 0)
            {
                    return (int)val_5;
            }
            
            do
            {
                var val_4 = (X9 >> 34) + (X9 >> 63);
                val_5 = val_5 + 1;
            }
            while((coin + 9) > 18);
            
            return (int)val_5;
        }
        private int Value2Coin(int value)
        {
            var val_2;
            int val_1 = value - 1;
            val_2 = 1;
            if(val_1 < 1)
            {
                    return (int)val_2;
            }
            
            do
            {
                val_1 = val_1 - 1;
                val_2 = 0;
            }
            while(val_1 > 0);
            
            return (int)val_2;
        }
        public SliderPlusCoin()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
