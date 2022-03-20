using UnityEngine;
private sealed class DailyPrayerLetterContent.<StartShowGuide>d__48 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.DailyPrayer.DailyPrayerLetterContent <>4__this;
    public System.Action onComplet;
    public float duration;
    public float delay;
    private View.DailyPrayer.DailyPrayerLetterContent.<>c__DisplayClass48_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DailyPrayerLetterContent.<StartShowGuide>d__48(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_14;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_15;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(DailyPrayerLetterContent.<>c__DisplayClass48_0).__il2cppRuntimeField_10 = this.<>4__this;
        val_14 = 1;
        this.<>8__1.onComplet = this.onComplet;
        this.<>2__current = 0;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_1:
        this.<>1__state = 0;
        if(View.DailyPrayer.DailyPrayerController.GetInstance() != 0)
        {
                this.<>4__this.InitGuidePath();
            View.DailyPrayer.DailyPrayerController val_4 = View.DailyPrayer.DailyPrayerController.GetInstance();
            if((val_4.<isGameComplete>k__BackingField) != true)
        {
                if((this.<>4__this.isDragging) == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        label_15:
        val_14 = 0;
        return (bool)val_14;
        label_12:
        if((this.<>4__this.canDraw) == false)
        {
            goto label_15;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector3[]> val_14 = this.<>4__this._guidePaths;
        if(val_14 == null)
        {
            goto label_15;
        }
        
        this.<>4__this.handTransform.position = new UnityEngine.Vector3();
        if(val_14 == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_14 = val_14 - 1;
        float val_15 = (float)val_14;
        val_15 = this.duration * val_15;
        this.<>4__this._guideTweener = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.<>4__this.handTransform, path:  this.<>4__this._guidePaths, duration:  val_15, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  1), delay:  this.delay), action:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void DailyPrayerLetterContent.<>c__DisplayClass48_0::<StartShowGuide>b__0())), action:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void DailyPrayerLetterContent.<>c__DisplayClass48_0::<StartShowGuide>b__1())), action:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void DailyPrayerLetterContent.<>c__DisplayClass48_0::<StartShowGuide>b__2()));
        return (bool)val_14;
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
