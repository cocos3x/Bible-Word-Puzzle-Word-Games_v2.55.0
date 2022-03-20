using UnityEngine;
private sealed class HintButton.<UpdateState>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonItem.HintButton <>4__this;
    public float loopDelay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HintButton.<UpdateState>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) > 1)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus) < 1)
        {
            goto label_4;
        }
        
        if((this.<>4__this.state) == 1)
        {
            goto label_7;
        }
        
        this.<>4__this.state = 1;
        this.<>4__this.SetHintNum(num:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus);
        goto label_7;
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_4:
        this.<>4__this.UpdateNormalAndState();
        label_7:
        val_6 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.loopDelay);
        this.<>1__state = val_6;
        return (bool)val_6;
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
