using UnityEngine;

namespace View.Dialog.Debug
{
    public class DebugDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Toggle toggleShowFps;
        public UnityEngine.UI.Toggle toggleBuyAnyItem;
        public UnityEngine.UI.Toggle toggleRemoveADS;
        public UnityEngine.UI.Toggle toggleShowHomeDaily;
        public UnityEngine.UI.Toggle toggleNoCheckExtraExist;
        public UnityEngine.UI.Button buttonClearBoxProgerss;
        public UnityEngine.UI.Button buttonShowDailyRedPoint;
        public UnityEngine.UI.Button buttonClearOLShowTime;
        public UnityEngine.UI.Button buttonClearExtraData;
        public UnityEngine.UI.Button buttonClearHintFree;
        public UnityEngine.UI.Button buttonSendEvent;
        public UnityEngine.UI.Button buttonSendFBEvent;
        public UnityEngine.UI.Button buttonDailyLottery;
        public View.Dialog.Debug.SliderPlusCoin sliderCoin;
        public View.Dialog.Debug.SliderPlus sliderABTest;
        public View.Dialog.Debug.SliderPlus sliderReward;
        public View.Dialog.Debug.SliderPlus SliderPiggyBank;
        public View.Dialog.Debug.SliderPlus SliderChrysalis;
        public View.Dialog.Debug.SliderPlus sliderSection;
        public View.Dialog.Debug.SliderPlus sliderLevel;
        public View.Dialog.Debug.SliderPlus sliderQuiz;
        public View.Dialog.Debug.SliderPlus sliderTotalQuiz;
        public View.Dialog.Debug.SliderPlus sliderDifficultyLevel;
        public View.Dialog.Debug.SliderPlus sliderMissionsChest;
        public View.Dialog.Debug.SliderPlus sliderUserPay;
        
        // Methods
        private void Start()
        {
            this.InitToggle();
            this.InitButton();
            this.InitSliderPlus();
        }
        private void InitToggle()
        {
            var val_16;
            UnityEngine.Events.UnityAction<System.Boolean> val_18;
            var val_19;
            UnityEngine.Events.UnityAction<System.Boolean> val_21;
            var val_22;
            UnityEngine.Events.UnityAction<System.Boolean> val_24;
            var val_25;
            UnityEngine.Events.UnityAction<System.Boolean> val_27;
            var val_28;
            UnityEngine.Events.UnityAction<System.Boolean> val_30;
            View.Dialog.Debug.DebugInfo val_1 = View.Dialog.Debug.DebugInfo.instance;
            this.toggleShowFps.isOn = val_1.isShowFPS;
            val_16 = null;
            val_16 = null;
            val_18 = DebugDialog.<>c.<>9__26_0;
            if(val_18 == null)
            {
                    UnityEngine.Events.UnityAction<System.Boolean> val_2 = null;
                val_18 = val_2;
                val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitToggle>b__26_0(bool isOn));
                DebugDialog.<>c.<>9__26_0 = val_18;
            }
            
