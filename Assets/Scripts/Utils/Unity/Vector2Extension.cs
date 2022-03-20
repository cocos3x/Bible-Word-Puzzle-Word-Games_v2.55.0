using UnityEngine;

namespace Utils.Unity
{
    public static class Vector2Extension
    {
        // Fields
        private static UnityEngine.Vector2 _cacheV2;
        private static UnityEngine.Vector3 _cacheV3;
        
        // Methods
        public static UnityEngine.Vector3 ToV3(UnityEngine.Vector2 self, float z = 0)
        {
            Utils.Unity.Vector2Extension._cacheV3 = self.x;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_C = self.y;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_10 = z;
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector2Extension._cacheV3, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector3 XZV3(UnityEngine.Vector2 self, float y = 0)
        {
            Utils.Unity.Vector2Extension._cacheV3 = self.x;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_C = y;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_10 = self.y;
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector2Extension._cacheV3, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector3 YZV3(UnityEngine.Vector2 self, float x = 0)
        {
            Utils.Unity.Vector2Extension._cacheV3 = x;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_C = self.x;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_10 = self.y;
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector2Extension._cacheV3, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector2 NewX(UnityEngine.Vector2 self, float x)
        {
            Utils.Unity.Vector2Extension._cacheV2 = self.x;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4 = self.y;
            Utils.Unity.Vector2Extension._cacheV2 = x;
            return new UnityEngine.Vector2() {x = Utils.Unity.Vector2Extension._cacheV2, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4};
        }
        public static UnityEngine.Vector2 NewY(UnityEngine.Vector2 self, float y)
        {
            Utils.Unity.Vector2Extension._cacheV2 = self.x;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4 = self.y;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4 = y;
            return new UnityEngine.Vector2() {x = Utils.Unity.Vector2Extension._cacheV2, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4};
        }
        public static UnityEngine.Vector2 OffsetX(UnityEngine.Vector2 self, float x)
        {
            x = self.x + x;
            return Utils.Unity.Vector2Extension.NewX(self:  new UnityEngine.Vector2() {x = self.x, y = self.y}, x:  x);
        }
        public static UnityEngine.Vector2 OffsetY(UnityEngine.Vector2 self, float y)
        {
            y = self.y + y;
            return Utils.Unity.Vector2Extension.NewY(self:  new UnityEngine.Vector2() {x = self.x, y = self.y}, y:  y);
        }
        public static UnityEngine.Vector2 ScaleX(UnityEngine.Vector2 self, float x)
        {
            x = self.x * x;
            return Utils.Unity.Vector2Extension.NewX(self:  new UnityEngine.Vector2() {x = self.x, y = self.y}, x:  x);
        }
        public static UnityEngine.Vector2 ScaleY(UnityEngine.Vector2 self, float y)
        {
            y = self.y * y;
            return Utils.Unity.Vector2Extension.NewY(self:  new UnityEngine.Vector2() {x = self.x, y = self.y}, y:  y);
        }
        public static bool IsUniformScale(UnityEngine.Vector2 self)
        {
            return UnityEngine.Mathf.Approximately(a:  self.x, b:  self.y);
        }
        public static float Angle(UnityEngine.Vector2 self)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.right;
            return Utils.Unity.Vector2Extension.AngleTo(from:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, to:  new UnityEngine.Vector2() {x = self.x, y = self.y});
        }
        public static float AngleTo(UnityEngine.Vector2 from, UnityEngine.Vector2 to)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = from.x, y = from.y});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = to.x, y = to.y});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            float val_4 = UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = from.x, y = from.y}, to:  new UnityEngine.Vector2() {x = to.x, y = to.y});
            val_4 = (val_3.z <= 0f) ? (-val_4) : (val_4);
            return (float)val_4;
        }
        public static UnityEngine.Vector2 RotateBy(UnityEngine.Vector2 self, float angle)
        {
            float val_4 = angle;
            float val_1 = Utils.Unity.Vector2Extension.Angle(self:  new UnityEngine.Vector2() {x = self.x, y = self.y});
            val_1 = val_1 + val_4;
            val_4 = val_1 * 0.01745329f;
            Utils.Unity.Vector2Extension._cacheV2 = val_4;
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4 = val_4;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = Utils.Unity.Vector2Extension._cacheV2, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4}, d:  self.x.magnitude);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public static UnityEngine.Vector2 Clamp(UnityEngine.Vector2 self, UnityEngine.Rect rect)
        {
            UnityEngine.Vector2 val_1 = rect.m_XMin.min;
            UnityEngine.Vector2 val_2 = rect.m_XMin.max;
            UnityEngine.Vector2 val_3 = Utils.Unity.Vector2Extension.Clamp(self:  new UnityEngine.Vector2() {x = self.x, y = self.y}, min:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, max:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public static UnityEngine.Vector2 Clamp(UnityEngine.Vector2 self, UnityEngine.Vector2 min, UnityEngine.Vector2 max)
        {
            Utils.Unity.Vector2Extension._cacheV2 = UnityEngine.Mathf.Clamp(value:  self.x, min:  min.x, max:  max.x);
            Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4 = UnityEngine.Mathf.Clamp(value:  self.y, min:  min.y, max:  max.y);
            return new UnityEngine.Vector2() {x = Utils.Unity.Vector2Extension._cacheV2, y = Utils.Unity.Vector2Extension._cacheV2.__il2cppRuntimeField_4};
        }
        public static UnityEngine.Vector2 PositionOnArc(UnityEngine.Vector2 center, float radius, float angle)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  radius);
            UnityEngine.Vector2 val_3 = Utils.Unity.Vector2Extension.RotateBy(self:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, angle:  angle);
            return UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = center.x, y = center.y}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        }
        public static UnityEngine.Vector2 RandomPositionOnArc(UnityEngine.Vector2 center, float radius, float startAngle = 0, float endAngle = 360)
        {
            return Utils.Unity.Vector2Extension.PositionOnArc(center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, radius:  radius, angle:  UnityEngine.Random.Range(min:  startAngle, max:  endAngle));
        }
        public static UnityEngine.Vector2 RandomPositionInSector(UnityEngine.Vector2 center, float maxRadius, float minRadius = 0, float startAngle = 0, float endAngle = 360)
        {
            return Utils.Unity.Vector2Extension.PositionOnArc(center:  new UnityEngine.Vector2() {x = center.x, y = center.y}, radius:  UnityEngine.Random.Range(min:  minRadius, max:  maxRadius), angle:  UnityEngine.Random.Range(min:  startAngle, max:  endAngle));
        }
        public static UnityEngine.Transform GetNearest(UnityEngine.Vector2 center, float radius, int layerMask)
        {
            float val_7;
            var val_8;
            val_7 = radius;
            if(val_1.Length >= 1)
            {
                    var val_8 = 0;
                val_8 = 0;
                do
            {
                UnityEngine.Collider2D val_7 = UnityEngine.Physics2D.OverlapCircleAll(point:  new UnityEngine.Vector2() {x = center.x, y = center.y}, radius:  val_7, layerMask:  layerMask)[val_8];
                UnityEngine.Vector3 val_3 = val_7.transform.position;
                val_7 = val_3.x;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_3.y, z = val_3.z});
                float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = center.x, y = center.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                if(val_5 < 0)
            {
                    val_7 = val_5;
                val_8 = val_7.transform;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_1.Length);
            
                return (UnityEngine.Transform)val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.Transform)val_8;
        }
        public static UnityEngine.Transform GetNearestNonAlloc(UnityEngine.Vector2 center, float radius, UnityEngine.Collider2D[] colliders, int layerMask)
        {
            float val_7;
            var val_8;
            val_7 = radius;
            int val_1 = UnityEngine.Physics2D.OverlapCircleNonAlloc(point:  new UnityEngine.Vector2() {x = center.x, y = center.y}, radius:  val_7, results:  colliders, layerMask:  layerMask);
            if(val_1 >= 1)
            {
                    var val_7 = 0;
                val_8 = 0;
                do
            {
                UnityEngine.Vector3 val_3 = 1152921505529320800.transform.position;
                val_7 = val_3.x;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_3.y, z = val_3.z});
                float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = center.x, y = center.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                if(val_5 < 0)
            {
                    val_7 = val_5;
                val_8 = 1152921505529320800.transform;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1);
            
                return (UnityEngine.Transform)val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.Transform)val_8;
        }
    
    }

}
