using UnityEngine;

namespace Data.Settings
{
    public class SettingsDataManager : Singleton<Data.Settings.SettingsDataManager>
    {
        // Properties
        public bool IsMusicOn { get; set; }
        public bool IsSoundOn { get; set; }
        
        // Methods
        public void Init()
        {
            Logic.Game.GameManager.gameMusic.mute = (~this.IsMusicOn) & 1;
            Logic.Game.GameManager.gameSound.mute = (~Logic.Game.GameManager.gameMusic.IsSoundOn) & 1;
        }
        public bool get_IsMusicOn()
        {
            return (bool)Store.SettingsData.__il2cppRuntimeField_name;
        }
        private void set_IsMusicOn(bool value)
        {
            typeof(Store.SettingsData).__il2cppRuntimeField_10 = value;
        }
        public bool get_IsSoundOn()
        {
            return (bool)typeof(Store.SettingsData).__il2cppRuntimeField_11;
        }
        private void set_IsSoundOn(bool value)
        {
            typeof(Store.SettingsData).__il2cppRuntimeField_11 = value;
        }
        public void ChangeMusicOn(bool isOn)
        {
            isOn = isOn;
            this.IsMusicOn = isOn;
            Logic.Game.GameManager.gameMusic.mute = (~this.IsMusicOn) & 1;
        }
        public void ChangeSoundOn(bool isOn)
        {
            isOn = isOn;
            this.IsSoundOn = isOn;
            Logic.Game.GameManager.gameSound.mute = (~this.IsSoundOn) & 1;
        }
        public SettingsDataManager()
        {
        
        }
    
    }

}
