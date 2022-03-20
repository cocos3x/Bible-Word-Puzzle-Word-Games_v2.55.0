using UnityEngine;

namespace View.CommonItem
{
    public class Fireworks : MonoBehaviour
    {
        // Fields
        private const float TimeFly = 0.75;
        private UnityEngine.GameObject effect;
        private UnityEngine.Animator flyLine;
        private UnityEngine.Transform fireWorkTransform;
        private View.CommonEffect.FireworkEffect fireworkEffect;
        private View.CommonEffect.FireworkFlyEffect fireworkFlyEffect;
        private UnityEngine.Transform fireworkParent;
        private UnityEngine.Transform startTransform;
        private UnityEngine.Transform endTransform;
        private float flyTime;
        private float interval;
        private float lineFlyTime;
        private bool _isPlay;
        
        // Methods
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  102, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.Fireworks::RunFirework()));
            Message.Messager.Add<System.Collections.Generic.List<View.CommonItem.LetterBox>>(cmd:  101, action:  new System.Action<System.Collections.Generic.List<View.CommonItem.LetterBox>>(object:  this, method:  System.Void View.CommonItem.Fireworks::LetterFly(System.Collections.Generic.List<View.CommonItem.LetterBox> letterBoxes)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Collections.Generic.List<View.CommonItem.LetterBox>>(cmd:  101, action:  new System.Action<System.Collections.Generic.List<View.CommonItem.LetterBox>>(object:  this, method:  System.Void View.CommonItem.Fireworks::LetterFly(System.Collections.Generic.List<View.CommonItem.LetterBox> letterBoxes)));
            Message.Messager.Remove(cmd:  102, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.Fireworks::RunFirework()));
        }
        private void RunFirework()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "fireworks", action:  "action", label:  "success", value:  0);
            this.StopAllCoroutines();
            UnityEngine.Vector3 val_1 = this.startTransform.position;
            this.fireWorkTransform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_3 = this.endTransform.position;
            this.effect.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.PlayFlyAnim());
        }
        private System.Collections.IEnumerator PlayFlyAnim()
        {
            typeof(Fireworks.<PlayFlyAnim>d__16).__il2cppRuntimeField_10 = 0;
            typeof(Fireworks.<PlayFlyAnim>d__16).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void LetterFly(System.Collections.Generic.List<View.CommonItem.LetterBox> letterBoxes)
        {
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_11;
            var val_12;
            float val_13;
            val_11 = letterBoxes;
            typeof(Fireworks.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = val_11;
            typeof(Fireworks.<>c__DisplayClass17_0).__il2cppRuntimeField_18 = this;
            var val_11 = 0;
            val_12 = 2;
            do
            {
                if(val_11 >= 1152921504812277760)
            {
                    return;
            }
            
                object val_2 = new System.Object();
                typeof(Fireworks.<>c__DisplayClass17_1).__il2cppRuntimeField_18 = new System.Object();
                typeof(Fireworks.<>c__DisplayClass17_1).__il2cppRuntimeField_10 = val_11;
                UnityEngine.Vector3 val_4 = this.endTransform.position;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_10 = letterBoxes + 16;
                val_10 = val_10 + 0;
                UnityEngine.Vector3 val_6 = (letterBoxes + 16 + 0) + 32 + 48.transform.position;
                if(val_11 != 0)
            {
                    System.Action val_7 = new System.Action(object:  val_2, method:  System.Void Fireworks.<>c__DisplayClass17_1::<LetterFly>b__1());
                val_13 = this.interval * 2f;
            }
            else
            {
                    System.Action val_8 = new System.Action(object:  val_2, method:  System.Void Fireworks.<>c__DisplayClass17_1::<LetterFly>b__0());
                val_13 = this.interval + this.interval;
            }
            
                View.CommonEffect.FireworkFlyEffect.Create(parent:  this.fireworkParent, prefab:  this.fireworkFlyEffect).Play(startPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, endPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, time:  this.flyTime + val_13, delay:  0f, onComplete:  null);
                val_11 = typeof(Fireworks.<>c__DisplayClass17_0).__il2cppRuntimeField_10;
                val_11 = val_11 + 1;
                val_12 = val_12 - 1;
            }
            while(val_11 != 0);
            
            throw new NullReferenceException();
        }
        public Fireworks()
        {
            this.flyTime = 0.8f;
            this.interval = 0.1f;
            this.lineFlyTime = 0.6f;
        }
    
    }

}
