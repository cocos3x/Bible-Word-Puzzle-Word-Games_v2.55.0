using UnityEngine;
private sealed class LetterBox.<>c__DisplayClass66_0
{
    // Fields
    public View.CommonItem.LetterBox <>4__this;
    public float delay;
    public DG.Tweening.TweenCallback <>9__4;
    
    // Methods
    public LetterBox.<>c__DisplayClass66_0()
    {
    
    }
    internal void <PlayShow>b__0()
    {
        this.<>4__this.HideGiftBox(isPlay:  true);
        this.<>4__this.crossTransform.gameObject.SetActive(value:  false);
    }
    internal void <PlayShow>b__1()
    {
        this.<>4__this.blockTransform.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.6f);
        this.<>4__this.blockTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    internal void <PlayShow>b__2()
    {
        this.<>4__this.HideChrysalisBox();
        this.<>4__this.blockTransform.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.6f);
        this.<>4__this.blockTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = this.<>4__this.ChrysalisBox.transform.position;
        UnityEngine.Vector3 val_8 = this.<>4__this.transform.parent.localScale;
        Message.Messager.Dispatch<UnityEngine.Vector3, UnityEngine.Vector3>(cmd:  107, t:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, u:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
    }
    internal void <PlayShow>b__3()
    {
        DG.Tweening.TweenCallback val_8;
        if((this.<>4__this._isBonus) != false)
        {
                this.delay = this.<>4__this.bonusTime;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_8 = this.<>9__4;
            if(val_8 == null)
        {
                DG.Tweening.TweenCallback val_3 = null;
            val_8 = val_3;
            val_3 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void LetterBox.<>c__DisplayClass66_0::<PlayShow>b__4());
            this.<>9__4 = val_8;
        }
        
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.crossTransform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  this.delay), action:  val_8);
        }
        else
        {
                this.<>4__this.blockTransform.gameObject.SetActive(value:  true);
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.6f);
        this.<>4__this.blockTransform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    internal void <PlayShow>b__4()
    {
        this.<>4__this.blockTransform.gameObject.SetActive(value:  true);
    }

}
