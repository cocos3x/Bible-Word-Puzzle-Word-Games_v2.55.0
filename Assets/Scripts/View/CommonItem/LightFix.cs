using UnityEngine;

namespace View.CommonItem
{
    public class LightFix : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform[] horizontals;
        public UnityEngine.Transform[] verticals;
        
        // Methods
        private void Start()
        {
            float val_14;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Rect val_2 = val_1.rect;
            UnityEngine.Vector2 val_3 = val_2.m_XMin.size;
            UnityEngine.Debug.Log(message:  "rect = "("rect = ") + val_3);
            if(this.verticals.Length >= 1)
            {
                    val_14 = 100f;
                var val_15 = 0;
                do
            {
                UnityEngine.Rect val_6 = val_1.rect;
                UnityEngine.Vector2 val_7 = val_6.m_XMin.size;
                val_7.y = (val_7.y * val_14) / 1400f;
                UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_14, y:  val_7.y, z:  val_14);
                this.verticals[val_15].transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                val_15 = val_15 + 1;
            }
            while(val_15 < this.verticals.Length);
            
            }
            
            if(this.horizontals.Length < 1)
            {
                    return;
            }
            
            val_14 = 100f;
            var val_17 = 0;
            do
            {
                UnityEngine.Rect val_11 = val_1.rect;
                UnityEngine.Vector2 val_12 = val_11.m_XMin.size;
                val_12.x = val_12.x * val_14;
                val_12.x = val_12.x / 1080f;
                UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_12.x, y:  val_14, z:  val_14);
                this.horizontals[val_17].transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
                val_17 = val_17 + 1;
            }
            while(val_17 < this.horizontals.Length);
        
        }
        public LightFix()
        {
        
        }
    
    }

}
