using UnityEngine;

namespace View.Dialog.ResultDaily
{
    public class ResultDailyBottom : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorBottoms;
        public UnityEngine.UI.Button ButtonVideo;
        public UnityEngine.UI.Button ButtonVideoTest;
        public TMPro.TextMeshProUGUI TextReward;
        public TMPro.TextMeshProUGUI TextOpen;
        public TMPro.TextMeshProUGUI TextNextLevel;
        public UnityEngine.UI.Image ImageIconCoin;
        public UnityEngine.UI.Image ImageIconHint;
        private Data.Bean.BibleSection _bibleSection;
        private bool _isLastLevel;
        private bool _videoClick;
        private bool _videoCallback;
        private bool _isClickNext;
        private bool _isBibleLastChapter;
        private int _rewardCount;
        
        // Methods
        public void LocaleTranslate()
        {
            this.TextOpen.text = Locale.LocaleManager.Translate(key:  "68");
            this.TextNextLevel.text = Locale.LocaleManager.Translate(key:  "38");
        }
        public void PlayShowBottomAni()
        {
            this.AnimatorBottoms.Play(stateName:  "ResultBottomsAni");
        }
        public void OnClickNextButton()
        {
            if(this._isClickNext != false)
            {
                    return;
            }
            
            this._isClickNext = true;
            Message.Messager.Dispatch(cmd:  4);
        }
        public void ShowBottoms()
        {
            this._isClickNext = false;
            this.ButtonVideo.gameObject.SetActive(value:  false);
            this.ButtonVideoTest.gameObject.SetActive(value:  false);
            this.UpdateButtonState();
        }
        private void LevelPassVideoReward()
        {
            this.ButtonVideo.gameObject.SetActive(value:  false);
            this.ButtonVideoTest.gameObject.SetActive(value:  false);
        }
        private void UpdateButtonState()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_16 = null;
            val_16 = null;
            val_17 = null;
            val_17 = null;
            val_18 = null;
            val_18 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.LevelPass, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionLevelPass});
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            val_21 = null;
            val_21 = null;
            val_22 = null;
            val_22 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceLevelPass}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.LevelPass), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionLevelPass});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "level_finish", label:  "reward_btn_show", value:  0);
            this.ButtonVideo.gameObject.SetActive(value:  (~Platform.AbTest.GameABTestManager.IsRewardAd_UI()) & 1);
            this.ButtonVideoTest.gameObject.SetActive(value:  Platform.AbTest.GameABTestManager.IsRewardAd_UI());
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "game_ad_reward", action:  "ad_enter_show", lable:  Platform.Ad.GameAdPosition.LevelPass);
            int val_9 = GetRewardCount();
            this._rewardCount = val_9;
            this.TextReward.text = "+"("+") + val_9;
            if(Platform.AbTest.GameABTestManager.IsRewardAd_UI() != false)
            {
                    this.AddButtonListener(btn:  this.ButtonVideoTest);
                this.ImageIconCoin.gameObject.SetActive(value:  (this._rewardCount != 1) ? 1 : 0);
                this.ImageIconHint.gameObject.SetActive(value:  (this._rewardCount == 1) ? 1 : 0);
                return;
            }
            
            this.AddButtonListener(btn:  this.ButtonVideo);
        }
        private void AddButtonListener(UnityEngine.UI.Button btn)
        {
            null = null;
            Common.GameButtonUtil.AddVideoListener(btn:  btn, adFrom:  Platform.Ad.GameAdPosition.LevelPass, position:  Platform.Ad.GameAdPosition.LevelPass, onClick:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyBottom::<AddButtonListener>b__21_0()), onSkip:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyBottom::<AddButtonListener>b__21_1()), onFinish:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyBottom::<AddButtonListener>b__21_2()), clearListenner:  true);
        }
        private int GetRewardCount()
        {
            return Common.Singleton<Data.Reward.RewardDataManager>.Instance.GetBoxRewardCount1();
        }
        public ResultDailyBottom()
        {
            this._rewardCount = 50;
        }
        private void <AddButtonListener>b__21_0()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceLevelPass}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.LevelPass), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionLevelPass});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "level_finish", label:  "reward_btn_click", value:  0);
            this._videoClick = true;
        }
        private void <AddButtonListener>b__21_1()
        {
            this._videoCallback = true;
        }
        private void <AddButtonListener>b__21_2()
        {
            if(Platform.AbTest.GameABTestManager.IsRewardLevelAd() != false)
            {
                    this.LevelPassVideoReward();
            }
            else
            {
                    Logic.Gameplay.GameplayController val_2 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
                val_2.<GameSceneShouldAd>k__BackingField = false;
            }
            
            mem2[0] = 2;
            Logic.Game.GameManager.gameDialog.Open(name:  "RewardTestDialog", type:  0).SetRewardCount(count:  this._rewardCount, extra:  0);
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddShowLevelPassVideoCount();
            Platform.Analytics.EzAnalytics.LevelPassVideoTimes();
        }
    
    }

}
