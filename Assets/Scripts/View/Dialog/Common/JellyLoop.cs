using UnityEngine;

namespace View.Dialog.Common
{
    public class JellyLoop : MonoBehaviour
    {
        // Fields
        public float maxDurTime;
        public float diffDurTime;
        public bool isJellyOnStart;
        private DG.Tweening.Sequence sequence;
        
        // Methods
        private void Start()
        {
            if(this.isJellyOnStart == false)
            {
                    return;
            }
            
            this.StartJelly();
        }
        public void StartJelly()
        {
            this.StopJelly();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.sequence = val_1;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.8f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.05f);
            float val_28 = this.maxDurTime;
            val_28 = val_28 - this.diffDurTime;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.9f);
            float val_29 = this.diffDurTime;
            val_29 = val_29 + val_29;
            val_29 = this.maxDurTime - val_29;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  1.02f);
            float val_30 = this.diffDurTime;
            val_30 = val_30 * (-3f);
            val_30 = this.maxDurTime + val_30;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
            float val_31 = this.diffDurTime;
            val_31 = val_31 * (-4f);
            val_31 = this.maxDurTime + val_31;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  this.maxDurTime)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  val_28)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  val_29)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  val_30)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  val_31)), delay:  1.5f), loops:  0, loopType:  0);
        }
        public void StopJelly()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            if(this.sequence == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.sequence, complete:  false);
        }
        public JellyLoop()
        {
            this.isJellyOnStart = true;
            this.maxDurTime = 0.15f;
            this.diffDurTime = 0.03f;
        }
    
    }

}
