using UnityEngine;
private sealed class ExtraBottle.<>c__DisplayClass22_0
{
    // Fields
    public string answer;
    public View.CommonItem.ExtraBottle <>4__this;
    public UnityEngine.GameObject effect;
    
    // Methods
    public ExtraBottle.<>c__DisplayClass22_0()
    {
    
    }
    internal void <AddExtraWord>b__0()
    {
        Platform.Analytics.EzAnalytics.ExtraWordsTimers();
        Data.ExtraWordData.ExtraWordDataMngr.AddWord(word:  this.answer);
        this.<>4__this.PlayAddExtraWordAni();
        UnityEngine.Object.Destroy(obj:  this.effect.gameObject);
    }

}
