using UnityEngine;

namespace View.Dialog.FreeHintsTest2
{
    public class FreeHintsTest2Dialog : Dialog
    {
        // Fields
        public UnityEngine.GameObject EffectLight;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public TMPro.TMP_Text WatchText;
        private Logic.Define.RewardedVideoTriggerType triggerType;
        private bool _isClickClose;
        private int _rewardCount;
        
        // Methods
        protected override void OnEnable()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            this.OnEnable();
            this._rewardCount = this.GetRewardCount();
            this._isClickClose = false;
            this.EffectLight.SetActive(value:  true);
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.ShopClose, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionShopClose});
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceShopClose}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.ShopClose), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionShopClose});
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "107");
            string val_2 = Locale.LocaleManager.Translate(key:  "109");
            this.WatchText.text = Locale.LocaleManager.Translate(key:  "108");
        }
        public void Watch()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            this.EffectLight.SetActive(value:  false);
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameWatch}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceShopClose}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.ShopClose), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionShopClose});
            val_9 = null;
            val_9 = null;
            Platform.Ad.RewardPlacement val_3 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
            typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = new System.Action<System.String, System.Boolean>(object:  this, method:  System.Void View.Dialog.FreeHintsTest2.FreeHintsTest2Dialog::<Watch>b__9_0(string adTaskID, bool isReward));
            RegisterDefaultLogEvent(adFrom:  Platform.Ad.GameAdPosition.ShopClose);
            goto mem[null + 464];
        }
        public void OnClickCloseButton()
        {
            if(this._isClickClose != false)
            {
                    return;
            }
            
            this._isClickClose = true;
            this.EffectLight.SetActive(value:  false);
            goto typeof(View.Dialog.FreeHintsTest2.FreeHintsTest2Dialog).__il2cppRuntimeField_1E0;
        }
        public void SetTriggerType(Logic.Define.RewardedVideoTriggerType type)
        {
            this.triggerType = type;
        }
        private int GetRewardCount()
        {
            return Common.Singleton<Data.Reward.RewardDataManager>.Instance.GetBoxRewardCount2();
        }
        public FreeHintsTest2Dialog()
        {
            this.triggerType = 3;
            this._rewardCount = 40;
            mem[1152921512755440552] = 257;
            mem[1152921512755440555] = 1;
            mem[1152921512755440560] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <Watch>b__9_0(string adTaskID, bool isReward)
        {
            if(isReward == false)
            {
                    return;
            }
            
            if(Platform.AbTest.GameABTestManager.IsReward() != false)
            {
                    mem2[0] = this.triggerType;
                Logic.Game.GameManager.gameDialog.Open(name:  "RewardAgainDialog", type:  0).SetRewardCount(count:  this._rewardCount, isInitialRewardAd:  true);
                return;
            }
            
            mem2[0] = this.triggerType;
            Logic.Game.GameManager.gameDialog.Open(name:  "RewardTestDialog", type:  0).SetRewardCount(count:  this._rewardCount, extra:  0);
        }
    
    }

}
