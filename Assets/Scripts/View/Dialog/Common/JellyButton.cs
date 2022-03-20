using UnityEngine;

namespace View.Dialog.Common
{
    public class JellyButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        public UnityEngine.Events.UnityEvent onPointDownEvent;
        public UnityEngine.Events.UnityEvent onPointUpEvent;
        
        // Methods
        public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.1f);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.13f);
            if(this.onPointDownEvent == null)
            {
                    return;
            }
            
            this.onPointDownEvent.Invoke();
        }
        public virtual void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.9f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.05f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.95f);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  1.02f);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.1f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.09f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.08f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.07f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.06f)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Common.JellyButton::<OnPointerUp>b__3_0()));
        }
        public JellyButton()
        {
        
        }
        private void <OnPointerUp>b__3_0()
        {
            string val_2;
            if(this.onPointUpEvent == null)
            {
                    return;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_2 = "eff_btn_click";
            }
            else
            {
                    val_2 = "open";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_2, volumeScale:  1f, loop:  false, delay:  0f);
            this.onPointUpEvent.Invoke();
        }
    
    }

}
