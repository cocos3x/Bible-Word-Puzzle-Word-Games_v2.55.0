using UnityEngine;
[Serializable]
private sealed class TransformExtension.<>c__39<T>
{
    // Fields
    public static readonly Utils.Unity.TransformExtension.<>c__39<T> <>9;
    public static System.Predicate<T> <>9__39_0;
    
    // Methods
    private static TransformExtension.<>c__39<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 302];
        val_1 = __RuntimeMethodHiddenParam + 24 + 302;
        val_2 = __RuntimeMethodHiddenParam + 24;
        if((val_1 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_1 = __RuntimeMethodHiddenParam + 24 + 302;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192;
    }
    public TransformExtension.<>c__39<T>()
    {
        if(this != null)
        {
                return;
        }
        
        throw new NullReferenceException();
    }
    internal bool <FindFirstInactiveChild>b__39_0(T child)
    {
        bool val_2 = child.gameObject.activeSelf;
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }

}
