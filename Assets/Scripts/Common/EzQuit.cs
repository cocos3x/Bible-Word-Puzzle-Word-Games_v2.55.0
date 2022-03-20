using UnityEngine;

namespace Common
{
    public class EzQuit
    {
        // Methods
        public static void Quit()
        {
            UnityEngine.PlayerPrefs.Save();
            Platform.Device.DeviceDefine.QuitApp();
        }
    
    }

}
