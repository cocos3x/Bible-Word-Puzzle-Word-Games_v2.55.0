using UnityEngine;
private sealed class HintEffect.<>c__DisplayClass1_0
{
    // Fields
    public System.Action onComplete;
    public View.CommonEffect.HintEffect <>4__this;
    
    // Methods
    public HintEffect.<>c__DisplayClass1_0()
    {
    
    }
    internal void <Play>b__0()
    {
        if(this.onComplete == null)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }
    internal void <Play>b__1()
    {
        View.CommonEffect.HintEffect val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.CommonEffect.HintEffect>(obj:  this.<>4__this, isUi:  true);
    }

}
