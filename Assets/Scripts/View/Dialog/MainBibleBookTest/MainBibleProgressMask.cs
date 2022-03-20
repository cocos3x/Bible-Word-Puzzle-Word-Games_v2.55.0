using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleProgressMask : MainBibleProgress
    {
        // Fields
        public UnityEngine.Transform MaskProgress;
        private UnityEngine.RectTransform _rectMaskProgress;
        private float _progressWidth;
        private UnityEngine.Vector2 _initValue;
        
        // Methods
        public override void SetProgress(float progress, bool isAll = False)
        {
            bool val_1 = isAll ^ 1;
            isAll = val_1;
            this.maskable = isAll;
            UnityEngine.GameObject val_2 = this.gameObject;
            val_2.SetActive(value:  ((progress == 1f) ? 1 : 0) & val_1);
            val_2.maskable = ((progress < 0) ? 1 : 0) & isAll;
            val_2.gameObject.SetActive(value:  isAll);
            this.ResetMaskProgress();
            UnityEngine.Rect val_9 = this._rectMaskProgress.rect;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  this._progressWidth * progress, y:  val_9.m_XMin.height);
            this._rectMaskProgress.sizeDelta = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        }
        public override DG.Tweening.Tweener AddProgress(float aniTime, bool isAll = False)
        {
            object val_1 = new System.Object();
            typeof(MainBibleProgressMask.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = this;
            typeof(MainBibleProgressMask.<>c__DisplayClass5_0).__il2cppRuntimeField_18 = isAll;
            UnityEngine.GameObject val_3 = val_1.gameObject;
            val_3.SetActive(value:  true);
            val_3.maskable = ((typeof(MainBibleProgressMask.<>c__DisplayClass5_0).__il2cppRuntimeField_18) == false) ? 1 : 0;
            val_3.maskable = typeof(MainBibleProgressMask.<>c__DisplayClass5_0).__il2cppRuntimeField_18;
            this._rectMaskProgress.sizeDelta = new UnityEngine.Vector2() {x = this._initValue};
            this.ResetMaskProgress();
            int val_5 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            UnityEngine.Rect val_6 = this._rectMaskProgress.rect;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  this._progressWidth, y:  val_6.m_XMin.height);
            DG.Tweening.Tweener val_15 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOSizeDelta(target:  this._rectMaskProgress, endValue:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, duration:  aniTime, snapping:  false), ease:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MainBibleProgressMask.<>c__DisplayClass5_0::<AddProgress>b__0())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MainBibleProgressMask.<>c__DisplayClass5_0::<AddProgress>b__1())), id:  this);
            mem[1152921512743184792] = val_15;
            return val_15;
        }
        public override void ResetProgress()
        {
            this.maskable = true;
            this._rectMaskProgress.sizeDelta = new UnityEngine.Vector2() {x = this._initValue};
        }
        private void ResetMaskProgress()
        {
            this.MaskProgress.gameObject.SetActive(value:  false);
            this.MaskProgress.gameObject.SetActive(value:  true);
        }
        private void Awake()
        {
            if((this.MaskProgress != null) && (null == null))
            {
                    this._rectMaskProgress = this.MaskProgress;
                UnityEngine.Rect val_1 = this.MaskProgress.rect;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  val_1.m_XMin.height);
                this._initValue = val_3.x;
                mem[1152921512743606840] = val_3.y;
                this._rectMaskProgress.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                UnityEngine.Rect val_5 = this.transform.rect;
                this._progressWidth = val_5.m_XMin.width;
                return;
            }
            
            this._rectMaskProgress = 0;
            throw new NullReferenceException();
        }
        public MainBibleProgressMask()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
