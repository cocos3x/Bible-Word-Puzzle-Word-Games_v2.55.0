using UnityEngine;
private sealed class DailyPrayerController.<ShowBibleDialog>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.DailyPrayer.DailyPrayerController <>4__this;
    public float delay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DailyPrayerController.<ShowBibleDialog>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        val_6 = this;
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
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.8f);
        this.<>1__state = val_7;
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        Message.Messager.Dispatch<System.Boolean>(cmd:  63, t:  ((this.<>4__this.<isGameComplete>k__BackingField) == true) ? 1 : 0);
        Message.Messager.Dispatch(cmd:  54);
        UnityEngine.WaitForSeconds val_3 = null;
        float val_6 = 0.8f;
        val_6 = this.delay + val_6;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  val_6);
        this.<>2__current = val_3;
        this.<>1__state = 2;
        val_7 = 1;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "level_success", label:  "", value:  0);
        val_6 = 1152921504818933760;
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
        {
                Logic.Game.GameManager.gameMusic.PlayResult();
        }
        else
        {
                Logic.Game.GameManager.gameMusic.Pause(pause:  true);
        }
        
        View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.Open(name:  "ResultDailyDialog", type:  0);
        label_3:
        val_7 = 0;
        return (bool)val_7;
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
