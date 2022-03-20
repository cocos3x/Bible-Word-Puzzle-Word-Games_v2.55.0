using UnityEngine;
private sealed class LoadingItem.<PlayAni>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonItem.LoadingItem <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingItem.<PlayAni>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) < 2)
        {
                this.<>1__state = 0;
            if((this.<>4__this._pointIndex) < (this.<>4__this.Points.Length))
        {
                this.<>4__this.Points[this.<>4__this._pointIndex].PlayAni();
            int val_4 = this.<>4__this._pointIndex;
            val_4 = val_4 + 1;
            this.<>4__this._pointIndex = val_4;
            val_4 = val_4 - ((val_4 / (this.<>4__this.Points.Length)) * (this.<>4__this.Points.Length));
            this.<>4__this._pointIndex = val_4;
            val_3 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.16f);
            this.<>1__state = val_3;
            return (bool)val_3;
        }
        
        }
        
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
