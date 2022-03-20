using UnityEngine;
public struct ComboShow.ComboTypeEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.ComboShow.ComboTypeEnum ComboTypeFaithful;
    public static Platform.Analyze.ComboShow.ComboTypeEnum ComboTypeGodBeWithYou;
    public static Platform.Analyze.ComboShow.ComboTypeEnum ComboTypeAmen;
    public static Platform.Analyze.ComboShow.ComboTypeEnum ComboTypeGlory;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new ComboShow.ComboTypeEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public ComboShow.ComboTypeEnum(string val)
    {
        this = val;
    }
    private static ComboShow.ComboTypeEnum()
    {
        ComboShow.ComboTypeEnum.ComboTypeFaithful = "faithful";
        ComboShow.ComboTypeEnum.ComboTypeGodBeWithYou = "god_be_with_you";
        ComboShow.ComboTypeEnum.ComboTypeAmen = "amen";
        ComboShow.ComboTypeEnum.ComboTypeGlory = "glory";
    }

}
