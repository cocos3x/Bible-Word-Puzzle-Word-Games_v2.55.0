using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class WaypointSlots : MonoBehaviour
    {
        // Fields
        private const int WaypointCount = 19;
        private const int SegmentNum = 20;
        private const float MinimumDistance = 2;
        private const int TryMaxCount = 4;
        public UnityEngine.Transform ControlPoint_0;
        public UnityEngine.Transform ControlPoint_1;
        private bool _isRunning;
        private View.Dialog.ButterFly.Waypoint[] _waypoints;
        private View.Dialog.ButterFly.Waypoint _waypoint;
        private System.Collections.Generic.List<View.Dialog.ButterFly.Waypoint> _unLockWaypoints;
        private int _lastPointIndex;
        private UnityEngine.Vector3 _tempTargetPos;
        private UnityEngine.Vector3 _tempControlPoint1;
        private UnityEngine.Vector3 _tempControlPoint2;
        private UnityEngine.Vector3 _tempBetweenPoint1;
        private UnityEngine.Vector3 _tempBetweenPoint2;
        private UnityEngine.Vector3[] _tempPaths;
        private float _timeFly;
        private int _tryCount;
        
        // Methods
        private void Awake()
        {
            var val_7;
            this._waypoints = 17038;
            var val_9 = 4;
            do
            {
                val_7 = this.transform.Find(n:  System.String.Format(format:  "Waypoint_{0}", arg0:  0)).GetComponent<View.Dialog.ButterFly.Waypoint>();
                if((val_9 - 4) > 17)
            {
                    return;
            }
            
                val_7 = this.transform;
                string val_8 = System.String.Format(format:  "Waypoint_{0}", arg0:  val_9 - 3);
                val_9 = val_9 + 1;
            }
            while(val_7 != null);
            
            throw new NullReferenceException();
        }
        private void OnEnable()
        {
            this._lastPointIndex = 0;
        }
        public View.Dialog.ButterFly.Waypoint GetNextWaypoint()
        {
            View.Dialog.ButterFly.Waypoint[] val_5;
            int val_6;
            int val_7;
            this._unLockWaypoints.Clear();
            val_5 = this._waypoints;
            var val_5 = 0;
            label_8:
            val_6 = this._waypoints.Length;
            if(val_5 >= val_6)
            {
                goto label_3;
            }
            
            val_6 = val_5[val_5];
            if(this._waypoints[0x0][0]._isLock != true)
            {
                    this._unLockWaypoints.Add(item:  val_6);
                val_5 = this._waypoints;
            }
            
            val_5 = val_5 + 1;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_3:
            if(this._unLockWaypoints >= 1)
            {
                    int val_1 = UnityEngine.Random.Range(min:  0, max:  this._unLockWaypoints);
                val_7 = val_1;
                if(val_1 == this._lastPointIndex)
            {
                    val_7 = UnityEngine.Random.Range(min:  0, max:  this._unLockWaypoints);
            }
            
                this._lastPointIndex = UnityEngine.Mathf.Clamp(value:  val_7, min:  0, max:  21121671);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            else
            {
                    int val_4 = UnityEngine.Random.Range(min:  0, max:  val_6);
                this._lastPointIndex = val_4;
            }
            
            return (View.Dialog.ButterFly.Waypoint)null;
        }
        private void MatchBezierPath(UnityEngine.Vector3 nowPos, View.Dialog.ButterFly.Waypoint point)
        {
            View.Dialog.ButterFly.Waypoint val_8;
            var val_9;
            val_8 = point;
            goto label_0;
            label_7:
            if(this._tryCount > 4)
            {
                goto label_1;
            }
            
            View.Dialog.ButterFly.Waypoint val_1 = this.GetNextWaypoint();
            int val_8 = this._tryCount;
            val_8 = val_1;
            this._waypoint = val_1;
            val_8 = val_8 + 1;
            this._tryCount = val_8;
            label_0:
            this._waypoint = val_8;
            UnityEngine.Vector3 val_3 = val_8.transform.position;
            this._tempTargetPos = val_3;
            mem[1152921512813406608] = val_3.y;
            mem[1152921512813406612] = val_3.z;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) < 0)
            {
                goto label_7;
            }
            
            val_9 = 0;
            goto label_8;
            label_1:
            val_9 = 1;
            label_8:
            this._tryCount = 0;
            this._timeFly = ;
            if((S11 > 2f) && ((UnityEngine.Random.Range(min:  0f, max:  1f)) >= 0.5f))
            {
                    this.CalculatePaths3(nowPos:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, endPos:  new UnityEngine.Vector3() {x = this._tempTargetPos});
                UnityEngine.Vector3[] val_6 = Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, controlPoint1:  new UnityEngine.Vector3() {x = this._tempControlPoint1}, controlPoint2:  new UnityEngine.Vector3() {x = this._tempControlPoint2, y = nowPos.y, z = this._tempTargetPos}, endPoint:  new UnityEngine.Vector3() {x = nowPos.x, y = ???}, segmentNum:  20);
            }
            else
            {
                    this.CalculatePaths2(nowPos:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, endPos:  new UnityEngine.Vector3() {x = this._tempTargetPos}, isShort:  true);
            }
            
            this._tempPaths = Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, controlPoint:  new UnityEngine.Vector3() {x = this._tempControlPoint1}, endPoint:  new UnityEngine.Vector3() {x = this._tempTargetPos, y = nowPos.x, z = this._tempTargetPos}, segmentNum:  20);
        }
        public UnityEngine.Vector3[] GetBezierPath(UnityEngine.Vector3 nowPos, View.Dialog.ButterFly.Waypoint point, System.Action<View.Dialog.ButterFly.Waypoint> callback)
        {
            this.MatchBezierPath(nowPos:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, point:  point);
            if(callback == null)
            {
                    return (UnityEngine.Vector3[])this._tempPaths;
            }
            
            callback.Invoke(obj:  this._waypoint);
            return (UnityEngine.Vector3[])this._tempPaths;
        }
        public float GetFlyTime()
        {
            return (float)this._timeFly;
        }
        private UnityEngine.Vector3 GetBetweenPoint(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float percent = 0.5)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            UnityEngine.Vector3 val_2 = val_1.x.normalized;
            float val_6 = end.x;
            val_6 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, b:  new UnityEngine.Vector3() {x = val_6, y = end.y, z = end.z})) * percent;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_6);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void CalculatePaths2(UnityEngine.Vector3 nowPos, UnityEngine.Vector3 endPos, bool isShort = False)
        {
            float val_11;
            float val_12;
            val_11 = 0.5f;
            val_12 = nowPos.y;
            UnityEngine.Vector3 val_1 = this.GetBetweenPoint(start:  new UnityEngine.Vector3() {x = nowPos.x, y = val_12, z = nowPos.z}, end:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, percent:  val_11);
            this._tempBetweenPoint1 = val_1;
            mem[1152921512814048180] = val_1.y;
            mem[1152921512814048184] = val_1.z;
            if(isShort != true)
            {
                    val_12 = 1.5f;
                val_11 = UnityEngine.Random.Range(min:  1f, max:  val_12);
            }
            
            this.ControlPoint_1.position = new UnityEngine.Vector3() {x = this._tempBetweenPoint1, y = val_12, z = val_1.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, b:  new UnityEngine.Vector3() {x = this._tempBetweenPoint1, y = nowPos.z, z = nowPos.y});
            UnityEngine.Vector3 val_4 = val_3.x.normalized;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_11);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this._tempBetweenPoint1, y = nowPos.z, z = nowPos.y});
            this._tempControlPoint1 = val_6;
            mem[1152921512814048156] = val_6.y;
            mem[1152921512814048160] = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            var val_9 = ((UnityEngine.Random.Range(min:  0f, max:  1f)) < 0.5f) ? 1 : 0;
            UnityEngine.Vector3 val_10 = this.RotateRound(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, center:  new UnityEngine.Vector3() {x = this._tempBetweenPoint1, y = nowPos.z, z = nowPos.y}, axis:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.z, z = 15231112 + val_8 < 0.5f ? 1 : 0}, angle:  null);
            this._tempControlPoint1 = val_10;
            mem[1152921512814048156] = val_10.y;
            mem[1152921512814048160] = val_10.z;
            this.ControlPoint_0.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        private void CalculatePaths3(UnityEngine.Vector3 nowPos, UnityEngine.Vector3 endPos)
        {
            float val_1 = UnityEngine.Random.Range(min:  0f, max:  1f);
            float val_2 = UnityEngine.Random.Range(min:  1.5f, max:  2f);
            UnityEngine.Vector3 val_3 = this.GetBetweenPoint(start:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, end:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, percent:  0.45f);
            this._tempBetweenPoint1 = val_3;
            mem[1152921512814176564] = val_3.y;
            mem[1152921512814176568] = val_3.z;
            var val_4 = (val_1 >= 0.5f) ? 1 : 0;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_6 = val_5.x.normalized;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_2);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = this._tempBetweenPoint1, y = val_3.y, z = val_3.z});
            this._tempControlPoint1 = val_8;
            mem[1152921512814176540] = val_8.y;
            mem[1152921512814176544] = val_8.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_10 = this.RotateRound(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, center:  new UnityEngine.Vector3() {x = this._tempBetweenPoint1, y = val_1, z = endPos.z}, axis:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.z, z = 15231104 + val_1 >= 0.5f ? 1 : 0}, angle:  null);
            this._tempControlPoint1 = val_10;
            mem[1152921512814176540] = val_10.y;
            mem[1152921512814176544] = val_10.z;
            this.ControlPoint_0.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_11 = this.ControlPoint_0.GetBetweenPoint(start:  new UnityEngine.Vector3() {x = nowPos.x, y = nowPos.y, z = nowPos.z}, end:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, percent:  0.55f);
            this._tempBetweenPoint2 = val_11;
            mem[1152921512814176576] = val_11.y;
            mem[1152921512814176580] = val_11.z;
            var val_12 = (val_1 >= 0.5f) ? 1 : 0;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = endPos.x, y = endPos.y, z = endPos.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_14 = val_13.x.normalized;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_2);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = this._tempBetweenPoint2, y = val_11.y, z = val_11.z});
            this._tempControlPoint2 = val_16;
            mem[1152921512814176552] = val_16.y;
            mem[1152921512814176556] = val_16.z;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_18 = this.RotateRound(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, center:  new UnityEngine.Vector3() {x = this._tempBetweenPoint2, y = val_11.x, z = val_11.y}, axis:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.z, z = 15231112 + val_1 >= 0.5f ? 1 : 0}, angle:  null);
            this._tempControlPoint2 = val_18;
            mem[1152921512814176552] = val_18.y;
            mem[1152921512814176556] = val_18.z;
            this.ControlPoint_1.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        }
        private UnityEngine.Vector3 RotateRound(UnityEngine.Vector3 position, UnityEngine.Vector3 center, UnityEngine.Vector3 axis, float angle)
        {
            float val_1;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.AngleAxis(angle:  axis.z, axis:  new UnityEngine.Vector3() {x = axis.x, y = val_1, z = axis.y});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public WaypointSlots()
        {
            this._unLockWaypoints = new System.Collections.Generic.List<View.Dialog.ButterFly.Waypoint>();
        }
    
    }

}
