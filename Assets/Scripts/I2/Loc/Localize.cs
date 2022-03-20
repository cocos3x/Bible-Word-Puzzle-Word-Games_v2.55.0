using UnityEngine;

namespace I2.Loc
{
    public class Localize : MonoBehaviour
    {
        // Fields
        public string mTerm;
        public string mTermSecondary;
        public string FinalTerm;
        public string FinalSecondaryTerm;
        public I2.Loc.Localize.TermModification PrimaryTermModifier;
        public I2.Loc.Localize.TermModification SecondaryTermModifier;
        public string TermPrefix;
        public string TermSuffix;
        public bool LocalizeOnAwake;
        private string LastLocalizedLanguage;
        public bool IgnoreRTL;
        public int MaxCharactersInRTL;
        public bool IgnoreNumbersInRTL;
        public bool CorrectAlignmentForRTL;
        public bool AddSpacesToJoinedLanguages;
        public bool AllowLocalizedParameters;
        public bool AllowParameters;
        public System.Collections.Generic.List<UnityEngine.Object> TranslatedObjects;
        public System.Collections.Generic.Dictionary<string, UnityEngine.Object> mAssetDictionary;
        public UnityEngine.Events.UnityEvent LocalizeEvent;
        public static string MainTranslation;
        public static string SecondaryTranslation;
        public static string CallBackTerm;
        public static string CallBackSecondaryTerm;
        public static I2.Loc.Localize CurrentLocalizeComponent;
        public bool AlwaysForceLocalize;
        public I2.Loc.EventCallback LocalizeCallBack;
        public bool mGUI_ShowReferences;
        public bool mGUI_ShowTems;
        public bool mGUI_ShowCallback;
        public I2.Loc.ILocalizeTarget mLocalizeTarget;
        public string mLocalizeTargetName;
        
        // Properties
        public string Term { get; set; }
        public string SecondaryTerm { get; set; }
        
