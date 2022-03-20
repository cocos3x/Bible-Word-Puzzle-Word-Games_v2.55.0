using UnityEngine;

namespace Store
{
    public class StoreRoot : AbstractStoreRoot
    {
        // Fields
        public static Store.StoreRoot Inst;
        public Store.BibleData Bible;
        public Store.ButterFlyData ButterFly;
        public Store.DailyLotteryData DailyLottery;
        public Store.DailyRecordData DailyRecord;
        public Store.ExtraWordData ExtraWord;
        public Store.GameRecordData GameRecord;
        public Store.GuideData Guide;
        public Store.LifeActivitiesData LifeActivities;
        public Store.LoginData Login;
        public Store.NotificationData Notification;
        public Store.PiggyBankData PiggyBank;
        public Store.RateUsData RateUs;
        public Store.RewardData Reward;
        public Store.SettingsData Settings;
        public Store.ShopData Shop;
        public Store.TreasureData Treasure;
        public Store.UserPlayerData UserPlayer;
        
        // Methods
        public override void Init()
        {
            if(this.Bible == null)
            {
                    this.Bible = new System.Object();
                Reset();
            }
            
            if(this.ButterFly == null)
            {
                    this.ButterFly = new Store.ButterFlyData();
                Reset();
            }
            
            if(this.DailyLottery == null)
            {
                    this.DailyLottery = new Store.DailyLotteryData();
                Reset();
            }
            
            if(this.DailyRecord == null)
            {
                    this.DailyRecord = new Store.DailyRecordData();
                Reset();
            }
            
            if(this.ExtraWord == null)
            {
                    this.ExtraWord = new Store.ExtraWordData();
                Reset();
            }
            
            if(this.GameRecord == null)
            {
                    this.GameRecord = new Store.GameRecordData();
                Reset();
            }
            
            if(this.Guide == null)
            {
                    object val_7 = null;
                typeof(Store.GuideData).__il2cppRuntimeField_18 = 1;
                val_7 = new System.Object();
                this.Guide = val_7;
                typeof(Store.GuideData).__il2cppRuntimeField_18 = 1;
                typeof(Store.GuideData).__il2cppRuntimeField_10 = 5.45361207450614E-312;
            }
            
            if(this.LifeActivities == null)
            {
                    this.LifeActivities = new System.Object();
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_24 = 0;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_1C = 0;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_14 = 0;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_38 = 0;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_40 = 0;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_10 = 0;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_2C = 257;
                typeof(Store.LifeActivitiesData).__il2cppRuntimeField_30 = 0;
            }
            
            if(this.Login == null)
            {
                    this.Login = new Store.LoginData();
                Reset();
            }
            
            if(this.Notification == null)
            {
                    this.Notification = new System.Object();
                typeof(Store.NotificationData).__il2cppRuntimeField_10 = 257;
            }
            
            if(this.PiggyBank == null)
            {
                    this.PiggyBank = new System.Object();
                typeof(Store.PiggyBankData).__il2cppRuntimeField_10 = 0;
                typeof(Store.PiggyBankData).__il2cppRuntimeField_14 = 1;
            }
            
            if(this.RateUs == null)
            {
                    this.RateUs = new System.Object();
                Reset();
            }
            
            if(this.Reward == null)
            {
                    this.Reward = new Store.RewardData();
                Reset();
            }
            
            if(this.Settings == null)
            {
                    object val_14 = null;
                typeof(Store.SettingsData).__il2cppRuntimeField_10 = 257;
                val_14 = new System.Object();
                this.Settings = val_14;
                typeof(Store.SettingsData).__il2cppRuntimeField_10 = 257;
            }
            
            if(this.Shop == null)
            {
                    this.Shop = new Store.ShopData();
                Reset();
            }
            
            if(this.Treasure == null)
            {
                    this.Treasure = new Store.TreasureData();
                Reset();
            }
            
            if(this.UserPlayer != null)
            {
                    return;
            }
            
            this.UserPlayer = new System.Object();
            typeof(Store.UserPlayerData).__il2cppRuntimeField_10 = 500;
            typeof(Store.UserPlayerData).__il2cppRuntimeField_1C = 0;
            typeof(Store.UserPlayerData).__il2cppRuntimeField_14 = 0;
            typeof(Store.UserPlayerData).__il2cppRuntimeField_24 = 0;
            typeof(Store.UserPlayerData).__il2cppRuntimeField_28 = ;
        }
        public override void Reset()
        {
            this.Bible.Reset();
            this.ButterFly.Reset();
            this.DailyLottery.Reset();
            this.DailyRecord.Reset();
            this.ExtraWord.Reset();
            this.GameRecord.Reset();
            this.Guide.IsHaveMapReelGuide = true;
            this.Guide.ShouldShowHomeDailyPoint = false;
            this.Guide.ShouldShowBonusWordGuideDialog = true;
            this.Guide.ShouldShowHomeDailyDialog = true;
            this.Guide.IsDailyNewGuide = true;
            this.Guide.IsReconfirmWatchVideo = true;
            this.Guide.IsLetterGiftReconfirm = true;
            this.Guide.HasShowFireworkGuide = false;
            this.Guide.HasShowExtraCoinGuide = false;
            this.LifeActivities.BonusWordsCount = 0;
            this.LifeActivities.LevelPassCount = 0;
            this.LifeActivities.ShowLevelPassVideoCount = 0;
            this.LifeActivities.StartLevelCount = 0;
            this.LifeActivities.UseHintCount = 0;
            this.LifeActivities.ShowDailyCount = 0;
            this.LifeActivities.FailCountLastLevel = 0;
            this.LifeActivities.CombosCount = 0;
            this.LifeActivities.LevelPassTime = 0f;
            this.LifeActivities.LevelPassDailyTime = 0f;
            this.LifeActivities.AllConnectWord = 0;
            this.LifeActivities.IsHaveNoviceBankruptcy = true;
            this.LifeActivities.IsHaveNoviceReward = true;
            this.LifeActivities.DailyLotteryCount = 0;
            this.LifeActivities.FailCountCurLevel = 0;
            this.Login.Reset();
            this.Notification.IsFirstForNotification = true;
            this.Notification.IsNotificationOn = true;
            this.PiggyBank.PiggyBankCoin = 0;
            this.PiggyBank.PiggyBankFullUnPop = true;
            this.PiggyBank.IsAlreadyPopPiggyBank = false;
            this.RateUs.Reset();
            this.Reward.Reset();
            this.Settings.IsMusicOn = true;
            this.Settings.IsSoundOn = true;
            this.Shop.Reset();
            this.Treasure.Reset();
            this.UserPlayer.Coin = 500;
            this.UserPlayer.UnlockSectionIndex = 0;
            this.UserPlayer.UnlockLevelIndex = 0;
            this.UserPlayer.CoinTemp = 0;
            this.UserPlayer.UserPay = 0f;
            this.UserPlayer.HintFreeStatus = 0;
            this.UserPlayer.GameScore = ;
            this.UserPlayer.FireworkCount = ;
            this.UserPlayer.UnlockQuizLevelIndex = 0;
            this.UserPlayer.ShowQuizCount = 0;
        }
        public StoreRoot()
        {
        
        }
    
    }

}
