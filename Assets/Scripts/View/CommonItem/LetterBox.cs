using UnityEngine;

namespace View.CommonItem
{
    public class LetterBox : RecyclableItem
    {
        // Fields
        public UnityEngine.Sprite[] BoxSprites;
        public UnityEngine.UI.Image ImageBg;
        public UnityEngine.UI.Image ImageBox;
        public UnityEngine.Transform SlotDove;
        public UnityEngine.Animator AnimatorBlock;
        public View.CommonItem.LetterGift Gift;
        public View.CommonItem.Chrysalis ChrysalisBox;
        public float bonusTime;
        public float time;
        public float scale;
        public View.CommonEffect.HintEffect hintEffectPrefab;
        private bool _isBonus;
        private bool _isStar;
        private bool <isDoveFlyLock>k__BackingField;
        private bool <isShow>k__BackingField;
        private bool <IsShowGift>k__BackingField;
        private bool <IsShowChrysalis>k__BackingField;
        private View.CommonItem.Letter <letter>k__BackingField;
        private View.CommonItem.Letter letter_2;
        private UnityEngine.Transform contentTransform;
        private UnityEngine.Transform blockTransform;
        private UnityEngine.Transform crossTransform;
        private UnityEngine.RectTransform rectTransform;
        private bool aleadyPlayShow;
        private DG.Tweening.Tween shakeTween;
        private UnityEngine.GameObject _effectShowAnswer;
        
        // Properties
        public bool isBonus { get; set; }
        public UnityEngine.Vector3 localScale { get; set; }
        public UnityEngine.Vector3 anchoredPosition { get; set; }
        public bool isDoveFlyLock { get; set; }
        public bool isShow { get; set; }
        public bool IsShowGift { get; set; }
        public bool IsShowChrysalis { get; set; }
        public UnityEngine.Vector3 contentPosition { get; }
        public View.CommonItem.Letter letter { get; set; }
        
