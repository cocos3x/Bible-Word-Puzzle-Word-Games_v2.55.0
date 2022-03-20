using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleProgress : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Image ImageCompleted;
        public UnityEngine.UI.Image ImageAllCompleted;
        protected DG.Tweening.Tweener _tweenerProgress;
        
        // Methods
        public virtual void SetProgress(float progress, bool isAll = False)
        {
        
        }
        public virtual DG.Tweening.Tweener AddProgress(float aniTime, bool isAll = False)
        {
            return (DG.Tweening.Tweener)this._tweenerProgress;
        }
        public virtual void ResetProgress()
        {
        
        }
        public MainBibleProgress()
        {
        
        }
    
    }

}
