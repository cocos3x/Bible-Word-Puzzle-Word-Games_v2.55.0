using UnityEngine;

namespace Utils.Unity
{
    public static class Vector3Extension
    {
        // Fields
        private static UnityEngine.Vector2 _cacheV2;
        private static UnityEngine.Vector3 _cacheV3;
        
        // Methods
        public static UnityEngine.Vector2 ToV2(UnityEngine.Vector3 self)
        {
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z});
        }
        public static UnityEngine.Vector2 ToV2XZ(UnityEngine.Vector3 self)
        {
            Utils.Unity.Vector3Extension._cacheV2 = self.x;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_4 = self.z;
            return new UnityEngine.Vector2() {x = Utils.Unity.Vector3Extension._cacheV2, y = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_4};
        }
        public static UnityEngine.Vector2 XZV2(UnityEngine.Vector3 self)
        {
            return Utils.Unity.Vector3Extension.ToV2XZ(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z});
        }
        public static UnityEngine.Vector2 ToV2YZ(UnityEngine.Vector3 self)
        {
            Utils.Unity.Vector3Extension._cacheV2 = self.y;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_4 = self.z;
            return new UnityEngine.Vector2() {x = Utils.Unity.Vector3Extension._cacheV2, y = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_4};
        }
        public static UnityEngine.Vector2 YZV2(UnityEngine.Vector3 self)
        {
            return Utils.Unity.Vector3Extension.ToV2YZ(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z});
        }
        public static UnityEngine.Vector3 NewX(UnityEngine.Vector3 self, float x)
        {
            Utils.Unity.Vector3Extension._cacheV3 = self.x;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C = self.y;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10 = self.z;
            Utils.Unity.Vector3Extension._cacheV3 = x;
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector3Extension._cacheV3, y = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector3 NewY(UnityEngine.Vector3 self, float y)
        {
            Utils.Unity.Vector3Extension._cacheV3 = self.x;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C = self.y;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10 = self.z;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C = y;
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector3Extension._cacheV3, y = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector3 NewZ(UnityEngine.Vector3 self, float z)
        {
            Utils.Unity.Vector3Extension._cacheV3 = self.x;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C = self.y;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10 = self.z;
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10 = z;
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector3Extension._cacheV3, y = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector3 NewXY(UnityEngine.Vector3 self, float x, float y)
        {
            UnityEngine.Vector3 val_1 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
            return Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, y:  y);
        }
        public static UnityEngine.Vector3 NewXZ(UnityEngine.Vector3 self, float x, float z)
        {
            UnityEngine.Vector3 val_1 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, z:  z);
        }
        public static UnityEngine.Vector3 NewYZ(UnityEngine.Vector3 self, float y, float z)
        {
            UnityEngine.Vector3 val_1 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, y:  y);
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, z:  z);
        }
        public static UnityEngine.Vector3 OffsetX(UnityEngine.Vector3 self, float x)
        {
            x = self.x + x;
            return Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
        }
        public static UnityEngine.Vector3 OffsetY(UnityEngine.Vector3 self, float y)
        {
            y = self.y + y;
            return Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, y:  y);
        }
        public static UnityEngine.Vector3 OffsetZ(UnityEngine.Vector3 self, float z)
        {
            z = self.z + z;
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, z:  z);
        }
        public static UnityEngine.Vector3 OffsetXY(UnityEngine.Vector3 self, float x, float y)
        {
            x = self.x + x;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
            return Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, y:  self.y + y);
        }
        public static UnityEngine.Vector3 OffsetXZ(UnityEngine.Vector3 self, float x, float z)
        {
            x = self.x + x;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, z:  self.z + z);
        }
        public static UnityEngine.Vector3 OffsetYZ(UnityEngine.Vector3 self, float y, float z)
        {
            y = self.y + y;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, y:  y);
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, z:  self.z + z);
        }
        public static UnityEngine.Vector3 ScaleX(UnityEngine.Vector3 self, float x)
        {
            x = self.x * x;
            return Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
        }
        public static UnityEngine.Vector3 ScaleY(UnityEngine.Vector3 self, float y)
        {
            y = self.y * y;
            return Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, y:  y);
        }
        public static UnityEngine.Vector3 ScaleZ(UnityEngine.Vector3 self, float z)
        {
            z = self.z * z;
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, z:  z);
        }
        public static UnityEngine.Vector3 ScaleXY(UnityEngine.Vector3 self, float x, float y)
        {
            x = self.x * x;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
            return Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, y:  self.y * y);
        }
        public static UnityEngine.Vector3 ScaleXZ(UnityEngine.Vector3 self, float x, float z)
        {
            x = self.x * x;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, x:  x);
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, z:  self.z * z);
        }
        public static UnityEngine.Vector3 ScaleYZ(UnityEngine.Vector3 self, float y, float z)
        {
            y = self.y * y;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, y:  y);
            return Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, z:  self.z * z);
        }
        public static bool IsUniformScale(UnityEngine.Vector3 self)
        {
            if((UnityEngine.Mathf.Approximately(a:  self.x, b:  self.y)) == false)
            {
                    return false;
            }
            
            return UnityEngine.Mathf.Approximately(a:  self.x, b:  self.z);
        }
        public static float AngleOnXZ(UnityEngine.Vector3 self)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, y:  0f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            return (float)Utils.Unity.Vector3Extension.AngleTo(from:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, axis:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = ???});
        }
        public static float AngleTo(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis)
        {
            float val_1;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, rhs:  new UnityEngine.Vector3() {x = to.x, y = to.y, z = to.z});
            float val_5 = UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = axis.x, y = val_1, z = axis.y}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}));
            val_5 = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, to:  new UnityEngine.Vector3() {x = to.x, y = to.y, z = to.z})) * val_5;
            return (float)val_5;
        }
        public static UnityEngine.Vector3 RotateBy(UnityEngine.Vector3 self, float angle, UnityEngine.Vector3 axis)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.AngleAxis(angle:  angle, axis:  new UnityEngine.Vector3() {x = axis.x, y = axis.y, z = axis.z});
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z});
        }
        public static UnityEngine.Vector3 Clamp(UnityEngine.Vector3 self, UnityEngine.Bounds bounds)
        {
            UnityEngine.Vector3 val_1 = bounds.min;
            UnityEngine.Vector3 val_2 = bounds.max;
            UnityEngine.Vector3 val_3 = Utils.Unity.Vector3Extension.Clamp(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, min:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, max:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z, z = ???});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static UnityEngine.Vector3 Clamp(UnityEngine.Vector3 self, UnityEngine.Vector3 min, UnityEngine.Vector3 max)
        {
            float val_1;
            Utils.Unity.Vector3Extension._cacheV3 = UnityEngine.Mathf.Clamp(value:  self.x, min:  min.x, max:  max.x);
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C = UnityEngine.Mathf.Clamp(value:  self.y, min:  min.y, max:  val_1);
            Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10 = UnityEngine.Mathf.Clamp(value:  self.z, min:  min.z, max:  max.y);
            return new UnityEngine.Vector3() {x = Utils.Unity.Vector3Extension._cacheV3, y = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_C, z = Utils.Unity.Vector3Extension._cacheV2.__il2cppRuntimeField_10};
        }
        public static UnityEngine.Vector3 RandomPositionOnSphere(UnityEngine.Vector3 center, float radius)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Random.onUnitSphere;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  radius);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public static UnityEngine.Vector3 RandomPositionInSphere(UnityEngine.Vector3 center, float maxRadius, float minRadius = 0)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Random.onUnitSphere;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  UnityEngine.Random.Range(min:  minRadius, max:  maxRadius));
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        public static UnityEngine.Transform GetNearest(UnityEngine.Vector3 center, float radius, int layerMask)
        {
            var val_6;
            if(val_1.Length >= 1)
            {
                    var val_7 = 0;
                val_6 = 0;
                do
            {
                UnityEngine.Collider val_6 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, radius:  radius, layerMask:  layerMask)[val_7];
                UnityEngine.Vector3 val_3 = val_6.transform.position;
                if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) < 0)
            {
                    val_6 = val_6.transform;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1.Length);
            
                return (UnityEngine.Transform)val_6;
            }
            
            val_6 = 0;
            return (UnityEngine.Transform)val_6;
        }
        public static UnityEngine.Transform GetNearestNonAlloc(UnityEngine.Vector3 center, float radius, UnityEngine.Collider[] colliders, int layerMask)
        {
            var val_6;
            int val_1 = UnityEngine.Physics.OverlapSphereNonAlloc(position:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, radius:  radius, results:  colliders, layerMask:  layerMask);
            if(val_1 >= 1)
            {
                    var val_6 = 0;
                val_6 = 0;
                do
            {
                UnityEngine.Vector3 val_3 = 1152921505535206176.transform.position;
                if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) < 0)
            {
                    val_6 = 1152921505535206176.transform;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_1);
            
                return (UnityEngine.Transform)val_6;
            }
            
            val_6 = 0;
            return (UnityEngine.Transform)val_6;
        }
        public static UnityEngine.Transform RayCast2D(UnityEngine.Vector3 self, UnityEngine.Vector2 direction, float maxDistance = ∞, int layerMask = -5)
        {
            var val_5;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z});
            UnityEngine.RaycastHit2D val_2 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, direction:  new UnityEngine.Vector2() {x = direction.x, y = direction.y}, distance:  maxDistance, layerMask:  layerMask);
            return (UnityEngine.Transform)val_5.transform;
        }
        public static T RayCast2D<T>(UnityEngine.Vector3 self, UnityEngine.Vector2 direction, float maxDistance = ∞, int layerMask = -5)
        {
            var val_14;
            float val_15;
            float val_16;
            float val_17;
            val_14 = __RuntimeMethodHiddenParam;
            val_15 = maxDistance;
            val_16 = direction.x;
            val_17 = self.y;
            if((Utils.Unity.Vector3Extension.RayCast2D(self:  new UnityEngine.Vector3() {x = self.x, y = val_17, z = self.z}, direction:  new UnityEngine.Vector2() {x = val_16, y = direction.y}, maxDistance:  val_15, layerMask:  layerMask)) == 0)
            {
                    return 0;
            }
            
            val_14 = ???;
            val_15 = ???;
            val_16 = ???;
            val_17 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static UnityEngine.Transform RayCast3D(UnityEngine.Vector3 self, UnityEngine.Vector3 direction, float maxDistance = ∞, int layerMask = -5)
        {
            var val_3;
            val_3 = 0;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = self.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  maxDistance, layerMask:  layerMask)) == false)
            {
                    return (UnityEngine.Transform)0.transform;
            }
            
            return (UnityEngine.Transform)0.transform;
        }
        public static T RayCast3D<T>(UnityEngine.Vector3 self, UnityEngine.Vector3 direction, float maxDistance = ∞, int layerMask = -5)
        {
            var val_15;
            float val_16;
            float val_17;
            float val_18;
            val_15 = __RuntimeMethodHiddenParam;
            val_16 = maxDistance;
            val_17 = direction.y;
            val_18 = self.z;
            if((Utils.Unity.Vector3Extension.RayCast3D(self:  new UnityEngine.Vector3() {x = self.x, y = self.y, z = val_18}, direction:  new UnityEngine.Vector3() {x = direction.x, y = val_17, z = direction.z}, maxDistance:  val_16, layerMask:  layerMask)) == 0)
            {
                    return 0;
            }
            
            val_15 = ???;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
    
    }

}
