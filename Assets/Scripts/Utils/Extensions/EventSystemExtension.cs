using UnityEngine;

namespace Utils.Extensions
{
    public static class EventSystemExtension
    {
        // Methods
        public static bool IsPointerOverUIObject(UnityEngine.EventSystems.EventSystem self)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_3.y);
            typeof(UnityEngine.EventSystems.PointerEventData).__il2cppRuntimeField_E8 = val_4.x;
            self.RaycastAll(eventData:  new UnityEngine.EventSystems.PointerEventData(eventSystem:  self), raycastResults:  new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>());
            return (bool)((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0) ? 1 : 0;
        }
        public static bool IsPointerOverUIObject(UnityEngine.EventSystems.EventSystem self, UnityEngine.GameObject uiObject)
        {
            UnityEngine.EventSystems.EventSystem val_7;
            var val_8;
            var val_9;
            val_7 = self;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_3.y);
            typeof(UnityEngine.EventSystems.PointerEventData).__il2cppRuntimeField_E8 = val_4.x;
            val_7.RaycastAll(eventData:  new UnityEngine.EventSystems.PointerEventData(eventSystem:  val_7), raycastResults:  new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>());
            var val_7 = 0;
            val_8 = 32;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((List<T>.__il2cppRuntimeField_20) != uiObject)
            {
                    val_7 = val_7 + 1;
                val_8 = val_8 + 72;
                val_9 = 0;
                return (bool)val_9;
            }
            
            val_9 = 1;
            return (bool)val_9;
        }
    
    }

}
