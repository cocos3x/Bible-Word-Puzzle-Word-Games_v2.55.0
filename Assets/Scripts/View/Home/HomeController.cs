using UnityEngine;

namespace View.Home
{
    public class HomeController : BaseController
    {
        // Fields
        public UnityEngine.GameObject dailyRedPoint;
        
        // Methods
        public static View.Home.HomeController GetInstance()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            return 0;
        }
        private void OpenHome()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 2)
            {
                    return;
            }
            
            Platform.Ad.GameAdManager.<Instance>k__BackingField.HideBannerAd();
            Logic.Game.GameManager.gameMusic.PlayHome();
            this.CheckHomeDialyPoint();
        }
        private void OpenHomeCallback()
        {
            var val_8;
            var val_9;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 2)
            {
                    return;
            }
            
            bool val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance.ShouldShowDailyLottery();
            if(val_3 != false)
            {
                    val_8 = null;
                val_8 = null;
                val_9 = null;
                val_9 = null;
                Platform.Analytics.EzAnalytics.SendDlgShow(dlgName:  new DlgNameEnum() {<Value>k__BackingField = DlgShow.DlgNameEnum.DlgNameDrDlg}, timing:  new TimingEnum() {<Value>k__BackingField = DlgShow.TimingEnum.TimingAuto});
                View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.Open(name:  "DailyLotteryTestDialog", type:  0).OnCancel(action:  new System.Action(object:  this, method:  System.Void View.Home.HomeController::AfterDailyLottery()));
            }
            else
            {
                    val_3.CheckShowHomeDailyDialog();
            }
            
            Common.Singleton<Data.Login.LoginDataManager>.Instance.UpdateDataFromDay();
        }
        private void AfterDailyLottery()
        {
            this.CheckShowHomeDailyDialog();
        }
        private void CheckShowHomeDailyDialog()
        {
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowHomeDailyDialog) == false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "HomeDailyGuideDialog", type:  2);
        }
        public void CheckHomeDialyPoint()
        {
            var val_3;
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.GetShouldShowHomeDailyPoint()) != false)
            {
                    val_3 = 1;
            }
            else
            {
                    val_3 = 0;
            }
            
            this.dailyRedPoint.SetActive(value:  false);
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  0)) != false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "QuitGameDialog", type:  0);
        }
        public override void OnApplicationPause(bool pause)
        {
            pause = pause;
            this.OnApplicationPause(pause:  pause);
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState == 1)
            {
                    return;
            }
            
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState != 2)
            {
                    return;
            }
            
            if(pause == true)
            {
                    return;
            }
            
            Common.Singleton<Data.Login.LoginDataManager>.Instance.UpdateDataFromDay();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add(cmd:  40, action:  new System.Action(object:  this, method:  System.Void View.Home.HomeController::OpenHome()));
            Message.Messager.Add(cmd:  41, action:  new System.Action(object:  this, method:  System.Void View.Home.HomeController::OpenHomeCallback()));
            this.OpenHome();
        }
        protected override void OnDisable()
        {
            Message.Messager.Remove(cmd:  40, action:  new System.Action(object:  this, method:  System.Void View.Home.HomeController::OpenHome()));
            Message.Messager.Remove(cmd:  41, action:  new System.Action(object:  this, method:  System.Void View.Home.HomeController::OpenHomeCallback()));
        }
        public HomeController()
        {
        
        }
    
    }

}