        // Methods
        public string get_Term()
        {
            return (string)this.mTerm;
        }
        public void set_Term(string value)
        {
            this.SetTerm(primary:  value);
        }
        public string get_SecondaryTerm()
        {
            return (string)this.mTermSecondary;
        }
        public void set_SecondaryTerm(string value)
        {
            this.SetTerm(primary:  0, secondary:  value);
        }
        private void Awake()
        {
            this.UpdateAssetDictionary();
            bool val_1 = this.FindTarget();
            if(this.LocalizeOnAwake == false)
            {
                    return;
            }
            
            this.OnLocalize(Force:  false);
        }
        private void OnEnable()
        {
            this.OnLocalize(Force:  false);
        }
        public bool HasCallback()
        {
            var val_4;
            if(this.LocalizeCallBack.HasCallback() == false)
            {
                    return (bool)(this.LocalizeEvent.GetPersistentEventCount() > 0) ? 1 : 0;
            }
            
            val_4 = 1;
            return (bool)(this.LocalizeEvent.GetPersistentEventCount() > 0) ? 1 : 0;
        }
        public void OnLocalize(bool Force = False)
        {
            string val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            UnityEngine.GameObject val_67;
            var val_68;
            var val_69;
            string val_71;
            var val_72;
            char val_73;
            var val_74;
            var val_76;
            if(Force == false)
            {
                goto label_1;
            }
            
            label_23:
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.CurrentLanguage)) == true)
            {
                    return;
            }
            
            if((this.AlwaysForceLocalize != true) && (Force != true))
            {
                    if(this.HasCallback() != true)
            {
                    if((System.String.op_Equality(a:  this.LastLocalizedLanguage, b:  I2.Loc.LocalizationManager.CurrentLanguage)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            string val_9 = this.FinalTerm;
            this.LastLocalizedLanguage = I2.Loc.LocalizationManager.CurrentLanguage;
            val_61 = 1152921513204880080;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                goto label_13;
            }
            
            string val_10 = this.FinalSecondaryTerm;
            if((System.String.IsNullOrEmpty(value:  val_10)) == false)
            {
                goto label_14;
            }
            
            label_13:
            this.GetFinalTerms(primaryTerm: out  val_9, secondaryTerm: out  val_10);
            label_14:
            if((UnityEngine.Application.isPlaying == false) || (this.HasCallback() == false))
            {
                goto label_16;
            }
            
            val_62 = 1;
            goto label_17;
            label_1:
            if(this.enabled == false)
            {
                    return;
            }
            
            val_61 = this.gameObject;
            if(val_61 == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == true)
            {
                goto label_23;
            }
            
            return;
            label_16:
            if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  this.FinalSecondaryTerm)) == true)
            {
                    return;
            }
            
            }
            
            val_62 = 0;
            label_17:
            I2.Loc.Localize.CallBackTerm = this.FinalTerm;
            I2.Loc.Localize.CallBackSecondaryTerm = this.FinalSecondaryTerm;
            val_63 = 0;
            if((System.String.IsNullOrEmpty(value:  this.FinalTerm)) != true)
            {
                    val_63 = 0;
                if((System.String.op_Equality(a:  val_9, b:  "-")) != true)
            {
                    val_61 = val_9;
                val_64 = 1;
                val_65 = 0;
            }
            
            }
            
            I2.Loc.Localize.MainTranslation = I2.Loc.LocalizationManager.GetTranslation(Term:  val_61, FixForRTL:  false, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0, allowLocalizedParameters:  true);
            val_66 = 0;
            if((System.String.IsNullOrEmpty(value:  this.FinalSecondaryTerm)) != true)
            {
                    val_66 = 0;
                if((System.String.op_Equality(a:  this.FinalSecondaryTerm, b:  "-")) != true)
            {
                    val_61 = this.FinalSecondaryTerm;
                val_64 = 1;
                val_65 = 0;
            }
            
            }
            
            I2.Loc.Localize.SecondaryTranslation = I2.Loc.LocalizationManager.GetTranslation(Term:  val_61, FixForRTL:  false, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0, allowLocalizedParameters:  true);
            if((val_62 & 1) == 0)
            {
                    if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.SecondaryTranslation)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            I2.Loc.Localize.CurrentLocalizeComponent = this;
            this.LocalizeCallBack.Execute(Sender:  this);
            val_67 = 0;
            this.LocalizeEvent.Invoke();
            if(this.AllowParameters != false)
            {
                    val_61 = this.gameObject;
                val_67 = val_61;
                I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  I2.Loc.Localize.MainTranslation, root:  val_67, allowLocalizedParameters:  (this.AllowLocalizedParameters == true) ? 1 : 0);
            }
            
            if(this.FindTarget() == false)
            {
                    return;
            }
            
            val_68 = null;
            val_68 = null;
            if(I2.Loc.LocalizationManager.IsRight2Left != false)
            {
                    val_69 = this.IgnoreRTL ^ 1;
            }
            else
            {
                    val_69 = 0;
            }
            
            if(I2.Loc.Localize.MainTranslation == null)
            {
                goto label_73;
            }
            
            TermModification val_60 = this.PrimaryTermModifier;
            val_60 = val_60 - 1;
            if(val_60 > 3)
            {
                goto label_49;
            }
            
            var val_61 = 15764100 + ((this.PrimaryTermModifier - 1)) << 2;
            val_61 = val_61 + 15764100;
            goto (15764100 + ((this.PrimaryTermModifier - 1)) << 2 + 15764100);
            label_49:
            if((System.String.IsNullOrEmpty(value:  this.TermPrefix)) != true)
            {
                    I2.Loc.Localize.MainTranslation = (val_69 != 0) ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : (this.TermPrefix)((val_69 != 0) ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : (this.TermPrefix)) + (val_69 != 0) ? (this.TermPrefix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields((val_69 != 0) ? (this.TermPrefix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields);
            }
            
            val_71 = 0;
            if((System.String.IsNullOrEmpty(value:  this.TermSuffix)) != true)
            {
                    val_71 = mem[val_69 != 0x0 ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : 1152921513204880104];
                val_71 = (val_69 != 0) ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : (this.TermSuffix);
                I2.Loc.Localize.MainTranslation = (val_69 != 0) ? (this.TermSuffix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields((val_69 != 0) ? (this.TermSuffix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields) + val_71;
            }
            
            if(this.AddSpacesToJoinedLanguages != false)
            {
                    val_72 = null;
                val_72 = null;
                if(I2.Loc.LocalizationManager.HasJoinedWords != false)
            {
                    val_71 = 0;
                if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.MainTranslation)) != true)
            {
                    val_73 = I2.Loc.Localize.MainTranslation.Chars[0];
                System.Text.StringBuilder val_46 = Append(value:  val_73);
                if(val_42.m_stringLength >= 2)
            {
                    var val_62 = 1;
                do
            {
                System.Text.StringBuilder val_47 = Append(value:  ' ');
                val_73 = I2.Loc.Localize.MainTranslation.Chars[1];
                System.Text.StringBuilder val_49 = Append(value:  val_73);
                val_62 = val_62 + 1;
            }
            while(val_62 < val_42.m_stringLength);
            
            }
            
                val_74 = mem[null + 352 + 8];
                I2.Loc.Localize.MainTranslation = new System.Text.StringBuilder();
            }
            
            }
            
            }
            
            if((val_69 != 0) && ((this.mLocalizeTarget & 1) != 0))
            {
                    val_67 = 0;
                if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.MainTranslation)) != true)
            {
                    val_67 = this.MaxCharactersInRTL;
                I2.Loc.Localize.MainTranslation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  I2.Loc.Localize.MainTranslation, maxCharacters:  val_67, ignoreNumbers:  (this.IgnoreNumbersInRTL == true) ? 1 : 0);
            }
            
            }
            
            label_73:
            val_61 = I2.Loc.Localize.SecondaryTranslation;
            if(val_61 == null)
            {
                goto label_88;
            }
            
            TermModification val_63 = this.SecondaryTermModifier;
            val_63 = val_63 - 1;
            if(val_63 > 3)
            {
                goto label_77;
            }
            
            var val_64 = 15764116 + ((this.SecondaryTermModifier - 1)) << 2;
            val_64 = val_64 + 15764116;
            goto (15764116 + ((this.SecondaryTermModifier - 1)) << 2 + 15764116);
            label_77:
            if((val_69 != 0) && ((this.mLocalizeTarget & 1) != 0))
            {
                    if((System.String.IsNullOrEmpty(value:  null)) != true)
            {
                    val_61 = ;
                I2.Loc.Localize.SecondaryTranslation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  val_61);
            }
            
            }
            
            label_88:
            val_76 = null;
            val_76 = null;
            if(I2.Loc.LocalizationManager.HighlightLocalizedTargets != false)
            {
                    I2.Loc.Localize.MainTranslation = "LOC:"("LOC:") + val_9;
            }
            
            I2.Loc.Localize.CurrentLocalizeComponent = 0;
        }
        public bool FindTarget()
        {
            string val_5;
            var val_6;
            var val_16;
            var val_17;
            string val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            string val_24;
            I2.Loc.ILocalizeTarget val_25;
            var val_26;
            I2.Loc.ILocalizeTarget val_27;
            var val_28;
            var val_29;
            if((this.mLocalizeTarget != 0) && ((this.mLocalizeTarget & 1) != 0))
            {
                    val_16 = 1;
                return (bool)val_16;
            }
            
            val_17 = 0;
            if(this.mLocalizeTarget != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.mLocalizeTarget);
                val_18 = 0;
                val_19 = this.mLocalizeTargetName;
                this.mLocalizeTarget = 0;
                this.mLocalizeTargetName = 0;
            }
            else
            {
                    val_19 = this;
                val_18 = this.mLocalizeTargetName;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_18)) == false)
            {
                goto label_13;
            }
            
            val_20 = 0;
            val_21 = 0;
            goto label_14;
            label_13:
            val_22 = null;
            val_22 = null;
            List.Enumerator<T> val_4 = I2.Loc.LocalizationManager.mLocalizeTargets.GetEnumerator();
            label_26:
            val_23 = public System.Boolean List.Enumerator<I2.Loc.ILocalizeTargetDescriptor>::MoveNext();
            if(val_6.MoveNext() == false)
            {
                goto label_18;
            }
            
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_23 = mem[val_5 + 400 + 8];
            val_23 = val_5 + 400 + 8;
            val_24 = val_5;
            if(val_24 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.String.op_Equality(a:  this.mLocalizeTargetName, b:  val_24)) == false)
            {
                goto label_26;
            }
            
            if((val_5 & 1) != 0)
            {
                    val_25 = val_5;
                this.mLocalizeTarget = val_5;
            }
            else
            {
                    val_25 = this.mLocalizeTarget;
            }
            
            val_17 = 0;
            if(val_25 == 0)
            {
                goto label_26;
            }
            
            val_26 = 1;
            val_27 = 300;
            goto label_27;
            label_18:
            val_26 = 0;
            val_27 = 195;
            label_27:
            val_6.Dispose();
            if(195 == 300)
            {
                    return (bool)val_16;
            }
            
            var val_10 = (195 == 195) ? -1 : 0;
            label_14:
            val_27 = 1152921504834908160;
            val_28 = null;
            val_28 = null;
            List.Enumerator<T> val_11 = I2.Loc.LocalizationManager.mLocalizeTargets.GetEnumerator();
            label_38:
            val_23 = public System.Boolean List.Enumerator<I2.Loc.ILocalizeTargetDescriptor>::MoveNext();
            if(val_6.MoveNext() == false)
            {
                goto label_32;
            }
            
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_5 & 1) == 0)
            {
                goto label_38;
            }
            
            this.mLocalizeTarget = val_5;
            val_23 = mem[val_5 + 400 + 8];
            val_23 = val_5 + 400 + 8;
            val_24 = val_5;
            if(val_24 == 0)
            {
                    throw new NullReferenceException();
            }
            
            this.mLocalizeTargetName = val_24;
            val_27 = this.mLocalizeTarget;
            if(val_27 == 0)
            {
                goto label_38;
            }
            
            val_20 = 1;
            val_29 = 300;
            goto label_39;
            label_32:
            val_29 = 298;
            label_39:
            val_10 = (long)val_10 + 1;
            mem2[0] = 298;
            val_6.Dispose();
            if(val_10 != 1)
            {
                    val_16 = val_26 & (((1152921513205167248 + (((long)(int)(0xC3 == 0xC3 ? -1 : 0) + 1)) << 2) == 300) ? 1 : 0);
                return (bool)val_16;
            }
            
            val_16 = 0;
            return (bool)val_16;
        }
        public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
        {
            string val_8;
            primaryTerm = System.String.alignConst;
            secondaryTerm = System.String.alignConst;
            if(this.FindTarget() == false)
            {
                    return;
            }
            
            if(this.mLocalizeTarget != 0)
            {
                    val_8 = this;
                primaryTerm = I2.Loc.I2Utils.GetValidTermName(text:  primaryTerm, allowCategory:  false);
            }
            else
            {
                    val_8 = this.mTerm;
            }
            
            if((System.String.IsNullOrEmpty(value:  mem[this.mTerm])) != true)
            {
                    primaryTerm = mem[this.mTerm];
            }
            
            if((System.String.IsNullOrEmpty(value:  this.mTermSecondary)) != true)
            {
                    secondaryTerm = this.mTermSecondary;
            }
            
            if(primaryTerm != null)
            {
                    primaryTerm = primaryTerm.Trim();
            }
            
            if(secondaryTerm == null)
            {
                    return;
            }
            
            secondaryTerm = secondaryTerm.Trim();
        }
        public string GetMainTargetsText()
        {
            if(this.mLocalizeTarget == 0)
            {
                    return (string)((System.String.IsNullOrEmpty(value:  0 = 0)) != true) ? this.mTerm : 8715992;
            }
            
            return (string)((System.String.IsNullOrEmpty(value:  0)) != true) ? this.mTerm : 8715992;
        }
        public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
        {
            primaryTerm = I2.Loc.I2Utils.GetValidTermName(text:  Main = Main, allowCategory:  false);
            secondaryTerm = Secondary;
        }
        public void SetTerm(string primary)
        {
            if((System.String.IsNullOrEmpty(value:  primary)) != true)
            {
                    this.mTerm = primary;
                this.FinalTerm = primary;
            }
            
            this.OnLocalize(Force:  true);
        }
        public void SetTerm(string primary, string secondary)
        {
            if((System.String.IsNullOrEmpty(value:  primary)) != true)
            {
                    this.mTerm = primary;
                this.FinalTerm = primary;
            }
            
            this.mTermSecondary = secondary;
            this.FinalSecondaryTerm = secondary;
            this.OnLocalize(Force:  true);
        }
        internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation)
        {
            UnityEngine.Object val_6;
            string val_1 = 0;
            string val_2 = 0;
            this.DeserializeTranslation(translation:  mainTranslation, value: out  val_1, secondary: out  val_2);
            val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    val_6 = this;
                if(this != 0)
            {
                    mainTranslation = val_1;
                secondaryTranslation = val_2;
            }
            
            }
            
            if(this != 0)
            {
                    return (object)val_6;
            }
            
            val_6 = this;
            return (object)val_6;
        }
        public void UpdateAssetDictionary()
        {
            var val_9;
            System.Predicate<UnityEngine.Object> val_11;
            var val_12;
            System.Func<UnityEngine.Object, System.String> val_14;
            var val_15;
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_17;
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_19;
            val_9 = null;
            val_9 = null;
            val_11 = Localize.<>c.<>9__50_0;
            if(val_11 == null)
            {
                    System.Predicate<UnityEngine.Object> val_1 = null;
                val_11 = val_1;
                val_1 = new System.Predicate<UnityEngine.Object>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Localize.<>c::<UpdateAssetDictionary>b__50_0(UnityEngine.Object x));
                Localize.<>c.<>9__50_0 = val_11;
            }
            
            int val_2 = this.TranslatedObjects.RemoveAll(match:  val_11);
            val_12 = null;
            val_12 = null;
            val_14 = Localize.<>c.<>9__50_1;
            if(val_14 == null)
            {
                    System.Func<UnityEngine.Object, System.String> val_4 = null;
                val_14 = val_4;
                val_4 = new System.Func<UnityEngine.Object, System.String>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.String Localize.<>c::<UpdateAssetDictionary>b__50_1(UnityEngine.Object o));
                Localize.<>c.<>9__50_1 = val_14;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = Localize.<>c.<>9__50_2;
            if(val_17 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_6 = null;
                val_17 = val_6;
                val_6 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.String Localize.<>c::<UpdateAssetDictionary>b__50_2(System.Linq.IGrouping<string, UnityEngine.Object> g));
                val_15 = null;
                Localize.<>c.<>9__50_2 = val_17;
            }
            
            val_15 = null;
            val_19 = Localize.<>c.<>9__50_3;
            if(val_19 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_7 = null;
                val_19 = val_7;
                val_7 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Object Localize.<>c::<UpdateAssetDictionary>b__50_3(System.Linq.IGrouping<string, UnityEngine.Object> g));
                Localize.<>c.<>9__50_3 = val_19;
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String, UnityEngine.Object>(source:  System.Linq.Enumerable.GroupBy<UnityEngine.Object, System.String>(source:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  this.TranslatedObjects), keySelector:  val_14), keySelector:  val_17, elementSelector:  val_19);
        }
        internal T GetObject<T>(string Translation)
        {
            if((System.String.IsNullOrEmpty(value:  Translation)) != false)
            {
                    return 0;
            }
        
        }
        private T GetTranslatedObject<T>(string Translation)
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void DeserializeTranslation(string translation, out string value, out string secondary)
        {
            var val_9;
            int val_10;
            val_9 = 1152921513206617184;
            if(((System.String.IsNullOrEmpty(value:  translation)) == true) || (translation.m_stringLength < 2))
            {
                goto label_5;
            }
            
            char val_3 = translation.Chars[0] & 65535;
            if(val_3 != '[')
            {
                goto label_5;
            }
            
            int val_4 = translation.IndexOf(value:  ']');
            if(val_3 < '[')
            {
                goto label_5;
            }
            
            secondary = translation.Substring(startIndex:  1, length:  val_4 - 1);
            string val_8 = translation.Substring(startIndex:  val_4 + 1);
            val_9 = 1152921513206613152;
            goto label_6;
            label_5:
            value = translation;
            val_10 = System.String.alignConst;
            label_6:
            secondary = val_10;
        }
        public T FindTranslatedObject<T>(string value)
        {
            var val_4;
            string val_5;
            var val_6;
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            val_15 = 0;
            if((System.String.IsNullOrEmpty(value:  value)) == true)
            {
                    return (object)val_15;
            }
            
            if(this.mAssetDictionary != null)
            {
                    if(this.mAssetDictionary.Count == this.TranslatedObjects)
            {
                goto label_4;
            }
            
            }
            
            this.UpdateAssetDictionary();
            label_4:
            Dictionary.Enumerator<TKey, TValue> val_3 = this.mAssetDictionary.GetEnumerator();
            label_11:
            if(val_6.MoveNext() == false)
            {
                goto label_6;
            }
            
            val_16 = val_5;
            if(X0 == false)
            {
                goto label_11;
            }
            
            if(value == null)
            {
                    throw new NullReferenceException();
            }
            
            if(((value.EndsWith(value:  val_5, comparisonType:  5)) == false) || ((System.String.Compare(strA:  value, strB:  val_5, comparisonType:  5)) != 0))
            {
                goto label_11;
            }
            
            if((val_16 == 0) || (X0 == true))
            {
                goto label_32;
            }
            
            label_6:
            val_17 = 0;
            val_15 = 0;
            label_32:
            val_16 = 0;
            val_4 = val_5;
            val_5 = val_6;
            val_6 = null;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_6.Dispose();
            if(val_16 != 0)
            {
                    throw val_16;
            }
            
            if(val_17 != 1)
            {
                    if(164 == 210)
            {
                    return (object)val_15;
            }
            
            }
            
            UnityEngine.Object val_10 = I2.Loc.LocalizationManager.FindAsset(value:  value);
            val_17 = X0;
            if(val_17 == false)
            {
                goto label_26;
            }
            
            val_15 = X0;
            if(X0 == true)
            {
                goto label_27;
            }
            
            label_26:
            val_15 = 0;
            label_27:
            if((UnityEngine.Object.op_Implicit(exists:  val_15)) == true)
            {
                    return (object)val_15;
            }
            
            val_15 = I2.Loc.ResourceManager.pInstance;
            return (object)val_15;
        }
        public bool HasTranslatedObject(UnityEngine.Object Obj)
        {
            if((this.TranslatedObjects.Contains(item:  Obj)) == false)
            {
                    return I2.Loc.ResourceManager.pInstance.HasAsset(Obj:  Obj);
            }
            
            return true;
        }
        public void AddTranslatedObject(UnityEngine.Object Obj)
        {
            if((this.TranslatedObjects.Contains(item:  Obj)) != false)
            {
                    return;
            }
            
            this.TranslatedObjects.Add(item:  Obj);
            this.UpdateAssetDictionary();
        }
        public void SetGlobalLanguage(string Language)
        {
            I2.Loc.LocalizationManager.CurrentLanguage = Language;
        }
        public Localize()
        {
            var val_5;
            this.mTerm = System.String.alignConst;
            this.LocalizeOnAwake = true;
            this.IgnoreNumbersInRTL = true;
            this.CorrectAlignmentForRTL = true;
            this.AllowLocalizedParameters = true;
            this.AllowParameters = true;
            this.mTermSecondary = System.String.alignConst;
            this.TranslatedObjects = new System.Collections.Generic.List<UnityEngine.Object>();
            val_5 = null;
            val_5 = null;
            this.mAssetDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer._ordinal);
            this.LocalizeEvent = new UnityEngine.Events.UnityEvent();
            this.LocalizeCallBack = new I2.Loc.EventCallback();
            this.mGUI_ShowTems = true;
        }
    
    }

}
