using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class TermData
    {
        // Fields
        public string Term;
        public I2.Loc.eTermType TermType;
        public string Description;
        public string[] Languages;
        public byte[] Flags;
        private string[] Languages_Touch;
        
        // Methods
        public string GetTranslation(int idx, string specialization, bool editMode = False)
        {
            var val_3;
            string val_3 = this.Languages[idx];
            if(val_3 != null)
            {
                    if(editMode == true)
            {
                    return (string)val_3;
            }
            
                return I2.Loc.SpecializationManager.GetSpecializedText(text:  val_3, specialization:  specialization).Replace(oldValue:  "[i2nt]", newValue:  "").Replace(oldValue:  "[/i2nt]", newValue:  "");
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        public void SetTranslation(int idx, string translation, string specialization)
        {
            mem2[0] = I2.Loc.SpecializationManager.SetSpecializedText(text:  this.Languages[idx], newText:  translation, specialization:  specialization);
        }
        public void Validate()
        {
            System.String[] val_2 = this.Languages;
            int val_1 = UnityEngine.Mathf.Max(a:  this.Languages.Length, b:  this.Flags.Length);
            if(val_1 != this.Languages.Length)
            {
                    System.Array.Resize<System.String>(array: ref  val_2, newSize:  val_1);
            }
            
            if(val_1 != this.Flags.Length)
            {
                    System.Array.Resize<System.Byte>(array: ref  this.Flags, newSize:  val_1);
            }
            
            if(this.Languages_Touch == null)
            {
                    return;
            }
            
            var val_11 = 4;
            label_27:
            if((val_11 - 4) >= ((UnityEngine.Mathf.Min(a:  this.Languages_Touch.Length, b:  val_1)) << ))
            {
                goto label_12;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_2[0])) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  this.Languages_Touch[0])) != true)
            {
                    this.Languages[0] = this.Languages_Touch[0];
                this.Languages_Touch[0] = 0;
            }
            
            }
            
            val_11 = val_11 + 1;
            if(this.Languages_Touch != null)
            {
                goto label_27;
            }
            
            throw new NullReferenceException();
            label_12:
            this.Languages_Touch = 0;
        }
        public bool IsTerm(string name, bool allowCategoryMistmatch)
        {
            string val_2 = this.Term;
            if(allowCategoryMistmatch == false)
            {
                    return System.String.op_Equality(a:  name, b:  val_2 = I2.Loc.LanguageSourceData.GetKeyFromFullTerm(FullTerm:  val_2 = this.Term, OnlyMainCategory:  false));
            }
            
            return System.String.op_Equality(a:  name, b:  val_2);
        }
        public TermData()
        {
            this.Term = System.String.alignConst;
            this.Languages = new string[0];
            this.Flags = new byte[0];
        }
    
    }

}
