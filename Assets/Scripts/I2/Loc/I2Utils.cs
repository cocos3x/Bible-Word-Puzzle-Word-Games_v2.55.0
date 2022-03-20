using UnityEngine;

namespace I2.Loc
{
    public static class I2Utils
    {
        // Methods
        public static string ReverseText(string source)
        {
            char[] val_1 = new char[0];
            if(source.m_stringLength < 1)
            {
                    return 0.CreateString(val:  val_1);
            }
            
            var val_4 = 0;
            var val_2 = (long)source.m_stringLength - 1;
            do
            {
                val_4 = val_4 + 1;
                val_2 = val_2 - 1;
                val_1[val_2 << 1] = source.Chars[0];
            }
            while(val_4 < (long)source.m_stringLength);
            
            return 0.CreateString(val:  val_1);
        }
        public static string RemoveNonASCII(string text, bool allowCategory = False)
        {
            var val_9;
            char val_10;
            if((System.String.IsNullOrEmpty(value:  text)) != false)
            {
                    return (string)text;
            }
            
            char[] val_2 = new char[0];
            int val_9 = val_4.Length;
            if(val_9 < 1)
            {
                goto label_5;
            }
            
            val_9 = 0;
            var val_10 = 0;
            val_9 = val_9 & 4294967295;
            label_25:
            if((allowCategory != false) && (1152921504842642926 <= 58))
            {
                    if(0 != 8193)
            {
                goto label_14;
            }
            
            }
            
            if((System.Char.IsLetterOrDigit(c:  '')) != true)
            {
                    if(((IndexOf(value:  '')) & 2147483648) != 0)
            {
                    val_10 = 32;
            }
            
            }
            
            label_14:
            if((System.Char.IsWhiteSpace(c:  ' ')) == false)
            {
                goto label_22;
            }
            
            var val_8 = (val_9 < 1) ? 1 : 0;
            val_8 = 0 | val_8;
            if((val_8 & 1) == 0)
            {
                goto label_18;
            }
            
            goto label_19;
            label_18:
            val_10 = 32;
            label_22:
            val_9 = val_9 + 1;
            val_2[0] = val_10;
            label_19:
            val_10 = val_10 + 1;
            if(val_10 < (val_4.Length << ))
            {
                goto label_25;
            }
            
            return 0.CreateString(val:  val_2, startIndex:  0, length:  0);
            label_5:
            val_9 = 0;
            return 0.CreateString(val:  val_2, startIndex:  0, length:  0);
        }
        public static string GetValidTermName(string text, bool allowCategory = False)
        {
            if(text == null)
            {
                    return (string)text;
            }
            
            allowCategory = allowCategory;
            return I2.Loc.I2Utils.RemoveNonASCII(text:  I2.Loc.I2Utils.RemoveTags(text:  text), allowCategory:  allowCategory);
        }
        public static string SplitLine(string line, int maxCharacters)
        {
            var val_10;
            System.Func<System.Char, System.Boolean> val_12;
            if(maxCharacters < 1)
            {
                    return (string)line;
            }
            
            if(line.m_stringLength < maxCharacters)
            {
                    return (string)line;
            }
            
            System.Char[] val_1 = line.ToCharArray();
            if(val_1.Length < 1)
            {
                goto label_5;
            }
            
            var val_9 = 0;
            int val_2 = val_1.Length & 4294967295;
            goto label_24;
            label_21:
            mem2[0] = 0;
            goto label_23;
            label_24:
            val_2 = val_2 & 4294967295;
            if((1 & 1) == 0)
            {
                goto label_8;
            }
            
            if((((null == 10) ? 0 : (0 + 1)) < maxCharacters) || ((System.Char.IsWhiteSpace(c:  '')) == false))
            {
                goto label_13;
            }
            
            mem2[0] = 10;
            goto label_23;
            label_8:
            if((System.Char.IsWhiteSpace(c:  '')) == false)
            {
                goto label_19;
            }
            
            if(null != 10)
            {
                goto label_21;
            }
            
            if((0 & 1) != 0)
            {
                goto label_23;
            }
            
            mem2[0] = 0;
            goto label_23;
            label_19:
            label_13:
            label_23:
            val_9 = val_9 + 1;
            if(val_9 < (val_1.Length << ))
            {
                goto label_24;
            }
            
            label_5:
            val_10 = null;
            val_10 = null;
            val_12 = I2Utils.<>c.<>9__6_0;
            if(val_12 != null)
            {
                    return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_1, predicate:  val_12 = val_6)));
            }
            
            System.Func<System.Char, System.Boolean> val_6 = null;
            val_6 = new System.Func<System.Char, System.Boolean>(object:  I2Utils.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean I2Utils.<>c::<SplitLine>b__6_0(char c));
            I2Utils.<>c.<>9__6_0 = val_12;
            return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_1, predicate:  val_12)));
        }
        public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
        {
            int val_14;
            tagStart = 0;
            tagEnd = 0;
            goto label_1;
            label_15:
            iStart = iStart + 1;
            tagEnd = iStart;
            if(iStart >= W25)
            {
                    return false;
            }
            
            var val_14 = 0;
            label_6:
            char val_1 = line.Chars[iStart];
            char val_2 = val_1 & 65535;
            char val_3 = val_2 - 62;
            if(val_3 > ('?'))
            {
                goto label_3;
            }
            
            val_3 = 1 << val_3;
            if(val_3 != '')
            {
                goto label_5;
            }
            
            label_3:
            if(val_2 == ')')
            {
                goto label_5;
            }
            
            iStart = tagEnd + 1;
            val_14 = val_14 | (((val_1 & 65535) > 'ÿ') ? 1 : 0);
            tagEnd = iStart;
            if(iStart < W25)
            {
                goto label_6;
            }
            
            return false;
            label_5:
            if((val_14 & 1) == 0)
            {
                    return false;
            }
            
            int val_15 = tagEnd;
            tagStart = 0;
            tagEnd = 0;
            val_14 = val_15 + 1;
            label_1:
            tagStart = val_14;
            if(val_14 >= line.m_stringLength)
            {
                goto label_9;
            }
            
            label_14:
            val_15 = line.Chars[val_14] & 65535;
            if((((val_15 == '[') || ((line.Chars[tagStart] & 65535) == '(')) || ((line.Chars[tagStart] & 65535) == '{')) || ((line.Chars[tagStart] & 65535) == ('<')))
            {
                goto label_13;
            }
            
            int val_13 = tagStart + 1;
            tagStart = val_13;
            if(val_13 < line.m_stringLength)
            {
                goto label_14;
            }
            
            label_13:
            val_14 = tagStart;
            label_9:
            if(val_14 != line.m_stringLength)
            {
                goto label_15;
            }
            
            return false;
        }
        public static string RemoveTags(string text)
        {
            return System.Text.RegularExpressions.Regex.Replace(input:  text, pattern:  "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>", replacement:  "");
        }
        public static bool IsPlaying()
        {
            return UnityEngine.Application.isPlaying;
        }
        public static void SendWebRequest(UnityEngine.Networking.UnityWebRequest www)
        {
            if(www != null)
            {
                    UnityEngine.Networking.UnityWebRequestAsyncOperation val_1 = www.SendWebRequest();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
