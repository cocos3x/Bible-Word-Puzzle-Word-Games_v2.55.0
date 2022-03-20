using UnityEngine;

namespace View.CommonItem
{
    public class LetterBlock : RecyclableItem
    {
        // Fields
        private bool _selected;
        public bool startAnimation;
        private View.CommonItem.Letter <letter>k__BackingField;
        private UnityEngine.Animator _animatorBlock;
        private const float TimeRotate = 0.06;
        private UnityEngine.RectTransform _rectTransform;
        private UnityEngine.RectTransform _rectBlock;
        private UnityEngine.Transform blockTransform;
        private UnityEngine.GameObject effect;
        private UnityEngine.Transform _slotDove;
        private UnityEngine.Vector3 originScale;
        private UnityEngine.Vector3 blockOriginAngle;
        private DG.Tweening.Tween tween;
        private DG.Tweening.Sequence _sequence;
        private UnityEngine.Transform _transformAni;
        private UnityEngine.Vector3 _rotateEulerAngles;
        private UnityEngine.Vector2 _moveDistance;
        
        // Properties
        public bool selected { get; set; }
        public UnityEngine.Vector3 localPosition { get; set; }
        public UnityEngine.Vector3 position { get; set; }
        public UnityEngine.Vector3 blockPosition { get; }
        public UnityEngine.Vector3 localScale { get; set; }
        public bool randomAngle { set; }
        public UnityEngine.RectTransform rectTransform { get; }
        public View.CommonItem.Letter letter { get; set; }
        