            this.toggleShowFps.onValueChanged.AddListener(call:  val_18);
            this.toggleBuyAnyItem.isOn = Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyAnyItem;
            val_19 = null;
            val_19 = null;
            val_21 = DebugDialog.<>c.<>9__26_1;
            if(val_21 == null)
            {
                    UnityEngine.Events.UnityAction<System.Boolean> val_6 = null;
                val_21 = val_6;
                val_6 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitToggle>b__26_1(bool isOn));
                DebugDialog.<>c.<>9__26_1 = val_21;
            }
            
            this.toggleBuyAnyItem.onValueChanged.AddListener(call:  val_21);
            this.toggleRemoveADS.isOn = Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem;
            val_22 = null;
            val_22 = null;
            val_24 = DebugDialog.<>c.<>9__26_2;
            if(val_24 == null)
            {
                    UnityEngine.Events.UnityAction<System.Boolean> val_10 = null;
                val_24 = val_10;
                val_10 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitToggle>b__26_2(bool isOn));
                DebugDialog.<>c.<>9__26_2 = val_24;
            }
            
            this.toggleRemoveADS.onValueChanged.AddListener(call:  val_24);
            this.toggleShowHomeDaily.isOn = Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowHomeDailyDialog;
            val_25 = null;
            val_25 = null;
            val_27 = DebugDialog.<>c.<>9__26_3;
            if(val_27 == null)
            {
                    UnityEngine.Events.UnityAction<System.Boolean> val_14 = null;
                val_27 = val_14;
                val_14 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitToggle>b__26_3(bool isOn));
                DebugDialog.<>c.<>9__26_3 = val_27;
            }
            
            this.toggleShowHomeDaily.onValueChanged.AddListener(call:  val_27);
            this.toggleNoCheckExtraExist.isOn = Data.ExtraWordData.ExtraWordDataMngr.isNotCheckExtraExist;
            val_28 = null;
            val_28 = null;
            val_30 = DebugDialog.<>c.<>9__26_4;
            if(val_30 == null)
            {
                    UnityEngine.Events.UnityAction<System.Boolean> val_15 = null;
                val_30 = val_15;
                val_15 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitToggle>b__26_4(bool isOn));
                DebugDialog.<>c.<>9__26_4 = val_30;
            }
            
            this.toggleNoCheckExtraExist.onValueChanged.AddListener(call:  val_30);
        }
        private void InitButton()
        {
            var val_9;
            UnityEngine.Events.UnityAction val_11;
            var val_12;
            UnityEngine.Events.UnityAction val_14;
            var val_15;
            UnityEngine.Events.UnityAction val_17;
            var val_18;
            UnityEngine.Events.UnityAction val_20;
            var val_21;
            UnityEngine.Events.UnityAction val_23;
            var val_24;
            UnityEngine.Events.UnityAction val_26;
            var val_27;
            UnityEngine.Events.UnityAction val_29;
            var val_30;
            UnityEngine.Events.UnityAction val_32;
            val_9 = null;
            val_9 = null;
            val_11 = DebugDialog.<>c.<>9__27_0;
            if(val_11 == null)
            {
                    UnityEngine.Events.UnityAction val_1 = null;
                val_11 = val_1;
                val_1 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_0());
                DebugDialog.<>c.<>9__27_0 = val_11;
            }
            
            this.buttonClearBoxProgerss.m_OnClick.AddListener(call:  val_11);
            val_12 = null;
            val_12 = null;
            val_14 = DebugDialog.<>c.<>9__27_1;
            if(val_14 == null)
            {
                    UnityEngine.Events.UnityAction val_2 = null;
                val_14 = val_2;
                val_2 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_1());
                DebugDialog.<>c.<>9__27_1 = val_14;
            }
            
            this.buttonShowDailyRedPoint.m_OnClick.AddListener(call:  val_14);
            val_15 = null;
            val_15 = null;
            val_17 = DebugDialog.<>c.<>9__27_2;
            if(val_17 == null)
            {
                    UnityEngine.Events.UnityAction val_3 = null;
                val_17 = val_3;
                val_3 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_2());
                DebugDialog.<>c.<>9__27_2 = val_17;
            }
            
            this.buttonClearOLShowTime.m_OnClick.AddListener(call:  val_17);
            val_18 = null;
            val_18 = null;
            val_20 = DebugDialog.<>c.<>9__27_3;
            if(val_20 == null)
            {
                    UnityEngine.Events.UnityAction val_4 = null;
                val_20 = val_4;
                val_4 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_3());
                DebugDialog.<>c.<>9__27_3 = val_20;
            }
            
            this.buttonClearExtraData.m_OnClick.AddListener(call:  val_20);
            val_21 = null;
            val_21 = null;
            val_23 = DebugDialog.<>c.<>9__27_4;
            if(val_23 == null)
            {
                    UnityEngine.Events.UnityAction val_5 = null;
                val_23 = val_5;
                val_5 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_4());
                DebugDialog.<>c.<>9__27_4 = val_23;
            }
            
            this.buttonClearHintFree.m_OnClick.AddListener(call:  val_23);
            val_24 = null;
            val_24 = null;
            val_26 = DebugDialog.<>c.<>9__27_5;
            if(val_26 == null)
            {
                    UnityEngine.Events.UnityAction val_6 = null;
                val_26 = val_6;
                val_6 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_5());
                DebugDialog.<>c.<>9__27_5 = val_26;
            }
            
            this.buttonSendEvent.m_OnClick.AddListener(call:  val_26);
            val_27 = null;
            val_27 = null;
            val_29 = DebugDialog.<>c.<>9__27_6;
            if(val_29 == null)
            {
                    UnityEngine.Events.UnityAction val_7 = null;
                val_29 = val_7;
                val_7 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_6());
                DebugDialog.<>c.<>9__27_6 = val_29;
            }
            
            this.buttonSendFBEvent.m_OnClick.AddListener(call:  val_29);
            val_30 = null;
            val_30 = null;
            val_32 = DebugDialog.<>c.<>9__27_7;
            if(val_32 == null)
            {
                    UnityEngine.Events.UnityAction val_8 = null;
                val_32 = val_8;
                val_8 = new UnityEngine.Events.UnityAction(object:  DebugDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DebugDialog.<>c::<InitButton>b__27_7());
                DebugDialog.<>c.<>9__27_7 = val_32;
            }
            
            this.buttonDailyLottery.m_OnClick.AddListener(call:  val_32);
        }
        private void InitSliderPlus()
        {
            this.sliderCoin.Init(onValueChange:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnCoinChange(int coin)), coin:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin);
            System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  0, method:  public static System.Void ABTest.ABTestManager::ForceSetPlayerId(int id));
            int val_5 = ABTest.ABTestManager.GetPlayerId();
            System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnRewardCountChange(int count));
            int val_8 = Common.Singleton<Data.Reward.RewardDataManager>.Instance.RewardDayCount;
            System.Action<System.Int32> val_9 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnPiggyBankNumChange(int count));
            int val_11 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.PiggyBankCoin;
            System.Action<System.Int32> val_12 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnChrysalisNumChange(int count));
            int val_14 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount;
            int val_15 = Logic.Game.GameManager.gameLevel.GetCount(section:  0);
            System.Action<System.Int32> val_16 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnSectionChange(int section));
            int val_19 = (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) + 1;
            int val_22 = Logic.Game.GameManager.gameLevel.GetCount(section:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex);
            System.Action<System.Int32> val_23 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnLevelChange(int level));
            int val_26 = (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) + 1;
            System.Action<System.Int32> val_28 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnQuizChange(int level));
            int val_31 = Logic.Game.GameManager.gameQuizLevel.GetQuizLevelCount() - 1;
            int val_32 = (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockQuizLevelIndex) + 1;
            System.Action<System.Int32> val_33 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnTotalQuizChange(int count));
            int val_35 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ShowQuizCount;
            System.Action<System.Int32> val_39 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnDifficultyLevelChange(int level));
            int val_41 = Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.GetDifficultyLevelIndex();
            int val_42 = (Logic.Game.GameManager.gameLevel.GetDifficultyLevelCount(partIndex:  Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.DifficultyPartyIndex)) - 1;
            System.Action<System.Int32> val_43 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnMissionsChestPRogressChange(int value));
            int val_45 = Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.MissionsChestProgress;
            int val_49 = UnityEngine.Mathf.Max(a:  200, b:  ((int)Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UserPay) + 1);
            System.Action<System.Int32> val_50 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnUserPayChalenge(int value));
            float val_52 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UserPay;
            goto typeof(View.Dialog.Debug.SliderPlus).__il2cppRuntimeField_180;
        }
        private void OnCoinChange(int coin)
        {
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetCoin(value:  coin);
        }
        private void OnRewardCountChange(int count)
        {
            Common.Singleton<Data.Reward.RewardDataManager>.Instance.SetRewardDayCount(count:  count);
        }
        private void OnPiggyBankNumChange(int count)
        {
            Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.SetPiggyBankCoinNumber(num:  count);
        }
        private void OnChrysalisNumChange(int count)
        {
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.SetChrysalisCount(count:  count);
        }
        private void OnSectionChange(int section)
        {
            int val_2 = section - 1;
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUnlockSectionIndex(index:  val_2);
            Data.UserPlayer.UserPlayerDataManager val_3 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            val_3.<CurrentSectionIndex>k__BackingField = val_2;
            Common.Singleton<Data.Bible.BibleDataManager>.Instance.SetLastCompleteBible(last:  section - 2);
            int val_6 = Logic.Game.GameManager.gameLevel.GetCount(section:  val_2);
            System.Action<System.Int32> val_7 = new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.Debug.DebugDialog::OnLevelChange(int level));
            goto typeof(View.Dialog.Debug.SliderPlus).__il2cppRuntimeField_180;
        }
        private void OnLevelChange(int level)
        {
            int val_3 = level;
            val_3 = val_3 - 1;
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUnlockLevelIndex(index:  val_3);
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetCurrentLevelIndex(index:  val_3);
        }
        private void OnQuizChange(int level)
        {
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUnlockQuizLevelIndex(level:  level);
        }
        private void OnTotalQuizChange(int count)
        {
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetShowQuizCount(count:  count);
        }
        private void OnDifficultyLevelChange(int level)
        {
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SetDifficultyLevelIndex(index:  level);
        }
        private void OnMissionsChestPRogressChange(int value)
        {
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetMissionsChestProgress(count:  value);
        }
        private void OnUserPayChalenge(int value)
        {
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetUserPay(value:  (float)value);
        }
        private void OnDisable()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        public DebugDialog()
        {
            mem[1152921512766511672] = 257;
            mem[1152921512766511675] = 1;
            mem[1152921512766511680] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
