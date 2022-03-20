using UnityEngine;

namespace View.Dialog.GameDictionary.Controller
{
    public class GameDictionaryController : SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>
    {
        // Fields
        private Data.GameDictionary.DictionaryWordData _wordData;
        private string _level;
        private System.Collections.Generic.List<string> _rightAnswer;
        
        // Methods
        public void SetRightAnswer(System.Collections.Generic.List<string> words)
        {
            System.Collections.Generic.List<System.String> val_1;
            this._rightAnswer.Clear();
            if(words == null)
            {
                    return;
            }
            
            if(1152921508357928576 < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            do
            {
                val_1 = this._rightAnswer;
                if(val_1 >= 1152921508357928576)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1.Add(item:  "mission");
                val_1 = val_1 + 1;
            }
            while(val_1 < 21133048);
        
        }
        public System.Collections.Generic.List<string> GetRightAnswer()
        {
            return (System.Collections.Generic.List<System.String>)this._rightAnswer;
        }
        public void AddRightAnswer(string word)
        {
            if((System.String.IsNullOrEmpty(value:  word)) == true)
            {
                    return;
            }
            
            this._rightAnswer.Add(item:  word);
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState == 3)
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SaveGameRightAnswerList(data:  this._rightAnswer);
                return;
            }
            
            }
            
            View.Controller.MainController val_6 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_6._bibleGameState != 4)
            {
                    return;
            }
            
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyRightAnswerList(data:  this._rightAnswer);
        }
        public Data.GameDictionary.DictionaryWordData GetWordData()
        {
            return (Data.GameDictionary.DictionaryWordData)this._wordData;
        }
        public System.Collections.Generic.List<string> FindDefinesFromWord(string word)
        {
            System.Collections.Generic.List<Data.GameDictionary.DictionaryWordDataSingle> val_3;
            if(this._wordData == null)
            {
                    return 0;
            }
            
            val_3 = this._wordData.list;
            if(this._wordData < 1)
            {
                    return 0;
            }
            
            var val_3 = 0;
            label_10:
            if(val_3 >= this._wordData)
            {
                    return 0;
            }
            
            if(this._wordData <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Equality(a:  Data.GameDictionary.DictionaryWordData.__il2cppRuntimeField_byval_arg + 16, b:  word.ToLower())) == true)
            {
                goto label_8;
            }
            
            val_3 = val_3 + 1;
            if(this._wordData.list != null)
            {
                goto label_10;
            }
            
            return 0;
            label_8:
            if(this._wordData > val_3)
            {
                    return 0;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return 0;
        }
        public void RequestWordData(string levelName, System.Collections.Generic.List<string> words)
        {
            var val_4;
            var val_5;
            var val_6;
            if(Common.EzNetwork.IsNetworkAvailable() == false)
            {
                goto label_1;
            }
            
            if(((System.String.IsNullOrEmpty(value:  this._level)) == true) || ((System.String.op_Equality(a:  this._level, b:  levelName)) == false))
            {
                goto label_3;
            }
            
            val_4 = 1152921512624727472;
            val_5 = 5;
            val_6 = 1;
            goto label_6;
            label_1:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dictionary", action:  "load", label:  "fail", value:  0);
            val_4 = 1152921512624727472;
            val_5 = 5;
            val_6 = 0;
            label_6:
            Message.Messager.Dispatch<System.Boolean>(cmd:  5, t:  false);
            return;
            label_3:
            this._level = levelName;
            this.PostWordData(words:  words);
        }
        private void PostWordData(System.Collections.Generic.List<string> words)
        {
            typeof(GameDictionaryController.<>c__DisplayClass10_0).__il2cppRuntimeField_18 = this;
            typeof(Data.GameDictionary.PostWordData).__il2cppRuntimeField_10 = words;
            UnityEngine.Networking.DownloadHandlerBuffer val_3 = new UnityEngine.Networking.DownloadHandlerBuffer();
            typeof(GameDictionaryController.<>c__DisplayClass10_0).__il2cppRuntimeField_10 = new UnityEngine.Networking.UnityWebRequest(url:  "https://bibleversecollect.com/bvc/v1/word", method:  "POST", downloadHandler:  val_3, uploadHandler:  new UnityEngine.Networking.UploadHandlerRaw(data:  val_3.ObjectToBytes(obj:  new Data.GameDictionary.PostWordData())));
            uploadHandler.contentType = "application/json";
            SetRequestHeader(name:  "Content-Type", value:  "application/json");
            timeout = 10;
            SendWebRequest().add_completed(value:  new System.Action<UnityEngine.AsyncOperation>(object:  new System.Object(), method:  System.Void GameDictionaryController.<>c__DisplayClass10_0::<PostWordData>b__0(UnityEngine.AsyncOperation _)));
        }
        private byte[] ObjectToBytes(object obj)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  obj);
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_240;
        }
        public GameDictionaryController()
        {
            this._rightAnswer = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
