using UnityEngine;

namespace Utils.Extensions
{
    public static class MonoBehaviourExtension
    {
        // Methods
        public static UnityEngine.Coroutine WaitSecondsDo(UnityEngine.MonoBehaviour behaviour, System.Action call, float seconds)
        {
            if(behaviour == 0)
            {
                    return 0;
            }
            
            if(behaviour.isActiveAndEnabled == false)
            {
                    return 0;
            }
            
            return behaviour.StartCoroutine(routine:  Utils.Extensions.MonoBehaviourExtension.WaitDo(call:  call, seconds:  seconds));
        }
        public static UnityEngine.Coroutine WaitFramesDo(UnityEngine.MonoBehaviour behaviour, System.Action call, int frames = 1)
        {
            if(behaviour == 0)
            {
                    return 0;
            }
            
            if(behaviour.isActiveAndEnabled == false)
            {
                    return 0;
            }
            
            return behaviour.StartCoroutine(routine:  Utils.Extensions.MonoBehaviourExtension.WaitDo(call:  call, frames:  frames));
        }
        private static System.Collections.IEnumerator WaitDo(System.Action call, float seconds)
        {
            typeof(MonoBehaviourExtension.<WaitDo>d__2).__il2cppRuntimeField_10 = 0;
            typeof(MonoBehaviourExtension.<WaitDo>d__2).__il2cppRuntimeField_28 = call;
            typeof(MonoBehaviourExtension.<WaitDo>d__2).__il2cppRuntimeField_20 = seconds;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static System.Collections.IEnumerator WaitDo(System.Action call, int frames)
        {
            typeof(MonoBehaviourExtension.<WaitDo>d__3).__il2cppRuntimeField_10 = 0;
            typeof(MonoBehaviourExtension.<WaitDo>d__3).__il2cppRuntimeField_28 = call;
            typeof(MonoBehaviourExtension.<WaitDo>d__3).__il2cppRuntimeField_20 = frames;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
