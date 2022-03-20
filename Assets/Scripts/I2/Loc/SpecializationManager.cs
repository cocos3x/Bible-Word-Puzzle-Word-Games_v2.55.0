using UnityEngine;

namespace I2.Loc
{
    public class SpecializationManager : BaseSpecializationManager
    {
        // Fields
        public static I2.Loc.SpecializationManager Singleton;
        
        // Methods
        private SpecializationManager()
        {
            this.InitializeSpecializations();
        }
        public static string GetSpecializedText(string text, string specialization)
        {
            string val_13;
            var val_14;
            var val_15;
            int val_16;
            val_13 = specialization;
            int val_1 = text.IndexOf(value:  "[i2s_");
            if((val_1 & 2147483648) != 0)
            {
                    return (string)text;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_13)) != false)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = I2.Loc.SpecializationManager.Singleton.GetCurrentSpecialization();
            }
            
            if((System.String.IsNullOrEmpty(value:  val_13)) == true)
            {
                    return text.Substring(startIndex:  0, length:  val_1);
            }
            
            label_13:
            if((System.String.op_Inequality(a:  val_13, b:  "Any")) == false)
            {
                    return text.Substring(startIndex:  0, length:  val_1);
            }
            
            int val_7 = text.IndexOf(value:  "[i2s_" + val_13 + "]");
            if((val_7 & 2147483648) == 0)
            {
                goto label_9;
            }
            
            val_15 = null;
            val_15 = null;
            string val_8 = I2.Loc.SpecializationManager.Singleton.GetFallbackSpecialization(specialization:  val_13);
            val_13 = val_8;
            if((System.String.IsNullOrEmpty(value:  val_8)) == false)
            {
                goto label_13;
            }
            
            return text.Substring(startIndex:  0, length:  val_1);
            label_9:
            int val_10 = val_6.m_stringLength + val_7;
            val_16 = text;
            if(((val_16.IndexOf(value:  "[i2s_", startIndex:  val_10)) & 2147483648) != 0)
            {
                    val_16 = text.m_stringLength;
            }
            
            int val_12 = val_16 - val_10;
            return text.Substring(startIndex:  0, length:  val_1);
        }
        public static string SetSpecializedText(string text, string newText, string specialization)
        {
            string val_6 = "Any";
            string val_2 = ((System.String.IsNullOrEmpty(value:  specialization)) != true) ? (val_6) : specialization;
            if(text == null)
            {
                goto label_1;
            }
            
            if((text.Contains(value:  "[i2s_")) == true)
            {
                goto label_3;
            }
            
            val_6 = "Any";
            label_1:
            if((System.String.op_Equality(a:  val_2, b:  val_6)) != false)
            {
                    return (string)newText;
            }
            
            label_3:
            System.Collections.Generic.Dictionary<System.String, System.String> val_5 = I2.Loc.SpecializationManager.GetSpecializations(text:  text, buffer:  0);
            val_5.set_Item(key:  val_2, value:  newText);
            return I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_5);
        }
        public static string SetSpecializedText(System.Collections.Generic.Dictionary<string, string> specializations)
        {
            string val_5;
            var val_6;
            string val_12;
            var val_13;
            int val_14;
            val_12 = specializations;
            bool val_2 = val_12.TryGetValue(key:  "Any", value: out  0);
            Dictionary.Enumerator<TKey, TValue> val_3 = val_12.GetEnumerator();
            goto label_5;
            label_22:
            val_12 = val_5;
            if(((System.String.op_Inequality(a:  val_5, b:  "Any")) != false) && ((System.String.IsNullOrEmpty(value:  val_12)) != true))
            {
                    string[] val_9 = new string[5];
                if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(System.String.alignConst != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
                val_14 = val_9.Length;
                if(val_14 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_9[0] = System.String.alignConst;
                val_13 = "[i2s_";
                if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_14 = val_9.Length;
                if(val_14 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_9[1] = "[i2s_";
                if(val_5 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_14 = val_9.Length;
            }
            
                val_9[2] = val_5;
                val_13 = "]";
                if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_14 = val_9.Length;
                if(val_14 <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_9[3] = "]";
                if(val_12 != 0)
            {
                    val_14 = val_9.Length;
            }
            
                if(val_14 <= 4)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_9[4] = val_12;
            }
            
            label_5:
            if(val_6.MoveNext() == true)
            {
                goto label_22;
            }
            
            val_6.Dispose();
            return (string)+val_9;
        }
        public static System.Collections.Generic.Dictionary<string, string> GetSpecializations(string text, System.Collections.Generic.Dictionary<string, string> buffer)
        {
            int val_11;
            var val_12;
            string val_13;
            string val_14;
            var val_15;
            val_12 = buffer;
            if(val_12 == null)
            {
                goto label_1;
            }
            
            val_12.Clear();
            if(text == null)
            {
                goto label_2;
            }
            
            label_11:
            int val_1 = text.IndexOf(value:  "[i2s_");
            val_11 = val_1;
            if((val_1 & 2147483648) != 0)
            {
                    val_11 = text.m_stringLength;
            }
            
            val_13 = text.Substring(startIndex:  0, length:  val_11);
            val_14 = "Any";
            val_15 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            goto label_5;
            label_9:
            int val_4 = text.IndexOf(value:  ']', startIndex:  ("[i2s_".__il2cppRuntimeField_10 + text.m_stringLength));
            if((val_4 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)val_12;
            }
            
            int val_6 = val_4 + 1;
            int val_7 = text.IndexOf(value:  "[i2s_", startIndex:  val_6);
            val_11 = val_7;
            if((val_7 & 2147483648) != 0)
            {
                    val_11 = text.m_stringLength;
            }
            
            val_15 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            val_13 = text.Substring(startIndex:  val_6, length:  val_11 - val_6);
            val_14 = text.Substring(startIndex:  ("[i2s_".__il2cppRuntimeField_10 + text.m_stringLength), length:  (val_4 - ("[i2s_".__il2cppRuntimeField_10 + text.m_stringLength))>>0&0xFFFFFFFF);
            label_5:
            val_12.set_Item(key:  val_14, value:  val_13);
            if(val_11 < text.m_stringLength)
            {
                goto label_9;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_12;
            label_1:
            System.Collections.Generic.Dictionary<System.String, System.String> val_10 = null;
            val_12 = val_10;
            val_10 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(text != null)
            {
                goto label_11;
            }
            
            label_2:
            set_Item(key:  "Any", value:  "");
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_12;
        }
        private static SpecializationManager()
        {
            InitializeSpecializations();
            I2.Loc.SpecializationManager.Singleton = new I2.Loc.BaseSpecializationManager();
        }
    
    }

}
