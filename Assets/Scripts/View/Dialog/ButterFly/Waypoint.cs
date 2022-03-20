using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class Waypoint : MonoBehaviour
    {
        // Fields
        private bool _isLock;
        
        // Methods
        public void SetLockState(bool isLock)
        {
            this._isLock = isLock;
        }
        public bool GetLockState()
        {
            return (bool)this._isLock;
        }
        private void OnDisable()
        {
            this._isLock = false;
        }
        public Waypoint()
        {
        
        }
    
    }

}
