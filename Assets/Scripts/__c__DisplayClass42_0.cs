using UnityEngine;
private sealed class LocalizationManager.<>c__DisplayClass42_0
{
    // Fields
    public UnityEngine.GameObject root;
    
    // Methods
    public LocalizationManager.<>c__DisplayClass42_0()
    {
    
    }
    internal object <ApplyLocalizationParams>b__0(string p)
    {
        return I2.Loc.LocalizationManager.GetLocalizationParam(ParamName:  p, root:  this.root);
    }

}
