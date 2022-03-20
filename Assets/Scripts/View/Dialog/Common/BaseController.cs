using UnityEngine;

namespace View.Dialog.Common
{
    public class BaseController : MonoBehaviour
    {
        // Fields
        public string startSceneName;
        public Common.DontDestroyObject[] playDestroyObjects;
        private static View.Dialog.Common.BaseController <instance>k__BackingField;
        
        // Properties
        public static View.Dialog.Common.BaseController instance { get; set; }
        
        // Methods
        public static View.Dialog.Common.BaseController get_instance()
        {
            return (View.Dialog.Common.BaseController)View.Dialog.Common.BaseController.<instance>k__BackingField;
        }
        protected static void set_instance(View.Dialog.Common.BaseController value)
        {
            View.Dialog.Common.BaseController.<instance>k__BackingField = value;
        }
        protected virtual void Awake()
        {
            var val_9;
            var val_10;
            val_9 = this;
            val_10 = 1152921504818933760;
            if((System.String.op_Inequality(a:  Logic.Game.GameManager.gameScene.CurrentSceneName, b:  this.startSceneName)) != false)
            {
                    if((Logic.Game.GameManager.gameLevel.<finishInited>k__BackingField) == false)
            {
                goto label_4;
            }
            
            }
            
            val_9 = ???;
            val_10 = ???;
            goto typeof(View.Dialog.Common.BaseController).__il2cppRuntimeField_180;
            label_4:
            UnityEngine.Debug.Log(message:  "Play game should start at [" + val_9 + 24(val_9 + 24) + "] scene");
            var val_9 = val_9 + 32;
            if(val_9 == 0)
            {
                goto label_8;
            }
            
            var val_10 = 0;
            label_11:
            if(val_10 >= (val_9 + 32 + 24))
            {
                goto label_8;
            }
            
            val_9 = val_9 + 0;
            (val_9 + 32 + 0) + 32.InitiativeDestroy();
            val_10 = val_10 + 1;
            if((val_9 + 32) != 0)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_8:
            val_10 + 184 + 64.LoadScene(name:  val_9 + 24, useLoadingScreen:  true, callBack:  0);
        }
        protected virtual void DoAwake()
        {
        
        }
        protected virtual void OnEnable()
        {
            View.Dialog.Common.BaseController.<instance>k__BackingField = this;
        }
        protected virtual void OnDisable()
        {
            View.Dialog.Common.BaseController.<instance>k__BackingField = 0;
        }
        public virtual void OnApplicationPause(bool pause)
        {
            var val_4;
            bool val_1 = pause;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "[adui][OnApplicationPause] Pause : "("[adui][OnApplicationPause] Pause : ") + val_1.ToString(), prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(val_1 == false)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.Save();
        }
        public virtual void OnApplicationQuit()
        {
            Platform.Notification.NotificationUtil.ScheduleAllNotify();
        }
        public BaseController()
        {
            this.startSceneName = "Game";
        }
    
    }

}
