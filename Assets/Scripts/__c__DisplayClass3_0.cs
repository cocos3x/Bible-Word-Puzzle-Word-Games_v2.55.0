using UnityEngine;
private sealed class CoinAnimationEffect.<>c__DisplayClass3_0
{
    // Fields
    public int amount;
    public string from;
    public UnityEngine.Events.UnityAction onComplete;
    public View.Dialog.CoinAnimation.CoinAnimationEffect <>4__this;
    
    // Methods
    public CoinAnimationEffect.<>c__DisplayClass3_0()
    {
    
    }
    internal void <GainCoin>b__0()
    {
        if(this.amount >= 1)
        {
                Message.Messager.Dispatch(cmd:  78);
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoins(value:  this.amount, from:  this.from);
        }
        
        if(this.onComplete != null)
        {
                this.onComplete.Invoke();
        }
        
        View.Dialog.CoinAnimation.CoinAnimationEffect val_2 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.CoinAnimation.CoinAnimationEffect>(obj:  this.<>4__this, isUi:  true);
    }

}
