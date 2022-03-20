using UnityEngine;

namespace View.CommonItem
{
    public class LoadingPoint : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorPoint;
        
        // Methods
        public void PlayAni()
        {
            this.AnimatorPoint.Play(stateName:  "LoadingPoint");
        }
        public LoadingPoint()
        {
        
        }
    
    }

}
