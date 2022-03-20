using UnityEngine;

namespace View.Game
{
    public class LevelPassTime : Singleton<View.Game.LevelPassTime>
    {
        // Fields
        private float _time;
        private float _dailyTime;
        private float timeStart;
        private View.Game.LevelPassTime.State state;
        private bool isInGameScene;
        private float _temp;
        
        // Properties
        private float GameTime { get; set; }
        private float DailyTime { get; set; }
        
        // Methods
        private float get_GameTime()
        {
            return (float)this._time;
        }
        private void set_GameTime(float value)
        {
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.SetLevelPassTime(time:  value);
            this._time = value;
        }
        private float get_DailyTime()
        {
            return (float)this._dailyTime;
        }
        private void set_DailyTime(float value)
        {
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.SetLevelPassDailyTime(time:  value);
            this._dailyTime = value;
        }
        public LevelPassTime()
        {
            this._dailyTime = Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.LevelPassDailyTime;
            this._time = Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.LevelPassTime;
        }
        public void TimingInGameStart()
        {
            this._temp = 0f;
            this.isInGameScene = true;
            this.TimingStart();
        }
        public void TimingStart()
        {
            if(this.isInGameScene == false)
            {
                    return;
            }
            
            if(this.state == 1)
            {
                    return;
            }
            
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 4)
            {
                goto label_4;
            }
            
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            if((val_2.<IsGameComplete>k__BackingField) == false)
            {
                goto label_6;
            }
            
            label_4:
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState != 3)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_4 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_4.<IsGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            label_6:
            this.timeStart = UnityEngine.Time.time;
            this.state = 1;
        }
        public void TimingPause()
        {
            if(this.isInGameScene == false)
            {
                    return;
            }
            
            if(this.state != 1)
            {
                    return;
            }
            
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 4)
            {
                goto label_4;
            }
            
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            if((val_2.<IsGameComplete>k__BackingField) == false)
            {
                goto label_6;
            }
            
            label_4:
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState != 3)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_4 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_4.<IsGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            float val_5 = UnityEngine.Time.time;
            val_5 = val_5 - this.timeStart;
            val_5 = this._time + val_5;
            this.GameTime = val_5;
            goto label_11;
            label_6:
            float val_6 = UnityEngine.Time.time;
            val_6 = val_6 - this.timeStart;
            val_6 = this._dailyTime + val_6;
            this.DailyTime = val_6;
            label_11:
            this.state = 2;
        }
        public void TimingLeaveGameScene()
        {
            this.TimingPause();
            this.isInGameScene = false;
        }
        public int TimingStop()
        {
            if(this.state == 2)
            {
                goto label_1;
            }
            
            if(this.state != 1)
            {
                goto label_13;
            }
            
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 4)
            {
                goto label_4;
            }
            
            float val_2 = UnityEngine.Time.time;
            val_2 = this._dailyTime + val_2;
            this.state = 3;
            val_2 = val_2 - this.timeStart;
            this._temp = val_2;
            goto label_5;
            label_1:
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState != 4)
            {
                goto label_7;
            }
            
            this.state = 3;
            this._temp = this._dailyTime;
            label_5:
            this.DailyTime = 0f;
            goto label_13;
            label_4:
            View.Controller.MainController val_4 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_4._bibleGameState != 3)
            {
                goto label_13;
            }
            
            float val_5 = UnityEngine.Time.time;
            val_5 = this._time + val_5;
            this.state = 3;
            val_5 = val_5 - this.timeStart;
            this._temp = val_5;
            goto label_11;
            label_7:
            View.Controller.MainController val_6 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_6._bibleGameState != 3)
            {
                goto label_13;
            }
            
            this.state = 3;
            this._temp = this._time;
            label_11:
            this.GameTime = 0f;
            label_13:
            float val_7 = this._temp;
            val_7 = val_7 * 1000f;
            return (int)(int)val_7;
        }
    
    }

}
