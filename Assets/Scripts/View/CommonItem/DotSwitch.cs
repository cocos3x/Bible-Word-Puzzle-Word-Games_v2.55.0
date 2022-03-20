using UnityEngine;

namespace View.CommonItem
{
    public class DotSwitch : MonoBehaviour
    {
        // Fields
        public UnityEngine.Color onBgColor;
        public UnityEngine.Color offBgColor;
        private bool _isOn;
        private UnityEngine.UI.Image bgImage;
        private UnityEngine.UI.Image onImage;
        private UnityEngine.UI.Image offImage;
        
        // Properties
        public bool isOpen { get; set; }
        
        // Methods
        public bool get_isOpen()
        {
            return (bool)this._isOn;
        }
        public void set_isOpen(bool value)
        {
            this._isOn = value;
            this.UpdateUI();
        }
        private void Awake()
        {
            this.bgImage = this.GetComponent<UnityEngine.UI.Image>();
            this.onImage = this.transform.Find(n:  "OnDot").GetComponent<UnityEngine.UI.Image>();
            this.offImage = this.transform.Find(n:  "OffDot").GetComponent<UnityEngine.UI.Image>();
            this.UpdateUI();
        }
        private void UpdateUI()
        {
            var val_1;
            if(this._isOn != false)
            {
                    this.bgImage.color = new UnityEngine.Color() {r = this.onBgColor};
                this.onImage.enabled = true;
                val_1 = 0;
            }
            else
            {
                    this.bgImage.color = new UnityEngine.Color() {r = this.offBgColor};
                this.onImage.enabled = false;
                val_1 = 1;
            }
            
            this.offImage.enabled = true;
        }
        public DotSwitch()
        {
        
        }
    
    }

}
