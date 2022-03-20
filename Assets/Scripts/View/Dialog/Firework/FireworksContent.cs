using UnityEngine;

namespace View.Dialog.Firework
{
    public class FireworksContent : MonoBehaviour
    {
        // Fields
        private bool playSound;
        private UnityEngine.CanvasGroup canvasGroup;
        private UnityEngine.Transform _transform;
        
        // Methods
        private void Awake()
        {
            this._transform = this.transform;
        }
        public void Open()
        {
            string val_13;
            this.gameObject.SetActive(value:  true);
            if(this.playSound != false)
            {
                    if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_13 = "eff_btn_click";
            }
            else
            {
                    val_13 = "open";
            }
            
                Logic.Game.GameManager.gameSound.Play(clipName:  val_13, volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this._transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.canvasGroup.alpha = 1f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  0f, duration:  0.5f))), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this._transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.25f)), ease:  27));
        }
        public void Close(System.Action action)
        {
            string val_10;
            typeof(FireworksContent.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = this;
            typeof(FireworksContent.<>c__DisplayClass5_0).__il2cppRuntimeField_18 = action;
            if(this.playSound != false)
            {
                    if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_10 = "eff_popup_close";
            }
            else
            {
                    val_10 = "close";
            }
            
                Logic.Game.GameManager.gameSound.Play(clipName:  val_10, volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.DOTween.Sequence(), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this._transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  26)), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void FireworksContent.<>c__DisplayClass5_0::<Close>b__0()));
        }
        public FireworksContent()
        {
        
        }
    
    }

}
