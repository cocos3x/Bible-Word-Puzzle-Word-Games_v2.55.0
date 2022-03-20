using UnityEngine;

namespace I2.Loc
{
    public class LanguageSourceAsset : ScriptableObject, ILanguageSource
    {
        // Fields
        public I2.Loc.LanguageSourceData mSource;
        
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
        public LanguageSourceAsset()
        {
            this.mSource = new I2.Loc.LanguageSourceData();
        }
    
    }

}
