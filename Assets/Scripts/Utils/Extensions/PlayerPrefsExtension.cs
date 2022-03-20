using UnityEngine;

namespace Utils.Extensions
{
    public class PlayerPrefsExtension
    {
        // Methods
        public static void SetStrings(string key, System.Collections.Generic.List<string> datas)
        {
            string val_4;
            string val_5;
            string val_7;
            if((datas == null) || (true == 0))
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_1 = null;
            val_5 = 0;
            val_4 = val_1;
            val_1 = new System.Text.StringBuilder();
            if(1152921504626868224 < 1)
            {
                goto label_3;
            }
            
            var val_4 = 0;
            do
            {
                if(val_4 >= 1152921504626868224)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = "_PublicKeyToken";
                System.Text.StringBuilder val_2 = Append(value:  val_5);
                if(val_4 != 21225311)
            {
                    val_5 = ",";
                System.Text.StringBuilder val_3 = Append(value:  val_5);
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < (21225312 << ));
            
            goto label_8;
            label_2:
            val_7 = "";
            goto label_9;
            label_3:
            label_8:
            val_7 = val_4;
            label_9:
            UnityEngine.PlayerPrefs.SetString(key:  key, value:  val_7);
        }
        public static System.Collections.Generic.List<string> GetStrings(string key)
        {
            var val_7;
            System.Collections.Generic.IEnumerable<T> val_8;
            System.Collections.Generic.List<System.String> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Collections.Generic.List<System.String>();
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  key);
            val_8 = val_2;
            if((System.String.IsNullOrEmpty(value:  val_2)) == true)
            {
                    return (System.Collections.Generic.List<System.String>)val_7;
            }
            
            char[] val_4 = new char[1];
            val_4[0] = ',';
            val_8 = val_8.Split(separator:  val_4);
            System.Collections.Generic.List<System.String> val_6 = null;
            val_7 = val_6;
            val_6 = new System.Collections.Generic.List<System.String>(collection:  val_8);
            return (System.Collections.Generic.List<System.String>)val_7;
        }
        public static void SetInts(string key, System.Collections.Generic.List<int> datas)
        {
            string val_4;
            string val_5;
            string val_7;
            if((datas == null) || (true == 0))
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_1 = null;
            val_5 = 0;
            val_4 = val_1;
            val_1 = new System.Text.StringBuilder();
            if(1152921504626868224 < 1)
            {
                goto label_3;
            }
            
            var val_4 = 0;
            do
            {
                if(val_4 >= 1152921504626868224)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = "_PublicKeyToken";
                System.Text.StringBuilder val_2 = Append(value:  -240481312);
                if(val_4 != 21225311)
            {
                    val_5 = ",";
                System.Text.StringBuilder val_3 = Append(value:  val_5);
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < (21225312 << ));
            
            goto label_8;
            label_2:
            val_7 = "";
            goto label_9;
            label_3:
            label_8:
            val_7 = val_4;
            label_9:
            UnityEngine.PlayerPrefs.SetString(key:  key, value:  val_7);
        }
        public static System.Collections.Generic.List<int> GetInts(string key)
        {
            var val_9;
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  key);
            if((System.String.IsNullOrEmpty(value:  val_2)) == true)
            {
                    return (System.Collections.Generic.List<System.Int32>)new System.Collections.Generic.List<System.Int32>();
            }
            
            char[] val_4 = new char[1];
            val_4[0] = ',';
            int val_9 = val_5.Length;
            if(val_9 < 1)
            {
                    return (System.Collections.Generic.List<System.Int32>)new System.Collections.Generic.List<System.Int32>();
            }
            
            val_9 = 0;
            val_9 = val_9 & 4294967295;
            goto label_22;
            label_20:
            System.String[] val_10 = val_2.Split(separator:  val_4)[32];
            throw new NullReferenceException();
            label_22:
            if(null == null)
            {
                goto label_20;
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(item:  System.Int32.Parse(s:  1152921504841900880.Trim()));
            val_9 = val_9 + 1;
            if(val_9 < (val_5.Length << ))
            {
                goto label_22;
            }
            
            return (System.Collections.Generic.List<System.Int32>)new System.Collections.Generic.List<System.Int32>();
        }
        public static void SetLong(string key, long value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  key, value:  value.ToString());
        }
        public static long GetLong(string key)
        {
            return System.Convert.ToInt64(value:  UnityEngine.PlayerPrefs.GetString(key:  key));
        }
        public PlayerPrefsExtension()
        {
        
        }
    
    }

}
