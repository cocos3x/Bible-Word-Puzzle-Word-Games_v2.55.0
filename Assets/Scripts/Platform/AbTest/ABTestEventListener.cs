using UnityEngine;

namespace Platform.AbTest
{
    public class ABTestEventListener : IABTestEventListener
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, object> _eventDict;
        
        // Methods
        public void SendEvent(string name, System.Collections.Generic.Dictionary<string, string> bundle)
        {
            this._eventDict.Clear();
            Dictionary.Enumerator<TKey, TValue> val_1 = bundle.GetEnumerator();
            label_5:
            if(0.MoveNext() == false)
            {
                goto label_3;
            }
            
            if(this._eventDict == null)
            {
                    throw new NullReferenceException();
            }
            
            this._eventDict.Add(key:  0, value:  0);
            goto label_5;
            label_3:
            0.Dispose();
            Platform.Analytics.EzAnalytics.SendEvent(eventName:  name, args:  this._eventDict, platform:  4);
        }
        public void SetUserProperty(string key, string value)
        {
            Platform.Analytics.EzAnalytics.SetUserProperty(key:  key, value:  value, platform:  4);
        }
        public ABTestEventListener()
        {
            this._eventDict = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
    
    }

}
