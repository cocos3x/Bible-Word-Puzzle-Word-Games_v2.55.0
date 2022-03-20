using UnityEngine;

namespace View.CommonEffect
{
    public class HintEffect : RecyclableItem
    {
        // Methods
        public static View.CommonEffect.HintEffect Create(UnityEngine.Transform parent, View.CommonEffect.HintEffect prefab)
        {
            View.CommonEffect.HintEffect val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonEffect.HintEffect>(prefab:  prefab, bufferSize:  10);
            val_1.name = prefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public void Play(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, float time, float delay, System.Action onComplete)
        {
            object val_1 = new System.Object();
            typeof(HintEffect.<>c__DisplayClass1_0).__il2cppRuntimeField_10 = onComplete;
            typeof(HintEffect.<>c__DisplayClass1_0).__il2cppRuntimeField_18 = this;
            this.transform.position = new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z};
            int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  delay);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = endPosition.x, y = endPosition.y, z = endPosition.z}, duration:  time, snapping:  false));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void HintEffect.<>c__DisplayClass1_0::<Play>b__0()));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  0.6f);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void HintEffect.<>c__DisplayClass1_0::<Play>b__1())), id:  this);
        }
        public HintEffect()
        {
        
        }
    
    }

}
