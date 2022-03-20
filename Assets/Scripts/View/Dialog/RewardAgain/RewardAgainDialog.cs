using UnityEngine;

namespace View.Dialog.RewardAgain
{
    public class RewardAgainDialog : Dialog
    {
        // Fields
        public TMPro.TextMeshProUGUI rewardText;
        public UnityEngine.Transform coinFlyStart;
        public UnityEngine.Sprite[] SpriteCoins;
        public UnityEngine.UI.Image ImageCoin;
        public UnityEngine.UI.Image ImageHint;
        public UnityEngine.UI.Button ButtonVideo;
        public UnityEngine.Transform TimeBubble;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public TMPro.TMP_Text ClaimText;
        public TMPro.TMP_Text WatchMoreText;
        private bool _isInitialRewardAd;
        private int _rewardCount;
        private Logic.Define.RewardedVideoTriggerType triggerType;
        private bool isClaimClicked;
        private bool _isPlayInnerAdState;
        
        // Methods
        public void OnClaim()
        {
            if(this.isClaimClicked != false)
            {
                    return;
            }
            
            this.isClaimClicked = true;
            this.ClaimCoin(callBack:  0);
        }
        public void OnClickVideoButton()
        {
            if(this.isClaimClicked != false)
            {
                    return;
            }
            
            this.isClaimClicked = true;
            this.ClaimCoin(callBack:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::OnGainCoinCallbackVideo()));
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "197");
            string val_2 = Locale.LocaleManager.Translate(key:  "106");
            this.ClaimText.text = Locale.LocaleManager.Translate(key:  "44");
            this.WatchMoreText.text = Locale.LocaleManager.Translate(key:  "198");
        }
        private void PlayAd()
        {
            object val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_11 = this;
            if(this._rewardCount == 30)
            {
                    if(this._isInitialRewardAd == false)
            {
                goto label_2;
            }
            
            }
            
            val_12 = null;
            val_12 = null;
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            val_15 = null;
            val_15 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceWatchMore5s}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.WatchMore5s), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeInterstitial}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionWatchMore5s});
            this._isPlayInnerAdState = true;
            val_16 = null;
            val_16 = null;
            Platform.Ad.InterstitialPlacement val_3 = new Platform.Ad.InterstitialPlacement(placementID:  Platform.Ad.GameAdID.InterstitalLevelPassID);
            typeof(Platform.Ad.InterstitialPlacement).__il2cppRuntimeField_30 = new System.Action<System.String>(object:  this, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::<PlayAd>b__19_0(string adTaskID));
            System.Action val_5 = new System.Action(object:  this, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::<PlayAd>b__19_1());
            System.Action val_6 = new System.Action(object:  this, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::<PlayAd>b__19_2());
            label_31:
            val_11 = ???;
            goto mem[null + 464];
            label_2:
            val_17 = null;
            val_17 = null;
            val_18 = null;
            val_18 = null;
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceWatchMoreReward}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.WatchMoreReward), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionWatchMoreReward});
            val_21 = null;
            val_21 = null;
            Platform.Ad.RewardPlacement val_9 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
            typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = new System.Action<System.String, System.Boolean>(object:  val_11, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::<PlayAd>b__19_3(string adTaskID, bool isReward));
            RegisterDefaultLogEvent(adFrom:  Platform.Ad.GameAdPosition.WatchMoreReward);
            goto label_31;
        }
        private void AdCallback()
        {
            if(this._isPlayInnerAdState == false)
            {
                    return;
            }
            
            this._isPlayInnerAdState = false;
            mem2[0] = this.triggerType;
            if(this._rewardCount == 30)
            {
                    if(this._isInitialRewardAd == false)
            {
                goto label_8;
            }
            
            }
            
            label_8:
            Logic.Game.GameManager.gameDialog.Open(name:  "RewardAgainDialog", type:  0).SetRewardCount(count:  30, isInitialRewardAd:  false);
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.isClaimClicked = false;
            this._isPlayInnerAdState = false;
            this.AddTodayPlayCount();
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::AdCallback()));
        }
        private void OnCloseUI()
        {
            if(this.triggerType == 2)
            {
                    Message.Messager.Dispatch(cmd:  2);
            }
        
        }
        private void OnGainCoinCallbackVideo()
        {
            this.PlayAd();
        }
        private void ClaimCoin(UnityEngine.Events.UnityAction callBack)
        {
            var val_5;
            if(this._rewardCount != 1)
            {
                goto label_1;
            }
            
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddHintFreeStatus(hint:  this._rewardCount);
            Message.Messager.Dispatch(cmd:  71);
            if(callBack == null)
            {
                goto label_6;
            }
            
            callBack.Invoke();
            goto label_6;
            label_1:
            val_5 = Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1);
            UnityEngine.Vector3 val_3 = this.coinFlyStart.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_5.GainCoin(amount:  this._rewardCount, from:  "video_play", centerPosition:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, time:  0.5f, delay:  0f, onFinish:  callBack, count:  0);
            label_6:
            this.OnCloseUI();
        }
        private int GetTodayPlayCount()
        {
            return Common.Singleton<Data.Reward.RewardDataManager>.Instance.RewardDayCount;
        }
        private void AddTodayPlayCount()
        {
            Data.Reward.RewardDataManager val_1 = Common.Singleton<Data.Reward.RewardDataManager>.Instance;
            Data.Reward.RewardDataManager val_3 = Common.Singleton<Data.Reward.RewardDataManager>.Instance;
            if((Common.GlobalMethods.IsToday(des:  new System.DateTime() {dateData = val_1._lastRewardDateTime}, res:  new System.Nullable<System.DateTime>() {HasValue = false})) != false)
            {
                    val_3.AddRewardDayCount();
                return;
            }
            
            System.DateTime val_4 = System.DateTime.Now;
            val_3.LastRewardDateTime = new System.DateTime() {dateData = val_4.dateData};
            Common.Singleton<Data.Reward.RewardDataManager>.Instance.SetRewardDayCount(count:  1);
        }
        public void SetTriggerType(Logic.Define.RewardedVideoTriggerType type)
        {
            this.triggerType = type;
        }
        public void SetRewardCount(int count, bool isInitialRewardAd = False)
        {
            bool val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            this._rewardCount = count;
            mem[1152921512680053344] = isInitialRewardAd;
            UnityEngine.GameObject val_2 = this.TimeBubble.gameObject;
            if(this._rewardCount != 30)
            {
                goto label_2;
            }
            
            val_12 = this._isInitialRewardAd;
            if(val_2 != null)
            {
                goto label_3;
            }
            
            label_2:
            val_12 = 1;
            label_3:
            val_2.SetActive(value:  (val_12 != 0) ? 1 : 0);
            if(this._rewardCount == 30)
            {
                    if(this._isInitialRewardAd == false)
            {
                goto label_7;
            }
            
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            val_15 = null;
            val_15 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.WatchMore5s, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeInterstitial}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionWatchMore5s});
            val_16 = null;
            val_16 = null;
            val_17 = null;
            val_17 = null;
            val_18 = null;
            val_18 = null;
            val_19 = null;
            val_19 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceWatchMore5s}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.WatchMore5s), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeInterstitial}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionWatchMore5s});
            label_45:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_ad_reward", action:  "ad_enter_show", label:  Platform.Ad.GameAdPosition.WatchMore5s, value:  0);
            if(this._rewardCount == 1)
            {
                    this.SetRewardInfo(isHint:  true);
                return;
            }
            
            this.SetRewardInfo(isHint:  false);
            this.rewardText.text = "x" + this._rewardCount.ToString();
            if(this.SpriteCoins.Length >= 2)
            {
                    var val_8 = (this._rewardCount > 40) ? 40 : 32;
                this.ImageCoin.sprite = null;
            }
            
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  this._rewardCount);
            return;
            label_7:
            val_20 = null;
            val_20 = null;
            val_21 = null;
            val_21 = null;
            val_22 = null;
            val_22 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.WatchMoreReward, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionWatchMoreReward});
            val_23 = null;
            val_23 = null;
            val_24 = null;
            val_24 = null;
            val_25 = null;
            val_25 = null;
            val_26 = null;
            val_26 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceWatchMoreReward}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.WatchMoreReward), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionWatchMoreReward});
            goto label_45;
        }
        private void SetRewardInfo(bool isHint)
        {
            this.ImageCoin.gameObject.SetActive(value:  (~isHint) & 1);
            this.ImageHint.gameObject.SetActive(value:  isHint);
        }
        private void OnDialogShow()
        {
            this.AddTodayPlayCount();
        }
        public RewardAgainDialog()
        {
            this.triggerType = 3;
        }
        private void <PlayAd>b__19_0(string adTaskID)
        {
            if(this._isPlayInnerAdState == false)
            {
                    return;
            }
            
            this.AdCallback();
        }
        private void <PlayAd>b__19_1()
        {
            null = null;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "level_pass_ad_interstitial", action:  "a1_show_from", label:  Platform.Ad.GameAdPosition.WatchMore5s, value:  0);
            Common.TimerEvent.Add(time:  0.5f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.RewardAgain.RewardAgainDialog::AdCallback()), isrepeat:  false);
        }
        private void <PlayAd>b__19_2()
        {
            var val_4;
            this._isPlayInnerAdState = false;
            val_4 = null;
            val_4 = null;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "toast_video_load", action:  "show", label:  Platform.Ad.GameAdPosition.WatchMore5s, value:  0);
            object[] val_1 = new object[1];
            val_1[0] = Locale.LocaleManager.Translate(key:  "110");
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_1);
        }
        private void <PlayAd>b__19_3(string adTaskID, bool isReward)
        {
            if(isReward == false)
            {
                    return;
            }
            
            mem2[0] = this.triggerType;
            Logic.Game.GameManager.gameDialog.Open(name:  "RewardAgainDialog", type:  0).SetRewardCount(count:  40, isInitialRewardAd:  false);
        }
    
    }

}
