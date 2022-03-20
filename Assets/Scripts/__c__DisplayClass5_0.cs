using UnityEngine;
private sealed class PrivacyPolicyManager.<>c__DisplayClass5_0
{
    // Fields
    public string key;
    
    // Methods
    public PrivacyPolicyManager.<>c__DisplayClass5_0()
    {
    
    }
    internal void <Agree>b__0()
    {
        var val_2;
        System.Nullable<System.Boolean> val_1 = new System.Nullable<System.Boolean>(value:  true);
        val_2 = null;
        val_2 = null;
        PrivacyPolicy.PrivacyPolicyManager.isAcceptCcpa = val_1.HasValue;
        UnityEngine.PlayerPrefs.SetInt(key:  this.key, value:  1);
    }

}
