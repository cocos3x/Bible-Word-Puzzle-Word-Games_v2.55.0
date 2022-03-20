using UnityEngine;
private sealed class ProgressBar.<WaitUpdateProgress>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonItem.ProgressBar <>4__this;
    public float progress;
    private View.CommonItem.ProgressBar.<>c__DisplayClass15_0 <>8__1;
    public float time;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProgressBar.<WaitUpdateProgress>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ProgressBar.<>c__DisplayClass15_0 val_15;
        int val_16;
        UnityEngine.UI.Image val_17;
        ProgressBar.<>c__DisplayClass15_0 val_19;
        float val_20;
        ProgressBar.<>c__DisplayClass15_0 val_21;
        val_15 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_24;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new ProgressBar.<>c__DisplayClass15_0();
        typeof(ProgressBar.<>c__DisplayClass15_0).__il2cppRuntimeField_10 = this.<>4__this;
        this.<>8__1.progress = this.progress;
        this.<>2__current = 0;
        val_16 = 1;
        this.<>1__state = val_16;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        val_17 = this.<>4__this.image;
        if(val_17 != 0)
        {
            goto label_9;
        }
        
        UnityEngine.Debug.LogError(message:  "Progress bar image object is null");
        goto label_24;
        label_9:
        if((this.<>4__this.width) <= 0f)
        {
                UnityEngine.Rect val_4 = this.<>4__this.transform.rect;
            UnityEngine.Vector2 val_5 = val_4.m_XMin.size;
            val_5.x = val_5.x - ((float)this.<>4__this.dtWidth);
            this.<>4__this.width = val_5.x;
        }
        
        this.<>8__1.progress = UnityEngine.Mathf.Min(a:  this.<>8__1.progress, b:  1f);
        val_19 = this.<>8__1;
        val_20 = (this.<>8__1.progress) * (this.<>4__this.width);
        if(val_20 >= 0)
        {
                if((val_20 != 0f) || (((this.<>4__this.contentMinWidth) & 2147483648) == 0))
        {
            goto label_22;
        }
        
        }
        
        val_20 = (float)this.<>4__this.contentMinWidth;
        label_22:
        if((this.<>4__this.canReduce) == true)
        {
            goto label_23;
        }
        
        float val_7 = this.<>4__this.GetCurrentWidth();
        if(val_20 < 0)
        {
            goto label_24;
        }
        
        val_21 = this.<>8__1;
        label_23:
        val_15 = this.<>8__1;
        DG.Tweening.TweenCallback val_12 = null;
        val_17 = val_12;
        val_12 = new DG.Tweening.TweenCallback(object:  val_15, method:  System.Void ProgressBar.<>c__DisplayClass15_0::<WaitUpdateProgress>b__2());
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_21, method:  System.Single ProgressBar.<>c__DisplayClass15_0::<WaitUpdateProgress>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  System.Void ProgressBar.<>c__DisplayClass15_0::<WaitUpdateProgress>b__1(float width)), endValue:  val_20, duration:  this.time), ease:  1), action:  val_17);
        label_24:
        val_16 = 0;
        return (bool)val_16;
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
