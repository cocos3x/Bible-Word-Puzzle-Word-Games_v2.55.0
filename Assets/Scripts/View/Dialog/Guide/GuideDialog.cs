using UnityEngine;

namespace View.Dialog.Guide
{
    public class GuideDialog : Dialog
    {
        // Fields
        private const string ContentFormat = "\n\"<color=#417A18><size=72>{0}</size></color>\"";
        private const string CheckContentFormat = "\n\"<color=#417A18><size=72>{0}</size></color>\"";
        public UnityEngine.Transform MaskContent;
        public UnityEngine.RectTransform RectContent;
        public View.CommonItem.GuideMask GuideMaskPrefab;
        public UnityEngine.UI.Text contextText;
        private System.Collections.Generic.List<string> <words>k__BackingField;
        private int stepIndex;
        
        // Properties
        public System.Collections.Generic.List<string> words { get; set; }
        
        // Methods
        public System.Collections.Generic.List<string> get_words()
        {
            return (System.Collections.Generic.List<System.String>)this.<words>k__BackingField;
        }
        public void set_words(System.Collections.Generic.List<string> value)
        {
            this.<words>k__BackingField = value;
        }
        protected override void Awake()
        {
            System.Collections.Generic.List<System.String> val_17;
            UnityEngine.RectTransform val_18;
            var val_19;
            this.Awake();
            Platform.Analytics.EzAnalytics.LogEvent(category:  "user_guide", action:  "a0_game_page_show", label:  "", value:  0);
            Message.Messager.Dispatch<System.Boolean>(cmd:  36, t:  true);
            View.Game.GameController val_1 = View.Game.GameController.GetInstance();
            this.<words>k__BackingField = val_1.wordContent.GetGuideWords();
            if((public static System.Void Message.Messager::Dispatch<System.Boolean>(Message.MessageCmd cmd, System.Boolean t)) == 0)
            {
                goto label_6;
            }
            
            if("17" == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_5 = Locale.LocaleManager.Translate(key:  "17")(Locale.LocaleManager.Translate(key:  "17")) + System.String.Format(format:  "\n\"<color=#417A18><size=72>{0}</size></color>\"", arg0:  null)(System.String.Format(format:  "\n\"<color=#417A18><size=72>{0}</size></color>\"", arg0:  null));
            View.Game.GameController val_6 = View.Game.GameController.GetInstance();
            val_17 = this.<words>k__BackingField;
            if(null == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.CreateGuideMask(word:  val_6.wordContent.ChangeToGuideCanvas(word:  UnityEngine.UI.Text.__il2cppRuntimeField_byval_arg));
            val_18 = this.RectContent;
            val_19 = null;
            if(1152921504686878720 >= 2)
            {
                goto label_15;
            }
            
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.up;
            goto label_18;
            label_6:
            val_19 = this;
            val_18 = ???;
            val_17 = ???;
            goto typeof(View.Dialog.Guide.GuideDialog).__il2cppRuntimeField_1F0;
            label_15:
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.up;
            label_18:
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, d:  200f);
            val_18.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        }
        private void OnDisable()
        {
            Message.Messager.Dispatch<System.Boolean>(cmd:  36, t:  false);
        }
        public View.Game.CheckAnswerType CheckAnswer(string word)
        {
            System.Collections.Generic.List<System.String> val_21;
            int val_22;
            int val_23;
            string val_24;
            var val_25;
            val_21 = this.<words>k__BackingField;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Equality(a:  word, b:  0)) == false)
            {
                goto label_3;
            }
            
            object[] val_2 = new object[5];
            val_21 = val_2;
            val_21[0] = "a";
            val_22 = val_2.Length;
            val_21[1] = this.stepIndex;
            val_22 = val_2.Length;
            val_21[2] = "_step";
            val_23 = val_2.Length;
            val_21[3] = this.stepIndex;
            val_23 = val_2.Length;
            val_21[4] = "_pass";
            Platform.Analytics.EzAnalytics.LogEvent(category:  "user_guide", action:  +val_2, label:  "", value:  0);
            int val_21 = this.stepIndex;
            val_21 = val_21 + 1;
            this.stepIndex = val_21;
            View.Game.GameController val_4 = View.Game.GameController.GetInstance();
            View.Game.CheckAnswerType val_5 = val_4.wordContent.CheckAnswer(answer:  word);
            this.<words>k__BackingField.RemoveAt(index:  0);
            if((this.<words>k__BackingField) == null)
            {
                goto label_24;
            }
            
            int val_6 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.5f), ease:  26));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_7, interval:  0.1f);
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Guide.GuideDialog::<CheckAnswer>b__13_0());
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  val_13);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_13, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.5f), ease:  27)), id:  this);
            goto label_29;
            label_3:
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_24 = "eff_word_fail";
            }
            else
            {
                    val_24 = "connect_fail";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_24, volumeScale:  1f, loop:  false, delay:  0f);
            val_25 = 3;
            return (View.Game.CheckAnswerType)val_25;
            label_24:
            label_29:
            val_25 = 0;
            return (View.Game.CheckAnswerType)val_25;
        }
        private void CreateGuideMask(View.CommonItem.Word word)
        {
            var val_15;
            var val_16;
            if(word == 0)
            {
                    return;
            }
            
            Message.Messager.Dispatch<System.Boolean>(cmd:  32, t:  false);
            View.CommonItem.GuideMask val_2 = UnityEngine.Object.Instantiate<View.CommonItem.GuideMask>(original:  this.GuideMaskPrefab);
            val_2.transform.SetParent(parent:  this.MaskContent, worldPositionStays:  false);
            UnityEngine.Transform val_4 = word.transform;
            if(val_4 != null)
            {
                    var val_5 = (null == null) ? (val_4) : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.Transform val_6 = val_2.transform;
            if(val_6 != null)
            {
                    var val_7 = (null == null) ? (val_6) : 0;
            }
            else
            {
                    val_16 = 0;
            }
            
            UnityEngine.Vector3 val_10 = word.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector2 val_11 = val_15.sizeDelta;
            val_16.sizeDelta = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            UnityEngine.Vector3 val_14 = word.transform.localScale;
            val_2.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            val_2.SetGuideMaskBgState(isShow:  true);
        }
        public GuideDialog()
        {
            this.stepIndex = 1;
            mem[1152921512749399960] = 257;
            mem[1152921512749399963] = 1;
            mem[1152921512749399968] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <CheckAnswer>b__13_0()
        {
            if("18" == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_3 = Locale.LocaleManager.Translate(key:  "18")(Locale.LocaleManager.Translate(key:  "18")) + System.String.Format(format:  "\n\"<color=#417A18><size=72>{0}</size></color>\"", arg0:  "Lo")(System.String.Format(format:  "\n\"<color=#417A18><size=72>{0}</size></color>\"", arg0:  "Lo"));
            View.Game.GameController val_4 = View.Game.GameController.GetInstance();
            if(null == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.CreateGuideMask(word:  val_4.wordContent.ChangeToGuideCanvas(word:  UnityEngine.UI.Text.__il2cppRuntimeField_byval_arg));
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  660f);
            this.RectContent.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
    
    }

}
