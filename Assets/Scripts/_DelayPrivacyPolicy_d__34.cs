using UnityEngine;
private sealed class GameManager.<DelayPrivacyPolicy>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameManager.<DelayPrivacyPolicy>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_5;
        }
        
        val_5 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        val_4 = 1152921512706614912;
        if((Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.IsCCPAAccepted) != true)
        {
                Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.SetCCPAAccepted(isCcp:  true);
            PrivacyPolicy.PrivacyPolicyManager.Agree(key:  "PrivacyPolicy_CCPA_Accepted");
            val_4 = "CCPA_pop";
            Platform.Analytics.EzAnalytics.LogEvent(category:  "CCPA_pop", action:  "action", label:  "show", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "CCPA_pop", action:  "action", label:  "agree", value:  0);
        }
        
        label_5:
        val_5 = 0;
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
