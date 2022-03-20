using UnityEngine;

namespace Common
{
    public class EzMonoPool<T> : EzPool<T>
    {
        // Fields
        private T prefab;
        
        // Methods
        public EzMonoPool<T>(int bufferSize, T prefab)
        {
            mem[1152921513076811880] = prefab;
        }
        public override T New()
        {
            UnityEngine.Object val_4;
            UnityEngine.Object val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(X22 == 0)
            {
                    val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
                mem[1152921513076927984] = val_4;
            }
            
            val_5 = 0;
            label_9:
            if(val_4 > 0)
            {
                    val_5 = val_4;
                if(val_5 == 0)
            {
                    if(val_4 != 0)
            {
                goto label_9;
            }
            
            }
            
            }
            
            if(val_5 != 0)
            {
                goto label_13;
            }
            
            val_5 = val_5;
            val_6 = null;
            if(mem[282584257676965] == 0)
            {
                goto label_17;
            }
            
            var val_3 = mem[282584257676847];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_19:
            if(((mem[282584257676847] + 8) + -8) == val_6)
            {
                goto label_18;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < mem[282584257676965])
            {
                goto label_19;
            }
            
            label_17:
            val_7 = val_5;
            val_8 = 0;
            goto label_25;
            label_13:
            val_6 = null;
            if(mem[282584257676965] == 0)
            {
                goto label_22;
            }
            
            var val_5 = mem[282584257676847];
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_24:
            if(((mem[282584257676847] + 8) + -8) == val_6)
            {
                goto label_23;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < mem[282584257676965])
            {
                goto label_24;
            }
            
            label_22:
            val_8 = 1;
            val_7 = val_5;
            goto label_25;
            label_18:
            val_10 = 1179403647 + (((mem[282584257676847] + 8)) << 4);
            goto label_26;
            label_23:
            var val_7 = val_5;
            val_7 = val_7 + 1;
            val_10 = 1179403647 + val_7;
            label_26:
            val_9 = val_10 + 304;
            label_25:
            val_5.OnReset();
            return (object)val_5;
        }
        public override void Recycle(T obj)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            obj.OnRecycle();
        }
    
    }

}
