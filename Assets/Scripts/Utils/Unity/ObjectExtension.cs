using UnityEngine;

namespace Utils.Unity
{
    public static class ObjectExtension
    {
        // Methods
        public static T Instantiate<T>(T selfObj)
        {
            if((UnityEngine.Object.op_Implicit(exists:  selfObj)) == false)
            {
                    return 0;
            }
            
            __RuntimeMethodHiddenParam = ???;
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public static T Name<T>(T self, string name)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            self.name = name;
            return (object)self;
        }
        public static void Destroy<T>(T self, float defaultDelay = 0)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  self, t:  defaultDelay);
        }
        public static T DontDestroyOnLoad<T>(T self)
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  self);
            return (object)self;
        }
        public static T As<T>(UnityEngine.Object self)
        {
            var val_1;
            if(X0 != false)
            {
                    if(X0 == true)
            {
                    return (object)val_1;
            }
            
            }
            
            val_1 = 0;
            return (object)val_1;
        }
    
    }

}
