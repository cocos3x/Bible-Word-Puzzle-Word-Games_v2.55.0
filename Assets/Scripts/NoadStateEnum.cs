using UnityEngine;
public struct UserRecord.NoadStateEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.UserRecord.NoadStateEnum NoadState1;
    public static Platform.Analyze.UserRecord.NoadStateEnum NoadState0;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new UserRecord.NoadStateEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public UserRecord.NoadStateEnum(string val)
    {
        this = val;
    }
    private static UserRecord.NoadStateEnum()
    {
        UserRecord.NoadStateEnum.NoadState1 = "1";
        UserRecord.NoadStateEnum.NoadState0 = "0";
    }

}
