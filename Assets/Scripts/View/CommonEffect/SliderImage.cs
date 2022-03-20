using UnityEngine;

namespace View.CommonEffect
{
    public class SliderImage : Image
    {
        // Fields
        private static readonly UnityEngine.Vector2[] s_VertScratch;
        private static readonly UnityEngine.Vector2[] s_UVScratch;
        private static readonly UnityEngine.Vector2[] s_VertDelta;
        
        // Methods
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
        {
            float val_55;
            var val_59;
            float val_60;
            var val_61;
            var val_62;
            var val_63;
            UnityEngine.Vector2[] val_64;
            UnityEngine.Vector2[] val_65;
            UnityEngine.Vector2[] val_66;
            UnityEngine.Vector2[] val_67;
            UnityEngine.Vector2[] val_69;
            UnityEngine.Vector2[] val_71;
            UnityEngine.Vector2[] val_73;
            UnityEngine.Vector2[] val_75;
            float val_76;
            var val_77;
            var val_78;
            var val_79;
            if((this.hasBorder == false) || (true != 1))
            {
                goto label_7;
            }
            
            UnityEngine.Vector4 val_3 = this.overrideSprite.border;
            UnityEngine.Rect val_4 = this.GetPixelAdjustedRect();
            UnityEngine.Vector4 val_6 = UnityEngine.Vector4.op_Division(a:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, d:  this.pixelsPerUnit);
            val_55 = val_6.x + val_6.z;
            if(val_4.m_XMin.width < 0)
            {
                goto label_6;
            }
            
            val_55 = val_6.y + val_6.w;
            if(val_4.m_XMin.height >= 0)
            {
                goto label_7;
            }
            
            label_6:
            toFill.Clear();
            if(this.overrideSprite == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Vector4 val_12 = UnityEngine.Sprites.DataUtility.GetOuterUV(sprite:  this.overrideSprite);
            UnityEngine.Vector4 val_14 = UnityEngine.Sprites.DataUtility.GetInnerUV(sprite:  this.overrideSprite);
            UnityEngine.Vector4 val_16 = UnityEngine.Sprites.DataUtility.GetPadding(sprite:  this.overrideSprite);
            goto label_12;
            label_7:
            this.OnPopulateMesh(toFill:  toFill);
            return;
            label_11:
            UnityEngine.Vector4 val_17 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_18 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_19 = UnityEngine.Vector4.zero;
            label_12:
            UnityEngine.Vector4 val_21 = UnityEngine.Vector4.op_Division(a:  new UnityEngine.Vector4() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, d:  this.pixelsPerUnit);
            val_59 = null;
            val_59 = null;
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_21.x, y:  val_21.y);
            View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_20 = val_22.x;
            val_21.z = val_4.m_XMin.width - val_21.z;
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_21.z, y:  val_4.m_XMin.height - val_21.w);
            View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_38 = val_26.x;
            View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_28 = val_6.x;
            View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_2C = val_6.y;
            float val_27 = val_4.m_XMin.width;
            val_27 = val_27 - val_6.z;
            View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_30 = val_27;
            float val_28 = val_4.m_XMin.height;
            val_28 = val_28 - val_6.w;
            View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_34 = val_28;
            UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = View.CommonEffect.SliderImage.s_VertScratch + 40, y = View.CommonEffect.SliderImage.s_VertScratch + 40 + 4}, b:  new UnityEngine.Vector2() {x = View.CommonEffect.SliderImage.s_VertScratch + 32, y = View.CommonEffect.SliderImage.s_VertScratch + 32 + 4});
            View.CommonEffect.SliderImage.s_VertDelta.__unknownFiledOffset_20 = val_29.x;
            View.CommonEffect.SliderImage.s_VertDelta.__unknownFiledOffset_24 = val_29.y;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = View.CommonEffect.SliderImage.s_VertScratch + 48, y = View.CommonEffect.SliderImage.s_VertScratch + 48 + 4}, b:  new UnityEngine.Vector2() {x = View.CommonEffect.SliderImage.s_VertScratch + 40, y = View.CommonEffect.SliderImage.s_VertScratch + 40 + 4});
            View.CommonEffect.SliderImage.s_VertDelta.__unknownFiledOffset_28 = val_30.x;
            View.CommonEffect.SliderImage.s_VertDelta.__unknownFiledOffset_2C = val_30.y;
            val_60 = mem[View.CommonEffect.SliderImage.s_VertScratch + 48 + 4];
            val_60 = View.CommonEffect.SliderImage.s_VertScratch + 48 + 4;
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = View.CommonEffect.SliderImage.s_VertScratch + 56, y = View.CommonEffect.SliderImage.s_VertScratch + 56 + 4}, b:  new UnityEngine.Vector2() {x = View.CommonEffect.SliderImage.s_VertScratch + 48, y = val_60});
            View.CommonEffect.SliderImage.s_VertDelta.__unknownFiledOffset_30 = val_31.x;
            View.CommonEffect.SliderImage.s_VertDelta.__unknownFiledOffset_34 = val_31.y;
            UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_17.x, y:  val_17.y);
            View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_20 = val_32.x;
            UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_18.x, y:  val_18.y);
            View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_28 = val_33.x;
            UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  val_18.z, y:  val_18.w);
            View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_30 = val_34.x;
            UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  val_17.z, y:  val_17.w);
            View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_38 = val_35.x;
            if(val_4.m_XMin.width < 0)
            {
                    val_61 = null;
                val_61 = null;
                View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_28 = val_4.m_XMin.width;
            }
            
            if(val_4.m_XMin.height < 0)
            {
                    val_62 = null;
                val_62 = null;
                View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_2C = val_4.m_XMin.height;
            }
            
            val_63 = null;
            val_63 = null;
            val_64 = View.CommonEffect.SliderImage.s_VertScratch;
            if((View.CommonEffect.SliderImage.s_VertScratch + 48) < 0)
            {
                    val_64 = View.CommonEffect.SliderImage.s_VertScratch;
                View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_30 = View.CommonEffect.SliderImage.s_VertScratch + 40;
                val_63 = null;
            }
            
            val_63 = null;
            val_65 = View.CommonEffect.SliderImage.s_VertScratch;
            if((View.CommonEffect.SliderImage.s_VertScratch + 52) < 0)
            {
                    val_65 = View.CommonEffect.SliderImage.s_VertScratch;
                View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_34 = View.CommonEffect.SliderImage.s_VertScratch + 44;
                val_63 = null;
            }
            
            val_63 = null;
            val_66 = View.CommonEffect.SliderImage.s_VertScratch;
            if((View.CommonEffect.SliderImage.s_VertScratch + 56) < 0)
            {
                    val_66 = View.CommonEffect.SliderImage.s_VertScratch;
                View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_38 = View.CommonEffect.SliderImage.s_VertScratch + 48;
                val_63 = null;
            }
            
            val_63 = null;
            val_67 = View.CommonEffect.SliderImage.s_VertScratch;
            if((View.CommonEffect.SliderImage.s_VertScratch + 60) < 0)
            {
                    val_67 = View.CommonEffect.SliderImage.s_VertScratch;
                View.CommonEffect.SliderImage.s_VertScratch.__unknownFiledOffset_3C = View.CommonEffect.SliderImage.s_VertScratch + 52;
                val_63 = null;
            }
            
            val_63 = null;
            val_69 = View.CommonEffect.SliderImage.s_UVScratch;
            float val_57 = View.CommonEffect.SliderImage.s_UVScratch + 40;
            val_57 = val_57 - (View.CommonEffect.SliderImage.s_UVScratch + 32);
            if(val_57 > 0f)
            {
                    val_69 = View.CommonEffect.SliderImage.s_UVScratch;
                float val_58 = View.CommonEffect.SliderImage.s_VertScratch + 40;
                float val_59 = View.CommonEffect.SliderImage.s_UVScratch + 32;
                val_60 = mem[View.CommonEffect.SliderImage.s_VertDelta + 32];
                val_60 = View.CommonEffect.SliderImage.s_VertDelta + 32;
                val_58 = val_58 - (View.CommonEffect.SliderImage.s_VertScratch + 32);
                val_58 = val_58 / val_60;
                val_58 = val_58 * ((View.CommonEffect.SliderImage.s_UVScratch + 40) - val_59);
                val_59 = val_59 + val_58;
                View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_28 = val_59;
                val_63 = null;
            }
            
            val_63 = null;
            val_71 = View.CommonEffect.SliderImage.s_UVScratch;
            float val_60 = View.CommonEffect.SliderImage.s_UVScratch + 44;
            val_60 = val_60 - (View.CommonEffect.SliderImage.s_UVScratch + 36);
            if(val_60 > 0f)
            {
                    val_71 = View.CommonEffect.SliderImage.s_UVScratch;
                float val_61 = View.CommonEffect.SliderImage.s_VertScratch + 44;
                float val_62 = View.CommonEffect.SliderImage.s_UVScratch + 36;
                val_60 = mem[View.CommonEffect.SliderImage.s_VertDelta + 36];
                val_60 = View.CommonEffect.SliderImage.s_VertDelta + 36;
                val_61 = val_61 - (View.CommonEffect.SliderImage.s_VertScratch + 36);
                val_61 = val_61 / val_60;
                val_61 = val_61 * ((View.CommonEffect.SliderImage.s_UVScratch + 44) - val_62);
                val_62 = val_62 + val_61;
                View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_2C = val_62;
                val_63 = null;
            }
            
            val_63 = null;
            val_73 = View.CommonEffect.SliderImage.s_UVScratch;
            float val_63 = View.CommonEffect.SliderImage.s_UVScratch + 56;
            val_63 = val_63 - (View.CommonEffect.SliderImage.s_UVScratch + 48);
            if(val_63 > 0f)
            {
                    val_73 = View.CommonEffect.SliderImage.s_UVScratch;
                float val_64 = View.CommonEffect.SliderImage.s_VertScratch + 56;
                float val_65 = View.CommonEffect.SliderImage.s_UVScratch + 48;
                val_60 = mem[View.CommonEffect.SliderImage.s_VertDelta + 48];
                val_60 = View.CommonEffect.SliderImage.s_VertDelta + 48;
                val_64 = val_64 - (View.CommonEffect.SliderImage.s_VertScratch + 48);
                val_64 = val_64 / val_60;
                val_64 = val_64 * ((View.CommonEffect.SliderImage.s_UVScratch + 56) - val_65);
                val_65 = val_65 + val_64;
                View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_38 = val_65;
                val_63 = null;
            }
            
            val_63 = null;
            val_75 = View.CommonEffect.SliderImage.s_UVScratch;
            val_76 = (View.CommonEffect.SliderImage.s_UVScratch + 60) - (View.CommonEffect.SliderImage.s_UVScratch + 52);
            if(val_76 > 0f)
            {
                    val_75 = View.CommonEffect.SliderImage.s_UVScratch;
                float val_66 = View.CommonEffect.SliderImage.s_VertScratch + 60;
                val_60 = mem[View.CommonEffect.SliderImage.s_VertDelta + 52];
                val_60 = View.CommonEffect.SliderImage.s_VertDelta + 52;
                val_66 = val_66 - (View.CommonEffect.SliderImage.s_VertScratch + 52);
                val_66 = val_66 / val_60;
                val_66 = val_66 * ((View.CommonEffect.SliderImage.s_UVScratch + 60) - (View.CommonEffect.SliderImage.s_UVScratch + 52));
                val_76 = (View.CommonEffect.SliderImage.s_UVScratch + 52) + val_66;
                View.CommonEffect.SliderImage.s_UVScratch.__unknownFiledOffset_3C = val_76;
            }
            
            var val_68 = 0;
            var val_67 = 0;
            do
            {
                val_77 = null;
                val_77 = null;
                var val_44 = val_67 + 1;
                float val_45 = val_4.m_XMin.x;
                val_45 = (X25 + 32) + val_45;
                mem2[0] = val_45;
                float val_46 = val_4.m_XMin.y;
                val_67 = val_67 + 1;
                val_46 = ((0 + 1) + 36) + val_46;
                val_68 = val_68 + 8;
                mem2[0] = val_46;
            }
            while(val_67 < 3);
            
            do
            {
                do
            {
                if(((0 == 1) && (0 == 1)) && (View.CommonEffect.SliderImage.s_VertScratch == null))
            {
                    val_78 = 2;
            }
            else
            {
                    val_79 = null;
                val_79 = null;
                UnityEngine.Vector2 val_48 = new UnityEngine.Vector2(x:  413.9746f, y:  View.CommonEffect.SliderImage.s_VertScratch + 4);
                UnityEngine.Vector2[] val_69 = View.CommonEffect.SliderImage.s_VertScratch;
                var val_50 = (0 + 1) << 3;
                val_69 = val_69 + (((0 + 1)) << 3);
                UnityEngine.Vector2 val_51 = new UnityEngine.Vector2(x:  413.9746f, y:  (View.CommonEffect.SliderImage.s_VertScratch + ((0 + 1)) << 3) + 4);
                UnityEngine.Color val_52 = this.color;
                UnityEngine.Color32 val_53 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_52.r, g = val_52.g, b = val_52.b, a = val_52.a});
                UnityEngine.Vector2 val_54 = new UnityEngine.Vector2(x:  413.9746f, y:  View.CommonEffect.SliderImage.s_UVScratch + 4);
                UnityEngine.Vector2[] val_70 = View.CommonEffect.SliderImage.s_UVScratch;
                val_70 = val_70 + (((0 + 1)) << 3);
                UnityEngine.Vector2 val_55 = new UnityEngine.Vector2(x:  413.9746f, y:  (View.CommonEffect.SliderImage.s_UVScratch + ((0 + 1)) << 3) + 4);
                View.CommonEffect.SliderImage.AddQuad(vertexHelper:  toFill, posMin:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y}, posMax:  new UnityEngine.Vector2() {x = val_51.x, y = val_51.y}, color:  new UnityEngine.Color32() {r = val_53.r & 4294967295, g = val_53.r & 4294967295, b = val_53.r & 4294967295, a = val_53.r & 4294967295}, uvMin:  new UnityEngine.Vector2() {x = val_54.x, y = val_54.y}, uvMax:  new UnityEngine.Vector2() {x = val_55.x, y = val_55.y});
                val_78 = 0 + 1;
            }
            
            }
            while(val_78 < 3);
            
            }
            while(0 <= 1);
        
        }
        private static void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax)
        {
            if(posMin.x > posMax.x)
            {
                    return;
            }
            
            if(posMin.y > posMax.y)
            {
                    return;
            }
            
            byte val_13 = color.r;
            int val_1 = vertexHelper.currentVertCount;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  posMin.x, y:  posMin.y, z:  0f);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  uvMin.x, y:  uvMin.y);
            val_13 = val_13 & 4294967295;
            vertexHelper.AddVert(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, color:  new UnityEngine.Color32() {r = val_13, g = val_13, b = val_13, a = val_13}, uv0:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  posMin.x, y:  posMax.y, z:  0f);
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  uvMin.x, y:  uvMax.y);
            vertexHelper.AddVert(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, color:  new UnityEngine.Color32() {r = val_13, g = val_13, b = val_13, a = val_13}, uv0:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  posMax.x, y:  posMax.y, z:  0f);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  uvMax.x, y:  uvMax.y);
            vertexHelper.AddVert(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, color:  new UnityEngine.Color32() {r = val_13, g = val_13, b = val_13, a = val_13}, uv0:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  posMax.x, y:  posMin.y, z:  0f);
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  uvMax.x, y:  uvMin.y);
            vertexHelper.AddVert(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, color:  new UnityEngine.Color32() {r = val_13, g = val_13, b = val_13, a = val_13}, uv0:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            int val_10 = val_1 + 2;
            vertexHelper.AddTriangle(idx0:  val_1, idx1:  val_1 + 1, idx2:  val_10);
            vertexHelper.AddTriangle(idx0:  val_10, idx1:  val_1 + 3, idx2:  val_1);
        }
        public SliderImage()
        {
        
        }
        private static SliderImage()
        {
            View.CommonEffect.SliderImage.s_VertScratch = new UnityEngine.Vector2[4];
            View.CommonEffect.SliderImage.s_UVScratch = new UnityEngine.Vector2[4];
            View.CommonEffect.SliderImage.s_VertDelta = new UnityEngine.Vector2[3];
        }
    
    }

}
