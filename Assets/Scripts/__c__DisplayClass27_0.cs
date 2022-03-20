using UnityEngine;
private sealed class Dialog.<>c__DisplayClass27_0
{
    // Fields
    public System.Action onComplete;
    
    // Methods
    public Dialog.<>c__DisplayClass27_0()
    {
    
    }
    internal void <DoContentAnimation>b__0()
    {
        if(this.onComplete == null)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }

}
