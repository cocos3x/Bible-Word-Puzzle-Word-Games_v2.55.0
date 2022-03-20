using UnityEngine;

namespace View.Home
{
    public class HomeView : UIView
    {
        // Fields
        private static View.Home.HomeView _instance;
        private View.Home.HomeTopMenu topMenu;
        private UnityEngine.GameObject playBtnEffect;
        public UnityEngine.Animator AnimatorHome;
        public View.Home.HomeTitle Title;
        
        // Methods
        public static View.Home.HomeView Create(UnityEngine.Transform parent)
        {
            if(View.Home.HomeView._instance != 0)
            {
                    return (View.Home.HomeView)View.Home.HomeView._instance;
            }
            
            View.Home.HomeView._instance = View.GameViewFactory.CreateHomeView(parent:  parent);
            val_2.Title.LocaleTranslate();
            return (View.Home.HomeView)View.Home.HomeView._instance;
        }
        protected void LocaleTranslate()
        {
            if(this.Title != null)
            {
                    this.Title.LocaleTranslate();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ShowHomeView(Logic.Define.OpenHomeFrom homeFrom)
        {
            string val_2;
            this.gameObject.SetActive(value:  true);
            if(homeFrom == 0)
            {
                goto label_2;
            }
            
            if(homeFrom == 2)
            {
                goto label_3;
            }
            
            if(homeFrom != 1)
            {
                goto label_4;
            }
            
            this.AnimatorHome.Play(stateName:  "HomeShowBible");
            goto label_6;
            label_2:
            val_2 = "HomeShow";
            goto label_10;
            label_3:
            val_2 = "HomeShowFromGame";
            goto label_10;
            label_4:
            val_2 = "HomeShow_2";
            label_10:
            this.AnimatorHome.Play(stateName:  val_2);
            this.Title._titleWords.PlayAni();
            label_6:
            this.topMenu.UpdateLotteryState();
        }
        public void HideHomeView(bool isOpenGame = False)
        {
            this.playBtnEffect.SetActive(value:  false);
            if(isOpenGame != false)
            {
                    View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
                this.AnimatorHome.Play(stateName:  (val_1._lastGameState == 1) ? "LoadingHideToGame" : "HomeHideToGame");
                return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        private void HomeHideToGameCallBack()
        {
            this.gameObject.SetActive(value:  false);
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  42, action:  new System.Action(object:  this, method:  System.Void View.Home.HomeView::HomeHideToGameCallBack()));
            this.playBtnEffect.SetActive(value:  true);
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  42, action:  new System.Action(object:  this, method:  System.Void View.Home.HomeView::HomeHideToGameCallBack()));
        }
        public HomeView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
