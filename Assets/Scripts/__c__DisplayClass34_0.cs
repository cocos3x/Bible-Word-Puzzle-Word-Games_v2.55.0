using UnityEngine;
private sealed class PersonalInfoDialog.<>c__DisplayClass34_0
{
    // Fields
    public System.Action onComplete;
    
    // Methods
    public PersonalInfoDialog.<>c__DisplayClass34_0()
    {
    
    }
    internal void <CloseAniFromActive>b__0()
    {
        if(this.onComplete == null)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }

}
