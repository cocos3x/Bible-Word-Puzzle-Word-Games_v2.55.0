using UnityEngine;

namespace Utils.Util.Crypt
{
    public class RijndaelCryptUtil
    {
        // Fields
        private const string M_KEY = "meevii.game.file.key.tryyourbest";
        
        // Methods
        public static string Encrypt(string pString, string pKey = "")
        {
            return System.Convert.ToBase64String(inArray:  Utils.Util.Crypt.RijndaelCryptUtil.Encrypt(pByte:  System.Text.Encoding.UTF8, pKey:  pKey), offset:  0, length:  val_2.Length);
        }
        public static byte[] Encrypt(byte[] pByte, string pKey = "")
        {
            var val_3 = ((System.String.IsNullOrEmpty(value:  pKey)) != true) ? "meevii.game.file.key.tryyourbest" : pKey;
            return Utils.Util.Crypt.RijndaelCryptUtil.Encrypt(pByte:  pByte, pKey:  System.Text.Encoding.UTF8);
        }
        public static byte[] Encrypt(byte[] pByte, byte[] pKey)
        {
            System.Security.Cryptography.RijndaelManaged val_1 = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.RijndaelManaged val_4 = null;
            if((mem[null + 294]) == 0)
            {
                    return TransformFinalBlock(inputBuffer:  pByte, inputOffset:  0, inputCount:  pByte.Length);
            }
            
            var val_2 = mem[null + 176];
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_6:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (mem[null + 294]))
            {
                goto label_6;
            }
            
            return TransformFinalBlock(inputBuffer:  pByte, inputOffset:  0, inputCount:  pByte.Length);
            label_5:
            val_4 = val_4 + (((mem[null + 176] + 8)) << 4);
            return TransformFinalBlock(inputBuffer:  pByte, inputOffset:  0, inputCount:  pByte.Length);
        }
        public static string Decrypt(string pString, string pKey = "")
        {
            System.Byte[] val_2 = Utils.Util.Crypt.RijndaelCryptUtil.Decrypt(pByte:  System.Convert.FromBase64String(s:  pString), pKey:  pKey);
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_340;
        }
        public static byte[] Decrypt(byte[] pByte, string pKey = "")
        {
            var val_3 = ((System.String.IsNullOrEmpty(value:  pKey)) != true) ? "meevii.game.file.key.tryyourbest" : pKey;
            return Utils.Util.Crypt.RijndaelCryptUtil.Decrypt(pByte:  pByte, pKey:  System.Text.Encoding.UTF8);
        }
        public static byte[] Decrypt(byte[] pByte, byte[] pKey)
        {
            System.Security.Cryptography.RijndaelManaged val_1 = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.RijndaelManaged val_4 = null;
            if((mem[null + 294]) == 0)
            {
                    return TransformFinalBlock(inputBuffer:  pByte, inputOffset:  0, inputCount:  pByte.Length);
            }
            
            var val_2 = mem[null + 176];
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_6:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (mem[null + 294]))
            {
                goto label_6;
            }
            
            return TransformFinalBlock(inputBuffer:  pByte, inputOffset:  0, inputCount:  pByte.Length);
            label_5:
            val_4 = val_4 + (((mem[null + 176] + 8)) << 4);
            return TransformFinalBlock(inputBuffer:  pByte, inputOffset:  0, inputCount:  pByte.Length);
        }
        public RijndaelCryptUtil()
        {
        
        }
    
    }

}
