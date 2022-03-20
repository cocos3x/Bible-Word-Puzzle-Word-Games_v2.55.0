using UnityEngine;

namespace Data.GameDictionary
{
    public class JsonResult<T>
    {
        // Fields
        public Data.GameDictionary.Status status;
        public T data;
        
        // Methods
        public JsonResult<T>()
        {
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
