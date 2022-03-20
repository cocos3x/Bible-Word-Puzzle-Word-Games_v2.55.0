using UnityEngine;
private sealed class WordContent.<>c__DisplayClass35_0
{
    // Fields
    public string answer;
    
    // Methods
    public WordContent.<>c__DisplayClass35_0()
    {
    
    }
    internal bool <FindWordFromTest>b__0(View.CommonItem.Word x)
    {
        if(x != null)
        {
                if(x._isAnswered == false)
        {
                return false;
        }
        
            return System.String.op_Equality(a:  x._word, b:  this.answer);
        }
        
        throw new NullReferenceException();
    }
    internal bool <FindWordFromTest>b__1(View.CommonItem.Word x)
    {
        if(x._isAnswered == true)
        {
                return false;
        }
        
        if(x.IsEmptyWord() == true)
        {
                return false;
        }
        
        if(x._word.m_stringLength != this.answer.m_stringLength)
        {
                return false;
        }
        
        return x.CheckShowLettersFromAnswer(answer:  this.answer);
    }
    internal bool <FindWordFromTest>b__2(View.CommonItem.Word x)
    {
        var val_3;
        if(x.IsEmptyWord() != false)
        {
                var val_2 = (x._word.m_stringLength == this.answer.m_stringLength) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }

}
