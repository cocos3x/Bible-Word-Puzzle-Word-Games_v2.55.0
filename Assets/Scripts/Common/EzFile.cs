using UnityEngine;

namespace Common
{
    public class EzFile
    {
        // Methods
        public static string RijndaelDecrypt(string pString, string pKey = "")
        {
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            var val_3 = ((System.String.IsNullOrEmpty(value:  pKey)) != true) ? "meevii.game.file.key.tryyourbest" : pKey;
            System.Security.Cryptography.RijndaelManaged val_5 = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.RijndaelManaged val_10 = null;
            if((mem[null + 294]) == 0)
            {
                goto label_10;
            }
            
            var val_8 = mem[null + 176];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_9:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (mem[null + 294]))
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            val_10 = val_10 + (((mem[null + 176] + 8)) << 4);
            label_10:
            System.Byte[] val_6 = TransformFinalBlock(inputBuffer:  System.Convert.FromBase64String(s:  pString), inputOffset:  0, inputCount:  val_4.Length);
            System.Text.Encoding val_7 = System.Text.Encoding.UTF8;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_340;
        }
    
    }

}
