using UnityEngine;
private sealed class LetterContent.<StartShowGuide>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Game.LetterContent <>4__this;
    public System.Action onComplet;
    public float duration;
    public float delay;
    private View.Game.LetterContent.<>c__DisplayClass49_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LetterContent.<StartShowGuide>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LetterContent.<>c__DisplayClass49_0 val_14;
        int val_15;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_16;
        }
        
        this.<>1__state = 0;
        object val_1 = null;
        val_14 = val_1;
        val_1 = new System.Object();
        this.<>8__1 = val_14;
        typeof(LetterContent.<>c__DisplayClass49_0).__il2cppRuntimeField_10 = this.<>4__this;
        this.<>8__1.onComplet = this.onComplet;
        this.<>4__this.InitGuidePath();
        val_15 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_1:
        this.<>1__state = 0;
        val_14 = View.Game.GameController.GetInstance();
        if(val_14 != 0)
        {
                View.Game.GameController val_4 = View.Game.GameController.GetInstance();
            if((val_4.<isGameComplete>k__BackingField) != true)
        {
                if((this.<>4__this.isDragging) == false)
        {
            goto label_13;
        }
        
        }
        
        }
        
        label_16:
        val_15 = 0;
        return (bool)val_15;
        label_13:
        if((this.<>4__this.canDraw) == false)
        {
            goto label_16;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector3[]> val_14 = this.<>4__this.guidePaths;
        if(val_14 == null)
        {
            goto label_16;
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
        this.<>4__this.guideTweener = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.<>4__this.handTransform, path:  this.<>4__this.guidePaths, duration:  val_15, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  1), delay:  this.delay), action:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void LetterContent.<>c__DisplayClass49_0::<StartShowGuide>b__0())), action:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void LetterContent.<>c__DisplayClass49_0::<StartShowGuide>b__1())), action:  new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  System.Void LetterContent.<>c__DisplayClass49_0::<StartShowGuide>b__2()));
        return (bool)val_15;
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
