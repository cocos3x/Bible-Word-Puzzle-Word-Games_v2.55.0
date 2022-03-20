using UnityEngine;

namespace View.Dialog.FreeGiftTest
{
    public class FreeGiftTestDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Toggle ToggleBox;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public UnityEngine.UI.Text DontText;
        public TMPro.TMP_Text WatchText;
        private bool _isCanClick;
        private string AdFrom;
        
        // Methods
        public void OnClickWatchButton()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            if(this._isCanClick != false)
            {
                    this._isCanClick = false;
                val_5 = null;
                val_5 = null;
                val_6 = null;
                val_6 = null;
                val_7 = null;
                val_7 = null;
                val_8 = null;
                val_8 = null;
                Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameWrongRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceWrong4timesGift}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.Wrong4TimesGift), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnClick.PositionEnum.PositionWrong4timesGift});
                val_9 = null;
                val_9 = null;
                Platform.Ad.RewardPlacement val_3 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
                typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = new System.Action<System.String, System.Boolean>(object:  this, method:  System.Void View.Dialog.FreeGiftTest.FreeGiftTestDialog::<OnClickWatchButton>b__7_0(string adTaskID, bool isReward));
                RegisterDefaultLogEvent(adFrom:  Platform.Ad.GameAdPosition.Wrong4TimesGift);
            }
        
        }
        public void OnClickCloseButton()
        {
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetLetterGiftReconfirm(isReconfirm:  true);
            goto typeof(View.Dialog.FreeGiftTest.FreeGiftTestDialog).__il2cppRuntimeField_1E0;
        }
        protected override void Awake()
        {
            this.Awake();
            this.ToggleBox.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void View.Dialog.FreeGiftTest.FreeGiftTestDialog::OnToggleChange(bool isOn)));
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Data.Guide.GuideDataManager val_1 = Common.Singleton<Data.Guide.GuideDataManager>.Instance;
            this.ToggleBox.isOn = val_1.<IsLetterGiftReconfirmToggleIsOn>k__BackingField;
            this._isCanClick = true;
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "157");
            string val_2 = Locale.LocaleManager.Translate(key:  "196");
            string val_3 = Locale.LocaleManager.Translate(key:  "111");
            this.WatchText.text = Locale.LocaleManager.Translate(key:  "108");
        }
        private void OnToggleChange(bool isOn)
        {
            Data.Guide.GuideDataManager val_1 = Common.Singleton<Data.Guide.GuideDataManager>.Instance;
            val_1.<IsLetterGiftReconfirmToggleIsOn>k__BackingField = isOn;
        }
        public FreeGiftTestDialog()
        {
            this._isCanClick = true;
            mem[1152921512756510888] = 257;
            mem[1152921512756510891] = true;
            this.AdFrom = "gift_box";
            mem[1152921512756510896] = ;
            this = new UnityEngine.MonoBehaviour();
        }
        private void <OnClickWatchButton>b__7_0(string adTaskID, bool isReward)
        {
            if(isReward == false)
            {
                    return;
            }
            
            Message.Messager.Dispatch(cmd:  69);
            Data.Guide.GuideDataManager val_2 = Common.Singleton<Data.Guide.GuideDataManager>.Instance;
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetLetterGiftReconfirm(isReconfirm:  ((val_2.<IsLetterGiftReconfirmToggleIsOn>k__BackingField) == false) ? 1 : 0);
        }
    
    }

}
