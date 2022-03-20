using UnityEngine;
public struct QuizRecord.AnswerStateEnum
{
    // Fields
    private string <Value>k__BackingField;
    public static Platform.Analyze.QuizRecord.AnswerStateEnum AnswerStateWrong;
    public static Platform.Analyze.QuizRecord.AnswerStateEnum AnswerStateRight;
    
    // Properties
    public string Value { get; set; }
    
    // Methods
    public string get_Value()
    {
        return (string)new QuizRecord.AnswerStateEnum();
    }
    private void set_Value(string value)
    {
        this = value;
    }
    public QuizRecord.AnswerStateEnum(string val)
    {
        this = val;
    }
    private static QuizRecord.AnswerStateEnum()
    {
        QuizRecord.AnswerStateEnum.AnswerStateWrong = "wrong";
        QuizRecord.AnswerStateEnum.AnswerStateRight = "right";
    }

}
