using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G>
    {
        // Methods
        public override bool CanLocalize(I2.Loc.Localize cmp)
        {
            return UnityEngine.Object.op_Inequality(x:  cmp, y:  0);
        }
        public override I2.Loc.ILocalizeTarget CreateTarget(I2.Loc.Localize cmp)
        {
            var val_2 = 0;
            if(cmp == 0)
            {
                    return (I2.Loc.ILocalizeTarget)val_2;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem2[0] = cmp;
            return (I2.Loc.ILocalizeTarget)val_2;
        }
        public LocalizeTargetDesc_Type<T, G>()
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
