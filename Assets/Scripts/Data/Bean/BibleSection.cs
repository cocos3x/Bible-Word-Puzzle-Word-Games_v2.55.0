using UnityEngine;

namespace Data.Bean
{
    public class BibleSection : IComparable<Data.Bean.BibleSection>
    {
        // Fields
        public string res;
        public string name;
        public string desc;
        public int chapter_start;
        public int chapter_end;
        public System.Collections.Generic.List<Data.Bean.BibleBean> bibles;
        
        // Properties
        public int maxCount { get; }
        public int collectCount { get; }
        
        // Methods
        public int get_maxCount()
        {
            return 2390;
        }
        public int get_collectCount()
        {
            return UnityEngine.Mathf.Clamp(value:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) - this.chapter_start, min:  0, max:  this.maxCount);
        }
        public string GetStartString()
        {
            int val_2 = this.chapter_start;
            val_2 = val_2 + 1;
            return (string)System.String.Format(format:  "{0}-1", arg0:  val_2);
        }
        public string GetEndString()
        {
            int val_3 = this.chapter_end;
            val_3 = val_3 + 1;
            return (string)System.String.Format(format:  "{0}-{1}", arg0:  val_3, arg1:  Logic.Game.GameManager.gameLevel.GetCount(section:  this.chapter_end));
        }
        private int System.IComparable<Data.Bean.BibleSection>.CompareTo(Data.Bean.BibleSection other)
        {
            if(other == null)
            {
                    return 1;
            }
            
            return this.chapter_start.CompareTo(value:  other.chapter_start);
        }
        public override string ToString()
        {
            object[] val_1 = new object[4];
            val_1[0] = this.name;
            val_1[1] = this.GetStartString();
            val_1[2] = this.GetEndString();
            val_1[3] = this.bibles;
            return (string)System.String.Format(format:  "BibleSections name:{0}, start:{1}, end:{2}, bibles count: {3}", args:  val_1);
        }
        public BibleSection()
        {
            this.bibles = new System.Collections.Generic.List<Data.Bean.BibleBean>();
        }
    
    }

}
