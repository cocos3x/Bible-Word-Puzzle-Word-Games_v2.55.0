using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleProgressFill : MainBibleProgress
    {
        // Methods
        public override void SetProgress(float progress, bool isAll = False)
        {
            this.fillAmount = (isAll != true) ? 1f : progress;
            UnityEngine.GameObject val_2 = this.gameObject;
            val_2.SetActive(value:  ((progress == 1f) ? 1 : 0) & isAll ^ 1);
            val_2.fillAmount = (isAll != true) ? progress : 0f;
            val_2.gameObject.SetActive(value:  isAll);
        }
        public override DG.Tweening.Tweener AddProgress(float aniTime, bool isAll = False)
        {
            UnityEngine.GameObject val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false).gameObject;
            val_2.SetActive(value:  true);
            if(isAll != false)
            {
                    UnityEngine.GameObject val_3 = val_2.gameObject;
                val_3.SetActive(value:  true);
                DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  val_3, endValue:  1f, duration:  aniTime), ease:  1), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleProgressFill::<AddProgress>b__1_0()));
            }
            
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  val_2, endValue:  1f, duration:  aniTime), ease:  1), id:  this);
            mem[1152921512742523416] = val_10;
            return val_10;
        }
        public override void ResetProgress()
        {
            this.fillAmount = 0f;
            this.fillAmount = 0f;
        }
        public MainBibleProgressFill()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <AddProgress>b__1_0()
        {
            this.gameObject.SetActive(value:  false);
        }
    
    }

}
