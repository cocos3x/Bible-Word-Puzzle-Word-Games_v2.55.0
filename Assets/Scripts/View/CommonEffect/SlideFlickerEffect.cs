using UnityEngine;

namespace View.CommonEffect
{
    public class SlideFlickerEffect : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Image image;
        public float to;
        public float duration;
        public float interval;
        public float delay;
        
        // Methods
        private void Start()
        {
            this.DOFlicker();
        }
        public void DOFlicker()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.transform, endValue:  this.to, duration:  this.duration, snapping:  false), delay:  this.interval), ease:  1));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.image, endValue:  0.8f, duration:  this.duration * 0.2f));
            float val_16 = this.duration;
            val_16 = val_16 * 0.8f;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.image, endValue:  0f, duration:  this.duration * 0.2f), delay:  val_16));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  val_1, loops:  0), delay:  this.delay);
        }
        public SlideFlickerEffect()
        {
        
        }
    
    }

}
