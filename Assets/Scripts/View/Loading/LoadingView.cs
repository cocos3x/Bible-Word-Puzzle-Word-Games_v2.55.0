using UnityEngine;

namespace View.Loading
{
    public class LoadingView : MonoBehaviour
    {
        // Fields
        private static View.Loading.LoadingView _instance;
        private View.Home.HomeTitle title;
        private View.Home.LoadingContent loadingContent;
        private UnityEngine.UI.Text textVersion;
        private bool _isShowLoadingAni;
        
        // Methods
        public static View.Loading.LoadingView Create(UnityEngine.Transform parent)
        {
            if(View.Loading.LoadingView._instance != 0)
            {
                    return (View.Loading.LoadingView)View.Loading.LoadingView._instance;
            }
            
            View.Loading.LoadingView._instance = View.GameViewFactory.CreateLoadingView(parent:  parent);
            val_2.title.LocaleTranslate();
            return (View.Loading.LoadingView)View.Loading.LoadingView._instance;
        }
        private void LocaleTranslate()
        {
            if(this.title != null)
            {
                    this.title.LocaleTranslate();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ShowLoadingView()
        {
            this.gameObject.SetActive(value:  true);
            string val_2 = UnityEngine.Application.version;
            this._isShowLoadingAni = false;
            this.loadingContent.gameObject.SetActive(value:  false);
        }
        private void ShowLoadingAni()
        {
            if(this._isShowLoadingAni != false)
            {
                    return;
            }
            
            this._isShowLoadingAni = true;
            if(this.loadingContent != null)
            {
                    this.loadingContent.ShowLoading();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  39, action:  new System.Action(object:  this, method:  System.Void View.Loading.LoadingView::ShowLoadingAni()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  39, action:  new System.Action(object:  this, method:  System.Void View.Loading.LoadingView::ShowLoadingAni()));
        }
        public LoadingView()
        {
            this._isShowLoadingAni = true;
        }
    
    }

}
