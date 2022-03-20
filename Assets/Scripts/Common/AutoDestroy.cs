using UnityEngine;

namespace Common
{
    public class AutoDestroy : RecyclableItem
    {
        // Fields
        public float time;
        private UnityEngine.Events.UnityAction <onDestroy>k__BackingField;
        
        // Properties
        public UnityEngine.Events.UnityAction onDestroy { get; set; }
        
        // Methods
        public static Common.AutoDestroy Create(UnityEngine.Transform parent, Common.AutoDestroy prefab, UnityEngine.Events.UnityAction onDestroy)
        {
            Common.AutoDestroy val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<Common.AutoDestroy>(prefab:  prefab, bufferSize:  5);
            val_1.name = prefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.<onDestroy>k__BackingField = onDestroy;
            return val_1;
        }
        public UnityEngine.Events.UnityAction get_onDestroy()
        {
            return (UnityEngine.Events.UnityAction)this.<onDestroy>k__BackingField;
        }
        public void set_onDestroy(UnityEngine.Events.UnityAction value)
        {
            this.<onDestroy>k__BackingField = value;
        }
        private System.Collections.IEnumerator DestroyDelay(float delay)
        {
            typeof(AutoDestroy.<DestroyDelay>d__6).__il2cppRuntimeField_10 = 0;
            typeof(AutoDestroy.<DestroyDelay>d__6).__il2cppRuntimeField_28 = this;
            typeof(AutoDestroy.<DestroyDelay>d__6).__il2cppRuntimeField_20 = delay;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DestroyDelay(delay:  this.time));
        }
        public AutoDestroy()
        {
        
        }
    
    }

}
