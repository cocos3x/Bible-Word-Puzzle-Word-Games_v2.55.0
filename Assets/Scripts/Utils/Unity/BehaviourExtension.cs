using UnityEngine;

namespace Utils.Unity
{
    public static class BehaviourExtension
    {
        // Methods
        public static T Enable<T>(T self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            self.enabled = true;
            return (object)self;
        }
        public static T Disable<T>(T self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            self.enabled = false;
            return (object)self;
        }
    
    }

}
