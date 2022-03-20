using UnityEngine;
private sealed class ImageExtension.<>c__DisplayClass2_0
{
    // Fields
    public UnityEngine.UI.Image self;
    
    // Methods
    public ImageExtension.<>c__DisplayClass2_0()
    {
    
    }
    internal void <CreateSpriteForUrl>b__0(UnityEngine.Texture2D texture)
    {
        if(texture == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  0f, y:  0f, width:  (float)texture.width, height:  (float)texture.height);
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, d:  0.5f);
        this.self.sprite = UnityEngine.Sprite.Create(texture:  texture, rect:  new UnityEngine.Rect() {m_XMin = val_4.m_XMin, m_YMin = val_4.m_YMin, m_Width = val_4.m_Width, m_Height = val_4.m_Height}, pivot:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
    }

}
