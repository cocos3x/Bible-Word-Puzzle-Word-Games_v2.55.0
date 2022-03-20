using UnityEngine;

namespace Platform.Ad
{
    public class AdInitListener : IInitListener
    {
        // Fields
        private System.Action _onSuccess;
        private System.Action _onError;
        
        // Methods
        public AdInitListener(System.Action onSuccess, System.Action onError)
        {
            this._onSuccess = onSuccess;
            this._onError = onError;
        }
        public void OnSuccess()
        {
            if(this._onSuccess != null)
            {
                    this._onSuccess.Invoke();
            }
            
            this._onSuccess = 0;
        }
        public void OnError(ADSDKv3.Common.AdError adError)
        {
            var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "AdLoadConfig:OnError: "("AdLoadConfig:OnError: ") + adError, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            UnityEngine.Debug.LogError(message:  "AdLoadConfig:OnError: "("AdLoadConfig:OnError: ") + adError);
            if(this._onError != null)
            {
                    this._onError.Invoke();
            }
            
            this._onError = 0;
        }
    
    }

}
