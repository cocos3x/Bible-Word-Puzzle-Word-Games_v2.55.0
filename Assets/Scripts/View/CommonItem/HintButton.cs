using UnityEngine;

namespace View.CommonItem
{
    public class HintButton : MonoBehaviour
    {
        // Fields
        private View.CommonItem.HintButton.State state;
        public UnityEngine.Transform flyParticle;
        private UnityEngine.UI.Button button;
        private UnityEngine.UI.Image _imageCoin;
        private UnityEngine.UI.Text hintText;
        private UnityEngine.UI.Image shakeImage;
        private UnityEngine.UI.Image _imageDot;
        private UnityEngine.UI.Text _textDot;
        private bool isPlaying;
        private float <time>k__BackingField;
        
        // Properties
        public float time { get; set; }
        
        // Methods
        public float get_time()
        {
            return (float)this.<time>k__BackingField;
        }
        public void set_time(float value)
        {
            this.<time>k__BackingField = value;
        }
        private void Awake()
        {
            this.shakeImage = this.transform.Find(n:  "Light").GetComponent<UnityEngine.UI.Image>();
            this.button = this.GetComponent<UnityEngine.UI.Button>();
            this._imageCoin = this.transform.Find(n:  "ImageCoin").GetComponent<UnityEngine.UI.Image>();
            this.hintText = this.transform.Find(n:  "ImageCoin/Text").GetComponent<UnityEngine.UI.Text>();
            this._imageDot = this.transform.Find(n:  "ImageDot").GetComponent<UnityEngine.UI.Image>();
            this._textDot = this.transform.Find(n:  "ImageDot/TextDot").GetComponent<UnityEngine.UI.Text>();
            string val_17 = 120.ToString();
            this.button.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.CommonItem.HintButton::<Awake>b__14_0()));
        }
        private void HintClick()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "hint", value:  0);
            Message.Messager.Dispatch(cmd:  57);
        }
        private void SetHintFree(UnityEngine.Vector3 startPos, UnityEngine.Events.UnityAction callback)
        {
            object val_1 = new System.Object();
            typeof(HintButton.<>c__DisplayClass16_0).__il2cppRuntimeField_10 = this;
            typeof(HintButton.<>c__DisplayClass16_0).__il2cppRuntimeField_18 = callback;
            this.flyParticle.transform.position = new UnityEngine.Vector3() {x = startPos.x, y = startPos.y, z = startPos.z};
            this.flyParticle.gameObject.SetActive(value:  true);
            int val_4 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  0.05f);
            UnityEngine.Vector3 val_8 = this._textDot.transform.position;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.flyParticle, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.7f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void HintButton.<>c__DisplayClass16_0::<SetHintFree>b__0())));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  0.15f);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void HintButton.<>c__DisplayClass16_0::<SetHintFree>b__1()));
            DG.Tweening.Tweener val_20 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.hintText.transform, endValue:  2f, duration:  0.3f), ease:  5), loops:  2, loopType:  1), delay:  0.38f);
        }
        public void StopHintFree()
        {
            this.UpdateNormalAndState();
        }
        private void SetHintNum(int num)
        {
            this._imageCoin.gameObject.SetActive(value:  (num < 1) ? 1 : 0);
            this._imageDot.gameObject.SetActive(value:  (num > 0) ? 1 : 0);
            string val_5 = num.ToString();
        }
        private void UpdateHintCount()
        {
            this.SetHintNum(num:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus);
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  71, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.HintButton::UpdateHintCount()));
            Message.Messager.Add<UnityEngine.Vector3, UnityEngine.Events.UnityAction>(cmd:  73, action:  new System.Action<UnityEngine.Vector3, UnityEngine.Events.UnityAction>(object:  this, method:  System.Void View.CommonItem.HintButton::SetHintFree(UnityEngine.Vector3 startPos, UnityEngine.Events.UnityAction callback)));
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState == 3)
            {
                    this.<time>k__BackingField = UnityEngine.Time.realtimeSinceStartup;
                UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.DOHint());
            }
            
            this.ShowNormal();
            this.state = 0;
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.UpdateState(loopDelay:  1f));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  71, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.HintButton::UpdateHintCount()));
            Message.Messager.Remove<UnityEngine.Vector3, UnityEngine.Events.UnityAction>(cmd:  73, action:  new System.Action<UnityEngine.Vector3, UnityEngine.Events.UnityAction>(object:  this, method:  System.Void View.CommonItem.HintButton::SetHintFree(UnityEngine.Vector3 startPos, UnityEngine.Events.UnityAction callback)));
        }
        private System.Collections.IEnumerator DOHint()
        {
            typeof(HintButton.<DOHint>d__22).__il2cppRuntimeField_10 = 0;
            typeof(HintButton.<DOHint>d__22).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void Light()
        {
            if(this.isPlaying == true)
            {
                    return;
            }
            
            this.<time>k__BackingField = UnityEngine.Time.realtimeSinceStartup;
            this.isPlaying = true;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  45f);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  this.shakeImage.transform, duration:  1f, strength:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, vibrato:  30, randomness:  90f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.HintButton::<Light>b__23_0())), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.HintButton::<Light>b__23_1()));
        }
        private System.Collections.IEnumerator UpdateState(float loopDelay)
        {
            typeof(HintButton.<UpdateState>d__24).__il2cppRuntimeField_10 = 0;
            typeof(HintButton.<UpdateState>d__24).__il2cppRuntimeField_20 = this;
            typeof(HintButton.<UpdateState>d__24).__il2cppRuntimeField_28 = loopDelay;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void UpdateNormalAndState()
        {
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus) > 0)
            {
                    return;
            }
            
            if(this.state == 0)
            {
                    return;
            }
            
            this.ShowNormal();
            this.state = 0;
        }
        private void ShowNormal()
        {
            string val_1 = 120.ToString();
            this.SetHintNum(num:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus);
        }
        public HintButton()
        {
        
        }
        private void <Awake>b__14_0()
        {
            this.<time>k__BackingField = UnityEngine.Time.realtimeSinceStartup;
            this.HintClick();
        }
        private void <Light>b__23_0()
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  1f, g:  1f, b:  0f, a:  1f);
            this.shakeImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        private void <Light>b__23_1()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.shakeImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            this.isPlaying = false;
        }
    
    }

}
