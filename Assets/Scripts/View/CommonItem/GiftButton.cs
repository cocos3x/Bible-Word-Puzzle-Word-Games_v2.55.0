using UnityEngine;

namespace View.CommonItem
{
    public class GiftButton : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Button ButtonGiftBox;
        public UnityEngine.Animator AnimatorGiftBox;
        private UnityEngine.RectTransform _rectGift;
        private int _rewardCount;
        private bool _isShowingGift;
        
        // Methods
        public void OnClickGiftButton()
        {
            if(this._isShowingGift == false)
            {
                    return;
            }
            
            if(this.IsGameComplete() == true)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "DailyGuideDialog")) != false)
            {
                    return;
            }
            
            this.HideSideButton();
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "game_ad_reward", action:  "ad_enter_show", lable:  "game_TV");
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.IsReconfirmWatchVideo) != false)
            {
                    if(Platform.AbTest.GameABTestManager.IsRewardAd_UI() != false)
            {
                    View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.Open(name:  "ReconfirmDialog", type:  0);
                return;
            }
            
            }
            
            this.showRewardedVideoAd(triggerType:  1);
        }
        private void ShowGiftButton()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if(this._isShowingGift != false)
            {
                    UnityEngine.Vector2 val_1 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  -50f);
                this._rectGift.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                this.AnimatorGiftBox.Play(stateName:  "GameGiftCoinFall");
                return;
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            val_15 = null;
            val_15 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.GameButton, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionGameButton});
            val_16 = null;
            val_16 = null;
            val_17 = null;
            val_17 = null;
            val_18 = null;
            val_18 = null;
            val_19 = null;
            val_19 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceGameButton}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.GameButton), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionGameButton});
            this._isShowingGift = true;
            int val_5 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this.AnimatorGiftBox.Play(stateName:  "GameGiftDefault");
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  200f);
            this._rectGift.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this._rectGift, endValue:  -50f, duration:  0.5f, snapping:  false), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.GiftButton::<ShowGiftButton>b__6_0())), id:  this);
        }
        private void HideSideButton()
        {
            if(this._isShowingGift == false)
            {
                    return;
            }
            
            if(this._rectGift == 0)
            {
                    return;
            }
            
            this._isShowingGift = false;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  -50f);
            this._rectGift.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this._rectGift, endValue:  200f, duration:  0.5f, snapping:  false), ease:  26), id:  this);
        }
        private void Awake()
        {
            UnityEngine.RectTransform val_3;
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_3 = 0;
            }
            
            this._rectGift = val_3;
        }
        private void UpdateGiftButton()
        {
            if(this.IsGameComplete() == true)
            {
                    return;
            }
            
            if((Common.SingletonController<Logic.Game.GameControllers>.Instance.IsRewardAdStarted()) == false)
            {
                    return;
            }
            
            this.ShowGiftButton();
        }
        private bool IsGameComplete()
        {
            bool val_10;
            var val_11;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                goto label_2;
            }
            
            if(View.Game.GameController.GetInstance() == 0)
            {
                goto label_12;
            }
            
            View.Game.GameController val_4 = View.Game.GameController.GetInstance();
            val_10 = val_4.<isGameComplete>k__BackingField;
            goto label_7;
            label_2:
            View.Controller.MainController val_5 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_5._bibleGameState != 4)
            {
                goto label_9;
            }
            
            if(View.DailyPrayer.DailyPrayerController.GetInstance() == 0)
            {
                goto label_12;
            }
            
            View.DailyPrayer.DailyPrayerController val_8 = View.DailyPrayer.DailyPrayerController.GetInstance();
            val_10 = val_8.<isGameComplete>k__BackingField;
            label_7:
            var val_9 = (val_10 == true) ? 1 : 0;
            return (bool)val_11;
            label_12:
            val_11 = 0;
            return (bool)val_11;
            label_9:
            val_11 = 1;
            return (bool)val_11;
        }
        private void ShowSideButtonGift()
        {
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide()) != false)
            {
                    return;
            }
            
            this.UpdateGiftButton();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  53, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.GiftButton::ShowSideButtonGift()));
            Message.Messager.Add(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.GiftButton::HideSideButton()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  53, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.GiftButton::ShowSideButtonGift()));
            Message.Messager.Remove(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.GiftButton::HideSideButton()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.CommonItem.GiftButton::UpdateGiftButton()));
            this._isShowingGift = false;
        }
        private void showRewardedVideoAd(Logic.Define.RewardedVideoTriggerType triggerType)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            object val_1 = new System.Object();
            typeof(GiftButton.<>c__DisplayClass14_0).__il2cppRuntimeField_10 = this;
            typeof(GiftButton.<>c__DisplayClass14_0).__il2cppRuntimeField_18 = triggerType;
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceGameButton}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.GameButton), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionGameButton});
            val_12 = null;
            val_12 = null;
            Platform.Ad.RewardPlacement val_4 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
            typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = new System.Action<System.String, System.Boolean>(object:  val_1, method:  System.Void GiftButton.<>c__DisplayClass14_0::<showRewardedVideoAd>b__0(string adTaskID, bool isReward));
            typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_30 = new System.Action<System.String>(object:  val_1, method:  System.Void GiftButton.<>c__DisplayClass14_0::<showRewardedVideoAd>b__1(string adTaskID));
            RegisterDefaultLogEvent(adFrom:  Platform.Ad.GameAdPosition.GameButton);
            System.Action val_7 = new System.Action(object:  val_1, method:  System.Void GiftButton.<>c__DisplayClass14_0::<showRewardedVideoAd>b__2());
            goto mem[null + 464];
        }
        private int GetRewardCount()
        {
            return Common.Singleton<Data.Reward.RewardDataManager>.Instance.GetBoxRewardCount2();
        }
        public GiftButton()
        {
        
        }
        private void <ShowGiftButton>b__6_0()
        {
            this.AnimatorGiftBox.Play(stateName:  "GameGiftCoinFall");
        }
    
    }

}
