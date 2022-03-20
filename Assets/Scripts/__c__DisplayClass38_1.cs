using UnityEngine;
private sealed class DailyPrayerWordContent.<>c__DisplayClass38_1
{
    // Fields
    public string x;
    
    // Methods
    public DailyPrayerWordContent.<>c__DisplayClass38_1()
    {
    
    }
    internal bool <GetDoveLetter>b__2(View.CommonItem.Word y)
    {
        if(y != null)
        {
                return System.String.op_Equality(a:  y._word, b:  this.x);
        }
        
        throw new NullReferenceException();
    }

}
