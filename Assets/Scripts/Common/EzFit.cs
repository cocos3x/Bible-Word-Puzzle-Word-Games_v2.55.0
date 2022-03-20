using UnityEngine;

namespace Common
{
    public class EzFit : MonoBehaviour
    {
        // Fields
        public Common.FitType fixType;
        public UnityEngine.UI.CanvasScaler canvasScaler;
        public bool isFitIphoneXBottom;
        public bool isBg;
        public bool useScale;
        public float heightOffset;
        public float heightProportion;
        public float maxHeight;
        public float widthOffset;
        public float widthProportion;
        private UnityEngine.Vector2 canvasRectSize;
        private float ratio;
        private UnityEngine.RectTransform rectTransform;
        
        // Methods
        private void Awake()
        {
            UnityEngine.RectTransform val_43;
            UnityEngine.RectTransform val_44;
            float val_45;
            float val_46;
            UnityEngine.RectTransform val_48;
            float val_50;
            float val_51;
            float val_52;
            UnityEngine.RectTransform val_55;
            UnityEngine.RectTransform val_56;
            val_43 = this;
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_44 = 0;
            }
            
            this.rectTransform = val_44;
            float val_42 = (float)UnityEngine.Screen.width;
            val_42 = val_42 / (float)UnityEngine.Screen.height;
            this.ratio = val_42;
            if(this.fixType != 2)
            {
                goto label_3;
            }
            
            val_43 = this.rectTransform;
            val_42 = val_42 * 16f;
            UnityEngine.Vector3 val_6 = val_43.localScale;
            val_45 = val_6.x;
            val_46 = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45, y = val_6.y, z = val_46}, d:  val_42 / 9f);
            label_37:
            val_43.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            return;
            label_3:
            if(this.canvasScaler == 0)
            {
                    UnityEngine.GameObject val_9 = UnityEngine.GameObject.Find(name:  "GameCanvas");
                if(val_9 != 0)
            {
                    this.canvasScaler = val_9.GetComponent<UnityEngine.UI.CanvasScaler>();
            }
            
            }
            
            if(this.canvasScaler == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  (float)UnityEngine.Screen.width, y:  (float)UnityEngine.Screen.height);
            float val_43 = val_15.y;
            val_43 = val_43 / S10;
            val_46 = val_15.x;
            val_45 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Log(f:  val_15.x / this.canvasScaler.m_ReferenceResolution, p:  2f), b:  UnityEngine.Mathf.Log(f:  val_43, p:  2f), t:  this.canvasScaler.m_MatchWidthOrHeight);
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_46, y = val_15.y}, d:  val_45);
            this.canvasRectSize = val_20;
            mem[1152921513076282004] = val_20.y;
            UnityEngine.Vector2 val_21;
            val_20.y = val_20.y - this.heightOffset;
            val_21 = new UnityEngine.Vector2(x:  val_20.x, y:  val_20.y);
            this.canvasRectSize = val_21.x;
            mem[1152921513076282004] = val_21.y;
            if(this.fixType == 1)
            {
                goto label_24;
            }
            
            if(this.fixType != 0)
            {
                    return;
            }
            
            if(this.useScale == false)
            {
                goto label_26;
            }
            
            val_48 = this.rectTransform;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            val_50 = val_22.x;
            val_51 = val_22.y;
            val_52 = val_22.z;
            UnityEngine.Vector2 val_23 = this.rectTransform.sizeDelta;
            float val_25 = (this.heightProportion * S12) / val_23.y;
            goto label_30;
            label_24:
            val_55 = this.rectTransform;
            if(this.useScale == false)
            {
                goto label_31;
            }
            
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
            val_50 = val_26.x;
            val_51 = val_26.y;
            val_52 = val_26.z;
            UnityEngine.Vector2 val_27 = this.rectTransform.sizeDelta;
            UnityEngine.Vector2 val_28 = this.rectTransform.sizeDelta;
            label_30:
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_50, y = val_51, z = val_52}, d:  (val_27.x * this.widthProportion) / val_28.x);
            goto label_37;
            label_26:
            val_45 = this.heightProportion * val_21.y;
            if(this.maxHeight != 0f)
            {
                    val_45 = UnityEngine.Mathf.Min(a:  val_45, b:  this.maxHeight);
            }
            
            UnityEngine.Vector2 val_33 = this.rectTransform.sizeDelta;
            UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  val_33.x, y:  val_45);
            this.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_34.x, y = val_34.y};
            if(Platform.Device.DeviceDefine.IsNotchScreen() == false)
            {
                    return;
            }
            
            val_56 = this.rectTransform;
            UnityEngine.Vector2 val_36 = val_56.sizeDelta;
            val_45 = val_36.x;
            float val_44 = (float)Platform.Device.DeviceDefine.GetNotchHeight();
            UnityEngine.Vector2 val_38;
            val_44 = this.heightProportion * val_44;
            val_38 = new UnityEngine.Vector2(x:  0f, y:  val_44);
            UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_45, y = val_36.y}, b:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y});
            goto label_46;
            label_31:
            UnityEngine.Vector2 val_40 = val_55.sizeDelta;
            UnityEngine.Vector2 val_41;
            val_40.x = val_40.x * this.widthProportion;
            val_41 = new UnityEngine.Vector2(x:  val_40.x, y:  val_40.y);
            label_46:
            val_55.sizeDelta = new UnityEngine.Vector2() {x = val_41.x, y = val_41.y};
        }
        public static bool IsIphoneX()
        {
            var val_4 = null;
            float val_4 = (float)UnityEngine.Screen.width;
            val_4 = val_4 / (float)UnityEngine.Screen.height;
            val_4 = val_4 + (-0.4618227f);
            return (bool)(val_4 <= System.Math.Abs(UnityEngine.Mathf.Epsilon)) ? 1 : 0;
        }
        public void SetHight()
        {
            UnityEngine.Vector2 val_2 = this.transform.sizeDelta;
            float val_3 = 1920f;
            val_3 = val_2.y / val_3;
            this.heightProportion = val_3;
        }
        public EzFit()
        {
        
        }
    
    }

}
