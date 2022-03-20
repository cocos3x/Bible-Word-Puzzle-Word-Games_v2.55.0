using UnityEngine;
public struct IapDlgShow.TimingEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.IapDlgShow.TimingEnum TimingAuto;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new IapDlgShow.TimingEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public IapDlgShow.TimingEnum(string val)
    {
        this = val;
    }
    private static IapDlgShow.TimingEnum()
    {
        IapDlgShow.TimingEnum.TimingAuto = "auto";
    }

}
