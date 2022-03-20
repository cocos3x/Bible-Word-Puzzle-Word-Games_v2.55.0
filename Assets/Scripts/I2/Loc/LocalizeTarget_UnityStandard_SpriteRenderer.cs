using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<UnityEngine.SpriteRenderer>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_SpriteRenderer()
        {
            I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "SpriteRenderer";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.SpriteRenderer, I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 5;
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
            int val_5;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  9777.sprite, y:  0);
            if(val_2 != false)
            {
                    string val_4 = val_2.sprite.name;
            }
            else
            {
                    val_5 = System.String.alignConst;
            }
            
            primaryTerm = val_5;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Sprite val_1 = 9776.sprite;
            if(val_1 != 0)
            {
                    if((System.String.op_Inequality(a:  val_1.name, b:  mainTranslation)) == false)
            {
                    return;
            }
            
            }
            
            this.sprite = cmp.FindTranslatedObject<UnityEngine.Sprite>(value:  mainTranslation);
        }
        public LocalizeTarget_UnityStandard_SpriteRenderer()
        {
        
        }
    
    }

}
