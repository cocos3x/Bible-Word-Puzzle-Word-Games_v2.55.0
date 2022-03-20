using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignAnimatorStars : MonoBehaviour
    {
        // Fields
        private const float TimeFly = 0.5;
        private const float BigScale = 3.45;
        public UnityEngine.Transform SlotStar;
        public View.Dialog.DailySign.DailySignDayStars DailySignDayStarsPrefab;
        private System.Collections.Generic.List<View.Dialog.DailySign.DailySignDayStars> _stars;
        
        // Methods
        private void PlayCollectStarsAnimator(UnityEngine.Vector3 begin, bool isLast)
        {
            typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = isLast;
            typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_20 = this;
            View.Dialog.DailySign.DailySignDayStars val_4 = View.Dialog.DailySign.DailySignDayStars.Create(parent:  this.transform, prefab:  this.DailySignDayStarsPrefab);
            typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18 = val_4;
            val_4.SetStarState(isLight:  true);
            typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18.transform.position = new UnityEngine.Vector3() {x = begin.x, y = begin.y, z = begin.z};
            int val_6 = DG.Tweening.DOTween.Kill(targetOrId:  typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18, complete:  false);
            UnityEngine.Vector3 val_7 = this.SlotStar.position;
            val_7.x = val_7.x - begin.x;
            UnityEngine.Vector3 val_9 = this.SlotStar.position;
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_7.x * 0.5f, y:  val_9.y);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  3.45f);
            DG.Tweening.Tweener val_15 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18.transform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.5f), id:  typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18);
            UnityEngine.Vector3 val_17 = this.SlotStar.position;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_23 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18.transform, path:  Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = begin.x, y = begin.y, z = begin.z}, controlPoint:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, endPoint:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.z}, segmentNum:  20), duration:  0.5f, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  5), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void DailySignAnimatorStars.<>c__DisplayClass5_0::<PlayCollectStarsAnimator>b__0())), id:  typeof(DailySignAnimatorStars.<>c__DisplayClass5_0).__il2cppRuntimeField_18);
        }
        private void ClearStars()
        {
            if(this._stars < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_2 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                View.Dialog.DailySign.DailySignDayStars val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.DailySign.DailySignDayStars>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
                val_2 = val_2 + 1;
            }
            while(val_2 < this._stars);
        
        }
        private void OnEnable()
        {
            this.ClearStars();
            Message.Messager.Add<UnityEngine.Vector3, System.Boolean>(cmd:  94, action:  new System.Action<UnityEngine.Vector3, System.Boolean>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignAnimatorStars::PlayCollectStarsAnimator(UnityEngine.Vector3 begin, bool isLast)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<UnityEngine.Vector3, System.Boolean>(cmd:  94, action:  new System.Action<UnityEngine.Vector3, System.Boolean>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignAnimatorStars::PlayCollectStarsAnimator(UnityEngine.Vector3 begin, bool isLast)));
        }
        public DailySignAnimatorStars()
        {
            this._stars = new System.Collections.Generic.List<View.Dialog.DailySign.DailySignDayStars>();
        }
    
    }

}
