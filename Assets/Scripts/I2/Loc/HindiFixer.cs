using UnityEngine;

namespace I2.Loc
{
    public class HindiFixer
    {
        // Methods
        internal static string Fix(string text)
        {
            string val_9;
            var val_10;
            var val_11;
            System.Func<System.Char, System.Boolean> val_12;
            int val_13;
            var val_14;
            val_9 = text;
            System.Char[] val_1 = val_9.ToCharArray();
            int val_18 = val_1.Length;
            if(val_18 < 1)
            {
                    return (string)val_9;
            }
            
            val_10 = 1152921504612597760;
            val_11 = 0;
            var val_37 = 0;
            val_18 = val_18 & 4294967295;
            do
            {
                char val_19 = val_1[0];
                if(val_19 == 'ि')
            {
                    var val_2 = val_37 - 1;
                if((System.Char.IsWhiteSpace(c:  W21)) != true)
            {
                    int val_20 = val_1.Length;
                if(val_19 != 0)
            {
                    val_20 = val_20 & 4294967295;
                val_11 = 1;
                val_1[0] = val_19;
                mem2[0] = 2367;
            }
            
            }
            
            }
            
                if(val_37 != (val_1.Length - 1))
            {
                    val_13 = val_1.Length & 4294967295;
                if(val_1[0] == 'इ')
            {
                    var val_5 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ऌ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == 'ृ')
            {
                    var val_6 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ॄ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == 'ँ')
            {
                    var val_7 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ॐ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == 'ऋ')
            {
                    var val_8 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ॠ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == 'ई')
            {
                    var val_9 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ॡ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == 'ि')
            {
                    var val_10 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ॢ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == 'ी')
            {
                    var val_11 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_1[0] = 'ॣ';
                val_1[0] = 0;
                val_13 = val_1.Length;
                val_11 = 1;
            }
            
            }
            
                if(val_1[0] == '।')
            {
                    var val_12 = val_37 + 1;
                if(val_1[0] == '़')
            {
                    val_11 = 1;
                val_1[0] = 'ऽ';
                val_1[0] = 0;
            }
            
            }
            
            }
            
                val_37 = val_37 + 1;
            }
            while(val_37 < (val_1.Length << ));
            
            if((val_11 & 1) == 0)
            {
                    return (string)val_9;
            }
            
            val_10 = 1152921504836612096;
            val_14 = null;
            val_14 = null;
            val_12 = HindiFixer.<>c.<>9__0_0;
            if(val_12 == null)
            {
                    System.Func<System.Char, System.Boolean> val_13 = null;
                val_12 = val_13;
                val_13 = new System.Func<System.Char, System.Boolean>(object:  HindiFixer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HindiFixer.<>c::<Fix>b__0_0(char x));
                HindiFixer.<>c.<>9__0_0 = val_12;
            }
            
            string val_16 = 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_1, predicate:  val_12)));
            bool val_17 = System.String.op_Equality(a:  val_16, b:  val_9);
            val_9 = val_16;
            return (string)val_9;
        }
    
    }

}
