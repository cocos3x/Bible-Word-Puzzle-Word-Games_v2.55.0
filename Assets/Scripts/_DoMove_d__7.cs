using UnityEngine;
private sealed class MoveEffect.<DoMove>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonEffect.MoveEffect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoveEffect.<DoMove>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        View.CommonEffect.MoveEffect val_27;
        int val_28;
        UnityEngine.Vector3[] val_34;
        float val_35;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_28 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_28;
        return (bool)val_28;
        label_1:
        val_27 = this.<>4__this;
        this.<>1__state = 0;
        UnityEngine.Rect val_4 = (null == null) ? val_27.transform.parent : 0.rect;
        UnityEngine.Vector2 val_5 = val_4.m_XMin.size;
        val_5.x = val_5.x * 0.5f;
        float val_6 = val_5.x + (-20f);
        UnityEngine.Vector3[] val_7 = new UnityEngine.Vector3[4];
        this.<>4__this.paths = val_7;
        if(((this.<>4__this.index) & 1) != 0)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  -val_6, y:  val_6);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        val_7[0] = val_9;
        val_7[0] = val_9.y;
        val_7[1] = val_9.z;
        UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  -val_6, y:  -val_6);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        this.<>4__this.paths[1] = val_11;
        this.<>4__this.paths[1] = val_11.y;
        this.<>4__this.paths[1] = val_11.z;
        UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_6, y:  -val_6);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        this.<>4__this.paths[2] = val_13;
        this.<>4__this.paths[2] = val_13.y;
        this.<>4__this.paths[2] = val_13.z;
        val_34 = this.<>4__this.paths;
        val_35 = val_6;
        goto label_17;
        label_2:
        val_28 = 0;
        return (bool)val_28;
        label_8:
        UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_6, y:  -val_6);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        val_7[0] = val_15;
        val_7[0] = val_15.y;
        val_7[1] = val_15.z;
        UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_6, y:  val_6);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        this.<>4__this.paths[1] = val_17;
        this.<>4__this.paths[1] = val_17.y;
        this.<>4__this.paths[1] = val_17.z;
        UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  -val_6, y:  val_6);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        this.<>4__this.paths[2] = val_19;
        this.<>4__this.paths[2] = val_19.y;
        this.<>4__this.paths[2] = val_19.z;
        val_34 = this.<>4__this.paths;
        val_35 = -val_6;
        label_17:
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  -val_6, y:  val_35);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = this.<>4__this.offset, y = V10.16B, z = V11.16B});
        val_34[3] = val_21;
        val_34[3] = val_21.y;
        val_34[3] = val_21.z;
        val_27.transform.localPosition = new UnityEngine.Vector3() {x = this.<>4__this.paths[3], y = this.<>4__this.paths[3], z = this.<>4__this.paths[3]};
        val_28 = 0;
        this.<>4__this.tween = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalPath(target:  val_27.transform, path:  this.<>4__this.paths, duration:  2f, pathType:  1, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  1), loops:  0);
        return (bool)val_28;
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
