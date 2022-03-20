using UnityEngine;

namespace View.Game
{
    public class GameSideMenus : MonoBehaviour
    {
        // Fields
        public View.Game.WordTreasureIcon TreasureIcon;
        public UnityEngine.Transform CenterAni;
        
        // Methods
        private void OnEnable()
        {
            UnityEngine.Vector3 val_1 = this.CenterAni.position;
            this.TreasureIcon._beginPos = val_1;
            mem2[0] = val_1.y;
            mem2[0] = val_1.z;
        }
        public GameSideMenus()
        {
        
        }
    
    }

}
