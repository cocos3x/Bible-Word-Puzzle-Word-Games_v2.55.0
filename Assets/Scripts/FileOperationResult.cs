using UnityEngine;
public class FileUtil.FileOperationResult : IDisposable
{
    // Fields
    private bool <Success>k__BackingField;
    private object <Data>k__BackingField;
    private string <Error>k__BackingField;
    
    // Properties
    public bool Success { get; set; }
    public object Data { get; set; }
    public string Error { get; set; }
    
    // Methods
    public bool get_Success()
    {
        return (bool)this.<Success>k__BackingField;
    }
    private void set_Success(bool value)
    {
        this.<Success>k__BackingField = value;
    }
    public object get_Data()
    {
        return (object)this.<Data>k__BackingField;
    }
    private void set_Data(object value)
    {
        this.<Data>k__BackingField = value;
    }
    public string get_Error()
    {
        return (string)this.<Error>k__BackingField;
    }
    private void set_Error(string value)
    {
        this.<Error>k__BackingField = value;
    }
    public FileUtil.FileOperationResult(bool success, object data, string error)
    {
        val_1 = new System.Object();
        this.<Success>k__BackingField = success;
        this.<Data>k__BackingField = val_1;
        this.<Error>k__BackingField = error;
    }
    public void Dispose()
    {
        this.<Success>k__BackingField = false;
        this.<Data>k__BackingField = 0;
        this.<Error>k__BackingField = 0;
    }

}
