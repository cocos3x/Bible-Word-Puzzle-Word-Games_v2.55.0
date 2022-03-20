using UnityEngine;

namespace View.CommonItem
{
    public class RubbyStar : MonoBehaviour
    {
        // Fields
        public float delay;
        public float intervalMin;
        public float intervalMax;
        public float time;
        public bool playOnEnable;
        private UnityEngine.UI.Image image;
        private float timeDelay;
        
        // Methods
        private void Awake()
        {
            UnityEngine.UI.Image val_1 = this.GetComponent<UnityEngine.UI.Image>();
            this.image = val_1;
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  0f);
            val_1.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        private void OnEnable()
        {
            if(this.playOnEnable == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Play());
        }
        private System.Collections.IEnumerator Play()
        {
            typeof(RubbyStar.<Play>d__9).__il2cppRuntimeField_10 = 0;
            typeof(RubbyStar.<Play>d__9).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public RubbyStar()
        {
        
        }
        private void <Play>b__9_0()
        {
            this.timeDelay = UnityEngine.Random.Range(min:  this.intervalMin, max:  this.intervalMax);
        }
    
    }

}
