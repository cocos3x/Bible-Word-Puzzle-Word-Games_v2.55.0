using UnityEngine;

namespace Utils.Extensions
{
    public static class ListExtension
    {
        // Methods
        public static void Shuffle<T>(System.Collections.Generic.IList<T> list, int count = -1)
        {
            var val_9;
            var val_11;
            var val_13;
            var val_15;
            var val_17;
            val_9 = count;
            if(val_9 == 1)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = list;
            }
            
            val_11 = 0;
            null = new System.Random();
            if(val_9 < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = __RuntimeMethodHiddenParam + 48;
            val_13 = 0;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = __RuntimeMethodHiddenParam + 48;
            val_15 = list;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_15 = 0;
            val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8];
            val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0) + 8;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_17 = 0;
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_9 = val_9 - 1;
        }
        public static void AddAdll<T>(System.Collections.Generic.IList<T> list, System.Collections.Generic.IList<T> source)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_11;
            val_6 = __RuntimeMethodHiddenParam;
            val_7 = source;
            if(val_7 == null)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = 0;
            val_7 = val_7;
            label_24:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 0;
            val_11 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_7.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = __RuntimeMethodHiddenParam + 48 + 8;
            val_8 = 0;
            if(list == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_8 = 2;
            goto label_24;
            label_12:
            val_6 = 0;
            if(val_7 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_7.Dispose();
            }
            
            if(val_6 != 0)
            {
                    throw val_6;
            }
        
        }
    
    }

}
