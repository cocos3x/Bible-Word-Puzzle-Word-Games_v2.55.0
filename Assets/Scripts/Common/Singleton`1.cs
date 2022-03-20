using UnityEngine;

namespace Common
{
    public class Singleton<T>
    {
        // Fields
        private static T _instance;
        
        // Properties
        public static T Instance { get; }
        
        // Methods
        public static T get_Instance()
        {
            var val_1;
            var val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 302];
                val_1 = __RuntimeMethodHiddenParam + 24 + 302;
                val_2 = __RuntimeMethodHiddenParam + 24;
                if((val_1 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24];
                val_2 = __RuntimeMethodHiddenParam + 24;
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 302];
                val_1 = __RuntimeMethodHiddenParam + 24 + 302;
            }
            
                mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) != 0)
            {
                    return (Common.EnterShow.EnterShow)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            return (Common.EnterShow.EnterShow)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        public Singleton<T>()
        {
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
