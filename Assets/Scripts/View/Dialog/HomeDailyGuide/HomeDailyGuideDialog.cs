using UnityEngine;

namespace View.Dialog.HomeDailyGuide
{
    public class HomeDailyGuideDialog : Dialog
    {
        // Fields
        public UnityEngine.Transform arrows;
        public View.Home.HomeDailySignProgress SignProgress;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text GotItText;
        
        // Methods
        private void Start()
        {
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetShouldShowHomeDailyDialog(isShould:  false);
            UnityEngine.Vector3 val_2 = this.arrows.localPosition;
            float val_6 = -50f;
            val_6 = val_2.y + val_6;
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.arrows, endValue:  val_6, duration:  0.5f, snapping:  false), loops:  0, loopType:  1), ease:  5);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "92");
            this.GotItText.text = Locale.LocaleManager.Translate(key:  "24");
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.SignProgress.gameObject.SetActive(value:  true);
            this.SignProgress.SetDailySignProgress();
        }
        public HomeDailyGuideDialog()
        {
        
        }
    
    }

}
