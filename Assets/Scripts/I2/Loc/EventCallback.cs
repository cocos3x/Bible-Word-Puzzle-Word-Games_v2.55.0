using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class EventCallback
    {
        // Fields
        public UnityEngine.MonoBehaviour Target;
        public string MethodName;
        
        // Methods
        public void Execute(UnityEngine.Object Sender)
        {
            if(this.HasCallback() == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.Target.gameObject.SendMessage(methodName:  this.MethodName, value:  Sender, options:  1);
        }
        public bool HasCallback()
        {
            var val_4;
            if(this.Target != 0)
            {
                    val_4 = (System.String.IsNullOrEmpty(value:  this.MethodName)) ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        public EventCallback()
        {
            this.MethodName = System.String.alignConst;
        }
    
    }

}
