using UnityEngine;
public struct UserRecord.NetStateEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.UserRecord.NetStateEnum NetState1;
    public static Platform.Analyze.UserRecord.NetStateEnum NetState0;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new UserRecord.NetStateEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public UserRecord.NetStateEnum(string val)
    {
        this = val;
    }
    private static UserRecord.NetStateEnum()
    {
        UserRecord.NetStateEnum.NetState1 = "1";
        UserRecord.NetStateEnum.NetState0 = "0";
    }

}
