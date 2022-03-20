using UnityEngine;
private sealed class LetterContent.<>c__DisplayClass49_0
{
    // Fields
    public View.Game.LetterContent <>4__this;
    public System.Action onComplet;
    
    // Methods
    public LetterContent.<>c__DisplayClass49_0()
    {
    
    }
    internal void <StartShowGuide>b__0()
    {
        this.<>4__this.handTransform.gameObject.SetActive(value:  true);
    }
    internal void <StartShowGuide>b__1()
    {
        this.<>4__this.guideLineRenderer.positionCount = (this.<>4__this.guideLineRenderer.positionCount) + 1;
        UnityEngine.Vector3 val_4 = this.<>4__this.handTransform.position;
        this.<>4__this.guideLineRenderer.SetPosition(index:  (this.<>4__this.guideLineRenderer.positionCount) - 1, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    internal void <StartShowGuide>b__2()
    {
        this.<>4__this.handTransform.gameObject.SetActive(value:  false);
        this.<>4__this.guideLineRenderer.positionCount = 0;
        if(this.onComplet != null)
        {
                this.onComplet.Invoke();
            return;
        }
        
        this.<>4__this.ShowGuide(delay:  0.2f);
    }

}
