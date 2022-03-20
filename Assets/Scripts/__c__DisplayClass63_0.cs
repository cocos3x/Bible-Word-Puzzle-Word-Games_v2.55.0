using UnityEngine;
private sealed class WordContent.<>c__DisplayClass63_0
{
    // Fields
    public string word;
    
    // Methods
    public WordContent.<>c__DisplayClass63_0()
    {
    
    }
    internal bool <ChangeToGuideCanvas>b__0(View.CommonItem.Word x)
    {
        if(x != null)
        {
                return System.String.op_Equality(a:  x._word, b:  this.word);
        }
        
        throw new NullReferenceException();
    }

}
