using UnityEngine;

namespace Logic
{
    public class BibleController : Singleton<Logic.BibleController>
    {
        // Methods
        public string GetBibleSpriteName(string name)
        {
            return "BibleCover/Pic"("BibleCover/Pic") + name.Replace(oldValue:  " ", newValue:  "")(name.Replace(oldValue:  " ", newValue:  ""));
        }
        public BibleController()
        {
        
        }
    
    }

}
