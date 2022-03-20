using UnityEngine;
public struct LevelContentLoad.StateEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.LevelContentLoad.StateEnum StateStart;
    public static Platform.Analyze.LevelContentLoad.StateEnum StateSuccess;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new LevelContentLoad.StateEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public LevelContentLoad.StateEnum(string val)
    {
        this = val;
    }
    private static LevelContentLoad.StateEnum()
    {
        LevelContentLoad.StateEnum.StateStart = "start";
        LevelContentLoad.StateEnum.StateSuccess = "success";
    }

}
