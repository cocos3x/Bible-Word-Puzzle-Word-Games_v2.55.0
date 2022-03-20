using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignDayStars : RecyclableItem
    {
        // Fields
        public UnityEngine.UI.Image ImageUnlit;
        
        // Methods
        public static View.Dialog.DailySign.DailySignDayStars Create(UnityEngine.Transform parent, View.Dialog.DailySign.DailySignDayStars prefab)
        {
            View.Dialog.DailySign.DailySignDayStars val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.DailySign.DailySignDayStars>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            return val_1;
        }
        public void SetStarState(bool isLight)
        {
            this.ImageUnlit.gameObject.SetActive(value:  (~isLight) & 1);
        }
        public override void OnRecycle()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.gameObject.SetActive(value:  true);
        }
        public DailySignDayStars()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
