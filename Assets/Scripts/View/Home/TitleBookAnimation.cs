using UnityEngine;

namespace View.Home
{
    public class TitleBookAnimation : MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform[] words;
        public float offsetY;
        public float scaleTo;
        public float duration;
        public float delayCut;
        public float delayWord;
        public float delayLoop;
        
        // Methods
        public void PlayAni()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this.DoMove(transArr:  this.words);
            this.DoScale(transArr:  this.words);
        }
        private void DoMove(UnityEngine.Transform[] transArr)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(transArr.Length >= 1)
            {
                    var val_15 = 0;
                do
            {
                UnityEngine.Transform val_13 = transArr[val_15];
                UnityEngine.Vector3 val_2 = val_13.localPosition;
                float val_14 = this.offsetY;
                val_14 = val_2.y + val_14;
                float val_3 = 2f - this.delayCut;
                val_3 = val_3 * 0f;
                val_3 = this.duration * val_3;
                DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_13, endValue:  val_14, duration:  this.duration, snapping:  false), loops:  2, loopType:  1), ease:  1), delay:  V8.16B));
                val_15 = val_15 + 1;
            }
            while(val_15 < transArr.Length);
            
            }
            
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  this.delayWord);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  val_1, loops:  0), delay:  this.delayLoop), id:  this);
        }
        private void DoScale(UnityEngine.Transform[] transArr)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(transArr.Length >= 1)
            {
                    var val_14 = 0;
                do
            {
                UnityEngine.Transform val_12 = transArr[val_14];
                UnityEngine.Vector3 val_2 = val_12.localPosition;
                float val_13 = this.delayCut;
                val_13 = 2f - val_13;
                val_13 = val_13 * 0f;
                val_13 = this.duration * val_13;
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_12, endValue:  this.scaleTo, duration:  this.duration), loops:  2, loopType:  1), ease:  1), delay:  V8.16B));
                val_14 = val_14 + 1;
            }
            while(val_14 < transArr.Length);
            
            }
            
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  this.delayWord);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  val_1, loops:  0), delay:  this.delayLoop), id:  this);
        }
        public TitleBookAnimation()
        {
            this.offsetY = ;
            this.scaleTo = ;
            this.duration = 0.3f;
            this.delayCut = 1f;
            this.delayWord = 3.25f;
            this.delayLoop = 2f;
        }
    
    }

}
