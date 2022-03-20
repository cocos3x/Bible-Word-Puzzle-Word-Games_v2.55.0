using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_Image : LocalizeTarget<UnityEngine.UI.Image>
    {
        // Methods
        private static LocalizeTarget_UnityUI_Image()
        {
            I2.Loc.LocalizeTarget_UnityUI_Image.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "Image";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Image, I2.Loc.LocalizeTarget_UnityUI_Image>());
        }
        public override bool CanUseSecondaryTerm()
        {
            return false;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return false;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return (I2.Loc.eTermType)(78033 != 0) ? 2 : 5;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_8;
            string val_9;
            val_8 = this;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  9785);
            if(val_1 != false)
            {
                    string val_2 = val_1.name;
            }
            else
            {
                    val_9 = "";
            }
            
            primaryTerm = val_9;
            if("Hashtable insert failed. Load factor too high. The most common cause is multiple threads writing to the Hashtable simultaneously." != 0)
            {
                    if((System.String.op_Inequality(a:  UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 192.name, b:  primaryTerm)) != false)
            {
                    val_8 = primaryTerm;
                primaryTerm = val_8 + "." + UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 192.name(UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 192.name);
            }
            
            }
            
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            if(78033 != 0)
            {
                    if((System.String.op_Inequality(a:  78033.name, b:  mainTranslation)) == false)
            {
                    return;
            }
            
            }
            
            this.sprite = cmp.FindTranslatedObject<UnityEngine.Sprite>(value:  mainTranslation);
        }
        public LocalizeTarget_UnityUI_Image()
        {
        
        }
    
    }

}
