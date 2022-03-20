using UnityEngine;

namespace Data.Bible
{
    public class BibleDataManager : Singleton<Data.Bible.BibleDataManager>
    {
        // Fields
        public System.Collections.Generic.List<string> BibleCoverOther;
        private System.DateTime _lastShowMainBibleDateTime;
        private bool <IsExistCollectAni>k__BackingField;
        private bool <IsPlayPageAni>k__BackingField;
        private bool <IsPageForward>k__BackingField;
        
        // Properties
        public int LastCompleteBible { get; set; }
        public int BookCollectCount { get; set; }
        public int VerseCollectCount { get; set; }
        public string LastShowMainBibleTime { get; }
        public bool IsExistCollectAni { get; set; }
        public bool IsPlayPageAni { get; set; }
        public bool IsPageForward { get; set; }
        
        // Methods
        public void Init()
        {
            System.DateTime val_2 = Common.EzDate.GetDateTime(dateString:  this.LastShowMainBibleTime, format:  0);
            this._lastShowMainBibleDateTime = val_2;
        }
        public int get_LastCompleteBible()
        {
            return (int)Store.BibleData.__il2cppRuntimeField_name;
        }
        private void set_LastCompleteBible(int value)
        {
            typeof(Store.BibleData).__il2cppRuntimeField_10 = value;
        }
        public int get_BookCollectCount()
        {
            return (int)Store.BibleData.__il2cppRuntimeField_namespaze;
        }
        private void set_BookCollectCount(int value)
        {
            typeof(Store.BibleData).__il2cppRuntimeField_18 = value;
        }
        public int get_VerseCollectCount()
        {
            return (int)typeof(Store.BibleData).__il2cppRuntimeField_1C;
        }
        private void set_VerseCollectCount(int value)
        {
            typeof(Store.BibleData).__il2cppRuntimeField_1C = value;
        }
        public string get_LastShowMainBibleTime()
        {
            return (string)typeof(Store.BibleData).__il2cppRuntimeField_28;
        }
        public void SetLastCompleteBible(int last)
        {
            this.LastCompleteBible = last;
        }
        public void AddLastCompleteBible()
        {
            int val_1 = this.LastCompleteBible;
            val_1.LastCompleteBible = val_1 + 1;
        }
        public void SetBookCollectCount(int count)
        {
            this.BookCollectCount = count;
        }
        public void SetVerseCollectCount(int count)
        {
            this.VerseCollectCount = count;
        }
        public bool get_IsExistCollectAni()
        {
            return (bool)this.<IsExistCollectAni>k__BackingField;
        }
        public void set_IsExistCollectAni(bool value)
        {
            this.<IsExistCollectAni>k__BackingField = value;
        }
        public bool get_IsPlayPageAni()
        {
            return (bool)this.<IsPlayPageAni>k__BackingField;
        }
        public void set_IsPlayPageAni(bool value)
        {
            this.<IsPlayPageAni>k__BackingField = value;
        }
        public bool get_IsPageForward()
        {
            return (bool)this.<IsPageForward>k__BackingField;
        }
        public void set_IsPageForward(bool value)
        {
            this.<IsPageForward>k__BackingField = value;
        }
        public BibleDataManager()
        {
            Add(item:  "Ephesians");
            Add(item:  "Philippians");
            Add(item:  "Colossians");
            Add(item:  "1 Thessalonians");
            Add(item:  "2 Thessalonians");
            Add(item:  "1 Timothy");
            Add(item:  "2 Timothy");
            Add(item:  "Titus");
            Add(item:  "Philemon");
            Add(item:  "Hebrews");
            Add(item:  "James");
            Add(item:  "1 Peter");
            Add(item:  "2 Peter");
            Add(item:  "1 John");
            Add(item:  "2 John");
            Add(item:  "3 John");
            Add(item:  "Jude");
            Add(item:  "Revelation");
            this.BibleCoverOther = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
