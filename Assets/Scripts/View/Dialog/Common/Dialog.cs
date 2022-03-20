using UnityEngine;

namespace View.Dialog.Common
{
    public class Dialog : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
    {
        // Fields
        public System.Action onDialogClosed;
        public System.Action onDialogCancel;
        public bool destoryOnCancel;
        public bool cancelByBack;
        public bool cancelByClickBlank;
        public bool playSound;
        public bool doAnimation;
        public float openScaleAnimTime;
        public float openFadeAnimTime;
        public float closeScaleAnimTime;
        public float closeFadeAnimTime;
        protected Logic.Define.DialogType dialogType;
        protected UnityEngine.Transform contentTransform;
        protected UnityEngine.UI.Image bgImage;
        
        // Methods
        protected virtual void Awake()
        {
            this.bgImage = this.GetComponent<UnityEngine.UI.Image>();
            UnityEngine.Transform val_3 = this.transform.Find(n:  "Content");
            this.contentTransform = val_3;
            if(val_3 == 0)
            {
                    this.contentTransform = this.transform.Find(n:  "FitPanel/Content");
            }
            
            this.transform.SetAsLastSibling();
            goto typeof(View.Dialog.Common.Dialog).__il2cppRuntimeField_190;
        }
        protected virtual void LocaleTranslate()
        {
        
        }
        protected virtual void OnEnable()
        {
            string val_14;
            if(this.playSound != false)
            {
                    if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_14 = "eff_btn_click";
            }
            else
            {
                    val_14 = "open";
            }
            
                Logic.Game.GameManager.gameSound.Play(clipName:  val_14, volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            if(this.doAnimation == false)
            {
                    return;
            }
            
            if(this.contentTransform == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.contentTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  0f, g:  0f, b:  0f, a:  0.7f);
            this.bgImage.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bgImage, endValue:  0f, duration:  this.openFadeAnimTime))), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.contentTransform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  this.openScaleAnimTime)), ease:  27));
        }
        public virtual bool IsOpened()
        {
            if(this == 0)
            {
                    return false;
            }
            
            if(this.gameObject != 0)
            {
                    return this.gameObject.activeSelf;
            }
            
            return false;
        }
        public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.cancelByClickBlank == false)
            {
                    return;
            }
            
            if((eventData.<pointerEnter>k__BackingField) != this.gameObject)
            {
                    return;
            }
            
            this = ???;
            goto typeof(View.Dialog.Common.Dialog).__il2cppRuntimeField_1E0;
        }
        public virtual View.Dialog.Common.Dialog Open()
        {
            if((this & 1) != 0)
            {
                    return (View.Dialog.Common.Dialog)this;
            }
            
            this.gameObject.SetActive(value:  true);
            return (View.Dialog.Common.Dialog)this;
        }
        public View.Dialog.Common.Dialog OnClose(System.Action action)
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  this.onDialogClosed, b:  action);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            this.onDialogClosed = val_1;
            return (View.Dialog.Common.Dialog)this;
            label_2:
        }
        public View.Dialog.Common.Dialog OnCancel(System.Action action)
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  this.onDialogCancel, b:  action);
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            this.onDialogCancel = val_1;
            return (View.Dialog.Common.Dialog)this;
            label_2:
        }
        public virtual void Close()
        {
            var val_4;
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this.onDialogClosed != null)
            {
                    val_4 = 0;
                this.onDialogClosed.Invoke();
            }
            
            this.onDialogClosed = 0;
            goto typeof(View.Dialog.Common.Dialog).__il2cppRuntimeField_1F0;
        }
        public virtual void Cancel()
        {
            string val_4;
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this.playSound != false)
            {
                    if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_4 = "eff_popup_close";
            }
            else
            {
                    val_4 = "close";
            }
            
                Logic.Game.GameManager.gameSound.Play(clipName:  val_4, volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            if(this.doAnimation != false)
            {
                    if(this.contentTransform != 0)
            {
                    this.DoContentAnimation(onComplete:  new System.Action(object:  this, method:  System.Void View.Dialog.Common.Dialog::DealCancel()));
                return;
            }
            
            }
            
            this.DealCancel();
        }
        public Logic.Define.DialogType GetDialogType()
        {
            return (Logic.Define.DialogType)this.dialogType;
        }
        public void SetDialogType(Logic.Define.DialogType type)
        {
            this.dialogType = type;
            if(type == 1)
            {
                    return;
            }
            
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingPause();
        }
        public virtual void OnTransmitParams(object[] pars)
        {
        
        }
        protected void DoContentAnimation(System.Action onComplete)
        {
            typeof(Dialog.<>c__DisplayClass27_0).__il2cppRuntimeField_10 = onComplete;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bgImage, endValue:  0f, duration:  this.closeFadeAnimTime)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.contentTransform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  this.closeScaleAnimTime), ease:  26)), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void Dialog.<>c__DisplayClass27_0::<DoContentAnimation>b__0()));
        }
        private void DealCancel()
        {
            Logic.Define.DialogType val_5 = this.dialogType;
            val_5 = val_5 - 1;
            if(val_5 >= 2)
            {
                    Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStart();
            }
            
            if(this.onDialogCancel != null)
            {
                    this.onDialogCancel.Invoke();
            }
            
            this.onDialogCancel = 0;
            if(this.destoryOnCancel != false)
            {
                    bool val_2 = Logic.Game.GameManager.gameDialog.DestroyDialog(dialog:  this);
                UnityEngine.Object.Destroy(obj:  this.gameObject);
                return;
            }
            
            Logic.Game.GameManager.gameDialog.DisPlayDialog(dialog:  this);
            this.gameObject.SetActive(value:  false);
        }
        private void OnDestroy()
        {
            bool val_1 = Logic.Game.GameManager.gameDialog.DestroyDialog(dialog:  this);
            this.onDialogClosed = 0;
            this.onDialogCancel = 0;
        }
        public Dialog()
        {
            this.destoryOnCancel = true;
            this.cancelByBack = true;
            this.playSound = true;
            this.openScaleAnimTime = ;
            this.openFadeAnimTime = ;
            this.closeScaleAnimTime = 0.15f;
            this.closeFadeAnimTime = 0.3f;
        }
    
    }

}
