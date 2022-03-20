using UnityEngine;

namespace View.Dialog.GameDictionary
{
    public class GameDictionaryDialog : Dialog
    {
        // Fields
        public View.Dialog.GameDictionary.DictionaryWordContent WordContent;
        public UnityEngine.GameObject Loading;
        public View.Dialog.GameDictionary.GameDictionaryTips Tips;
        private const string TipsEmpty = "Finish words to check the meaning.";
        private const string TipsFail = "Connection Failed. Please check your network connection and try again.";
        
        // Methods
        public void ClickCloseButton()
        {
            goto typeof(View.Dialog.GameDictionary.GameDictionaryDialog).__il2cppRuntimeField_1E0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add<System.Boolean>(cmd:  5, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.GameDictionary.GameDictionaryDialog::OnRequestWordDataCallBack(bool isSuccess)));
            this.UpdateWords();
        }
        protected void OnDisable()
        {
            Message.Messager.Remove<System.Boolean>(cmd:  5, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.GameDictionary.GameDictionaryDialog::OnRequestWordDataCallBack(bool isSuccess)));
        }
        private void OnRequestWordDataCallBack(bool isSuccess)
        {
            if(isSuccess != false)
            {
                    this.WordContent.ShowWordContents();
                this.SetDictionaryStatus(status:  3);
                return;
            }
            
            this.SetDictionaryStatus(status:  2);
            this.Tips.TextTips.text = "Connection Failed. Please check your network connection and try again.";
        }
        private void UpdateWords()
        {
            System.Collections.Generic.List<System.String> val_20;
            int val_21;
            this.SetDictionaryStatus(status:  1);
            System.Collections.Generic.List<System.String> val_1 = null;
            val_20 = val_1;
            val_1 = new System.Collections.Generic.List<System.String>();
            val_21 = System.String.alignConst;
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState != 3)
            {
                goto label_2;
            }
            
            Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_3._levelBean == null)
            {
                goto label_12;
            }
            
            Logic.Game.GameControllers val_4 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_20 = val_4._levelBean.AllAnswerList;
            Logic.Game.GameControllers val_6 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_21 = val_6.<NowCurLevelName>k__BackingField;
            if(val_20 != null)
            {
                goto label_8;
            }
            
            goto label_26;
            label_2:
            if(View.DailyPrayer.DailyPrayerController.GetInstance() != 0)
            {
                    View.DailyPrayer.DailyPrayerController val_9 = View.DailyPrayer.DailyPrayerController.GetInstance();
                if((val_9.<levelBean>k__BackingField) != null)
            {
                    View.DailyPrayer.DailyPrayerController val_10 = View.DailyPrayer.DailyPrayerController.GetInstance();
                val_20 = val_10.<levelBean>k__BackingField.AllAnswerList;
            }
            
                System.DateTime val_12 = System.DateTime.Now;
                val_21 = val_12.dateData.ToString(format:  "dd MMM", provider:  System.Globalization.CultureInfo.CreateSpecificCulture(name:  "en-GB"))(val_12.dateData.ToString(format:  "dd MMM", provider:  System.Globalization.CultureInfo.CreateSpecificCulture(name:  "en-GB"))) + Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex()(Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex());
            }
            
            label_12:
            if(val_20 == null)
            {
                goto label_26;
            }
            
            label_8:
            if( != 0)
            {
                    View.Dialog.GameDictionary.Controller.GameDictionaryController val_18 = Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance;
                if(val_18._rightAnswer != null)
            {
                    Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.RequestWordData(levelName:  val_21, words:  val_20);
                return;
            }
            
            }
            
            label_26:
            this.EmptyWords();
        }
        private void SetDictionaryStatus(int status)
        {
            this.Loading.gameObject.SetActive(value:  (status == 1) ? 1 : 0);
            this.Tips.gameObject.SetActive(value:  (status == 2) ? 1 : 0);
            this.WordContent.gameObject.SetActive(value:  (status == 3) ? 1 : 0);
        }
        private void EmptyWords()
        {
            this.SetDictionaryStatus(status:  2);
            this.Tips.TextTips.text = "Finish words to check the meaning.";
        }
        public GameDictionaryDialog()
        {
            mem[1152921512752349336] = 257;
            mem[1152921512752349339] = 1;
            mem[1152921512752349344] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
