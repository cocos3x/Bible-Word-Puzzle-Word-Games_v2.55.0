using UnityEngine;
public struct DlgShow.DlgNameEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.DlgShow.DlgNameEnum DlgNamePushSystemDlg;
    public static Platform.Analyze.DlgShow.DlgNameEnum DlgNameLevelResultDlg;
    public static Platform.Analyze.DlgShow.DlgNameEnum DlgNameShopDlg;
    public static Platform.Analyze.DlgShow.DlgNameEnum DlgNameQuitDlg;
    public static Platform.Analyze.DlgShow.DlgNameEnum DlgNameRateDlg;
    public static Platform.Analyze.DlgShow.DlgNameEnum DlgNameDrDlg;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new DlgShow.DlgNameEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public DlgShow.DlgNameEnum(string val)
    {
        this = val;
    }
    private static DlgShow.DlgNameEnum()
    {
        DlgShow.DlgNameEnum.DlgNamePushSystemDlg = "push_system_dlg";
        DlgShow.DlgNameEnum.DlgNameLevelResultDlg = "level_result_dlg";
        DlgShow.DlgNameEnum.DlgNameShopDlg = "shop_dlg";
        DlgShow.DlgNameEnum.DlgNameQuitDlg = "quit_dlg";
        DlgShow.DlgNameEnum.DlgNameRateDlg = "rate_dlg";
        DlgShow.DlgNameEnum.DlgNameDrDlg = "dr_dlg";
    }

}
