using UnityEngine;
private sealed class Fireworks.<PlayFlyAnim>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.CommonItem.Fireworks <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Fireworks.<PlayFlyAnim>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_8;
        int val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() == false)
        {
            goto label_6;
        }
        
        val_8 = "eff_firework";
        goto label_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.effect.SetActive(value:  true);
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
        {
                Logic.Game.GameManager.gameSound.Play(clipName:  "hint_rocket_explode", volumeScale:  1f, loop:  false, delay:  0f);
        }
        
        Message.Messager.Dispatch(cmd:  100);
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_6:
        val_8 = "hint_rocket_launch";
        label_7:
        Logic.Game.GameManager.gameSound.Play(clipName:  val_8, volumeScale:  1f, loop:  false, delay:  0f);
        this.<>4__this.flyLine.SetTrigger(name:  "play");
        int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this.<>4__this, complete:  false);
        UnityEngine.Vector3 val_4 = this.<>4__this.endTransform.position;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.fireWorkTransform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.75f, snapping:  false), id:  this.<>4__this);
        val_9 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.lineFlyTime);
        this.<>1__state = val_9;
        return (bool)val_9;
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
