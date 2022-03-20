using UnityEngine;

namespace Utils.Extensions
{
    public static class RectTransformExtension
    {
        // Methods
        public static UnityEngine.Rect WordRect(UnityEngine.RectTransform self)
        {
            UnityEngine.Rect val_1 = self.rect;
            UnityEngine.Vector2 val_2 = val_1.m_XMin.size;
            UnityEngine.Vector3 val_3 = self.lossyScale;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector3 val_6 = self.position;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, d:  0.5f);
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            UnityEngine.Rect val_10 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, size:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            return new UnityEngine.Rect() {m_XMin = val_10.m_XMin, m_YMin = val_10.m_YMin, m_Width = val_10.m_Width, m_Height = val_10.m_Height};
        }
        public static bool InRect(UnityEngine.RectTransform self, UnityEngine.Vector3 position, bool worldSpace = False, float rectScale = 1.2)
        {
            float val_14;
            float val_15;
            float val_16;
            val_14 = position.z;
            val_15 = position.y;
            val_16 = position.x;
            if(worldSpace != true)
            {
                    UnityEngine.Vector3 val_2 = Utils.Extensions.CameraExtension.ScreenToWorldPointExt(camera:  UnityEngine.Camera.main, pointPosition:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_14});
                val_16 = val_2.x;
                val_15 = val_2.y;
                val_14 = val_2.z;
            }
            
