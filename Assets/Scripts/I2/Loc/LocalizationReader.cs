using UnityEngine;

namespace I2.Loc
{
    public class LocalizationReader
    {
        // Methods
        public static System.Collections.Generic.List<string[]> ReadI2CSV(string Text)
        {
            string[] val_1 = new string[1];
            val_1[0] = "[*]";
            string[] val_2 = new string[1];
            val_2[0] = "[ln]";
            if(val_4.Length < 1)
            {
                    return (System.Collections.Generic.List<System.String[]>)new System.Collections.Generic.List<System.String[]>();
            }
            
            var val_7 = 0;
            do
            {
                Add(item:  Text.Split(separator:  val_2, options:  0)[val_7].Split(separator:  val_1, options:  0));
                val_7 = val_7 + 1;
            }
            while(val_7 < val_4.Length);
            
            return (System.Collections.Generic.List<System.String[]>)new System.Collections.Generic.List<System.String[]>();
        }
    
    }

}
