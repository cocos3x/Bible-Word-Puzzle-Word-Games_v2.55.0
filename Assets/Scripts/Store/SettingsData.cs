using UnityEngine;

namespace Store
{
    public class SettingsData : IStoreData
    {
        // Fields
        public bool IsMusicOn;
        public bool IsSoundOn;
        
        // Methods
        public void Reset()
        {
            this.IsMusicOn = true;
            this.IsSoundOn = true;
        }
        public SettingsData()
        {
            this.IsMusicOn = true;
            this.IsSoundOn = true;
        }
    
    }

}
