using UnityEngine;
public struct BtnShow.PlacementTypeEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.BtnShow.PlacementTypeEnum PlacementTypeReward;
    public static Platform.Analyze.BtnShow.PlacementTypeEnum PlacementTypeInterstitial;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new BtnShow.PlacementTypeEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public BtnShow.PlacementTypeEnum(string val)
    {
        this = val;
    }
    private static BtnShow.PlacementTypeEnum()
    {
        BtnShow.PlacementTypeEnum.PlacementTypeReward = "reward";
        BtnShow.PlacementTypeEnum.PlacementTypeInterstitial = "interstitial";
    }

}
