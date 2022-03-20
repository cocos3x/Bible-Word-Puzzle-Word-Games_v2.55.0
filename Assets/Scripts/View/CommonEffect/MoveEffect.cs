using UnityEngine;

namespace View.CommonEffect
{
    public class MoveEffect : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 offset;
        private int index;
        private UnityEngine.Vector3[] paths;
        private DG.Tweening.Tween tween;
        
        // Methods
        public static View.CommonEffect.MoveEffect Create(UnityEngine.Transform parent, View.CommonEffect.MoveEffect moveEffectPrefab, int index)
        {
            View.CommonEffect.MoveEffect val_1 = UnityEngine.Object.Instantiate<View.CommonEffect.MoveEffect>(original:  moveEffectPrefab);
            val_1.name = moveEffectPrefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.index = index;
            return val_1;
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DoMove());
        }
        private void OnDisable()
        {
            if(this.tween == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.tween, complete:  false);
        }
        private System.Collections.IEnumerator DoMove()
        {
            typeof(MoveEffect.<DoMove>d__7).__il2cppRuntimeField_10 = 0;
            typeof(MoveEffect.<DoMove>d__7).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public MoveEffect()
        {
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  0f, y:  12f);
            this.offset = val_1.x;
            mem[1152921512921337664] = val_1.z;
        }
    
    }

}
