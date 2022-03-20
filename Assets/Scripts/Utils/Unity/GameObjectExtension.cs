using UnityEngine;

namespace Utils.Unity
{
    public static class GameObjectExtension
    {
        // Methods
        public static UnityEngine.GameObject Active(UnityEngine.GameObject self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.GameObject)self;
            }
            
            self.SetActive(value:  true);
            return (UnityEngine.GameObject)self;
        }
        public static UnityEngine.GameObject Inactive(UnityEngine.GameObject self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.GameObject)self;
            }
            
            self.SetActive(value:  false);
            return (UnityEngine.GameObject)self;
        }
        public static UnityEngine.GameObject Layer(UnityEngine.GameObject self, int layer)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.GameObject)self;
            }
            
            self.layer = layer;
            return (UnityEngine.GameObject)self;
        }
        public static UnityEngine.GameObject Layer(UnityEngine.GameObject self, string layerName)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.GameObject)self;
            }
            
            self.layer = UnityEngine.LayerMask.NameToLayer(layerName:  layerName);
            return (UnityEngine.GameObject)self;
        }
        public static T GetComponentNotNull<T>(UnityEngine.GameObject self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    throw new System.NullReferenceException(message:  "Null object can not get component!");
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self)) != false)
            {
                    return (object)self;
            }
        
        }
    
    }

}
