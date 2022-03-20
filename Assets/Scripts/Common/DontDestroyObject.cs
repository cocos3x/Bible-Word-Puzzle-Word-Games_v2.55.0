using UnityEngine;

namespace Common
{
    public class DontDestroyObject : MonoBehaviour
    {
        // Fields
        public bool useNew;
        public string hashName;
        private static System.Collections.Generic.Dictionary<string, Common.DontDestroyObject> instanceMap;
        
        // Methods
        private void Awake()
        {
            System.Collections.Generic.Dictionary<System.String, Common.DontDestroyObject> val_9;
            if((System.String.IsNullOrEmpty(value:  this.hashName)) != false)
            {
                    this.hashName = this.name;
            }
            
            val_9 = Common.DontDestroyObject.instanceMap;
            if(val_9 == null)
            {
                    Common.DontDestroyObject.instanceMap = new System.Collections.Generic.Dictionary<System.String, Common.DontDestroyObject>();
                val_9 = Common.DontDestroyObject.instanceMap;
            }
            
            if((ContainsKey(key:  this.hashName)) == false)
            {
                goto label_4;
            }
            
            if(this.useNew == false)
            {
                goto label_5;
            }
            
            UnityEngine.Object.Destroy(obj:  Item[this.hashName].gameObject);
            set_Item(key:  this.hashName, value:  this);
            return;
            label_4:
            Add(key:  this.hashName, value:  this);
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            return;
            label_5:
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public void InitiativeDestroy()
        {
            if(Common.DontDestroyObject.instanceMap == null)
            {
                    return;
            }
            
            if((Common.DontDestroyObject.instanceMap.ContainsKey(key:  this.hashName)) == false)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  Common.DontDestroyObject.instanceMap.Item[this.hashName].gameObject);
            bool val_4 = Common.DontDestroyObject.instanceMap.Remove(key:  this.hashName);
        }
        private void OnDestroy()
        {
            if((System.String.IsNullOrEmpty(value:  this.hashName)) == true)
            {
                    return;
            }
            
            if((Common.DontDestroyObject.instanceMap.ContainsKey(key:  this.hashName)) == false)
            {
                    return;
            }
            
            bool val_3 = Common.DontDestroyObject.instanceMap.Remove(key:  this.hashName);
        }
        public DontDestroyObject()
        {
        
        }
    
    }

}
