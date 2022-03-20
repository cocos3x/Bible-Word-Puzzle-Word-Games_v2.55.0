using UnityEngine;

namespace Common
{
    public class GlobalMethods
    {
        // Methods
        public static T GetBaseVale<T>(object[] inputs, int idx, object defaultVal)
        {
            var val_3;
            var val_4;
            System.Type val_5;
            var val_6;
            val_3 = __RuntimeMethodHiddenParam;
            val_4 = defaultVal;
            val_5 = idx;
            if(inputs == null)
            {
                goto label_11;
            }
            
            if(inputs.Length <= val_5)
            {
                goto label_2;
            }
            
            object val_3 = inputs[val_5];
            if(val_3 == null)
            {
                goto label_11;
            }
            
            val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 8});
            val_4 = System.Convert.ChangeType(value:  val_3, conversionType:  val_5);
            val_3 = mem[__RuntimeMethodHiddenParam + 48];
            val_3 = __RuntimeMethodHiddenParam + 48;
            if(val_4 != null)
            {
                    return (Data.Bible.BibleOpenFrom)val_6;
            }
            
            throw new NullReferenceException();
            label_2:
            if(val_4 != null)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 48 + 48];
                val_3 = __RuntimeMethodHiddenParam + 48 + 48;
                if(((__RuntimeMethodHiddenParam + 48 + 48 + 302) & 1) != 0)
            {
                    return (Data.Bible.BibleOpenFrom)val_6;
            }
            
                return (Data.Bible.BibleOpenFrom)val_6;
            }
            
            label_11:
            val_6 = 0;
            return (Data.Bible.BibleOpenFrom)val_6;
        }
        public static string TransTimeSecondIntToString(long second)
        {
            var val_13 = 0;
            val_13 = val_13 + second;
            long val_1 = val_13 >> 5;
            val_1 = val_1 + (val_13 >> 63);
            val_1 = second - (val_1 * 60);
            string val_2 = 5124095576030431.ToString();
            if(second > 35999)
            {
                    string val_3 = "" + val_2;
            }
            
            string val_5 = "" + "0" + val_2("" + "0" + val_2) + ":"(":");
            string val_6 = -269015017741597627.ToString();
            if((-269015017741597627) > 9)
            {
                    string val_7 = val_5 + val_6;
            }
            
            string val_9 = val_5 + "0" + val_6(val_5 + "0" + val_6) + ":"(":");
            string val_10 = val_1.ToString();
            if(val_1 <= 9)
            {
                    return (string)val_9 + "0" + val_10;
            }
            
            string val_11 = val_9 + val_10;
            return (string)val_9 + "0" + val_10;
        }
        public static string TransTimeSecondToDayString(long second)
        {
            if(second < 86401)
            {
                    return Common.GlobalMethods.TransTimeSecondIntToString(second:  second);
            }
            
            float val_4 = 86400f;
            val_4 = (float)second / val_4;
            return (string)System.String.Format(format:  Locale.LocaleManager.Translate(key:  "118"), arg0:  UnityEngine.Mathf.FloorToInt(f:  val_4));
        }
        public static bool IsToday(System.DateTime des, System.Nullable<System.DateTime> res)
        {
            if(X2 == 255)
            {
                    System.DateTime val_1 = System.DateTime.Now;
                System.Nullable<System.DateTime> val_2 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = val_1.dateData});
            }
            
            System.DateTime val_3 = val_2.HasValue.Value;
            return (bool)System.String.op_Equality(a:  des.dateData.ToShortDateString(), b:  val_3.dateData.ToShortDateString());
        }
    
    }

}
