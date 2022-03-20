using UnityEngine;
private sealed class ProgressBar.<>c__DisplayClass15_0
{
    // Fields
    public View.CommonItem.ProgressBar <>4__this;
    public float progress;
    
    // Methods
    public ProgressBar.<>c__DisplayClass15_0()
    {
    
    }
    internal float <WaitUpdateProgress>b__0()
    {
        if((this.<>4__this) != null)
        {
                return this.<>4__this.GetCurrentWidth();
        }
        
        throw new NullReferenceException();
    }
    internal void <WaitUpdateProgress>b__1(float width)
    {
        if((this.<>4__this) != null)
        {
                this.<>4__this.SetCurrentWidth(width:  width);
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <WaitUpdateProgress>b__2()
    {
        if(this.progress != 1f)
        {
                return;
        }
        
        if((this.<>4__this) != null)
        {
                if((this.<>4__this.onProgressComplete) == null)
        {
                return;
        }
        
            this.<>4__this.onProgressComplete.Invoke();
            return;
        }
        
        throw new NullReferenceException();
    }

}
