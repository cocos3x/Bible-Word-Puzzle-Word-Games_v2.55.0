using UnityEngine;

namespace View.CommonItem
{
    public class ItemBreatheBeat : MonoBehaviour
    {
        // Fields
        public float to;
        public float duration;
        public float delay;
        public float interval;
        public bool isPlayOnAwake;
        private DG.Tweening.Sequence sequence;
        
        // Methods
        private void Awake()
        {
            if(this.isPlayOnAwake == false)
            {
                    return;
            }
            
            this.PlayBreathe();
        }
        public void PlayBreathe()
        {
            if(this.sequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.sequence, complete:  false);
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.sequence = val_1;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.to);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  this.duration), loops:  2, loopType:  1), ease:  26), delay:  this.interval)), loops:  0), delay:  this.delay);
        }
        public ItemBreatheBeat()
        {
            this.isPlayOnAwake = true;
        }
    
    }

}
