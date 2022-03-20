using UnityEngine;

namespace Utils.Unity
{
    public static class TransformExtension
    {
        // Methods
        public static UnityEngine.Transform Reset(UnityEngine.Transform self)
        {
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            self.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            self.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            self.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Vector3 GetLocalPosition(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.localPosition;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform LocalPosition(UnityEngine.Transform self, UnityEngine.Vector3 localPosition)
        {
            self.localPosition = new UnityEngine.Vector3() {x = localPosition.x, y = localPosition.y, z = localPosition.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalPositionX(UnityEngine.Transform self, float x)
        {
            UnityEngine.Vector3 val_1 = self.localPosition;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, x:  x);
            self.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalPositionY(UnityEngine.Transform self, float y)
        {
            UnityEngine.Vector3 val_1 = self.localPosition;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, y:  y);
            self.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalPositionZ(UnityEngine.Transform self, float z)
        {
            UnityEngine.Vector3 val_1 = self.localPosition;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, z:  z);
            self.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalPositionReset(UnityEngine.Transform self)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            self.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Vector3 GetAnchoredPosition(UnityEngine.Transform self)
        {
            UnityEngine.Vector2 val_2 = Utils.Unity.ObjectExtension.As<UnityEngine.RectTransform>(self:  self).anchoredPosition;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        }
        public static UnityEngine.Transform AnchoredPosition(UnityEngine.Transform self, UnityEngine.Vector3 anchoredPosition)
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = anchoredPosition.x, y = anchoredPosition.y, z = anchoredPosition.z});
            Utils.Unity.ObjectExtension.As<UnityEngine.RectTransform>(self:  self).anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Quaternion GetLocalRotation(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.localRotation;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform LocalRotation(UnityEngine.Transform self, UnityEngine.Quaternion localRotation)
        {
            self.localRotation = new UnityEngine.Quaternion() {x = localRotation.x, y = localRotation.y, z = localRotation.z, w = localRotation.w};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalRotationReset(UnityEngine.Transform self)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            self.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.localEulerAngles;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform LocalEulerAngles(UnityEngine.Transform self, UnityEngine.Vector3 localEulerAngles)
        {
            self.localEulerAngles = new UnityEngine.Vector3() {x = localEulerAngles.x, y = localEulerAngles.y, z = localEulerAngles.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalEulerAnglesReset(UnityEngine.Transform self)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            self.localEulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Vector3 GetLocalScale(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.localScale;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform LocalScale(UnityEngine.Transform self, UnityEngine.Vector3 scale)
        {
            self.localScale = new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalScale(UnityEngine.Transform self, float value)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  value);
            self.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalScaleX(UnityEngine.Transform self, float x)
        {
            UnityEngine.Vector3 val_1 = self.localScale;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, x:  x);
            self.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalScaleY(UnityEngine.Transform self, float y)
        {
            UnityEngine.Vector3 val_1 = self.localScale;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, y:  y);
            self.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalScaleZ(UnityEngine.Transform self, float z)
        {
            UnityEngine.Vector3 val_1 = self.localScale;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, z:  z);
            self.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LocalScaleReset(UnityEngine.Transform self)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            self.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Vector3 GetPosition(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.position;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform Position(UnityEngine.Transform self, UnityEngine.Vector3 position)
        {
            self.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform PositionX(UnityEngine.Transform self, float x)
        {
            UnityEngine.Vector3 val_1 = self.position;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewX(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, x:  x);
            self.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform PositionY(UnityEngine.Transform self, float y)
        {
            UnityEngine.Vector3 val_1 = self.position;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewY(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, y:  y);
            self.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform PositionZ(UnityEngine.Transform self, float z)
        {
            UnityEngine.Vector3 val_1 = self.position;
            UnityEngine.Vector3 val_2 = Utils.Unity.Vector3Extension.NewZ(self:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, z:  z);
            self.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform PositionReset(UnityEngine.Transform self)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            self.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Quaternion Rotation(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.rotation;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform Rotation(UnityEngine.Transform self, UnityEngine.Quaternion rotation)
        {
            self.rotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform RotationReset(UnityEngine.Transform self)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            self.rotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Vector3 GetLossyScale(UnityEngine.Transform self)
        {
            if(self != null)
            {
                    return self.lossyScale;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Transform DestroyAllChildren(UnityEngine.Transform self, float defaultDelay)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.Transform)self;
            }
            
            int val_2 = self.childCount;
            if(val_2 < 1)
            {
                    return (UnityEngine.Transform)self;
            }
            
            var val_4 = 0;
            do
            {
                Utils.Unity.ObjectExtension.Destroy<UnityEngine.Transform>(self:  self.GetChild(index:  0), defaultDelay:  defaultDelay);
                val_4 = val_4 + 1;
            }
            while(val_2 != val_4);
            
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform SetActiveAllChildren(UnityEngine.Transform self, bool active, bool recursive = False)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.Transform)self;
            }
            
            int val_2 = self.childCount;
            if(val_2 < 1)
            {
                    return (UnityEngine.Transform)self;
            }
            
            var val_6 = 0;
            do
            {
                self.GetChild(index:  0).gameObject.SetActive(value:  active);
                val_6 = val_6 + 1;
            }
            while(val_6 < val_2);
            
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform FindChild(UnityEngine.Transform self, System.Predicate<UnityEngine.Transform> predicate)
        {
            var val_5;
            UnityEngine.Transform val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.Transform)val_6;
            }
            
            int val_2 = self.childCount;
            if(val_2 >= 1)
            {
                    val_5 = val_2;
                var val_5 = 0;
                do
            {
                val_6 = self.GetChild(index:  0);
                if(predicate == null)
            {
                    return (UnityEngine.Transform)val_6;
            }
            
                if((predicate.Invoke(obj:  val_6)) == true)
            {
                    return (UnityEngine.Transform)val_6;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < val_5);
            
            }
            
            val_6 = 0;
            return (UnityEngine.Transform)val_6;
        }
        public static T FindChild<T>(UnityEngine.Transform self, System.Predicate<T> predicate)
        {
            var val_4;
            if(self.childCount >= 1)
            {
                    var val_4 = 0;
                do
            {
                val_4 = self.GetChild(index:  0);
                if(predicate == null)
            {
                    return (object)val_4;
            }
            
                if((predicate & 1) != 0)
            {
                    return (object)val_4;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < self.childCount);
            
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public static UnityEngine.Transform FindFirstActiveChild(UnityEngine.Transform self)
        {
            var val_2;
            System.Predicate<UnityEngine.Transform> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = TransformExtension.<>c.<>9__36_0;
            if(val_4 != null)
            {
                    return Utils.Unity.TransformExtension.FindChild(self:  self, predicate:  val_4 = val_1);
            }
            
            System.Predicate<UnityEngine.Transform> val_1 = null;
            val_1 = new System.Predicate<UnityEngine.Transform>(object:  TransformExtension.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TransformExtension.<>c::<FindFirstActiveChild>b__36_0(UnityEngine.Transform child));
            TransformExtension.<>c.<>9__36_0 = val_4;
            return Utils.Unity.TransformExtension.FindChild(self:  self, predicate:  val_4);
        }
        public static UnityEngine.Transform FindFirstInactiveChild(UnityEngine.Transform self)
        {
            var val_2;
            System.Predicate<UnityEngine.Transform> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = TransformExtension.<>c.<>9__37_0;
            if(val_4 != null)
            {
                    return Utils.Unity.TransformExtension.FindChild(self:  self, predicate:  val_4 = val_1);
            }
            
            System.Predicate<UnityEngine.Transform> val_1 = null;
            val_1 = new System.Predicate<UnityEngine.Transform>(object:  TransformExtension.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TransformExtension.<>c::<FindFirstInactiveChild>b__37_0(UnityEngine.Transform child));
            TransformExtension.<>c.<>9__37_0 = val_4;
            return Utils.Unity.TransformExtension.FindChild(self:  self, predicate:  val_4);
        }
        public static T FindFirstActiveChild<T>(UnityEngine.Transform self)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 48 + 302];
            val_1 = __RuntimeMethodHiddenParam + 48 + 302;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_1 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_2 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_2 == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_3 = __RuntimeMethodHiddenParam + 48 + 302;
                if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_3 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
                val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
                if(((__RuntimeMethodHiddenParam + 48 + 302) & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
            }
            
                val_2 = __RuntimeMethodHiddenParam + 48 + 16;
                mem2[0] = val_2;
            }
        
        }
        public static T FindFirstInactiveChild<T>(UnityEngine.Transform self)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 48 + 302];
            val_1 = __RuntimeMethodHiddenParam + 48 + 302;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_1 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_2 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_2 == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_3 = __RuntimeMethodHiddenParam + 48 + 302;
                if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_3 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
                val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
                if(((__RuntimeMethodHiddenParam + 48 + 302) & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
            }
            
                val_2 = __RuntimeMethodHiddenParam + 48 + 16;
                mem2[0] = val_2;
            }
        
        }
        public static UnityEngine.Transform CopyInfo(UnityEngine.Transform self, UnityEngine.Transform targetTransform)
        {
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            if(targetTransform == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            self.SetParent(p:  targetTransform.parent);
            UnityEngine.Vector3 val_4 = targetTransform.localPosition;
            self.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_5 = targetTransform.localRotation;
            self.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            UnityEngine.Vector3 val_6 = targetTransform.localScale;
            self.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            return (UnityEngine.Transform)self;
        }
        public static string GetPath(UnityEngine.Transform self)
        {
            UnityEngine.Object val_10;
            if(self == 0)
            {
                    return 0;
            }
            
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder(value:  self.name);
            val_10 = self.parent;
            goto label_5;
            label_10:
            System.Text.StringBuilder val_7 = Insert(index:  0, value:  val_10.name + "/"("/"));
            val_10 = val_10.parent;
            label_5:
            if(val_10 != 0)
            {
                goto label_10;
            }
            
            goto mem[null + 352];
        }
        public static UnityEngine.Transform Parent(UnityEngine.Transform self, UnityEngine.Transform parent, bool worldPositionStays = True)
        {
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            self.SetParent(parent:  parent, worldPositionStays:  worldPositionStays);
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform LastSibling(UnityEngine.Transform self)
        {
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            self.SetAsLastSibling();
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform FirstSibling(UnityEngine.Transform self)
        {
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            self.SetAsFirstSibling();
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform SiblingIndex(UnityEngine.Transform self, int index)
        {
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            self.SetSiblingIndex(index:  index);
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Transform SetSizeDelta(UnityEngine.Transform self, UnityEngine.Vector2 size)
        {
            if(self == null)
            {
                    return (UnityEngine.Transform)self;
            }
            
            if(self == 0)
            {
                    return (UnityEngine.Transform)self;
            }
            
            if(null != null)
            {
                    return (UnityEngine.Transform)self;
            }
            
            self.sizeDelta = new UnityEngine.Vector2() {x = size.x, y = size.y};
            return (UnityEngine.Transform)self;
        }
        public static UnityEngine.Rect GetWordRect(UnityEngine.Transform self)
        {
            if(((self == null) || (self == 0)) || (null != null))
            {
                    throw new System.NullReferenceException(message:  "[GetWordRect] transform is null");
            }
            
            UnityEngine.Rect val_3 = Utils.Unity.ObjectExtension.As<UnityEngine.RectTransform>(self:  self).rect;
            UnityEngine.Vector2 val_4 = val_3.m_XMin.size;
            UnityEngine.Vector3 val_5 = self.lossyScale;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector3 val_8 = self.position;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, d:  0.5f);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            UnityEngine.Rect val_12 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, size:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            return new UnityEngine.Rect() {m_XMin = val_12.m_XMin, m_YMin = val_12.m_YMin, m_Width = val_12.m_Width, m_Height = val_12.m_Height};
        }
        public static bool IsPositionIn(UnityEngine.Transform self, UnityEngine.Vector3 position, bool worldSpace = False, float rectScale = 1)
        {
            float val_16;
            float val_17;
            float val_18;
            val_16 = position.z;
            val_17 = position.y;
            val_18 = position.x;
            if(worldSpace != true)
            {
                    if(UnityEngine.Camera.main != 0)
            {
                    UnityEngine.Vector3 val_4 = Utils.Extensions.CameraExtension.ScreenToWorldPointExt(camera:  UnityEngine.Camera.main, pointPosition:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_16});
                val_18 = val_4.x;
                val_17 = val_4.y;
                val_16 = val_4.z;
            }
            
            }
            
            UnityEngine.Rect val_5 = Utils.Unity.TransformExtension.GetWordRect(self:  self);
            UnityEngine.Vector2 val_6 = val_5.m_XMin.center;
            UnityEngine.Vector2 val_7 = val_5.m_XMin.size;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, d:  rectScale);
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, d:  2f);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            UnityEngine.Vector2 val_11 = val_5.m_XMin.size;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, d:  rectScale);
            UnityEngine.Rect val_13 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, size:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            return (bool)val_13.m_XMin.Contains(point:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_16});
        }
    
    }

}
