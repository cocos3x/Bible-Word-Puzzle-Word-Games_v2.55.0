using UnityEngine;
private sealed class DailyPrayerWordContent.<>c__DisplayClass64_0
{
    // Fields
    public View.CommonItem.LetterBox letterBox;
    
    // Methods
    public DailyPrayerWordContent.<>c__DisplayClass64_0()
    {
    
    }
    internal bool <ShowHintWordFromDove>b__0(View.CommonItem.Word x)
    {
        if(x != null)
        {
                return x.WordIsContainLetterBox(letterBox:  this.letterBox);
        }
        
        throw new NullReferenceException();
    }

}
