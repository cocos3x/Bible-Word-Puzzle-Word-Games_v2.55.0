using UnityEngine;

namespace Logic.Gameplay
{
    public class GameplayController : SingletonController<Logic.Gameplay.GameplayController>
    {
        // Fields
        private bool <ShouldShowRate>k__BackingField;
        private bool <GameSceneShouldAd>k__BackingField;
        
        // Properties
        public bool ShouldShowRate { get; set; }
        public bool GameSceneShouldAd { get; set; }
        
        // Methods
        public bool get_ShouldShowRate()
        {
            return (bool)this.<ShouldShowRate>k__BackingField;
        }
        public void set_ShouldShowRate(bool value)
        {
            this.<ShouldShowRate>k__BackingField = value;
        }
        public bool get_GameSceneShouldAd()
        {
            return (bool)this.<GameSceneShouldAd>k__BackingField;
        }
        public void set_GameSceneShouldAd(bool value)
        {
            this.<GameSceneShouldAd>k__BackingField = value;
        }
        public GameplayController()
        {
        
        }
    
    }

}
