using UnityEngine;

namespace Platform.Device
{
    public static class DeviceDefine
    {
        // Fields
        private static Platform.Device.DeviceDefine.IDeviceImpl _deviceImpl;
        
        // Methods
        public static void Init()
        {
            Platform.Device.DeviceDefine._deviceImpl = new DeviceDefine.DeviceAndroid();
        }
        public static bool IsNotchScreen()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Platform.Device.DeviceDefine._deviceImpl.IsNotchScreenImpl();
        }
        public static int GetNotchHeight()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Platform.Device.DeviceDefine._deviceImpl.GetNotchHeightImpl();
        }
        public static void QuitApp()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            Platform.Device.DeviceDefine._deviceImpl.QuitAppImpl();
        }
    
    }

}
