using UnityEngine;

namespace I2.Loc
{
    public class CoroutineManager : MonoBehaviour
    {
        // Fields
        private static I2.Loc.CoroutineManager mInstance;
        
        // Properties
        private static I2.Loc.CoroutineManager pInstance { get; }
        
        // Methods
        private static I2.Loc.CoroutineManager get_pInstance()
        {
            I2.Loc.CoroutineManager val_5 = I2.Loc.CoroutineManager.mInstance;
            if(val_5 != 0)
            {
                    return (I2.Loc.CoroutineManager)I2.Loc.CoroutineManager.mInstance;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_5 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "_Coroutiner");
            hideFlags = 61;
            I2.Loc.CoroutineManager.mInstance = AddComponent<I2.Loc.CoroutineManager>();
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (I2.Loc.CoroutineManager)I2.Loc.CoroutineManager.mInstance;
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  val_5);
            return (I2.Loc.CoroutineManager)I2.Loc.CoroutineManager.mInstance;
        }
        private void Awake()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public static UnityEngine.Coroutine Start(System.Collections.IEnumerator coroutine)
        {
            return I2.Loc.CoroutineManager.pInstance.StartCoroutine(routine:  coroutine);
        }
        public CoroutineManager()
        {
        
        }
    
    }

}
