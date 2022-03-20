using UnityEngine;

namespace View.Home
{
    public class Entrancepanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject ObjDaily;
        public UnityEngine.Transform TransformFrame;
        public View.Home.HomeDailySignProgress SignProgress;
        private View.Home.Entrancepanel.DailyStatus dailyStatus;
        private bool isClickPlay;
        
        // Methods
        private void OnEnable()
        {
            this.isClickPlay = false;
            if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) + 1) >= 2)
            {
                    this.OnDailyEnable();
            }
            else
            {
                    this.OnDailyHide();
            }
            
            this.SignProgress.gameObject.SetActive(value:  true);
            this.SignProgress.SetDailySignProgress();
        }
        private void OnDailyHide()
        {
            this.dailyStatus = 0;
            this.ObjDaily.SetActive(value:  false);
            this.TransformFrame.gameObject.SetActive(value:  true);
        }
        private void OnDailyEnable()
        {
            this.ObjDaily.SetActive(value:  true);
            this.TransformFrame.gameObject.SetActive(value:  false);
            this.dailyStatus = 2;
        }
        public void OnPlayClick()
        {
            GameScrShow.ScrNameEnum val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_9 = this;
            if(this.isClickPlay != false)
            {
                    return;
            }
            
            this.isClickPlay = true;
            val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNamePlayBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceHomeScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_prepare", action:  "a1_button_play_click", label:  "", value:  0);
            if((Logic.Game.GameManager.gameLevel.IsAllLevelPass(section:  0, level:  0)) != false)
            {
                    this.isClickPlay = false;
                object[] val_2 = new object[1];
                val_2[0] = Locale.LocaleManager.Translate(key:  "133");
                View.Dialog.Common.Dialog val_4 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_2);
                return;
            }
            
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != true)
            {
                    val_12 = null;
                val_12 = null;
                val_9 = GameScrShow.ScrNameEnum.ScrNameMgScr;
                val_13 = null;
                val_13 = null;
                Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = val_9}, curLevel:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceHomeScr});
            }
            
            Common.SingletonController<View.Controller.MainController>.Instance.OpenGame(gameFrom:  0);
        }
        public void OnDailyClick()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetShouldShowHomeDailyPoint(isShould:  false);
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState == 2)
            {
                    View.Home.HomeController.GetInstance().CheckHomeDialyPoint();
            }
            
            if(this.dailyStatus != 2)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameDcBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceHomeScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_prepare", action:  "a1_button_daily_puzzle_click", label:  "fly", value:  0);
            Data.DailyRecord.DailyRecordDataManager val_4 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_4.<CurrentDailyDay>k__BackingField = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SignToday;
            if((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetUnlockDailyLevelIndex()) == 3)
            {
                    Data.DailyRecord.DailyRecordDataManager val_9 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                val_9.<DailySignBeforeCollectStar>k__BackingField = (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord) - (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyDayStarCollectNum());
                View.Dialog.Common.Dialog val_15 = Logic.Game.GameManager.gameDialog.Open(name:  "DailySignDialog", type:  0);
                return;
            }
            
            val_21 = null;
            val_21 = null;
            val_22 = null;
            val_22 = null;
            Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameDcScr}, curLevel:  Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance.GetCurDailyLevel(), source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceHomeScr});
            Common.SingletonController<View.Controller.MainController>.Instance.OpenDailyPrayer(dailyPrayerFrom:  1);
        }
        public Entrancepanel()
        {
        
        }
    
    }

}
