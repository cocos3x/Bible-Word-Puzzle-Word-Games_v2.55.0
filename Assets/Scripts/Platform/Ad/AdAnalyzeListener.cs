using UnityEngine;

namespace Platform.Ad
{
    public class AdAnalyzeListener : IEventListener
    {
        // Methods
        public void SendEvent(string eventName, System.Collections.Generic.Dictionary<string, object> dict)
        {
            UnityAnalytics.AnalyticsPlatform val_4;
            if((System.String.IsNullOrEmpty(value:  eventName)) != false)
            {
                    return;
            }
            
            if((eventName.StartsWith(value:  "grt")) != false)
            {
                    val_4 = 7;
            }
            else
            {
                    val_4 = 4;
            }
            
            Platform.Analytics.EzAnalytics.SendEvent(eventName:  eventName, args:  new System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Texture>(), platform:  val_4);
        }
        public void SetUserProperty(string key, string value)
        {
            Platform.Analytics.EzAnalytics.SetUserProperty(key:  key, value:  value, platform:  4);
        }
        public AdAnalyzeListener()
        {
        
        }
    
    }

}
