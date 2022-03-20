using UnityEngine;

namespace View.CommonItem
{
    public class LoadingItem : MonoBehaviour
    {
        // Fields
        public View.CommonItem.LoadingPoint[] Points;
        private UnityEngine.Coroutine _coroutine;
        private int _pointIndex;
        
        // Methods
        private System.Collections.IEnumerator PlayAni()
        {
            typeof(LoadingItem.<PlayAni>d__3).__il2cppRuntimeField_10 = 0;
            typeof(LoadingItem.<PlayAni>d__3).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnEnable()
        {
            this._coroutine = this.StartCoroutine(routine:  this.PlayAni());
        }
        private void OnDisable()
        {
            if(this._coroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this._coroutine);
        }
        public LoadingItem()
        {
        
        }
    
    }

}
