using UnityEngine;
private sealed class LocalizationManager.<>c__DisplayClass33_0
{
    // Fields
    public System.Collections.Generic.List<string> Languages;
    public System.Func<string, bool> <>9__0;
    
    // Methods
    public LocalizationManager.<>c__DisplayClass33_0()
    {
    
    }
    internal bool <GetAllLanguages>b__0(string x)
    {
        bool val_1 = this.Languages.Contains(item:  x);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }

}
