using UnityEngine;

namespace Utils.Util
{
    public class MD5Util
    {
        // Methods
        public static string GetStringMD5(string target)
        {
            var val_2 = (target == null) ? "" : target;
            return Utils.Util.MD5Util.GetBytesMD5(bytes:  System.Text.Encoding.UTF8);
        }
        public static string GetBytesMD5(byte[] bytes)
        {
            string val_7;
            System.Security.Cryptography.MD5CryptoServiceProvider val_1 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            val_7 = 0;
            null = new System.Text.StringBuilder();
            int val_7 = val_2.Length;
            if(val_7 >= 1)
            {
                    var val_8 = 0;
                val_7 = val_7 & 4294967295;
                do
            {
                val_7 = ComputeHash(buffer:  bytes)[32][val_8].ToString(format:  "X").PadLeft(totalWidth:  2, paddingChar:  '0');
                System.Text.StringBuilder val_6 = Append(value:  val_7);
                val_8 = val_8 + 1;
            }
            while(val_8 < (val_2.Length << ));
            
            }
        
        }
        public MD5Util()
        {
        
        }
    
    }

}
