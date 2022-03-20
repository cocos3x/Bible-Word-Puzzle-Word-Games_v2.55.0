using UnityEngine;

namespace Store
{
    public class StoreManager
    {
        // Fields
        private static Store.StoreManager <Instance>k__BackingField;
        private const int Version = 1;
        private const string FileName = "StoreData";
        private Store.StoreFile _storeFile;
        
        // Properties
        public static Store.StoreManager Instance { get; set; }
        
        // Methods
        public static Store.StoreManager get_Instance()
        {
            return (Store.StoreManager)Store.StoreManager.FileName;
        }
        private static void set_Instance(Store.StoreManager value)
        {
            Store.StoreManager.FileName = value;
        }
        public static void Create()
        {
            Store.StoreManager.FileName = new System.Object();
            Init();
        }
        public static void Destroy()
        {
            null = 1152921504826069176;
            Store.StoreManager.FileName = 0;
        }
        private void Release()
        {
        
        }
        private StoreManager()
        {
        
        }
        private void Init()
        {
            this._storeFile = new Store.StoreFile(fileName:  "StoreData", secret:  "#FX20210508@#$%^&*()");
            Store.StoreRoot val_3 = Store.StoreSerializer.Decode<Store.StoreRoot>(json:  Load());
            this.UpdateData(version:  -107742656, store:  val_3);
            Store.StoreRoot.Inst = val_3;
        }
        public void Save()
        {
            Store.StoreRoot.Inst.__unknownFiledOffset_10 = 1;
            this._storeFile.Save(json:  Store.StoreSerializer.Encode(root:  Store.StoreRoot.Inst));
        }
        public void Reload()
        {
            goto typeof(Store.StoreRoot).__il2cppRuntimeField_180;
        }
        private void UpdateData(int version, Store.StoreRoot store)
        {
            int val_2 = version;
            goto label_0;
            label_2:
            if(this.IsNeedDataMigration() != false)
            {
                    this.DataMigration(store:  store);
            }
            
            label_3:
            val_2 = val_2 + 1;
            label_0:
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            if(val_2 != 1)
            {
                goto label_3;
            }
        
        }
        private void DataMigration(Store.StoreRoot store)
        {
            store.Guide.ShouldShowHomeDailyPoint = ((UnityEngine.PlayerPrefs.GetInt(key:  "SHOULD_SHOW_HOME_DAILY_POINT", defaultValue:  0)) == 1) ? 1 : 0;
            store.Guide.ShouldShowBonusWordGuideDialog = ((UnityEngine.PlayerPrefs.GetInt(key:  "GUIDE_BONUS_WORD_BUBBLE", defaultValue:  1)) == 1) ? 1 : 0;
            store.Guide.ShouldShowHomeDailyDialog = ((UnityEngine.PlayerPrefs.GetInt(key:  "SHOULD_SHOW_HOME_DAILY_DIALOG", defaultValue:  0)) == 1) ? 1 : 0;
            store.Guide.IsDailyNewGuide = ((UnityEngine.PlayerPrefs.GetInt(key:  "DAILY_NEW_GUIDE", defaultValue:  0)) == 0) ? 1 : 0;
            store.Guide.IsReconfirmWatchVideo = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reconfirm_Watch_Video", defaultValue:  0)) == 0) ? 1 : 0;
            store.Guide.IsLetterGiftReconfirm = ((UnityEngine.PlayerPrefs.GetInt(key:  "Letter_Gift_Reconfirm", defaultValue:  0)) == 0) ? 1 : 0;
            store.Guide.HasShowFireworkGuide = ((UnityEngine.PlayerPrefs.GetInt(key:  "HAS_SHOW_FIREWORK_GUIDE", defaultValue:  0)) == 1) ? 1 : 0;
            store.RateUs.LastRateTime = UnityEngine.PlayerPrefs.GetString(key:  "LAST_RATE_TIME");
            store.RateUs.IsRate = ((UnityEngine.PlayerPrefs.GetInt(key:  "IS_RATE", defaultValue:  0)) == 1) ? 1 : 0;
            store.RateUs.IsFeedback = ((UnityEngine.PlayerPrefs.GetInt(key:  "IS_FEEDBACK", defaultValue:  0)) == 1) ? 1 : 0;
            store.RateUs.RateCloseCount = UnityEngine.PlayerPrefs.GetInt(key:  "RATE_CLOSE_COUNT");
            store.RateUs.IsCCPAAccepted = ((UnityEngine.PlayerPrefs.GetInt(key:  "IS_CCPA_ACCEPTED", defaultValue:  0)) == 1) ? 1 : 0;
            store.RateUs.IsRateIOSFirst = ((UnityEngine.PlayerPrefs.GetInt(key:  "IsRateIOSFirstDone")) == 1) ? 1 : 0;
            store.Reward.LastRewardDate = UnityEngine.PlayerPrefs.GetString(key:  "LAST_REWARD_VIDEO_DATE");
            store.Reward.RewardDayCount = UnityEngine.PlayerPrefs.GetInt(key:  "REWARD_DAY_COUNT");
            store.Reward.RewardVideoCount = UnityEngine.PlayerPrefs.GetInt(key:  "REWARD_VIDEO_COUNT");
            store.Reward.BoxLowestRewardTotal1 = UnityEngine.PlayerPrefs.GetInt(key:  "GET_BOX_LOWEST_REWARD_TOTAL_1", defaultValue:  0);
            store.Reward.BoxLowestRewardTotal2 = UnityEngine.PlayerPrefs.GetInt(key:  "GET_BOX_LOWEST_REWARD_TOTAL_2", defaultValue:  0);
            store.Bible.BibleDialogShowCount = UnityEngine.PlayerPrefs.GetInt(key:  "BIBLE_DIALOG_SHOW_COUNT", defaultValue:  0);
            store.Bible.BookCollectCount = UnityEngine.PlayerPrefs.GetInt(key:  "BOOK_COLLECT_COUNT", defaultValue:  0);
            store.Bible.VerseCollectCount = UnityEngine.PlayerPrefs.GetInt(key:  "VERSE_COllECT_COUNT", defaultValue:  0);
            store.Bible.LastShowMainBibleSection = UnityEngine.PlayerPrefs.GetInt(key:  "LAST_SHOW_MAIN_BIBLE_SECTION", defaultValue:  0);
            store.Bible.LastShowMainBibleTime = UnityEngine.PlayerPrefs.GetString(key:  "LAST_SHOW_MAIN_BIBLE_TIME");
            store.Bible.CanShowMainBibleBook = ((UnityEngine.PlayerPrefs.GetInt(key:  "CAN_SHOW_MAIN_BIBLE_BOOK", defaultValue:  1)) == 1) ? 1 : 0;
            store.Bible.LastCompleteBible = UnityEngine.PlayerPrefs.GetInt(key:  "LAST_COMPLETE_BIBLE", defaultValue:  0);
            store.Login.UserLoginDays = UnityEngine.PlayerPrefs.GetInt(key:  "USER_LOGIN_DAYS", defaultValue:  0);
            store.Login.UserInstallDaysTime = UnityEngine.PlayerPrefs.GetString(key:  "USER_INSTALL_DAYS", defaultValue:  "");
            store.Login.UserLoginCount = UnityEngine.PlayerPrefs.GetInt(key:  "USER_LOGIN_COUNT", defaultValue:  0);
            store.Login.FirstLoginTime = UnityEngine.PlayerPrefs.GetString(key:  "FIRST_LOGIN_TIME");
            store.Login.UserLoginCountIn7 = UnityEngine.PlayerPrefs.GetInt(key:  "USER_LOGIN_COUNT_IN7", defaultValue:  0);
            store.Login.LastLoginTime = UnityEngine.PlayerPrefs.GetString(key:  "LAST_LOGIN_TIME");
            store.Login.LastLoginNetTime = UnityEngine.PlayerPrefs.GetString(key:  "LAST_LOGIN_NET_TIME");
            store.Login.FirstLoginVersion = UnityEngine.PlayerPrefs.GetString(key:  "IS_NEW_VERSION_USER", defaultValue:  "");
            store.Login.AppVersion = UnityEngine.PlayerPrefs.GetString(key:  "APP_VERSION", defaultValue:  "");
            store.Login.IsFirstLogin = ((UnityEngine.PlayerPrefs.GetInt(key:  "IS_FIRST_LOGIN", defaultValue:  0)) == 0) ? 1 : 0;
            store.LifeActivities.UseHintCount = UnityEngine.PlayerPrefs.GetInt(key:  "USE_HINT_COUNT", defaultValue:  0);
            store.LifeActivities.ShowDailyCount = UnityEngine.PlayerPrefs.GetInt(key:  "SHOW_DAILY_COUNT", defaultValue:  0);
            store.LifeActivities.ShowLevelPassVideoCount = UnityEngine.PlayerPrefs.GetInt(key:  "SHOW_LEVEL_PASS_VIDEO_COUNT", defaultValue:  0);
            store.LifeActivities.StartLevelCount = UnityEngine.PlayerPrefs.GetInt(key:  "START_LEVEL_COUNT", defaultValue:  0);
            store.LifeActivities.BonusWordsCount = UnityEngine.PlayerPrefs.GetInt(key:  "BONUS_WORDS_COUNT", defaultValue:  0);
            store.LifeActivities.LevelPassCount = UnityEngine.PlayerPrefs.GetInt(key:  "LEVEL_PASS_COUNT", defaultValue:  0);
            store.LifeActivities.IsHaveNoviceBankruptcy = ((UnityEngine.PlayerPrefs.GetInt(key:  "Novice_Reward_Bankruptsy", defaultValue:  0)) == 0) ? 1 : 0;
            store.LifeActivities.IsHaveNoviceReward = ((UnityEngine.PlayerPrefs.GetInt(key:  "Novice_Reward_Gift", defaultValue:  0)) == 0) ? 1 : 0;
            store.LifeActivities.DailyLotteryCount = UnityEngine.PlayerPrefs.GetInt(key:  "DAILY_LOTTERY_COUNT", defaultValue:  0);
            store.LifeActivities.FailCountCurLevel = UnityEngine.PlayerPrefs.GetInt(key:  "FAIL_COUNT_CUR_LEVEL");
            store.LifeActivities.FailCountLastLevel = UnityEngine.PlayerPrefs.GetInt(key:  "FAIL_COUNT_LAST_LEVEL");
            store.LifeActivities.CombosCount = UnityEngine.PlayerPrefs.GetInt(key:  "COUNT_OF_COMBOS", defaultValue:  0);
            store.LifeActivities.AllConnectWord = UnityEngine.PlayerPrefs.GetInt(key:  "ALL_CONNECT_WORD", defaultValue:  0);
            store.LifeActivities.LevelPassTime = UnityEngine.PlayerPrefs.GetFloat(key:  "LEVEL_PASS_TIME", defaultValue:  0f);
            store.UserPlayer.Coin = UnityEngine.PlayerPrefs.GetInt(key:  "coins", defaultValue:  244);
            store.UserPlayer.CoinTemp = UnityEngine.PlayerPrefs.GetInt(key:  "coins_temp", defaultValue:  0);
            store.UserPlayer.UserPay = UnityEngine.PlayerPrefs.GetFloat(key:  "USER_PAY", defaultValue:  0f);
            store.UserPlayer.UnlockSectionIndex = UnityEngine.PlayerPrefs.GetInt(key:  "UNLOCK_SECTION_INDEX");
            store.UserPlayer.UnlockLevelIndex = UnityEngine.PlayerPrefs.GetInt(key:  "UNLOCK_LEVEL_INDEX");
            store.UserPlayer.HintFreeStatus = UnityEngine.PlayerPrefs.GetInt(key:  "HINT_FREE_STATUS", defaultValue:  0);
            store.UserPlayer.GameScore = UnityEngine.PlayerPrefs.GetInt(key:  "Game_Score", defaultValue:  0);
            store.UserPlayer.FireworkCount = UnityEngine.PlayerPrefs.GetInt(key:  "FIREWORKCOUNT", defaultValue:  0);
            store.DailyRecord.DailySignDateRecord = UnityEngine.PlayerPrefs.GetString(key:  "DAILYPRAYER_SIGN_DATE_RECORD");
            store.DailyRecord.DailySignRecord = Utils.Extensions.PlayerPrefsExtension.GetInts(key:  "DAILYPRAYER_SIGN_RECORD");
            store.DailyRecord.DailySignBeforeRecord = Utils.Extensions.PlayerPrefsExtension.GetInts(key:  "DAILYPRAYER_SIGN_BEFORE_RECORD");
            store.DailyRecord.DailySignCollectStarRecord = UnityEngine.PlayerPrefs.GetInt(key:  "DAILYPRAYER_SIGN_MONTH_COLLECT_STAR", defaultValue:  0);
            store.DailyRecord.DailySignBeforeCollectStarRecord = UnityEngine.PlayerPrefs.GetInt(key:  "DAILYPRAYER_SIGN_BEFORE_MONTH_COLLECT_STAR", defaultValue:  0);
            store.DailyRecord.DailyRightAnswerList = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "DAILY_RIGHT_ANSWER_LIST");
            store.DailyRecord.DailyPrayerBoxProgress = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "DAILY_PRAYER_BOX_PROGRESS");
            store.DailyRecord.DailyPrayerBoxProgressTest = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "DAILYPRAYER_BOX_PROGRESS_TEST");
            store.DailyRecord.IsTestDailyPrayerBoxProgress = UnityEngine.PlayerPrefs.GetString(key:  "DAILYPRAYER_BOX_PROGRESS_IS_TEST", defaultValue:  "contrast");
            store.DailyRecord.DailyPrayerOpenDate = UnityEngine.PlayerPrefs.GetString(key:  "DAILY_PRAYER_OPEN_DATE_SIGN");
            store.GameRecord.IsTestLevelBoxProgress = UnityEngine.PlayerPrefs.GetString(key:  "LEVEL_BOX_PROGRESS_IS_TEST", defaultValue:  "contrast");
            store.GameRecord.LevelBoxProgress = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "LEVEL_BOX_PROGRESS");
            store.GameRecord.LevelBoxProgressTest = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "LEVEL_BOX_PROGRESS_TEST");
            store.GameRecord.GameRightAnswerList = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "GAME_RIGHT_ANSWER_LIST");
            store.Shop.IsBuyItem = ((UnityEngine.PlayerPrefs.GetInt(key:  "buy_item")) == 1) ? 1 : 0;
            store.Shop.IsBuyAnyItem = ((UnityEngine.PlayerPrefs.GetInt(key:  "BUY_ANY_ITEM")) == 1) ? 1 : 0;
            string val_91 = UnityEngine.PlayerPrefs.GetString(key:  "FIRST_BUY_PRODUCT_TIME", defaultValue:  "");
            store.Shop.FirstBuyTime = val_91;
            string val_92 = val_91.ChangePackName(name:  "60");
            store.Shop.PackageShowTime.Add(key:  val_92, value:  UnityEngine.PlayerPrefs.GetInt(key:  System.String.Format(format:  "PACKAGE_SHOW_TIME_{0}", arg0:  val_92), defaultValue:  0));
            store.Shop.PackageOverdue.Add(key:  val_92, value:  UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "PACKAGE_OVERDUE_{0}", arg0:  val_92), defaultValue:  ""));
            string val_97 = store.Shop.PackageOverdue.ChangePackName(name:  "64");
            store.Shop.PackageShowTime.Add(key:  val_97, value:  UnityEngine.PlayerPrefs.GetInt(key:  System.String.Format(format:  "PACKAGE_SHOW_TIME_{0}", arg0:  val_97), defaultValue:  0));
            store.Shop.PackageOverdue.Add(key:  val_97, value:  UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "PACKAGE_OVERDUE_{0}", arg0:  val_97), defaultValue:  ""));
            string val_102 = store.Shop.PackageOverdue.ChangePackName(name:  "63");
            store.Shop.PackageShowTime.Add(key:  val_102, value:  UnityEngine.PlayerPrefs.GetInt(key:  System.String.Format(format:  "PACKAGE_SHOW_TIME_{0}", arg0:  val_102), defaultValue:  0));
            store.Shop.PackageOverdue.Add(key:  val_102, value:  UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "PACKAGE_OVERDUE_{0}", arg0:  val_102), defaultValue:  ""));
            string val_107 = store.Shop.PackageOverdue.ChangePackName(name:  "65");
            store.Shop.PackageShowTime.Add(key:  val_107, value:  UnityEngine.PlayerPrefs.GetInt(key:  System.String.Format(format:  "PACKAGE_SHOW_TIME_{0}", arg0:  val_107), defaultValue:  0));
            store.Shop.PackageOverdue.Add(key:  val_107, value:  UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "PACKAGE_OVERDUE_{0}", arg0:  val_107), defaultValue:  ""));
            store.PiggyBank.PiggyBankCoin = UnityEngine.PlayerPrefs.GetInt(key:  "PIGGY_BANK_COIN_NUMBER", defaultValue:  0);
            store.PiggyBank.PiggyBankFullUnPop = ((UnityEngine.PlayerPrefs.GetInt(key:  "PIGGY_BANK_FULL_UNPOP", defaultValue:  0)) == 0) ? 1 : 0;
            store.PiggyBank.IsAlreadyPopPiggyBank = ((UnityEngine.PlayerPrefs.GetInt(key:  "PIGGY_BANK_IS_ALREADY_POP", defaultValue:  0)) == 1) ? 1 : 0;
            store.ButterFly.LevelChrysalisCount = UnityEngine.PlayerPrefs.GetInt(key:  "BUTTERFLY_ACTIVITY_LEVEL_CHRYSALIS_COUNT", defaultValue:  0);
            store.ButterFly.ChrysalisCount = UnityEngine.PlayerPrefs.GetInt(key:  "BUTTERFLY_ACTIVITY_CHRYSALIS_COUNT", defaultValue:  0);
            store.ButterFly.ButterFlyList = Utils.Extensions.PlayerPrefsExtension.GetInts(key:  "BUTTERFLY_ACTIVITY_BUTTERFLY_LIST");
            store.ButterFly.ShouldShowButterFlyGuide = ((UnityEngine.PlayerPrefs.GetInt(key:  "BUTTERFLY_ACTIVITY_SHOULD_SHOW_GUIDE", defaultValue:  0)) == 0) ? 1 : 0;
            store.ButterFly.OldCollectButterFly = UnityEngine.PlayerPrefs.GetInt(key:  "BUTTERFLY_ACTIVITY_OLD_COLLECT_BUTTERFLY", defaultValue:  0);
            store.DailyLottery.DailyGiftBoxProgress = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "Daily_Gift_Box_Progress");
            store.DailyLottery.DailyGiftRewardCount = Utils.Extensions.PlayerPrefsExtension.GetInts(key:  "Daily_Gift_Reward_Count");
            store.Notification.IsFirstForNotification = ((UnityEngine.PlayerPrefs.GetInt(key:  "FIRST_START_FOR_NOTIFICATION", defaultValue:  1)) == 1) ? 1 : 0;
            store.Notification.IsNotificationOn = ((UnityEngine.PlayerPrefs.GetInt(key:  "IS_NOTIFICATION_ON", defaultValue:  1)) == 1) ? 1 : 0;
            store.Settings.IsMusicOn = ((UnityEngine.PlayerPrefs.GetInt(key:  "music_enabled", defaultValue:  1)) == 1) ? 1 : 0;
            store.Settings.IsSoundOn = ((UnityEngine.PlayerPrefs.GetInt(key:  "sound_enabled", defaultValue:  1)) == 1) ? 1 : 0;
            store.ExtraWord.ExtraWord = Utils.Extensions.PlayerPrefsExtension.GetStrings(key:  "EXTRA_WORDS");
            store.ExtraWord.Left5Count = UnityEngine.PlayerPrefs.GetInt(key:  "EXTRA_LEFT5_COUNT", defaultValue:  2);
            store.ExtraWord.ExtraProgress = UnityEngine.PlayerPrefs.GetInt(key:  "EXTRA_PROGRESS");
            store.ExtraWord.HasExtraFirst = ((UnityEngine.PlayerPrefs.GetInt(key:  "EXTRA_FIRST", defaultValue:  0)) == 1) ? 1 : 0;
            store.ExtraWord.TotalProgress = UnityEngine.PlayerPrefs.GetInt(key:  "EXTRA_PROGRESS_TOTAL", defaultValue:  0);
        }
        private bool IsNeedDataMigration()
        {
            bool val_2 = System.String.IsNullOrEmpty(value:  UnityEngine.PlayerPrefs.GetString(key:  "APP_VERSION", defaultValue:  ""));
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        private string ChangePackName(string name)
        {
            return name.Replace(oldValue:  " ", newValue:  "_");
        }
    
    }

}
