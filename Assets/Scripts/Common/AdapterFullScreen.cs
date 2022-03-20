using UnityEngine;

namespace Common
{
    public class AdapterFullScreen : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform TransformAdapter;
        public UnityEngine.Vector3 AdapterScaleLong;
        public UnityEngine.Vector3 AdapterScaleWide;
        
        // Methods
        private void AdapterContent()
        {
            float val_4 = (float)UnityEngine.Screen.width;
            val_4 = val_4 / (float)UnityEngine.Screen.height;
            if(val_4 < 0)
            {
                
            }
            else
            {
                    if(val_4 > 0.6f)
            {
                
            }
            else
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            }
            
            }
            
            this.TransformAdapter.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        private void Awake()
        {
            this.AdapterContent();
        }
        public AdapterFullScreen()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.91f);
            this.AdapterScaleLong = val_2;
            mem[1152921513071146260] = val_2.y;
            mem[1152921513071146264] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.85f);
            this.AdapterScaleWide = val_4;
            mem[1152921513071146272] = val_4.y;
            mem[1152921513071146276] = val_4.z;
        }
    
    }

}
