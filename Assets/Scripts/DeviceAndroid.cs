using UnityEngine;
private class DeviceDefine.DeviceAndroid : DeviceDefine.IDeviceImpl
{
    // Fields
    private int _version;
    private Platform.Device.DeviceLevel _level;
    private bool _isLowAspectRatio;
    private bool _isNotch;
    private int _notchHeight;
    private bool _isTablet;
    
    // Methods
    public DeviceDefine.DeviceAndroid()
    {
        this.InitDeviceLevel();
        this.InitLowAspectRatio();
        Platform.Native.Android.AndroidNativeBridge.InitNotch(isNotch: ref  this._isNotch, height: ref  this._notchHeight);
        this.InitTablet();
        Platform.Native.Android.AndroidNativeBridge.InitVibrate();
    }
    private void InitDeviceLevel()
    {
        var val_6;
        Platform.Device.DeviceLevel val_7;
        int val_1 = Platform.Native.Android.AndroidNativeBridge.GetSDKVersion();
        this._version = val_1;
        if(val_1 >= 24)
        {
                val_6 = UnityEngine.Screen.width;
            if(val_6 > UnityEngine.Screen.height)
        {
                val_6 = UnityEngine.Screen.height;
        }
        
            var val_5 = (val_6 >= 720) ? (1 + 1) : 1;
        }
        else
        {
                val_7 = 1;
        }
        
        this._level = val_7;
    }
    private void InitLowAspectRatio()
    {
        var val_8;
        var val_9;
        if(UnityEngine.Screen.width > UnityEngine.Screen.height)
        {
                val_8 = UnityEngine.Screen.width;
            val_9 = 0;
            int val_4 = UnityEngine.Screen.height;
        }
        else
        {
                val_8 = UnityEngine.Screen.height;
            val_9 = 0;
        }
        
        float val_8 = (float)val_8;
        val_8 = val_8 / (float)UnityEngine.Screen.width;
        this._isLowAspectRatio = (val_8 < 0) ? 1 : 0;
    }
    private void InitNotch()
    {
        Platform.Native.Android.AndroidNativeBridge.InitNotch(isNotch: ref  this._isNotch, height: ref  this._notchHeight);
    }
    public bool IsNotchScreenImpl()
    {
        return (bool)this._isNotch;
    }
    public int GetNotchHeightImpl()
    {
        return (int)this._notchHeight;
    }
    private void InitTablet()
    {
        float val_8;
        int val_5 = UnityEngine.Screen.width * UnityEngine.Screen.width;
        val_5 = val_5 + (UnityEngine.Screen.height * UnityEngine.Screen.height);
        if(S8 >= _TYPE_MAX_)
        {
                val_8 = (float)val_5;
        }
        
        float val_6 = UnityEngine.Screen.dpi;
        val_6 = val_8 / val_6;
        this._isTablet = (val_6 >= 7f) ? 1 : 0;
    }
    public void QuitAppImpl()
    {
        Platform.Native.Android.AndroidNativeBridge.MoveTaskToBack();
    }
    private void InitVibrate()
    {
        Platform.Native.Android.AndroidNativeBridge.InitVibrate();
    }

}
