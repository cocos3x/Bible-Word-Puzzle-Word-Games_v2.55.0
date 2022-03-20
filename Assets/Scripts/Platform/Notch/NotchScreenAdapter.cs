using UnityEngine;

namespace Platform.Notch
{
    public class NotchScreenAdapter : MonoBehaviour
    {
        // Fields
        private bool _isNeedAdapter;
        private float _notchSize;
        private UnityEngine.RectTransform _rectTransform;
        private UnityEngine.Vector2 _oriOffsetMax;
        private UnityEngine.Vector2 _notchOffsetMax;
        
        // Methods
        private void Awake()
        {
            this._isNeedAdapter = Platform.Device.DeviceDefine.IsNotchScreen();
            this._notchSize = (float)Platform.Device.DeviceDefine.GetNotchHeight();
            UnityEngine.RectTransform val_4 = this.GetComponent<UnityEngine.RectTransform>();
            this._rectTransform = val_4;
            UnityEngine.Vector2 val_5 = val_4.offsetMax;
            this._oriOffsetMax = val_5;
            mem[1152921513096332652] = val_5.y;
            val_5.y = val_5.y - this._notchSize;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
            this._notchOffsetMax = val_6.x;
        }
        private void Start()
        {
            this.UpdateLayout();
        }
        private void UpdateLayout()
        {
            if(this._isNeedAdapter == false)
            {
                    return;
            }
            
            if(this._rectTransform != null)
            {
                    this._rectTransform.offsetMax = new UnityEngine.Vector2() {x = this._notchOffsetMax};
                return;
            }
            
            throw new NullReferenceException();
        }
        public NotchScreenAdapter()
        {
        
        }
    
    }

}
