using UnityEngine;

namespace Platform.Native.Android
{
    public class AndroidNativeBridge
    {
        // Fields
        private static UnityEngine.AndroidJavaObject _androidVibrator;
        
        // Methods
        public static int GetSDKVersion()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build$VERSION");
            return GetStatic<System.Int32>(fieldName:  "SDK_INT");
        }
        public static void InitNotch(ref bool isNotch, ref int height)
        {
            var val_8;
            var val_9;
            val_8 = 1152921513097066496;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.meevii.soniclib.util.NotchUtils");
            object[] val_4 = new object[1];
            val_4[0] = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            bool val_5 = CallStatic<System.Boolean>(methodName:  "isNotch", args:  val_4);
            isNotch = val_5;
            if(val_5 == false)
            {
                    return;
            }
            
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            height = CallStatic<System.Int32>(methodName:  "getNotchSize", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void HideSplash()
        {
            var val_2;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.meevii.soniclib.UnitySplashSDK");
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            CallStatic(methodName:  "hideSplash", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void MoveTaskToBack()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            object[] val_3 = new object[1];
            val_3[0] = true;
            bool val_4 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<System.Boolean>(methodName:  "moveTaskToBack", args:  val_3);
        }
        public static void InitVibrate()
        {
            var val_6;
            if(Platform.Native.Android.AndroidNativeBridge._androidVibrator != null)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaClass val_3 = null;
            val_6 = val_3;
            val_3 = new UnityEngine.AndroidJavaClass(className:  "com.meevii.sudoku.vibration.Vibrate");
            object[] val_4 = new object[1];
            val_4[0] = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            Platform.Native.Android.AndroidNativeBridge._androidVibrator = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "newInstance", args:  val_4);
        }
    
    }

}
