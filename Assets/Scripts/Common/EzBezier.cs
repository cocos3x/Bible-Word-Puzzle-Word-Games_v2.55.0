using UnityEngine;

namespace Common
{
    public class EzBezier
    {
        // Methods
        private static UnityEngine.Vector3 CalculateCubicBezierPoint(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
        {
            float val_1;
            float val_9 = 1f;
            float val_2 = val_9 - t;
            val_9 = val_2 * val_2;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            float val_5 = val_2 + val_2;
            val_5 = val_5 * t;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_5, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  t * t, a:  new UnityEngine.Vector3() {x = p2.x, y = val_1, z = p2.y});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        private static UnityEngine.Vector3 CalculateCubicBezierPoint(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            float val_1;
            float val_2;
            float val_3 = 1f - t;
            float val_4 = t * t;
            float val_5 = val_3 * val_3;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  val_3 * val_5, a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            float val_14 = 3f;
            val_14 = val_5 * val_14;
            val_14 = val_14 * t;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  val_14, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            float val_15 = 3f;
            val_15 = val_3 * val_15;
            val_15 = val_4 * val_15;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  val_4 * t, a:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        }
        public static UnityEngine.Vector3[] GetBezierList(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 controlPoint, UnityEngine.Vector3 endPoint, int segmentNum)
        {
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
            if(segmentNum < 1)
            {
                    return val_1;
            }
            
            var val_7 = 1;
            do
            {
                float val_6 = 1f;
                val_6 = val_6 / (float)segmentNum;
                UnityEngine.Vector3 val_3 = Common.EzBezier.CalculateCubicBezierPoint(t:  val_6, p0:  new UnityEngine.Vector3() {x = startPoint.x, y = startPoint.y, z = startPoint.z}, p1:  new UnityEngine.Vector3() {x = controlPoint.x, y = controlPoint.y, z = controlPoint.z}, p2:  new UnityEngine.Vector3() {x = endPoint.x, y = endPoint.y});
                val_7 = ((long)val_7 - 1) + 2;
                var val_5 = val_1 + (((long)val_7 - 1) * 12);
                mem2[0] = val_3.x;
                mem2[0] = val_3.y;
                mem2[0] = val_3.z;
            }
            while(val_7 <= segmentNum);
            
            return val_1;
        }
        public static UnityEngine.Vector3[] GetBezierList(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 controlPoint1, UnityEngine.Vector3 controlPoint2, UnityEngine.Vector3 endPoint, int segmentNum)
        {
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
            if(segmentNum < 1)
            {
                    return val_1;
            }
            
            var val_8 = 1;
            do
            {
                float val_7 = 1f;
                val_7 = val_7 / (float)segmentNum;
                UnityEngine.Vector3 val_4 = Common.EzBezier.CalculateCubicBezierPoint(t:  val_7, p0:  new UnityEngine.Vector3() {x = startPoint.x, y = startPoint.y, z = startPoint.z}, p1:  new UnityEngine.Vector3() {x = controlPoint1.x, y = controlPoint1.y, z = controlPoint1.z}, p2:  new UnityEngine.Vector3() {x = controlPoint2.x, y = controlPoint2.y, z = controlPoint2.z}, p3:  new UnityEngine.Vector3() {x = endPoint.x, y = startPoint.z, z = controlPoint1.y});
                val_8 = ((long)val_8 - 1) + 2;
                var val_6 = val_1 + (((long)val_8 - 1) * 12);
                mem2[0] = val_4.x;
                mem2[0] = val_4.y;
                mem2[0] = val_4.z;
            }
            while(val_8 <= segmentNum);
            
            return val_1;
        }
    
    }

}
