using UnityEngine;

namespace View.CommonItem
{
    public class LetterGift : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorGift;
        private bool _isHideGifting;
        
        // Methods
        public void OnClickGiftButton()
        {
            if(this._isHideGifting != false)
            {
                    return;
            }
            
            bool val_2 = Common.Singleton<Data.Guide.GuideDataManager>.Instance.IsLetterGiftReconfirm;
            if(val_2 != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game_ad_reward", action:  "ad_enter_show", label:  "wrong_4times_gift_pop", value:  0);
                View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "FreeGiftTestDialog", type:  0);
                return;
            }
            
            val_2.PlayAd();
        }
        public void PlayShowGiftAni()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.Wrong4TimesGift, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionWrong4timesGift});
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameWrongRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceWrong4timesGift}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.Wrong4TimesGift), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionWrong4timesGift});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_ad_reward", action:  "ad_enter_show", label:  Platform.Ad.GameAdPosition.Wrong4TimesGift, value:  0);
            this.AnimatorGift.Play(stateName:  "GiftBoxBorn");
        }
        public void PlayHideGiftAni()
        {
            this._isHideGifting = true;
            this.AnimatorGift.Play(stateName:  "GiftBoxDeath");
        }
        private void PlayAd()
        {
            var val_5;
            var val_6;
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Action<System.String, System.Boolean> val_13;
            var val_14;
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            val_7 = Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.Wrong4TimesGift);
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameWrongRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceWrong4timesGift}, adShowId:  val_7, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionWrong4timesGift});
            val_10 = null;
            val_10 = null;
            Platform.Ad.RewardPlacement val_3 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
            val_11 = null;
            val_11 = null;
            val_13 = LetterGift.<>c.<>9__5_0;
            if(val_13 == null)
            {
                    System.Action<System.String, System.Boolean> val_4 = null;
                val_13 = val_4;
                val_4 = new System.Action<System.String, System.Boolean>(object:  LetterGift.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LetterGift.<>c::<PlayAd>b__5_0(string adTaskID, bool isReward));
                LetterGift.<>c.<>9__5_0 = val_13;
            }
            
            typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = val_13;
            val_14 = null;
            val_14 = null;
            RegisterDefaultLogEvent(adFrom:  Platform.Ad.GameAdPosition.Wrong4TimesGift);
            goto mem[null + 464];
        }
        private void HideFlow()
        {
            this.AnimatorGift.Play(stateName:  "GiftBoxFlowHide");
        }
        private void OnEnable()
        {
            this._isHideGifting = false;
            Message.Messager.Add(cmd:  62, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.LetterGift::HideFlow()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  62, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.LetterGift::HideFlow()));
        }
        public LetterGift()
        {
        
        }
    
    }

}
