using UnityEngine;

namespace View.Dialog.PurchaseFailed
{
    public class PurchaseFailedDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text OkText;
        
        // Methods
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "204");
            string val_2 = Locale.LocaleManager.Translate(key:  "58");
            string val_3 = Locale.LocaleManager.Translate(key:  "59");
            this.OkText.text = Locale.LocaleManager.Translate(key:  "36");
        }
        public PurchaseFailedDialog()
        {
        
        }
    
    }

}
