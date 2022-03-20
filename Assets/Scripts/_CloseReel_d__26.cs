using UnityEngine;
private sealed class ResultDailyBibleContent.<CloseReel>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Dialog.ResultDaily.ResultDailyBibleContent <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ResultDailyBibleContent.<CloseReel>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_2:
        this.<>1__state = 0;
        Message.Messager.Dispatch(cmd:  81);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = 2;
        val_4 = 1;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.gameObject.SetActive(value:  false);
        label_3:
        val_4 = 0;
        return (bool)val_4;
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
