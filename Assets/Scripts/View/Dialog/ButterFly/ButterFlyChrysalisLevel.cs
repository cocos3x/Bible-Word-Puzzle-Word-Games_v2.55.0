using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class ButterFlyChrysalisLevel : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Image ImageChrysalis;
        public UnityEngine.UI.Image ImageChrysalisSplit;
        
        // Methods
        public void SetChrysalisState(bool isCollect)
        {
            this.ImageChrysalis.gameObject.SetActive(value:  (~isCollect) & 1);
            this.ImageChrysalisSplit.gameObject.SetActive(value:  isCollect);
        }
        public ButterFlyChrysalisLevel()
        {
        
        }
    
    }

}
