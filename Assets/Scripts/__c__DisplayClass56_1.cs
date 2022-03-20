using UnityEngine;
private sealed class WordContent.<>c__DisplayClass56_1
{
    // Fields
    public string x;
    
    // Methods
    public WordContent.<>c__DisplayClass56_1()
    {
    
    }
    internal bool <MatchAnswerForWord>b__2(View.CommonItem.Word y)
    {
        if(y.IsEmptyWord() == false)
        {
                return System.String.op_Equality(a:  y._word, b:  this.x);
        }
        
        return false;
    }

}
