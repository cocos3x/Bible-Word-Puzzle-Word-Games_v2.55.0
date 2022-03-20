using UnityEngine;

namespace Platform.AbTest
{
    internal class ABTestAttribute : Attribute
    {
        // Fields
        public string name;
        public bool allowNull;
        
        // Methods
        public ABTestAttribute(string name, bool allowNull = True)
        {
            this.name = name;
            this.allowNull = allowNull;
        }
    
    }

}
