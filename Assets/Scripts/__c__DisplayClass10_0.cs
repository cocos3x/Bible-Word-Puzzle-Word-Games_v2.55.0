using UnityEngine;
private sealed class GameDictionaryController.<>c__DisplayClass10_0
{
    // Fields
    public UnityEngine.Networking.UnityWebRequest request;
    public View.Dialog.GameDictionary.Controller.GameDictionaryController <>4__this;
    
    // Methods
    public GameDictionaryController.<>c__DisplayClass10_0()
    {
    
    }
    internal void <PostWordData>b__0(UnityEngine.AsyncOperation _)
    {
        var val_6;
        UnityEngine.Networking.UnityWebRequest val_7;
        if(this.request.isHttpError == true)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if(this.request.isNetworkError == false)
        {
            goto label_4;
        }
        
        label_2:
        Message.Messager.Dispatch<System.Boolean>(cmd:  5, t:  false);
        this.<>4__this._level = System.String.alignConst;
        Platform.Analytics.EzAnalytics.LogEvent(category:  "dictionary", action:  "load", label:  "fail", value:  0);
        return;
        label_4:
        val_7 = this.request;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        val_6 = 0;
        UnityEngine.Networking.DownloadHandler val_3 = val_7.downloadHandler;
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        val_6 = public static Data.GameDictionary.JsonResult<Data.GameDictionary.DictionaryWordData> Newtonsoft.Json.JsonConvert::DeserializeObject<Data.GameDictionary.JsonResult<Data.GameDictionary.DictionaryWordData>>(string value);
        Data.GameDictionary.JsonResult<Data.GameDictionary.DictionaryWordData> val_5 = Newtonsoft.Json.JsonConvert.DeserializeObject<Data.GameDictionary.JsonResult<Data.GameDictionary.DictionaryWordData>>(value:  val_3.text);
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        if(X9 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((X9 + 24) != 0)
        {
                val_7 = 5;
            val_6 = 0;
            Message.Messager.Dispatch<System.Boolean>(cmd:  5, t:  false);
            if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
            this.<>4__this._level = System.String.alignConst;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dictionary", action:  "load", label:  "fail", value:  0);
            return;
        }
        
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        this.<>4__this._wordData = val_5;
        Message.Messager.Dispatch<System.Boolean>(cmd:  5, t:  true);
    }

}
