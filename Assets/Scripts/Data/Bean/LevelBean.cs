using UnityEngine;

namespace Data.Bean
{
    [Serializable]
    public class LevelBean
    {
        // Fields
        public string l;
        public string t;
        public System.Collections.Generic.List<string> a;
        private System.Collections.Generic.List<string> _answerList;
        private System.Collections.Generic.List<string> _allAnswerList;
        
        // Properties
        public string Letters { get; }
        public System.Collections.Generic.List<string> answerList { get; set; }
        public System.Collections.Generic.List<string> AllAnswerList { get; set; }
        
        // Methods
        public string get_Letters()
        {
            return (string)this.l;
        }
        public System.Collections.Generic.List<string> get_answerList()
        {
            System.Collections.Generic.List<System.String> val_6 = this._answerList;
            if(val_6 != null)
            {
                    return val_6;
            }
            
            this._answerList = new System.Collections.Generic.List<System.String>();
            var val_7 = 4;
            label_25:
            var val_2 = val_7 - 4;
            if(val_2 >= 1152921507302932960)
            {
                goto label_21;
            }
            
            if(1152921507302932960 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Equals(value:  Logic.Define.ApplicationConfig.BonusIdentifier)) == true)
            {
                goto label_8;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((Logic.Define.ApplicationConfig.DynamicIdentifier.Equals(value:  Logic.Define.ApplicationConfig.ExtrasIdentifier)) == false)
            {
                goto label_14;
            }
            
            label_8:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((Logic.Define.ApplicationConfig.DynamicIdentifier.Equals(value:  Logic.Define.ApplicationConfig.ExtrasIdentifier)) == false)
            {
                goto label_20;
            }
            
            goto label_21;
            label_14:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this._answerList.Add(item:  Logic.Define.ApplicationConfig.DynamicIdentifier);
            label_20:
            val_7 = val_7 + 1;
            if(this.a != null)
            {
                goto label_25;
            }
            
            label_21:
            this._answerList.Sort(comparer:  new System.Object());
            val_6 = this._answerList;
            return val_6;
        }
        public void set_answerList(System.Collections.Generic.List<string> value)
        {
            this._answerList = value;
        }
        public System.Collections.Generic.List<string> get_AllAnswerList()
        {
            System.Collections.Generic.List<System.String> val_5 = this._allAnswerList;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            this._allAnswerList = new System.Collections.Generic.List<System.String>();
            var val_6 = 4;
            label_18:
            var val_2 = val_6 - 4;
            if(val_2 >= 1152921507302932960)
            {
                goto label_3;
            }
            
            if(1152921507302932960 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((Equals(value:  Logic.Define.ApplicationConfig.BonusIdentifier)) != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if((Logic.Define.ApplicationConfig.DynamicIdentifier.Equals(value:  Logic.Define.ApplicationConfig.ExtrasIdentifier)) != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                this._allAnswerList.Add(item:  Logic.Define.ApplicationConfig.DynamicIdentifier);
            }
            
            }
            
            val_6 = val_6 + 1;
            if(this.a != null)
            {
                goto label_18;
            }
            
            label_3:
            this._allAnswerList.Sort(comparer:  new System.Object());
            val_5 = this._allAnswerList;
            return val_5;
        }
        public void set_AllAnswerList(System.Collections.Generic.List<string> value)
        {
            this._allAnswerList = value;
        }
        public bool HasBonus()
        {
            var val_4;
            if((this.a.Contains(item:  Logic.Define.ApplicationConfig.BonusIdentifier)) != false)
            {
                    System.Collections.Generic.List<System.String> val_4 = this.a;
                val_4 = val_4 - 1;
                var val_3 = ((this.a.IndexOf(item:  Logic.Define.ApplicationConfig.BonusIdentifier)) < val_4) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public int HasBonusCount()
        {
            var val_5;
            System.Collections.Generic.List<System.String> val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = 1152921504819572736;
            if((this.a.Contains(item:  Logic.Define.ApplicationConfig.BonusIdentifier)) == false)
            {
                goto label_4;
            }
            
            val_6 = this.a;
            if((this.a.Contains(item:  Logic.Define.ApplicationConfig.ExtrasIdentifier)) == false)
            {
                goto label_8;
            }
            
            val_6 = this.a;
            val_7 = val_6.IndexOf(item:  Logic.Define.ApplicationConfig.ExtrasIdentifier);
            val_8 = null;
            goto label_16;
            label_4:
            val_9 = 0;
            return (int)val_9;
            label_8:
            val_8 = null;
            label_16:
            val_9 = this + (~(val_6.IndexOf(item:  Logic.Define.ApplicationConfig.BonusIdentifier)));
            if(>=0)
            {
                    return (int)val_9;
            }
            
            val_5 = public static T[] System.Array::Empty<System.Object>();
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "LevelBean HasBonusCount 数据错误... ", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return (int)val_9;
        }
        public bool WordIsAnswer(string word)
        {
            System.Collections.Generic.List<System.String> val_1 = this.AllAnswerList;
            if(true < 1)
            {
                    return false;
            }
            
            return this.AllAnswerList.Contains(item:  word);
        }
        public void CopyLevelBean(Data.Bean.LevelBean newBean)
        {
            if(newBean != null)
            {
                    this.l = newBean.l;
                this.a = newBean.a;
                return;
            }
            
            throw new NullReferenceException();
        }
        public LevelBean()
        {
        
        }
    
    }

}
