using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<UnityEngine.TextMesh>
    {
        // Fields
        private UnityEngine.TextAlignment mAlignment_RTL;
        private UnityEngine.TextAlignment mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_UnityStandard_TextMesh()
        {
            I2.Loc.LocalizeTarget_UnityStandard_TextMesh.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "TextMesh";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.TextMesh, I2.Loc.LocalizeTarget_UnityStandard_TextMesh>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 1;
        }
        public override bool CanUseSecondaryTerm()
        {
            return true;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return true;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_8;
            var val_9;
            var val_10;
            val_8 = Secondary;
            val_9 = 0;
            primaryTerm = val_9.text;
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  val_8)) != false)
            {
                    val_8 = val_10.font;
                val_10 = 0;
            }
            
            secondaryTerm = val_10.font.name;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            string val_1 = mainTranslation;
            val_15 = cmp.GetSecondaryTranslatedObj<UnityEngine.Font>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            bool val_4 = UnityEngine.Object.op_Inequality(x:  val_15, y:  0);
            if(val_4 != false)
            {
                    bool val_6 = UnityEngine.Object.op_Inequality(x:  val_4.font, y:  val_15);
                if(val_6 != false)
            {
                    val_6.font = val_15;
                UnityEngine.MeshRenderer val_7 = val_6.GetComponentInChildren<UnityEngine.MeshRenderer>();
                val_7.material = val_15.material;
            }
            
            }
            
            if(this.mInitializeAlignment != false)
            {
                    this.mInitializeAlignment = false;
                UnityEngine.TextAlignment val_9 = val_7.alignment;
                this.mAlignment_RTL = val_9;
                this.mAlignment_LTR = val_9;
                val_15 = 1152921504834908160;
                val_16 = null;
                val_16 = null;
                val_17 = val_16;
                if((I2.Loc.LocalizationManager.IsRight2Left != false) && (this.mAlignment_RTL == 2))
            {
                    this.mAlignment_LTR = 0;
            }
            
                val_17 = 1152921504834908344;
                if((I2.Loc.LocalizationManager.IsRight2Left != true) && (this.mAlignment_LTR == 0))
            {
                    this.mAlignment_RTL = 2;
            }
            
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            bool val_11 = System.String.op_Inequality(a:  null.text, b:  val_1);
            if(val_11 == false)
            {
                    return;
            }
            
            if(cmp.CorrectAlignmentForRTL != false)
            {
                    if(val_11.alignment != 1)
            {
                    val_15 = 1152921504834908160;
                var val_13 = (I2.Loc.LocalizationManager.IsRight2Left == false) ? 36 : 32;
                cmp.alignment = null;
            }
            
            }
            
            UnityEngine.Font val_14 = cmp.font;
            val_14.RequestCharactersInTexture(characters:  val_1);
            val_14.text = val_1;
        }
        public LocalizeTarget_UnityStandard_TextMesh()
        {
            this.mAlignment_RTL = 2;
            this.mInitializeAlignment = true;
        }
    
    }

}
