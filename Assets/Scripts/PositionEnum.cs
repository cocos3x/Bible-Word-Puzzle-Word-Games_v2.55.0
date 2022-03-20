using UnityEngine;
public struct BtnShow.PositionEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.BtnShow.PositionEnum PositionLevelPass;
    public static Platform.Analyze.BtnShow.PositionEnum PositionWatchMoreReward;
    public static Platform.Analyze.BtnShow.PositionEnum PositionWrong4timesGift;
    public static Platform.Analyze.BtnShow.PositionEnum PositionShopClose;
    public static Platform.Analyze.BtnShow.PositionEnum PositionWatchMore5s;
    public static Platform.Analyze.BtnShow.PositionEnum PositionVoid;
    public static Platform.Analyze.BtnShow.PositionEnum PositionGameButton;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new BtnShow.PositionEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public BtnShow.PositionEnum(string val)
    {
        this = val;
    }
    private static BtnShow.PositionEnum()
    {
        BtnShow.PositionEnum.PositionLevelPass = "level_pass";
        BtnShow.PositionEnum.PositionWatchMoreReward = "watch_more_reward";
        BtnShow.PositionEnum.PositionWrong4timesGift = "wrong_4times_gift";
        BtnShow.PositionEnum.PositionShopClose = "shop_close";
        BtnShow.PositionEnum.PositionWatchMore5s = "watch_more_5s";
        BtnShow.PositionEnum.PositionVoid = "void";
        BtnShow.PositionEnum.PositionGameButton = "game_button";
    }

}
