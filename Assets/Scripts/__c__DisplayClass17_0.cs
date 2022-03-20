using UnityEngine;
private sealed class DailyPrayerBean.<>c__DisplayClass17_0
{
    // Fields
    public char targetLetter;
    
    // Methods
    public DailyPrayerBean.<>c__DisplayClass17_0()
    {
    
    }
    internal bool <RandomDoveLetter>b__0(string x)
    {
        string val_2 = x;
        int val_1 = val_2.IndexOf(value:  this.targetLetter);
        val_2 = val_1 >> 31;
        val_1 = val_2 ^ 1;
        return (bool)val_1;
    }

}
