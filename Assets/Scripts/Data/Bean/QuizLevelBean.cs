using UnityEngine;

namespace Data.Bean
{
    [Serializable]
    public class QuizLevelBean
    {
        // Fields
        public string rightAnswer;
        public string quizTitle;
        public System.Collections.Generic.List<string> quizAnswer;
        public string id;
        
        // Methods
        public QuizLevelBean()
        {
        
        }
    
    }

}
