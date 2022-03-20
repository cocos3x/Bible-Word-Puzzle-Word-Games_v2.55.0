using UnityEngine;
private sealed class WordContent.<>c__DisplayClass56_2
{
    // Fields
    public string x;
    
    // Methods
    public WordContent.<>c__DisplayClass56_2()
    {
    
    }
    internal bool <MatchAnswerForWord>b__4(View.CommonItem.Word y)
    {
        if(y != null)
        {
                if(y._isAnswered == false)
        {
                return false;
        }
        
            return System.String.op_Equality(a:  y._word, b:  this.x);
        }
        
        throw new NullReferenceException();
    }

}
