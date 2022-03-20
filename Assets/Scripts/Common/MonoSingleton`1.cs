using UnityEngine;

namespace Common
{
    public class MonoSingleton<T> : MonoBehaviour
    {
        // Fields
        private static T <instance>k__BackingField;
        
        // Properties
        public static T instance { get; set; }
        
        // Methods
        public static T get_instance()
        {
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) != 0)
            {
                    return (Logic.Game.GameManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            return (Logic.Game.GameManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        protected static void set_instance(T value)
        {
            mem2[0] = value;
        }
        protected virtual void Awake()
        {
            if(X0 != false)
            {
                    if(X0 == true)
            {
                goto __RuntimeMethodHiddenParam + 24 + 192 + 8 + 8;
            }
            
            }
        
        }
        protected virtual void OnDestroy()
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 16;
        }
        public MonoSingleton<T>()
        {
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
