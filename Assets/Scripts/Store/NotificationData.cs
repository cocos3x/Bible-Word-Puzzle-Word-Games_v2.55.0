using UnityEngine;

namespace Store
{
    public class NotificationData : IStoreData
    {
        // Fields
        public bool IsFirstForNotification;
        public bool IsNotificationOn;
        
        // Methods
        public void Reset()
        {
            this.IsFirstForNotification = true;
            this.IsNotificationOn = true;
        }
        public NotificationData()
        {
        
        }
    
    }

}