        // Methods
        public static View.CommonItem.LetterBox Create(UnityEngine.Transform parent, View.CommonItem.LetterBox letterBoxPrefab, char letter)
        {
            View.CommonItem.LetterBox val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.LetterBox>(prefab:  letterBoxPrefab, bufferSize:  10);
            val_1.name = letterBoxPrefab.name + "_" + letter.ToString();
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.<letter>k__BackingField.letter = letter;
            val_1.letter_2.letter = letter;
            return val_1;
        }
        public View.CommonItem.LetterBox SetLetterSprite(char _letter)
        {
            this.<letter>k__BackingField.letter = _letter;
            this.letter_2.letter = _letter;
            return (View.CommonItem.LetterBox)this;
        }
        public bool get_isBonus()
        {
            return (bool)this._isBonus;
        }
        public void set_isBonus(bool value)
        {
            var val_4;
            this._isBonus = value;
            UnityEngine.GameObject val_2 = this.crossTransform.gameObject;
            if(value == false)
            {
                goto label_1;
            }
            
            var val_3 = ((this.<isShow>k__BackingField) == false) ? 1 : 0;
            if(val_2 != null)
            {
                goto label_2;
            }
            
            label_1:
            val_4 = 0;
            label_2:
            val_2.SetActive(value:  false);
        }
        public UnityEngine.Vector3 get_localScale()
        {
            return this.transform.lossyScale;
        }
        public void set_localScale(UnityEngine.Vector3 value)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
        public UnityEngine.Vector3 get_anchoredPosition()
        {
            UnityEngine.Vector2 val_1 = this.rectTransform.anchoredPosition;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public void set_anchoredPosition(UnityEngine.Vector3 value)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
            this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public bool get_isDoveFlyLock()
        {
            return (bool)this.<isDoveFlyLock>k__BackingField;
        }
        public void set_isDoveFlyLock(bool value)
        {
            this.<isDoveFlyLock>k__BackingField = value;
        }
        public bool get_isShow()
        {
            return (bool)this.<isShow>k__BackingField;
        }
        public void set_isShow(bool value)
        {
            this.<isShow>k__BackingField = value;
        }
        public bool get_IsShowGift()
        {
            return (bool)this.<IsShowGift>k__BackingField;
        }
        public void set_IsShowGift(bool value)
        {
            this.<IsShowGift>k__BackingField = value;
        }
        public bool get_IsShowChrysalis()
        {
            return (bool)this.<IsShowChrysalis>k__BackingField;
        }
        public void set_IsShowChrysalis(bool value)
        {
            this.<IsShowChrysalis>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_contentPosition()
        {
            if(this.contentTransform != null)
            {
                    return this.contentTransform.position;
            }
            
            throw new NullReferenceException();
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
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            this.rectTransform = val_1;
            this.contentTransform = this.transform.Find(n:  "Content");
            this.blockTransform = this.transform.Find(n:  "Content/Block");
            this.crossTransform = this.transform.Find(n:  "Content/Cross");
            this._effectShowAnswer = this.transform.Find(n:  "Content/Block/eff_letters_fill").gameObject;
            this.<letter>k__BackingField = this.transform.Find(n:  "Content/Block/Letter").GetComponent<View.CommonItem.Letter>();
            this.letter_2 = this.transform.Find(n:  "Content/Block/ImageFrame/ImageThickness/Letter").GetComponent<View.CommonItem.Letter>();
            return;
            label_2:
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  68, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.LetterBox::GiftBoxDeathCallback()));
            this.ChangeToGuideBox(isGuide:  false);
            this._effectShowAnswer.gameObject.SetActive(value:  false);
            this.HideGiftBox(isPlay:  false);
            this.HideChrysalisBox();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  68, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.LetterBox::GiftBoxDeathCallback()));
        }
        private void HideGiftBox(bool isPlay = False)
        {
            var val_21;
            var val_22;
            int val_23;
            int val_24;
            this.<IsShowGift>k__BackingField = false;
            if(isPlay == false)
            {
                goto label_2;
            }
            
            this.Gift.PlayHideGiftAni();
            val_22 = 1152921512608631808;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                goto label_4;
            }
            
            val_21 = 1152921508081656432;
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_2 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            val_2.<IsHaveLetterGiftFromGame>k__BackingField = false;
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_3 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            Data.UserPlayer.UserPlayerDataManager val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_7 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            if((System.String.op_Equality(a:  val_3.<IsAppearedLetterGiftFromGame>k__BackingField, b:  Logic.Game.GameManager.gameBible.GetBibleProgress(sectionIndex:  val_4.<CurrentSectionIndex>k__BackingField))) == false)
            {
                goto label_10;
            }
            
            val_23 = (val_7.<IsAppearedLetterGiftFromGameCount>k__BackingField) + 1;
            goto label_11;
            label_2:
            this.Gift.gameObject.SetActive(value:  false);
            return;
            label_4:
            View.Controller.MainController val_9 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_9._bibleGameState != 4)
            {
                goto label_24;
            }
            
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_10 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            val_10.<IsHaveLetterGiftFromDaily>k__BackingField = false;
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_11 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            val_21 = 1152921512608795232;
            Data.DailyRecord.DailyRecordDataManager val_12 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_14 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            if((System.String.op_Equality(a:  val_11.<IsAppearedLetterGiftFromDaily>k__BackingField, b:  val_12.<DailyLevel>k__BackingField)) == false)
            {
                goto label_19;
            }
            
            val_24 = (val_14.<IsAppearedLetterGiftFromDailyCount>k__BackingField) + 1;
            goto label_20;
            label_10:
            val_23 = 1;
            label_11:
            val_7.<IsAppearedLetterGiftFromGameCount>k__BackingField = val_23;
            val_22 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            Data.UserPlayer.UserPlayerDataManager val_16 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            val_15.<IsAppearedLetterGiftFromGame>k__BackingField = Logic.Game.GameManager.gameBible.GetBibleProgress(sectionIndex:  val_16.<CurrentSectionIndex>k__BackingField);
            goto label_24;
            label_19:
            val_24 = 1;
            label_20:
            val_14.<IsAppearedLetterGiftFromDailyCount>k__BackingField = val_24;
            val_22 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            Data.DailyRecord.DailyRecordDataManager val_19 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_18.<IsAppearedLetterGiftFromDaily>k__BackingField = val_19.<DailyLevel>k__BackingField;
            label_24:
            Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance.IsGiftBoxCooling = true;
        }
        public void ShowGiftBox()
        {
            if(this.crossTransform.gameObject.activeSelf != false)
            {
                    this.crossTransform.gameObject.SetActive(value:  false);
            }
            
            View.Controller.MainController val_4 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_4._bibleGameState == 3)
            {
                    View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_5 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
                val_5.<IsHaveLetterGiftFromGame>k__BackingField = true;
            }
            else
            {
                    View.Controller.MainController val_6 = Common.SingletonController<View.Controller.MainController>.Instance;
                if(val_6._bibleGameState == 4)
            {
                    View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_7 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
                val_7.<IsHaveLetterGiftFromDaily>k__BackingField = true;
            }
            
            }
            
            this.<IsShowGift>k__BackingField = true;
            this.Gift.gameObject.SetActive(value:  true);
            this.Gift.PlayShowGiftAni();
        }
        private void GiftBoxDeathCallback()
        {
            this.Gift.gameObject.SetActive(value:  false);
        }
        public void ShowChrysalisBox()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                    return;
            }
            
            this.<IsShowChrysalis>k__BackingField = true;
            this.ChrysalisBox.gameObject.SetActive(value:  true);
            this.ChrysalisBox.SetChrysalisInfo();
        }
        private void HideChrysalisBox()
        {
            this.<IsShowChrysalis>k__BackingField = false;
            this.ChrysalisBox.gameObject.SetActive(value:  false);
        }
        public void PlayHint(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, float time, float delay)
        {
            View.CommonEffect.HintEffect.Create(parent:  this.transform, prefab:  this.hintEffectPrefab).Play(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = endPosition.x, y = endPosition.y, z = endPosition.z}, time:  time, delay:  delay, onComplete:  new System.Action(object:  this, method:  System.Void View.CommonItem.LetterBox::<PlayHint>b__62_0()));
        }
        public void PlayHint()
        {
            goto typeof(View.CommonItem.LetterBox).__il2cppRuntimeField_1D0;
        }
        public void PlayFreeHint()
        {
            goto typeof(View.CommonItem.LetterBox).__il2cppRuntimeField_1D0;
        }
        public void Shake()
        {
            if(this.shakeTween != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.shakeTween, complete:  false);
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.blockTransform.localEulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  40f);
            this.shakeTween = DG.Tweening.DOTween.Shake(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  this, method:  UnityEngine.Vector3 View.CommonItem.LetterBox::<Shake>b__65_0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  this, method:  System.Void View.CommonItem.LetterBox::<Shake>b__65_1(UnityEngine.Vector3 v)), duration:  0.5f, strength:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, vibrato:  30, randomness:  90f);
        }
        public virtual void PlayShow()
        {
            DG.Tweening.TweenCallback val_16;
            var val_17;
            IntPtr val_18;
            object val_1 = new System.Object();
            typeof(LetterBox.<>c__DisplayClass66_0).__il2cppRuntimeField_10 = this;
            if(this.aleadyPlayShow != false)
            {
                    return;
            }
            
            this.aleadyPlayShow = true;
            typeof(LetterBox.<>c__DisplayClass66_0).__il2cppRuntimeField_18 = 0;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            if((this.<IsShowGift>k__BackingField) != false)
            {
                    DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LetterBox.<>c__DisplayClass66_0::<PlayShow>b__0()));
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.8f);
                val_16 = null;
                val_17 = System.Void LetterBox.<>c__DisplayClass66_0::<PlayShow>b__1();
            }
            else
            {
                    val_16 = null;
                if((this.<IsShowChrysalis>k__BackingField) != false)
            {
                    val_18 = 1152921512878572624;
            }
            else
            {
                    val_18 = 1152921512878573648;
            }
            
            }
            
            val_16 = new DG.Tweening.TweenCallback(object:  val_1, method:  val_18);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  val_16);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            float val_16 = this.scale;
            val_16 = val_16 + 1f;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  val_16);
            float val_18 = this.time;
            float val_17 = this.scale;
            val_17 = val_17 + val_17;
            val_18 = (val_17 + 1f) * val_18;
            val_17 = val_17 + 1f;
            val_17 = val_18 / val_17;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.blockTransform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  val_17));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            float val_19 = this.time;
            float val_20 = this.scale;
            val_19 = val_20 * val_19;
            val_20 = val_20 + val_20;
            val_20 = val_20 + 1f;
            val_19 = val_19 / val_20;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.blockTransform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  val_19));
        }
        public void PlayShow(float delay, UnityEngine.Vector3 from, System.Action onComplete, bool useSound = False)
        {
            object val_1 = new System.Object();
            typeof(LetterBox.<>c__DisplayClass67_0).__il2cppRuntimeField_10 = this;
            typeof(LetterBox.<>c__DisplayClass67_0).__il2cppRuntimeField_18 = useSound;
            typeof(LetterBox.<>c__DisplayClass67_0).__il2cppRuntimeField_20 = onComplete;
            if(this.aleadyPlayShow != false)
            {
                    return;
            }
            
            this.aleadyPlayShow = true;
            if(this._isBonus != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.crossTransform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  this.bonusTime);
            }
            
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            if((this.<IsShowGift>k__BackingField) != false)
            {
                    DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LetterBox.<>c__DisplayClass67_0::<PlayShow>b__0()));
                DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  0.8f);
            }
            else
            {
                    if((this.<IsShowChrysalis>k__BackingField) != false)
            {
                    DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LetterBox.<>c__DisplayClass67_0::<PlayShow>b__1()));
            }
            
            }
            
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  delay);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LetterBox.<>c__DisplayClass67_0::<PlayShow>b__2()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  0.25f);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LetterBox.<>c__DisplayClass67_0::<PlayShow>b__3()));
        }
        public void ChangeToGuideBox(bool isGuide)
        {
            if(this.BoxSprites.Length < 2)
            {
                goto label_1;
            }
            
            var val_1 = (isGuide != true) ? 40 : 32;
            this.ImageBg.sprite = null;
            if(isGuide == false)
            {
                goto label_4;
            }
            
            if(this.ImageBox != null)
            {
                goto label_6;
            }
            
            label_4:
            label_6:
            this.ImageBox.sprite = null;
            label_1:
            if(isGuide != false)
            {
                    return;
            }
            
            this.DeleteCanvas();
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.isBonus = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            this.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.aleadyPlayShow = false;
            this.<isDoveFlyLock>k__BackingField = false;
            this.<isShow>k__BackingField = false;
            this.blockTransform.gameObject.SetActive(value:  false);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.crossTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.Gift.gameObject.SetActive(value:  false);
            this.DeleteCanvas();
        }
        private void DeleteCanvas()
        {
            if((this.gameObject.GetComponent<UnityEngine.Canvas>()) == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject.GetComponent<UnityEngine.Canvas>());
        }
        public UnityEngine.Transform GetSlotDove()
        {
            return (UnityEngine.Transform)this.SlotDove;
        }
        public LetterBox()
        {
            this.bonusTime = 0.3f;
            this.time = 0.2f;
            this.scale = 0.05f;
        }
        private void <PlayHint>b__62_0()
        {
            goto typeof(View.CommonItem.LetterBox).__il2cppRuntimeField_1D0;
        }
        private UnityEngine.Vector3 <Shake>b__65_0()
        {
            if(this.blockTransform != null)
            {
                    return this.blockTransform.localEulerAngles;
            }
            
            throw new NullReferenceException();
        }
        private void <Shake>b__65_1(UnityEngine.Vector3 v)
        {
            if(this.blockTransform != null)
            {
                    this.blockTransform.localEulerAngles = new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
