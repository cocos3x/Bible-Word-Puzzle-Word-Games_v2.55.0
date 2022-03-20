using UnityEngine;

namespace View.Dialog.Reconfirm
{
    public class ReconfirmDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Toggle ToggleBox;
        public TMPro.TextMeshProUGUI TextReward;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public UnityEngine.UI.Text DontShowText;
        private bool _isCanClick;
        private Logic.Define.RewardedVideoTriggerType _triggerType;
        private int _rewardCount;
        
        // Methods
        public void OnClickWatchButton()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            BtnClick.PlacementTypeEnum val_11;
            var val_12;
            var val_13;
            System.Action<System.String> val_15;
            var val_16;
            var val_17;
            System.Action val_19;
            if(this._isCanClick != false)
            {
                    this._isCanClick = false;
                val_7 = null;
                val_7 = null;
                val_8 = null;
                val_8 = null;
                val_9 = null;
                val_9 = null;
                val_10 = null;
                val_11 = BtnClick.PlacementTypeEnum.PlacementTypeReward;
                val_10 = null;
                Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceGameButton}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.GameButton), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = val_11}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionGameButton});
                val_12 = null;
                val_12 = null;
                Platform.Ad.RewardPlacement val_3 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
                typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = new System.Action<System.String, System.Boolean>(object:  this, method:  System.Void View.Dialog.Reconfirm.ReconfirmDialog::<OnClickWatchButton>b__8_0(string adTaskID, bool isReward));
                val_13 = null;
                val_13 = null;
                val_15 = ReconfirmDialog.<>c.<>9__8_1;
                if(val_15 == null)
            {
                    System.Action<System.String> val_5 = null;
                val_15 = val_5;
                val_5 = new System.Action<System.String>(object:  ReconfirmDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ReconfirmDialog.<>c::<OnClickWatchButton>b__8_1(string adTaskID));
                ReconfirmDialog.<>c.<>9__8_1 = val_15;
            }
            
                typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_30 = val_15;
                val_16 = null;
                val_16 = null;
                RegisterDefaultLogEvent(adFrom:  Platform.Ad.GameAdPosition.GameButton);
                val_17 = null;
                val_17 = null;
                val_19 = ReconfirmDialog.<>c.<>9__8_2;
                if(val_19 == null)
            {
                    System.Action val_6 = null;
                val_19 = val_6;
                val_6 = new System.Action(object:  ReconfirmDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ReconfirmDialog.<>c::<OnClickWatchButton>b__8_2());
                ReconfirmDialog.<>c.<>9__8_2 = val_19;
            }
            
            }
        
        }
        public void OnClickCloseButton()
        {
            Message.Messager.Dispatch(cmd:  53);
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetReconfirmWatchVideo(isReconfirm:  true);
            goto typeof(View.Dialog.Reconfirm.ReconfirmDialog).__il2cppRuntimeField_1E0;
        }
        protected override void Awake()
        {
            this.Awake();
            this.ToggleBox.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void View.Dialog.Reconfirm.ReconfirmDialog::OnToggleChange(bool isOn)));
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Data.Guide.GuideDataManager val_1 = Common.Singleton<Data.Guide.GuideDataManager>.Instance;
            this.ToggleBox.isOn = val_1.<IsGiftReconfirmToggleIsOn>k__BackingField;
            this._isCanClick = true;
            int val_2 = this.ToggleBox.GetRewardCount();
            this._rewardCount = val_2;
            this.TextReward.text = "+"("+") + val_2;
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "107");
            string val_2 = Locale.LocaleManager.Translate(key:  "109");
            string val_3 = Locale.LocaleManager.Translate(key:  "111");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private int GetRewardCount()
        {
            var val_7;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() == null)
            {
                    return 38;
            }
            
            Data.Bean.PropertyBean val_2 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            int val_4 = Common.Singleton<Data.Reward.RewardDataManager>.Instance.RewardDayCount;
            if(W9 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(W9 >= 3)
            {
                    val_7 = (System.Int32 System.Array::InternalArray__IndexOf<System.Collections.Generic.KeyValuePair<Newtonsoft.Json.Serialization.ResolverContractKey, System.Object>>(System.Collections.Generic.KeyValuePair<Newtonsoft.Json.Serialization.ResolverContractKey, System.Object> item)) - ((public System.Void Spine.ExposedList<System.Boolean>::set_Capacity(int value)) * val_4);
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_7 = (System.Int32 System.Array::InternalArray__IndexOf<System.Collections.Generic.KeyValuePair<Newtonsoft.Json.Serialization.ResolverContractKey, System.Object>>(System.Collections.Generic.KeyValuePair<Newtonsoft.Json.Serialization.ResolverContractKey, System.Object> item)) - ((public System.Void Spine.ExposedList<System.Boolean>::set_Capacity(int value)) * val_4);
                if(W9 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
            if(W9 > 1)
            {
                    return 38;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return 38;
        }
        private void OnToggleChange(bool isOn)
        {
            Data.Guide.GuideDataManager val_1 = Common.Singleton<Data.Guide.GuideDataManager>.Instance;
            val_1.<IsGiftReconfirmToggleIsOn>k__BackingField = isOn;
        }
        public ReconfirmDialog()
        {
            this._isCanClick = true;
            this._triggerType = true;
        }
        private void <OnClickWatchButton>b__8_0(string adTaskID, bool isReward)
        {
            if(isReward == false)
            {
                    return;
            }
            
            if(Platform.AbTest.GameABTestManager.IsReward() != false)
            {
                    mem2[0] = this._triggerType;
                Logic.Game.GameManager.gameDialog.Open(name:  "RewardAgainDialog", type:  0).SetRewardCount(count:  this._rewardCount, isInitialRewardAd:  true);
            }
            else
            {
                    mem2[0] = this._triggerType;
                Logic.Game.GameManager.gameDialog.Open(name:  "RewardTestDialog", type:  0).SetRewardCount(count:  this._rewardCount, extra:  0);
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "video_gain", label:  "", value:  0);
            Data.Guide.GuideDataManager val_5 = Common.Singleton<Data.Guide.GuideDataManager>.Instance;
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetReconfirmWatchVideo(isReconfirm:  ((val_5.<IsGiftReconfirmToggleIsOn>k__BackingField) == false) ? 1 : 0);
        }
    
    }

}
