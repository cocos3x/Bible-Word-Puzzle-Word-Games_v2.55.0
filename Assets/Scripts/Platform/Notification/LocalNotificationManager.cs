using UnityEngine;

namespace Platform.Notification
{
    public static class LocalNotificationManager
    {
        // Fields
        private static Beatles.INotificationService _service;
        
        // Methods
        public static void Init()
        {
            var val_2;
            Beatles.MobileNotifications.Create();
            Platform.Notification.LocalNotificationManager._service = Beatles.MobileNotifications._instance;
            val_2 = null;
            val_2 = null;
            Beatles.ServicePlatforms.NotificationCallback._callback = new System.Action<Beatles.LocalNotification>(object:  0, method:  static System.Void Platform.Notification.LocalNotificationManager::OnReceiveNotification(Beatles.LocalNotification data));
        }
        private static void OnReceiveNotification(Beatles.LocalNotification data)
        {
            int val_9 = data._id;
            val_9 = val_9 * 1717986919;
            val_9 = val_9 >> 34;
            val_9 = val_9 + (val_9 >> 63);
            set_Item(key:  "id", value:  val_9);
            set_Item(key:  "txt_key", value:  data._userData.Item["ContentId"]);
            System.DateTime val_4 = System.DateTime.Now;
            set_Item(key:  "data", value:  val_4.dateData.ToString(format:  "yyyyMMdd"));
            System.DateTime val_7 = System.DateTime.Now;
            Platform.Analytics.EzAnalytics.SendPushClick(pushId:  data._userData.Item["ContentId"], pushTime:  val_7.dateData.ToString(format:  "HH"));
            UnityAnalytics.GameAnalytics.SendEvent(eventName:  "act_click_noti", paramsDict:  new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  3), platform:  4);
        }
        public static void Schedule(int id, string title, string body, long fireDate, long interval, System.Collections.Generic.Dictionary<string, string> userData, string smallIcon = "", string largeIcon = "")
        {
            string val_5;
            string val_6;
            val_5 = largeIcon;
            Beatles.LocalNotification val_1 = null;
            val_6 = title;
            val_1 = new Beatles.LocalNotification(id:  id, title:  val_6, body:  body, fireDate:  fireDate);
            typeof(Beatles.LocalNotification).__il2cppRuntimeField_18 = interval;
            typeof(Beatles.LocalNotification).__il2cppRuntimeField_38 = val_5;
            typeof(Beatles.LocalNotification).__il2cppRuntimeField_40 = smallIcon;
            if(userData == null)
            {
                goto label_14;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = userData.GetEnumerator();
            val_5 = 1152921507982172224;
            label_5:
            if(0.MoveNext() == false)
            {
                goto label_3;
            }
            
            if(1179403647 == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(key:  0, value:  0);
            goto label_5;
            label_3:
            0.Dispose();
            label_14:
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = 0;
            Platform.Notification.LocalNotificationManager._service.ScheduleNotification(notification:  val_1);
        }
        public static bool IsEnable()
        {
            if(Platform.Notification.LocalNotificationManager._service == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Platform.Notification.LocalNotificationManager._service.IsEnabled();
        }
        public static void CancelAll()
        {
            if(Platform.Notification.LocalNotificationManager._service == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            Platform.Notification.LocalNotificationManager._service.CancelNotification(id:  0);
        }
    
    }

}
