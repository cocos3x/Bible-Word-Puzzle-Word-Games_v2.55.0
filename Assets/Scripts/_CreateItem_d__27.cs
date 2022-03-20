using UnityEngine;
private sealed class ResultBibleContent.<CreateItem>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Dialog.Result.ResultBibleContent <>4__this;
    private string <bible>5__2;
    private string <reference>5__3;
    private string <deficiency>5__4;
    private int <col>5__5;
    private string[] <bibleWords>5__6;
    private int <row>5__7;
    private int <colIndex>5__8;
    private int <j>5__9;
    private string <word>5__10;
    private string <>7__wrap10;
    private int <>7__wrap11;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ResultBibleContent.<CreateItem>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_64;
        string val_65;
        int val_66;
        string val_67;
        System.String[] val_68;
        int val_69;
        int val_70;
        int val_71;
        float val_72;
        char val_73;
        var val_74;
        if((this.<>1__state) > 4)
        {
            goto label_1;
        }
        
        var val_61 = 15448216 + (this.<>1__state) << 2;
        val_61 = val_61 + 15448216;
        goto (15448216 + (this.<>1__state) << 2 + 15448216);
        label_23:
        if( >= val_15.m_stringLength)
        {
            goto label_21;
        }
        
        Add(item:  View.CommonItem.ResultBibleTextItem.Create(parent:  typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_38, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_castClass, c:  Chars[0], show:  true, useUnderline:  false));
         =  + 1;
        if((this.<reference>5__3) != null)
        {
            goto label_23;
        }
        
        this.<>1__state = 0;
        this.<deficiency>5__4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,";
        UnityEngine.Rect val_20 = (null == null) ? UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform : 0.rect;
        UnityEngine.Vector2 val_21 = val_20.m_XMin.size;
        val_67 = this.<bible>5__2;
        val_21.x = val_21.x / (UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg + 96);
        this.<col>5__5 = (int)val_21.x;
        char[] val_22 = new char[1];
        val_22[0] = 32;
        System.String[] val_23 = val_67.Split(separator:  val_22);
        val_69 = 0;
        this.<bibleWords>5__6 = val_23;
        this.<row>5__7 = 1;
        this.<colIndex>5__8 = 0;
        this.<j>5__9 = 0;
        if(val_23 != null)
        {
            goto label_33;
        }
        
        val_65 = this.<word>5__10;
        this.<>1__state = 0;
        if(val_65 != null)
        {
            goto label_49;
        }
        
        label_21:
        View.CommonItem.ResultBibleTextItem.ResetMaterial();
        this.<>2__current = 0;
        label_101:
        this.<>1__state = 2;
        label_55:
        val_64 = 1;
        return (bool)val_64;
        label_69:
        this.<word>5__10 = (val_64 + (Resource.ResManager.__il2cppRuntimeField_cctor_finished) << 3) + 32;
        int val_62 = this.<col>5__5;
        val_62 = val_62 + 1;
        if((((val_64 + (Resource.ResManager.__il2cppRuntimeField_cctor_finished) << 3) + 32.Chars[((val_64 + (Resource.ResManager.__il2cppRuntimeField_cctor_finished) << 3) + 32 + 16 - 1)>>0&0xFFFFFFFF]) & 65535) < 'a')
        {
            goto label_41;
        }
        
        int val_63 = this.<word>5__10.m_stringLength;
        val_63 = (this.<word>5__10.Chars[val_63 - 1]) & 65535;
        if(val_63 < '{')
        {
            goto label_43;
        }
        
        label_41:
        int val_64 = this.<word>5__10.m_stringLength;
        val_64 = (this.<word>5__10.Chars[val_64 - 1]) & 65535;
        if(val_64 < 'A')
        {
            goto label_47;
        }
        
        int val_65 = this.<word>5__10.m_stringLength;
        val_65 = (this.<word>5__10.Chars[val_65 - 1]) & 65535;
        if(val_65 >= '[')
        {
            goto label_47;
        }
        
        label_43:
        val_65 = this.<word>5__10;
        val_67 = this.<colIndex>5__8;
        int val_66 = this.<word>5__10.m_stringLength;
        val_66 = val_66 + val_67;
        if(val_66 <= (this.<col>5__5))
        {
            goto label_49;
        }
        
        if(val_67 < (this.<col>5__5))
        {
                do
        {
            UnityEngine.WaitForSeconds.__il2cppRuntimeField_methods.Add(item:  View.CommonItem.ResultBibleTextItem.Create(parent:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_element_class, c:  ' ', show:  false, useUnderline:  false));
            val_67 = val_67 + 1;
        }
        while(val_67 < (this.<col>5__5));
        
        }
        
        int val_67 = this.<row>5__7;
        this.<>2__current = 0;
        this.<>1__state = 3;
        val_67 = val_67 + 1;
        this.<row>5__7 = val_67;
        this.<colIndex>5__8 = 0;
        goto label_55;
        label_47:
        string val_36 = this.<word>5__10.Substring(startIndex:  0, length:  (this.<word>5__10.m_stringLength) - 1);
        this.<word>5__10 = val_36;
        label_49:
        int val_68 = val_36.m_stringLength;
        val_68 = val_68 + (this.<colIndex>5__8);
        if(val_68 > (this.<col>5__5))
        {
            goto label_67;
        }
        
        val_66 = 0;
        this.<>7__wrap10 = val_36;
        this.<>7__wrap11 = 0;
        if(val_66 < val_36.m_stringLength)
        {
            goto label_59;
        }
        
        this.<>7__wrap10 = 0;
        val_70 = this.<col>5__5;
        val_71 = (this.<word>5__10.m_stringLength) + (this.<colIndex>5__8);
        this.<colIndex>5__8 = val_71;
        if(val_71 < val_70)
        {
                UnityEngine.WaitForSeconds.__il2cppRuntimeField_methods.Add(item:  View.CommonItem.ResultBibleTextItem.Create(parent:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_element_class, c:  ' ', show:  false, useUnderline:  false));
            val_70 = this.<col>5__5;
            val_71 = (this.<colIndex>5__8) + 1;
            this.<colIndex>5__8 = val_71;
        }
        
        if(val_71 == val_70)
        {
                int val_69 = this.<bibleWords>5__6.Length;
            val_69 = val_69 - 1;
            if((this.<j>5__9) != val_69)
        {
                int val_70 = this.<row>5__7;
            val_70 = val_70 + 1;
            this.<row>5__7 = val_70;
            this.<colIndex>5__8 = 0;
        }
        
        }
        
        label_67:
        val_68 = this.<bibleWords>5__6;
        this.<word>5__10 = 0;
        val_69 = (this.<j>5__9) + 1;
        this.<j>5__9 = val_69;
        label_33:
        if(val_69 < (this.<bibleWords>5__6.Length))
        {
            goto label_69;
        }
        
        if(val_69 <= (this.<bibleWords>5__6.Length))
        {
            goto label_71;
        }
        
        val_72 = 1f - (typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_A4 * ((float)(this.<row>5__7 - UnityEngine.WaitForSeconds.__il2cppRuntimeField_nestedTypes)));
        goto label_72;
        label_59:
        char val_40 = val_36.Chars[0];
        val_73 = val_40;
        if((System.String.IsNullOrEmpty(value:  this.<deficiency>5__4)) == true)
        {
            goto label_73;
        }
        
        if((this.<deficiency>5__4.Contains(value:  val_40.ToString().ToUpper())) == false)
        {
            goto label_76;
        }
        
        val_74 = 1;
        if(null != 0)
        {
            goto label_95;
        }
        
        label_71:
        val_72 = 1f;
        label_72:
        if(val_69 > (this.<bibleWords>5__6.Length))
        {
                float val_71 = (float)(this.<reference>5__3.m_stringLength) - (this.<col>5__5);
            val_71 = typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_A4 * val_71;
            float val_72 = 1f;
            val_72 = val_72 - val_71;
            val_72 = UnityEngine.Mathf.Min(a:  val_72, b:  val_72);
        }
        
        if(val_72 != 1f)
        {
                UnityEngine.Vector3 val_48 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, d:  val_72);
            typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_38.transform.localScale = new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z};
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, d:  val_72);
            UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform.localScale = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
        }
        
        if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
        {
                Logic.Game.GameManager.gameSound.Stop(clipName:  "eff_result_scroll_type", isLoopClip:  true);
        }
        
        UnityEngine.Coroutine val_55 = StartCoroutine(routine:  PlayItemAni());
        label_1:
        val_64 = 0;
        return (bool)val_64;
        label_76:
        val_73 = val_40;
        label_73:
        char val_56 = val_73 - 97;
        val_56 = val_56 & 65535;
        if(val_56 >= '')
        {
            goto label_94;
        }
        
        val_74 = 0;
        if(null != 0)
        {
            goto label_95;
        }
        
        label_94:
        char val_57 = val_73 - 65;
        val_57 = val_57 & 65535;
        label_95:
        View.CommonItem.ResultBibleTextItem val_60 = View.CommonItem.ResultBibleTextItem.Create(parent:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_this_arg.transform, prefab:  UnityEngine.WaitForSeconds.__il2cppRuntimeField_element_class, c:  val_40, show:  (val_57 > '') ? 1 : 0, useUnderline:  true);
        Add(item:  val_60);
        UnityEngine.WaitForSeconds.__il2cppRuntimeField_methods.Add(item:  val_60);
        this.<>2__current = 0;
        goto label_101;
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
