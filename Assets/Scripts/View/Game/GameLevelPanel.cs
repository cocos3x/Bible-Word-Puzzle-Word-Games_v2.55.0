using UnityEngine;

namespace View.Game
{
    public class GameLevelPanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TextLevel;
        
        // Methods
        public void SetLevel(string level)
        {
            if(this.TextLevel != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public GameLevelPanel()
        {
        
        }
    
    }

}
