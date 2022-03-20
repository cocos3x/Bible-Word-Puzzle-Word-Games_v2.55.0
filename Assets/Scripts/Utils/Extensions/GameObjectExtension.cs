using UnityEngine;

namespace Utils.Extensions
{
    public static class GameObjectExtension
    {
        // Methods
        public static void ChangeCanvasSorting(UnityEngine.GameObject obj, string name = "Default", int order = 0)
        {
            UnityEngine.Canvas val_4 = obj.GetComponent<UnityEngine.Canvas>();
            if(val_4 == 0)
            {
                    val_4 = obj.AddComponent<UnityEngine.Canvas>();
            }
            
            val_4.overrideSorting = true;
            val_4.sortingLayerName = name;
            val_4.sortingOrder = order;
        }
        public static T GetComponentByPath<T>(UnityEngine.GameObject target, string path)
        {
            UnityEngine.Transform val_1 = target.transform;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static UnityEngine.Component GetComponentByPath(UnityEngine.GameObject target, System.Type type, string path)
        {
            return Utils.Unity.ComponentExtension.GetComponentByPath(target:  target.transform, type:  type, path:  path);
        }
        public static T AddComponentByPath<T>(UnityEngine.GameObject target, string path)
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
        public static UnityEngine.Component AddComponentByPath(UnityEngine.GameObject target, System.Type type, string path)
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
        public static T GetOrAddComponentByPath<T>(UnityEngine.GameObject target, string path)
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
        public static UnityEngine.Component GetOrAddComponentByPath(UnityEngine.GameObject target, System.Type type, string path)
        {
            UnityEngine.Component val_1 = Utils.Extensions.GameObjectExtension.GetComponentByPath(target:  target, type:  type, path:  path);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            return Utils.Extensions.GameObjectExtension.AddComponentByPath(target:  target, type:  type, path:  path);
        }
        public static T GetOrAddComponent<T>(UnityEngine.GameObject target)
        {
            var val_8;
            UnityEngine.Object val_9;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = target;
            if(val_9 != 0)
            {
                    return (object)val_9;
            }
            
            UnityEngine.GameObject val_2 = target.gameObject;
            val_8 = ???;
            val_9 = ???;
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
        public static UnityEngine.Component GetOrAddComponent(UnityEngine.GameObject target, System.Type type)
        {
            UnityEngine.Component val_1 = target.GetComponent(type:  type);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            return target.gameObject.AddComponent(componentType:  type);
        }
        public static UnityEngine.GameObject BetterSetActive(UnityEngine.GameObject target, bool value)
        {
            if(target == 0)
            {
                    return (UnityEngine.GameObject)target;
            }
            
            if(target.activeSelf ^ value == false)
            {
                    return (UnityEngine.GameObject)target;
            }
            
            target.SetActive(value:  value);
            return (UnityEngine.GameObject)target;
        }
    
    }

}
