using UnityEngine;

namespace Logic.Game
{
    public class GameControllers : SingletonController<Logic.Game.GameControllers>
    {
        // Fields
        private bool <IsGameComplete>k__BackingField;
        private bool <IsHideBanner>k__BackingField;
        private int <OldScore>k__BackingField;
        private int <OldPiggyBankCoin>k__BackingField;
        private int <OldChrysalisCount>k__BackingField;
        private int <OldCollectChrysalisLevel>k__BackingField;
        private int <NowCurLevelUseHintCount>k__BackingField;
        private int <NowCurLevelUseRefreshCount>k__BackingField;
        private int <NowCurLevelUseFireworkCount>k__BackingField;
        private int <NowCurLevelWrongCount>k__BackingField;
        private int <NowCurLevelMaxComboCount>k__BackingField;
        private string <NowCurLevelName>k__BackingField;
        private Data.Bean.LevelBean _levelBean;
        private Data.Bean.QuizLevelBean _quizLevelBean;
        private System.DateTime _timeNow;
        
        // Properties
        public bool IsGameComplete { get; set; }
        public bool IsHideBanner { set; }
        public int OldScore { get; set; }
        public int OldPiggyBankCoin { get; set; }
        public int OldChrysalisCount { get; set; }
        public int OldCollectChrysalisLevel { get; set; }
        public int NowCurLevelUseHintCount { get; set; }
        public int NowCurLevelUseRefreshCount { get; set; }
        public int NowCurLevelUseFireworkCount { get; set; }
        public int NowCurLevelWrongCount { get; set; }
        public int NowCurLevelMaxComboCount { get; set; }
        public string NowCurLevelName { get; set; }
        public Data.Bean.LevelBean CurrentLevelBean { get; set; }
        public Data.Bean.QuizLevelBean CurrentQuizLevelBean { get; set; }
        
