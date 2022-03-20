using UnityEngine;
private sealed class LanguageSourceData.<Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public I2.Loc.LanguageSourceData <>4__this;
    public bool JustCheck;
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LanguageSourceData.<Import_Google_Coroutine>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        UnityEngine.Networking.UnityWebRequest val_14;
        string val_15;
        int val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_35;
        }
        
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_1 = this.<>4__this.Import_Google_CreateWWWcall(ForceUpdate:  false, justCheck:  false);
        val_13 = this;
        this.<www>5__2 = val_1;
        if(val_1 != null)
        {
            goto label_4;
        }
        
        return (bool)val_16;
        label_1:
        val_13 = this;
        val_14 = this.<www>5__2;
        this.<>1__state = 0;
        label_4:
        if(val_14.isDone == false)
        {
            goto label_7;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.<www>5__2.error)) == false)
        {
            goto label_9;
        }
        
        System.Byte[] val_6 = this.<www>5__2.downloadHandler.data;
        System.Text.Encoding val_7 = System.Text.Encoding.UTF8;
        if((System.String.IsNullOrEmpty(value:  val_7)) == false)
        {
            goto label_14;
        }
        
        val_15 = 1;
        goto label_15;
        label_7:
        val_16 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_16;
        return (bool)val_16;
        label_14:
        val_15 = val_7;
        bool val_9 = System.String.op_Equality(a:  val_15, b:  "\"\"");
        label_15:
        if(this.JustCheck == false)
        {
            goto label_17;
        }
        
        if(val_9 == true)
        {
            goto label_35;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Spreadsheet is not up-to-date and Google Live Synchronization is enabled\nWhen playing in the device the Spreadsheet will be downloaded and translations may not behave as what you see in the editor.\nTo fix this, Import or Export replace to Google");
        val_16 = 0;
        this.<>4__this.GoogleLiveSyncIsUptoDate = false;
        return (bool)val_16;
        label_17:
        if(val_9 == false)
        {
            goto label_23;
        }
        
        label_9:
        if((this.<>4__this.Event_OnSourceUpdateFromGoogle) != null)
        {
                this.<>4__this.Event_OnSourceUpdateFromGoogle.Invoke(source:  this.<>4__this, ReceivedNewData:  false, errorMsg:  this.<www>5__2.error);
        }
        
        UnityEngine.Debug.Log(message:  "Language Source was up-to-date with Google Spreadsheet");
        label_35:
        val_16 = 0;
        return (bool)val_16;
        label_23:
        this.<>4__this.mDelayedGoogleData = val_7;
        if((this.<>4__this.GoogleUpdateSynchronization) == 1)
        {
            goto label_30;
        }
        
        if((this.<>4__this.GoogleUpdateSynchronization) != 2)
        {
            goto label_35;
        }
        
        this.<>4__this.ApplyDownloadedDataFromGoogle();
        goto label_35;
        label_30:
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this.<>4__this, method:  System.Void I2.Loc.LanguageSourceData::ApplyDownloadedDataOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        goto label_35;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
