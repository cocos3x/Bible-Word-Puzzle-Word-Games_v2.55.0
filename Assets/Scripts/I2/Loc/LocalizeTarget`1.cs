using UnityEngine;

namespace I2.Loc
{
    public abstract class LocalizeTarget<T> : ILocalizeTarget
    {
        // Fields
        public T mTarget;
        
        // Methods
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            var val_7;
            if((21078016 != 0) && (X0 != 0))
            {
                    UnityEngine.GameObject val_3 = X0.gameObject;
                if(val_3 != cmp.gameObject)
            {
                    mem[1152921513218915768] = 0;
            }
            
            }
            
            if(val_3 == 0)
            {
                    val_7 = cmp;
                mem[1152921513218915768] = cmp;
                return UnityEngine.Object.op_Inequality(x:  cmp, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  cmp, y:  0);
        }
        protected LocalizeTarget<T>()
        {
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
