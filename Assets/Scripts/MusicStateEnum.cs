using UnityEngine;
public struct UserRecord.MusicStateEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.UserRecord.MusicStateEnum MusicState1;
    public static Platform.Analyze.UserRecord.MusicStateEnum MusicState0;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new UserRecord.MusicStateEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public UserRecord.MusicStateEnum(string val)
    {
        this = val;
    }
    private static UserRecord.MusicStateEnum()
    {
        UserRecord.MusicStateEnum.MusicState1 = "1";
        UserRecord.MusicStateEnum.MusicState0 = "0";
    }

}
