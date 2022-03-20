using UnityEngine;

namespace View.Dialog.Common
{
    public class NotificationButton : MonoBehaviour
    {
        // Fields
        private View.CommonItem.ImageSwitch funSwitch;
        
        // Methods
        private void Awake()
        {
            this.funSwitch = this.GetComponent<View.CommonItem.ImageSwitch>();
            UnityEngine.UI.Button val_2 = this.GetComponent<UnityEngine.UI.Button>();
            val_2.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Common.NotificationButton::<Awake>b__1_0()));
        }
        private void Start()
        {
            var val_4;
            if((Common.Singleton<Data.Notification.NotificationDataManager>.Instance.IsNotificationOn) == false)
            {
                goto label_2;
            }
            
            val_4 = 0;
            bool val_3 = Platform.Notification.NotificationUtil.IsNotificationAllow();
            if(this.funSwitch != null)
            {
                goto label_3;
            }
            
            label_2:
            val_4 = 0;
            label_3:
            this.funSwitch.isOn = val_4 & 1;
        }
        private void OnApplicationPause(bool pause)
        {
            var val_4;
            if((Common.Singleton<Data.Notification.NotificationDataManager>.Instance.IsNotificationOn) == false)
            {
                goto label_2;
            }
            
            val_4 = 0;
            bool val_3 = Platform.Notification.NotificationUtil.IsNotificationAllow();
            if(this.funSwitch != null)
            {
                goto label_3;
            }
            
            label_2:
            val_4 = 0;
            label_3:
            this.funSwitch.isOn = val_4 & 1;
        }
        public NotificationButton()
        {
        
        }
        private void <Awake>b__1_0()
        {
            var val_5;
            var val_6;
            bool val_1 = (this.funSwitch._isOn == false) ? 1 : 0;
            Common.Singleton<Data.Notification.NotificationDataManager>.Instance.SetNotificationOn(isOn:  val_1);
            this.funSwitch.isOn = val_1;
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameNotiBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceMenuDlg});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_home_menu", action:  "click_btn_notif", label:  (this.funSwitch._isOn == false) ? "off" : "on", value:  0);
            if(this.funSwitch._isOn != false)
            {
                    Platform.Notification.NotificationUtil.CleanAllNotification();
                return;
            }
            
            bool val_4 = Platform.Notification.NotificationUtil.IsNotificationAllow();
        }
    
    }

}
