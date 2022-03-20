using UnityEngine;

namespace Common
{
    public class StringLengthComparer : IComparer<string>
    {
        // Methods
        public int Compare(string x, string y)
        {
            if(x == null)
            {
                    return 0;
            }
            
            if(y == null)
            {
                    return 1;
            }
            
            int val_2 = x.m_stringLength;
            val_2 = val_2 - y.m_stringLength;
            return (int)() ? (val_2) : (0 + 1);
        }
        public StringLengthComparer()
        {
        
        }
    
    }

}
