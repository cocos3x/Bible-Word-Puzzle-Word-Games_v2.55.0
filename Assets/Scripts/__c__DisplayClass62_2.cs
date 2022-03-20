using UnityEngine;
private sealed class DailyPrayerWordContent.<>c__DisplayClass62_2
{
    // Fields
    public string x;
    
    // Methods
    public DailyPrayerWordContent.<>c__DisplayClass62_2()
    {
    
    }
    internal bool <MatchAnswerForWord>b__4(View.CommonItem.Word y)
    {
        if(y != null)
        {
                if(y._isAnswered == false)
        {
                return false;
        }
        
            return System.String.op_Equality(a:  y._word, b:  this.x);
        }
        
        throw new NullReferenceException();
    }

}
