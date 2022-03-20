using UnityEngine;
private sealed class ResultDailyBibleContent.<CreateItem>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Dialog.ResultDaily.ResultDailyBibleContent <>4__this;
    private string <verse>5__2;
    private string <deficiency>5__3;
    private int <col>5__4;
    private string[] <bibleWords>5__5;
    private int <row>5__6;
    private int <colIndex>5__7;
    private int <j>5__8;
    private string <word>5__9;
    private string <>7__wrap9;
    private int <>7__wrap10;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ResultDailyBibleContent.<CreateItem>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_50;
        string val_51;
        int val_52;
        string val_53;
        System.String[] val_54;
        int val_55;
        int val_56;
        int val_57;
        char val_58;
        var val_59;
        if((this.<>1__state) > 4)
        {
            goto label_1;
        }
        
        var val_48 = 15448252 + (this.<>1__state) << 2;
        val_48 = val_48 + 15448252;
        goto (15448252 + (this.<>1__state) << 2 + 15448252);
        label_89:
        this.<>1__state = ;
        label_48:
        val_50 = 1;
        return (bool)val_50;
        label_62:
        this.<word>5__9 = 0;
        int val_51 = this.<col>5__4;
         = (mem[-4611686018427387888]) + ;
        val_51 = val_51 + 1;
        if( != val_51)
        {
            goto label_36;
        }
        
        if(((0.Chars[(mem[-4611686018427387888]) - 1]) & 65535) < 'a')
        {
            goto label_34;
        }
        
        int val_52 = this.<word>5__9.m_stringLength;
        val_52 = (this.<word>5__9.Chars[val_52 - 1]) & 65535;
        if(val_52 < '{')
        {
            goto label_36;
        }
        
        label_34:
        int val_53 = this.<word>5__9.m_stringLength;
        val_53 = (this.<word>5__9.Chars[val_53 - 1]) & 65535;
        if(val_53 < 'A')
        {
            goto label_40;
        }
        
        int val_54 = this.<word>5__9.m_stringLength;
        val_54 = (this.<word>5__9.Chars[val_54 - 1]) & 65535;
        if(val_54 >= '[')
        {
            goto label_40;
        }
        
        label_36:
        val_51 = this.<word>5__9;
        val_53 = this.<colIndex>5__7;
        int val_55 = this.<word>5__9.m_stringLength;
        val_55 = val_55 + val_53;
        if(val_55 <= (this.<col>5__4))
        {
            goto label_42;
        }
        
        if(val_53 < (this.<col>5__4))
        {
                do
        {
            Add(item:  View.CommonItem.ResultBibleTextItem.Create(parent:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_element_class, c:  ' ', show:  false, useUnderline:  false));
            val_53 = val_53 + 1;
        }
        while(val_53 < (this.<col>5__4));
        
        }
        
        int val_56 = this.<row>5__6;
        this.<>2__current = 0;
        this.<>1__state = 3;
        val_56 = val_56 + 1;
        this.<row>5__6 = val_56;
        this.<colIndex>5__7 = 0;
        goto label_48;
        label_40:
        string val_24 = this.<word>5__9.Substring(startIndex:  0, length:  (this.<word>5__9.m_stringLength) - 1);
        this.<word>5__9 = val_24;
        label_42:
        int val_57 = val_24.m_stringLength;
        val_57 = val_57 + (this.<colIndex>5__7);
        if(val_57 > (this.<col>5__4))
        {
            goto label_60;
        }
        
        val_52 = 0;
        this.<>7__wrap9 = val_24;
        this.<>7__wrap10 = 0;
        if(val_52 < val_24.m_stringLength)
        {
            goto label_52;
        }
        
        this.<>7__wrap9 = 0;
        val_56 = this.<col>5__4;
        val_57 = (this.<word>5__9.m_stringLength) + (this.<colIndex>5__7);
        this.<colIndex>5__7 = val_57;
        if(val_57 < val_56)
        {
                Add(item:  View.CommonItem.ResultBibleTextItem.Create(parent:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_element_class, c:  ' ', show:  false, useUnderline:  false));
            val_56 = this.<col>5__4;
            val_57 = (this.<colIndex>5__7) + 1;
            this.<colIndex>5__7 = val_57;
        }
        
        if(val_57 == val_56)
        {
                int val_58 = this.<bibleWords>5__5.Length;
            val_58 = val_58 - 1;
            if((this.<j>5__8) != val_58)
        {
                int val_59 = this.<row>5__6;
            val_59 = val_59 + 1;
            this.<row>5__6 = val_59;
            this.<colIndex>5__7 = 0;
        }
        
        }
        
        label_60:
        val_54 = this.<bibleWords>5__5;
        this.<word>5__9 = 0;
        val_55 = (this.<j>5__8) + 1;
        this.<j>5__8 = val_55;
        if(val_55 < (this.<bibleWords>5__5.Length))
        {
            goto label_62;
        }
        
        if(val_55 > (this.<bibleWords>5__5.Length))
        {
                float val_28 = 1f - (typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_9C * ((float)(this.<row>5__6 - UnityEngine.WaitForSeconds.__il2cppRuntimeField_methods)));
            if(val_28 != 1f)
        {
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  val_28);
            typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_38.transform.localScale = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  val_28);
            UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform.localScale = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        }
        
        }
        
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
        {
                Logic.Game.GameManager.gameSound.Stop(clipName:  "eff_result_scroll_type", isLoopClip:  true);
        }
        
        UnityEngine.Coroutine val_37 = StartCoroutine(routine:  PlayItemAni());
        label_1:
        val_50 = 0;
        return (bool)val_50;
        label_52:
        char val_38 = val_24.Chars[0];
        val_58 = val_38;
        if((System.String.IsNullOrEmpty(value:  this.<deficiency>5__3)) == true)
        {
            goto label_76;
        }
        
        if((this.<deficiency>5__3.Contains(value:  val_38.ToString().ToUpper())) == false)
        {
            goto label_79;
        }
        
        val_59 = 1;
        if(null != 0)
        {
            goto label_83;
        }
        
        label_79:
        val_58 = val_38;
        label_76:
        char val_43 = val_58 - 97;
        val_43 = val_43 & 65535;
        if(val_43 >= '')
        {
            goto label_82;
        }
        
        val_59 = 0;
        if(null != 0)
        {
            goto label_83;
        }
        
        label_82:
        char val_44 = val_58 - 65;
        val_44 = val_44 & 65535;
        label_83:
        View.CommonItem.ResultBibleTextItem val_47 = View.CommonItem.ResultBibleTextItem.Create(parent:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_element_class, c:  val_38, show:  (val_44 > '') ? 1 : 0, useUnderline:  true);
        Add(item:  val_47);
        Add(item:  val_47);
        this.<>2__current = 0;
        goto label_89;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
