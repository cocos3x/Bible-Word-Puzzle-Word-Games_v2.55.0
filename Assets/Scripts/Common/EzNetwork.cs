using UnityEngine;

namespace Common
{
    public class EzNetwork
    {
        // Methods
        public static bool IsNetworkAvailable()
        {
            return (bool)(UnityEngine.Application.internetReachability != 0) ? 1 : 0;
        }
    
    }

}
