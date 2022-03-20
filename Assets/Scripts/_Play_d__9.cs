using UnityEngine;
private sealed class RubbyStar.<Play>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonItem.RubbyStar <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RubbyStar.<Play>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.timeDelay = this.<>4__this.delay;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.image, endValue:  1f, duration:  this.<>4__this.time), loops:  2, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  System.Void View.CommonItem.RubbyStar::<Play>b__9_0()));
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.image.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  this.<>4__this.time), loops:  2, loopType:  1);
        label_4:
        UnityEngine.WaitForSeconds val_10 = null;
        float val_9 = (this.<>4__this.time) + (this.<>4__this.time);
        val_9 = (this.<>4__this.timeDelay) + val_9;
        val_10 = new UnityEngine.WaitForSeconds(seconds:  val_9);
        val_11 = 1;
        this.<>2__current = val_10;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_2:
        val_11 = 0;
        return (bool)val_11;
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
