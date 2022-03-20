using UnityEngine;

namespace View.CommonItem
{
    public class Chrysalis : RecyclableItem
    {
        // Fields
        private const float TimeFly = 0.6;
        private readonly UnityEngine.Vector3 LastScale;
        public UnityEngine.Animator AnimatorChrysalis;
        public View.CommonItem.ChrysalisIcon Icon;
        
        // Methods
        public static View.CommonItem.Chrysalis Create(UnityEngine.Transform parent, View.CommonItem.Chrysalis prefab)
        {
            View.CommonItem.Chrysalis val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.Chrysalis>(prefab:  prefab, bufferSize:  10);
            val_1.name = prefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public void SetChrysalisInfo()
        {
            this.Icon.SetChrysalisIcon(level:  Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisLevel());
            this.AnimatorChrysalis.Play(stateName:  "ChrysalisAppear");
        }
        public void CollectChrysalis(UnityEngine.Vector3 beginPos, UnityEngine.Vector3 endPos)
        {
            this.AnimatorChrysalis.enabled = false;
            this.Icon.SetChrysalisIcon(level:  Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisLevel());
            this.AnimatorChrysalis.Play(stateName:  "ChrysalisAlive");
            this.transform.position = new UnityEngine.Vector3() {x = beginPos.x, y = beginPos.y, z = beginPos.z};
            int val_4 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, duration:  0.6f, snapping:  false), ease:  1), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.Chrysalis::<CollectChrysalis>b__6_0())), id:  this);
            DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.LastScale, y = endPos.y, z = endPos.z}, duration:  0.6f), id:  this);
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.AnimatorChrysalis.enabled = true;
        }
        public Chrysalis()
        {
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  0.53f, y:  0.53f, z:  0.53f);
            this.LastScale = val_1.x;
            mem[1152921512851230032] = val_1.z;
        }
        private void <CollectChrysalis>b__6_0()
        {
            Message.Messager.Dispatch(cmd:  108);
            View.CommonItem.Chrysalis val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.CommonItem.Chrysalis>(obj:  this, isUi:  true);
        }
    
    }

}
