using UnityEngine;

namespace Logic.Game
{
    public class GameBible
    {
        // Fields
        private System.Collections.Generic.List<Data.Bean.BibleBean> bibleBeans;
        private System.Collections.Generic.List<Data.Bean.BibleSection> bibleSections;
        
        // Methods
        public void InitBible()
        {
            UnityEngine.TextAsset val_2 = Resource.ResManager.GetConfig(configName:  this.GetBibleConfigName());
            if(val_2 == 0)
            {
                    return;
            }
            
            if((UnityEngine.JsonUtility.FromJson<Data.Bean.BibleBeans>(json:  Common.EzFile.RijndaelDecrypt(pString:  val_2.text, pKey:  ""))) != null)
            {
                    this.bibleBeans = val_6.bibles;
                Data.Bean.BibleSections val_7 = Data.Bean.BibleBeanHelp.GetBibleSections(bibles:  val_6.bibles);
                this.bibleSections = val_7.sections;
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "BibleBean Init failed: bibleAsset json to object is null");
        }
        private string GetBibleConfigName()
        {
            var val_3;
            if((Locale.LocaleManager.GetCurLanguage() - 1) <= 2)
            {
                    val_3 = mem[19752576 + ((val_1 - 1)) << 3];
                val_3 = 19752576 + ((val_1 - 1)) << 3;
                return (string)val_3;
            }
            
            val_3 = "Config/Game/BibleLevel/bible_verse";
            return (string)val_3;
        }
        public bool IsDataEmpty()
        {
            return (bool)(this.bibleBeans == 0) ? 1 : 0;
        }
        public Data.Bean.BibleSection GetBibleSection()
        {
            return this.GetBibleSection(sectionIndex:  this.GetBibleSectionIndex());
        }
        public Data.Bean.BibleSection GetBibleSection(int sectionIndex)
        {
            System.Collections.Generic.List<Data.Bean.BibleSection> val_1;
            var val_2;
            val_1 = this.bibleSections;
            if(val_1 != null)
            {
                    val_1 = this.bibleSections;
                if(val_1 != null)
            {
                    var val_1 = 0;
            }
            
                val_2 = 0;
                if((sectionIndex & 2147483648) != 0)
            {
                    return (Data.Bean.BibleSection)val_2;
            }
            
                if(W9 <= sectionIndex)
            {
                    return (Data.Bean.BibleSection)val_2;
            }
            
                if(val_1 <= sectionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (sectionIndex << 3);
                val_2 = mem[(0 + (sectionIndex) << 3) + 32];
                val_2 = (0 + (sectionIndex) << 3) + 32;
                return (Data.Bean.BibleSection)val_2;
            }
            
            val_2 = 0;
            return (Data.Bean.BibleSection)val_2;
        }
        public int GetBibleSectionIndex()
        {
            var val_7;
            System.Collections.Generic.List<Data.Bean.BibleBean> val_8;
            var val_9;
            if(this.bibleSections == null)
            {
                goto label_8;
            }
            
            val_7 = 1152921512608190960;
            val_8 = this.bibleBeans;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) >= val_8)
            {
                goto label_5;
            }
            
            int val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex;
            val_9 = 0;
            val_7 = val_4 & (~(val_4 >> 31));
            label_16:
            if(val_9 >= val_8)
            {
                goto label_8;
            }
            
