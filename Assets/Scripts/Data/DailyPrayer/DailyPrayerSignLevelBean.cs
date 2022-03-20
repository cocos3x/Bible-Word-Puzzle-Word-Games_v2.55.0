using UnityEngine;

namespace Data.DailyPrayer
{
    [Serializable]
    public class DailyPrayerSignLevelBean
    {
        // Fields
        public int levelIndex;
        public string letters;
        public System.Collections.Generic.List<string> answers;
        public System.Collections.Generic.List<string> bonus;
        public System.Collections.Generic.List<string> extras;
        private System.Collections.Generic.List<string> _answerList;
        private System.Collections.Generic.List<string> _allAnswerList;
        private char _doveLetter;
        
        // Properties
        public System.Collections.Generic.List<string> answerList { get; set; }
        public System.Collections.Generic.List<string> AllAnswerList { get; set; }
        
        // Methods
        public System.Collections.Generic.List<string> get_answerList()
        {
            System.Collections.Generic.List<System.String> val_3 = this._answerList;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            this._answerList = val_1;
            Utils.Extensions.ListExtension.AddAdll<System.String>(list:  val_1, source:  this.bonus);
            Utils.Extensions.ListExtension.AddAdll<System.String>(list:  this._answerList, source:  this.answers);
            this._answerList.Sort(comparer:  new System.Object());
            val_3 = this._answerList;
            return val_3;
        }
        public void set_answerList(System.Collections.Generic.List<string> value)
        {
            this._answerList = value;
        }
        public System.Collections.Generic.List<string> get_AllAnswerList()
        {
            System.Collections.Generic.List<System.String> val_3 = this._allAnswerList;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            this._allAnswerList = val_1;
            Utils.Extensions.ListExtension.AddAdll<System.String>(list:  val_1, source:  this.bonus);
            Utils.Extensions.ListExtension.AddAdll<System.String>(list:  this._allAnswerList, source:  this.answers);
            Utils.Extensions.ListExtension.AddAdll<System.String>(list:  this._allAnswerList, source:  this.extras);
            this._allAnswerList.Sort(comparer:  new System.Object());
            val_3 = this._allAnswerList;
            return val_3;
        }
        public void set_AllAnswerList(System.Collections.Generic.List<string> value)
        {
            this._allAnswerList = value;
        }
        public char RandomDoveLetter(System.Collections.Generic.List<string> allWords, bool isNew = True)
        {
            var val_12;
            var val_13;
            Data.DailyPrayer.DailyPrayerSignLevelBean val_14;
            char val_15;
            val_13 = isNew;
            val_14 = this;
            if(val_13 == false)
            {
                    return val_15;
            }
            
            this._doveLetter = 0;
            if(true < 2)
            {
                goto label_3;
            }
            
            val_12 = 1152921508224013648;
            val_13 = System.String.Join(separator:  ",", value:  allWords.ToArray()).Replace(oldValue:  ",", newValue:  "");
            label_12:
            if(val_3.m_stringLength <= 0)
            {
                goto label_6;
            }
            
            object val_4 = null;
            val_14 = val_4;
            val_4 = new System.Object();
            int val_7 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Random.Range(min:  0, max:  val_3.m_stringLength), min:  0, max:  val_3.m_stringLength - 1);
            typeof(DailyPrayerSignLevelBean.<>c__DisplayClass14_0).__il2cppRuntimeField_10 = val_13.Chars[val_7];
            System.Collections.Generic.List<T> val_10 = allWords.FindAll(match:  new System.Predicate<System.String>(object:  val_14, method:  System.Boolean DailyPrayerSignLevelBean.<>c__DisplayClass14_0::<RandomDoveLetter>b__0(string x)));
            if(null >= 3)
            {
                goto label_11;
            }
            
            string val_11 = val_13.Remove(startIndex:  val_7, count:  1);
            val_13 = val_11;
            if(val_11 != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_3:
            val_15 = 0;
            return val_15;
            label_6:
            val_15 = this._doveLetter;
            return val_15;
            label_11:
            val_15 = typeof(DailyPrayerSignLevelBean.<>c__DisplayClass14_0).__il2cppRuntimeField_10;
            mem[1152921513058763688] = val_15;
            return val_15;
        }
        public char GetDoveLetter()
        {
            return (char)this._doveLetter;
        }
        public bool HasBonus()
        {
            var val_2;
            if(this.bonus != null)
            {
                    var val_1 = (this.bonus != 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public bool WordIsBonus(string word)
        {
            if(this.bonus == null)
            {
                    return false;
            }
            
            if(true == 0)
            {
                    return false;
            }
            
            return this.bonus.Contains(item:  word);
        }
        public bool isMatchByActiveDays(int activeDays)
        {
            return (bool)(this.levelIndex == activeDays) ? 1 : 0;
        }
        public DailyPrayerSignLevelBean()
        {
        
        }
    
    }

}
