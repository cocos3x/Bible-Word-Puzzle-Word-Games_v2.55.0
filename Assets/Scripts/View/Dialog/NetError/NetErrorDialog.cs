using UnityEngine;

namespace View.Dialog.NetError
{
    public class NetErrorDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Button retryButton;
        public UnityEngine.UI.Button closeButton;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text RetryText;
        public System.Action onRetryClick;
        public System.Action onCloseClick;
        
        // Methods
        public void SetAction(System.Action onRetryClick, System.Action onCloseClick)
        {
            this.onRetryClick = onRetryClick;
            this.onCloseClick = onCloseClick;
        }
        public void ActiveBlackBG(bool isActive)
        {
            float val_2;
            float val_3;
            if(isActive != false)
            {
                    val_2 = 0.7f;
                val_3 = 0f;
            }
            else
            {
                    UnityEngine.Color val_1;
                val_3 = 0f;
                val_2 = 0f;
            }
            
            val_1 = new UnityEngine.Color(r:  0f, g:  val_3, b:  0f, a:  val_2);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "205");
            string val_2 = Locale.LocaleManager.Translate(key:  "132");
            this.RetryText.text = Locale.LocaleManager.Translate(key:  "161");
        }
        private void Start()
        {
            this.retryButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.NetError.NetErrorDialog::<Start>b__10_0()));
            this.closeButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.NetError.NetErrorDialog::<Start>b__10_1()));
        }
        private void OnDisable()
        {
            this.ActiveBlackBG(isActive:  false);
            this.onRetryClick = 0;
            this.onCloseClick = 0;
        }
        public NetErrorDialog()
        {
        
        }
        private void <Start>b__10_0()
        {
            if(this.onRetryClick != null)
            {
                    this.onRetryClick.Invoke();
            }
        
        }
        private void <Start>b__10_1()
        {
            if(this.onCloseClick != null)
            {
                    this.onCloseClick.Invoke();
            }
        
        }
    
    }

}
