using UnityEngine;
private sealed class LocalizationManager.<>c__DisplayClass71_0
{
    // Fields
    public I2.Loc.ILocalizeTargetDescriptor desc;
    
    // Methods
    public LocalizationManager.<>c__DisplayClass71_0()
    {
    
    }
    internal bool <RegisterTarget>b__0(I2.Loc.ILocalizeTargetDescriptor x)
    {
        return System.String.op_Equality(a:  x.Name, b:  this.desc.Name);
    }

}
