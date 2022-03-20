using UnityEngine;
private sealed class ResultDailyLevelContent.<>c__DisplayClass21_0
{
    // Fields
    public View.Dialog.ResultDaily.ResultDailyLevelContent <>4__this;
    public System.Action callback;
    public DG.Tweening.TweenCallback <>9__1;
    
    // Methods
    public ResultDailyLevelContent.<>c__DisplayClass21_0()
    {
    
    }
    internal void <HideLevelContent>b__0()
    {
        DG.Tweening.TweenCallback val_4 = this.<>9__1;
        if(val_4 == null)
        {
                DG.Tweening.TweenCallback val_2 = null;
            val_4 = val_2;
            val_2 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void ResultDailyLevelContent.<>c__DisplayClass21_0::<HideLevelContent>b__1());
            this.<>9__1 = val_4;
        }
        
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.CanvasGroupContent, endValue:  0f, duration:  0.5f), action:  val_4);
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke();
    }
    internal void <HideLevelContent>b__1()
    {
        this.<>4__this.gameObject.SetActive(value:  false);
    }

}
