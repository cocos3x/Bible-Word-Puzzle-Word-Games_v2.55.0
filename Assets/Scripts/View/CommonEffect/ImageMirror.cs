using UnityEngine;

namespace View.CommonEffect
{
    public sealed class ImageMirror : BaseMeshEffect, ILayoutElement
    {
        // Fields
        private View.CommonEffect.ImageMirror.MirrorModeType mirrorMode;
        private readonly System.Collections.Generic.List<UnityEngine.UIVertex> _meshCacheList;
        
        // Properties
        public View.CommonEffect.ImageMirror.MirrorModeType MirrorMode { get; set; }
        public float flexibleHeight { get; }
        public float flexibleWidth { get; }
        public int layoutPriority { get; }
        public float minHeight { get; }
        public float minWidth { get; }
        public float preferredHeight { get; }
        public float preferredWidth { get; }
        
        // Methods
        public View.CommonEffect.ImageMirror.MirrorModeType get_MirrorMode()
        {
            return (MirrorModeType)this.mirrorMode;
        }
        public void set_MirrorMode(View.CommonEffect.ImageMirror.MirrorModeType value)
        {
            if(this.mirrorMode == value)
            {
                    return;
            }
            
            this.mirrorMode = value;
            if(this.graphic == null)
            {
                    return;
            }
            
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2F0;
        }
        public float get_flexibleHeight()
        {
            return -1f;
        }
        public float get_flexibleWidth()
        {
            return -1f;
        }
        public int get_layoutPriority()
        {
            return 0;
        }
        public float get_minHeight()
        {
            return 0f;
        }
        public float get_minWidth()
        {
            return 0f;
        }
        public float get_preferredHeight()
        {
            var val_7;
            var val_8;
            val_7 = this;
            UnityEngine.UI.Graphic val_1 = this.graphic;
            val_8 = 0;
            if( == 0)
            {
                    return (float)(val_7 < 2) ? (S0 + S0) : (S0);
            }
            
            val_7 = this.mirrorMode - 1;
            return (float)(val_7 < 2) ? (S0 + S0) : (S0);
        }
        public float get_preferredWidth()
        {
            var val_4;
            UnityEngine.UI.Graphic val_1 = this.graphic;
            val_4 = 0;
            float val_5 = 0f;
            if( == 0)
            {
                    return (float)val_5;
            }
            
            MirrorModeType val_4 = this.mirrorMode;
            val_4 = val_4 | 2;
            if(val_4 == 2)
            {
                    val_5 = val_5 + val_5;
                return (float)val_5;
            }
        
        }
        public void SetNativeSize()
        {
            var val_20;
            float val_21;
            UnityEngine.UI.Graphic val_1 = this.graphic;
            val_20 = 0;
            if( == 0)
            {
                    return;
            }
            
            UnityEngine.Sprite val_4 = overrideSprite;
            if(val_4 == 0)
            {
                    return;
            }
            
            UnityEngine.Rect val_6 = val_4.rect;
            float val_18 = pixelsPerUnit;
            UnityEngine.Rect val_9 = val_4.rect;
            UnityEngine.Transform val_12 = this.transform;
            val_18 = val_6.m_XMin.width / val_18;
            float val_13 = val_9.m_XMin.height / pixelsPerUnit;
            UnityEngine.Vector2 val_14 = val_12.anchorMin;
            val_12.anchorMax = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            if(this.mirrorMode == 0)
            {
                goto label_14;
            }
            
            if(this.mirrorMode == 1)
            {
                goto label_15;
            }
            
            if(this.mirrorMode != 2)
            {
                    return;
            }
            
            float val_15 = val_18 + val_18;
            val_21 = val_13 + val_13;
            goto label_18;
            label_15:
            val_21 = val_13 + val_13;
            goto label_18;
            label_14:
            val_21 = val_13;
            label_18:
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_18 + val_18, y:  val_21);
            val_12.sizeDelta = new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
        }
        public void CalculateLayoutInputHorizontal()
        {
        
        }
        public void CalculateLayoutInputVertical()
        {
        
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            if(this.IsActive() == false)
            {
                    return;
            }
            
            if(vh.currentVertCount < 1)
            {
                    return;
            }
            
            this._meshCacheList.Clear();
            vh.GetUIVertexStream(stream:  this._meshCacheList);
            System.Collections.Generic.List<UnityEngine.UIVertex> val_3 = this.Modify(verts:  this._meshCacheList);
            if(val_3 == null)
            {
                    return;
            }
            
            vh.Clear();
            vh.AddUIVertexTriangleStream(verts:  val_3);
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.graphic == null)
            {
                    return;
            }
            
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2F0;
        }
        private static float GetCenter(float p1, float p2, float p3)
        {
            float val_4 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  p1, b:  p2), b:  p3);
            val_4 = (UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Max(a:  p1, b:  p2), b:  p3)) + val_4;
            val_4 = val_4 * 0.5f;
            return (float)val_4;
        }
        private static UnityEngine.Vector2 GetOverturnUV(UnityEngine.Vector2 uv, float start, float end, bool isHorizontal = True)
        {
            float val_1 = end - uv.x;
            end = end - uv.y;
            val_1 = val_1 + start;
            start = end + start;
            uv.x = (isHorizontal != true) ? (val_1) : uv.x;
            uv.y = (isHorizontal != true) ? uv.y : (start);
            return new UnityEngine.Vector2() {x = uv.x, y = uv.y};
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> Modify(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            var val_4;
            UnityEngine.UI.Graphic val_1 = this.graphic;
            val_4 = 0;
            if( != 0)
            {
                    return this.ModifySimple(verts:  verts);
            }
            
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySimple(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            if(this.mirrorMode > 4)
            {
                    return 0;
            }
            
            var val_1 = 15720548 + (this.mirrorMode) << 2;
            val_1 = val_1 + 15720548;
            goto (15720548 + (this.mirrorMode) << 2 + 15720548);
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySimpleHorizontal(System.Collections.Generic.List<UnityEngine.UIVertex> verts, bool inverse)
        {
            var val_5;
            var val_7;
            var val_8;
            val_5 = this;
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            if(21061632 < 1)
            {
                goto label_3;
            }
            
            val_7 = 0;
            val_5 = 0;
            val_8 = 21061632;
            goto label_4;
            label_6:
            val_5 = 1;
            val_7 = 76;
            label_4:
            if(val_5 >= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_3 = val_2.m_XMin.x;
            val_3 = 0f + val_3;
            val_3 = val_3 * 0.5f;
            verts.set_Item(index:  1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_3, y = 1.401298E-45f, z = 0f}, normal = new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 4.203895E-44f}, tangent = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2() {x = 2.073189E-38f, y = 0f}, uv1 = new UnityEngine.Vector2() {x = 2.07319E-38f, y = 0f}, uv2 = new UnityEngine.Vector2() {x = 2.073238E-38f, y = 0f}, uv3 = new UnityEngine.Vector2() {x = 2.073275E-38f, y = 0f}});
            if(21061631 != val_5)
            {
                goto label_6;
            }
            
            label_3:
            View.CommonEffect.ListExtension.Reserve<UnityEngine.UIVertex>(array:  verts, capacity:  42123264);
            if(inverse != false)
            {
                    verts.MirrorVertsHorizontalInverse(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
                return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
            }
            
            verts.MirrorVertsHorizontal(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySimpleVertical(System.Collections.Generic.List<UnityEngine.UIVertex> verts, bool inverse)
        {
            var val_7;
            var val_9;
            var val_10;
            val_7 = this;
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            if(21061632 < 1)
            {
                goto label_3;
            }
            
            val_9 = 0;
            val_7 = 0;
            val_10 = 21061632;
            goto label_4;
            label_6:
            val_7 = 1;
            val_9 = 76;
            label_4:
            if(val_7 >= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_5 = val_2.m_XMin.y;
            val_5 = (1.401298E-45f) + val_5;
            val_5 = val_5 * 0.5f;
            val_5 = (val_2.m_XMin.height * 0.5f) + val_5;
            verts.set_Item(index:  1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = 0f, y = val_5, z = 0f}, normal = new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 4.203895E-44f}, tangent = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2() {x = 2.073189E-38f, y = 0f}, uv1 = new UnityEngine.Vector2() {x = 2.07319E-38f, y = 0f}, uv2 = new UnityEngine.Vector2() {x = 2.073238E-38f, y = 0f}, uv3 = new UnityEngine.Vector2() {x = 2.073275E-38f, y = 0f}});
            if(21061631 != val_7)
            {
                goto label_6;
            }
            
            label_3:
            View.CommonEffect.ListExtension.Reserve<UnityEngine.UIVertex>(array:  verts, capacity:  42123264);
            if(inverse != false)
            {
                    verts.MirrorVertsVecticalInverse(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
                return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
            }
            
            verts.MirrorVertsVectical(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySimpleQuarter(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            var val_9;
            var val_10;
            var val_11;
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            if(21061632 < 1)
            {
                goto label_3;
            }
            
            val_9 = 0;
            val_10 = 0;
            val_11 = 21061632;
            goto label_4;
            label_6:
            val_10 = 1;
            val_9 = 76;
            label_4:
            if(val_10 >= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_7 = 0f;
            float val_5 = val_2.m_XMin.x;
            val_5 = val_7 + val_5;
            val_7 = val_5 * 0.5f;
            float val_6 = val_2.m_XMin.y;
            val_6 = (1.401298E-45f) + val_6;
            val_6 = val_6 * 0.5f;
            val_6 = (val_2.m_XMin.height * 0.5f) + val_6;
            verts.set_Item(index:  1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_7, y = val_6, z = 0f}, normal = new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 4.203895E-44f}, tangent = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2() {x = 2.073189E-38f, y = 0f}, uv1 = new UnityEngine.Vector2() {x = 2.07319E-38f, y = 0f}, uv2 = new UnityEngine.Vector2() {x = 2.073238E-38f, y = 0f}, uv3 = new UnityEngine.Vector2() {x = 2.073275E-38f, y = 0f}});
            if(21061631 != val_10)
            {
                goto label_6;
            }
            
            label_3:
            View.CommonEffect.ListExtension.Reserve<UnityEngine.UIVertex>(array:  verts, capacity:  84246528);
            verts.MirrorVertsHorizontal(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            verts.MirrorVertsVectical(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySliced(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            this.SlicedScale(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts, count:  verts);
            if(this.mirrorMode > 4)
            {
                    return 0;
            }
            
            var val_13 = 15720568 + (this.mirrorMode) << 2;
            val_13 = val_13 + 15720568;
            goto (15720568 + (this.mirrorMode) << 2 + 15720568);
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySlicedHorizontal(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts, bool inverse)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = this;
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            float val_7 = val_2.m_XMin.width;
            if(21061632 < 1)
            {
                goto label_3;
            }
            
            float val_6 = 0.5f;
            val_6 = val_7 * val_6;
            val_8 = 0;
            val_7 = 0;
            val_7 = val_2.m_XMin.x + val_6;
            val_9 = 21061632;
            goto label_4;
            label_6:
            val_7 = 1;
            val_8 = 76;
            label_4:
            if(val_7 >= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            verts.set_Item(index:  1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (0f >= val_7) ? (val_7) : 0f, y = 1.401298E-45f, z = 0f}, normal = new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 4.203895E-44f}, tangent = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2() {x = 2.073189E-38f, y = 0f}, uv1 = new UnityEngine.Vector2() {x = 2.07319E-38f, y = 0f}, uv2 = new UnityEngine.Vector2() {x = 2.073238E-38f, y = 0f}, uv3 = new UnityEngine.Vector2() {x = 2.073275E-38f, y = 0f}});
            if(21061631 != val_7)
            {
                goto label_6;
            }
            
            label_3:
            verts.SliceExcludeVerts(verts:  verts);
            View.CommonEffect.ListExtension.Reserve<UnityEngine.UIVertex>(array:  verts, capacity:  42123264);
            if(inverse != false)
            {
                    verts.MirrorVertsHorizontalInverse(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
                return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
            }
            
            verts.MirrorVertsHorizontal(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySlicedVertical(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts, bool inverse)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = this;
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            float val_7 = val_2.m_XMin.height;
            if(21061632 < 1)
            {
                goto label_3;
            }
            
            float val_6 = 0.5f;
            val_6 = val_7 * val_6;
            val_8 = 0;
            val_7 = 0;
            val_7 = val_2.m_XMin.y + val_6;
            val_9 = 21061632;
            goto label_4;
            label_6:
            val_7 = 1;
            val_8 = 76;
            label_4:
            if(val_7 >= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            verts.set_Item(index:  1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = 0f, y = ((1.401298E-45f) <= val_7) ? (val_7) : 1.401298E-45f, z = 0f}, normal = new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 4.203895E-44f}, tangent = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2() {x = 2.073189E-38f, y = 0f}, uv1 = new UnityEngine.Vector2() {x = 2.07319E-38f, y = 0f}, uv2 = new UnityEngine.Vector2() {x = 2.073238E-38f, y = 0f}, uv3 = new UnityEngine.Vector2() {x = 2.073275E-38f, y = 0f}});
            if(21061631 != val_7)
            {
                goto label_6;
            }
            
            label_3:
            verts.SliceExcludeVerts(verts:  verts);
            View.CommonEffect.ListExtension.Reserve<UnityEngine.UIVertex>(array:  verts, capacity:  42123264);
            if(inverse != false)
            {
                    verts.MirrorVertsVecticalInverse(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
                return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
            }
            
            verts.MirrorVertsVectical(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifySlicedQuarter(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            float val_11;
            var val_12;
            var val_13;
            var val_14;
            UnityEngine.Rect val_2 = this.graphic.GetPixelAdjustedRect();
            val_11 = val_2.m_XMin.width;
            float val_11 = val_2.m_XMin.height;
            if(21061632 < 1)
            {
                goto label_3;
            }
            
            float val_10 = 0.5f;
            val_10 = val_11 * val_10;
            val_12 = 0;
            val_13 = 0;
            val_11 = (val_11 * val_10) + val_2.m_XMin.x;
            val_11 = val_10 + val_2.m_XMin.y;
            val_14 = 21061632;
            goto label_4;
            label_6:
            val_13 = 1;
            val_12 = 76;
            label_4:
            if(val_13 >= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            verts.set_Item(index:  1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (0f >= val_11) ? (val_11) : 0f, y = ((1.401298E-45f) <= val_11) ? (val_11) : 1.401298E-45f, z = 0f}, normal = new UnityEngine.Vector3() {x = 0f, y = 1.401298E-45f, z = 4.203895E-44f}, tangent = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2() {x = 2.073189E-38f, y = 0f}, uv1 = new UnityEngine.Vector2() {x = 2.07319E-38f, y = 0f}, uv2 = new UnityEngine.Vector2() {x = 2.073238E-38f, y = 0f}, uv3 = new UnityEngine.Vector2() {x = 2.073275E-38f, y = 0f}});
            if(21061631 != val_13)
            {
                goto label_6;
            }
            
            label_3:
            verts.SliceExcludeVerts(verts:  verts);
            View.CommonEffect.ListExtension.Reserve<UnityEngine.UIVertex>(array:  verts, capacity:  42123264);
            verts.MirrorVertsHorizontal(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            verts.MirrorVertsVectical(rect:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, verts:  verts);
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)verts;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifyTiled(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            if(this.mirrorMode == 2)
            {
                    return this.ModifyTiledQuarter(image:  image, verts:  verts);
            }
            
            if(this.mirrorMode == 1)
            {
                    return this.ModifyTiledVertical(image:  image, verts:  verts);
            }
            
            if(this.mirrorMode != 0)
            {
                    return 0;
            }
            
            return this.ModifyTiledHorizontal(image:  image, verts:  verts);
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifyTiledHorizontal(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            int val_16;
            float val_17;
            var val_18;
            float val_19;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            float val_27;
            float val_28;
            float val_29;
            val_16 = this;
            UnityEngine.Sprite val_1 = image.overrideSprite;
            bool val_19 = UnityEngine.Object.op_Equality(x:  val_1, y:  0);
            val_18 = 0;
            if(val_19 == true)
            {
                    return (System.Collections.Generic.List<UnityEngine.UIVertex>)val_18;
            }
            
            UnityEngine.Rect val_4 = this.graphic.GetPixelAdjustedRect();
            UnityEngine.Vector4 val_5 = UnityEngine.Sprites.DataUtility.GetInnerUV(sprite:  val_1);
            UnityEngine.Rect val_6 = val_1.rect;
            val_19 = val_6.m_XMin.width;
            float val_8 = image.pixelsPerUnit;
            if(val_19 < true)
            {
                goto label_8;
            }
            
            val_21 = 0;
            val_22 = 0;
            val_8 = val_19 / val_8;
            val_23 = 76;
            val_24 = -1;
            goto label_9;
            label_17:
            val_22 = 12884901888;
            val_21 = 3;
            val_24 = -2;
            val_23 = 76;
            label_9:
            if(val_21 < val_19)
            {
                    val_25 = val_19;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = 0;
            val_16 = val_21 + 1;
            val_16 = val_19 + (val_16 * 76);
            val_19 = mem[(0 * 76) + val_2 + 32];
            val_19 = (0 * 76) + val_2 + 32;
            val_27 = mem[(0 * 76) + val_2 + 76];
            val_27 = (0 * 76) + val_2 + 76;
            if(val_24 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = 4294967296;
            val_17 = val_22 + val_17;
            val_17 = val_17 >> 32;
            val_17 = val_19 + (val_17 * 76);
            int val_9 = val_21 + 2;
            val_28 = mem[(((val_22 + 4294967296) >> 32) * 76) + val_2 + 76];
            val_28 = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 76;
            if(val_24 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = 8589934592;
            val_18 = val_22 + val_18;
            val_18 = val_18 >> 32;
            val_19 = val_19 + (val_18 * 76);
            val_17 = mem[(((val_22 + 8589934592) >> 32) * 76) + val_2 + 36];
            val_17 = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 36;
            val_29 = mem[(((val_22 + 8589934592) >> 32) * 76) + val_2 + 76];
            val_29 = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 76;
            float val_11 = val_4.m_XMin.xMin;
            val_11 = (View.CommonEffect.ImageMirror.GetCenter(p1:  val_19, p2:  (((val_22 + 4294967296) >> 32) * 76) + val_2 + 32, p3:  (((val_22 + 8589934592) >> 32) * 76) + val_2 + 32)) - val_11;
            val_11 = val_11 / val_8;
            int val_12 = UnityEngine.Mathf.FloorToInt(f:  val_11);
            var val_13 = (val_12 < 0) ? (val_12 + 1) : (val_12);
            val_13 = val_13 & 4294967294;
            val_13 = val_12 - val_13;
            if(val_13 == 1)
            {
                    float val_20 = val_5.z;
                val_20 = val_20 - val_29;
                val_27 = val_5.x + (val_20 - val_27);
                val_28 = val_5.x + (val_20 - val_28);
                val_29 = val_5.x + val_20;
            }
            
            verts.set_Item(index:  3, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_19, y = (0 * 76) + val_2 + 36, z = (0 * 76) + val_2 + 36}, normal = new UnityEngine.Vector3() {x = (0 * 76) + val_2 + 44, y = (0 * 76) + val_2 + 44, z = (0 * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (0 * 76) + val_2 + 44, y = (0 * 76) + val_2 + 60, z = (0 * 76) + val_2 + 60, w = (0 * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (0 * 76) + val_2 + 60, g = (0 * 76) + val_2 + 60, b = (0 * 76) + val_2 + 60, a = (0 * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = val_27, y = (0 * 76) + val_2 + 80}, uv1 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 84, y = (0 * 76) + val_2 + 84}, uv2 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 84, y = (0 * 76) + val_2 + 84}, uv3 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 100, y = (0 * 76) + val_2 + 100}});
            verts.set_Item(index:  val_16, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 32, y = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 36, z = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 36}, normal = new UnityEngine.Vector3() {x = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 44, y = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 44, z = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 44, y = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60, z = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60, w = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60, g = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60, b = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60, a = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = val_28, y = (((val_22 + 4294967296) >> 32) * 76) + val_2 + 80}});
            verts.set_Item(index:  val_9, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 32, y = val_17, z = val_17}, normal = new UnityEngine.Vector3() {x = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 44, y = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 44, z = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 44, y = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60, z = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60, w = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60, g = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60, b = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60, a = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = val_29, y = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 80}, uv1 = new UnityEngine.Vector2() {x = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 84, y = (((val_22 + 8589934592) >> 32) * 76) + val_2 + 84}});
            if(val_24 != 0)
            {
                goto label_17;
            }
            
            label_8:
            val_18 = verts;
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)val_18;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifyTiledVertical(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            int val_16;
            var val_17;
            float val_18;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            float val_26;
            float val_27;
            float val_28;
            val_16 = this;
            UnityEngine.Sprite val_1 = image.overrideSprite;
            bool val_19 = UnityEngine.Object.op_Equality(x:  val_1, y:  0);
            val_17 = 0;
            if(val_19 == true)
            {
                    return (System.Collections.Generic.List<UnityEngine.UIVertex>)val_17;
            }
            
            UnityEngine.Rect val_4 = this.graphic.GetPixelAdjustedRect();
            UnityEngine.Vector4 val_5 = UnityEngine.Sprites.DataUtility.GetInnerUV(sprite:  val_1);
            UnityEngine.Rect val_6 = val_1.rect;
            val_18 = val_6.m_XMin.height;
            float val_8 = image.pixelsPerUnit;
            if(val_19 < true)
            {
                goto label_8;
            }
            
            val_20 = 0;
            val_21 = 0;
            val_8 = val_18 / val_8;
            val_22 = 76;
            val_23 = -1;
            goto label_9;
            label_17:
            val_21 = 12884901888;
            val_20 = 3;
            val_23 = -2;
            val_22 = 76;
            label_9:
            if(val_20 < val_19)
            {
                    val_24 = val_19;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = 0;
            val_16 = val_20 + 1;
            val_16 = val_19 + (val_16 * 76);
            val_18 = mem[(0 * 76) + val_2 + 36];
            val_18 = (0 * 76) + val_2 + 36;
            val_26 = mem[(0 * 76) + val_2 + 80];
            val_26 = (0 * 76) + val_2 + 80;
            if(val_23 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = 4294967296;
            val_17 = val_21 + val_17;
            val_17 = val_17 >> 32;
            val_17 = val_19 + (val_17 * 76);
            val_27 = mem[(((val_21 + 4294967296) >> 32) * 76) + val_2 + 80];
            val_27 = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 80;
            int val_9 = val_20 + 2;
            if(val_23 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = 8589934592;
            val_18 = val_21 + val_18;
            val_18 = val_18 >> 32;
            val_19 = val_19 + (val_18 * 76);
            val_28 = mem[(((val_21 + 8589934592) >> 32) * 76) + val_2 + 80];
            val_28 = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 80;
            float val_11 = val_4.m_XMin.yMin;
            val_11 = (View.CommonEffect.ImageMirror.GetCenter(p1:  val_18, p2:  (((val_21 + 4294967296) >> 32) * 76) + val_2 + 36, p3:  (((val_21 + 8589934592) >> 32) * 76) + val_2 + 36)) - val_11;
            val_11 = val_11 / val_8;
            int val_12 = UnityEngine.Mathf.FloorToInt(f:  val_11);
            var val_13 = (val_12 < 0) ? (val_12 + 1) : (val_12);
            val_13 = val_13 & 4294967294;
            val_13 = val_12 - val_13;
            if(val_13 == 1)
            {
                    float val_20 = val_5.w;
                val_20 = val_20 - val_28;
                val_26 = val_5.y + (val_20 - val_26);
                val_27 = val_5.y + (val_20 - val_27);
                val_28 = val_5.y + val_20;
            }
            
            verts.set_Item(index:  3, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (0 * 76) + val_2 + 32, y = val_18, z = (0 * 76) + val_2 + 40}, normal = new UnityEngine.Vector3() {x = (0 * 76) + val_2 + 44, y = (0 * 76) + val_2 + 44, z = (0 * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (0 * 76) + val_2 + 44, y = (0 * 76) + val_2 + 60, z = (0 * 76) + val_2 + 60, w = (0 * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (0 * 76) + val_2 + 60, g = (0 * 76) + val_2 + 60, b = (0 * 76) + val_2 + 60, a = (0 * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 76, y = val_26}, uv1 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 84, y = (0 * 76) + val_2 + 84}, uv2 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 84, y = (0 * 76) + val_2 + 84}, uv3 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 100, y = (0 * 76) + val_2 + 100}});
            verts.set_Item(index:  val_16, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 32, y = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 36, z = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 40}, normal = new UnityEngine.Vector3() {x = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 44, y = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 44, z = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 44, y = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60, z = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60, w = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60, g = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60, b = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60, a = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = (((val_21 + 4294967296) >> 32) * 76) + val_2 + 76, y = val_27}});
            verts.set_Item(index:  val_9, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 32, y = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 36, z = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 40}, normal = new UnityEngine.Vector3() {x = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 44, y = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 44, z = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 44, y = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60, z = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60, w = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60, g = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60, b = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60, a = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = (((val_21 + 8589934592) >> 32) * 76) + val_2 + 76, y = val_28}});
            if(val_23 != 0)
            {
                goto label_17;
            }
            
            label_8:
            val_17 = verts;
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)val_17;
        }
        private System.Collections.Generic.List<UnityEngine.UIVertex> ModifyTiledQuarter(UnityEngine.UI.Image image, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            UnityEngine.Object val_27;
            var val_28;
            float val_29;
            float val_30;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            val_27 = image.overrideSprite;
            bool val_25 = UnityEngine.Object.op_Equality(x:  val_27, y:  0);
            val_28 = 0;
            if(val_25 == true)
            {
                    return (System.Collections.Generic.List<UnityEngine.UIVertex>)val_28;
            }
            
            UnityEngine.Rect val_4 = this.graphic.GetPixelAdjustedRect();
            UnityEngine.Vector4 val_5 = UnityEngine.Sprites.DataUtility.GetInnerUV(sprite:  val_27);
            UnityEngine.Rect val_6 = val_27.rect;
            val_29 = val_6.m_XMin.width;
            UnityEngine.Rect val_9 = val_27.rect;
            val_30 = val_9.m_XMin.height;
            float val_11 = image.pixelsPerUnit;
            if(val_25 < true)
            {
                goto label_8;
            }
            
            val_32 = 0;
            val_33 = 0;
            val_11 = val_30 / val_11;
            val_34 = 76;
            val_35 = -1;
            goto label_9;
            label_22:
            val_33 = 12884901888;
            val_32 = 3;
            val_35 = -2;
            val_34 = 76;
            label_9:
            if(val_32 < val_25)
            {
                    val_36 = val_25;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = 0;
            val_27 = val_32 + 1;
            val_22 = val_25 + (val_22 * 76);
            val_38 = mem[(0 * 76) + val_2 + 76];
            val_38 = (0 * 76) + val_2 + 76;
            if(val_35 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_23 = 4294967296;
            val_23 = val_33 + val_23;
            val_23 = val_23 >> 32;
            val_23 = val_25 + (val_23 * 76);
            int val_13 = val_32 + 2;
            if(val_35 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_24 = 8589934592;
            val_24 = val_33 + val_24;
            val_24 = val_24 >> 32;
            val_25 = val_25 + (val_24 * 76);
            val_39 = mem[(((val_33 + 8589934592) >> 32) * 76) + val_2 + 76];
            val_39 = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 76;
            val_29 = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 32;
            float val_16 = val_4.m_XMin.xMin;
            val_16 = (View.CommonEffect.ImageMirror.GetCenter(p1:  (0 * 76) + val_2 + 32, p2:  (((val_33 + 4294967296) >> 32) * 76) + val_2 + 32, p3:  (((val_33 + 8589934592) >> 32) * 76) + val_2 + 32)) - val_16;
            val_40 = val_16 / (val_29 / image.pixelsPerUnit);
            int val_17 = UnityEngine.Mathf.FloorToInt(f:  val_40);
            var val_18 = (val_17 < 0) ? (val_17 + 1) : (val_17);
            val_18 = val_18 & 4294967294;
            val_18 = val_17 - val_18;
            if(val_18 == 1)
            {
                    float val_27 = val_5.z;
                float val_26 = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 76;
                val_40 = val_27 - val_38;
                val_26 = val_27 - val_26;
                val_27 = val_27 - val_39;
                val_38 = val_5.x + val_40;
                val_41 = val_5.x + val_26;
                val_39 = val_5.x + val_27;
            }
            else
            {
                    val_41 = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 76;
            }
            
            float val_19 = val_4.m_XMin.yMin;
            val_19 = (View.CommonEffect.ImageMirror.GetCenter(p1:  (0 * 76) + val_2 + 32 + 4, p2:  (((val_33 + 4294967296) >> 32) * 76) + val_2 + 32 + 4, p3:  (((val_33 + 8589934592) >> 32) * 76) + val_2 + 32 + 4)) - val_19;
            val_19 = val_19 / val_11;
            int val_20 = UnityEngine.Mathf.FloorToInt(f:  val_19);
            var val_21 = (val_20 < 0) ? (val_20 + 1) : (val_20);
            val_21 = val_21 & 4294967294;
            val_21 = val_20 - val_21;
            if(val_21 == 1)
            {
                    float val_30 = val_5.w;
                float val_28 = (0 * 76) + val_2 + 76 + 4;
                float val_29 = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 80;
                val_42 = (0 * 76) + val_2 + 40;
                val_28 = val_30 - val_28;
                val_29 = val_30 - val_29;
                val_30 = val_30 - ((((val_33 + 8589934592) >> 32) * 76) + val_2 + 76 + 4);
                val_43 = val_5.y + val_28;
                val_44 = (0 * 76) + val_2 + 32;
                val_30 = val_5.y + val_29;
                val_45 = val_5.y + val_30;
            }
            else
            {
                    val_44 = (0 * 76) + val_2 + 32;
                val_43 = (0 * 76) + val_2 + 76 + 4;
                val_30 = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 80;
                val_45 = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 76 + 4;
                val_42 = (0 * 76) + val_2 + 40;
            }
            
            verts.set_Item(index:  3, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_44, y = (0 * 76) + val_2 + 32 + 4, z = val_42}, normal = new UnityEngine.Vector3() {x = (0 * 76) + val_2 + 44, y = (0 * 76) + val_2 + 44, z = (0 * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (0 * 76) + val_2 + 44, y = (0 * 76) + val_2 + 60, z = (0 * 76) + val_2 + 60, w = (0 * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (0 * 76) + val_2 + 60, g = (0 * 76) + val_2 + 60, b = (0 * 76) + val_2 + 60, a = (0 * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = val_38, y = val_43}, uv1 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 84, y = (0 * 76) + val_2 + 84}, uv2 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 84, y = (0 * 76) + val_2 + 84}, uv3 = new UnityEngine.Vector2() {x = (0 * 76) + val_2 + 100, y = (0 * 76) + val_2 + 100}});
            verts.set_Item(index:  val_27, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 32, y = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 32 + 4, z = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 40}, normal = new UnityEngine.Vector3() {x = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 44, y = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 44, z = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 44, y = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60, z = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60, w = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60, g = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60, b = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60, a = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = val_41, y = val_30}, uv1 = new UnityEngine.Vector2() {x = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 84, y = (((val_33 + 4294967296) >> 32) * 76) + val_2 + 84}});
            verts.set_Item(index:  val_13, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_29, y = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 32 + 4, z = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 40}, normal = new UnityEngine.Vector3() {x = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 44, y = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 44, z = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 44}, tangent = new UnityEngine.Vector4() {x = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 44, y = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60, z = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60, w = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60}, color = new UnityEngine.Color32() {r = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60, g = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60, b = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60, a = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 60}, uv0 = new UnityEngine.Vector2() {x = val_39, y = val_45}, uv1 = new UnityEngine.Vector2() {x = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 84, y = (((val_33 + 8589934592) >> 32) * 76) + val_2 + 84}});
            if(val_35 != 0)
            {
                goto label_22;
            }
            
            label_8:
            val_28 = verts;
            return (System.Collections.Generic.List<UnityEngine.UIVertex>)val_28;
        }
        private void MirrorVertsHorizontal(UnityEngine.Rect rect, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            var val_4;
            var val_5;
            bool val_2 = true;
            if(val_2 < 1)
            {
                    return;
            }
            
            val_4 = 0;
            val_5 = 0;
            goto label_3;
            label_5:
            val_5 = 1;
            val_4 = 76;
            label_3:
            if(val_5 >= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + val_4;
            UnityEngine.Vector2 val_1 = rect.m_XMin.center;
            val_1.x = val_1.x + val_1.x;
            val_1.x = val_1.x - ((true + val_4) + 32);
            verts.Add(item:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_1.x, y = (true + val_4) + 36, z = (true + val_4) + 36}, normal = new UnityEngine.Vector3() {x = (true + val_4) + 44, y = (true + val_4) + 44, z = (true + val_4) + 44}, tangent = new UnityEngine.Vector4() {x = (true + val_4) + 44, y = (true + val_4) + 60, z = (true + val_4) + 60, w = (true + val_4) + 60}, color = new UnityEngine.Color32() {r = (true + val_4) + 60, g = (true + val_4) + 60, b = (true + val_4) + 60, a = (true + val_4) + 60}, uv0 = new UnityEngine.Vector2() {x = (true + val_4) + 76, y = (true + val_4) + 76}, uv1 = new UnityEngine.Vector2() {x = (true + val_4) + 76, y = (true + val_4) + 76}, uv2 = new UnityEngine.Vector2() {x = (true + val_4) + 92, y = (true + val_4) + 92}, uv3 = new UnityEngine.Vector2() {x = (true + val_4) + 92, y = (true + val_4) + 92}});
            if(0 != val_5)
            {
                goto label_5;
            }
        
        }
        private void MirrorVertsHorizontalInverse(UnityEngine.Rect rect, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            UnityEngine.Vector2 val_1 = rect.m_XMin.center;
            if(21061632 < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            var val_10 = 0;
            do
            {
                if(val_10 >= (-276833504))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_9 = val_3;
                val_9 = (val_1.x + val_1.x) - val_9;
                val_4 = val_7;
                val_5 = val_6;
                verts.Add(item:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_9, z = val_8}, normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, tangent = new UnityEngine.Vector4() {x = val_4, y = val_5, z = val_5, w = val_5}, color = new UnityEngine.Color32() {r = val_5, g = val_5, b = val_5, a = val_5}, uv0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, uv1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, uv2 = new UnityEngine.Vector2() {x = val_5, y = val_5}, uv3 = new UnityEngine.Vector2() {x = val_5, y = val_5}});
                val_10 = val_10 + 1;
                val_11 = val_11 + 76;
            }
            while(21061632 != val_10);
        
        }
        private void MirrorVertsVectical(UnityEngine.Rect rect, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            var val_5;
            var val_6;
            bool val_3 = true;
            if(val_3 < 1)
            {
                    return;
            }
            
            val_5 = 0;
            val_6 = 0;
            goto label_3;
            label_5:
            val_6 = 1;
            val_5 = 76;
            label_3:
            if(val_6 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + val_5;
            UnityEngine.Vector2 val_1 = rect.m_XMin.center;
            float val_2 = val_1.y + val_1.y;
            val_2 = val_2 - ((true + val_5) + 36);
            verts.Add(item:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = (true + val_5) + 32, y = val_2, z = (true + val_5) + 40}, normal = new UnityEngine.Vector3() {x = (true + val_5) + 44, y = (true + val_5) + 44, z = (true + val_5) + 44}, tangent = new UnityEngine.Vector4() {x = (true + val_5) + 44, y = (true + val_5) + 60, z = (true + val_5) + 60, w = (true + val_5) + 60}, color = new UnityEngine.Color32() {r = (true + val_5) + 60, g = (true + val_5) + 60, b = (true + val_5) + 60, a = (true + val_5) + 60}, uv0 = new UnityEngine.Vector2() {x = (true + val_5) + 76, y = (true + val_5) + 76}, uv1 = new UnityEngine.Vector2() {x = (true + val_5) + 76, y = (true + val_5) + 76}, uv2 = new UnityEngine.Vector2() {x = (true + val_5) + 92, y = (true + val_5) + 92}, uv3 = new UnityEngine.Vector2() {x = (true + val_5) + 92, y = (true + val_5) + 92}});
            if(0 != val_6)
            {
                goto label_5;
            }
        
        }
        private void MirrorVertsVecticalInverse(UnityEngine.Rect rect, System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            var val_5;
            var val_6;
            bool val_3 = true;
            if(val_3 < 1)
            {
                    return;
            }
            
            val_5 = 0;
            val_6 = 0;
            goto label_3;
            label_5:
            val_6 = 1;
            val_5 = 76;
            label_3:
            if(val_6 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + val_5;
            UnityEngine.Vector2 val_1 = rect.m_XMin.center;
            UnityEngine.Vector2 val_2 = rect.m_XMin.center;
            float val_4 = val_1.x;
            val_4 = val_4 + val_4;
            val_4 = val_4 - ((true + val_5) + 32);
            verts.Add(item:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_4, z = (true + val_5) + 40}, normal = new UnityEngine.Vector3() {x = (true + val_5) + 44, y = (true + val_5) + 44, z = (true + val_5) + 44}, tangent = new UnityEngine.Vector4() {x = (true + val_5) + 44, y = (true + val_5) + 60, z = (true + val_5) + 60, w = (true + val_5) + 60}, color = new UnityEngine.Color32() {r = (true + val_5) + 60, g = (true + val_5) + 60, b = (true + val_5) + 60, a = (true + val_5) + 60}, uv0 = new UnityEngine.Vector2() {x = (true + val_5) + 76, y = (true + val_5) + 76}, uv1 = new UnityEngine.Vector2() {x = (true + val_5) + 76, y = (true + val_5) + 76}, uv2 = new UnityEngine.Vector2() {x = (true + val_5) + 92, y = (true + val_5) + 92}, uv3 = new UnityEngine.Vector2() {x = (true + val_5) + 92, y = (true + val_5) + 92}});
            if(0 != val_6)
            {
                goto label_5;
            }
        
        }
        private void SliceExcludeVerts(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
        {
            var val_7;
            if(true < 1)
            {
                    return;
            }
            
            var val_17 = 0;
            label_20:
            val_17 = val_17 + 2;
            do
            {
                if(true <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = val_17 + (0 * 76);
                if(true <= ((long)val_17 + 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_3 = val_17 + (((long)val_17 + 1) * 76);
                if(true <= (long)val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_4 = val_17 + ((long)val_17 * 76);
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = (0 * 76) + (0 + 2) + 32, y = (0 * 76) + (0 + 2) + 32 + 4, z = (0 * 76) + (0 + 2) + 40}, rhs:  new UnityEngine.Vector3() {x = ((long)(int)((0 + 1)) * 76) + (0 + 2) + 32, y = ((long)(int)((0 + 1)) * 76) + (0 + 2) + 32 + 4, z = ((long)(int)((0 + 1)) * 76) + (0 + 2) + 40})) != true)
            {
                    if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = ((long)(int)((0 + 1)) * 76) + (0 + 2) + 32, y = ((long)(int)((0 + 1)) * 76) + (0 + 2) + 32 + 4, z = ((long)(int)((0 + 1)) * 76) + (0 + 2) + 40}, rhs:  new UnityEngine.Vector3() {x = ((long)(int)((0 + 2)) * 76) + (0 + 2) + 32, y = ((long)(int)((0 + 2)) * 76) + (0 + 2) + 32 + 4, z = ((long)(int)((0 + 2)) * 76) + (0 + 2) + 40})) != true)
            {
                    if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = ((long)(int)((0 + 2)) * 76) + (0 + 2) + 32, y = ((long)(int)((0 + 2)) * 76) + (0 + 2) + 32 + 4, z = ((long)(int)((0 + 2)) * 76) + (0 + 2) + 40}, rhs:  new UnityEngine.Vector3() {x = (0 * 76) + (0 + 2) + 32, y = (0 * 76) + (0 + 2) + 32 + 4, z = (0 * 76) + (0 + 2) + 40})) == false)
            {
                goto label_14;
            }
            
            }
            
            }
            
                val_7 = true - 3;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                verts.set_Item(index:  0, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()});
                var val_9 = true - 2;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                verts.set_Item(index:  (long)val_17 + 1, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()});
                var val_12 = true - 1;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                verts.set_Item(index:  (long)val_17, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()});
            }
            while(0 < val_7);
            
            goto label_19;
            label_14:
            var val_15 = 0 + 3;
            val_7 = true;
            if(val_15 < true)
            {
                goto label_20;
            }
            
            label_19:
            if(val_15 <= true)
            {
                    return;
            }
            
            verts.RemoveRange(index:  1, count:  (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished - val_7)>>0&0xFFFFFFFF);
        }
        protected UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Rect rect)
        {
            float val_15;
            UnityEngine.Vector4 val_3 = this.graphic.overrideSprite.border;
            UnityEngine.Vector4 val_6 = UnityEngine.Vector4.op_Division(a:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, d:  this.graphic.pixelsPerUnit);
            var val_16 = 0;
            do
            {
                int val_8 = val_16 + 2;
                val_15 = val_6.x.Item[0] + val_6.x.Item[val_8];
                UnityEngine.Vector2 val_10 = rect.m_XMin.size;
                if((val_15 != 0f) && (val_10.x.Item[0] < 0))
            {
                    UnityEngine.Vector2 val_12 = rect.m_XMin.size;
                val_15 = val_12.x.Item[0] / val_15;
                float val_14 = val_6.x.Item[0];
                val_14 = val_14 * val_15;
                val_6.x.set_Item(index:  0, value:  val_14);
                float val_15 = val_6.x.Item[val_8];
                val_15 = val_15 * val_15;
                val_6.x.set_Item(index:  val_8, value:  val_15);
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 != 2);
            
            return new UnityEngine.Vector4() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
        }
        protected void SlicedScale(UnityEngine.Rect rect, System.Collections.Generic.List<UnityEngine.UIVertex> verts, int count)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            var val_19;
            float val_20;
            float val_21;
            float val_22;
            val_20 = rect.m_XMin;
            UnityEngine.Vector4 val_1 = this.GetAdjustedBorders(rect:  new UnityEngine.Rect() {m_XMin = val_20, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height});
            val_21 = rect.m_XMin.width;
            if(count < 1)
            {
                    return;
            }
            
            var val_20 = 0;
            label_14:
            if(0 >= (-276207008))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = val_9;
            val_22 = val_10;
            MirrorModeType val_18 = this.mirrorMode;
            val_18 = val_18 | 2;
            if(val_18 != 2)
            {
                goto label_8;
            }
            
            if((val_21 * 0.5f) >= 0)
            {
                goto label_5;
            }
            
            UnityEngine.Vector2 val_12 = rect.m_XMin.center;
            if(val_21 >= val_12.x)
            {
                goto label_6;
            }
            
            label_5:
            if(val_21 < val_1.x)
            {
                goto label_8;
            }
            
            val_20 = val_21 + rect.m_XMin.x;
            val_21 = val_20 * 0.5f;
            goto label_8;
            label_6:
            UnityEngine.Vector2 val_14 = rect.m_XMin.center;
            val_21 = val_14.x;
            label_8:
            MirrorModeType val_19 = this.mirrorMode;
            val_19 = val_19 - 1;
            if(val_19 > 1)
            {
                goto label_13;
            }
            
            if((rect.m_XMin.height * 0.5f) >= 0)
            {
                goto label_10;
            }
            
            UnityEngine.Vector2 val_15 = rect.m_XMin.center;
            if(val_22 >= val_15.y)
            {
                goto label_11;
            }
            
            label_10:
            if(val_22 < val_1.y)
            {
                goto label_13;
            }
            
            float val_16 = rect.m_XMin.y;
            val_16 = val_22 + val_16;
            val_22 = val_16 * 0.5f;
            goto label_13;
            label_11:
            UnityEngine.Vector2 val_17 = rect.m_XMin.center;
            val_22 = val_17.y;
            label_13:
            val_8 = val_6;
            val_7 = ???;
            verts.set_Item(index:  0, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_11}, normal = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, tangent = new UnityEngine.Vector4() {x = val_8, y = val_7, z = val_7, w = val_7}, color = new UnityEngine.Color32() {r = val_7, g = val_7, b = val_7, a = val_7}, uv0 = new UnityEngine.Vector2() {x = val_8, y = val_8}, uv1 = new UnityEngine.Vector2() {x = val_8, y = val_8}, uv2 = new UnityEngine.Vector2() {x = val_7, y = val_7}, uv3 = new UnityEngine.Vector2() {x = val_7, y = val_7}});
            val_19 = 0 + 1;
            val_20 = val_20 + 76;
            if(count != val_19)
            {
                goto label_14;
            }
        
        }
        public ImageMirror()
        {
            this._meshCacheList = new System.Collections.Generic.List<UnityEngine.UIVertex>();
        }
    
    }

}
