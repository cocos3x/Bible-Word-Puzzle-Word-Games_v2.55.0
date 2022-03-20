using UnityEngine;
private sealed class AutoDestroy.<DestroyDelay>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public Common.AutoDestroy <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutoDestroy.<DestroyDelay>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_3;
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        val_4 = 1;
        this.<>2__current = val_3;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        val_3 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this.<onDestroy>k__BackingField) != null)
        {
                this.<>4__this.<onDestroy>k__BackingField.Invoke();
            this.<>4__this.<onDestroy>k__BackingField = 0;
        }
        
        Common.AutoDestroy val_2 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<Common.AutoDestroy>(obj:  val_3, isUi:  true);
        label_2:
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
