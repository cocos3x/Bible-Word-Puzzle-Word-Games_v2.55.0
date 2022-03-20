using UnityEngine;
private sealed class ResManager.<>c__DisplayClass9_0
{
    // Fields
    public UnityEngine.Networking.UnityWebRequest uwr;
    public string cachePath;
    public UnityEngine.Texture2D texture;
    public System.Action<UnityEngine.Texture2D> callback;
    
    // Methods
    public ResManager.<>c__DisplayClass9_0()
    {
    
    }
    internal void <GetTextureForUrl>b__0(UnityEngine.AsyncOperation _)
    {
        var val_11;
        System.Byte[] val_12;
        UnityEngine.Networking.UnityWebRequest val_13;
        if(this.uwr.isHttpError != true)
        {
                if(this.uwr.isNetworkError == false)
        {
            goto label_4;
        }
        
        }
        
        val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        Log.D.Error(message:  this.uwr.error, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        return;
        label_4:
        if(this.uwr == null)
        {
                return;
        }
        
        val_12 = 0;
        if(this.uwr.isDone == false)
        {
                return;
        }
        
        val_13 = this.uwr;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        UnityEngine.Networking.DownloadHandler val_5 = val_13.downloadHandler;
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        System.Byte[] val_6 = val_5.data;
        if(val_6 == null)
        {
                return;
        }
        
        if(val_6.Length == 0)
        {
                return;
        }
        
        val_12 = val_6;
        if((Utils.Util.File.FileUtil.WriteAllBytes(path:  this.cachePath, bytes:  val_12)) == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_7.<Success>k__BackingField) == false)
        {
                return;
        }
        
        UnityEngine.Texture2D val_8 = new UnityEngine.Texture2D(width:  0, height:  0, textureFormat:  49, mipChain:  false);
        this.texture = val_8;
        bool val_9 = UnityEngine.ImageConversion.LoadImage(tex:  val_8, data:  val_6);
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(obj:  this.texture);
    }

}
