using UnityEngine;

namespace View.Dialog.ContactUs
{
    public class ContactUsDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.InputField inputField;
        public UnityEngine.UI.Button feedbackButton;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text SendText;
        private int star;
        private UnityEngine.UI.Image feedbackImage;
        
        // Methods
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "81");
            string val_2 = Locale.LocaleManager.Translate(key:  "82");
            this.SendText.text = Locale.LocaleManager.Translate(key:  "83");
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_contact_us", action:  "show_contact_us", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            this.feedbackImage = this.feedbackButton.GetComponent<UnityEngine.UI.Image>();
            this.feedbackButton.interactable = false;
            this.inputField.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void View.Dialog.ContactUs.ContactUsDialog::<OnEnable>b__8_0(string text)));
            this.feedbackButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.ContactUs.ContactUsDialog::<OnEnable>b__8_1()));
            this.inputField.shouldHideMobileInput = false;
        }
        public void OnCloseClick()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_contact_us", action:  "click_btn_close", label:  "", value:  0);
            goto typeof(View.Dialog.ContactUs.ContactUsDialog).__il2cppRuntimeField_1E0;
        }
        public void OnClickButton()
        {
            if((this.inputField.m_Text.Equals(value:  "up¥onepiece")) == false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.Open(name:  "DebugDialog", type:  0);
            this = ???;
            goto typeof(View.Dialog.ContactUs.ContactUsDialog).__il2cppRuntimeField_1E0;
        }
        public ContactUsDialog()
        {
            mem[1152921512787478536] = 257;
            mem[1152921512787478539] = 1;
            mem[1152921512787478544] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <OnEnable>b__8_0(string text)
        {
            this.feedbackButton.interactable = (~(System.String.IsNullOrEmpty(value:  text.Trim()))) & 1;
        }
        private void <OnEnable>b__8_1()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dlg_contact_us", action:  "click_btn_send", label:  "", value:  0);
            Logic.Game.GameManager.gameSound.PlayButton();
            Common.Singleton<Data.RateUs.RateUsDataManager>.Instance.SetFeedback(isFeedback:  true);
            Common.EzRate.Feedback(text:  this.inputField.m_Text, star:  this.star, levelName:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName());
            this.inputField.text = "";
            goto typeof(View.Dialog.ContactUs.ContactUsDialog).__il2cppRuntimeField_1E0;
        }
    
    }

}
