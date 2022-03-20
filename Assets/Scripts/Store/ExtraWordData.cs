using UnityEngine;

namespace Store
{
    public class ExtraWordData : IStoreData
    {
        // Fields
        public System.Collections.Generic.List<string> ExtraWord;
        public int Left5Count;
        public int ExtraProgress;
        public bool HasExtraFirst;
        public int TotalProgress;
        
        // Methods
        public void Reset()
        {
            this.ExtraWord.Clear();
            this.HasExtraFirst = false;
            this.TotalProgress = 0;
            this.Left5Count = 2;
            this.ExtraProgress = 0;
        }
        public ExtraWordData()
        {
            this.ExtraWord = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
