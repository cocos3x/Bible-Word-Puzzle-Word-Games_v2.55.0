using UnityEngine;

namespace Common
{
    public class EzRate
    {
        // Methods
        public static void RateGame()
        {
            UnityEngine.Application.OpenURL(url:  "market://details?id="("market://details?id=") + UnityEngine.Application.identifier);
        }
        public static void Feedback(string text, int star, string levelName)
        {
            AddField(fieldName:  "app", value:  UnityEngine.Application.identifier);
            AddField(fieldName:  "feedback", value:  text + " --- "(" --- ") + levelName);
            if(star >= 1)
            {
                    AddField(fieldName:  "star", i:  star);
            }
            
            AddField(fieldName:  "version", value:  UnityEngine.Application.version);
            System.DateTime val_5 = System.DateTime.Today;
            AddField(fieldName:  "today", value:  val_5.dateData.ToString(format:  "yyyyMMdd"));
            AddField(fieldName:  "device_brand", value:  UnityEngine.SystemInfo.deviceModel);
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_9 = UnityEngine.Networking.UnityWebRequest.Post(uri:  "http://matrix.dailyinnovation.biz/feedback", formData:  new UnityEngine.WWWForm()).SendWebRequest();
        }
    
    }

}
