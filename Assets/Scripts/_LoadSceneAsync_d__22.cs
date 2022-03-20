using UnityEngine;
private sealed class GameScene.<LoadSceneAsync>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Logic.Game.GameScene <>4__this;
    public string name;
    public System.Action callBack;
    private float <time>5__2;
    private UnityEngine.AsyncOperation <async>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameScene.<LoadSceneAsync>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<time>5__2 = UnityEngine.Time.realtimeSinceStartup;
        this.<>4__this.DoClose();
        this.<>4__this.loadingScene = true;
        UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  this.name);
        val_6 = this;
        this.<async>5__3 = val_2;
        label_12:
        val_2.allowSceneActivation = false;
        goto label_10;
        label_1:
        val_6 = this;
        this.<>1__state = 0;
        if((this.<async>5__3.progress) < 0.9f)
        {
            goto label_10;
        }
        
        float val_4 = UnityEngine.Time.realtimeSinceStartup;
        val_4 = val_4 - (this.<time>5__2);
        if(val_4 <= 0.5f)
        {
            goto label_10;
        }
        
        goto label_12;
        label_10:
        if((this.<async>5__3.isDone) == false)
        {
            goto label_14;
        }
        
        if(this.callBack != null)
        {
                this.callBack.Invoke();
        }
        
        this.<>4__this.loadingScene = false;
        this.<>4__this.DoOpenCloud();
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_14:
        val_7 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_7;
        return (bool)val_7;
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
