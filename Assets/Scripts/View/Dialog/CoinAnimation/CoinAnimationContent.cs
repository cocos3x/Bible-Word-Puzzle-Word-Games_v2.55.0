using UnityEngine;

namespace View.Dialog.CoinAnimation
{
    public class CoinAnimationContent : RecyclableItem
    {
        // Fields
        public UnityEngine.UI.Image image;
        
        // Methods
        public static View.Dialog.CoinAnimation.CoinAnimationContent Create(UnityEngine.Transform parent, View.Dialog.CoinAnimation.CoinAnimationContent prefab)
        {
            View.Dialog.CoinAnimation.CoinAnimationContent val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.CoinAnimation.CoinAnimationContent>(prefab:  prefab, bufferSize:  10);
            val_1.name = prefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public void Play(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, float startScale, float endScale, float time, float delay, View.Dialog.CoinAnimation.CoinAnimationContent.CoinAnimationStartType startType = 0, float startTime = 0, float keepTime = 0, bool useBeizer = False, System.Action onComplete)
        {
            float val_50;
            float val_51;
            float val_52;
            val_50 = endPosition.z;
            val_51 = endPosition.y;
            val_52 = endPosition.x;
            typeof(CoinAnimationContent.<>c__DisplayClass3_0).__il2cppRuntimeField_10 = onComplete;
            typeof(CoinAnimationContent.<>c__DisplayClass3_0).__il2cppRuntimeField_18 = this;
            float val_50 = startTime;
            this.transform.position = new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z};
            float val_4 = ((startType & 1) != 0) ? 0f : (val_50 + 0f);
            UnityEngine.Transform val_5 = this.transform;
            if(val_4 > 0f)
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  startScale);
                float val_9 = (val_4 + val_4) / 3f;
                DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_9), delay:  delay), ease:  6);
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  startScale);
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  0.8f);
                DG.Tweening.Tweener val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  val_4 / 3f), delay:  val_9 + delay), ease:  5);
                val_51 = val_51;
                val_52 = val_52;
                val_50 = val_50;
            }
            else
            {
                    UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  startScale);
                DG.Tweening.Tweener val_26 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  val_4), delay:  delay), ease:  6);
            }
            
            if((startType & 2) != 0)
            {
                    UnityEngine.Vector3 val_28 = new UnityEngine.Vector3(x:  0f, y:  720f, z:  0f);
                DG.Tweening.Tweener val_30 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  val_50, mode:  1), delay:  delay);
            }
            
            val_50 = (val_50 + keepTime) + delay;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  endScale);
            DG.Tweening.Tweener val_37 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, duration:  time), ease:  5), delay:  val_50);
            if(useBeizer != false)
            {
                    float val_38 = startPosition.x + val_52;
                val_38 = val_38 * 0.5f;
                UnityEngine.Vector3 val_39 = new UnityEngine.Vector3(x:  val_38, y:  startPosition.y);
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_43 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform, path:  Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, controlPoint:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, endPoint:  new UnityEngine.Vector3() {x = val_52, y = val_50}, segmentNum:  20), duration:  time, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  5);
            }
            
            DG.Tweening.Tweener val_49 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_52, y = val_51, z = val_50}, duration:  time, snapping:  false), delay:  val_50), ease:  5), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void CoinAnimationContent.<>c__DisplayClass3_0::<Play>b__0()));
        }
        public void Play(UnityEngine.Transform startTransform, UnityEngine.Transform endTransform, float time, float delay, View.Dialog.CoinAnimation.CoinAnimationContent.CoinAnimationStartType startType = 0, float startTime = 0, float keepTime = 0, bool useBeizer = False, System.Action onComplete)
        {
            UnityEngine.Vector3 val_1 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  startTransform);
            UnityEngine.Vector3 val_2 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  endTransform);
            if(null != null)
            {
                goto label_2;
            }
            
            UnityEngine.Rect val_3 = startTransform.rect;
            UnityEngine.Vector2 val_4 = val_3.m_XMin.size;
            if(null != null)
            {
                goto label_4;
            }
            
            float val_11 = val_4.x;
            UnityEngine.Rect val_5 = endTransform.rect;
            UnityEngine.Vector2 val_6 = val_5.m_XMin.size;
            val_11 = (UnityEngine.Mathf.Min(a:  val_11, b:  val_4.y)) / 100f;
            this.Play(startPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, endPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, startScale:  val_11, endScale:  (UnityEngine.Mathf.Min(a:  val_6.x, b:  val_6.y)) / 100f, time:  time, delay:  delay, startType:  startType, startTime:  startTime, keepTime:  keepTime, useBeizer:  useBeizer, onComplete:  onComplete);
            return;
            label_2:
            label_4:
        }
        public void Play(UnityEngine.Vector3 startPosition, float startScale, UnityEngine.Transform endTransform, float time, float delay, View.Dialog.CoinAnimation.CoinAnimationContent.CoinAnimationStartType startType = 0, float startTime = 0, float keepTime = 0, bool useBeizer = False, System.Action onComplete)
        {
            UnityEngine.Vector3 val_1 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  endTransform);
            if(null == null)
            {
                    UnityEngine.Rect val_2 = endTransform.rect;
                UnityEngine.Vector2 val_3 = val_2.m_XMin.size;
                this.Play(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, startScale:  startScale, endScale:  (UnityEngine.Mathf.Min(a:  val_3.x, b:  val_3.y)) / 100f, time:  time, delay:  delay, startType:  startType, startTime:  startTime, keepTime:  keepTime, useBeizer:  useBeizer, onComplete:  onComplete);
                return;
            }
        
        }
        public void Play(UnityEngine.Vector3 startPosition, float startScale, float endscale, UnityEngine.Transform endTransform, float time, float delay, View.Dialog.CoinAnimation.CoinAnimationContent.CoinAnimationStartType startType = 0, float startTime = 0, float keepTime = 0, bool useBeizer = False, System.Action onComplete)
        {
            UnityEngine.Vector3 val_1 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  endTransform);
            this.Play(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, startScale:  startScale, endScale:  endscale, time:  time, delay:  delay, startType:  startType, startTime:  startTime, keepTime:  keepTime, useBeizer:  useBeizer, onComplete:  onComplete);
        }
        public override void OnRecycle()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public CoinAnimationContent()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
