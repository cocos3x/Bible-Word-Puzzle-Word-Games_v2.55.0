using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_Text : LocalizeTarget<UnityEngine.UI.Text>
    {
        // Fields
        private UnityEngine.TextAnchor mAlignment_RTL;
        private UnityEngine.TextAnchor mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_UnityUI_Text()
        {
            I2.Loc.LocalizeTarget_UnityUI_Text.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "Text";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Text, I2.Loc.LocalizeTarget_UnityUI_Text>());
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
            string val_6;
            int val_7;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  21061632);
            val_6 = 0;
            primaryTerm = val_6;
            bool val_3 = UnityEngine.Object.op_Inequality(x:  val_6.font, y:  0);
            if(val_3 != false)
            {
                    string val_5 = val_3.font.name;
            }
            else
            {
                    val_7 = System.String.alignConst;
            }
            
            secondaryTerm = val_7;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_15;
            var val_16;
            UnityEngine.TextAnchor val_17;
            var val_18;
            UnityEngine.TextAnchor val_19;
            UnityEngine.TextAnchor val_20;
            string val_21;
            string val_1 = mainTranslation;
            UnityEngine.TextAnchor val_12 = 0;
            UnityEngine.Font val_3 = cmp.GetSecondaryTranslatedObj<UnityEngine.Font>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            bool val_4 = UnityEngine.Object.op_Inequality(x:  val_3, y:  0);
            if(val_4 != false)
            {
                    bool val_6 = UnityEngine.Object.op_Inequality(x:  val_3, y:  val_4.font);
                if(val_6 != false)
            {
                    val_6.font = val_3;
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_10;
            }
            
            this.mInitializeAlignment = false;
            val_15 = null;
            val_15 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            UnityEngine.TextAnchor val_8 = alignment;
            val_8.InitAlignment(isRTL:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignment:  val_8, alignLTR: out  this.mAlignment_LTR, alignRTL: out  this.mAlignment_RTL);
            goto label_14;
            label_10:
            UnityEngine.TextAnchor val_11 = val_6.alignment;
            val_11.InitAlignment(isRTL:  this.mAlignmentWasRTL, alignment:  val_11, alignLTR: out  val_12, alignRTL: out  val_12);
            if(this.mAlignmentWasRTL == false)
            {
                goto label_16;
            }
            
            val_17 = this;
            val_18 = 0;
            if(this.mAlignment_RTL == val_18)
            {
                goto label_19;
            }
            
            val_19 = 0;
            val_20 = this.mAlignment_LTR;
            goto label_18;
            label_16:
            val_20 = this;
            val_19 = 0;
            if(this.mAlignment_LTR == val_19)
            {
                goto label_19;
            }
            
            val_18 = 0;
            val_17 = this.mAlignment_RTL;
            label_18:
            this.mAlignment_LTR = val_19;
            mem2[0] = val_18;
            label_19:
            val_16 = 1152921504834908160;
            val_21 = null;
            val_21 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_14:
            if(val_1 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  val_21, b:  val_1)) == false)
            {
                    return;
            }
            
            if(cmp.CorrectAlignmentForRTL == false)
            {
                    return;
            }
            
            val_16 = 1152921504834908160;
            var val_14 = (I2.Loc.LocalizationManager.IsRight2Left == false) ? 36 : 32;
            cmp.alignment = null;
        }
        private void InitAlignment(bool isRTL, UnityEngine.TextAnchor alignment, out UnityEngine.TextAnchor alignLTR, out UnityEngine.TextAnchor alignRTL)
        {
            alignRTL = alignment;
            alignLTR = alignment;
            if(isRTL != false)
            {
                    if(alignment > 8)
            {
                    return;
            }
            
                var val_1 = 15448468 + (alignment) << 2;
                val_1 = val_1 + 15448468;
            }
            else
            {
                    if(alignment > 8)
            {
                    return;
            }
            
                var val_2 = 15448432 + (alignment) << 2;
                val_2 = val_2 + 15448432;
            }
        
        }
        public LocalizeTarget_UnityUI_Text()
        {
            this.mAlignment_RTL = 2;
            this.mInitializeAlignment = true;
        }
    
    }

}
