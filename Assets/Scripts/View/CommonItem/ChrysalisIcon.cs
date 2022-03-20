using UnityEngine;

namespace View.CommonItem
{
    public class ChrysalisIcon : MonoBehaviour
    {
        // Fields
        public UnityEngine.Sprite[] SpriteChrysalis;
        public UnityEngine.UI.Image ImageIcon;
        
        // Methods
        public void SetChrysalisIcon(int level)
        {
            int val_1 = level / this.SpriteChrysalis.Length;
            val_1 = level - (val_1 * this.SpriteChrysalis.Length);
            this.ImageIcon.sprite = this.SpriteChrysalis[val_1];
        }
        public ChrysalisIcon()
        {
        
        }
    
    }

}
