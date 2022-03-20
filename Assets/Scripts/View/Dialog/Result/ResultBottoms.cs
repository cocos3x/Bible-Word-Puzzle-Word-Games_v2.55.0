using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultBottoms : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorBottoms;
        public UnityEngine.UI.Button ButtonText;
        public UnityEngine.UI.Button ButtonBox;
        public UnityEngine.UI.Button ButtonNext;
        public TMPro.TextMeshProUGUI TextReward;
        public TMPro.TextMeshProUGUI TextOpen;
        public TMPro.TextMeshProUGUI TextNextLevel;
        private Data.Bean.BibleSection _bibleSection;
        private bool _isLastLevel;
        private bool _canVideo;
        private bool _videoClick;
        private bool _videoCallback;
        private bool _isSectionPass;
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
            if(this._isSectionPass != false)
            {
                    Message.Messager.Dispatch<System.Boolean>(cmd:  3, t:  false);
                return;
            }
            
            Message.Messager.Dispatch(cmd:  1);
        }
        private bool CheckLevelCanVideo()
        {
            if(this._isLastLevel == false)
            {
                    return false;
            }
            
            return Common.SingletonController<Logic.Game.GameControllers>.Instance.IsRewardAdStartedForReward();
        }
        public void ShowBottoms(bool isSectionPass = False)
        {
            this._isClickNext = false;
            this._isSectionPass = isSectionPass;
            this._isLastLevel = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0);
            this._canVideo = this.CheckLevelCanVideo();
            this.ButtonText.gameObject.SetActive(value:  false);
            this.ButtonBox.gameObject.SetActive(value:  false);
            if(this._canVideo == false)
            {
                    return;
            }
            
            if(isSectionPass == true)
            {
                    return;
            }
            
            this.UpdateButtonState();
        }
        private void LevelPassVideoReward()
        {
            this.ButtonText.gameObject.SetActive(value:  false);
            this.ButtonBox.gameObject.SetActive(value:  false);
        }
        private Platform.AbTest.ResultVideoRewardType GetResultVideoRewardType()
        {
            return 1;
        }
        private void UpdateButtonState()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.LevelPass, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionLevelPass});
            val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            val_12 = null;
            val_12 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceLevelPass}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.LevelPass), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionLevelPass});
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "game_ad_reward", action:  "ad_enter_show", lable:  Platform.Ad.GameAdPosition.LevelPass);
            this._rewardCount = GetRewardCount();
            this.ButtonText.gameObject.SetActive(value:  true);
            this.TextReward.text = "+"("+") + this._rewardCount;
            this.AddButtonListener(btn:  this.ButtonText);
        }
        private void AddButtonListener(UnityEngine.UI.Button btn)
        {
            null = null;
            Common.GameButtonUtil.AddVideoListener(btn:  btn, adFrom:  Platform.Ad.GameAdPosition.LevelPass, position:  Platform.Ad.GameAdPosition.LevelPass, onClick:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Result.ResultBottoms::<AddButtonListener>b__24_0()), onSkip:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Result.ResultBottoms::<AddButtonListener>b__24_1()), onFinish:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Result.ResultBottoms::<AddButtonListener>b__24_2()), clearListenner:  true);
        }
        private int GetRewardCount()
        {
            return Common.Singleton<Data.Reward.RewardDataManager>.Instance.GetBoxRewardCount1();
        }
        public ResultBottoms()
        {
            this._rewardCount = 50;
        }
        private void <AddButtonListener>b__24_0()
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
            this._videoClick = true;
        }
        private void <AddButtonListener>b__24_1()
        {
            this._videoCallback = true;
        }
        private void <AddButtonListener>b__24_2()
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
            Platform.Analytics.EzAnalytics.LogEvent(category:  "level_pass_bonus", action:  "button_video_gain", label:  "", value:  0);
        }
    
    }

}
