using UnityEngine;

namespace View.Dialog.ButterFlyHelp
{
    public class ButterFlyHelpDialog : Dialog
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text Step1Text;
        public UnityEngine.UI.Text Step2Text;
        public UnityEngine.UI.Text Step3Text;
        public TMPro.TMP_Text OkText;
        public UnityEngine.UI.Image ImageStep;
        
        // Methods
        public void OnClickCloseButton()
        {
            this.Close();
        }
        protected override void LocaleTranslate()
        {
            var val_8;
            string val_9;
            string val_1 = Locale.LocaleManager.Translate(key:  "91");
            string val_2 = Locale.LocaleManager.Translate(key:  "124");
            string val_3 = Locale.LocaleManager.Translate(key:  "125");
            string val_4 = Locale.LocaleManager.Translate(key:  "126");
            this.OkText.text = Locale.LocaleManager.Translate(key:  "36");
            val_8 = "Atlas/ButterFlyActivity";
            Locale.LocaleE val_6 = Locale.LocaleManager.GetCurLanguage();
            if(val_6 == 3)
            {
                goto label_6;
            }
            
            if(val_6 == 2)
            {
                goto label_7;
            }
            
            if(val_6 != 1)
            {
                goto label_8;
            }
            
            val_9 = "Atlas/LocalePortuguese";
            goto label_10;
            label_7:
            val_9 = "Atlas/LocaleSpanish";
            goto label_10;
            label_6:
            val_9 = "Atlas/LocaleFrench";
            label_10:
            label_8:
            this.ImageStep.sprite = Resource.ResManager.GetSpriteFromPool(atlas:  val_9, spriteName:  "Img_Rule_Step_1");
        }
        public ButterFlyHelpDialog()
        {
            mem[1152921512803691720] = 257;
            mem[1152921512803691723] = 1;
            mem[1152921512803691728] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
