using UnityEngine;
private sealed class DailyPrayerWordContent.<>c__DisplayClass38_0
{
    // Fields
    public int i;
    public View.DailyPrayer.DailyPrayerWordContent <>4__this;
    
    // Methods
    public DailyPrayerWordContent.<>c__DisplayClass38_0()
    {
    
    }
    internal bool <GetDoveLetter>b__0(View.CommonItem.Word w)
    {
        if(w.IsEmptyWord() != false)
        {
                return false;
        }
        
        View.DailyPrayer.DailyPrayerWordContent val_2 = this.<>4__this;
        if(val_2 <= this.i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + ((this.i) << 3);
        return System.String.op_Equality(a:  w._word, b:  (this.<>4__this + (this.i) << 3).wordVerticalRatioSpacing + 40);
    }
    internal bool <GetDoveLetter>b__1(string x)
    {
        var val_6;
        UnityEngine.Object val_7;
        var val_8;
        val_6 = this;
        typeof(DailyPrayerWordContent.<>c__DisplayClass38_1).__il2cppRuntimeField_10 = x;
        val_7 = this.<>4__this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  new System.Object(), method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass38_1::<GetDoveLetter>b__2(View.CommonItem.Word y)));
        if(val_7 == 0)
        {
                val_7 = this.i;
            val_6 = mem[x + 16];
            val_6 = x + 16;
            if((this.<>4__this) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_5 = (val_6 == ((x + (this.i) << 3) + 32 + 40 + 16)) ? 1 : 0;
            return (bool)val_8;
        }
        
        val_8 = 0;
        return (bool)val_8;
    }

}
