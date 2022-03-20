using UnityEngine;

namespace Utils.Extensions
{
    public static class CameraExtension
    {
        // Methods
        public static UnityEngine.Vector3 ScreenToWorldPointExt(UnityEngine.Camera camera, UnityEngine.Vector3 pointPosition)
        {
            if((System.Single.IsNaN(f:  pointPosition.x)) == true)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if((System.Single.IsInfinity(f:  pointPosition.x)) == true)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if((System.Single.IsNaN(f:  pointPosition.y)) == true)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if((System.Single.IsInfinity(f:  pointPosition.y)) == false)
            {
                    return camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z});
            }
            
            return UnityEngine.Vector3.zero;
        }
    
    }

}