            UnityEngine.Rect val_3 = Utils.Extensions.RectTransformExtension.WordRect(self:  self);
            UnityEngine.Vector2 val_4 = val_3.m_XMin.center;
            UnityEngine.Vector2 val_5 = val_3.m_XMin.size;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, d:  rectScale);
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  2f);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector2 val_9 = val_3.m_XMin.size;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, d:  rectScale);
            UnityEngine.Rect val_11 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, size:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            return (bool)val_11.m_XMin.Contains(point:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_14});
        }
        public static bool InRect(UnityEngine.Transform self, UnityEngine.Vector3 position, bool worldSpace = False)
        {
            if(self == null)
            {
                    return Utils.Extensions.RectTransformExtension.InRect(self:  self, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, worldSpace:  worldSpace, rectScale:  1.2f);
            }
            
            if(null == null)
            {
                    return Utils.Extensions.RectTransformExtension.InRect(self:  self, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, worldSpace:  worldSpace, rectScale:  1.2f);
            }
        
        }
        public static UnityEngine.Rect GetScreenRect(UnityEngine.RectTransform self, UnityEngine.Canvas canvas)
        {
            var val_15;
            UnityEngine.Object val_25;
            UnityEngine.Camera val_30;
            UnityEngine.Vector3 val_31;
            UnityEngine.Vector3 val_32;
            UnityEngine.Vector3 val_33;
            var val_34;
            float val_35;
            var val_37;
            float val_38;
            var val_40;
            float val_41;
            var val_43;
            float val_44;
            val_25 = canvas;
            if(val_25 == 0)
            {
                    val_25 = self.GetComponentInParent<UnityEngine.Canvas>();
                UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[4];
            }
            else
            {
                    UnityEngine.Vector3[] val_4 = new UnityEngine.Vector3[4];
            }
            
            self.GetWorldCorners(fourCornersArray:  val_4);
            if(val_25.renderMode != 1)
            {
                    if(val_25.renderMode != 2)
            {
                goto label_9;
            }
            
            }
            
            UnityEngine.Vector2 val_8 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  val_25.worldCamera, worldPoint:  new UnityEngine.Vector3() {x = val_4[0], y = val_4[0], z = val_4[1]});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            val_4[1] = val_9;
            val_4[2] = val_9.y;
            val_4[2] = val_9.z;
            UnityEngine.Camera val_10 = val_25.worldCamera;
            val_31 = val_4[3];
            val_32 = val_4[3];
            val_33 = val_4[4];
            goto label_18;
            label_9:
            UnityEngine.Vector2 val_11 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  0, worldPoint:  new UnityEngine.Vector3() {x = val_4[0], y = val_4[0], z = val_4[1]});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_4[1] = val_12;
            val_4[2] = val_12.y;
            val_4[2] = val_12.z;
            val_31 = val_4[3];
            val_32 = val_4[3];
            val_33 = val_4[4];
            val_30 = 0;
            label_18:
            UnityEngine.Vector2 val_13 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  val_30, worldPoint:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_33});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            val_4[4] = val_14;
            val_4[5] = val_14.y;
            val_4[5] = val_14.z;
            UnityEngine.Vector3 val_31 = val_4[1];
            if(val_31 >= 0f)
            {
                goto label_31;
            }
            
            if((double)val_31 != (-0.5))
            {
                goto label_32;
            }
            
            val_34 = val_15;
            val_35 = -1f;
            goto label_33;
            label_31:
            if((double)val_31 != 0.5)
            {
                goto label_34;
            }
            
            val_34 = val_15;
            val_35 = 1f;
            label_33:
            float val_32 = (float)val_34;
            val_35 = val_32 + val_35;
            val_32 = (((long)val_34 & 1) != 0) ? (val_32) : (val_35);
            goto label_36;
            label_32:
            float val_33 = -0.5f;
            val_33 = val_31 + val_33;
            goto label_36;
            label_34:
            float val_34 = 0.5f;
            val_34 = val_31 + val_34;
            label_36:
            UnityEngine.Vector3 val_35 = val_4[2];
            val_4[1] = val_34;
            if(val_35 >= 0f)
            {
                goto label_38;
            }
            
            if((double)val_35 != (-0.5))
            {
                goto label_39;
            }
            
            val_37 = val_15;
            val_38 = -1f;
            goto label_40;
            label_38:
            if((double)val_35 != 0.5)
            {
                goto label_41;
            }
            
            val_37 = val_15;
            val_38 = 1f;
            label_40:
            float val_36 = (float)val_37;
            val_38 = val_36 + val_38;
            val_36 = (((long)val_37 & 1) != 0) ? (val_36) : (val_38);
            goto label_43;
            label_39:
            float val_37 = -0.5f;
            val_37 = val_35 + val_37;
            goto label_43;
            label_41:
            float val_38 = 0.5f;
            val_38 = val_35 + val_38;
            label_43:
            val_4[2] = val_38;
            UnityEngine.Vector3 val_39 = val_4[4];
            if(val_39 >= 0f)
            {
                goto label_46;
            }
            
            if((double)val_39 != (-0.5))
            {
                goto label_47;
            }
            
            val_40 = val_15;
            val_41 = -1f;
            goto label_48;
            label_46:
            if((double)val_39 != 0.5)
            {
                goto label_49;
            }
            
            val_40 = val_15;
            val_41 = 1f;
            label_48:
            float val_40 = (float)val_40;
            val_41 = val_40 + val_41;
            val_40 = (((long)val_40 & 1) != 0) ? (val_40) : (val_41);
            goto label_51;
            label_47:
            float val_41 = -0.5f;
            val_41 = val_39 + val_41;
            goto label_51;
            label_49:
            float val_42 = 0.5f;
            val_42 = val_39 + val_42;
            label_51:
            UnityEngine.Vector3 val_43 = val_4[5];
            val_4[4] = val_42;
            if(val_43 >= 0f)
            {
                goto label_53;
            }
            
            if((double)val_43 != (-0.5))
            {
                goto label_54;
            }
            
            val_43 = val_15;
            val_44 = -1f;
            goto label_55;
            label_53:
            if((double)val_43 != 0.5)
            {
                goto label_56;
            }
            
            val_43 = val_15;
            val_44 = 1f;
            label_55:
            val_44 = (float)val_43 + val_44;
            var val_16 = (((long)val_43 & 1) != 0) ? ((float)val_43) : (val_44);
            goto label_58;
            label_54:
            float val_44 = -0.5f;
            val_44 = val_43 + val_44;
            goto label_58;
            label_56:
            float val_45 = 0.5f;
            val_45 = val_43 + val_45;
            label_58:
            val_4[5] = val_14.z;
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Min(a:  val_4[1], b:  val_4[4]), y:  UnityEngine.Mathf.Min(a:  val_4[2], b:  val_4[5]));
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Max(a:  val_4[1], b:  val_4[4]), y:  UnityEngine.Mathf.Max(a:  val_4[2], b:  val_4[5]));
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Rect val_24 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, size:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
            return new UnityEngine.Rect() {m_XMin = val_24.m_XMin, m_YMin = val_24.m_YMin, m_Width = val_24.m_Width, m_Height = val_24.m_Height};
        }
        public static UnityEngine.Vector3 GetCenterPosition(UnityEngine.Transform tf)
        {
            UnityEngine.RectTransform val_2;
            if(tf != null)
            {
                    var val_1 = (null == null) ? tf : 0;
                return Utils.Extensions.RectTransformExtension.GetCenterPosition(transform:  val_2 = 0);
            }
            
            return Utils.Extensions.RectTransformExtension.GetCenterPosition(transform:  val_2);
        }
        public static UnityEngine.Vector3 GetCenterPosition(UnityEngine.RectTransform transform)
        {
            UnityEngine.Vector3 val_1 = transform.position;
            UnityEngine.Vector2 val_2 = transform.sizeDelta;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            float val_10 = val_3.x;
            float val_11 = val_3.y;
            UnityEngine.Vector2 val_4 = transform.pivot;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector3 val_6 = transform.lossyScale;
            val_6.x = val_10 * val_6.x;
            val_10 = (0.5f - val_5.x) * val_6.x;
            val_11 = (0.5f - val_5.y) * (val_11 * val_6.y);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = 0f});
        }
    
    }

}
