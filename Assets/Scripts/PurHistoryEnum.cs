using UnityEngine;
public struct UserRecord.PurHistoryEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.UserRecord.PurHistoryEnum PurHistory1;
    public static Platform.Analyze.UserRecord.PurHistoryEnum PurHistory0;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new UserRecord.PurHistoryEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public UserRecord.PurHistoryEnum(string val)
    {
        this = val;
    }
    private static UserRecord.PurHistoryEnum()
    {
        UserRecord.PurHistoryEnum.PurHistory1 = "1";
        UserRecord.PurHistoryEnum.PurHistory0 = "0";
    }

}
