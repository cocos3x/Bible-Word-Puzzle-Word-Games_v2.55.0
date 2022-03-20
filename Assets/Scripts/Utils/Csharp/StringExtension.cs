using UnityEngine;

namespace Utils.Csharp
{
    public static class StringExtension
    {
        // Methods
        public static bool Any(string self)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  self);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public static bool IsNullOrEmpty(string self)
        {
            return System.String.IsNullOrEmpty(value:  self);
        }
        public static bool IsNotNullAndEmpty(string self)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  self);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public static string UppercaseFirst(string self)
        {
            string val_7 = self;
            if((System.String.IsNullOrEmpty(value:  val_7 = self)) == true)
            {
                    return (string)val_7;
            }
            
            val_7 = System.Char.ToUpper(c:  val_7.Chars[0]).ToString()(System.Char.ToUpper(c:  val_7.Chars[0]).ToString()) + val_7.Substring(startIndex:  1)(val_7.Substring(startIndex:  1));
            return (string)val_7;
        }
        public static string LowercaseFirst(string self)
        {
            string val_7 = self;
            if((System.String.IsNullOrEmpty(value:  val_7 = self)) == true)
            {
                    return (string)val_7;
            }
            
            val_7 = System.Char.ToLower(c:  val_7.Chars[0]).ToString()(System.Char.ToLower(c:  val_7.Chars[0]).ToString()) + val_7.Substring(startIndex:  1)(val_7.Substring(startIndex:  1));
            return (string)val_7;
        }
        public static string Format(string self, object[] args)
        {
            string val_3 = self;
            if(args == null)
            {
                    return (string)val_3;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_3 = self)) == true)
            {
                    return (string)val_3;
            }
            
            if(args.Length == 0)
            {
                    return (string)val_3;
            }
            
            val_3 = System.String.Format(format:  val_3, args:  args);
            return (string)val_3;
        }
        public static System.Text.StringBuilder Append(string self, string appendStr)
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(value:  self);
            return Append(value:  appendStr);
        }
        public static System.Text.StringBuilder AppendFormat(string self, string appendFormat, object[] args)
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(value:  self);
            return AppendFormat(format:  appendFormat, args:  args);
        }
        public static string AddPrefix(string self, object prefix)
        {
            if(prefix == null)
            {
                    return (string)self;
            }
            
            label_1:
            goto label_1;
        }
        public static string AddPrefix(string self, string prefix)
        {
            System.Text.StringBuilder val_1 = Utils.Csharp.StringExtension.Append(self:  prefix, appendStr:  self);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        public static string AddSuffix(string self, object suffix)
        {
            if(suffix == null)
            {
                    return (string)self;
            }
            
            return Utils.Csharp.StringExtension.AddSuffix(self:  self, suffix:  suffix);
        }
        public static string AddSuffix(string self, string suffix)
        {
            System.Text.StringBuilder val_1 = Utils.Csharp.StringExtension.Append(self:  self, appendStr:  suffix);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        public static string Join(string self, string target, string split)
        {
            if(split == null)
            {
                    return self + split + target(split + target);
            }
            
            return self + split + target(split + target);
        }
        public static bool EqualsIgnoreCase(string self, string target)
        {
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  self)) == true)
            {
                    return false;
            }
            
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  target)) == false)
            {
                    return self.ToLower().Equals(value:  target.ToLower());
            }
            
            return false;
        }
        public static bool StartsWithIgnoreCase(string self, string target)
        {
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  self)) == true)
            {
                    return false;
            }
            
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  target)) == false)
            {
                    return self.ToLower().StartsWith(value:  target.ToLower());
            }
            
            return false;
        }
        public static bool EndsWithIgnoreCase(string self, string target)
        {
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  self)) == true)
            {
                    return false;
            }
            
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  target)) == false)
            {
                    return self.ToLower().EndsWith(value:  target.ToLower());
            }
            
            return false;
        }
        public static string ReplaceIgnoreCase(string self, char oldValue, char newValue)
        {
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  self)) == false)
            {
                    return self.Replace(oldChar:  System.Char.ToLower(c:  oldValue), newChar:  newValue).Replace(oldChar:  System.Char.ToUpper(c:  oldValue), newChar:  newValue);
            }
            
            return (string)self;
        }
        public static string ReplaceIgnoreCase(string self, string oldValue, string newValue)
        {
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  self)) == true)
            {
                    return (string)self;
            }
            
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  oldValue)) == true)
            {
                    return (string)self;
            }
            
            if((Utils.Csharp.ClassExtension.IsNull<System.String>(self:  newValue)) == false)
            {
                    return self.Replace(oldValue:  oldValue.ToUpper(), newValue:  newValue).Replace(oldValue:  oldValue.ToLower(), newValue:  newValue);
            }
            
            return (string)self;
        }
        public static int ToInt(string self, int defaultValue = 0)
        {
            int val_1 = 0;
            return (int)((System.Int32.TryParse(s:  self, result: out  val_1)) != true) ? (val_1) : defaultValue;
        }
        public static float ToFloat(string self, float defaultValue = 0)
        {
            return (float)((System.Single.TryParse(s:  self, result: out  float val_1 = -3.020969E+30f)) != true) ? 0 : defaultValue;
        }
        public static bool IsDateTime(string self, string dateFormat)
        {
            return (bool)System.DateTime.TryParseExact(s:  self, format:  dateFormat, provider:  System.Globalization.CultureInfo.InvariantCulture, style:  0, result: out  new System.DateTime());
        }
        public static System.DateTime ToDateTime(string self, System.DateTime defaultValue)
        {
            return (System.DateTime)((System.DateTime.TryParse(s:  self, result: out  new System.DateTime())) != true) ? 0 : defaultValue.dateData;
        }
        public static string Reverse(string self)
        {
            System.Char[] val_1 = self.ToCharArray();
            System.Array.Reverse(array:  val_1);
            return 0.CreateString(val:  val_1);
        }
        public static bool Match(string self, string pattern)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input:  self, pattern:  pattern);
        }
        public static System.Collections.Generic.IEnumerable<T> SplitTo<T>(string self, char[] separator)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            System.String[] val_1 = self.Split(separator:  separator, options:  0);
            val_2 = mem[__RuntimeMethodHiddenParam + 48 + 302];
            val_2 = __RuntimeMethodHiddenParam + 48 + 302;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_2 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_3 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_3 == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_4 = __RuntimeMethodHiddenParam + 48 + 302;
                if((val_4 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_4 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
                val_5 = mem[__RuntimeMethodHiddenParam + 48];
                val_5 = __RuntimeMethodHiddenParam + 48;
                if(((__RuntimeMethodHiddenParam + 48 + 302) & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 48];
                val_5 = __RuntimeMethodHiddenParam + 48;
            }
            
                val_3 = __RuntimeMethodHiddenParam + 48 + 16;
                mem2[0] = val_3;
            }
        
        }
        public static System.Collections.Generic.IEnumerable<T> SplitTo<T>(string self, System.StringSplitOptions options, char[] separator)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            System.String[] val_1 = self.Split(separator:  separator, options:  options);
            val_2 = mem[__RuntimeMethodHiddenParam + 48 + 302];
            val_2 = __RuntimeMethodHiddenParam + 48 + 302;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_2 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_3 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_3 == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_4 = __RuntimeMethodHiddenParam + 48 + 302;
                if((val_4 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 48 + 302];
                val_4 = __RuntimeMethodHiddenParam + 48 + 302;
            }
            
                val_5 = mem[__RuntimeMethodHiddenParam + 48];
                val_5 = __RuntimeMethodHiddenParam + 48;
                if(((__RuntimeMethodHiddenParam + 48 + 302) & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 48];
                val_5 = __RuntimeMethodHiddenParam + 48;
            }
            
                val_3 = __RuntimeMethodHiddenParam + 48 + 16;
                mem2[0] = val_3;
            }
        
        }
        public static string Cut(string self, int length)
        {
            if((System.String.IsNullOrEmpty(value:  self)) == true)
            {
                    return (string)System.String.alignConst;
            }
            
            if((length & 2147483648) != 0)
            {
                    return (string)System.String.alignConst;
            }
            
            return self.Substring(startIndex:  0, length:  System.Math.Min(val1:  length, val2:  self.m_stringLength));
        }
        public static string CutLast(string self, int length)
        {
            if((System.String.IsNullOrEmpty(value:  self)) == true)
            {
                    return (string)System.String.alignConst;
            }
            
            if((length & 2147483648) != 0)
            {
                    return (string)System.String.alignConst;
            }
            
            return self.Substring(startIndex:  System.Math.Max(val1:  0, val2:  self.m_stringLength - length));
        }
        public static bool HasChinese(string self)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input:  self, pattern:  "[\\u4e00-\\u9fa5]");
        }
        public static string RemoveString(string self, string[] targets)
        {
            var val_2;
            System.Func<System.String, System.String, System.String> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = StringExtension.<>c.<>9__29_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Aggregate<System.String, System.String>(source:  targets, seed:  self, func:  val_4 = val_1);
            }
            
            System.Func<System.String, System.String, System.String> val_1 = null;
            val_1 = new System.Func<System.String, System.String, System.String>(object:  StringExtension.<>c.__il2cppRuntimeField_static_fields, method:  System.String StringExtension.<>c::<RemoveString>b__29_0(string current, string t));
            StringExtension.<>c.<>9__29_0 = val_4;
            return System.Linq.Enumerable.Aggregate<System.String, System.String>(source:  targets, seed:  self, func:  val_4);
        }
    
    }

}
