using UnityEngine;

namespace Utils.Unity
{
    public static class ComponentExtension
    {
        // Methods
        public static T Active<T>(T self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self.gameObject)) == false)
            {
                    return (object)self;
            }
            
            UnityEngine.GameObject val_5 = Utils.Unity.GameObjectExtension.Active(self:  self.gameObject);
            return (object)self;
        }
        public static T Inactive<T>(T self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            UnityEngine.GameObject val_3 = Utils.Unity.GameObjectExtension.Inactive(self:  self.gameObject);
            return (object)self;
        }
        public static T Layer<T>(T self, int layer)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self.gameObject)) == false)
            {
                    return (object)self;
            }
            
            UnityEngine.GameObject val_5 = Utils.Unity.GameObjectExtension.Layer(self:  self.gameObject, layer:  layer);
            return (object)self;
        }
        public static T Layer<T>(T self, string layerName)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (object)self;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self.gameObject)) == false)
            {
                    return (object)self;
            }
            
            UnityEngine.GameObject val_5 = Utils.Unity.GameObjectExtension.Layer(self:  self.gameObject, layerName:  layerName);
            return (object)self;
        }
        public static void DestroyGameObj<T>(T self, float defaultDelay = 0)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self.gameObject)) == false)
            {
                    return;
            }
            
            Utils.Unity.ObjectExtension.Destroy<UnityEngine.GameObject>(self:  self.gameObject, defaultDelay:  0f);
        }
        public static void ChangeCanvasSorting<T>(T self, string name = "Default", int order = 0)
        {
            UnityEngine.Object val_8;
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self.gameObject)) == false)
            {
                    return;
            }
            
            val_8 = self.GetComponent<UnityEngine.Canvas>();
            if(val_8 == 0)
            {
                    val_8 = self.gameObject.AddComponent<UnityEngine.Canvas>();
            }
            
            val_8.overrideSorting = true;
            val_8.sortingLayerName = name;
            val_8.sortingOrder = order;
        }
        public static void ChangeCanvasUnsorting<T>(T self)
        {
            object val_6 = self;
            if((UnityEngine.Object.op_Implicit(exists:  val_6 = self)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_6.gameObject)) == false)
            {
                    return;
            }
            
            val_6 = val_6.GetComponent<UnityEngine.Canvas>();
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6.overrideSorting = false;
        }
        public static void RemoveComponent<T, K>(T self)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  self.gameObject)) == false)
            {
                    return;
            }
            
            if(self == null)
            {
                    return;
            }
            
            __RuntimeMethodHiddenParam = ???;
            goto __RuntimeMethodHiddenParam + 48 + 24;
        }
        public static T GetComponentByPath<T>(UnityEngine.Component target, string path)
        {
            UnityEngine.Component val_5 = target;
            if((System.String.IsNullOrEmpty(value:  path)) != true)
            {
                    val_5 = val_5.transform.Find(n:  path);
            }
            
            if(val_5 == 0)
            {
                    return 0;
            }
        
        }
        public static UnityEngine.Component GetComponentByPath(UnityEngine.Component target, System.Type type, string path)
        {
            UnityEngine.Component val_5 = target;
            if((System.String.IsNullOrEmpty(value:  path)) != true)
            {
                    val_5 = val_5.transform.Find(n:  path);
            }
            
            if(val_5 != 0)
            {
                    return val_5.GetComponent(type:  type);
            }
            
            return 0;
        }
        public static T AddComponentByPath<T>(UnityEngine.Component target, string path)
        {
            UnityEngine.Object val_6 = target.transform;
            if((System.String.IsNullOrEmpty(value:  path)) != true)
            {
                    val_6 = val_6.Find(n:  path);
            }
            
            if(val_6 == 0)
            {
                    return 0;
            }
            
            UnityEngine.GameObject val_5 = val_6.gameObject;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static UnityEngine.Component AddComponentByPath(UnityEngine.Component target, System.Type type, string path)
        {
            UnityEngine.Object val_6 = target.transform;
            if((System.String.IsNullOrEmpty(value:  path)) != true)
            {
                    val_6 = val_6.Find(n:  path);
            }
            
            if(val_6 != 0)
            {
                    return val_6.gameObject.AddComponent(componentType:  type);
            }
            
            return 0;
        }
        public static T GetOrAddComponentByPath<T>(UnityEngine.Component target, string path)
        {
            var val_8;
            UnityEngine.Object val_9;
            UnityEngine.Object val_10;
            val_8 = path;
            val_9 = target;
            val_10 = val_9;
            if(val_10 != 0)
            {
                    return (object)val_10;
            }
            
            val_8 = ???;
            val_10 = ???;
            val_9 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        public static UnityEngine.Component GetOrAddComponentByPath(UnityEngine.Component target, System.Type type, string path)
        {
            UnityEngine.Component val_1 = Utils.Unity.ComponentExtension.GetComponentByPath(target:  target, type:  type, path:  path);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            return Utils.Unity.ComponentExtension.AddComponentByPath(target:  target, type:  type, path:  path);
        }
        public static T GetOrAddComponent<T>(UnityEngine.Component target)
        {
            var val_8;
            UnityEngine.Object val_9;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = target;
            if(val_9 != 0)
            {
                    return (Logic.Game.GameConfig)val_9;
            }
            
            UnityEngine.GameObject val_2 = target.gameObject;
            val_8 = ???;
            val_9 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        public static UnityEngine.Component GetOrAddComponent(UnityEngine.Component target, System.Type type)
        {
            UnityEngine.Component val_1 = target.GetComponent(type:  type);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            return target.gameObject.AddComponent(componentType:  type);
        }
        public static void LocalNormalize(UnityEngine.Transform target)
        {
            if(0 == target)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            target.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            target.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            target.localEulerAngles = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
    
    }

}
