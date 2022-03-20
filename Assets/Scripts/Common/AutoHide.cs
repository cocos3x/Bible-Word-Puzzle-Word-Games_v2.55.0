using UnityEngine;

namespace Common
{
    public class AutoHide : MonoBehaviour
    {
        // Fields
        public float time;
        
        // Methods
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.HideDelay());
        }
        private System.Collections.IEnumerator HideDelay()
        {
            typeof(AutoHide.<HideDelay>d__2).__il2cppRuntimeField_10 = 0;
            typeof(AutoHide.<HideDelay>d__2).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public AutoHide()
        {
        
        }
    
    }

}
