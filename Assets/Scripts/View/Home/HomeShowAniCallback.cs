using UnityEngine;

namespace View.Home
{
    public class HomeShowAniCallback : MonoBehaviour
    {
        // Methods
        public void ShowHomeViewCallBack()
        {
            Message.Messager.Dispatch(cmd:  41);
        }
        public void HomeHideToGameCallBack()
        {
            Message.Messager.Dispatch(cmd:  42);
        }
        public void LoadingHideToGameCallback()
        {
            Message.Messager.Dispatch(cmd:  42);
        }
        public HomeShowAniCallback()
        {
        
        }
    
    }

}
