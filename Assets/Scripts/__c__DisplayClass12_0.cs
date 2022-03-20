using UnityEngine;
private sealed class DailySignDayProgress.<>c__DisplayClass12_0
{
    // Fields
    public View.CommonItem.DailyProgressBarItem _tempItem;
    
    // Methods
    public DailySignDayProgress.<>c__DisplayClass12_0()
    {
    
    }
    internal void <PlayProgressAni>b__0()
    {
        if(this._tempItem != null)
        {
                this._tempItem.PlayProgressDoneAni(isExist:  false);
            return;
        }
        
        throw new NullReferenceException();
    }

}
