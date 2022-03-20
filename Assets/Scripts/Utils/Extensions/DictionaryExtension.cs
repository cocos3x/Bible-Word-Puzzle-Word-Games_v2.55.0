using UnityEngine;

namespace Utils.Extensions
{
    public static class DictionaryExtension
    {
        // Methods
        public static string ToCustomString<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> dic)
        {
            var val_13;
            string val_14;
            object val_16;
            string val_18;
            val_13 = __RuntimeMethodHiddenParam;
            if(dic == null)
            {
                    return "[]";
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = "[";
            System.Text.StringBuilder val_2 = Append(value:  val_14);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = __RuntimeMethodHiddenParam + 48;
            val_16 = dic;
            goto label_9;
            label_25:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_18 = val_16 + ":"(":") + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(dic, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(dic, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8);
            System.Text.StringBuilder val_6 = Append(value:  val_18);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = __RuntimeMethodHiddenParam + 48 + 48;
            if(0 != (dic - 1))
            {
                    System.Text.StringBuilder val_9 = Append(value:  ", ");
            }
            
            label_9:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_16.MoveNext() == true)
            {
                goto label_25;
            }
            
            val_13 = 0;
            if(val_16 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_16.Dispose();
            }
            
            if(val_13 != 0)
            {
                    throw val_13 = ???;
            }
            
            System.Text.StringBuilder val_13 = Append(value:  "]");
            val_16 = ???;
            goto mem[null + 352];
        }
    
    }

}
