using UnityEngine;

namespace Utils.Util.Comparer
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
            
            if()
            {
                    return System.String.CompareOrdinal(strA:  x, strB:  y);
            }
            
            return (int)x.m_stringLength - y.m_stringLength;
        }
        public StringLengthComparer()
        {
        
        }
    
    }

}
