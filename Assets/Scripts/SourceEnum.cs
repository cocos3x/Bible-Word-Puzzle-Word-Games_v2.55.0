using UnityEngine;
public struct ActivScrShow.SourceEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.ActivScrShow.SourceEnum SourceMgScr;
    public static Platform.Analyze.ActivScrShow.SourceEnum SourceLevelResultDlg;
    public static Platform.Analyze.ActivScrShow.SourceEnum SourceHomeScr;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new ActivScrShow.SourceEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public ActivScrShow.SourceEnum(string val)
    {
        this = val;
    }
    private static ActivScrShow.SourceEnum()
    {
        ActivScrShow.SourceEnum.SourceMgScr = "mg_scr";
        ActivScrShow.SourceEnum.SourceLevelResultDlg = "level_result_dlg";
        ActivScrShow.SourceEnum.SourceHomeScr = "home_scr";
    }

}
