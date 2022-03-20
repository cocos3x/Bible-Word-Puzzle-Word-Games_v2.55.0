using UnityEngine;

namespace Platform.Luid
{
    public class GameLuidManager
    {
        // Fields
        private static Platform.Luid.GameLuidManager <Instance>k__BackingField;
        private static string <Luid>k__BackingField;
        private string _luid;
        private System.Action<string> _luidCallback;
        
        // Properties
        public static Platform.Luid.GameLuidManager Instance { get; set; }
        public static string Luid { get; set; }
        
        // Methods
        public static Platform.Luid.GameLuidManager get_Instance()
        {
            return (Platform.Luid.GameLuidManager)Platform.Luid.GameLuidManager.<Instance>k__BackingField;
        }
        private static void set_Instance(Platform.Luid.GameLuidManager value)
        {
            Platform.Luid.GameLuidManager.<Instance>k__BackingField = value;
        }
        public static void Create(bool isDebug)
        {
            Platform.Luid.GameLuidManager.<Instance>k__BackingField = new Platform.Luid.GameLuidManager();
            Init(isDebug:  isDebug);
        }
        public static string get_Luid()
        {
            return (string)Platform.Luid.GameLuidManager.<Luid>k__BackingField;
        }
        private static void set_Luid(string value)
        {
            Platform.Luid.GameLuidManager.<Luid>k__BackingField = value;
        }
        private void add__luidCallback(System.Action<string> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this._luidCallback, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this._luidCallback != 1152921513098139272);
            
            return;
            label_2:
        }
        private void remove__luidCallback(System.Action<string> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this._luidCallback, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this._luidCallback != 1152921513098275848);
            
            return;
            label_2:
        }
        private GameLuidManager()
        {
            this._luid = System.String.alignConst;
        }
        private void Init(bool isDebug)
        {
            Platform.Luid.GameLuidManager.<Luid>k__BackingField = UnityEngine.PlayerPrefs.GetString(key:  "game_luid", defaultValue:  "");
            Luid.LuidSettings val_2 = new Luid.LuidSettings();
            Luid.LuidManager.Init(settings:  SetDebug(isDebug:  isDebug));
            Luid.LuidManager.Generate(onGenerate:  new System.Action<System.String>(object:  this, method:  System.Void Platform.Luid.GameLuidManager::SetLuid(string luid)));
        }
        private void SetLuid(string luid)
        {
            string val_3 = luid;
            if((System.String.op_Inequality(a:  Platform.Luid.GameLuidManager.<Luid>k__BackingField, b:  val_3 = luid)) != false)
            {
                    Platform.Luid.GameLuidManager.<Luid>k__BackingField = val_3;
                UnityEngine.PlayerPrefs.SetString(key:  "game_luid", value:  val_3);
            }
            
            this._luid = val_3;
            if(this._luidCallback != null)
            {
                    this._luidCallback.Invoke(obj:  val_3);
                val_3 = this._luid;
            }
            
            this._luidCallback = 0;
            UnityEngine.Debug.Log(message:  "[GameLuidManager] Luid callback, id is " + val_3);
        }
        public void GetLuid(System.Action<string> callback)
        {
            if((System.String.IsNullOrEmpty(value:  this._luid)) != false)
            {
                    this.add__luidCallback(value:  callback);
                return;
            }
            
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  this._luid);
        }
        public string GetUuid()
        {
            return (string)Luid.LuidManager._currentUuid;
        }
    
    }

}
