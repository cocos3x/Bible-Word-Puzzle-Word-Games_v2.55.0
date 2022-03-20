using UnityEngine;

namespace View.Game
{
    public class QuizOption : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshProUGUI TextOption;
        public UnityEngine.UI.Image ImageSelect;
        public UnityEngine.UI.Image ImageIcon;
        public TMPro.TextMeshProUGUI TextSelectOption;
        public UnityEngine.Sprite[] SpritesSelectStates;
        public UnityEngine.Sprite[] SpritesIconStates;
        private string _optionStr;
        private bool _canOperation;
        
        // Methods
        public void OnClickOptionButton()
        {
            if(this._canOperation == false)
            {
                    return;
            }
            
            Message.Messager.Dispatch<System.String>(cmd:  76, t:  this._optionStr);
        }
        public void SetOptionInfos(string option)
        {
            this._canOperation = true;
            this._optionStr = option;
            this.TextOption.text = option;
            this.TextSelectOption.text = option;
            this.ImageSelect.gameObject.SetActive(value:  false);
        }
        private void SetOptionState(bool right)
        {
            this.ImageSelect.gameObject.SetActive(value:  true);
            if(right == false)
            {
                goto label_3;
            }
            
            if(this.ImageSelect != null)
            {
                goto label_5;
            }
            
            label_3:
            label_5:
            this.ImageSelect.sprite = null;
            if(right == false)
            {
                goto label_10;
            }
            
            if(this.ImageIcon != null)
            {
                goto label_12;
            }
            
            label_10:
            label_12:
            this.ImageIcon.sprite = null;
            goto typeof(UnityEngine.UI.Image).__il2cppRuntimeField_3F0;
        }
        private void QuizEnd(bool right)
        {
            var val_14;
            var val_15;
            var val_16;
            System.Action val_17;
            var val_18;
            Message.Messager.Dispatch(cmd:  47);
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SetInQuizLevel(isIn:  false);
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddUnlockQuizLevelIndex(maxLevel:  Logic.Game.GameManager.gameQuizLevel.GetQuizLevelCount());
            string val_5 = "quiz_" + Logic.Game.GameManager.gameQuizLevel.GetQuizId();
            val_14 = null;
            if(right != false)
            {
                    val_15 = null;
                Platform.Analytics.EzAnalytics.SendQuizRecord(curLevel:  val_5, answerState:  new AnswerStateEnum() {<Value>k__BackingField = QuizRecord.AnswerStateEnum.AnswerStateRight});
                Platform.Analytics.EzAnalytics.LogEvent(category:  "quiz", action:  "level", label:  Logic.Game.GameManager.gameQuizLevel.GetQuizId() + "_right", value:  0);
                Logic.Game.GameManager.gameSound.Play(clipName:  "quiz_correct", volumeScale:  1f, loop:  false, delay:  0f);
                val_16 = 1152921504611106816;
                Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectOptionIsRight()));
                System.Action val_9 = null;
                val_17 = val_9;
                val_9 = new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectOptionIsRight());
            }
            else
            {
                    val_18 = null;
                Platform.Analytics.EzAnalytics.SendQuizRecord(curLevel:  val_5, answerState:  new AnswerStateEnum() {<Value>k__BackingField = QuizRecord.AnswerStateEnum.AnswerStateWrong});
                Platform.Analytics.EzAnalytics.LogEvent(category:  "quiz", action:  "level", label:  Logic.Game.GameManager.gameQuizLevel.GetQuizId() + "_wrong", value:  0);
                Logic.Game.GameManager.gameSound.Play(clipName:  "quiz_error", volumeScale:  1f, loop:  false, delay:  0f);
                Message.Messager.Dispatch(cmd:  77);
                val_16 = 1152921504611106816;
                Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectOptionIsWrong()));
                System.Action val_13 = null;
                val_17 = val_13;
                val_13 = new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectOptionIsWrong());
            }
            
            Common.TimerEvent.Add(time:  1.5f, callback:  val_17, isrepeat:  false);
        }
        private void SelectOptionIsRight()
        {
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "QuizRewardDialog", type:  0);
        }
        private void SelectOptionIsWrong()
        {
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "QuizTryAgainDialog", type:  0);
        }
        private void SelectQuizOption(string selectOption)
        {
            this._canOperation = false;
            if((this._optionStr.Equals(value:  selectOption)) == false)
            {
                    return;
            }
            
            string val_4 = selectOption;
            val_4 = Logic.Game.GameManager.gameQuizLevel.CheckSelectOptionIsRight(optionStr:  val_4);
            this.SetOptionState(right:  val_4);
            string val_5 = selectOption;
            val_5 = Logic.Game.GameManager.gameQuizLevel.CheckSelectOptionIsRight(optionStr:  val_5);
            this.QuizEnd(right:  val_5);
        }
        private void SelectRightQuizOption()
        {
            if(Logic.Game.GameManager.gameQuizLevel.GetQuizOptionRight() == null)
            {
                    return;
            }
            
            if((this._optionStr.Equals(value:  Logic.Game.GameManager.gameQuizLevel.GetQuizOptionRight())) == false)
            {
                    return;
            }
            
            this.SetOptionState(right:  true);
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.String>(cmd:  76, action:  new System.Action<System.String>(object:  this, method:  System.Void View.Game.QuizOption::SelectQuizOption(string selectOption)));
            Message.Messager.Add(cmd:  77, action:  new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectRightQuizOption()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.String>(cmd:  76, action:  new System.Action<System.String>(object:  this, method:  System.Void View.Game.QuizOption::SelectQuizOption(string selectOption)));
            Message.Messager.Remove(cmd:  77, action:  new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectRightQuizOption()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectOptionIsRight()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.QuizOption::SelectOptionIsRight()));
        }
        public QuizOption()
        {
        
        }
    
    }

}
