using UnityEngine;
private sealed class GameManager.<HideSplash>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameManager.<HideSplash>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        int val_2;
        if((this.<>1__state) == 0)
        {
            goto label_0;
        }
        
        val_1 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
                return (bool)val_1;
        }
        
        this.<>1__state = 0;
        Platform.Native.Android.AndroidNativeBridge.HideSplash();
        val_2 = 2;
        goto label_3;
        label_0:
        val_2 = 1;
        label_3:
        val_1 = 1;
        this.<>2__current = 0;
        goto label_4;
        label_1:
        val_2 = 0;
        label_4:
        this.<>1__state = val_2;
        return (bool)val_1;
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