        // Methods
        public bool get_IsGameComplete()
        {
            return (bool)this.<IsGameComplete>k__BackingField;
        }
        public void set_IsGameComplete(bool value)
        {
            this.<IsGameComplete>k__BackingField = value;
        }
        public void set_IsHideBanner(bool value)
        {
            this.<IsHideBanner>k__BackingField = value;
        }
        public int get_OldScore()
        {
            return (int)this.<OldScore>k__BackingField;
        }
        public void set_OldScore(int value)
        {
            this.<OldScore>k__BackingField = value;
        }
        public int get_OldPiggyBankCoin()
        {
            return (int)this.<OldPiggyBankCoin>k__BackingField;
        }
        public void set_OldPiggyBankCoin(int value)
        {
            this.<OldPiggyBankCoin>k__BackingField = value;
        }
        public int get_OldChrysalisCount()
        {
            return (int)this.<OldChrysalisCount>k__BackingField;
        }
        public void set_OldChrysalisCount(int value)
        {
            this.<OldChrysalisCount>k__BackingField = value;
        }
        public int get_OldCollectChrysalisLevel()
        {
            return (int)this.<OldCollectChrysalisLevel>k__BackingField;
        }
        public void set_OldCollectChrysalisLevel(int value)
        {
            this.<OldCollectChrysalisLevel>k__BackingField = value;
        }
        public int get_NowCurLevelUseHintCount()
        {
            return (int)this.<NowCurLevelUseHintCount>k__BackingField;
        }
        public void set_NowCurLevelUseHintCount(int value)
        {
            this.<NowCurLevelUseHintCount>k__BackingField = value;
        }
        public int get_NowCurLevelUseRefreshCount()
        {
            return (int)this.<NowCurLevelUseRefreshCount>k__BackingField;
        }
        public void set_NowCurLevelUseRefreshCount(int value)
        {
            this.<NowCurLevelUseRefreshCount>k__BackingField = value;
        }
        public int get_NowCurLevelUseFireworkCount()
        {
            return (int)this.<NowCurLevelUseFireworkCount>k__BackingField;
        }
        public void set_NowCurLevelUseFireworkCount(int value)
        {
            this.<NowCurLevelUseFireworkCount>k__BackingField = value;
        }
        public int get_NowCurLevelWrongCount()
        {
            return (int)this.<NowCurLevelWrongCount>k__BackingField;
        }
        public void set_NowCurLevelWrongCount(int value)
        {
            this.<NowCurLevelWrongCount>k__BackingField = value;
        }
        public int get_NowCurLevelMaxComboCount()
        {
            return (int)this.<NowCurLevelMaxComboCount>k__BackingField;
        }
        public void set_NowCurLevelMaxComboCount(int value)
        {
            this.<NowCurLevelMaxComboCount>k__BackingField = value;
        }
        public string get_NowCurLevelName()
        {
            return (string)this.<NowCurLevelName>k__BackingField;
        }
        public void set_NowCurLevelName(string value)
        {
            this.<NowCurLevelName>k__BackingField = value;
        }
        public Data.Bean.LevelBean get_CurrentLevelBean()
        {
            return (Data.Bean.LevelBean)this._levelBean;
        }
        private void set_CurrentLevelBean(Data.Bean.LevelBean value)
        {
            this._levelBean = value;
        }
        public void SetCurrentLevelBean(Data.Bean.LevelBean bean)
        {
            this._levelBean = bean;
        }
        public Data.Bean.QuizLevelBean get_CurrentQuizLevelBean()
        {
            return (Data.Bean.QuizLevelBean)this._quizLevelBean;
        }
        private void set_CurrentQuizLevelBean(Data.Bean.QuizLevelBean value)
        {
            this._quizLevelBean = value;
        }
        public void SetCurrentQuizLevelBean(Data.Bean.QuizLevelBean bean)
        {
            this._quizLevelBean = bean;
        }
        public bool GetLevelHasBonus()
        {
            if(this._levelBean == null)
            {
                    return (bool)this._levelBean;
            }
            
            return this._levelBean.HasBonus();
        }
        public int GetLevelHasBonusCount()
        {
            if(this._levelBean == null)
            {
                    return (int)this._levelBean;
            }
            
            return this._levelBean.HasBonusCount();
        }
        public int GetLevelLettersLength()
        {
            if(this._levelBean == null)
            {
                    return 0;
            }
            
            if(this._levelBean.l != null)
            {
                    return (int)this._levelBean.l.m_stringLength;
            }
            
            throw new NullReferenceException();
        }
        public int GetLevelAnswerListCount()
        {
            if(this._levelBean == null)
            {
                    return (int)this._levelBean.answerList;
            }
            
            return (int)this._levelBean.answerList;
        }
        public int GetLevelAnswerCount(int index)
        {
            Data.Bean.LevelBean val_2;
            bool val_2 = true;
            val_2 = this._levelBean;
            if(val_2 == null)
            {
                    return (int)val_2;
            }
            
            System.Collections.Generic.List<System.String> val_1 = val_2.answerList;
            if(val_2 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (index << 3);
            val_2 = mem[(true + (index) << 3) + 32 + 16];
            val_2 = (true + (index) << 3) + 32 + 16;
            return (int)val_2;
        }
        public bool CheckWordExact(System.Collections.Generic.List<string> words)
        {
            var val_5;
            if(words == null)
            {
                    if(this._levelBean != null)
            {
                goto label_15;
            }
            
            }
            
            if((W9 != 0) && ((System.String.IsNullOrEmpty(value:  this._levelBean.l)) != true))
            {
                    if(this._levelBean < 1)
            {
                    return (bool)val_5;
            }
            
                var val_5 = 0;
                if(val_5 >= this._levelBean)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_5 >= null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_4 = 0;
                if(((this._levelBean.l.IndexOf(value:  Data.Bean.LevelBean.__il2cppRuntimeField_byval_arg.Chars[0])) & 2147483648) == 0)
            {
                    val_4 = val_4 + 1;
                val_5 = val_5 + 1;
                val_5 = 1;
                return (bool)val_5;
            }
            
            }
            
            label_15:
            val_5 = 0;
            return (bool)val_5;
        }
        public void ScoreUpdateData(int score = 0)
        {
            Logic.Game.GameLevel val_13;
            var val_14;
            var val_15;
            val_14 = score;
            int val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GameScore;
            this.<OldScore>k__BackingField = val_2;
            if(val_2 == 1)
            {
                    val_13 = Logic.Game.GameManager.gameLevel;
                int val_6 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex;
                this.<OldScore>k__BackingField = val_13.GetAllScore(unlockSectionIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex, unlockLevelIndex:  0);
            }
            
            System.Collections.Generic.List<System.String> val_8 = this._levelBean.answerList;
            if((public static Data.UserPlayer.UserPlayerDataManager Common.Singleton<Data.UserPlayer.UserPlayerDataManager>::get_Instance()) < 2)
            {
                goto label_8;
            }
            
            System.Collections.Generic.List<System.String> val_9 = this._levelBean.answerList;
            val_15 = 1152921512608190958;
            if(val_14 != 0)
            {
                goto label_13;
            }
            
            goto label_12;
            label_8:
            val_15 = 0;
            if(val_14 != 0)
            {
                goto label_13;
            }
            
            label_12:
            int val_12 = this._levelBean.l.m_stringLength;
            val_12 = val_12 - 2;
            val_14 = 2 + (val_12 * val_15);
            label_13:
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.SetGameScore(score:  (this.<OldScore>k__BackingField) + val_14);
        }
        public void PiggyBankCoinUpdateData()
        {
            int val_10;
            int val_11;
            int val_2 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.GetPiggyBankCoinNumber();
            this.<OldPiggyBankCoin>k__BackingField = val_2;
            Data.PiggyBank.PiggyBankDataManager val_3 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            if(val_2 >= val_3.PiggyBankMaxNum)
            {
                    return;
            }
            
            Data.PiggyBank.PiggyBankDataManager val_4 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            val_10 = val_4.PiggyBankCollectNum;
            val_11 = this.<OldPiggyBankCoin>k__BackingField;
            Data.PiggyBank.PiggyBankDataManager val_5 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            if(val_11 == 0)
            {
                goto label_5;
            }
            
            if(val_11 >= val_5.PiggyBankStartUpNum)
            {
                goto label_11;
            }
            
            val_11 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            Data.PiggyBank.PiggyBankDataManager val_7 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            val_11.SetPiggyBankCoinNumber(num:  val_7.PiggyBankStartUpNum);
            Data.PiggyBank.PiggyBankDataManager val_8 = Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance;
            this.<OldPiggyBankCoin>k__BackingField = val_8.PiggyBankStartUpNum;
            goto label_11;
            label_5:
            val_10 = val_5.PiggyBankStartUpNum;
            label_11:
            Common.Singleton<Data.PiggyBank.PiggyBankDataManager>.Instance.AddPiggyBankCoinNum(num:  val_10);
        }
        public void ChrysalisUpdateData()
        {
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) == 0)
            {
                    return;
            }
            
