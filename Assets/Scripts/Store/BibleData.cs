using UnityEngine;

namespace Store
{
    public class BibleData : IStoreData
    {
        // Fields
        public int LastCompleteBible;
        public int BibleDialogShowCount;
        public int BookCollectCount;
        public int VerseCollectCount;
        public int LastShowMainBibleSection;
        public string LastShowMainBibleTime;
        public bool CanShowMainBibleBook;
        
        // Methods
        public void Reset()
        {
            this.VerseCollectCount = 0;
            this.LastShowMainBibleSection = 0;
            this.BibleDialogShowCount = 0;
            this.BookCollectCount = 0;
            this.LastCompleteBible = 0;
            this.CanShowMainBibleBook = true;
            this.LastShowMainBibleTime = System.String.alignConst;
        }
        public BibleData()
        {
        
        }
    
    }

}
