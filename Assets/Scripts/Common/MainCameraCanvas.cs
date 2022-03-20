using UnityEngine;

namespace Common
{
    public class MainCameraCanvas : MonoBehaviour
    {
        // Fields
        private UnityEngine.Canvas canvas;
        
        // Methods
        private void Awake()
        {
            this.canvas = this.GetComponent<UnityEngine.Canvas>();
            this.SetMainCamera();
        }
        public void SetMainCamera()
        {
            this.canvas.worldCamera = UnityEngine.Camera.main;
        }
        public MainCameraCanvas()
        {
        
        }
    
    }

}
