using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignDialog : Dialog
    {
        // Fields
        public TMPro.TextMeshProUGUI TextButton;
        public TMPro.TextMeshProUGUI TextTitle;
        public View.Dialog.DailySign.DailySignCalendar SignCalendar;
        
        // Methods
        public void DailySignShowCallback()
        {
            Message.Messager.Dispatch(cmd:  96);
        }
        public void OnClickCloseButton()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameCloseBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceDccScr});
            Message.Messager.Dispatch(cmd:  34);
            Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  4);
        }
        public void OnClickContinueButton()
        {
            System.Object[] val_13;
            string val_14;
            var val_15;
            var val_16;
            BtnClick.BtnNameEnum val_17;
            string val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if((val_1.<DailySignIsCanOperate>k__BackingField) == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.IsAllPassLevelFromCurrentDay()) == false)
            {
                goto label_4;
            }
            
            if((Logic.Game.GameManager.gameLevel.IsAllLevelPass(section:  0, level:  0)) == false)
            {
                goto label_6;
            }
            
            val_13 = 1152921512608631808;
            View.Controller.MainController val_5 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_5._bibleGameState != 2)
            {
                goto label_8;
            }
            
            object[] val_6 = new object[1];
            val_13 = val_6;
            val_13[0] = Locale.LocaleManager.Translate(key:  "133");
            val_14 = "ToastDialog";
            View.Dialog.Common.Dialog val_8 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  val_14, type:  1, pars:  val_6);
            goto label_14;
            label_4:
            Message.Messager.Dispatch(cmd:  34);
            Common.SingletonController<View.Controller.MainController>.Instance.OpenDailyPrayer(dailyPrayerFrom:  2);
            val_15 = null;
            val_15 = null;
            val_16 = null;
            val_17 = BtnClick.BtnNameEnum.BtnNamePlayBtn;
            val_16 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = val_17}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceDccScr});
            val_18 = "scr_daily_calender";
            val_19 = "play_btn";
            goto label_22;
            label_6:
            val_20 = null;
            val_20 = null;
            val_13 = 1152921504832139264;
            val_21 = null;
            val_21 = null;
            Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameMgScr}, curLevel:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceDccScr});
            Common.SingletonController<View.Controller.MainController>.Instance.OpenGame(gameFrom:  3);
            goto label_29;
            label_8:
            Message.Messager.Dispatch(cmd:  34);
            val_14 = 3;
            Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  val_14);
            label_14:
            label_29:
            val_22 = null;
            val_22 = null;
            val_23 = null;
            val_17 = BtnClick.BtnNameEnum.BtnNameContinueBtn;
            val_23 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = val_17}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceDccScr});
            val_18 = "scr_daily_calender";
            val_19 = "continue_btn";
            label_22:
            Platform.Analytics.EzAnalytics.LogEvent(category:  val_18, action:  val_19, label:  "click", value:  0);
        }
        private void SelectSignDay(int day)
        {
            string val_7;
            this.TextButton.text = Locale.LocaleManager.Translate(key:  ((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.IsAllPassLevelFromCurrentDay()) != true) ? "193" : "97");
            if((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.IsAllPassLevelFromCurrentDay()) != false)
            {
                    val_7 = "continue_btn";
            }
            else
            {
                    val_7 = "play_btn";
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_calender", action:  val_7, label:  "show", value:  0);
        }
        private void OpenDailyCloseDailySign()
        {
            goto typeof(View.Dialog.DailySign.DailySignDialog).__il2cppRuntimeField_1E0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add<System.Int32>(cmd:  93, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDialog::SelectSignDay(int day)));
            Message.Messager.Add(cmd:  97, action:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDialog::OpenDailyCloseDailySign()));
            Data.DailyRecord.DailyRecordDataManager val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            this.SelectSignDay(day:  4259840);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_calender", action:  "page", label:  "show", value:  0);
            Data.DailyRecord.DailyRecordDataManager val_4 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_4.<DailySignIsOpened>k__BackingField = true;
            Data.DailyRecord.DailyRecordDataManager val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_5.<DailySignIsCanOperate>k__BackingField = false;
            Message.Messager.Dispatch(cmd:  75);
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  false);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Int32>(cmd:  93, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDialog::SelectSignDay(int day)));
            Message.Messager.Remove(cmd:  97, action:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDialog::OpenDailyCloseDailySign()));
            Data.DailyRecord.DailyRecordDataManager val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_3.<DailySignIsOpened>k__BackingField = false;
            Message.Messager.Dispatch(cmd:  74);
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  true);
        }
        protected override void LocaleTranslate()
        {
            this.TextTitle.text = Locale.LocaleManager.Translate(key:  "96");
            this.SignCalendar.LocaleTranslate();
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameTypeLast(type:  W21, name:  this.name)) == false)
            {
                    return;
            }
            
            Message.Messager.Dispatch(cmd:  34);
            Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  4);
        }
        public DailySignDialog()
        {
            mem[1152921512777146104] = 257;
            mem[1152921512777146107] = 1;
            mem[1152921512777146112] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
