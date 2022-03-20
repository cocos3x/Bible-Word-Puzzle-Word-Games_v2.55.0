using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class ButterFlyFly : RecyclableItem
    {
        // Fields
        private const float TimeDelay = 5.3;
        private const float TimeRotate = 0.38;
        private const float ButterFlyBeginScale = 1.5;
        private const float ButterFlyScale = 0.56;
        private readonly UnityEngine.Vector3[] StopAngles;
        public View.Dialog.ButterFly.ButterFlyAnimationController AnimationController;
        public ButterFlyIcon Icon;
        public UnityEngine.AnimationCurve FlyCurve;
        private UnityEngine.Transform _target;
        private UnityEngine.Transform _nextTarget;
        private View.Dialog.ButterFly.WaypointSlots _waypointSlots;
        private View.Dialog.ButterFly.Waypoint _waypoint;
        private bool _isFlying;
        private DG.Tweening.Sequence _sequence;
        private UnityEngine.Vector3[] _paths;
        private float lastAngle;
        private int _pathPointIndex;
        private int _butterFlyStyle;
        private int _butterFlyIndex;
        private bool _isJustCollect;
        private bool _isClickButterFly;
        private float _timeFly;
        
        // Methods
        public static View.Dialog.ButterFly.ButterFlyFly Create(UnityEngine.Transform parent, View.Dialog.ButterFly.ButterFlyFly prefab)
        {
            View.Dialog.ButterFly.ButterFlyFly val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.ButterFly.ButterFlyFly>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = val_1.name;
            return val_1;
        }
        public void OnClickButterFlyButton()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendActivBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = ActivBtnClick.BtnNameEnum.BtnNameButterflyBtn}, source:  new SourceEnum() {<Value>k__BackingField = ActivBtnClick.SourceEnum.SourceButterflyScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "main_click", label:  "butterfly", value:  0);
            if(this._isFlying != false)
            {
                    this._isClickButterFly = true;
                return;
            }
            
            this.AnimationController.PlayBeginFlyAni(butterFlyStyle:  this._butterFlyStyle);
            this.ButterFlyFlyToTarget();
        }
        public void SetButterflyInfo(View.Dialog.ButterFly.WaypointSlots waypointSlots, int index, bool isJustCollect = False)
        {
            float val_7;
            this.gameObject.SetActive(value:  true);
            this._waypointSlots = waypointSlots;
            this._butterFlyIndex = index;
            this._isJustCollect = isJustCollect;
            if(isJustCollect != false)
            {
                    val_7 = 1.5f;
            }
            else
            {
                    val_7 = 0.56f;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_7);
            this.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.Icon.SetButterFlyIcon(index:  index, isCollect:  true);
            this.ReadyFly(isJustCollect:  isJustCollect);
        }
        public void ClearButterfly()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  System.String.Format(format:  "rotate{0}", arg0:  this._butterFlyIndex), complete:  false);
            this.gameObject.SetActive(value:  false);
        }
        private void ReadyFly(bool isJustCollect)
        {
            if(isJustCollect != true)
            {
                    View.Dialog.ButterFly.Waypoint val_1 = this._waypointSlots.GetNextWaypoint();
                this._waypoint = val_1;
                this._target = val_1.transform;
                UnityEngine.Vector3 val_4 = this._target.position;
                this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            }
            
            this.ButterFlyFlyToTarget();
        }
        private void ButterFlyFlyToTarget()
        {
            this.SetWaypointLockState(isLock:  false);
            View.Dialog.ButterFly.Waypoint val_1 = this._waypointSlots.GetNextWaypoint();
            this._waypoint = val_1;
            if(val_1 == null)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.transform.position;
            this._paths = this._waypointSlots.GetBezierPath(nowPos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, point:  this._waypoint, callback:  new System.Action<View.Dialog.ButterFly.Waypoint>(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyFly::<ButterFlyFlyToTarget>b__27_0(View.Dialog.ButterFly.Waypoint point)));
            this.SetWaypointLockState(isLock:  true);
            this._pathPointIndex = 0;
            this._timeFly = this._waypointSlots._timeFly;
            int val_6 = UnityEngine.Random.Range(min:  0, max:  3);
            this._butterFlyStyle = val_6;
            int val_34 = this.StopAngles.Length;
            val_34 = val_6 - ((val_6 / val_34) * val_34);
            this._butterFlyStyle = val_34;
            int val_8 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            int val_10 = DG.Tweening.DOTween.Kill(targetOrId:  System.String.Format(format:  "rotate{0}", arg0:  this._butterFlyIndex), complete:  false);
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            this._sequence = val_11;
            this._isFlying = true;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.OnWaypointChange<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform, path:  this._paths, duration:  this._timeFly, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  this.FlyCurve), action:  new DG.Tweening.TweenCallback<System.Int32>(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyFly::<ButterFlyFlyToTarget>b__27_1(int p))));
            if(this._isJustCollect != false)
            {
                    UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  0.56f);
                DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  this._sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  this._timeFly));
            }
            
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyFly::<ButterFlyFlyToTarget>b__27_2()));
            UnityEngine.Vector3[] val_35 = this.StopAngles;
            val_35 = val_35 + (this._butterFlyStyle * 12);
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = (this._butterFlyStyle * 12) + this.StopAngles + 32, y = (this._butterFlyStyle * 12) + this.StopAngles + 32 + 4, z = (this._butterFlyStyle * 12) + this.StopAngles + 40}, duration:  0.38f, mode:  0), id:  System.String.Format(format:  "rotate{0}", arg0:  this._butterFlyIndex)));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this._sequence, interval:  5.3f);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyFly::<ButterFlyFlyToTarget>b__27_3()));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  this._sequence, id:  this);
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
            UnityEngine.Transform val_10;
            int val_10 = this._pathPointIndex;
            val_10 = val_10 + 1;
            this._pathPointIndex = val_10;
            if(val_10 >= paths.Length)
            {
                    return;
            }
            
            var val_11 = (long)val_10;
            val_11 = paths + (val_11 * 12);
            int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  System.String.Format(format:  "rotate{0}", arg0:  this._butterFlyIndex), complete:  false);
            val_10 = this.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.LookAtAngle(targetPos:  new UnityEngine.Vector3() {x = ((long)(int)((this._pathPointIndex + 1)) * 12) + paths + 32, y = ((long)(int)((this._pathPointIndex + 1)) * 12) + paths + 32 + 4, z = ((long)(int)((this._pathPointIndex + 1)) * 12) + paths + 40}));
            float val_12 = (float)paths.Length;
            val_12 = this._timeFly / val_12;
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_10, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  val_12, mode:  3), id:  System.String.Format(format:  "rotate{0}", arg0:  this._butterFlyIndex));
        }
        private void SetWaypointLockState(bool isLock)
        {
            if(this._waypoint == 0)
            {
                    return;
            }
            
            this._waypoint._isLock = isLock;
        }
        private void OnDisable()
        {
            this.ClearButterfly();
        }
        public ButterFlyFly()
        {
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  -24f);
            val_1[0] = val_2.x;
            val_1[1] = val_2.z;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  18f);
            UnityEngine.Vector3 val_4;
            val_1[1] = val_3.x;
            val_1[2] = val_3.z;
            val_4 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  -25f);
            val_1[3] = val_4.x;
            val_1[4] = val_4.z;
            this.StopAngles = val_1;
            this = new UnityEngine.MonoBehaviour();
        }
        private void <ButterFlyFlyToTarget>b__27_0(View.Dialog.ButterFly.Waypoint point)
        {
            this._waypoint = point;
        }
        private void <ButterFlyFlyToTarget>b__27_1(int p)
        {
            this.WaypointChange(paths:  this._paths);
        }
        private void <ButterFlyFlyToTarget>b__27_2()
        {
            if(this._isClickButterFly != false)
            {
                    this.AnimationController.PlayDefaultFlyAni();
                this._isClickButterFly = false;
                this.ButterFlyFlyToTarget();
            }
            else
            {
                    this.AnimationController.PlayStopAni(butterFlyStyle:  this._butterFlyStyle);
            }
            
            this._isFlying = false;
        }
        private void <ButterFlyFlyToTarget>b__27_3()
        {
            this.AnimationController.PlayBeginFlyAni(butterFlyStyle:  this._butterFlyStyle);
            this.ButterFlyFlyToTarget();
        }
    
    }

}
