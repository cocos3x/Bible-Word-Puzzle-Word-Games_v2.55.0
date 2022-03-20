using UnityEngine;

namespace View.Dialog.DailyGuide
{
    public class DailyGuideDialog : Dialog
    {
        // Fields
        private UnityEngine.UI.Text contextText;
        private System.Collections.Generic.List<string> <words>k__BackingField;
        
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
            var val_13;
            var val_14;
            val_13 = this;
            this.Awake();
            this.contextText = this.transform.Find(n:  "FitPanel/Content/Text").GetComponent<UnityEngine.UI.Text>();
            View.DailyPrayer.DailyPrayerController val_4 = View.DailyPrayer.DailyPrayerController.GetInstance();
            val_14 = 0;
            this.<words>k__BackingField = val_4.wordContent.GetGuideWords();
            if((public UnityEngine.UI.Text UnityEngine.Component::GetComponent<UnityEngine.UI.Text>()) != 0)
            {
                    if("29" == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "29"), arg0:  null);
                val_13 = ???;
            }
        
        }
        public View.Game.CheckAnswerType CheckAnswer(string word)
        {
            var val_6;
            string val_7;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Equality(a:  word, b:  0)) != false)
            {
                    View.DailyPrayer.DailyPrayerController val_2 = View.DailyPrayer.DailyPrayerController.GetInstance();
                View.Game.CheckAnswerType val_3 = val_2.wordContent.CheckAnswer(answer:  word);
                Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetDailyNewGuide(isGuide:  false);
                val_6 = 0;
                return (View.Game.CheckAnswerType)val_6;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_7 = "eff_word_fail";
            }
            else
            {
                    val_7 = "connect_fail";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_7, volumeScale:  1f, loop:  false, delay:  0f);
            val_6 = 3;
            return (View.Game.CheckAnswerType)val_6;
        }
        public DailyGuideDialog()
        {
            mem[1152921512786767448] = 257;
            mem[1152921512786767451] = 1;
            mem[1152921512786767456] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
