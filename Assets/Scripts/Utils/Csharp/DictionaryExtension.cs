using UnityEngine;

namespace Utils.Csharp
{
    public static class DictionaryExtension
    {
        // Methods
        public static bool IsEmptyOrNull<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self)
        {
            var val_3;
            var val_4;
            val_3 = mem[__RuntimeMethodHiddenParam + 48];
            val_3 = __RuntimeMethodHiddenParam + 48;
            if((self & 1) != 0)
            {
                    val_4 = 1;
                return (bool)(self == 0) ? 1 : 0;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = __RuntimeMethodHiddenParam + 48 + 8;
            return (bool)(self == 0) ? 1 : 0;
        }
        public static bool IsNotEmptyAndNull<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self)
        {
            self = (~self) & 1;
            return (bool)self;
        }
        public static bool IsNullOrEmpty<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self)
        {
            var val_3;
            var val_4;
            val_3 = mem[__RuntimeMethodHiddenParam + 48];
            val_3 = __RuntimeMethodHiddenParam + 48;
            if((self & 1) != 0)
            {
                    val_4 = 1;
                return (bool)(self == 0) ? 1 : 0;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = __RuntimeMethodHiddenParam + 48 + 8;
            return (bool)(self == 0) ? 1 : 0;
        }
        public static bool IsNotNullAndEmpty<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self)
        {
            self = (~self) & 1;
            return (bool)self;
        }
        public static System.Collections.Generic.IDictionary<TK, TV> ForEach<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self, System.Action<TK, TV> action)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_10;
            val_6 = __RuntimeMethodHiddenParam;
            val_7 = mem[__RuntimeMethodHiddenParam + 48];
            val_7 = __RuntimeMethodHiddenParam + 48;
            if((self & 1) != 0)
            {
                    return (System.Collections.Generic.IDictionary<TK, TV>)self;
            }
            
            if(self == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = __RuntimeMethodHiddenParam + 48 + 8;
            val_5 = self;
            label_20:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_5.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_10 = __RuntimeMethodHiddenParam + 48 + 16;
            if(action == null)
            {
                    throw new NullReferenceException();
            }
            
            goto label_20;
            label_13:
            val_6 = 0;
            if(val_5 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_5.Dispose();
            }
            
            if(val_6 != 0)
            {
                    throw val_6;
            }
            
            return (System.Collections.Generic.IDictionary<TK, TV>)self;
        }
        public static System.Collections.Generic.IDictionary<TK, TV> AddRange<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self, System.Collections.Generic.IDictionary<TK, TV> sourceDic, bool isOverride = False)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_15;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = sourceDic;
            if((self & 1) != 0)
            {
                    return (System.Collections.Generic.IDictionary<TK, TV>)self;
            }
            
            val_11 = mem[__RuntimeMethodHiddenParam + 48 + 8];
            val_11 = __RuntimeMethodHiddenParam + 48 + 8;
            if((val_10 & 1) != 0)
            {
                    return (System.Collections.Generic.IDictionary<TK, TV>)self;
            }
            
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = mem[__RuntimeMethodHiddenParam + 48 + 16];
            val_8 = __RuntimeMethodHiddenParam + 48 + 16;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = val_8;
            val_12 = 0;
            val_10 = val_10;
            label_39:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = 0;
            val_15 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_10.MoveNext() == false)
            {
                goto label_14;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_15 = __RuntimeMethodHiddenParam + 48 + 24;
            val_12 = 0;
            if(self == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = 3;
            if((self & 1) == 0)
            {
                goto label_26;
            }
            
            if(isOverride == false)
            {
                goto label_39;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_39;
            label_26:
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_39;
            label_14:
            val_9 = 0;
            if(val_10 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_10.Dispose();
            }
            
            if(val_9 != 0)
            {
                    throw val_9;
            }
            
            return (System.Collections.Generic.IDictionary<TK, TV>)self;
        }
        public static string ToCustomString<TK, TV>(System.Collections.Generic.IDictionary<TK, TV> self)
        {
            if((self & 1) == 0)
            {
                    return "{" + "," + "}";
            }
            
            return "{}";
        }
    
    }

}
