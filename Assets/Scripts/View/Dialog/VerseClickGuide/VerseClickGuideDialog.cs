using UnityEngine;

namespace View.Dialog.VerseClickGuide
{
    public class VerseClickGuideDialog : Dialog
    {
        // Fields
        public UnityEngine.Transform Arrows;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text GotItText;
        private UnityEngine.RectTransform _rectArrows;
        private UnityEngine.Vector3 InitPos;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Transform val_2;
            this.Awake();
            val_2 = this.Arrows;
            this._rectArrows = (null == null) ? (val_2) : 0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            UnityEngine.Vector2 val_1 = this._rectArrows.anchoredPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            this.InitPos = val_2;
            mem[1152921512659551276] = val_2.y;
            float val_6 = 28f;
            val_6 = val_2.y + val_6;
            mem[1152921512659551280] = val_2.z;
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this._rectArrows, endValue:  val_6, duration:  0.5f, snapping:  false), loops:  0, loopType:  1), ease:  5);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "23");
            this.GotItText.text = Locale.LocaleManager.Translate(key:  "24");
        }
        public VerseClickGuideDialog()
        {
        
        }
    
    }

}
