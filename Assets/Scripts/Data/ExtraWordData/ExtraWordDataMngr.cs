using UnityEngine;

namespace Data.ExtraWordData
{
    public static class ExtraWordDataMngr
    {
        // Fields
        public static bool isNotCheckExtraExist;
        
        // Methods
        public static bool IsWordExist(string word)
        {
            if(Data.ExtraWordData.ExtraWordDataMngr.isNotCheckExtraExist == false)
            {
                    return Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ExtraWord.Contains(item:  word);
            }
            
            return false;
        }
        public static void AddWord(string word)
        {
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.AddWord(word:  word);
            Data.ExtraWordData.ExtraWordDataMngr.AddProgress();
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  word);
            if((Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.HasExtraFirst) != false)
            {
                    return;
            }
            
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.HasExtraFirst = true;
        }
        public static int GetTotalProgress()
        {
            int val_2 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.TotalProgress;
            val_2 = val_2 + 1;
            return (int)val_2;
        }
        private static void AddProgress()
        {
            int val_2 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ExtraProgress;
            val_2.ExtraProgress = val_2 + 1;
            int val_5 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.TotalProgress;
            val_5.TotalProgress = val_5 + 1;
        }
        public static void ClearAll()
        {
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ClearWords();
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.Left5Count = 2;
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ExtraProgress = 0;
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.HasExtraFirst = false;
        }
    
    }

}
