using UnityEngine;

namespace Utils.Extensions
{
    public class FixTouchInput : BaseInput
    {
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.EventSystems.BaseInputModule val_1 = this.GetComponent<UnityEngine.EventSystems.BaseInputModule>();
            val_1.m_InputOverride = this;
        }
        public override UnityEngine.Touch GetTouch(int index)
        {
            UnityEngine.Touch val_0;
            UnityEngine.Touch val_1 = this.GetTouch(index:  index);
            UnityEngine.Vector2 val_2 = position;
            if((System.Single.IsNaN(f:  val_2.x)) != true)
            {
                    UnityEngine.Vector2 val_4 = position;
                if((System.Single.IsNaN(f:  val_4.y)) == false)
            {
                    return val_0;
            }
            
            }
            
            type = 1;
            return val_0;
        }
        public FixTouchInput()
        {
        
        }
    
    }

}
