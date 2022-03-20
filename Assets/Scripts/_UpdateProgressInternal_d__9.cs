using UnityEngine;
private sealed class ChapterProgressBar.<UpdateProgressInternal>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int progress;
    public View.CommonItem.ChapterProgressBar <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ChapterProgressBar.<UpdateProgressInternal>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
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
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.6f);
        this.<>1__state = val_7;
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  (this.<>4__this._singleLength) * (float)this.progress, y:  this.<>4__this._singleLength);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOSizeDelta(target:  this.<>4__this.progressBar.rectTransform, endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  0.4f, snapping:  false);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.<>1__state = 2;
        val_7 = 1;
        return (bool)val_7;
        label_1:
        val_7 = 0;
        this.<>1__state = 0;
        return (bool)val_7;
        label_3:
        val_7 = 0;
        return (bool)val_7;
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
