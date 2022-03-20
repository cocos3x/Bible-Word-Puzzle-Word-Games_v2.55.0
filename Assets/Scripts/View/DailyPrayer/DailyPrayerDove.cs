using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerDove : RecyclableItem
    {
        // Fields
        private const float TimeFly_1 = 0.2;
        private const float TimeFly_2 = 2;
        private const float TimeAlpha = 0.35;
        private const float PathScale = 0.2;
        private readonly UnityEngine.Quaternion InitRotation;
        private readonly UnityEngine.Color ColorAlphaZero;
        private readonly UnityEngine.Color ColorAlphaOne;
        public UnityEngine.Animator AnimatorDove;
        public UnityEngine.AnimationCurve CurveDove;
        public UnityEngine.UI.Image ImageDove;
        private bool _isFlying;
        private bool _isLeftDirection;
        private UnityEngine.Vector3[] _paths;
        private int _pathPointIndex;
        private View.CommonItem.LetterBox _letterBox;
        
        // Methods
        public static View.DailyPrayer.DailyPrayerDove Create(UnityEngine.Transform parent, View.DailyPrayer.DailyPrayerDove dovePrefab)
        {
            View.DailyPrayer.DailyPrayerDove val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.DailyPrayer.DailyPrayerDove>(prefab:  dovePrefab, bufferSize:  10);
            val_1.name = dovePrefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public void PlayFlyAni(View.CommonItem.LetterBox letterBox, System.Action callback)
        {
            object val_1 = new System.Object();
            typeof(DailyPrayerDove.<>c__DisplayClass16_0).__il2cppRuntimeField_10 = this;
            typeof(DailyPrayerDove.<>c__DisplayClass16_0).__il2cppRuntimeField_18 = callback;
            this.transform.SetAsLastSibling();
            this._isFlying = true;
            this._letterBox = letterBox;
            letterBox.<isDoveFlyLock>k__BackingField = true;
            UnityEngine.Vector3 val_4 = this.transform.forward;
            UnityEngine.Vector3 val_5 = letterBox.SlotDove.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this._isLeftDirection = (val_6.y < 0) ? 1 : 0;
            this.AnimatorDove.Play(stateName:  "DoveTurnAround");
            this._pathPointIndex = 0;
            UnityEngine.Vector3 val_9 = this.transform.position;
            UnityEngine.Vector3 val_10 = letterBox.SlotDove.position;
            UnityEngine.Vector3 val_11 = this.CalculatePaths(endPos:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = letterBox.SlotDove.position;
            this._paths = Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, controlPoint:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, endPoint:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.z, z = ???}, segmentNum:  15);
            if(val_13.Length == 0)
            {
                    return;
            }
            
            int val_14 = DG.Tweening.DOTween.Kill(targetOrId:  "DoveRotate", complete:  false);
            int val_15 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_17 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  this.LookAtAngle(targetPos:  new UnityEngine.Vector3() {x = this._paths[0], y = this._paths[0], z = this._paths[0]}));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_17, t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  0.2f, mode:  3), id:  "DoveRotate"));
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_17, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DailyPrayerDove.<>c__DisplayClass16_0::<PlayFlyAni>b__0()));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_17, interval:  2f);
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_17, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DailyPrayerDove.<>c__DisplayClass16_0::<PlayFlyAni>b__1()));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_17, id:  this);
        }
        public void PlayDoveHideToShowAni(UnityEngine.Transform slotDove)
        {
            typeof(DailyPrayerDove.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = this;
            typeof(DailyPrayerDove.<>c__DisplayClass17_0).__il2cppRuntimeField_18 = slotDove;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this.ImageDove.color = new UnityEngine.Color() {r = this.ColorAlphaZero};
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ImageDove, endValue:  0f, duration:  0.35f));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void DailyPrayerDove.<>c__DisplayClass17_0::<PlayDoveHideToShowAni>b__0()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ImageDove, endValue:  1f, duration:  0.35f));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_3, id:  this);
        }
        public void PlayDoveShowAni(UnityEngine.Transform slotDove)
        {
            this.transform.rotation = new UnityEngine.Quaternion() {x = this.InitRotation};
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this.ShowDove(slotDove:  slotDove);
            this.ImageDove.color = new UnityEngine.Color() {r = this.ColorAlphaOne};
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ImageDove, endValue:  1f, duration:  0.35f), id:  this);
        }
        public void ShowDove(UnityEngine.Transform slotDove)
        {
            this.transform.SetAsFirstSibling();
            this._isFlying = false;
            UnityEngine.Vector3 val_3 = slotDove.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public void ClearDove()
        {
            if(this._isFlying != false)
            {
                    return;
            }
            
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            View.DailyPrayer.DailyPrayerDove val_2 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.DailyPrayer.DailyPrayerDove>(obj:  this, isUi:  true);
        }
        private UnityEngine.Vector3 CalculatePaths(UnityEngine.Vector3 endPos)
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_4 = this.transform.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z});
            float val_7 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z})) * 0.2f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_9 = val_8.x.normalized;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_7);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = val_13.x.normalized;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_7);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.forward;
            var val_18 = (val_5.y < 0) ? 1 : 0;
            UnityEngine.Vector3 val_19 = this.RotateRound(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, center:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, axis:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.z, z = 15231112 + val_5.y < 0 ? 1 : 0}, angle:  null);
            return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        }
        private UnityEngine.Vector3 RotateRound(UnityEngine.Vector3 position, UnityEngine.Vector3 center, UnityEngine.Vector3 axis, float angle)
        {
            float val_1;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.AngleAxis(angle:  axis.z, axis:  new UnityEngine.Vector3() {x = axis.x, y = val_1, z = axis.y});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        private float LookAtAngle(UnityEngine.Vector3 targetPos)
        {
            float val_7;
            UnityEngine.Vector3 val_2 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = targetPos.x, y = targetPos.y, z = targetPos.z});
            val_2.x.Normalize();
            float val_7 = val_2.x;
            val_7 = val_7 * 57.29578f;
            val_7 = System.Math.Abs(val_7);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.right;
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) >= 0f)
            {
                    return (float)val_7;
            }
            
            val_7 = ((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) >= 0f) ? (-val_7) : 0f;
            return (float)val_7;
        }
        private void WaypointChange(UnityEngine.Vector3[] paths)
        {
            int val_8 = this._pathPointIndex;
            val_8 = val_8 + 1;
            this._pathPointIndex = val_8;
            if(val_8 >= paths.Length)
            {
                    return;
            }
            
            var val_9 = (long)val_8;
            val_9 = paths + (val_9 * 12);
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  "DoveRotate", complete:  false);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.LookAtAngle(targetPos:  new UnityEngine.Vector3() {x = ((long)(int)((this._pathPointIndex + 1)) * 12) + paths + 32, y = ((long)(int)((this._pathPointIndex + 1)) * 12) + paths + 32 + 4, z = ((long)(int)((this._pathPointIndex + 1)) * 12) + paths + 40}));
            float val_10 = (float)paths.Length;
            val_10 = 2f / val_10;
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  val_10, mode:  3), id:  "DoveRotate");
        }
        public DailyPrayerDove()
        {
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.InitRotation = val_2;
            mem[1152921512822564652] = val_2.y;
            mem[1152921512822564656] = val_2.z;
            mem[1152921512822564660] = val_2.w;
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  0f);
            UnityEngine.Color val_4;
            this.ColorAlphaZero = val_3.r;
            val_4 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  1f);
            this.ColorAlphaOne = val_4.r;
        }
    
    }

}
