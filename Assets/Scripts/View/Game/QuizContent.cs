using UnityEngine;

namespace View.Game
{
    public class QuizContent : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TextQuiz;
        private Data.Bean.QuizLevelBean _quizLevelBean;
        
        // Methods
        public void InitContent(Data.Bean.QuizLevelBean bean)
        {
            this._quizLevelBean = bean;
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        public void ClearContent()
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        public QuizContent()
        {
        
        }
    
    }

}
