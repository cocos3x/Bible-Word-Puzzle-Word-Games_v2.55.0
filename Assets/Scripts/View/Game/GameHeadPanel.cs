using UnityEngine;

namespace View.Game
{
    public class GameHeadPanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Button ButtonDictionary;
        private UnityEngine.Transform _bible;
        
        // Methods
        public void OnClickDictionary()
        {
            var val_6;
            GameBtnClick.BtnNameEnum val_7;
            string val_8;
            var val_9;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                goto label_2;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = GameBtnClick.BtnNameEnum.BtnNameDictionaryBtn;
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_8 = val_2.<NowCurLevelName>k__BackingField;
            goto label_6;
            label_2:
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState != 4)
            {
                goto label_8;
            }
            
            val_9 = null;
            val_9 = null;
            val_7 = GameBtnClick.BtnNameEnum.BtnNameDictionaryBtn;
            Logic.DailyPrayer.DailyPrayerControllers val_4 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_8 = val_4.<NowCurLevelName>k__BackingField;
            label_6:
            Platform.Analytics.EzAnalytics.SendGameBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = val_7}, levelName:  val_8);
            label_8:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dictionary", action:  "click", label:  "main_game", value:  0);
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.Open(name:  "GameDictionaryDialog", type:  0);
        }
        private void BeginGame(float delay = 0)
        {
            this.UpdateBibleState(delay:  delay);
            UnityEngine.GameObject val_1 = this.ButtonDictionary.gameObject;
            val_1.SetActive(value:  val_1.IsShowDictionary());
        }
        private bool IsShowDictionary()
        {
            var val_6;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                    return (bool)(Locale.LocaleManager.GetCurLanguage() == 0) ? 1 : 0;
            }
            
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) == false)
            {
                    return (bool)(Locale.LocaleManager.GetCurLanguage() == 0) ? 1 : 0;
            }
            
            val_6 = 0;
            return (bool)(Locale.LocaleManager.GetCurLanguage() == 0) ? 1 : 0;
        }
        private void UpdateBibleState(float delay = 0)
        {
            UnityEngine.Transform val_7;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                    return;
            }
            
            if(this._bible == 0)
            {
                    UnityEngine.Transform val_4 = this.transform.Find(n:  "Bible");
                val_7 = val_4;
                this._bible = val_4;
            }
            else
            {
                    val_7 = this._bible;
            }
            
            if(val_7 != 0)
            {
                    this._bible.gameObject.SetActive(value:  true);
            }
            
            this.ChangeDictionaryButtonState(isAbove:  false);
        }
        private void SetGameBibleIconState(bool isShow)
        {
            UnityEngine.Transform val_8;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                    return;
            }
            
            if(this._bible == 0)
            {
                    UnityEngine.Transform val_4 = this.transform.Find(n:  "Bible");
                val_8 = val_4;
                this._bible = val_4;
            }
            else
            {
                    val_8 = this._bible;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            this._bible.gameObject.SetActive(value:  isShow);
        }
        private void ChangeDictionaryButtonState(bool isAbove)
        {
            Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  this.ButtonDictionary.gameObject, name:  (isAbove != true) ? "Dialog" : "Default", order:  (isAbove != true) ? 11 : (0 + 1));
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Single>(cmd:  44, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameHeadPanel::BeginGame(float delay)));
            Message.Messager.Add<System.Boolean>(cmd:  66, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.GameHeadPanel::SetGameBibleIconState(bool isShow)));
            Message.Messager.Add<System.Boolean>(cmd:  67, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.GameHeadPanel::ChangeDictionaryButtonState(bool isAbove)));
            this.BeginGame(delay:  0f);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Single>(cmd:  44, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameHeadPanel::BeginGame(float delay)));
            Message.Messager.Remove<System.Boolean>(cmd:  66, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.GameHeadPanel::SetGameBibleIconState(bool isShow)));
            Message.Messager.Remove<System.Boolean>(cmd:  67, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.GameHeadPanel::ChangeDictionaryButtonState(bool isAbove)));
        }
        public GameHeadPanel()
        {
        
        }
    
    }

}
