using UnityEngine;

namespace View.CommonItem
{
    public class Letter : MonoBehaviour
    {
        // Fields
        private char _letter;
        private UnityEngine.UI.Image letterImage;
        
        // Properties
        public char letter { get; set; }
        
        // Methods
        public char get_letter()
        {
            return (char)this._letter;
        }
        public void set_letter(char value)
        {
            char val_6;
            UnityEngine.UI.Image val_7;
            val_6 = value;
            if(this._letter == val_6)
            {
                    return;
            }
            
            this._letter = val_6;
            if(this.letterImage == 0)
            {
                    UnityEngine.UI.Image val_2 = this.GetComponent<UnityEngine.UI.Image>();
                val_7 = val_2;
                this.letterImage = val_2;
            }
            else
            {
                    val_7 = this.letterImage;
            }
            
            val_6 = System.String.Format(format:  "letter_{0}", arg0:  System.Char.ToLower(c:  val_6));
            val_7.sprite = Resource.ResManager.GetSpriteFromPool(atlas:  "Atlas/Game", spriteName:  val_6);
        }
        public Letter()
        {
        
        }
    
    }

}
