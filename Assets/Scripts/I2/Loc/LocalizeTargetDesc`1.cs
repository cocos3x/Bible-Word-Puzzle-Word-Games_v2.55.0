using UnityEngine;

namespace I2.Loc
{
    public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor
    {
        // Methods
        public override I2.Loc.ILocalizeTarget CreateTarget(I2.Loc.Localize cmp)
        {
            goto __RuntimeMethodHiddenParam + 24 + 192;
        }
        public override System.Type GetTargetType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16});
        }
        protected LocalizeTargetDesc<T>()
        {
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
