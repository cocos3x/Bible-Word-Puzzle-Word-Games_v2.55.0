using UnityEngine;
private sealed class GameController.<ShowWinVerseDialog>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Game.GameController <>4__this;
    public float delay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameController.<ShowWinVerseDialog>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Logic.Game.GameDiglog val_11;
        int val_12;
        val_11 = this;
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
        val_12 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  ((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsHaveCollectChrysalisAni()) != true) ? 1.3f : 0.8f);
        this.<>1__state = val_12;
        return (bool)val_12;
        label_2:
        this.<>1__state = 0;
        Message.Messager.Dispatch<System.Boolean>(cmd:  63, t:  ((this.<>4__this.<isGameComplete>k__BackingField) == true) ? 1 : 0);
        Message.Messager.Dispatch(cmd:  54);
        Message.Messager.Dispatch(cmd:  47);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        this.<>1__state = 2;
        val_12 = 1;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
        {
                Logic.Game.GameManager.gameMusic.PlayResult();
        }
        else
        {
                Logic.Game.GameManager.gameMusic.Pause(pause:  true);
        }
        
        val_11 = Logic.Game.GameManager.gameDialog;
        object[] val_8 = new object[1];
        UnityEngine.Vector3 val_9 = this.<>4__this.SlotBible.position;
        val_8[0] = val_9;
        View.Dialog.Common.Dialog val_10 = val_11.OpenAddParams(name:  "ResultDialog", pars:  val_8);
        label_3:
        val_12 = 0;
        return (bool)val_12;
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
