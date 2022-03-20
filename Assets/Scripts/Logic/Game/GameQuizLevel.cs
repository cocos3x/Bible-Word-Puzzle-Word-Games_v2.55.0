using UnityEngine;

namespace Logic.Game
{
    public class GameQuizLevel
    {
        // Fields
        private Data.Bean.QuizLevelsBean _quizLevelsBean;
        private Data.Bean.QuizLevelBean _quizLevelBeanNow;
        
        // Methods
        public void Init()
        {
            this._quizLevelsBean = UnityEngine.JsonUtility.FromJson<Data.Bean.QuizLevelsBean>(json:  Common.EzFile.RijndaelDecrypt(pString:  Resource.ResManager.GetConfig(configName:  this.GetQuizLevelConfigName()).text, pKey:  ""));
        }
        private string GetQuizLevelConfigName()
        {
            var val_3;
            if((Locale.LocaleManager.GetCurLanguage() - 1) <= 2)
            {
                    val_3 = mem[19752640 + ((val_1 - 1)) << 3];
                val_3 = 19752640 + ((val_1 - 1)) << 3;
                return (string)val_3;
            }
            
            val_3 = "Config/Game/Quiz/quiz_level";
            return (string)val_3;
        }
        public Data.Bean.QuizLevelBean GetUnlockQuizLevelBean()
        {
            Data.Bean.QuizLevelBean val_5;
            var val_6;
            int val_4 = UnityEngine.Mathf.Clamp(value:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockQuizLevelIndex, min:  0, max:  W21 - 1);
            Data.Bean.QuizLevelsBean val_5 = this._quizLevelsBean;
            if(val_5 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (val_4 << 3);
            this._quizLevelBeanNow = 0;
            if(0 == 4)
            {
                    return val_5;
            }
            
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "GameQuizLevel GetUnlockQuizLevelBean json is error ... ", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_5 = this._quizLevelBeanNow;
            return val_5;
        }
        public bool CheckSelectOptionIsRight(string optionStr)
        {
            if(this._quizLevelBeanNow == null)
            {
                    return false;
            }
            
            if(this._quizLevelBeanNow.rightAnswer != null)
            {
                    return this._quizLevelBeanNow.rightAnswer.Equals(value:  optionStr);
            }
            
            throw new NullReferenceException();
        }
        public string GetQuizOptionRight()
        {
            if(this._quizLevelBeanNow == null)
            {
                    return 0;
            }
            
            return (string)this._quizLevelBeanNow.rightAnswer;
        }
        public int GetQuizLevelCount()
        {
            var val_1;
            if(this._quizLevelsBean != null)
            {
                    return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public string GetQuizId()
        {
            return (string)(this._quizLevelBeanNow == 0) ? "" : this._quizLevelBeanNow.id;
        }
        public GameQuizLevel()
        {
        
        }
    
    }

}
