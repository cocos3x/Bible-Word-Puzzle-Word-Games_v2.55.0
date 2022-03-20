using UnityEngine;
public struct BtnShow.PlacementEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.BtnShow.PlacementEnum PlacementGame;
    public static Platform.Analyze.BtnShow.PlacementEnum PlacementLevelPass;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new BtnShow.PlacementEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public BtnShow.PlacementEnum(string val)
    {
        this = val;
    }
    private static BtnShow.PlacementEnum()
    {
        BtnShow.PlacementEnum.PlacementGame = "game";
        BtnShow.PlacementEnum.PlacementLevelPass = "levelPass";
    }

}
