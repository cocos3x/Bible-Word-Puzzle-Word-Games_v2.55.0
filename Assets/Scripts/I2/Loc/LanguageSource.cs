using UnityEngine;

namespace I2.Loc
{
    public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
    {
        // Fields
        public I2.Loc.LanguageSourceData mSource;
        public int version;
        public bool NeverDestroy;
        public bool UserAgreesToHaveItOnTheScene;
        public bool UserAgreesToHaveItInsideThePluginsFolder;
        public bool GoogleLiveSyncIsUptoDate;
        public System.Collections.Generic.List<UnityEngine.Object> Assets;
        public string Google_WebServiceURL;
        public string Google_SpreadsheetKey;
        public string Google_SpreadsheetName;
        public string Google_LastUpdatedVersion;
        public I2.Loc.LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;
        public float GoogleUpdateDelay;
        private I2.Loc.LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle;
        public System.Collections.Generic.List<I2.Loc.LanguageData> mLanguages;
        public bool IgnoreDeviceLanguage;
        public I2.Loc.LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;
        public System.Collections.Generic.List<I2.Loc.TermData> mTerms;
        public bool CaseInsensitiveTerms;
        public I2.Loc.LanguageSourceData.MissingTranslationAction OnMissingTranslation;
        public string mTerm_AppName;
        
        // Properties
        public I2.Loc.LanguageSourceData SourceData { get; set; }
        
        // Methods
        public I2.Loc.LanguageSourceData get_SourceData()
        {
            return (I2.Loc.LanguageSourceData)this.mSource;
        }
        public void set_SourceData(I2.Loc.LanguageSourceData value)
        {
            this.mSource = value;
        }
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
            while(this.Event_OnSourceUpdateFromGoogle != 1152921513192650072);
            
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
            while(this.Event_OnSourceUpdateFromGoogle != 1152921513192786648);
            
            return;
            label_2:
        }
        private void Awake()
        {
            this.mSource.owner = this;
            this.mSource.Awake();
        }
        private void OnDestroy()
        {
            this.NeverDestroy = false;
            if(this.mSource != null)
            {
                    this.mSource.OnDestroy();
                return;
            }
            
            throw new NullReferenceException();
        }
        public string GetSourceName()
        {
            string val_8 = this.gameObject.name;
            UnityEngine.Transform val_3 = this.transform;
            goto label_3;
            label_7:
            val_8 = val_3.name + "_" + val_8;
            label_3:
            if((UnityEngine.Object.op_Implicit(exists:  val_3.parent)) == true)
            {
                goto label_7;
            }
            
            return (string)val_8;
        }
        public void OnBeforeSerialize()
        {
            this.version = 1;
        }
        public void OnAfterDeserialize()
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_2;
            var val_3;
            if(this.version != 0)
            {
                    if(this.mSource != null)
            {
                    return;
            }
            
            }
            
            this.mSource = new I2.Loc.LanguageSourceData();
            typeof(I2.Loc.LanguageSourceData).__il2cppRuntimeField_10 = this;
            this.mSource.UserAgreesToHaveItOnTheScene = this.UserAgreesToHaveItOnTheScene;
            this.mSource.UserAgreesToHaveItInsideThePluginsFolder = this.UserAgreesToHaveItInsideThePluginsFolder;
            this.mSource.IgnoreDeviceLanguage = this.IgnoreDeviceLanguage;
            this.mSource._AllowUnloadingLanguages = this._AllowUnloadingLanguages;
            this.mSource.CaseInsensitiveTerms = this.CaseInsensitiveTerms;
            this.mSource.OnMissingTranslation = this.OnMissingTranslation;
            this.mSource.mTerm_AppName = this.mTerm_AppName;
            this.mSource.GoogleLiveSyncIsUptoDate = this.GoogleLiveSyncIsUptoDate;
            this.mSource.Google_WebServiceURL = this.Google_WebServiceURL;
            this.mSource.Google_SpreadsheetKey = this.Google_SpreadsheetKey;
            this.mSource.Google_SpreadsheetName = this.Google_SpreadsheetName;
            this.mSource.Google_LastUpdatedVersion = this.Google_LastUpdatedVersion;
            this.mSource.GoogleUpdateFrequency = this.GoogleUpdateFrequency;
            this.mSource.GoogleUpdateDelay = this.GoogleUpdateDelay;
            this.mSource.add_Event_OnSourceUpdateFromGoogle(value:  this.Event_OnSourceUpdateFromGoogle);
            if((this.mLanguages != null) && (this.mLanguages >= 1))
            {
                    this.mSource.mLanguages.Clear();
                this.mSource.mLanguages.AddRange(collection:  this.mLanguages);
                this.mLanguages.Clear();
            }
            
            if((this.Assets != null) && (this.Assets >= 1))
            {
                    this.mSource.Assets.Clear();
                this.mSource.Assets.AddRange(collection:  this.Assets);
                this.Assets.Clear();
            }
            
            if((this.mTerms == null) || (this.mTerms < 1))
            {
                goto label_34;
            }
            
            I2.Loc.LanguageSourceData val_2 = this.mSource;
            this.mSource.mTerms.Clear();
            val_2 = this.mTerms;
            val_3 = 0;
            label_42:
            if(val_3 >= val_2)
            {
                goto label_38;
            }
            
            val_2 = val_2 & 4294967295;
            if(val_3 >= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.mSource.mTerms.Add(item:  I2.Loc.LanguageSourceData.__il2cppRuntimeField_byval_arg);
            val_2 = this.mTerms;
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_42;
            }
            
            throw new NullReferenceException();
            label_38:
            val_2.Clear();
            label_34:
            this.version = 1;
            this.Event_OnSourceUpdateFromGoogle = 0;
        }
        public LanguageSource()
        {
            this.mSource = new I2.Loc.LanguageSourceData();
            this.GoogleLiveSyncIsUptoDate = true;
            this.Assets = new System.Collections.Generic.List<UnityEngine.Object>();
            this.GoogleUpdateFrequency = 3;
            this.mLanguages = new System.Collections.Generic.List<I2.Loc.LanguageData>();
            this.mTerms = new System.Collections.Generic.List<I2.Loc.TermData>();
            this.OnMissingTranslation = true;
        }
    
    }

}
