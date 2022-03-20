using UnityEngine;
private sealed class GameButtonUtil.<>c__DisplayClass0_0
{
    // Fields
    public UnityEngine.Events.UnityAction onClick;
    public UnityEngine.Events.UnityAction onFinish;
    public UnityEngine.Events.UnityAction onSkip;
    public string adFrom;
    public string position;
    public System.Action<string, bool> <>9__1;
    
    // Methods
    public GameButtonUtil.<>c__DisplayClass0_0()
    {
    
    }
    internal void <AddVideoListener>b__0()
    {
        var val_3;
        System.Action<System.String, System.Boolean> val_4;
        if(this.onClick != null)
        {
                this.onClick.Invoke();
        }
        
        val_3 = null;
        val_3 = null;
        Platform.Ad.RewardPlacement val_1 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
        val_4 = this.<>9__1;
        if(val_4 == null)
        {
                System.Action<System.String, System.Boolean> val_2 = null;
            val_4 = val_2;
            val_2 = new System.Action<System.String, System.Boolean>(object:  this, method:  System.Void GameButtonUtil.<>c__DisplayClass0_0::<AddVideoListener>b__1(string adTaskID, bool isReward));
            this.<>9__1 = val_4;
        }
        
        typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = val_4;
        RegisterDefaultLogEvent(adFrom:  this.adFrom);
        goto mem[null + 464];
    }
    internal void <AddVideoListener>b__1(string adTaskID, bool isReward)
    {
        if(isReward == false)
        {
            goto label_0;
        }
        
        if(this.onFinish == null)
        {
                return;
        }
        
        label_2:
        this.onFinish.Invoke();
        return;
        label_0:
        if(this.onSkip != null)
        {
            goto label_2;
        }
    
    }

}
