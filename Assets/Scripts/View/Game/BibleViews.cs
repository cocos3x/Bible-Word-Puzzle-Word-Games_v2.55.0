using UnityEngine;

namespace View.Game
{
    public class BibleViews : MonoBehaviour
    {
        // Fields
        private View.Loading.LoadingView _loadingView;
        private View.Home.HomeView _homeView;
        private View.Game.GameView _gameView;
        private View.DailyPrayer.DailyPrayerView _dailyPrayerView;
        
        // Methods
        public void OnOpenLoadingView()
        {
            if(this._loadingView != 0)
            {
                goto label_3;
            }
            
            View.Loading.LoadingView val_3 = View.Loading.LoadingView.Create(parent:  this.transform);
            this._loadingView = val_3;
            if(val_3 != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            this._loadingView.ShowLoadingView();
            if(this._gameView != 0)
            {
                    this._gameView.HideGameView(isAni:  false);
            }
            
            if(this._dailyPrayerView == 0)
            {
                    return;
            }
            
            this._dailyPrayerView.HideDailyPrayerView();
        }
        public void OnOpenHomeView(Logic.Define.OpenHomeFrom homeFrom)
        {
            Message.Messager.Dispatch(cmd:  40);
            if(this._gameView != 0)
            {
                    this._gameView.HideGameView(isAni:  true);
            }
            
            if(this._dailyPrayerView != 0)
            {
                    this._dailyPrayerView.HideDailyPrayerView();
            }
            
            if(this._homeView != 0)
            {
                goto label_13;
            }
            
            View.Home.HomeView val_5 = View.Home.HomeView.Create(parent:  this.transform);
            this._homeView = val_5;
            if(val_5 != null)
            {
                goto label_14;
            }
            
            label_13:
            label_14:
            this._homeView.ShowHomeView(homeFrom:  homeFrom);
        }
        public void OnOpenGameView(Logic.Define.OpenGameFrom gameFrom)
        {
            Message.Messager.Dispatch<System.Single>(cmd:  44, t:  0.58f);
            if(this._gameView != 0)
            {
                goto label_5;
            }
            
            View.Game.GameView val_3 = View.Game.GameView.Create(parent:  this.transform);
            this._gameView = val_3;
            if(val_3 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            this._gameView.ShowGameView(gameFrom:  gameFrom);
            if(this._homeView != 0)
            {
                    this._homeView.HideHomeView(isOpenGame:  true);
            }
            
            if(this._dailyPrayerView == 0)
            {
                    return;
            }
            
            this._dailyPrayerView.HideDailyPrayerView();
        }
        public void OnOpenDailyPrayerView(Logic.Define.OpenDailyPrayerFrom dailyPrayerFrom)
        {
            Message.Messager.Dispatch<System.Single>(cmd:  91, t:  0.45f);
            if(this._dailyPrayerView != 0)
            {
                goto label_5;
            }
            
            View.DailyPrayer.DailyPrayerView val_3 = View.DailyPrayer.DailyPrayerView.Create(parent:  this.transform);
            this._dailyPrayerView = val_3;
            if(val_3 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            this._dailyPrayerView.ShowDailyPrayerView(dailyPrayerFrom:  dailyPrayerFrom);
            if(this._homeView == 0)
            {
                    return;
            }
            
            this._homeView.HideHomeView(isOpenGame:  false);
        }
        public void DestroyLoading()
        {
            if(this._loadingView == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this._loadingView.gameObject);
            this._loadingView = 0;
        }
        public BibleViews()
        {
        
        }
    
    }

}
