using UnityEngine;
private sealed class FireworksHintClickGuideDialog.<>c__DisplayClass11_0
{
    // Fields
    public View.Dialog.Firework.FireworksHintClickGuideDialog <>4__this;
    public UnityEngine.Vector3 pos;
    
    // Methods
    public FireworksHintClickGuideDialog.<>c__DisplayClass11_0()
    {
    
    }
    internal void <OnCloseButtonClick>b__0()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this._fireworksButton)) != false)
        {
                0 = 0;
            this.<>4__this._fireworksButton.SetFireworkFree(startPos:  new UnityEngine.Vector3() {x = this.pos});
        }
    
    }

}
