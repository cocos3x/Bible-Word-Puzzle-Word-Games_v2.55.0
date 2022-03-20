using UnityEngine;

namespace Utils.Unity
{
    public static class ImageExtension
    {
        // Methods
        public static UnityEngine.UI.Image FillAmount(UnityEngine.UI.Image self, float fillAmount)
        {
            if((UnityEngine.Object.op_Implicit(exists:  self)) == false)
            {
                    return (UnityEngine.UI.Image)self;
            }
            
            self.fillAmount = fillAmount;
            return (UnityEngine.UI.Image)self;
        }
        public static void SetSpriteForPath(UnityEngine.UI.Image self, string path)
        {
            UnityEngine.Sprite val_1 = Resource.ResManager.Load<UnityEngine.Sprite>(path:  path, parent:  0);
            if(val_1 == 0)
            {
                    return;
            }
            
            self.sprite = val_1;
        }
        public static void CreateSpriteForUrl(UnityEngine.UI.Image self, string url)
        {
            string val_16;
            UnityEngine.UI.Image val_17;
            var val_18;
            val_16 = url;
            val_17 = self;
            typeof(ImageExtension.<>c__DisplayClass2_0).__il2cppRuntimeField_10 = val_17;
            if((System.String.IsNullOrEmpty(value:  val_16)) == true)
            {
                    return;
            }
            
            val_18 = null;
            val_18 = null;
            FileOperationResult val_5 = Utils.Util.File.FileUtil.ReadAllBytes(path:  System.IO.Path.Combine(path1:  Logic.Define.ApplicationConfig.TextureCachePath, path2:  Utils.Util.MD5Util.GetStringMD5(target:  val_16)));
            if(((val_5.<Success>k__BackingField) != false) && (X0 != false))
            {
                    UnityEngine.Texture2D val_6 = null;
                val_16 = val_6;
                val_6 = new UnityEngine.Texture2D(width:  0, height:  0, textureFormat:  49, mipChain:  false);
                bool val_7 = UnityEngine.ImageConversion.LoadImage(tex:  val_16, data:  X0);
                val_17 = width;
                UnityEngine.Rect val_10 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)val_17, height:  (float)height);
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.one;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, d:  0.5f);
                typeof(ImageExtension.<>c__DisplayClass2_0).__il2cppRuntimeField_10.sprite = UnityEngine.Sprite.Create(texture:  val_16, rect:  new UnityEngine.Rect() {m_XMin = val_10.m_XMin, m_YMin = val_10.m_YMin, m_Width = val_10.m_Width, m_Height = val_10.m_Height}, pivot:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                return;
            }
            
            UnityEngine.Texture2D val_15 = Resource.ResManager.GetTextureForUrl(url:  val_16, callback:  new System.Action<UnityEngine.Texture2D>(object:  new System.Object(), method:  System.Void ImageExtension.<>c__DisplayClass2_0::<CreateSpriteForUrl>b__0(UnityEngine.Texture2D texture)));
        }
        public static void CreateSpriteForTexture(UnityEngine.UI.Image self, UnityEngine.Texture2D texture)
        {
            if(texture == 0)
            {
                    return;
            }
            
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)texture.width, height:  (float)texture.height);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, d:  0.5f);
            self.sprite = UnityEngine.Sprite.Create(texture:  texture, rect:  new UnityEngine.Rect() {m_XMin = val_4.m_XMin, m_YMin = val_4.m_YMin, m_Width = val_4.m_Width, m_Height = val_4.m_Height}, pivot:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        }
    
    }

}
