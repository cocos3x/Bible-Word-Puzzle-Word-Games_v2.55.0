using UnityEngine;

namespace Data.ExtraWord
{
    public class ExtraWordDataManager : Singleton<Data.ExtraWord.ExtraWordDataManager>
    {
        // Properties
        public System.Collections.Generic.List<string> ExtraWord { get; }
        public int Left5Count { get; set; }
        public int ExtraProgress { get; set; }
        public bool HasExtraFirst { get; set; }
        public int TotalProgress { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public System.Collections.Generic.List<string> get_ExtraWord()
        {
            return (System.Collections.Generic.List<System.String>)Store.ExtraWordData.__il2cppRuntimeField_name;
        }
        public int get_Left5Count()
        {
            return (int)Store.ExtraWordData.__il2cppRuntimeField_namespaze;
        }
        private void set_Left5Count(int value)
        {
            typeof(Store.ExtraWordData).__il2cppRuntimeField_18 = value;
        }
        public int get_ExtraProgress()
        {
            return (int)typeof(Store.ExtraWordData).__il2cppRuntimeField_1C;
        }
        private void set_ExtraProgress(int value)
        {
            typeof(Store.ExtraWordData).__il2cppRuntimeField_1C = value;
        }
        public bool get_HasExtraFirst()
        {
            return (bool)Store.ExtraWordData.__il2cppRuntimeField_byval_arg;
        }
        private void set_HasExtraFirst(bool value)
        {
            typeof(Store.ExtraWordData).__il2cppRuntimeField_20 = value;
        }
        public int get_TotalProgress()
        {
            return (int)typeof(Store.ExtraWordData).__il2cppRuntimeField_24;
        }
        private void set_TotalProgress(int value)
        {
            typeof(Store.ExtraWordData).__il2cppRuntimeField_24 = value;
        }
        public void AddWord(string word)
        {
            this.ExtraWord.Add(item:  word);
        }
        public System.Collections.Generic.List<string> GetWords()
        {
            return this.ExtraWord;
        }
        public void ClearWords()
        {
            this.ExtraWord.Clear();
        }
        public void SetLeft5Count(int count)
        {
            this.Left5Count = count;
        }
        public void SetExtraProgress(int progress)
        {
            this.ExtraProgress = progress;
        }
        public void AddExtraProgress()
        {
            int val_1 = this.ExtraProgress;
            val_1.ExtraProgress = val_1 + 1;
        }
        public void SetHasExtraFirst(bool isHas)
        {
            this.HasExtraFirst = isHas;
        }
        public void AddTotalProgress()
        {
            int val_1 = this.TotalProgress;
            val_1.TotalProgress = val_1 + 1;
        }
        public ExtraWordDataManager()
        {
        
        }
    
    }

}
