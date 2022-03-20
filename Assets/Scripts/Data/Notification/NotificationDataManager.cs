using UnityEngine;

namespace Data.Notification
{
    public class NotificationDataManager : Singleton<Data.Notification.NotificationDataManager>
    {
        // Properties
        public bool IsNotificationOn { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public bool get_IsNotificationOn()
        {
            return (bool)typeof(Store.NotificationData).__il2cppRuntimeField_11;
        }
        private void set_IsNotificationOn(bool value)
        {
            typeof(Store.NotificationData).__il2cppRuntimeField_11 = value;
        }
        public void SetNotificationOn(bool isOn)
        {
            this.IsNotificationOn = isOn;
        }
        public NotificationDataManager()
        {
        
        }
    
    }

}
