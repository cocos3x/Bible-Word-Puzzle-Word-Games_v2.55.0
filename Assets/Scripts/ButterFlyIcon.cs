using UnityEngine;
public class ButterFlyIcon : MonoBehaviour
{
    // Fields
    private readonly UnityEngine.Color _grayColor;
    public UnityEngine.Sprite[] SpriteWins;
    public UnityEngine.Sprite[] SpriteMids;
    public UnityEngine.Sprite SpriteSpecial;
    public UnityEngine.UI.Image ImageMidLeft;
    public UnityEngine.UI.Image ImageMidRight;
    public UnityEngine.UI.Image ImageLeft;
    public UnityEngine.UI.Image ImageRight;
    public Coffee.UIEffects.UIEffect EffectMidLeft;
    public Coffee.UIEffects.UIEffect EffectMidRight;
    public Coffee.UIEffects.UIEffect EffectLeft;
    public Coffee.UIEffects.UIEffect EffectRight;
    
    // Methods
    public void SetButterFlyIcon(int index, bool isCollect)
    {
        UnityEngine.Sprite val_7;
        if(this.SpriteWins.Length <= index)
        {
                return;
        }
        
        bool val_10 = isCollect;
        this.ImageMidLeft.sprite = this.SpriteMids[(long)index];
        this.ImageMidRight.sprite = this.SpriteMids[(long)index];
        this.ImageLeft.sprite = this.SpriteWins[(long)index];
        if(index == 11)
        {
                val_7 = this.SpriteSpecial;
        }
        else
        {
                val_7 = this.SpriteWins[(long)index];
        }
        
        this.ImageRight.sprite = val_7;
        if(val_10 == false)
        {
            goto label_17;
        }
        
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        if(this.ImageMidLeft != null)
        {
            goto label_18;
        }
        
        label_17:
        label_18:
        this.ImageMidLeft.color = new UnityEngine.Color() {r = this._grayColor};
        if(val_10 == false)
        {
            goto label_21;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        if(this.ImageMidRight != null)
        {
            goto label_22;
        }
        
        label_21:
        label_22:
        this.ImageMidRight.color = new UnityEngine.Color() {r = this._grayColor};
        if(val_10 == false)
        {
            goto label_25;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        if(this.ImageLeft != null)
        {
            goto label_26;
        }
        
        label_25:
        label_26:
        this.ImageLeft.color = new UnityEngine.Color() {r = this._grayColor};
        if(val_10 == false)
        {
            goto label_29;
        }
        
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        if(this.ImageRight != null)
        {
            goto label_30;
        }
        
        label_29:
        label_30:
        this.ImageRight.color = new UnityEngine.Color() {r = this._grayColor};
        bool val_5 = val_10 ^ 1;
        val_10 = val_5;
        this.EffectMidLeft.enabled = val_10;
        this.EffectMidRight.enabled = val_10;
        bool val_6 = val_5;
        this.EffectLeft.enabled = val_6;
        this.EffectRight.enabled = val_6;
    }
    public ButterFlyIcon()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  0.48f);
        this._grayColor = val_1.r;
    }

}
