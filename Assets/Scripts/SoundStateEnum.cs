using UnityEngine;
public struct UserRecord.SoundStateEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.UserRecord.SoundStateEnum SoundState1;
    public static Platform.Analyze.UserRecord.SoundStateEnum SoundState0;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new UserRecord.SoundStateEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public UserRecord.SoundStateEnum(string val)
    {
        this = val;
    }
    private static UserRecord.SoundStateEnum()
    {
        UserRecord.SoundStateEnum.SoundState1 = "1";
        UserRecord.SoundStateEnum.SoundState0 = "0";
    }

}