            this.<OldChrysalisCount>k__BackingField = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetNowRoundChrysalisCount();
            this.<OldCollectChrysalisLevel>k__BackingField = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisLevel();
            Logic.ButterFly.ButterFlyController val_7 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance;
            int val_9 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount;
            val_9.CollectChrysalis(count:  val_9);
        }
        public bool ShouldShowDailyLottery()
        {
            System.DateTime val_14;
            ulong val_15;
            val_14 = 1152921504613236736;
            System.DateTime val_1 = System.DateTime.Now;
            this._timeNow = val_1;
            Data.Login.LoginDataManager val_2 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            System.Nullable<System.DateTime> val_3 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = this._timeNow});
            val_15 = val_2._lastLoginNetDateTime;
            if((Common.GlobalMethods.IsToday(des:  new System.DateTime() {dateData = val_15}, res:  new System.Nullable<System.DateTime>() {HasValue = val_3.HasValue})) != false)
            {
                    int val_6 = Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.DailyLotteryCount;
                if(val_6 != 0)
            {
                    return false;
            }
            
            }
            
            if(val_6.IsUnlock2_3Level() == false)
            {
                    return false;
            }
            
            Data.Login.LoginDataManager val_8 = Common.Singleton<Data.Login.LoginDataManager>.Instance;
            val_14 = this._timeNow;
            if(((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_8._lastLoginNetDateTime}, t2:  new System.DateTime() {dateData = val_14})) & 2147483648) == 0)
            {
                    return false;
            }
            
            Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.SaveDailyGiftBoxProgress(data:  0);
            Common.Singleton<Data.DailyLottery.DailyLotteryDataManager>.Instance.SaveDailyGiftRewardCount(data:  0);
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddDailyLotteryCount();
            Common.Singleton<Data.Login.LoginDataManager>.Instance.LastLoginNetDateTime = new System.DateTime() {dateData = this._timeNow};
            return false;
        }
        private bool IsUnlock2_3Level()
        {
            var val_4;
            Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_1.<CurrentSectionIndex>k__BackingField) <= 1)
            {
                goto label_2;
            }
            
            label_7:
            val_4 = 1;
            return (bool)val_4;
            label_2:
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_2.<CurrentSectionIndex>k__BackingField) != 1)
            {
                goto label_5;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_3 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_3.<CurrentLevelIndex>k__BackingField) > 1)
            {
                goto label_7;
            }
            
            label_5:
            val_4 = 0;
            return (bool)val_4;
        }
        public bool IsRewardAdStarted()
        {
            return (bool)(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) + 1) > 1) ? 1 : 0;
        }
        public bool IsRewardAdStartedForReward()
        {
            var val_8;
            if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) + 1) <= 2)
            {
                    if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) != 1) || ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) <= 0))
            {
                goto label_6;
            }
            
            }
            
            val_8 = 1;
            return (bool)val_8;
            label_6:
            val_8 = 0;
            return (bool)val_8;
        }
        public GameControllers()
        {
        
        }
    
    }

}
