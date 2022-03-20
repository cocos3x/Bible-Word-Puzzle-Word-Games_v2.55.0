using UnityEngine;
private sealed class LocalizationManager.<Coroutine_LocalizeAll>d__86 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LocalizationManager.<Coroutine_LocalizeAll>d__86(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        var val_2;
        bool val_3;
        var val_4;
        val_1 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_2 = null;
        val_2 = null;
        val_3 = true;
        I2.Loc.LocalizationManager.mLocalizeIsScheduled = val_3;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        val_1 = 1152921504834908160;
        val_4 = null;
        val_4 = null;
        I2.Loc.LocalizationManager.mLocalizeIsScheduled = false;
        I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = false;
        I2.Loc.LocalizationManager.DoLocalizeAll(Force:  I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue);
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
