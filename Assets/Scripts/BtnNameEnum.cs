using UnityEngine;
public struct ActivBtnClick.BtnNameEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.ActivBtnClick.BtnNameEnum BtnNameCloseBtn;
    public static Platform.Analyze.ActivBtnClick.BtnNameEnum BtnNameButterflyBtn;
    public static Platform.Analyze.ActivBtnClick.BtnNameEnum BtnNameCollectionBtn;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new ActivBtnClick.BtnNameEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public ActivBtnClick.BtnNameEnum(string val)
    {
        this = val;
    }
    private static ActivBtnClick.BtnNameEnum()
    {
        ActivBtnClick.BtnNameEnum.BtnNameCloseBtn = "close_btn";
        ActivBtnClick.BtnNameEnum.BtnNameButterflyBtn = "butterfly_btn";
        ActivBtnClick.BtnNameEnum.BtnNameCollectionBtn = "collection_btn";
    }

}
