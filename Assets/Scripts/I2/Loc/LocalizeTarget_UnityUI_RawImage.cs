using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<UnityEngine.UI.RawImage>
    {
        // Methods
        private static LocalizeTarget_UnityUI_RawImage()
        {
            I2.Loc.LocalizeTarget_UnityUI_RawImage.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "RawImage";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.RawImage, I2.Loc.LocalizeTarget_UnityUI_RawImage>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 2;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
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
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_4;
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  9790.GetCharCount(bytes:  ???, count:  ???, baseDecoder:  ???));
            if(val_2 != false)
            {
                    string val_3 = val_2.name;
            }
            else
            {
                    val_4 = "";
            }
            
            primaryTerm = val_4;
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
            
            this.texture = cmp.FindTranslatedObject<UnityEngine.Texture>(value:  mainTranslation);
        }
        public LocalizeTarget_UnityUI_RawImage()
        {
        
        }
    
    }

}