        // Methods
        public static View.CommonItem.LetterBlock Create(UnityEngine.Transform parent, View.CommonItem.LetterBlock prefab, char letter, bool randomAngle = True)
        {
            View.CommonItem.LetterBlock val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.LetterBlock>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name + "_" + letter.ToString();
            val_1.<letter>k__BackingField.letter = letter;
            if(randomAngle == false)
            {
                    return val_1;
            }
            
            val_1.RandomAngle();
            return val_1;
        }
        public bool get_selected()
        {
            return (bool)this._selected;
        }
        public void set_selected(bool value)
        {
            this._selected = value;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originScale, y = V8.16B, z = V10.16B}, d:  (value != true) ? 1.03f : 1f);
            this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public UnityEngine.Vector3 get_localPosition()
        {
            return this.transform.localPosition;
        }
        public void set_localPosition(UnityEngine.Vector3 value)
        {
            this.transform.localPosition = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
        public UnityEngine.Vector3 get_position()
        {
            return this.transform.position;
        }
        public void set_position(UnityEngine.Vector3 value)
        {
            this.transform.position = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
        public UnityEngine.Vector3 get_blockPosition()
        {
            if(this.blockTransform != null)
            {
                    return this.blockTransform.position;
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 get_localScale()
        {
            return this.transform.localScale;
        }
        public void set_localScale(UnityEngine.Vector3 value)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
            this.originScale = value;
            mem[1152921512870823964] = value.y;
            mem[1152921512870823968] = value.z;
        }
        public void set_randomAngle(bool value)
        {
            if(value == false)
            {
                    return;
            }
            
            this.RandomAngle();
        }
        public UnityEngine.RectTransform get_rectTransform()
        {
            return (UnityEngine.RectTransform)this._rectTransform;
        }
        public View.CommonItem.Letter get_letter()
        {
            return (View.CommonItem.Letter)this.<letter>k__BackingField;
        }
        public void set_letter(View.CommonItem.Letter value)
        {
            this.<letter>k__BackingField = value;
        }
        private void Awake()
        {
            UnityEngine.RectTransform val_18;
            UnityEngine.RectTransform val_19;
            this._animatorBlock = this.transform.Find(n:  "Block").GetComponent<UnityEngine.Animator>();
            this.blockTransform = this.transform.Find(n:  "Block");
            this.effect = this.transform.Find(n:  "eff_letters_disappear").gameObject;
            this._slotDove = this.transform.Find(n:  "Block/SlotDove");
            this.<letter>k__BackingField = this.GetComponentInChildren<View.CommonItem.Letter>();
            UnityEngine.Transform val_12 = this.transform;
            if(val_12 != null)
            {
                    var val_13 = (null == null) ? (val_12) : 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            this._rectTransform = val_18;
            UnityEngine.Transform val_15 = this.transform.Find(n:  "Block");
            if(val_15 != null)
            {
                    var val_16 = (null == null) ? (val_15) : 0;
            }
            else
            {
                    val_19 = 0;
            }
            
            this._rectBlock = val_19;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
            this.originScale = val_17;
            mem[1152921512871471292] = val_17.y;
            mem[1152921512871471296] = val_17.z;
        }
        public void RandomAngle()
        {
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  (float)UnityEngine.Random.Range(min:  9, max:  10));
            this.blockOriginAngle = val_2.x;
            mem[1152921512871644748] = val_2.z;
            this.transform.localEulerAngles = new UnityEngine.Vector3() {x = this.blockOriginAngle, y = 0f, z = (float)UnityEngine.Random.Range(min:  9, max:  10)};
        }
        public UnityEngine.Vector3 GetBlockOriginAngle()
        {
            return new UnityEngine.Vector3() {x = this.blockOriginAngle};
        }
        private void TweenKill()
        {
            if(this.tween != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tween, complete:  false);
            }
            
            this.transform.localEulerAngles = new UnityEngine.Vector3() {x = this.blockOriginAngle};
            this.transform.localScale = new UnityEngine.Vector3() {x = this.originScale};
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this._rectBlock.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            if(this._sequence == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this._sequence, complete:  false);
        }
        private void OnlyTweenKill()
        {
            if(this.tween != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tween, complete:  false);
            }
            
            if(this._sequence == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this._sequence, complete:  false);
        }
        public void Shake()
        {
            this.TweenKill();
            this._animatorBlock.Play(stateName:  "word_fail_letters", layer:  0, normalizedTime:  0f);
        }
        public void DoJelly()
        {
            this.TweenKill();
            this._animatorBlock.Play(stateName:  "word_suc_letters", layer:  0, normalizedTime:  0f);
        }
        public void DoScaleBig()
        {
            this.TweenKill();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  1.1f, a:  new UnityEngine.Vector3() {x = this.originScale, y = V9.16B, z = V8.16B});
            this.tween = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  28);
        }
        public void DoScaleNormal()
        {
            this.OnlyTweenKill();
            this.tween = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.originScale}, duration:  0.2f), ease:  28);
        }
        public void SetScaleToZero()
        {
            this.effect.gameObject.SetActive(value:  false);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public void DoShowEffect(float time, float delay)
        {
            if(this._sequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this._sequence, complete:  false);
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this._sequence = val_1;
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  delay);
            float val_16 = 0.6f;
            val_16 = time * val_16;
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.originScale, y = delay}, duration:  val_16));
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.15f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.originScale, y = V10.16B, z = delay}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  time * 0.2f));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.originScale, y = val_9.y, z = val_9.z}, duration:  0.2f));
        }
        public void DestroyEffect(float time, bool isGameComplete = False, float delay = 0)
        {
            var val_15;
            DG.Tweening.TweenCallback val_17;
            typeof(LetterBlock.<>c__DisplayClass50_0).__il2cppRuntimeField_10 = isGameComplete;
            typeof(LetterBlock.<>c__DisplayClass50_0).__il2cppRuntimeField_18 = this;
            if(this._sequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this._sequence, complete:  false);
            }
            
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            this._sequence = val_3;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  delay);
            val_15 = null;
            val_15 = null;
            val_17 = LetterBlock.<>c.<>9__50_0;
            if(val_17 == null)
            {
                    DG.Tweening.TweenCallback val_5 = null;
                val_17 = val_5;
                val_5 = new DG.Tweening.TweenCallback(object:  LetterBlock.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LetterBlock.<>c::<DestroyEffect>b__50_0());
                LetterBlock.<>c.<>9__50_0 = val_17;
            }
            
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  val_17);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  time), ease:  26));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void LetterBlock.<>c__DisplayClass50_0::<DestroyEffect>b__1()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  this._sequence, id:  this);
        }
        public void DestroyRotate()
        {
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  360f);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f, mode:  1);
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.effect.gameObject.SetActive(value:  false);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.localScale = new UnityEngine.Vector3() {x = this.originScale, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.blockTransform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.selected = false;
        }
        public UnityEngine.Transform GetSlotDove()
        {
            return (UnityEngine.Transform)this._slotDove;
        }
        public LetterBlock()
        {
            UnityEngine.Vector3 val_1;
            this.startAnimation = true;
            val_1 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  -6f);
            this._rotateEulerAngles = val_1.x;
            mem[1152921512873661520] = val_1.z;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  20f);
            this._moveDistance = val_3;
            mem[1152921512873661528] = val_3.y;
        }
    
    }

}
