using UnityEngine;

namespace I2.Loc
{
    public class StringObfucator
    {
        // Fields
        public static char[] StringObfuscatorPassword;
        
        // Methods
        public static string Encode(string NormalString)
        {
            return (string)I2.Loc.StringObfucator.ToBase64(regularString:  I2.Loc.StringObfucator.XoREncode(NormalString:  NormalString));
        }
        public static string Decode(string ObfucatedString)
        {
            return (string)I2.Loc.StringObfucator.XoREncode(NormalString:  I2.Loc.StringObfucator.FromBase64(base64string:  ObfucatedString));
        }
        private static string ToBase64(string regularString)
        {
            return System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8);
        }
        private static string FromBase64(string base64string)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  base64string);
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_350;
        }
        private static string XoREncode(string NormalString)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_6 = null;
            if(NormalString == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7 = 0;
            System.Char[] val_1 = NormalString.ToCharArray();
            if(I2.Loc.StringObfucator.StringObfuscatorPassword == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_5 = val_1.Length;
            if(val_5 < 1)
            {
                    return (string)0.CreateString(val:  val_1);
            }
            
            val_5 = val_5 & 4294967295;
            var val_7 = 0;
            do
            {
                if(val_7 >= val_5)
            {
                    throw new IndexOutOfRangeException();
            }
            
                int val_2 = val_7 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length;
                val_2 = val_7 - (val_2 * I2.Loc.StringObfucator.StringObfuscatorPassword.Length);
                val_2 = I2.Loc.StringObfucator.StringObfuscatorPassword + (val_2 << 1);
                System.Char[] val_6 = (I2.Loc.StringObfucator.StringObfuscatorPassword + (0 - ((0 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length)) << 1) + 32;
                var val_3 = ((val_7 & 1) != 0) ? 23 : 50;
                val_3 = val_3 * val_7;
                val_3 = val_3 & 255;
                val_6 = val_6 ^ 1152921504842642960;
                val_6 = val_6 ^ val_3;
                mem2[0] = val_6;
                val_7 = val_7 + 1;
            }
            while(val_7 < (long)val_5);
            
            return (string)0.CreateString(val:  val_1);
        }
        private static StringObfucator()
        {
            I2.Loc.StringObfucator.StringObfuscatorPassword = ToCharArray();
        }
    
    }

}
