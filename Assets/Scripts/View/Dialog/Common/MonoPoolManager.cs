using UnityEngine;

namespace View.Dialog.Common
{
    public class MonoPoolManager : MonoSingleton<View.Dialog.Common.MonoPoolManager>
    {
        // Fields
        private UnityEngine.Transform uiParent;
        private System.Collections.Generic.Dictionary<string, Common.EzMonoPool<View.Dialog.Common.RecyclableItem>> pools;
        
        // Methods
        protected override void Awake()
        {
            if((public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184) == 0)
            {
                    this.Awake();
                this.uiParent = this.transform.Find(n:  "UIRecycle");
                return;
            }
            
            if((public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184) == this)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public T Create<T>(T prefab, int bufferSize = 10)
        {
            var val_8;
            int val_9;
            View.Dialog.Common.RecyclableItem val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.String, Common.EzMonoPool<View.Dialog.Common.RecyclableItem>> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = bufferSize;
            val_10 = prefab;
            val_11 = this;
            val_12 = this.pools;
            if(val_12 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, Common.EzMonoPool<View.Dialog.Common.RecyclableItem>> val_1 = null;
                val_12 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.String, Common.EzMonoPool<View.Dialog.Common.RecyclableItem>>();
                this.pools = val_12;
            }
            
            if((ContainsKey(key:  val_10.name)) == false)
            {
                goto label_4;
            }
            
            Common.EzMonoPool<View.Dialog.Common.RecyclableItem> val_5 = this.pools.Item[val_10.name];
            val_13 = X0;
            val_10 = mem[__RuntimeMethodHiddenParam + 48];
            val_10 = __RuntimeMethodHiddenParam + 48;
            if(val_13 == false)
            {
                goto label_9;
            }
            
            val_14 = X0;
            if(X0 == true)
            {
                    return (Common.AutoDestroy)val_15;
            }
            
            label_4:
            val_9 = mem[X0 + 48];
            val_9 = X0 + 48;
            if(X0 == false)
            {
                goto label_14;
            }
            
            val_15 = X0;
            if(X0 == true)
            {
                goto label_15;
            }
            
            label_14:
            val_15 = 0;
            label_15:
            val_16 = mem[X0 + 32];
            val_16 = X0 + 32;
            val_16.Add(key:  val_10.name, value:  new Common.EzMonoPool<View.Dialog.Common.RecyclableItem>(bufferSize:  val_9, prefab:  val_10));
            return (Common.AutoDestroy)val_15;
            label_9:
            val_15 = 0;
            return (Common.AutoDestroy)val_15;
        }
        public T Recycle<T>(T obj, bool isUi = True)
        {
            System.Char[] val_8;
            if(obj == 0)
            {
                    return (Common.AutoDestroy)obj;
            }
            
            char[] val_3 = new char[1];
            val_8 = val_3;
            val_8[0] = '_';
            if(this.pools != null)
            {
                    string val_8 = obj.name.Split(separator:  val_3)[0];
                val_8 = val_8;
                if((this.pools.ContainsKey(key:  val_8)) != false)
            {
                    obj.name = val_8;
                Common.EzMonoPool<View.Dialog.Common.RecyclableItem> val_6 = this.pools.Item[val_8];
                if(isUi == false)
            {
                    return (Common.AutoDestroy)obj;
            }
            
                obj.transform.SetParent(parent:  this.uiParent, worldPositionStays:  false);
                return (Common.AutoDestroy)obj;
            }
            
            }
            
            obj.OnRecycle();
            return (Common.AutoDestroy)obj;
        }
        protected override void OnDestroy()
        {
        
        }
        public MonoPoolManager()
        {
        
        }
    
    }

}
