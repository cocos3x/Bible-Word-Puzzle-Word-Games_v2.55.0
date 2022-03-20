using UnityEngine;
private sealed class HintButton.<>c__DisplayClass16_0
{
    // Fields
    public View.CommonItem.HintButton <>4__this;
    public UnityEngine.Events.UnityAction callback;
    
    // Methods
    public HintButton.<>c__DisplayClass16_0()
    {
    
    }
    internal void <SetHintFree>b__0()
    {
        Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddHintFreeStatus(hint:  1);
        this.<>4__this.state = 1;
        this.<>4__this.SetHintNum(num:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus);
    }
    internal void <SetHintFree>b__1()
    {
        this.<>4__this.flyParticle.gameObject.SetActive(value:  false);
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke();
    }

}
