using UnityEngine;
private sealed class WordContent.<>c__DisplayClass56_0
{
    // Fields
    public View.Game.WordContent <>4__this;
    public View.CommonItem.Word word;
    
    // Methods
    public WordContent.<>c__DisplayClass56_0()
    {
    
    }
    internal bool <MatchAnswerForWord>b__1(string x)
    {
        var val_6;
        typeof(WordContent.<>c__DisplayClass56_1).__il2cppRuntimeField_10 = x;
        if((this.<>4__this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  new System.Object(), method:  System.Boolean WordContent.<>c__DisplayClass56_1::<MatchAnswerForWord>b__2(View.CommonItem.Word y)))) == 0)
        {
                var val_5 = ((x + 16) == this.word._word.m_stringLength) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal bool <MatchAnswerForWord>b__0(View.CommonItem.Word x)
    {
        if(x._isAnswered == false)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  x._word, b:  this.word._word);
    }
    internal bool <MatchAnswerForWord>b__3(string x)
    {
        typeof(WordContent.<>c__DisplayClass56_2).__il2cppRuntimeField_10 = x;
        if((this.<>4__this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  new System.Object(), method:  System.Boolean WordContent.<>c__DisplayClass56_2::<MatchAnswerForWord>b__4(View.CommonItem.Word y)))) != 0)
        {
                return false;
        }
        
        if((x + 16) != this.word._word.m_stringLength)
        {
                return false;
        }
        
        return this.word.CheckShowLettersFromAnswer(answer:  typeof(WordContent.<>c__DisplayClass56_2).__il2cppRuntimeField_10);
    }

}
