using UnityEngine;
public struct PropUse.PropNameEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.PropUse.PropNameEnum PropNameRefresh;
    public static Platform.Analyze.PropUse.PropNameEnum PropNameFirework;
    public static Platform.Analyze.PropUse.PropNameEnum PropNameHint;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new PropUse.PropNameEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public PropUse.PropNameEnum(string val)
    {
        this = val;
    }
    private static PropUse.PropNameEnum()
    {
        PropUse.PropNameEnum.PropNameRefresh = "refresh";
        PropUse.PropNameEnum.PropNameFirework = "firework";
        PropUse.PropNameEnum.PropNameHint = "hint";
    }

}
