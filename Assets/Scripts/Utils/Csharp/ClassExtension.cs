using UnityEngine;

namespace Utils.Csharp
{
    public static class ClassExtension
    {
        // Methods
        public static bool IsNull<T>(T self)
        {
            return (bool)(self == 0) ? 1 : 0;
        }
        public static bool IsNotNull<T>(T self)
        {
            return (bool)(self != 0) ? 1 : 0;
        }
    
    }

}
