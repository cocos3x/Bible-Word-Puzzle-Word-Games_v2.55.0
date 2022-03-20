using UnityEngine;
private sealed class ResultDailyBibleContent.<PlayItemAni>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Dialog.ResultDaily.ResultDailyBibleContent <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ResultDailyBibleContent.<PlayItemAni>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_5;
        int val_18;
        var val_20;
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
        val_18 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_18;
        return (bool)val_18;
        label_2:
        this.<>1__state = 0;
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
        {
                Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_scroll_light", volumeScale:  1f, loop:  false, delay:  0f);
        }
        
        this.<>4__this.EffectVersesLight.SetActive(value:  true);
        List.Enumerator<T> val_3 = this.<>4__this._referenceItems.GetEnumerator();
        label_15:
        val_20 = public System.Boolean List.Enumerator<View.CommonItem.ResultBibleTextItem>::MoveNext();
        if(val_5.MoveNext() == false)
        {
            goto label_12;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_20 = 0;
        UnityEngine.Transform val_7 = val_4.transform;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_8 = val_7.position;
        val_4.Show(startPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        goto label_15;
        label_1:
        this.<>1__state = 0;
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
        {
                Logic.Game.GameManager.gameSound.Play(clipName:  "verse_completed_music", volumeScale:  1f, loop:  false, delay:  0f);
        }
        
        this.<>4__this.ButtonCollect.gameObject.SetActive(value:  true);
        this.<>4__this.AnimatorBible.Play(stateName:  "ResultBibleContentShow");
        label_3:
        val_18 = 0;
        return (bool)val_18;
        label_12:
        val_5.Dispose();
        List.Enumerator<T> val_11 = this.<>4__this._allContentTextItems.GetEnumerator();
        label_29:
        val_20 = public System.Boolean List.Enumerator<View.CommonItem.ResultBibleTextItem>::MoveNext();
        if(val_5.MoveNext() == false)
        {
            goto label_26;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_20 = 0;
        UnityEngine.Transform val_13 = val_4.transform;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_14 = val_13.position;
        val_4.Show(startPosition:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        goto label_29;
        label_26:
        val_5.Dispose();
        View.CommonItem.ResultBibleTextItem.DoTextAnim(callback:  0);
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
        {
                Logic.Game.GameManager.gameSound.Play(clipName:  "verse_completed", volumeScale:  1f, loop:  false, delay:  0f);
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = 2;
        val_18 = 1;
        return (bool)val_18;
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
