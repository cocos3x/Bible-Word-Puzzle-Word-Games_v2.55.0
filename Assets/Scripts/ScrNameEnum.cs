using UnityEngine;
public struct ActivScrShow.ScrNameEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.ActivScrShow.ScrNameEnum ScrNameButterflyScr;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new ActivScrShow.ScrNameEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public ActivScrShow.ScrNameEnum(string val)
    {
        this = val;
    }
    private static ActivScrShow.ScrNameEnum()
    {
        ActivScrShow.ScrNameEnum.ScrNameButterflyScr = "butterfly_scr";
    }

}
