using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TMPro.TextMeshPro>
    {
        // Fields
        private TMPro.TextAlignmentOptions mAlignment_RTL;
        private TMPro.TextAlignmentOptions mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_Label()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_Label.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "TextMeshPro Label";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshPro, I2.Loc.LocalizeTarget_TextMeshPro_Label>());
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
            string val_4;
            int val_5;
            val_4 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  static_value_01417000)) != false)
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
        internal static TMPro.TMP_FontAsset GetTMPFontFromMaterial(I2.Loc.Localize cmp, string matName)
        {
            int val_10;
            UnityEngine.Object val_11;
            val_10 = matName.m_stringLength - 1;
            if(val_10 < 1)
            {
                goto label_11;
            }
            
            label_14:
            if(((IndexOf(value:  matName.Chars[val_10])) & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_10 = val_10 - 1;
            if(val_10 >= 2)
            {
                goto label_14;
            }
            
            goto label_11;
            label_4:
            val_11 = cmp.GetObject<TMPro.TMP_FontAsset>(Translation:  matName.Substring(startIndex:  0, length:  val_10 + 1));
            if(val_11 != 0)
            {
                    return (TMPro.TMP_FontAsset)val_11;
            }
            
            if(val_10 < 1)
            {
                goto label_11;
            }
            
            label_13:
            if(((IndexOf(value:  matName.Chars[val_10])) & 2147483648) == 0)
            {
                goto label_12;
            }
            
            val_10 = val_10 - 1;
            if(val_10 > 1)
            {
                goto label_13;
            }
            
            label_12:
            if(val_10 >= 1)
            {
                goto label_14;
            }
            
            label_11:
            val_11 = 0;
            return (TMPro.TMP_FontAsset)val_11;
        }
        internal static void InitAlignment_TMPro(bool isRTL, TMPro.TextAlignmentOptions alignment, out TMPro.TextAlignmentOptions alignLTR, out TMPro.TextAlignmentOptions alignRTL)
        {
            var val_1;
            alignRTL = alignment;
            alignLTR = alignment;
            if(isRTL == false)
            {
                goto label_0;
            }
            
            if(alignment <= 1028)
            {
                goto label_1;
            }
            
            if(alignment <= 4097)
            {
                goto label_2;
            }
            
            if(alignment == 4100)
            {
                goto label_3;
            }
            
            if(alignment == 8193)
            {
                goto label_4;
            }
            
            if(alignment != 8196)
            {
                    return;
            }
            
            alignLTR = 8193;
            return;
            label_0:
            if(alignment <= 1028)
            {
                goto label_6;
            }
            
            if(alignment <= 4097)
            {
                goto label_7;
            }
            
            if(alignment == 4100)
            {
                goto label_8;
            }
            
            if(alignment == 8193)
            {
                goto label_9;
            }
            
            if(alignment != 8196)
            {
                    return;
            }
            
            val_1 = 8193;
            goto label_41;
            label_1:
            if(alignment <= 513)
            {
                goto label_12;
            }
            
            if(alignment == 516)
            {
                goto label_13;
            }
            
            if(alignment == 1025)
            {
                goto label_14;
            }
            
            if(alignment != 1028)
            {
                    return;
            }
            
            alignLTR = 1025;
            return;
            label_6:
            if(alignment <= 513)
            {
                goto label_16;
            }
            
            if(alignment == 516)
            {
                goto label_17;
            }
            
            if(alignment == 1025)
            {
                goto label_18;
            }
            
            if(alignment != 1028)
            {
                    return;
            }
            
            val_1 = 1025;
            goto label_41;
            label_2:
            if(alignment == 2049)
            {
                goto label_21;
            }
            
            if(alignment == 2052)
            {
                goto label_22;
            }
            
            if(alignment != 4097)
            {
                    return;
            }
            
            alignLTR = 4100;
            return;
            label_7:
            if(alignment == 2049)
            {
                goto label_24;
            }
            
            if(alignment == 2052)
            {
                goto label_25;
            }
            
            if(alignment != 4097)
            {
                    return;
            }
            
            val_1 = 4100;
            goto label_41;
            label_12:
            if(alignment == 257)
            {
                goto label_28;
            }
            
            if(alignment == 260)
            {
                goto label_29;
            }
            
            if(alignment != 513)
            {
                    return;
            }
            
            alignLTR = 516;
            return;
            label_16:
            if(alignment == 257)
            {
                goto label_31;
            }
            
            if(alignment == 260)
            {
                goto label_32;
            }
            
            if(alignment != 513)
            {
                    return;
            }
            
            val_1 = 516;
            goto label_41;
            label_3:
            alignLTR = 4097;
            return;
            label_4:
            alignLTR = 8196;
            return;
            label_8:
            val_1 = 4097;
            goto label_41;
            label_9:
            val_1 = 8196;
            goto label_41;
            label_13:
            alignLTR = 513;
            return;
            label_14:
            alignLTR = 1028;
            return;
            label_17:
            val_1 = 513;
            goto label_41;
            label_18:
            val_1 = 1028;
            goto label_41;
            label_21:
            alignLTR = 2052;
            return;
            label_22:
            alignLTR = 2049;
            return;
            label_24:
            val_1 = 2052;
            goto label_41;
            label_25:
            val_1 = 2049;
            goto label_41;
            label_28:
            alignLTR = 260;
            return;
            label_29:
            alignLTR = 257;
            return;
            label_31:
            val_1 = 260;
            goto label_41;
            label_32:
            val_1 = 257;
            label_41:
            alignRTL = 257;
        }
        internal static void SetFont(TMPro.TMP_Text label, TMPro.TMP_FontAsset newFont)
        {
            goto label_2;
            label_10:
            label = label.m_linkedTextComponent;
            label_2:
            if(label.m_linkedTextComponent.m_fontAsset != newFont)
            {
                    label.font = newFont;
            }
            
            if(label.m_linkedTextComponent.m_linkedTextComponent != 0)
            {
                goto label_10;
            }
        
        }
        internal static void SetMaterial(TMPro.TMP_Text label, UnityEngine.Material newMat)
        {
            goto label_2;
            label_10:
            label = label.m_linkedTextComponent;
            label_2:
            bool val_1 = UnityEngine.Object.op_Inequality(x:  label, y:  newMat);
            if(label.m_linkedTextComponent.m_linkedTextComponent != 0)
            {
                goto label_10;
            }
        
        }
        public LocalizeTarget_TextMeshPro_Label()
        {
            this.mInitializeAlignment = true;
            this.mAlignment_RTL = 1.08858384102012E-311;
        }
    
    }

}
