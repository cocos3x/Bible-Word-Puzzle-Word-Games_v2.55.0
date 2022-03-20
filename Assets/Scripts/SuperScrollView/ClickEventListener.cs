using UnityEngine;

namespace SuperScrollView
{
    public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
    {
        // Fields
        private System.Action<UnityEngine.GameObject> mClickedHandler;
        private System.Action<UnityEngine.GameObject> mDoubleClickedHandler;
        private System.Action<UnityEngine.GameObject> mOnPointerDownHandler;
        private System.Action<UnityEngine.GameObject> mOnPointerUpHandler;
        private bool mIsPressed;
        
        // Properties
        public bool IsPressd { get; }
        
        // Methods
        public static SuperScrollView.ClickEventListener Get(UnityEngine.GameObject obj)
        {
            SuperScrollView.ClickEventListener val_1 = obj.GetComponent<SuperScrollView.ClickEventListener>();
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            return obj.AddComponent<SuperScrollView.ClickEventListener>();
        }
        public bool get_IsPressd()
        {
            return (bool)this.mIsPressed;
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<clickCount>k__BackingField) != 2)
            {
                goto label_2;
            }
            
            if(this.mDoubleClickedHandler == null)
            {
                    return;
            }
            
            label_4:
            this.mDoubleClickedHandler.Invoke(obj:  this.gameObject);
            return;
            label_2:
            if(this.mClickedHandler != null)
            {
                goto label_4;
            }
        
        }
        public void SetClickEventHandler(System.Action<UnityEngine.GameObject> handler)
        {
            this.mClickedHandler = handler;
        }
        public void SetDoubleClickEventHandler(System.Action<UnityEngine.GameObject> handler)
        {
            this.mDoubleClickedHandler = handler;
        }
        public void SetPointerDownHandler(System.Action<UnityEngine.GameObject> handler)
        {
            this.mOnPointerDownHandler = handler;
        }
        public void SetPointerUpHandler(System.Action<UnityEngine.GameObject> handler)
        {
            this.mOnPointerUpHandler = handler;
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mIsPressed = true;
            if(this.mOnPointerDownHandler == null)
            {
                    return;
            }
            
            this.mOnPointerDownHandler.Invoke(obj:  this.gameObject);
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mIsPressed = false;
            if(this.mOnPointerUpHandler == null)
            {
                    return;
            }
            
            this.mOnPointerUpHandler.Invoke(obj:  this.gameObject);
        }
        public ClickEventListener()
        {
        
        }
    
    }

}
