using UnityEngine;
private sealed class LetterBlock.<>c__DisplayClass50_0
{
    // Fields
    public bool isGameComplete;
    public View.CommonItem.LetterBlock <>4__this;
    
    // Methods
    public LetterBlock.<>c__DisplayClass50_0()
    {
    
    }
    internal void <DestroyEffect>b__1()
    {
        if(this.isGameComplete == false)
        {
                return;
        }
        
        this.<>4__this.effect.gameObject.SetActive(value:  true);
    }

}
