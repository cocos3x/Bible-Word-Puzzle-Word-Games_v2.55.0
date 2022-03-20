using UnityEngine;

namespace Platform.Notification
{
    public class NotificationUtil
    {
        // Fields
        private static int _contentStartIndex;
        private static int _contentEndIndex;
        
        // Methods
        public static void CleanAllNotification()
        {
            Platform.Notification.LocalNotificationManager.CancelAll();
        }
        public static bool IsNotificationAllow()
        {
            return Platform.Notification.LocalNotificationManager.IsEnable();
        }
        public static void ScheduleAllNotify()
        {
            var val_27;
            if((Common.Singleton<Data.Notification.NotificationDataManager>.Instance.IsNotificationOn) == false)
            {
                    return;
            }
            
            if(Platform.Notification.LocalNotificationManager.IsEnable() == false)
            {
                    return;
            }
            
            Platform.Notification.LocalNotificationManager.CancelAll();
            Platform.Notification.NotificationUtil._contentStartIndex = 0;
            val_27 = Data.Bean.NotifyTextBean.getNotifyTextBeans();
            Platform.Notification.NotificationUtil._contentEndIndex = ;
            System.DateTime val_5 = System.DateTime.UtcNow;
            System.TimeSpan val_6 = System.TimeSpan.FromHours(value:  20);
            System.DateTime val_7 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_5.dateData}, t:  new System.TimeSpan() {_ticks = val_6._ticks});
            System.DateTimeOffset val_8 = new System.DateTimeOffset(dateTime:  new System.DateTime() {dateData = val_7.dateData});
            long val_9 = val_8.m_dateTime.dateData.ToUnixTimeMilliseconds();
            System.DateTime val_10 = System.DateTime.UtcNow;
            System.TimeSpan val_11 = System.TimeSpan.FromHours(value:  23);
            System.DateTime val_12 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_10.dateData}, t:  new System.TimeSpan() {_ticks = val_11._ticks});
            System.TimeSpan val_13 = System.TimeSpan.FromMinutes(value:  30);
            System.DateTime val_14 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_12.dateData}, t:  new System.TimeSpan() {_ticks = val_13._ticks});
            System.DateTimeOffset val_15 = new System.DateTimeOffset(dateTime:  new System.DateTime() {dateData = val_14.dateData});
            var val_28 = 0;
            var val_27 = 0;
            do
            {
                int val_17 = UnityEngine.Random.Range(min:  0, max:  Platform.Notification.NotificationUtil._contentEndIndex);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if(Platform.Native.Android.AndroidNative.GetSystemVersion() <= 22)
            {
                    mem2[0] = "215";
                mem2[0] = "216";
            }
            
                set_Item(key:  "ContentId", value:  "txt_" + (Platform.Notification.NotificationUtil.__il2cppRuntimeField_static_fields + (val_17) << 3) + 32 + 16((Platform.Notification.NotificationUtil.__il2cppRuntimeField_static_fields + (val_17) << 3) + 32 + 16));
                System.TimeSpan val_22 = System.TimeSpan.FromDays(value:  (double)val_27 + 1);
                long val_24 = val_15.m_dateTime.dateData.ToUnixTimeMilliseconds() + ((int)val_22._ticks.TotalMilliseconds << );
                Platform.Notification.NotificationUtil.ScheduleNotification(id:  0, title:  Locale.LocaleManager.Translate(key:  (Platform.Notification.NotificationUtil.__il2cppRuntimeField_static_fields + (val_17) << 3) + 32 + 24), body:  Locale.LocaleManager.Translate(key:  (Platform.Notification.NotificationUtil.__il2cppRuntimeField_static_fields + (val_17) << 3) + 32 + 32), fireDate:  val_24, interval:  0, userData:  new System.Collections.Generic.Dictionary<System.String, System.String>());
                Platform.Notification.NotificationUtil.LogFireDateString(fireDate:  val_24, bean:  (Platform.Notification.NotificationUtil.__il2cppRuntimeField_static_fields + (val_17) << 3) + 32, id:  0);
                val_27 = val_27 + 1;
                val_28 = val_28 + 100;
            }
            while(val_27 < 6);
        
        }
        private static void LogFireDateString(long fireDate, Data.Bean.NotifyTextBean bean, int id)
        {
            int val_10;
            int val_11;
            int val_12;
            System.DateTime val_2 = new System.DateTime(year:  178, month:  1, day:  1);
            System.DateTime val_4 = System.TimeZone.CurrentTimeZone.Add(value:  new System.TimeSpan() {_ticks = fireDate * 10000});
            string val_5 = System.String.Format(format:  "{0:yyyy年MM月dd日  HH:mm:ss}", arg0:  val_4);
            object[] val_6 = new object[10];
            val_10 = val_6.Length;
            val_6[0] = "[Notify Time] ";
            if(val_5 != null)
            {
                    val_10 = val_6.Length;
            }
            
            val_6[1] = val_5;
            val_10 = val_6.Length;
            val_6[2] = ", index = ";
            if(bean.index != null)
            {
                    val_10 = val_6.Length;
            }
            
            val_6[3] = bean.index;
            val_10 = val_6.Length;
            val_6[4] = ", title = ";
            val_11 = val_6.Length;
            val_6[5] = Locale.LocaleManager.Translate(key:  bean.title);
            val_11 = val_6.Length;
            val_6[6] = ", content = ";
            val_12 = val_6.Length;
            val_6[7] = Locale.LocaleManager.Translate(key:  bean.content);
            val_12 = val_6.Length;
            val_6[8] = ", id = ";
            val_6[9] = id;
            UnityEngine.Debug.Log(message:  +val_6);
        }
        private static void ScheduleNotification(int id, string title, string body, long fireDate, long interval, System.Collections.Generic.Dictionary<string, string> userData)
        {
            Platform.Notification.LocalNotificationManager.Schedule(id:  id, title:  title, body:  body, fireDate:  fireDate, interval:  interval, userData:  userData, smallIcon:  "notification_small", largeIcon:  "notification_large");
        }
    
    }

}
