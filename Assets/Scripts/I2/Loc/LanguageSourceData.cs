using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class LanguageSourceData
    {
        // Fields
        public I2.Loc.ILanguageSource owner;
        public bool UserAgreesToHaveItOnTheScene;
        public bool UserAgreesToHaveItInsideThePluginsFolder;
        public bool GoogleLiveSyncIsUptoDate;
        public bool mIsGlobalSource;
        public System.Collections.Generic.List<I2.Loc.TermData> mTerms;
        public bool CaseInsensitiveTerms;
        public System.Collections.Generic.Dictionary<string, I2.Loc.TermData> mDictionary;
        public I2.Loc.LanguageSourceData.MissingTranslationAction OnMissingTranslation;
        public string mTerm_AppName;
        public System.Collections.Generic.List<I2.Loc.LanguageData> mLanguages;
        public bool IgnoreDeviceLanguage;
        public I2.Loc.LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;
        public string Google_WebServiceURL;
        public string Google_SpreadsheetKey;
        public string Google_SpreadsheetName;
        public string Google_LastUpdatedVersion;
        public I2.Loc.LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;
        public I2.Loc.LanguageSourceData.eGoogleUpdateFrequency GoogleInEditorCheckFrequency;
        public I2.Loc.LanguageSourceData.eGoogleUpdateSynchronization GoogleUpdateSynchronization;
        public float GoogleUpdateDelay;
        private I2.Loc.LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle;
        public System.Collections.Generic.List<UnityEngine.Object> Assets;
        public System.Collections.Generic.Dictionary<string, UnityEngine.Object> mAssetDictionary;
        private string mDelayedGoogleData;
        public static string EmptyCategory;
        public static char[] CategorySeparators;
        
        // Methods
        public void add_Event_OnSourceUpdateFromGoogle(I2.Loc.LanguageSource.fnOnSourceUpdated value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.Event_OnSourceUpdateFromGoogle, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.Event_OnSourceUpdateFromGoogle != 1152921513194961928);
            
            return;
            label_2:
        }
        public void remove_Event_OnSourceUpdateFromGoogle(I2.Loc.LanguageSource.fnOnSourceUpdated value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.Event_OnSourceUpdateFromGoogle, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.Event_OnSourceUpdateFromGoogle != 1152921513195098504);
            
            return;
            label_2:
        }
        public void Awake()
        {
            I2.Loc.LocalizationManager.AddSource(Source:  this);
            this.UpdateDictionary(force:  false);
            this.UpdateAssetDictionary();
            I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
        }
        public void OnDestroy()
        {
            I2.Loc.LocalizationManager.RemoveSource(Source:  this);
        }
        public void ClearAllData()
        {
            this.mTerms.Clear();
            this.mLanguages.Clear();
            this.mDictionary.Clear();
            this.mAssetDictionary.Clear();
        }
        public void Editor_SetDirty()
        {
        
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
            val_11 = LanguageSourceData.<>c.<>9__39_0;
            if(val_11 == null)
            {
                    System.Predicate<UnityEngine.Object> val_1 = null;
                val_11 = val_1;
                val_1 = new System.Predicate<UnityEngine.Object>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_0(UnityEngine.Object x));
                LanguageSourceData.<>c.<>9__39_0 = val_11;
            }
            
            int val_2 = this.Assets.RemoveAll(match:  val_11);
            val_12 = null;
            val_12 = null;
            val_14 = LanguageSourceData.<>c.<>9__39_1;
            if(val_14 == null)
            {
                    System.Func<UnityEngine.Object, System.String> val_4 = null;
                val_14 = val_4;
                val_4 = new System.Func<UnityEngine.Object, System.String>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.String LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_1(UnityEngine.Object o));
                LanguageSourceData.<>c.<>9__39_1 = val_14;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = LanguageSourceData.<>c.<>9__39_2;
            if(val_17 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_6 = null;
                val_17 = val_6;
                val_6 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.String LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_2(System.Linq.IGrouping<string, UnityEngine.Object> g));
                val_15 = null;
                LanguageSourceData.<>c.<>9__39_2 = val_17;
            }
            
            val_15 = null;
            val_19 = LanguageSourceData.<>c.<>9__39_3;
            if(val_19 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_7 = null;
                val_19 = val_7;
                val_7 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Object LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_3(System.Linq.IGrouping<string, UnityEngine.Object> g));
                LanguageSourceData.<>c.<>9__39_3 = val_19;
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String, UnityEngine.Object>(source:  System.Linq.Enumerable.GroupBy<UnityEngine.Object, System.String>(source:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  this.Assets), keySelector:  val_14), keySelector:  val_17, elementSelector:  val_19);
        }
        public UnityEngine.Object FindAsset(string Name)
        {
            var val_5;
            UnityEngine.Object val_2 = 0;
            if(this.Assets == null)
            {
                goto label_1;
            }
            
            if(this.mAssetDictionary != null)
            {
                    if(this.mAssetDictionary.Count == this.Assets)
            {
                goto label_4;
            }
            
            }
            
            this.UpdateAssetDictionary();
            label_4:
            var val_4 = ((this.mAssetDictionary.TryGetValue(key:  Name, value: out  val_2)) != true) ? (val_2) : 0;
            return (UnityEngine.Object)val_5;
            label_1:
            val_5 = 0;
            return (UnityEngine.Object)val_5;
        }
        private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
        {
            var val_13;
            System.Collections.Generic.List<I2.Loc.TermData> val_14;
            var val_15;
            System.Collections.Generic.List<I2.Loc.TermData> val_16;
            System.Collections.Generic.List<I2.Loc.TermData> val_17;
            var val_18;
            val_13 = fillTermWithFallback;
            bool val_13 = true;
            if(val_13 <= langIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (langIndex << 3);
            if((((true + (langIndex) << 3) + 32 + 32) & 4) != 0)
            {
                goto label_4;
            }
            
            val_14 = this.mTerms;
            val_15 = "[i2fb]";
            var val_14 = 0;
            label_24:
            if(val_14 >= 1152921504626868224)
            {
                goto label_6;
            }
            
            if(val_14 != 0)
            {
                    System.Text.StringBuilder val_2 = Append(value:  "[i2t]");
                val_16 = this.mTerms;
            }
            
            if(1152921504626868224 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Text.StringBuilder val_3 = Append(value:  "_PublicKeyToken".__il2cppRuntimeField_10);
            System.Text.StringBuilder val_4 = Append(value:  "=");
            string val_7 = ("_PublicKeyToken".__il2cppRuntimeField_28 + ((long)(int)(langIndex)) << 3) + 32;
            if(((this.OnMissingTranslation == 1) && ((System.String.IsNullOrEmpty(value:  ("_PublicKeyToken".__il2cppRuntimeField_28 + ((long)(int)(langIndex)) << 3) + 32)) != false)) && ((this.TryGetFallbackTranslation(termData:  "_PublicKeyToken", Translation: out  val_7, langIndex:  langIndex, overrideSpecialization:  0, skipDisabled:  true)) != false))
            {
                    System.Text.StringBuilder val_9 = Append(value:  "[i2fb]");
                if(val_13 != false)
            {
                    mem2[0] = val_7;
                val_15 = val_15;
                val_13 = val_13;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  val_7)) != true)
            {
                    System.Text.StringBuilder val_12 = Append(value:  val_7);
            }
            
            val_17 = this.mTerms;
            val_14 = val_14 + 1;
            if(val_17 != null)
            {
                goto label_24;
            }
            
            throw new NullReferenceException();
            label_4:
            val_18 = 0;
            return (string)val_18;
            label_6:
            val_18 = new System.Text.StringBuilder();
            return (string)val_18;
        }
        public string Import_I2CSV(string Category, string I2CSVstring, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            return this.Import_CSV(Category:  Category, CSV:  I2.Loc.LocalizationReader.ReadI2CSV(Text:  I2CSVstring), UpdateMode:  UpdateMode);
        }
        public string Import_CSV(string Category, System.Collections.Generic.List<string[]> CSV, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            System.Collections.Generic.List<System.String[]> val_63;
            I2.Loc.LanguageSourceData val_64;
            System.String[] val_65;
            System.String[] val_66;
            int val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            I2.Loc.TermData val_72;
            I2.Loc.LanguageSourceData val_73;
            var val_74;
            I2.Loc.LanguageSourceData val_75;
            string val_76;
            var val_77;
            System.Collections.Generic.List<I2.Loc.LanguageData> val_78;
            System.Collections.Generic.List<I2.Loc.LanguageData> val_79;
            object val_80;
            val_63 = CSV;
            val_64 = this;
            string val_27 = 0;
            string val_26 = 0;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string[] val_1 = new string[1];
            val_1[0] = "Key";
            string[] val_2 = new string[1];
            val_65 = val_2;
            val_65[0] = "Type";
            string[] val_3 = new string[2];
            val_66 = val_3;
            val_67 = val_3.Length;
            val_66[0] = "Desc";
            val_68 = "Description";
            val_69 = "Description";
            val_67 = val_3.Length;
            val_66[1] = "Description";
            if(((mem[-4611686018427387880]) < 2) || ((X0.ArrayContains(MainText:  mem[-4611686018427387872], texts:  val_1)) == false))
            {
                goto label_20;
            }
            
            if(UpdateMode == 1)
            {
                    val_69 = val_64;
                this.ClearAllData();
            }
            
            if((mem[-4611686018427387880]) >= 3)
            {
                goto label_22;
            }
            
            val_70 = 1;
            goto label_27;
            label_20:
            val_71 = "Bad Spreadsheet Format.\nFirst columns should be \'Key\', \'Type\' and \'Desc\'";
            return (string)System.String.__il2cppRuntimeField_static_fields;
            label_22:
            bool val_5 = this.ArrayContains(MainText:  mem[-4611686018427387864], texts:  val_2);
            bool val_6 = val_5.ArrayContains(MainText:  mem[-4611686018427387864], texts:  val_3);
            var val_10 = ((val_5 | val_6) != true) ? (1 + 1) : 1;
            if((mem[-4611686018427387880]) < 4)
            {
                    val_70 = val_10;
            }
            else
            {
                    bool val_11 = val_6.ArrayContains(MainText:  mem[-4611686018427387856], texts:  val_2);
                bool val_13 = val_11.ArrayContains(MainText:  mem[-4611686018427387856], texts:  val_3);
                var val_16 = ((val_11 | val_13) != true) ? 3 : (val_10);
            }
            
            label_27:
            val_72 = 0;
            int val_18 = UnityEngine.Mathf.Max(a:  (mem[-4611686018427387880]) - val_16, b:  0);
            val_65 = new int[0];
            if(val_18 <= 0)
            {
                goto label_31;
            }
            
            val_73 = val_16;
            var val_63 = 0;
            val_66 = (long)val_18;
            val_74 = 4294967296;
            var val_20 = val_73 << 32;
            label_52:
            var val_21 = val_73 + val_63;
            var val_22 = 0 + (val_20 >> 29);
            if((System.String.IsNullOrEmpty(value:  (0 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32)) == false)
            {
                goto label_33;
            }
            
            val_75 = 0;
            goto label_36;
            label_33:
            val_76 = mem[(0 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32];
            val_76 = (0 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32;
            if((val_76.StartsWith(value:  "$")) != false)
            {
                    val_77 = 1;
                val_76 = val_76.Substring(startIndex:  1);
            }
            else
            {
                    val_77 = 0;
            }
            
            I2.Loc.GoogleLanguages.UnPackCodeFromLanguageName(CodedLanguage:  val_76, Language: out  val_26, code: out  val_27);
            if((System.String.IsNullOrEmpty(value:  val_27)) == false)
            {
                goto label_43;
            }
            
            val_75 = val_64;
            val_72 = 1;
            if(((this.GetLanguageIndex(language:  val_26, AllowDiscartingRegion:  true, SkipDisabled:  false)) & 2147483648) == 0)
            {
                goto label_46;
            }
            
            goto label_45;
            label_43:
            val_75 = val_64;
            val_72 = 1;
            if(((this.GetLanguageIndexFromCode(Code:  val_27, exactMatch:  true, ignoreDisabled:  false)) & 2147483648) == 0)
            {
                goto label_46;
            }
            
            label_45:
            typeof(I2.Loc.LanguageData).__il2cppRuntimeField_20 = val_77;
            typeof(I2.Loc.LanguageData).__il2cppRuntimeField_10 = val_26;
            typeof(I2.Loc.LanguageData).__il2cppRuntimeField_18 = val_27;
            val_72 = public System.Void System.Collections.Generic.List<I2.Loc.LanguageData>::Add(I2.Loc.LanguageData item);
            this.mLanguages.Add(item:  new System.Object());
            val_66 = val_66;
            val_74 = 4294967296;
            val_75 = (this.mLanguages + 24) - 1;
            label_46:
            label_36:
            mem2[0] = val_75;
            val_63 = val_63 + 1;
            val_20 = val_20 + val_74;
            if(val_63 < val_66)
            {
                goto label_52;
            }
            
            val_64 = val_64;
            val_63 = val_63;
            val_78 = this.mLanguages;
            goto label_53;
            label_31:
            val_78 = this.mLanguages;
            label_53:
            if(val_16 < 1)
            {
                goto label_61;
            }
            
            val_66 = 1152921513196379936;
            label_62:
            if(this.mLanguages.SyncRoot <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[this.mLanguages.SyncRoot + 24]) > (mem[this.mLanguages.SyncRoot + 32] + 40 + 24))
            {
                    System.Array.Resize<System.String>(array: ref  T[] val_32 = mem[this.mLanguages.SyncRoot + 32] + 40, newSize:  mem[this.mLanguages.SyncRoot + 24]);
                val_72 = public static System.Void System.Array::Resize<System.Byte>(ref T[] array, int newSize);
                System.Array.Resize<System.Byte>(array: ref  (mem[this.mLanguages.SyncRoot + 32]) + 48, newSize:  mem[this.mLanguages.SyncRoot + 24]);
            }
            
            val_73 = 0 + 1;
            if(val_73 < val_16)
            {
                    if(this.mTerms != null)
            {
                goto label_62;
            }
            
            }
            
            label_61:
            val_79 = val_78;
            if(this.mLanguages.SyncRoot <= 1)
            {
                goto label_64;
            }
            
            System.Int32[] val_64 = val_65[32];
            var val_65 = val_16;
            val_65 = val_65 << 32;
            val_80 = this.mLanguages.SyncRoot;
            goto label_65;
            label_110:
            val_80 = mem[this.mLanguages + 24];
            val_63 = val_78;
            label_65:
            if(val_80 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_66 = mem[this.mLanguages + 16];
            val_66 = val_66 + 8;
            val_66 = mem[(mem[this.mLanguages + 16] + 8) + 32 + 32];
            val_66 = (mem[this.mLanguages + 16] + 8) + 32 + 32;
            if((System.String.IsNullOrEmpty(value:  Category)) != true)
            {
                    val_66 = Category + "/"("/") + val_66;
            }
            
            val_72 = 0;
            if((val_66.EndsWith(value:  "]")) != false)
            {
                    val_72 = 0;
                int val_37 = val_66.LastIndexOf(value:  '[');
                if(val_37 >= 1)
            {
                    var val_67 = -2;
                val_67 = val_67 - val_37;
                string val_40 = val_66.Substring(startIndex:  val_37 + 1, length:  val_67 + val_35.m_stringLength);
                val_72 = 0;
                var val_42 = ((System.String.op_Equality(a:  val_40, b:  "touch")) != true) ? "Touch" : (val_40);
                val_79 = val_78;
                string val_44 = val_66.Remove(startIndex:  val_37);
            }
            
            }
            
            I2.Loc.LanguageSourceData.ValidateFullTerm(Term: ref  val_44);
            if((System.String.IsNullOrEmpty(value:  val_44)) == true)
            {
                goto label_101;
            }
            
            val_72 = 0;
            I2.Loc.TermData val_46 = this.GetTermData(term:  val_44, allowCategoryMistmatch:  false);
            if(val_46 == null)
            {
                goto label_77;
            }
            
            val_66 = val_46;
            if(UpdateMode != 3)
            {
                goto label_78;
            }
            
            goto label_101;
            label_77:
            I2.Loc.TermData val_47 = null;
            val_66 = val_47;
            val_47 = new I2.Loc.TermData();
            typeof(I2.Loc.TermData).__il2cppRuntimeField_10 = val_44;
            string[] val_48 = new string[0];
            typeof(I2.Loc.TermData).__il2cppRuntimeField_28 = val_48;
            typeof(I2.Loc.TermData).__il2cppRuntimeField_30 = new byte[0];
            var val_69 = 0;
            label_89:
            if(val_69 >= (this.mLanguages + 24))
            {
                goto label_84;
            }
            
            if(System.String.alignConst != 0)
            {
                    string val_68 = val_48[4];
            }
            
            mem2[0] = System.String.alignConst;
            val_69 = val_69 + 1;
            if(val_79 != 0)
            {
                goto label_89;
            }
            
            label_84:
            val_73 = val_64;
            this.mTerms.Add(item:  val_66);
            val_72 = val_66;
            mem[1152921513196442976].Add(key:  val_44, value:  val_72);
            label_78:
            if(((val_11 != true) ? 2 : (((val_5 & true) != 0) ? (-1) : 1)) >= 1)
            {
                    var val_51 = ((mem[this.mLanguages + 16] + 8) + 32) + (((long)(int)(val_11 != true ? 2 : (val_5 & true)!=0 ?  (-1) : 1)) << 3);
                typeof(I2.Loc.TermData).__il2cppRuntimeField_18 = I2.Loc.LanguageSourceData.GetTermType(type:  ((mem[this.mLanguages + 16] + 8) + 32 + ((long)(int)(val_11 != true ? 2 : (val_5 & true)!=0 ?  (-1) : 1)) << 3) + 32);
            }
            
            if(((val_13 != true) ? 2 : (((val_6 & true) != 0) ? (-1) : 1)) >= 1)
            {
                    var val_53 = ((mem[this.mLanguages + 16] + 8) + 32) + (((long)(int)(val_13 != true ? 2 : (val_6 & true)!=0 ?  (-1) : 1)) << 3);
                typeof(I2.Loc.TermData).__il2cppRuntimeField_20 = ((mem[this.mLanguages + 16] + 8) + 32 + ((long)(int)(val_13 != true ? 2 : (val_6 & true)!=0 ?  (-1) : 1)) << 3) + 32;
            }
            
            if(val_19.Length < 1)
            {
                goto label_101;
            }
            
            var val_72 = val_65;
            val_73 = 0;
            label_109:
            var val_71 = (mem[this.mLanguages + 16] + 8) + 32 + 24;
            var val_70 = val_16;
            val_70 = val_71 - val_70;
            if(val_73 >= (val_70 << ))
            {
                goto label_101;
            }
            
            val_71 = val_71 & 4294967295;
            var val_54 = val_65 + val_73;
            var val_55 = ((mem[this.mLanguages + 16] + 8) + 32) + (val_72 >> 29);
            if(((System.String.IsNullOrEmpty(value:  ((mem[this.mLanguages + 16] + 8) + 32 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32)) != true) && (((val_19[0x20] + 0) & 2147483648) == 0))
            {
                    if((System.String.op_Equality(a:  ((mem[this.mLanguages + 16] + 8) + 32 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32, b:  "-")) != false)
            {
                    val_72 = System.String.alignConst;
            }
            else
            {
                    string val_59 = ((System.String.op_Equality(a:  ((mem[this.mLanguages + 16] + 8) + 32 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32, b:  "")) != true) ? 0 : (((mem[this.mLanguages + 16] + 8) + 32 + ((ulong)(val_14 != true ? 3 : val_7 != true ? (1 + 1) : 1 << 32)) >> 29) + 32);
            }
            
                SetTranslation(idx:  val_19[0x20] + 0, translation:  val_59, specialization:  0);
            }
            
            val_73 = val_73 + 1;
            val_72 = val_72 + 4294967296;
            if(val_73 < val_19.Length)
            {
                goto label_109;
            }
            
            label_101:
            val_64 = val_64;
            val_68 = 1 + 1;
            if(val_68 < this.mLanguages.SyncRoot)
            {
                goto label_110;
            }
            
            label_64:
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            this.SaveLanguages(unloadAll:  this.HasUnloadedLanguages(), fileLocation:  val_59);
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private bool ArrayContains(string MainText, string[] texts)
        {
            var val_2;
            var val_3;
            int val_2 = texts.Length;
            if(val_2 < 1)
            {
                goto label_5;
            }
            
            val_2 = val_2 & 4294967295;
            val_2 = 0;
            label_6:
            if(((MainText.IndexOf(value:  null, comparisonType:  5)) & 2147483648) == 0)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            if(val_2 >= (long)val_2)
            {
                goto label_5;
            }
            
            if(val_2 < texts.Length)
            {
                goto label_6;
            }
            
            throw new IndexOutOfRangeException();
            label_5:
            val_3 = 0;
            return (bool)val_3;
            label_4:
            val_3 = 1;
            return (bool)val_3;
        }
        public static I2.Loc.eTermType GetTermType(string type)
        {
            var val_3;
            var val_4 = 0;
            label_3:
            if((System.String.Equals(a:  val_4 + 1.ToString(), b:  type, comparisonType:  5)) == true)
            {
                goto label_2;
            }
            
            val_4 = val_4 + 1;
            if(val_4 <= 9)
            {
                goto label_3;
            }
            
            val_3 = 0;
            return (I2.Loc.eTermType)val_3;
            label_2:
            val_3 = val_4 + 1;
            return (I2.Loc.eTermType)val_3;
        }
        private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
        {
            var val_15;
            int val_16;
            string val_17;
            val_16 = onlyCurrentSpecialization;
            if(langData.m_stringLength < 1)
            {
                    return;
            }
            
            val_15 = "[i2t]";
            do
            {
                int val_2 = langData.IndexOf(value:  "[i2t]", startIndex:  0);
                val_16 = val_2;
                if((val_2 & 2147483648) != 0)
            {
                    val_16 = langData.m_stringLength;
            }
            
                int val_3 = langData.IndexOf(value:  "=", startIndex:  0);
                if(val_3 >= val_16)
            {
                    return;
            }
            
                val_17 = val_3;
                if((this.GetTermData(term:  langData.Substring(startIndex:  0, length:  val_3 - 0), allowCategoryMistmatch:  false)) != null)
            {
                    int val_7 = val_17 + 1;
                if(val_3 == val_16)
            {
                    val_17 = 0;
            }
            else
            {
                    string val_9 = langData.Substring(startIndex:  val_7, length:  val_16 - val_7);
                bool val_10 = val_9.StartsWith(value:  "[i2fb]");
                val_17 = (val_10 != true) ? 0 : (val_9);
                if((val_10 != false) && (useFallback != false))
            {
                    val_17 = val_9.Substring(startIndex:  6);
            }
            
                var val_12 = (val_17 == null) ? 1 : 0;
                val_12 = val_12 | val_16 ^ 1;
                if(val_12 != true)
            {
                    val_17 = I2.Loc.SpecializationManager.GetSpecializedText(text:  val_17, specialization:  0);
            }
            
            }
            
                val_6.Languages[(long)langIndex] = val_17;
            }
            
            }
            while((val_16 + 5) < langData.m_stringLength);
        
        }
        public void Import_Google_FromCache()
        {
            string val_19;
            int val_20;
            if(this.GoogleUpdateFrequency == 1)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            string val_2 = this.GetSourcePlayerPrefName();
            string val_4 = I2.Loc.PersistentStorage.LoadFile(fileType:  1, fileName:  "I2Source_" + val_2 + ".loc", logExceptions:  false);
            val_19 = val_4;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    return;
            }
            
            if((val_19.StartsWith(value:  "[i2e]", comparisonType:  4)) != false)
            {
                    val_19 = I2.Loc.StringObfucator.Decode(ObfucatedString:  val_19.Substring(startIndex:  5, length:  val_4.m_stringLength - 5));
            }
            
            if((I2.Loc.PersistentStorage.HasSetting(key:  "I2SourceVersion_" + val_2)) != false)
            {
                    string val_13 = I2.Loc.PersistentStorage.GetSetting_String(key:  "I2SourceVersion_" + val_2, defaultValue:  this.Google_LastUpdatedVersion);
                val_20 = val_13;
                if((val_13.IsNewerVersion(currentVersion:  this.Google_LastUpdatedVersion, newVersion:  val_13)) != false)
            {
                    if(val_13.m_stringLength >= 20)
            {
                    val_20 = System.String.alignConst;
            }
            
                this.Google_LastUpdatedVersion = val_20;
                string val_15 = this.Import_Google_Result(JsonString:  val_19, UpdateMode:  1, saveInPlayerPrefs:  false);
                return;
            }
            
            }
            
            bool val_17 = I2.Loc.PersistentStorage.DeleteFile(fileType:  1, fileName:  "I2Source_" + val_2 + ".loc", logExceptions:  false);
            I2.Loc.PersistentStorage.DeleteSetting(key:  "I2SourceVersion_" + val_2);
        }
        private bool IsNewerVersion(string currentVersion, string newVersion)
        {
            var val_8;
            long val_3 = 0;
            long val_5 = 0;
            if((System.String.IsNullOrEmpty(value:  newVersion)) != false)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            if((System.String.IsNullOrEmpty(value:  currentVersion)) != true)
            {
                    if((System.Int64.TryParse(s:  newVersion, result: out  val_3)) != false)
            {
                    if((System.Int64.TryParse(s:  currentVersion, result: out  val_5)) != false)
            {
                    var val_7 = (val_3 > val_5) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        public void Import_Google(bool ForceUpdate, bool justCheck)
        {
            string val_16;
            if(ForceUpdate != true)
            {
                    if(this.GoogleUpdateFrequency == 1)
            {
                    return;
            }
            
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_16 = this.GetSourcePlayerPrefName();
            if(((this.GoogleUpdateFrequency == 0) || (ForceUpdate == true)) || ((System.DateTime.TryParse(s:  I2.Loc.PersistentStorage.GetSetting_String(key:  "LastGoogleUpdate_" + val_16, defaultValue:  ""), result: out  new System.DateTime())) == false))
            {
                goto label_11;
            }
            
            System.DateTime val_6 = System.DateTime.Now;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.dateData}, d2:  new System.DateTime());
            if((this.GoogleUpdateFrequency - 2) > 4)
            {
                goto label_11;
            }
            
            var val_16 = 15764080 + ((this.GoogleUpdateFrequency - 2)) << 2;
            val_16 = val_16 + 15764080;
            goto (15764080 + ((this.GoogleUpdateFrequency - 2)) << 2 + 15764080);
            label_11:
            val_16 = "LastGoogleUpdate_" + val_16;
            System.DateTime val_11 = System.DateTime.Now;
            I2.Loc.PersistentStorage.SetSetting_String(key:  val_16, value:  val_11.dateData.ToString());
            UnityEngine.Coroutine val_15 = I2.Loc.CoroutineManager.Start(coroutine:  this.Import_Google_Coroutine(JustCheck:  justCheck));
        }
        private string GetSourcePlayerPrefName()
        {
            string val_9;
            var val_10;
            if(this.owner != null)
            {
                    val_9 = this.owner.name;
                if((System.String.IsNullOrEmpty(value:  this.Google_SpreadsheetKey)) != true)
            {
                    val_9 = val_9 + this.Google_SpreadsheetKey;
            }
            
                val_10 = null;
                val_10 = null;
                if(((System.Array.IndexOf<System.String>(array:  I2.Loc.LocalizationManager.GlobalSources, value:  this.owner.name)) & 2147483648) == 0)
            {
                    return (string)val_9;
            }
            
                UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                val_9 = val_6.m_Handle.name + "_" + val_9;
                return (string)val_9;
            }
            
            val_9 = 0;
            return (string)val_9;
        }
        private System.Collections.IEnumerator Import_Google_Coroutine(bool JustCheck)
        {
            typeof(LanguageSourceData.<Import_Google_Coroutine>d__65).__il2cppRuntimeField_10 = 0;
            typeof(LanguageSourceData.<Import_Google_Coroutine>d__65).__il2cppRuntimeField_20 = this;
            typeof(LanguageSourceData.<Import_Google_Coroutine>d__65).__il2cppRuntimeField_28 = JustCheck;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void ApplyDownloadedDataOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void I2.Loc.LanguageSourceData::ApplyDownloadedDataOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
            this.ApplyDownloadedDataFromGoogle();
        }
        public void ApplyDownloadedDataFromGoogle()
        {
            object val_4;
            if((System.String.IsNullOrEmpty(value:  this.mDelayedGoogleData)) != false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.Import_Google_Result(JsonString:  this.mDelayedGoogleData, UpdateMode:  1, saveInPlayerPrefs:  true))) != false)
            {
                    if(this.Event_OnSourceUpdateFromGoogle != null)
            {
                    this.Event_OnSourceUpdateFromGoogle.Invoke(source:  this, ReceivedNewData:  true, errorMsg:  "");
            }
            
                I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
                val_4 = "Done Google Sync";
            }
            else
            {
                    if(this.Event_OnSourceUpdateFromGoogle != null)
            {
                    this.Event_OnSourceUpdateFromGoogle.Invoke(source:  this, ReceivedNewData:  false, errorMsg:  "");
            }
            
                val_4 = "Done Google Sync: source was up-to-date";
            }
            
            UnityEngine.Debug.Log(message:  val_4);
        }
        public UnityEngine.Networking.UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
        {
            int val_11;
            var val_12;
            if(this.HasGoogleSpreadsheet() != false)
            {
                    string val_4 = I2.Loc.PersistentStorage.GetSetting_String(key:  "I2SourceVersion_" + this.GetSourcePlayerPrefName(), defaultValue:  this.Google_LastUpdatedVersion);
                val_11 = val_4;
                if(val_4.m_stringLength >= 20)
            {
                    val_11 = System.String.alignConst;
            }
            
                if((val_4.IsNewerVersion(currentVersion:  val_11, newVersion:  this.Google_LastUpdatedVersion)) != false)
            {
                    this.Google_LastUpdatedVersion = val_11;
            }
            
                UnityEngine.Networking.UnityWebRequest val_9 = UnityEngine.Networking.UnityWebRequest.Get(uri:  System.String.Format(format:  "{0}?key={1}&action=GetLanguageSource&version={2}", arg0:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  this), arg1:  this.Google_SpreadsheetKey, arg2:  (ForceUpdate != true) ? "0" : (this.Google_LastUpdatedVersion)));
                val_12 = val_9;
                UnityEngine.Networking.UnityWebRequestAsyncOperation val_10 = val_9.SendWebRequest();
                return (UnityEngine.Networking.UnityWebRequest)val_12;
            }
            
            val_12 = 0;
            return (UnityEngine.Networking.UnityWebRequest)val_12;
        }
        public bool HasGoogleSpreadsheet()
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  this.Google_WebServiceURL)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  this.Google_SpreadsheetKey)) == false)
            {
                goto label_2;
            }
            
            }
            
            val_6 = 0;
            goto label_3;
            label_2:
            bool val_4 = System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  this));
            val_6 = val_4 ^ 1;
            label_3:
            val_4 = val_6;
            return (bool)val_4;
        }
        public string Import_Google_Result(string JsonString, I2.Loc.eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = False)
        {
            var val_31;
            I2.Loc.eSpreadsheetUpdateMode val_32;
            int val_33;
            string val_34;
            string val_35;
            var val_36;
            int val_37;
            string val_38;
            var val_40;
            System.StringComparison val_41;
            string val_43;
            string val_44;
            var val_45;
            val_32 = UpdateMode;
            val_33 = System.String.alignConst;
            if((System.String.IsNullOrEmpty(value:  JsonString)) == true)
            {
                    return (string)val_45;
            }
            
            val_34 = "\"\"";
            val_35 = JsonString;
            if((System.String.op_Equality(a:  val_35, b:  val_34)) == true)
            {
                    return (string)val_45;
            }
            
            if(JsonString == null)
            {
                    throw new NullReferenceException();
            }
            
            val_31 = "version=";
            val_36 = "script_version=";
            val_37 = JsonString.IndexOf(value:  "version=", comparisonType:  4);
            val_34 = "script_version=";
            val_35 = JsonString;
            int val_4 = val_35.IndexOf(value:  val_34, comparisonType:  4);
            val_38 = val_4;
            if(((val_4 | val_37) & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_36 = ",";
            int val_6 = JsonString.IndexOf(value:  ",", startIndex:  ("version=".__il2cppRuntimeField_10 + val_3), comparisonType:  4);
            val_37 = JsonString.Substring(startIndex:  ("version=".__il2cppRuntimeField_10 + val_3), length:  (val_6 - ("version=".__il2cppRuntimeField_10 + val_3))>>0&0xFFFFFFFF);
            int val_8 = JsonString.IndexOf(value:  ",", startIndex:  ("script_version=".__il2cppRuntimeField_10 + val_4), comparisonType:  4);
            val_34 = 0;
            if(val_37 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_38 = System.Int32.Parse(s:  JsonString.Substring(startIndex:  ("script_version=".__il2cppRuntimeField_10 + val_4), length:  (val_8 - ("script_version=".__il2cppRuntimeField_10 + val_4))>>0&0xFFFFFFFF));
            if(val_7.m_stringLength >= 20)
            {
                    val_37 = System.String.alignConst;
            }
            
            val_40 = null;
            if(val_38 != 5)
            {
                goto label_11;
            }
            
            if(saveInPlayerPrefs != false)
            {
                    if((null.IsNewerVersion(currentVersion:  this.Google_LastUpdatedVersion, newVersion:  val_37)) == false)
            {
                    return (string)val_45;
            }
            
                string val_12 = this.GetSourcePlayerPrefName();
                val_38 = "I2Source_" + val_12 + ".loc";
                bool val_16 = I2.Loc.PersistentStorage.SaveFile(fileType:  1, fileName:  val_38, data:  "[i2e]" + I2.Loc.StringObfucator.Encode(NormalString:  JsonString)(I2.Loc.StringObfucator.Encode(NormalString:  JsonString)), logExceptions:  true);
                I2.Loc.PersistentStorage.SetSetting_String(key:  "I2SourceVersion_" + val_12, value:  val_37);
                I2.Loc.PersistentStorage.ForceSaveSettings();
            }
            
            this.Google_LastUpdatedVersion = val_37;
            if(val_32 == 1)
            {
                    this.ClearAllData();
            }
            
            val_34 = "[i2category]";
            val_41 = 4;
            val_35 = JsonString;
            if((val_35.IndexOf(value:  val_34, comparisonType:  val_41)) >= 1)
            {
                    val_36 = "[/i2category]";
                val_31 = 2;
                do
            {
                int val_19 = JsonString.IndexOf(value:  "[/i2category]", startIndex:  ("[i2category]".__il2cppRuntimeField_10 + val_18), comparisonType:  4);
                val_34 = ("[i2category]".__il2cppRuntimeField_10 + val_18);
                string val_20 = JsonString.Substring(startIndex:  val_34, length:  (val_19 - ("[i2category]".__il2cppRuntimeField_10 + val_18))>>0&0xFFFFFFFF);
                val_43 = val_20;
                val_44 = JsonString.Substring(startIndex:  ("[/i2category]".__il2cppRuntimeField_10 + val_19), length:  (val_22 - ("[/i2category]".__il2cppRuntimeField_10 + val_19))>>0&0xFFFFFFFF);
                val_41 = I2.Loc.LocalizationReader.ReadI2CSV(Text:  val_44);
                string val_26 = this.Import_CSV(Category:  val_43, CSV:  val_41, UpdateMode:  val_32);
                var val_27 = (val_32 == 1) ? (val_31) : (val_32);
            }
            while((JsonString.IndexOf(value:  "[i2category]", startIndex:  JsonString.IndexOf(value:  "[/i2csv]", startIndex:  ("[/i2category]".__il2cppRuntimeField_10 + val_19), comparisonType:  4), comparisonType:  4)) >= 1);
            
            }
            
            this.GoogleLiveSyncIsUptoDate = true;
            val_33 = val_33;
            if(UnityEngine.Application.isPlaying != false)
            {
                    this.SaveLanguages(unloadAll:  true, fileLocation:  val_41);
            }
            
            bool val_29 = System.String.IsNullOrEmpty(value:  val_33);
            return (string)val_45;
            label_4:
            val_45 = "Invalid Response from Google, Most likely the WebService needs to be updated";
            return (string)val_45;
            label_11:
            val_45 = "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
            return (string)val_45;
        }
        public int GetLanguageIndex(string language, bool AllowDiscartingRegion = True, bool SkipDisabled = True)
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_5;
            var val_6;
            System.Collections.Generic.List<I2.Loc.LanguageData> val_7;
            val_5 = AllowDiscartingRegion;
            if(W24 >= 1)
            {
                    val_6 = 0;
                do
            {
                if(SkipDisabled != false)
            {
                    val_7 = this.mLanguages;
                if(val_6 >= this.mLanguages)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
                val_7 = this.mLanguages;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if((System.String.Compare(strA:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 32 + 0) + 32 + 16, strB:  language, comparisonType:  5)) == 0)
            {
                    return (int)val_6;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < X24);
            
            }
            
            if((val_5 != false) && (W24 >= 1))
            {
                    val_6 = 0;
                do
            {
                if(SkipDisabled != false)
            {
                    val_5 = this.mLanguages;
                if(0 >= this.mLanguages)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_5 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 32 + 0) + 32 + 16];
                val_5 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 32 + 0) + 32 + 16;
                int val_2 = I2.Loc.LanguageSourceData.GetCommonWordInLanguageNames(Language1:  val_5, Language2:  language);
                var val_3 = (val_2 > 0) ? (val_2) : 0;
                val_7 = 0 + 1;
            }
            while(val_7 < X24);
            
                if((((val_2 > 0) ? 0 : (val_6)) & 2147483648) == 0)
            {
                    return (int)val_6;
            }
            
            }
            
            val_6 = 0;
            return (int)val_6;
        }
        public bool IsCurrentLanguage(int languageIndex)
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return System.String.op_Equality(a:  I2.Loc.LocalizationManager.CurrentLanguage, b:  (I2.Loc.LocalizationManager.__il2cppRuntimeField_cctor_finished + (languageIndex) << 3) + 32 + 16);
        }
        public int GetLanguageIndexFromCode(string Code, bool exactMatch = True, bool ignoreDisabled = False)
        {
            var val_3;
            var val_4;
            val_3 = exactMatch;
            if(W24 >= 1)
            {
                    val_4 = 0;
                do
            {
                if(ignoreDisabled != false)
            {
                    if(val_4 >= this.mLanguages)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if((System.String.Compare(strA:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 32 + 0) + 32 + 24, strB:  Code, comparisonType:  5)) == 0)
            {
                    return (int)val_4;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < X24);
            
            }
            
            if((val_3 != true) && (val_3 >= true))
            {
                    val_4 = 0;
                do
            {
                if(ignoreDisabled != false)
            {
                    if(val_4 >= this.mLanguages)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if((System.String.Compare(strA:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 32 + 0) + 32 + 24, indexA:  0, strB:  Code, indexB:  0, length:  2, comparisonType:  5)) == 0)
            {
                    return (int)val_4;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < val_3);
            
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        public static int GetCommonWordInLanguageNames(string Language1, string Language2)
        {
            var val_14;
            if((System.String.IsNullOrEmpty(value:  Language1)) == true)
            {
                    return 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  Language2)) != false)
            {
                    return 0;
            }
            
            System.Char[] val_3 = ToCharArray();
            System.String[] val_5 = Language1.ToLower().Split(separator:  val_3);
            System.String[] val_7 = Language2.ToLower().Split(separator:  val_3);
            int val_14 = val_5.Length;
            if(val_14 < 1)
            {
                goto label_9;
            }
            
            val_14 = 0;
            var val_15 = 0;
            val_14 = val_14 & 4294967295;
            do
            {
                if((System.String.IsNullOrEmpty(value:  1152921504841900880)) != true)
            {
                    val_14 = val_14 + (System.Linq.Enumerable.Contains<System.String>(source:  val_7, value:  1152921504841900880));
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 < (val_5.Length << ));
            
            label_19:
            int val_16 = val_7.Length;
            if(val_16 < 1)
            {
                    return 0;
            }
            
            var val_17 = 0;
            val_16 = val_16 & 4294967295;
            do
            {
                if((System.String.IsNullOrEmpty(value:  1152921504841900880)) != true)
            {
                    val_14 = val_14 + (System.Linq.Enumerable.Contains<System.String>(source:  val_5, value:  1152921504841900880));
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 < (val_7.Length << ));
            
            return 0;
            label_9:
            if(val_7 != null)
            {
                goto label_19;
            }
            
            throw new NullReferenceException();
        }
        public System.Collections.Generic.List<string> GetLanguages(bool skipDisabled = True)
        {
            if(W22 < 1)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            var val_3 = 4;
            label_12:
            if(skipDisabled == false)
            {
                goto label_3;
            }
            
            if(0 >= this.mLanguages)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this.mLanguages & 1) != 0)
            {
                goto label_7;
            }
            
            label_3:
            if(0 >= this.mLanguages)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Add(item:  public System.Void System.Collections.Generic.List<System.String>::.ctor());
            label_7:
            val_3 = val_3 + 1;
            if((val_3 - 3) < X22)
            {
                goto label_12;
            }
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
        }
        public bool AllowUnloadingLanguages()
        {
            return (bool)(this._AllowUnloadingLanguages != 0) ? 1 : 0;
        }
        private string GetSavedLanguageFileName(int languageIndex)
        {
            int val_3;
            int val_4;
            if((languageIndex & 2147483648) != 0)
            {
                    return 0;
            }
            
            string[] val_1 = new string[5];
            val_1[0] = "LangSource_";
            val_3 = val_1.Length;
            val_1[1] = this.GetSourcePlayerPrefName();
            val_3 = val_1.Length;
            string val_3 = "_";
            val_1[2] = val_3;
            if(val_3 <= languageIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (languageIndex << 3);
            val_4 = val_1.Length;
            val_1[3] = ("_" + (languageIndex) << 3) + 32 + 16;
            val_4 = val_1.Length;
            val_1[4] = ".loc";
            return +val_1;
        }
        public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
        {
            var val_8;
            System.Collections.Generic.List<I2.Loc.LanguageData> val_9;
            val_8 = UnloadOtherLanguages;
            eAllowUnloadLanguages val_8 = this._AllowUnloadingLanguages;
            if(val_8 == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            if((languageIndex & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if(forceLoad == true)
            {
                goto label_4;
            }
            
            if(val_8 <= languageIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (languageIndex << 3);
            if((val_8 & 4) == 0)
            {
                goto label_9;
            }
            
            label_4:
            string val_3 = I2.Loc.PersistentStorage.LoadFile(fileType:  2, fileName:  this.GetSavedLanguageFileName(languageIndex:  languageIndex), logExceptions:  false);
            if((System.String.IsNullOrEmpty(value:  val_3)) != true)
            {
                    onlyCurrentSpecialization = onlyCurrentSpecialization;
                this.Import_Language_from_Cache(langIndex:  languageIndex, langData:  val_3, useFallback:  useFallback, onlyCurrentSpecialization:  onlyCurrentSpecialization);
                if(val_8 <= languageIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + (languageIndex << 3);
                var val_6 = W9 & 4294967291;
                mem2[0] = val_6;
            }
            
            label_9:
            if(val_8 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_9 = this.mLanguages;
            val_8 = 0;
            do
            {
                if(val_8 >= val_6)
            {
                    return;
            }
            
                if(languageIndex != val_8)
            {
                    this.UnloadLanguage(languageIndex:  0);
                val_9 = this.mLanguages;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_9 != null);
            
            throw new NullReferenceException();
        }
        public void UnloadLanguage(int languageIndex)
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_8;
            System.Collections.Generic.List<I2.Loc.TermData> val_9;
            eAllowUnloadLanguages val_8 = this._AllowUnloadingLanguages;
            if(val_8 == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            val_9 = 0;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_8 = this.mLanguages;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_8 <= languageIndex)
            {
                    val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (languageIndex << 3);
            if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_8 & 4) != 0)
            {
                    return;
            }
            
            val_8 = this.mLanguages;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_8 <= languageIndex)
            {
                    val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (((long)(int)(languageIndex)) << 3);
            if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_8 & 2) != 0)
            {
                    return;
            }
            
            if((this.IsCurrentLanguage(languageIndex:  languageIndex)) == true)
            {
                    return;
            }
            
            if((I2.Loc.PersistentStorage.HasFile(fileType:  2, fileName:  this.GetSavedLanguageFileName(languageIndex:  languageIndex), logExceptions:  true)) == false)
            {
                    return;
            }
            
            val_9 = this.mTerms;
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_6 = val_9.GetEnumerator();
            val_8 = 1152921513200245328;
            goto label_15;
            label_19:
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_9 = 20997824;
            val_9 = val_9 + (((long)(int)(languageIndex)) << 3);
            mem2[0] = 0;
            label_15:
            if(0.MoveNext() == true)
            {
                goto label_19;
            }
            
            var val_10 = 1152921513200246352;
            0.Dispose();
            if(this.mLanguages == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_10 <= languageIndex)
            {
                    val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (((long)(int)(languageIndex)) << 3);
            if(((1152921513200246352 + ((long)(int)(languageIndex)) << 3) + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_11 = (1152921513200246352 + ((long)(int)(languageIndex)) << 3) + 32 + 32;
            val_11 = val_11 | 4;
            mem2[0] = val_11;
        }
        public void SaveLanguages(bool unloadAll, I2.Loc.PersistentStorage.eFileType fileLocation = 2)
        {
            var val_9;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            val_9 = 0;
            label_6:
            if(val_9 >= this.mLanguages)
            {
                goto label_4;
            }
            
            string val_4 = this.Export_Language_to_Cache(langIndex:  0, fillTermWithFallback:  this.IsCurrentLanguage(languageIndex:  0));
            if((System.String.IsNullOrEmpty(value:  val_4)) != true)
            {
                    bool val_7 = I2.Loc.PersistentStorage.SaveFile(fileType:  2, fileName:  this.GetSavedLanguageFileName(languageIndex:  0), data:  val_4, logExceptions:  true);
            }
            
            val_9 = val_9 + 1;
            if(this.mLanguages != null)
            {
                goto label_6;
            }
            
            label_4:
            if(this.mLanguages < 1)
            {
                    return;
            }
            
            if(unloadAll == false)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                if((this.IsCurrentLanguage(languageIndex:  0)) != true)
            {
                    this.UnloadLanguage(languageIndex:  0);
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 < this.mLanguages);
        
        }
        public bool HasUnloadedLanguages()
        {
            var val_1;
            bool val_1 = true;
            var val_2 = 0;
            label_6:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if((((true + 0) + 32 + 32) & 4) != 0)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(this.mLanguages != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (bool)val_1;
            label_5:
            val_1 = 1;
            return (bool)val_1;
        }
        public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = False)
        {
            var val_3;
            if(OnlyMainCategory == false)
            {
                goto label_1;
            }
            
            val_3 = FullTerm;
            if(((val_3.IndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators)) & 2147483648) == 0)
            {
                goto label_5;
            }
            
            return (string)FullTerm;
            label_1:
            val_3 = FullTerm;
            System.Char[] val_3 = I2.Loc.LanguageSourceData.CategorySeparators;
            int val_2 = val_3.LastIndexOfAny(anyOf:  val_3);
            if((val_2 & 2147483648) != 0)
            {
                    return (string)FullTerm;
            }
            
            label_5:
            val_3 = val_2 + 1;
            return FullTerm.Substring(startIndex:  val_3);
        }
        public void UpdateDictionary(bool force = False)
        {
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_6;
            var val_7;
            System.Collections.Generic.IEqualityComparer<TKey> val_8;
            var val_9;
            I2.Loc.TermData val_10;
            if((force != true) && (this.mDictionary != null))
            {
                    if(this.mDictionary.Count == this.mTerms)
            {
                    return;
            }
            
            }
            
            if(this.CaseInsensitiveTerms != false)
            {
                    val_7 = null;
                val_7 = null;
                val_8 = 1152921504618778648;
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                val_8 = 1152921504618778640;
            }
            
            if(val_8 != val_8)
            {
                    System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_2 = null;
                val_6 = val_2;
                val_10 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>::.ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer);
                val_2 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>(comparer:  val_8);
                this.mDictionary = val_6;
            }
            else
            {
                    this.mDictionary.Clear();
            }
            
            if(W22 < 1)
            {
                goto label_32;
            }
            
            var val_6 = 0;
            label_33:
            if(1152921513195434944 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            I2.Loc.LanguageSourceData.ValidateFullTerm(Term: ref  1152921508236372208);
            val_6 = this.mDictionary;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = mem[(I2.Loc.LanguageSourceData.__il2cppRuntimeField_cctor_finished + 0) + 32];
            val_10 = (I2.Loc.LanguageSourceData.__il2cppRuntimeField_cctor_finished + 0) + 32;
            val_6.set_Item(key:  "_".m_stringLength, value:  val_10);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            ((I2.Loc.LanguageSourceData.__il2cppRuntimeField_cctor_finished + 0) + 0) + 32.Validate();
            val_6 = val_6 + 1;
            if(val_6 >= W22)
            {
                goto label_32;
            }
            
            if(this.mTerms != null)
            {
                goto label_33;
            }
            
            throw new NullReferenceException();
            label_32:
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.SaveLanguages(unloadAll:  true, fileLocation:  val_10);
        }
        public bool TryGetTranslation(string term, out string Translation, string overrideLanguage, string overrideSpecialization, bool skipDisabled = False, bool allowCategoryMistmatch = False)
        {
            bool val_10;
            string val_11;
            var val_12;
            val_10 = allowCategoryMistmatch;
            val_11 = overrideLanguage;
            if(val_11 == null)
            {
                goto label_1;
            }
            
            label_4:
            if(this != null)
            {
                goto label_2;
            }
            
            if(val_11 != null)
            {
                goto label_4;
            }
            
            label_1:
            val_11 = I2.Loc.LocalizationManager.CurrentLanguage;
            label_2:
            int val_2 = this.GetLanguageIndex(language:  val_11, AllowDiscartingRegion:  true, SkipDisabled:  false);
            if((val_2 & 2147483648) != 0)
            {
                goto label_13;
            }
            
            if(skipDisabled != false)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            I2.Loc.TermData val_4 = this.GetTermData(term:  term, allowCategoryMistmatch:  val_10);
            val_10 = val_4;
            if(val_4 == null)
            {
                goto label_14;
            }
            
            string val_5 = val_10.GetTranslation(idx:  val_2, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_5;
            if((System.String.op_Equality(a:  val_5, b:  "---")) == false)
            {
                goto label_15;
            }
            
            label_23:
            Translation = System.String.alignConst;
            goto label_24;
            label_15:
            if((System.String.IsNullOrEmpty(value:  Translation)) == false)
            {
                goto label_24;
            }
            
            Translation = 0;
            label_14:
            if(this.OnMissingTranslation != 2)
            {
                goto label_18;
            }
            
            Translation = System.String.Format(format:  "<!-Missing Translation [{0}]-!>", arg0:  term);
            label_24:
            val_12 = 1;
            return (bool)val_12;
            label_18:
            if((this.OnMissingTranslation == 1) && (val_10 != null))
            {
                    skipDisabled = skipDisabled;
                return this.TryGetFallbackTranslation(termData:  val_10, Translation: out  string val_9 = Translation, langIndex:  val_2, overrideSpecialization:  overrideSpecialization, skipDisabled:  skipDisabled);
            }
            
            if(this.OnMissingTranslation == 3)
            {
                goto label_22;
            }
            
            if(this.OnMissingTranslation == 0)
            {
                goto label_23;
            }
            
            label_13:
            val_12 = 0;
            Translation = 0;
            return (bool)val_12;
            label_22:
            Translation = term;
            goto label_24;
        }
        private bool TryGetFallbackTranslation(I2.Loc.TermData termData, out string Translation, int langIndex, string overrideSpecialization, bool skipDisabled = False)
        {
            var val_11;
            string val_12;
            System.Collections.Generic.List<I2.Loc.LanguageData> val_13;
            var val_14;
            val_11 = langIndex;
            bool val_11 = true;
            if(val_11 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_11 << 3);
            var val_13 = (true + (langIndex) << 3) + 32;
            val_12 = mem[(true + (langIndex) << 3) + 32 + 24];
            val_12 = (true + (langIndex) << 3) + 32 + 24;
            if((System.String.IsNullOrEmpty(value:  val_12)) == false)
            {
                goto label_4;
            }
            
            val_13 = this.mLanguages;
            if(val_13 != null)
            {
                goto label_10;
            }
            
            label_4:
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_12, value:  '-')) != false)
            {
                    val_12 = val_12.Substring(startIndex:  0, length:  val_12.IndexOf(value:  '-'));
            }
            
            val_13 = this.mLanguages;
            var val_12 = 0;
            label_23:
            if(val_12 >= 1152921513201201056)
            {
                goto label_10;
            }
            
            if(val_11 != val_12)
            {
                    if(val_12 >= 21248752)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((public static System.Void System.Array::Resize<UnityEngine.Material>(ref T[] array, int newSize).__il2cppRuntimeField_18.StartsWith(value:  val_12)) != false)
            {
                    if(skipDisabled != false)
            {
                    if(val_12 >= (public static System.Void System.Array::Resize<UnityEngine.Material>(ref T[] array, int newSize)))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
                val_14 = 1;
                string val_6 = termData.GetTranslation(idx:  0, specialization:  overrideSpecialization, editMode:  true);
                Translation = val_6;
                if((System.String.IsNullOrEmpty(value:  val_6)) == false)
            {
                    return (bool)val_14;
            }
            
            }
            
            }
            
            val_12 = val_12 + 1;
            if(this.mLanguages != null)
            {
                goto label_23;
            }
            
            label_10:
            var val_15 = 0;
            val_11 = val_11;
            label_39:
            if(val_15 >= val_13)
            {
                goto label_25;
            }
            
            if(val_11 == val_15)
            {
                goto label_36;
            }
            
            if(skipDisabled == false)
            {
                goto label_27;
            }
            
            val_13 = val_13 & 4294967295;
            if(val_15 >= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            var val_14 = (((true + (langIndex) << 3) + 32 & 4294967295) + 0) + 32 + 32;
            if((val_14 & 1) != 0)
            {
                goto label_36;
            }
            
            label_27:
            if(val_12 == 0)
            {
                goto label_31;
            }
            
            if(val_15 >= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            if((((((true + (langIndex) << 3) + 32 & 4294967295) + 0) + 32 + 32 + 0) + 32 + 24.StartsWith(value:  val_12)) == true)
            {
                goto label_36;
            }
            
            label_31:
            val_14 = 1;
            string val_9 = termData.GetTranslation(idx:  0, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_9;
            if((System.String.IsNullOrEmpty(value:  val_9)) == false)
            {
                    return (bool)val_14;
            }
            
            label_36:
            val_15 = val_15 + 1;
            if(this.mLanguages != null)
            {
                goto label_39;
            }
            
            throw new NullReferenceException();
            label_25:
            val_14 = 0;
            Translation = 0;
            return (bool)val_14;
        }
        public I2.Loc.TermData GetTermData(string term, bool allowCategoryMistmatch = False)
        {
            string val_9;
            var val_10;
            val_9 = term;
            I2.Loc.TermData val_3 = 0;
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                    return (I2.Loc.TermData)val_10;
            }
            
            if(this.mDictionary.Count == 0)
            {
                    this.UpdateDictionary(force:  false);
            }
            
            if((this.mDictionary.TryGetValue(key:  val_9, value: out  val_3)) != false)
            {
                    val_10 = val_3;
                return (I2.Loc.TermData)val_10;
            }
            
            if(allowCategoryMistmatch == false)
            {
                goto label_7;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_6 = this.mDictionary.GetEnumerator();
            val_9 = 0;
            label_14:
            val_10 = val_9;
            label_13:
            if(0.MoveNext() == false)
            {
                goto label_11;
            }
            
            val_9 = 0;
            if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_9.IsTerm(name:  I2.Loc.LanguageSourceData.GetKeyFromFullTerm(FullTerm:  val_9, OnlyMainCategory:  false), allowCategoryMistmatch:  true)) == false)
            {
                goto label_13;
            }
            
            if(val_10 == 0)
            {
                goto label_14;
            }
            
            val_10 = 0;
            label_11:
            0.Dispose();
            return (I2.Loc.TermData)val_10;
            label_7:
            val_10 = 0;
            return (I2.Loc.TermData)val_10;
        }
        public static void ValidateFullTerm(ref string Term)
        {
            var val_9;
            string val_10;
            var val_11;
            string val_1 = Term.Replace(oldChar:  '\', newChar:  '/');
            Term = val_1;
            string val_2 = val_1.Trim();
            Term = val_2;
            if((val_2.StartsWith(value:  I2.Loc.LanguageSourceData.EmptyCategory, comparisonType:  4)) != false)
            {
                    val_9 = null;
                val_9 = null;
                val_10 = I2.Loc.LanguageSourceData.EmptyCategory;
                if(val_2.m_stringLength > I2.Loc.LanguageSourceData.EmptyCategory.m_stringLength)
            {
                    val_10 = I2.Loc.LanguageSourceData.EmptyCategory;
                if((Term.Chars[I2.Loc.LanguageSourceData.EmptyCategory.m_stringLength] & 65535) == ('/'))
            {
                    val_11 = null;
                val_11 = null;
                Term = Term.Substring(startIndex:  I2.Loc.LanguageSourceData.EmptyCategory.m_stringLength + 1);
            }
            
            }
            
            }
            
            Term = I2.Loc.I2Utils.GetValidTermName(text:  Term, allowCategory:  true);
        }
        public LanguageSourceData()
        {
            var val_6;
            var val_7;
            this.GoogleLiveSyncIsUptoDate = true;
            this.mTerms = new System.Collections.Generic.List<I2.Loc.TermData>();
            val_6 = null;
            val_6 = null;
            this.mDictionary = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>(comparer:  System.StringComparer._ordinal);
            this.OnMissingTranslation = 1;
            this.mLanguages = new System.Collections.Generic.List<I2.Loc.LanguageData>();
            this.GoogleUpdateSynchronization = 1;
            this.GoogleUpdateFrequency = 4.24399158341274E-314;
            this.Assets = new System.Collections.Generic.List<UnityEngine.Object>();
            val_7 = null;
            val_7 = null;
            this.mAssetDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer._ordinal);
        }
        private static LanguageSourceData()
        {
            I2.Loc.LanguageSourceData.EmptyCategory = "Default";
            I2.Loc.LanguageSourceData.CategorySeparators = ToCharArray();
        }
    
    }

}
