using UnityEngine;
private sealed class LetterBox.<>c__DisplayClass67_0
{
    // Fields
    public View.CommonItem.LetterBox <>4__this;
    public bool useSound;
    public System.Action onComplete;
    
    // Methods
    public LetterBox.<>c__DisplayClass67_0()
    {
    
    }
    internal void <PlayShow>b__0()
    {
        if((this.<>4__this) != null)
        {
                this.<>4__this.HideGiftBox(isPlay:  true);
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <PlayShow>b__1()
    {
        this.<>4__this.HideChrysalisBox();
        UnityEngine.Vector3 val_2 = this.<>4__this.ChrysalisBox.transform.position;
        UnityEngine.Vector3 val_5 = this.<>4__this.transform.parent.localScale;
        Message.Messager.Dispatch<UnityEngine.Vector3, UnityEngine.Vector3>(cmd:  107, t:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, u:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    internal void <PlayShow>b__2()
    {
        if(this.useSound != false)
        {
                Logic.Game.GameManager.gameSound.Play(clipName:  "letter_box_imbed", volumeScale:  1f, loop:  false, delay:  0f);
        }
        
        this.<>4__this.blockTransform.gameObject.SetActive(value:  true);
        this.<>4__this.AnimatorBlock.Play(stateName:  "LetterBoxBlockDone");
    }
    internal void <PlayShow>b__3()
    {
        this.<>4__this._effectShowAnswer.gameObject.SetActive(value:  true);
        if(this.onComplete == null)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }

}
