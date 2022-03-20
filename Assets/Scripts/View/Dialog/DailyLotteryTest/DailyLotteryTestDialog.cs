using UnityEngine;

namespace View.Dialog.DailyLotteryTest
{
    public class DailyLotteryTestDialog : Dialog
    {
        // Fields
        private readonly int[] RewardCountsTest;
        private readonly string OnStateName;
        private readonly string OffStateName;
        public UnityEngine.UI.Button[] ButtonGifts;
        public View.Dialog.DailyLotteryTest.DailyLotteryGift[] Gifts;
        public UnityEngine.UI.Button ButtonClose;
        public UnityEngine.UI.Text TextTips;
        public UnityEngine.UI.Text TitleText;
        private System.Collections.Generic.List<string> _lotteryProgress;
        private System.Collections.Generic.List<int> _rewardCounts;
        private bool _openedGift;
        private bool _isCanWatch;
        private System.Collections.Generic.List<int> _nowRewardCountsTest;
        
        // Methods
        public void OnClickGiftButton(int index)
        {
            if(this._openedGift == true)
            {
                    return;
            }
            
            if(this.Gifts.Length <= index)
            {
                    return;
            }
            
            this._openedGift = true;
            this.SetRewardCounts(index:  index);
            this.ButtonClose.gameObject.SetActive(value:  true);
            Platform.Analytics.EzAnalytics.DailyRewardFirstTime();
            this.Gifts[index].PlayOpenGiftAni(isPlayTextAni:  true);
            this.SetGiftButtonState();
        }
        public void OnClickCloseButton()
        {
            goto typeof(View.Dialog.DailyLotteryTest.DailyLotteryTestDialog).__il2cppRuntimeField_1E0;
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "93");
            string val_2 = Locale.LocaleManager.Translate(key:  "94");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add<System.Int32>(cmd:  88, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryTestDialog::SaveDailyGiftBoxProgress(int index)));
            Message.Messager.Add<System.Boolean>(cmd:  89, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryTestDialog::ShowDailyLotteryVideoButton(bool isAni)));
            this.UpdateDailyLottery();
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Int32>(cmd:  88, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryTestDialog::SaveDailyGiftBoxProgress(int index)));
            Message.Messager.Remove<System.Boolean>(cmd:  89, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryTestDialog::ShowDailyLotteryVideoButton(bool isAni)));
        }
        private void UpdateDailyLottery()
        {
            var val_11;
            System.Collections.Generic.List<System.Int32> val_12;
            this._openedGift = false;
            this._isCanWatch = false;
            if(this.Gifts.Length != this.ButtonGifts.Length)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_ad_reward", action:  "ad_enter_show", label:  Platform.Ad.GameAdPosition.DailyGift, value:  0);
            this._lotteryProgress = Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.GetDailyGiftBoxProgress();
            this._rewardCounts = Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.GetDailyGiftRewardCount();
            var val_18 = 0;
            float val_16 = 0f;
            label_35:
            int val_13 = this.ButtonGifts.Length;
            if(val_18 >= val_13)
            {
                goto label_9;
            }
            
            if(val_18 >= val_13)
            {
                goto label_11;
            }
            
            val_13 = val_13 & 4294967295;
            if(val_18 >= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            string val_14 = this.OnStateName;
            val_14 = ((this.ButtonGifts.Length & 4294967295) + 0) + 32.Equals(value:  val_14);
            this.Gifts[val_18].SetGiftBoxState(isOpened:  val_14, delay:  val_16);
            if(val_18 >= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            if(((((this.ButtonGifts.Length & 4294967295) + 0) + 0) + 32.Equals(value:  this.OnStateName)) == false)
            {
                goto label_20;
            }
            
            this._openedGift = true;
            goto label_21;
            label_11:
            this._isCanWatch = true;
            this.Gifts[val_18].SetGiftBoxState(isOpened:  false, delay:  val_16);
            this._lotteryProgress.Add(item:  this.OffStateName);
            goto label_26;
            label_20:
            this._isCanWatch = true;
            label_26:
            val_16 = val_16 + 0.8f;
            label_21:
            if(val_18 < val_13)
            {
                    val_13 = val_13 & 4294967295;
                val_12 = this._rewardCounts;
                if(val_18 >= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = this._rewardCounts;
            }
            
                val_13 = val_13 + 0;
                if(val_18 >= this.Gifts[val_18])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + 0;
                this.Gifts[val_18].SetRewardCount(count:  (((((this.ButtonGifts.Length & 4294967295) + 0) + 0) & 4294967295) + 0) + 32, isHint:  ((((((((this.ButtonGifts.Length & 4294967295) + 0) + 0) & 4294967295) + 0) + 0) + 32) == 1) ? 1 : 0);
            }
            
            val_18 = val_18 + 1;
            if(this.ButtonGifts != null)
            {
                goto label_35;
            }
            
            return;
            label_9:
            var val_21 = 4;
            label_44:
            int val_8 = val_21 - 4;
            if(val_8 >= this.Gifts.Length)
            {
                goto label_38;
            }
            
            View.Dialog.DailyLotteryTest.DailyLotteryGift val_19 = this.Gifts[0];
            this.Gifts[0]._giftIndex = val_8;
            this.Gifts[0].SetGiftBoxInfo(isHaveOpened:  this._openedGift);
            val_21 = val_21 + 1;
            if(this.Gifts != null)
            {
                goto label_44;
            }
            
            label_38:
            this.TextTips.gameObject.SetActive(value:  (this._openedGift == false) ? 1 : 0);
            this.ButtonClose.gameObject.SetActive(value:  this._openedGift);
            this.SetGiftButtonState();
        }
        private void SetGiftButtonState()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_5 = 0;
            label_5:
            if(val_5 >= this.ButtonGifts.Length)
            {
                goto label_2;
            }
            
            this.ButtonGifts[val_5].enabled = (this._openedGift == false) ? 1 : 0;
            val_5 = val_5 + 1;
            if(this.ButtonGifts != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            if(this._openedGift == false)
            {
                    return;
            }
            
            if(this._isCanWatch == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendAdShowTiming(adPosition:  Platform.Ad.GameAdPosition.DailyGift, placementType:  new PlacementTypeEnum() {<Value>k__BackingField = AdShowTiming.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = AdShowTiming.PositionEnum.PositionVoid});
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            Platform.Analytics.EzAnalytics.SendBtnShow(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnShow.BtnNameEnum.BtnNameDailyRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnShow.SourceEnum.SourceDailyReward}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.DailyGift), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnShow.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = BtnShow.PositionEnum.PositionVoid});
        }
        private void SetRewardCounts(int index)
        {
            int val_9 = index;
            if(this._openedGift == false)
            {
                    return;
            }
            
            int val_3 = (Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.DailyLotteryCount) - 1;
            int val_10 = this.RewardCountsTest.Length;
            int val_9 = this.RewardCountsTest[UnityEngine.Mathf.Clamp(value:  val_3 - ((val_3 / this.RewardCountsTest.Length) * this.RewardCountsTest.Length), min:  0, max:  this.RewardCountsTest.Length - 1)];
            if(val_10 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = 0;
            val_10 = val_10 + (val_9 << 2);
            label_23:
            int val_11 = this.Gifts.Length;
            if(val_14 >= val_11)
            {
                goto label_11;
            }
            
            val_9 = val_9;
            if(val_9 != val_14)
            {
                    val_9 = val_9;
                if(val_14 < val_11)
            {
                    if(val_11 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = (this.RewardCountsTest.Length + (index) << 2) + 32;
                val_11 = val_11 + 0;
                var val_12 = (this.Gifts.Length + 0) + 32;
                if(val_12 != val_9)
            {
                    val_9 = val_12;
                if(val_10 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = val_12 + 0;
                val_9 = mem[((this.Gifts.Length + 0) + 32 + 0) + 32];
                val_9 = ((this.Gifts.Length + 0) + 32 + 0) + 32;
            }
            
            }
            
            }
            
            }
            
            this.Gifts[val_14].SetRewardCount(count:  val_9, isHint:  (val_9 == 1) ? 1 : 0);
            if(val_14 < this.Gifts[val_14])
            {
                    this._rewardCounts.set_Item(index:  0, value:  val_9);
            }
            else
            {
                    this._rewardCounts.Add(item:  val_9);
            }
            
            val_14 = val_14 + 1;
            if(this.Gifts != null)
            {
                goto label_23;
            }
            
            throw new NullReferenceException();
            label_11:
            this.SaveDailyGiftRewardCount();
        }
        private void SaveDailyGiftBoxProgress(int index)
        {
            if(this._lotteryProgress == null)
            {
                    return;
            }
            
            if(true <= index)
            {
                    return;
            }
            
            this._lotteryProgress.set_Item(index:  index, value:  this.OnStateName);
            Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.SaveDailyGiftBoxProgress(data:  this._lotteryProgress);
        }
        private void SaveDailyGiftRewardCount()
        {
            if(this._rewardCounts == null)
            {
                    return;
            }
            
            if(this._rewardCounts < 1)
            {
                    return;
            }
            
            Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.SaveDailyGiftRewardCount(data:  this._rewardCounts);
        }
        private void ShowDailyLotteryVideoButton(bool isAni)
        {
            this.TextTips.gameObject.SetActive(value:  (this._openedGift == false) ? 1 : 0);
        }
        public DailyLotteryTestDialog()
        {
            this.RewardCountsTest = new int[4] {120, 20, 80, 20};
            this.OnStateName = "on";
            this.OffStateName = "off";
            Add(item:  120);
            Add(item:  20);
            Add(item:  80);
            mem[1152921512786054648] = 257;
            this._nowRewardCountsTest = new System.Collections.Generic.List<System.Int32>();
            mem[1152921512786054651] = 1;
            mem[1152921512786054656] = ;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
