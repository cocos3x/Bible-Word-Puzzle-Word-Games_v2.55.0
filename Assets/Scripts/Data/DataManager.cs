using UnityEngine;

namespace Data
{
    public class DataManager : Singleton<Data.DataManager>
    {
        // Methods
        public void Init()
        {
            Common.Singleton<Data.Bible.BibleDataManager>.Instance.Init();
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.Init();
            Data.DailyLottery.DailyLotteryDataManager val_3 = Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance;
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.Init();
            Data.ExtraWord.ExtraWordDataManager val_5 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance;
            Data.Gameplay.GameplayDataManager val_6 = Common.Singleton<Data.Gameplay.GameplayDataManager>.Instance;
            Data.GameRecord.GameRecordDataManager val_7 = Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance;
            bool val_9 = Common.Singleton<Data.Guide.GuideDataManager>.Instance.IsReconfirmWatchVideo;
            val_8.<IsGiftReconfirmToggleIsOn>k__BackingField = val_9;
            val_8.<IsLetterGiftReconfirmToggleIsOn>k__BackingField = val_9.IsLetterGiftReconfirm;
            Data.LifeActivities.LifeActivitiesDataManager val_13 = Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance;
            Common.Singleton<Data.Login.LoginDataManager>.Instance.Init();
            Data.Notification.NotificationDataManager val_15 = Common.Singleton<Data.Notification.NotificationDataManager>.Instance;
            Data.PiggyBank.PiggyBankDataManager val_16 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.Init();
            Common.Singleton<Data.Reward.RewardDataManager>.Instance.Init();
            Common.Singleton<Data.Settings.SettingsDataManager>.Instance.Init();
            Common.Singleton<Data.Shop.ShopDataManager>.Instance.Init();
            Data.Treasure.TreasureDataManager val_21 = Common.Singleton<Data.Treasure.TreasureDataManager>.Instance;
            int val_23 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex;
            val_22.<CurrentSectionIndex>k__BackingField = val_23;
            val_22.<CurrentLevelIndex>k__BackingField = val_23.UnlockLevelIndex;
        }
        public DataManager()
        {
        
        }
    
    }

}
