using UnityEngine;
private sealed class ResultBibleContent.<PlayItemAni>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Dialog.Result.ResultBibleContent <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ResultBibleContent.<PlayItemAni>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        var val_8;
        int val_19;
        int val_20;
        var val_22;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_18 = 15448236 + (this.<>1__state) << 2;
        val_18 = val_18 + 15448236;
        goto (15448236 + (this.<>1__state) << 2 + 15448236);
        label_1:
        val_19 = 0;
        return (bool)val_19;
        label_27:
        val_22 = public System.Boolean List.Enumerator<View.CommonItem.ResultBibleTextItem>::MoveNext();
        if(val_8.MoveNext() == false)
        {
            goto label_24;
        }
        
        if(val_7 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_22 = 0;
        UnityEngine.Transform val_10 = val_7.transform;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_11 = val_10.position;
        val_7.Show(startPosition:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        goto label_27;
        label_24:
        val_8.Dispose();
        List.Enumerator<T> val_12 = this.<>4__this._allContentTextItems.GetEnumerator();
        label_32:
        val_22 = public System.Boolean List.Enumerator<View.CommonItem.ResultBibleTextItem>::MoveNext();
        if(val_8.MoveNext() == false)
        {
            goto label_29;
        }
        
        if(val_7 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_22 = 0;
        UnityEngine.Transform val_14 = val_7.transform;
        if(val_14 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_15 = val_14.position;
        val_7.Show(startPosition:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        goto label_32;
        label_29:
        val_8.Dispose();
        View.CommonItem.ResultBibleTextItem.DoTextAnim(callback:  0);
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
        {
                Logic.Game.GameManager.gameSound.Play(clipName:  "verse_completed", volumeScale:  1f, loop:  false, delay:  0f);
        }
        
        val_20 = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = val_20;
        val_19 = 1;
        return (bool)val_19;
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
