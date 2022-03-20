using UnityEngine;
private class PrivacyPolicyAndroidImpl.DialogListener : AndroidJavaProxy
{
    // Fields
    private const string JavaClassName = "com.beatles.localdialog.OnAcceptCallback";
    private System.Action _callback;
    
    // Methods
    public PrivacyPolicyAndroidImpl.DialogListener(System.Action callback)
    {
        this._callback = callback;
    }
    public void onAccept()
    {
        if(this._callback == null)
        {
                return;
        }
        
        this._callback.Invoke();
    }

}
