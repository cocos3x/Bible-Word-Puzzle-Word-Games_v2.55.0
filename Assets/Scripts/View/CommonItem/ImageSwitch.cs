using UnityEngine;

namespace View.CommonItem
{
    public class ImageSwitch : MonoBehaviour
    {
        // Fields
        public UnityEngine.Sprite onSprite;
        public UnityEngine.Sprite offSprite;
        private UnityEngine.UI.Image image;
        private bool _isOn;
        
        // Properties
        public bool isOn { get; set; }
        
        // Methods
        public bool get_isOn()
        {
            return (bool)this._isOn;
        }
        public void set_isOn(bool value)
        {
            bool val_2 = this._isOn;
            if((val_2 != false) && (value != true))
            {
                    this.image.sprite = this.offSprite;
                val_2 = this._isOn;
            }
            
            if((val_2 != true) && (value != false))
            {
                    this.image.sprite = this.onSprite;
            }
            
            this._isOn = value;
        }
        private void Awake()
        {
            this.image = this.GetComponent<UnityEngine.UI.Image>();
        }
        public ImageSwitch()
        {
            this._isOn = true;
        }
    
    }

}
