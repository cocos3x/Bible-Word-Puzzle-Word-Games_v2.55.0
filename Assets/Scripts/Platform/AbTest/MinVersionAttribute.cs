using UnityEngine;

namespace Platform.AbTest
{
    internal class MinVersionAttribute : Attribute
    {
        // Fields
        public string Version;
        
        // Methods
        public MinVersionAttribute(string version)
        {
            this.Version = version;
        }
    
    }

}
