using UnityEngine;

namespace Common
{
    public static class EzPath
    {
        // Methods
        private static UnityEngine.Vector3[] PathControlPointGenerator(UnityEngine.Vector3[] path)
        {
            System.Array val_15;
            int val_1 = path.Length + 2;
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
            val_15 = val_2;
            System.Array.Copy(sourceArray:  path, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  1, length:  path.Length);
            UnityEngine.Vector3 val_15 = val_15[1];
            UnityEngine.Vector3 val_16 = val_15[2];
            UnityEngine.Vector3 val_17 = val_15[2];
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_15[3], y = val_15[3], z = val_15[4]});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_15[0] = val_4;
            val_15[0] = val_4.y;
            val_15[1] = val_4.z;
            float val_21 = 0f;
            val_21 = val_21 + ((val_2.Length) << 32);
            float val_5 = (-12884901888) + ((val_2.Length) << 32);
            val_21 = val_21 >> 32;
            val_5 = val_5 >> 32;
            val_21 = val_15[32] + (val_21 * 12);
            val_5 = val_15[32] + (val_5 * 12);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2[0x20] + 4, z = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2[0x20] + 8}, b:  new UnityEngine.Vector3() {x = val_5, y = (((-12884901888 + (val_2.Length) << 32) >> 32) * 12) + val_2[0x20] + 4, z = (((-12884901888 + (val_2.Length) << 32) >> 32) * 12) + val_2[0x20] + 8});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21, y = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2[0x20] + 4, z = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2[0x20] + 8}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            var val_8 = (-4294967296) + ((val_2.Length) << 32);
            val_8 = val_8 >> 32;
            val_8 = val_15 + (val_8 * 12);
            mem2[0] = val_7.x;
            mem2[0] = val_7.y;
            mem2[0] = val_7.z;
            var val_9 = (-8589934592) + ((val_2.Length) << 32);
            val_9 = val_9 >> 32;
            val_9 = val_15 + (val_9 * 12);
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_15[1], y = val_15[2], z = val_15[2]}, rhs:  new UnityEngine.Vector3() {x = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32, y = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 32 + 4, z = (((-8589934592 + (val_2.Length) << 32) >> 32) * 12) + val_2 + 40})) == false)
            {
                    return (UnityEngine.Vector3[])val_15;
            }
            
            UnityEngine.Vector3[] val_11 = new UnityEngine.Vector3[0];
            System.Array.Copy(sourceArray:  val_2, destinationArray:  val_11, length:  val_2.Length);
            UnityEngine.Vector3 val_12 = (-12884901888) + ((val_11.Length) << 32);
            val_12 = val_12 >> 32;
            var val_13 = (-4294967296) + ((val_11.Length) << 32);
            val_12 = val_11[32] + (val_12 * 12);
            val_13 = val_13 >> 32;
            val_13 = val_11[32] + (val_13 * 12);
            val_11[0] = val_12;
            val_11[1] = (((-12884901888 + (val_11.Length) << 32) >> 32) * 12) + val_11[0x20] + 8;
            mem2[0] = val_11[3];
            mem2[0] = val_11[4];
            UnityEngine.Vector3[] val_14 = new UnityEngine.Vector3[0];
            val_15 = val_14;
            System.Array.Copy(sourceArray:  val_11, destinationArray:  val_14, length:  val_11.Length);
            return (UnityEngine.Vector3[])val_15;
        }
        public static UnityEngine.Vector3[] GetSmoothPoints(UnityEngine.Vector3[] points, int smooth = 10)
        {
            UnityEngine.Vector3[] val_4;
            UnityEngine.Vector3[] val_5;
            int val_8 = smooth;
            val_5 = points;
            if(points.Length == 1)
            {
                    return (UnityEngine.Vector3[])val_5;
            }
            
            val_8 = points.Length * val_8;
            val_4 = Common.EzPath.PathControlPointGenerator(path:  val_5);
            val_5 = new UnityEngine.Vector3[0];
            if(val_8 >= 1)
            {
                    var val_10 = 1;
                do
            {
                float val_9 = 1f;
                val_9 = val_9 / (float)val_8;
                UnityEngine.Vector3 val_3 = Common.EzPath.Interp(pts:  val_4, t:  val_9);
                val_10 = ((long)val_10 - 1) + 2;
                var val_5 = val_5 + (((long)val_10 - 1) * 12);
                mem2[0] = val_3.x;
                mem2[0] = val_3.y;
                mem2[0] = val_3.z;
            }
            while(val_10 <= val_8);
            
            }
            
            val_5[0] = val_5[0];
            val_5[1] = val_5[1];
            return (UnityEngine.Vector3[])val_5;
        }
        private static UnityEngine.Vector3 Interp(UnityEngine.Vector3[] pts, float t)
        {
            float val_2 = ((float)pts.Length - 3) * t;
            int val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_2), b:  pts.Length - 4);
            var val_32 = (long)val_5;
            var val_33 = (long)val_32 + 1;
            val_32 = pts + (val_32 * 12);
            var val_34 = (long)val_32 + 2;
            val_33 = pts + (val_33 * 12);
            val_34 = pts + (val_34 * 12);
            var val_35 = 12;
            val_35 = pts + (((long)val_32 + 3) * val_35);
            float val_9 = val_2 - (float)val_5;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + pts + 32, y = ((long)(int)(val_5) * 12) + pts + 32 + 4, z = ((long)(int)(val_5) * 12) + pts + 40});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 40});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 40});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 40});
            float val_16 = val_9 * val_9;
            val_16 = val_9 * val_16;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  val_16);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + pts + 32, y = ((long)(int)(val_5) * 12) + pts + 32 + 4, z = ((long)(int)(val_5) * 12) + pts + 40});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  5f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 40});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 40});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + pts + 40});
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_16);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + pts + 32, y = ((long)(int)(val_5) * 12) + pts + 32 + 4, z = ((long)(int)(val_5) * 12) + pts + 40});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + pts + 40});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  val_9);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + pts + 40});
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            return UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        }
    
    }

}
