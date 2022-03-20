using UnityEngine;

namespace View.Home
{
    public class TitleWords : MonoBehaviour
    {
        // Fields
        private const float OffsetY = 28;
        private const float ScaleTo = 1.1;
        private const float Duration = 0.3;
        private const float DelayLoop = 2;
        private UnityEngine.RectTransform[] words;
        private System.Collections.Generic.List<UnityEngine.Vector2> _wordsPos;
        
        // Methods
        private void OnDisable()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
        }
        public void InitTitleWord()
        {
            var val_2;
            this._wordsPos.Clear();
            val_2 = 0;
            do
            {
                if(val_2 >= this.words.Length)
            {
                    return;
            }
            
                UnityEngine.Vector2 val_1 = this.words[val_2].anchoredPosition;
                this._wordsPos.Add(item:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
                val_2 = val_2 + 1;
            }
            while(this.words != null);
            
            throw new NullReferenceException();
        }
        public void PlayAni()
        {
            UnityEngine.RectTransform[] val_3;
            var val_4;
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            val_3 = this.words;
            val_4 = 0;
            label_15:
            if(val_4 >= this.words.Length)
            {
                goto label_4;
            }
            
            if(val_4 < W10)
            {
                    if(W10 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3[0].anchoredPosition = new UnityEngine.Vector2() {x = val_3[0][0], y = val_3[0][0]};
                val_3 = this.words;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_3[val_4].localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            val_4 = val_4 + 1;
            if(this.words != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_4:
            this.DoMove();
        }
        private void DoMove()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            var val_21 = 0;
            label_7:
            if(val_21 >= this.words.Length)
            {
                goto label_4;
            }
            
            UnityEngine.RectTransform val_20 = this.words[val_21];
            UnityEngine.Vector3 val_2 = val_20.localPosition;
            float val_4 = 0f * 0.3f;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_20, endValue:  val_2.y + 28f, duration:  0.3f, snapping:  false), loops:  2, loopType:  1), ease:  1), delay:  val_4));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_20, endValue:  1.1f, duration:  0.3f), loops:  2, loopType:  1), ease:  1), delay:  val_4));
            val_21 = val_21 + 1;
            if(this.words != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_4:
            float val_23 = 0.6f;
            float val_22 = (float)this.words.Length - 1;
            val_22 = val_22 * 0.3f;
            val_23 = val_22 + val_23;
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  val_23);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  val_1, loops:  0), delay:  2f), id:  this);
        }
        public TitleWords()
        {
            this._wordsPos = new System.Collections.Generic.List<UnityEngine.Vector2>();
        }
    
    }

}
