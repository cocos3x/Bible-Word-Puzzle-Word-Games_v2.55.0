using UnityEngine;

namespace Common
{
    public class EzPool<T>
    {
        // Fields
        protected System.Collections.Generic.Stack<T> objStack;
        
        // Methods
        public EzPool<T>(int bufferSize)
        {
            mem[1152921513077944096] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public virtual T New()
        {
            if(this > 0)
            {
                    __RuntimeMethodHiddenParam = ???;
            }
        
        }
        public virtual void Recycle(T obj)
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
