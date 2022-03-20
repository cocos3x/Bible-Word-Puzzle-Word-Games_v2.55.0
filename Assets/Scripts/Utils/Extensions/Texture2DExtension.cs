using UnityEngine;

namespace Utils.Extensions
{
    public static class Texture2DExtension
    {
        // Methods
        public static void Save(UnityEngine.Texture2D tex, string path)
        {
            if((path.EndsWith(value:  ".jpg", comparisonType:  5)) != true)
            {
                    if((path.EndsWith(value:  ".jpeg", comparisonType:  5)) == false)
            {
                goto label_3;
            }
            
            }
            
            System.Byte[] val_3 = UnityEngine.ImageConversion.EncodeToJPG(tex:  tex);
            goto label_4;
            label_3:
            label_4:
            System.IO.File.WriteAllBytes(path:  path, bytes:  UnityEngine.ImageConversion.EncodeToPNG(tex:  tex));
        }
        public static void SaveToJPG(UnityEngine.Texture2D tex, string path)
        {
            System.IO.File.WriteAllBytes(path:  path, bytes:  UnityEngine.ImageConversion.EncodeToJPG(tex:  tex));
        }
        public static void SaveToPNG(UnityEngine.Texture2D tex, string path)
        {
            System.IO.File.WriteAllBytes(path:  path, bytes:  UnityEngine.ImageConversion.EncodeToPNG(tex:  tex));
        }
        public static UnityEngine.Texture2D NewCopy(UnityEngine.Texture2D tex)
        {
            SetPixels32(colors:  tex.GetPixels32());
            Apply();
            return (UnityEngine.Texture2D)new UnityEngine.Texture2D(width:  tex.width, height:  tex.height);
        }
        public static UnityEngine.Texture2D GetResized(UnityEngine.Texture2D tex, int width, int height)
        {
            UnityEngine.TextureFormat val_7;
            if(tex.width == width)
            {
                    if(tex.height == height)
            {
                    return Utils.Extensions.Texture2DExtension.NewCopy(tex:  tex);
            }
            
            }
            
            val_7 = tex.format;
            if(height >= 1)
            {
                    do
            {
                if(width >= 1)
            {
                    var val_8 = 0;
                do
            {
                float val_7 = 0f;
                val_7 = val_7 / (float)width;
                UnityEngine.Color val_6 = tex.GetPixelBilinear(u:  val_7, v:  0f / (float)height);
                SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
                val_8 = val_8 + 1;
            }
            while(val_8 < width);
            
            }
            
                val_7 = 0 + 1;
            }
            while(val_7 < height);
            
            }
            
            Apply();
            return (UnityEngine.Texture2D)new UnityEngine.Texture2D(width:  width, height:  height, textureFormat:  val_7, mipChain:  false);
        }
        public static UnityEngine.Texture2D GetScaled(UnityEngine.Texture2D tex, float scaleX, float scaleY)
        {
            float val_5 = (float)tex.width;
            val_5 = val_5 * scaleX;
            float val_6 = (float)tex.height;
            val_6 = val_6 * scaleY;
            return Utils.Extensions.Texture2DExtension.GetResized(tex:  tex, width:  UnityEngine.Mathf.RoundToInt(f:  val_5), height:  UnityEngine.Mathf.RoundToInt(f:  val_6));
        }
        public static void CaptureScreen(UnityEngine.Texture2D source, UnityEngine.Rect fromRect, int toX, int toY)
        {
            source.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = fromRect.m_XMin, m_YMin = fromRect.m_YMin, m_Width = fromRect.m_Width, m_Height = fromRect.m_Height}, destX:  toX, destY:  toY);
            source.Apply();
        }
        public static void Overlay(UnityEngine.Texture2D source, UnityEngine.Texture2D target, int x, int y)
        {
            Utils.Extensions.Texture2DExtension.Overlay(source:  source, target:  target, x:  x, y:  y, width:  target.width, height:  target.height);
        }
        public static void Overlay(UnityEngine.Texture2D source, UnityEngine.Texture2D target, int x, int y, int width, int height)
        {
            UnityEngine.Texture2D val_18;
            int val_19;
            int val_20;
            var val_21;
            val_18 = target;
            val_19 = height;
            if(val_18.width != width)
            {
                goto label_1;
            }
            
            val_20 = public System.Int32 UnityEngine.Texture::get_height();
            if(val_18.height == val_19)
            {
                goto label_2;
            }
            
            label_1:
            val_20 = width;
            val_18 = Utils.Extensions.Texture2DExtension.GetResized(tex:  val_18, width:  val_20, height:  val_19);
            label_2:
            if((val_18.height + y) > y)
            {
                    do
            {
                val_21 = public System.Int32 UnityEngine.Texture::get_width();
                if((val_18.width + x) > x)
            {
                    var val_18 = 0;
                do
            {
                int val_9 = x + val_18;
                UnityEngine.Color val_10 = source.GetPixel(x:  val_9, y:  y);
                UnityEngine.Color val_11 = val_18.GetPixel(x:  0, y:  y - y);
                UnityEngine.Color val_12 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a}, b:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, t:  val_11.a);
                source.SetPixel(x:  val_9, y:  y, color:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
                val_21 = public System.Int32 UnityEngine.Texture::get_width();
                val_18 = val_18 + 1;
            }
            while((x + val_18) < (val_18.width + x));
            
            }
            
                val_19 = y + 1;
            }
            while(val_19 < (val_18.height + y));
            
            }
            
            source.Apply();
        }
    
    }

}
