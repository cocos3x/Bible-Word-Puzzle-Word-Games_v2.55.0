using UnityEngine;

namespace Common
{
    public class EzDate
    {
        // Fields
        public static string defaultDateFormat;
        public static readonly System.DateTime defaultDateTime;
        
        // Methods
        public static System.DateTime GetDateTime(string dateString, string format)
        {
            return Common.EzDate.GetDateTime(dateString:  dateString, format:  format, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        public static System.DateTime GetDateTime(string dateString, string format, System.IFormatProvider provider)
        {
            string val_6;
            string val_7;
            var val_8;
            var val_10;
            System.DateTime val_11;
            var val_12;
            val_6 = format;
            val_7 = dateString;
            val_8 = null;
            if((System.String.IsNullOrEmpty(value:  val_7)) == false)
            {
                goto label_1;
            }
            
            val_8 = null;
            goto label_4;
            label_1:
            string val_2 = Common.EzDate.FixDateString(dateString:  val_7);
            val_7 = val_2;
            if((System.String.IsNullOrEmpty(value:  val_2)) == false)
            {
                goto label_7;
            }
            
            val_10 = null;
            val_10 = null;
            label_4:
            val_11 = Common.EzDate.defaultDateTime;
            return (System.DateTime)val_5.dateData;
            label_7:
            if((System.String.IsNullOrEmpty(value:  val_6)) != false)
            {
                    val_12 = null;
                val_12 = null;
                val_6 = Common.EzDate.defaultDateFormat;
            }
            
            System.DateTime val_5 = System.DateTime.ParseExact(s:  val_7, format:  val_6, provider:  provider, style:  0);
            return (System.DateTime)val_5.dateData;
        }
        public static string GetDateString(System.DateTime dateTime, string format)
        {
            return Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = dateTime.dateData}, format:  format, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        public static string GetDateString(System.DateTime dateTime, string format, System.IFormatProvider provider)
        {
            var val_3;
            bool val_1 = System.String.IsNullOrEmpty(value:  format);
            val_3 = null;
            val_3 = null;
            return (string)dateTime.dateData.ToString(format:  Common.EzDate.defaultDateFormat, provider:  provider);
        }
        private static int[] getTimeInfoFromString(string strTime, ref int timeInfoIndex)
        {
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if((System.String.IsNullOrEmpty(value:  strTime)) == true)
            {
                goto label_42;
            }
            
            int[] val_2 = new int[7];
            timeInfoIndex = 0;
            if()
            {
                goto label_42;
            }
            
            val_18 = 0;
            var val_29 = 0;
            val_19 = 0;
            label_18:
            if(val_18 >= val_2.Length)
            {
                goto label_19;
            }
            
            char val_5 = strTime.Chars[0] - 48;
            val_5 = val_5 & 65535;
            if(val_5 > '	')
            {
                goto label_6;
            }
            
            val_20 = val_29;
            if(val_19 == 1)
            {
                goto label_37;
            }
            
            val_21 = strTime.m_stringLength;
            if(val_29 == (strTime.m_stringLength - 1))
            {
                goto label_8;
            }
            
            label_10:
            val_20 = val_19;
            goto label_37;
            label_6:
            val_21 = val_29;
            if(val_19 >= val_29)
            {
                goto label_10;
            }
            
            label_8:
            int val_6 = val_21 - val_19;
            if(timeInfoIndex == 0)
            {
                goto label_11;
            }
            
            if(val_6 <= 4)
            {
                goto label_12;
            }
            
            goto label_42;
            label_11:
            var val_7 = val_6 - 8;
            if(val_7 <= 9)
            {
                goto label_14;
            }
            
            label_12:
            timeInfoIndex = 1;
            label_36:
            val_2[0] = System.Convert.ToInt32(value:  strTime.Substring(startIndex:  0, length:  val_6));
            label_25:
            val_20 = 0;
            label_37:
            val_18 = timeInfoIndex;
            val_29 = val_29 + 1;
            val_19 = val_20;
            if(val_29 < strTime.m_stringLength)
            {
                goto label_18;
            }
            
            goto label_19;
            label_14:
            timeInfoIndex = 1;
            val_2[0] = System.Convert.ToInt32(value:  strTime.Substring(startIndex:  0, length:  4));
            timeInfoIndex = 2;
            val_2[4] = System.Convert.ToInt32(value:  strTime.Substring(startIndex:  val_19 + 4, length:  2));
            timeInfoIndex = 3;
            val_2[8] = System.Convert.ToInt32(value:  strTime.Substring(startIndex:  val_19 + 6, length:  2));
            if(val_7 < 2)
            {
                goto label_25;
            }
            
            int val_18 = val_19 + 8;
            var val_19 = 9 - val_19;
            label_30:
            timeInfoIndex = timeInfoIndex + 1;
            val_18 = val_18 + 2;
            val_2[12] = System.Convert.ToInt32(value:  strTime.Substring(startIndex:  val_18, length:  2));
            if(0 > 1)
            {
                goto label_29;
            }
            
            val_19 = val_19 - 2;
            if((val_21 + val_19) > 1)
            {
                goto label_30;
            }
            
            label_29:
            if((0 + 1) != 3)
            {
                goto label_37;
            }
            
            int val_25 = val_21 - val_18;
            if(val_25 < 3)
            {
                goto label_37;
            }
            
            timeInfoIndex = timeInfoIndex + 1;
            int val_28 = System.Convert.ToInt32(value:  strTime.Substring(startIndex:  val_18, length:  val_25));
            goto label_36;
            label_19:
            if((val_18 >= 3) && (val_2[1] <= 24))
            {
                    if(val_2[2] <= 60)
            {
                    val_2 = (val_2[2] > 60) ? 0 : (val_2);
                return (System.Int32[])val_22;
            }
            
            }
            
            label_42:
            val_22 = 0;
            return (System.Int32[])val_22;
        }
        private static string FixDateString(string dateString)
        {
            string val_5 = dateString;
            int val_1 = 0;
            System.Int32[] val_2 = Common.EzDate.getTimeInfoFromString(strTime:  val_5 = dateString, timeInfoIndex: ref  val_1);
            if(val_2 != null)
            {
                    if(val_1 > 5)
            {
                    return (string)val_5;
            }
            
                object[] val_3 = new object[6];
                val_3[0] = val_2[0];
                val_3[1] = val_2[0];
                val_3[2] = val_2[1];
                val_3[3] = val_2[1];
                val_3[4] = val_2[2];
                val_3[5] = val_2[2];
                val_5 = System.String.Format(format:  "{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2}", args:  val_3);
                return (string)val_5;
            }
            
            val_5 = "";
            return (string)val_5;
        }
        private static EzDate()
        {
            Common.EzDate.defaultDateFormat = "yyyy-MM-dd HH:mm:ss";
            System.DateTime val_1 = new System.DateTime(year:  178, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
            Common.EzDate.defaultDateTime = val_1.dateData;
        }
    
    }

}
