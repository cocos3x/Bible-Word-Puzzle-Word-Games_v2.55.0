using UnityEngine;

namespace Common
{
    internal class EzVersionComparer
    {
        // Methods
        private static int coverStringToInt(string str)
        {
            int val_1 = 0;
            return (int)((System.Int32.TryParse(s:  str, result: out  val_1)) != true) ? (val_1) : 0;
        }
        public static int VerCompare(string ver1, string Ver2)
        {
            int val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            char[] val_1 = new char[1];
            val_1[0] = '.';
            char[] val_3 = new char[1];
            val_3[0] = '.';
            val_12 = val_2.Length;
            int val_5 = System.Math.Max(val1:  val_12, val2:  val_4.Length);
            if(val_5 < 1)
            {
                goto label_11;
            }
            
            val_13 = 0;
            val_12 = (long)val_12;
            label_20:
            if(val_13 < val_12)
            {
                    int val_6 = 0;
                var val_8 = ((System.Int32.TryParse(s:  null, result: out  val_6)) != true) ? (val_6) : 0;
            }
            else
            {
                    val_14 = 0;
            }
            
            if(val_13 < (long)val_4.Length)
            {
                    int val_9 = 0;
                var val_11 = ((System.Int32.TryParse(s:  null, result: out  val_9)) != true) ? (val_9) : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(val_14 > val_15)
            {
                goto label_18;
            }
            
            if(val_14 < val_15)
            {
                goto label_19;
            }
            
            val_13 = val_13 + 1;
            if(val_13 < (long)val_5)
            {
                goto label_20;
            }
            
            label_11:
            val_16 = 0;
            return (int)val_16;
            label_18:
            val_16 = 1;
            return (int)val_16;
            label_19:
            val_16 = 0;
            return (int)val_16;
        }
    
    }

}
