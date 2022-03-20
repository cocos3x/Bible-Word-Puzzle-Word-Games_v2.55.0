using UnityEngine;

namespace View.Dialog.Common
{
    public class FacebookButton : MonoBehaviour
    {
        // Fields
        public string openUrl;
        
        // Methods
        private void Awake()
        {
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            val_1.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Common.FacebookButton::<Awake>b__1_0()));
        }
        public FacebookButton()
        {
        
        }
        private void <Awake>b__1_0()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_prepare", action:  "a1_button_facebook_click", label:  "", value:  0);
            UnityEngine.Application.OpenURL(url:  this.openUrl);
        }
    
    }

}
