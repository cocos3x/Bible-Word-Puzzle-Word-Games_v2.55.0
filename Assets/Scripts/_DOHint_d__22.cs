using UnityEngine;
private sealed class HintButton.<DOHint>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonItem.HintButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HintButton.<DOHint>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return false;
        }
        
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 - (this.<>4__this.<time>k__BackingField);
            if(val_1 > 10f)
        {
                this.<>4__this.Light();
        }
        
        }
        
        if(View.Game.GameController.GetInstance() == 0)
        {
                return false;
        }
        
        View.Game.GameController val_4 = View.Game.GameController.GetInstance();
        if((val_4.<isGameComplete>k__BackingField) != false)
        {
                return false;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  5f);
        this.<>1__state = 1;
        return false;
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
