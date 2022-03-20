using UnityEngine;
public struct CalendarRewardGain.RewardIndexEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.CalendarRewardGain.RewardIndexEnum RewardIndex1;
    public static Platform.Analyze.CalendarRewardGain.RewardIndexEnum RewardIndex3;
    public static Platform.Analyze.CalendarRewardGain.RewardIndexEnum RewardIndex4;
    public static Platform.Analyze.CalendarRewardGain.RewardIndexEnum RewardIndex2;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new CalendarRewardGain.RewardIndexEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public CalendarRewardGain.RewardIndexEnum(string val)
    {
        this = val;
    }
    private static CalendarRewardGain.RewardIndexEnum()
    {
        CalendarRewardGain.RewardIndexEnum.RewardIndex1 = "1";
        CalendarRewardGain.RewardIndexEnum.RewardIndex3 = "3";
        CalendarRewardGain.RewardIndexEnum.RewardIndex4 = "4";
        CalendarRewardGain.RewardIndexEnum.RewardIndex2 = "2";
    }

}