            if(val_8 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = val_9 + 1;
            if(this.bibleSections != null)
            {
                goto label_16;
            }
            
            label_8:
            val_9 = 0;
            return (int)val_9;
            label_5:
            val_9 = this.bibleSections - 1;
            return (int)val_9;
        }
        public int GetCurrentBibleSectionIndex(int sectionIndex)
        {
            System.Collections.Generic.List<Data.Bean.BibleBean> val_2;
            var val_3;
            if(this.bibleSections == null)
            {
                goto label_6;
            }
            
            val_2 = this.bibleBeans;
            if(val_2 <= sectionIndex)
            {
                goto label_4;
            }
            
            val_3 = 0;
            label_14:
            if(val_3 >= val_2)
            {
                goto label_6;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_3 = val_3 + 1;
            if(this.bibleSections != null)
            {
                goto label_14;
            }
            
            label_6:
            val_3 = 0;
            return (int)val_3;
            label_4:
            val_3 = val_2 - 1;
            return (int)val_3;
        }
        public int GetBibleSectionCount()
        {
            var val_1;
            if(this.bibleSections != null)
            {
                    return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public int GetCollectBookCount()
        {
            var val_3;
            var val_4;
            val_3 = 4;
            label_9:
            var val_1 = val_3 - 4;
            if(val_1 >= 6973)
            {
                    return (int)val_4;
            }
            
            if(6973 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0.collectCount != 0.maxCount)
            {
                goto label_8;
            }
            
            val_3 = val_3 + 1;
            if(this.bibleSections != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_8:
            val_4 = val_3 - 4;
            return (int)val_4;
        }
        public int GetCollectVerseCount()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 4;
            do
            {
                var val_1 = val_4 - 4;
                if(val_1 >= true)
            {
                    return (int)val_3;
            }
            
                if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(0.collectCount == 0)
            {
                    return (int)val_3;
            }
            
                if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = 0.collectCount + val_3;
                val_4 = val_4 + 1;
            }
            while(this.bibleSections != null);
            
            throw new NullReferenceException();
        }
        public string GetBibleProgress(int sectionIndex)
        {
            object val_10;
            Data.Bean.BibleSection val_2 = this.GetBibleSection(sectionIndex:  this.GetCurrentBibleSectionIndex(sectionIndex:  sectionIndex));
            if(W9 >= 1)
            {
                    int val_10 = val_2.chapter_start;
                val_10 = (sectionIndex + 1) - val_10;
                val_10 = val_10;
                Data.UserPlayer.UserPlayerDataManager val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                int val_11 = val_4.<CurrentLevelIndex>k__BackingField;
                val_11 = val_11 + 1;
                string val_5 = System.String.Format(format:  "{0} {1}-{2}", arg0:  this, arg1:  val_10, arg2:  val_11);
                return (string)System.String.Format(format:  "{0}-{1}", arg0:  val_12 = (sectionIndex + 1) - val_12, arg1:  val_13 = val_13 + 1)(System.String.Format(format:  "{0}-{1}", arg0:  val_12 = (sectionIndex + 1) - val_12, arg1:  val_13 = val_13 + 1)) + " ";
            }
            
            int val_12 = val_2.chapter_start;
            val_10 = val_12;
            Data.UserPlayer.UserPlayerDataManager val_7 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            int val_13 = val_7.<CurrentLevelIndex>k__BackingField;
            return (string)System.String.Format(format:  "{0}-{1}", arg0:  val_12, arg1:  val_13)(System.String.Format(format:  "{0}-{1}", arg0:  val_12, arg1:  val_13)) + " ";
        }
        public string GetBible(int levelSectionIndex)
        {
            var val_1;
            bool val_1 = true;
            if((this.bibleBeans != null) && (val_1 > levelSectionIndex))
            {
                    if(val_1 <= levelSectionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (levelSectionIndex << 3);
                val_1 = ((true + (levelSectionIndex) << 3) + 32) + 32;
                return (string)val_1;
            }
            
            val_1 = "";
            return (string)val_1;
        }
        public string GetReference(int levelSectionIndex)
        {
            var val_1;
            bool val_1 = true;
            if((this.bibleBeans != null) && (val_1 > levelSectionIndex))
            {
                    if(val_1 <= levelSectionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (levelSectionIndex << 3);
                val_1 = ((true + (levelSectionIndex) << 3) + 32) + 40;
                return (string)val_1;
            }
            
            val_1 = "";
            return (string)val_1;
        }
        private int GetCount()
        {
            var val_1;
            if(this.bibleBeans != null)
            {
                    return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public GameBible()
        {
        
        }
    
    }

}
