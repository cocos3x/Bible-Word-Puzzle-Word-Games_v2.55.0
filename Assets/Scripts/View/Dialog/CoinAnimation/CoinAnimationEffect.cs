using UnityEngine;

namespace View.Dialog.CoinAnimation
{
    public class CoinAnimationEffect : RecyclableItem
    {
        // Fields
        private const float TimeJump = 1;
        private const float TimeFly = 0.6;
        
        // Methods
        public static View.Dialog.CoinAnimation.CoinAnimationEffect Create(UnityEngine.Transform parent, View.Dialog.CoinAnimation.CoinAnimationEffect effectPrefab)
        {
            View.Dialog.CoinAnimation.CoinAnimationEffect val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.CoinAnimation.CoinAnimationEffect>(prefab:  effectPrefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = effectPrefab.name;
            return val_1;
        }
        public void GainCoin(int amount, string from, UnityEngine.Vector2 centerPosition, UnityEngine.Vector3 endPos, float time = 1, float delay = 0, UnityEngine.Events.UnityAction onComplete, int count = -1)
        {
            typeof(CoinAnimationEffect.<>c__DisplayClass3_0).__il2cppRuntimeField_10 = amount;
            typeof(CoinAnimationEffect.<>c__DisplayClass3_0).__il2cppRuntimeField_18 = from;
            typeof(CoinAnimationEffect.<>c__DisplayClass3_0).__il2cppRuntimeField_20 = onComplete;
            typeof(CoinAnimationEffect.<>c__DisplayClass3_0).__il2cppRuntimeField_28 = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            float val_16 = 1f;
            val_16 = delay + val_16;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  val_16);
            float val_5 = centerPosition.x + endPos.x;
            val_5 = val_5 * 0.5f;
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_5, y:  centerPosition.y);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_coins", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = centerPosition.x, y = centerPosition.y});
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform, path:  Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, controlPoint:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, endPoint:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.z}, segmentNum:  20), duration:  time, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  5));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void CoinAnimationEffect.<>c__DisplayClass3_0::<GainCoin>b__0()));
        }
        public CoinAnimationEffect()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
