using UnityEngine;

namespace View.Dialog.GameDictionary
{
    public class GameDictionaryTips : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshProUGUI TextTips;
        
        // Methods
        public void SetTips(string tips)
        {
            if(this.TextTips != null)
            {
                    this.TextTips.text = tips;
                return;
            }
            
            throw new NullReferenceException();
        }
        public GameDictionaryTips()
        {
        
        }
    
    }

}
