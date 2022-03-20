using UnityEngine;

namespace Platform.Native.Android
{
    public class AndroidNative
    {
        // Methods
        public static int GetSystemVersion()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build$VERSION");
            return GetStatic<System.Int32>(fieldName:  "SDK_INT");
        }
    
    }

}
