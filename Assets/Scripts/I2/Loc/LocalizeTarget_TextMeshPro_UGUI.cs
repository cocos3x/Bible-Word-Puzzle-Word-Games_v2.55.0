using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TMPro.TextMeshProUGUI>
    {
        // Fields
        public TMPro.TextAlignmentOptions mAlignment_RTL;
        public TMPro.TextAlignmentOptions mAlignment_LTR;
        public bool mAlignmentWasRTL;
        public bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_UGUI()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_UGUI.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "TextMeshPro UGUI";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshProUGUI, I2.Loc.LocalizeTarget_TextMeshPro_UGUI>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 9;
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
            string val_4;
            int val_5;
            val_4 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  21061632)) != false)
            {
                    val_4 = 19976488;
            }
            
            primaryTerm = val_4;
            if(11 != 0)
            {
                    string val_3 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 208.name;
            }
            else
            {
                    val_5 = System.String.alignConst;
            }
            
            secondaryTerm = val_5;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            TMPro.TMP_Text val_25;
            string val_26;
            var val_27;
            TMPro.TextAlignmentOptions val_28;
            TMPro.TextAlignmentOptions val_29;
            var val_30;
            TMPro.TextAlignmentOptions val_31;
            TMPro.TextAlignmentOptions val_32;
            var val_33;
            string val_2 = secondaryTranslation;
            string val_1 = mainTranslation;
            TMPro.TextAlignmentOptions val_21 = 0;
            TMPro.TMP_FontAsset val_3 = cmp.GetSecondaryTranslatedObj<TMPro.TMP_FontAsset>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
            val_25 = 1152921504689328128;
            if(val_3 != 0)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  X22, newFont:  val_3);
            }
            else
            {
                    UnityEngine.Material val_5 = cmp.GetSecondaryTranslatedObj<UnityEngine.Material>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
                bool val_6 = UnityEngine.Object.op_Inequality(x:  val_5, y:  0);
                if((val_6 != false) && (val_6.fontMaterial != val_5))
            {
                    if((val_5.name.StartsWith(value:  UnityEngine.Object.__il2cppRuntimeField_unity_user_data.name, comparisonType:  4)) != true)
            {
                    if((val_2.EndsWith(value:  val_5.name, comparisonType:  4)) != false)
            {
                    val_26 = val_2;
            }
            else
            {
                    val_26 = val_5.name;
            }
            
                TMPro.TMP_FontAsset val_15 = I2.Loc.LocalizeTarget_TextMeshPro_Label.GetTMPFontFromMaterial(cmp:  cmp, matName:  val_26);
                if(val_15 != 0)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  val_25, newFont:  val_15);
            }
            
            }
            
                I2.Loc.LocalizeTarget_TextMeshPro_Label.SetMaterial(label:  val_15, newMat:  val_5);
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_32;
            }
            
            this.mInitializeAlignment = false;
            val_27 = null;
            val_27 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            val_28 = this.mAlignment_RTL;
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignment:  I2.Loc.LocalizationManager.mCurrentLanguage.__il2cppRuntimeField_288, alignLTR: out  this.mAlignment_LTR, alignRTL: out  val_28);
            goto label_38;
            label_32:
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  (this.mAlignmentWasRTL == true) ? 1 : 0, alignment:  this.mInitializeAlignment + 648, alignLTR: out  val_21, alignRTL: out  val_21);
            if(this.mAlignmentWasRTL == false)
            {
                goto label_42;
            }
            
            val_29 = this;
            val_30 = 0;
            if(this.mAlignment_RTL == val_30)
            {
                goto label_45;
            }
            
            val_31 = 0;
            val_32 = this.mAlignment_LTR;
            goto label_44;
            label_42:
            val_32 = this;
            val_31 = 0;
            if(this.mAlignment_LTR == val_31)
            {
                goto label_45;
            }
            
            val_30 = 0;
            val_29 = this.mAlignment_RTL;
            label_44:
            this.mAlignment_LTR = val_31;
            mem2[0] = val_30;
            label_45:
            val_28 = 1152921504834908160;
            val_33 = null;
            val_33 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_38:
            if(val_1 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.IsRight2Left + 192, b:  val_1)) == false)
            {
                    return;
            }
            
            if((val_1 != 0) && (cmp.CorrectAlignmentForRTL != false))
            {
                    val_28 = 1152921504834908160;
                var val_23 = (I2.Loc.LocalizationManager.IsRight2Left == false) ? 36 : 32;
                cmp.alignment = null;
                cmp.isRightToLeftText = I2.Loc.LocalizationManager.IsRight2Left;
                if(I2.Loc.LocalizationManager.IsRight2Left != false)
            {
                    string val_24 = I2.Loc.I2Utils.ReverseText(source:  val_1);
            }
            
            }
            
            val_24.text = val_24;
        }
        public LocalizeTarget_TextMeshPro_UGUI()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 1.08858384102012E-311;
        }
    
    }

}
