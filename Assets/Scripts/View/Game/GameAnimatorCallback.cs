using UnityEngine;

namespace View.Game
{
    public class GameAnimatorCallback : MonoBehaviour
    {
        // Methods
        public void GameHideToHomeCallBack()
        {
            Message.Messager.Dispatch(cmd:  61);
        }
        public void GameShowFromHomeCallBackSideButton()
        {
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != false)
            {
                    return;
            }
            
            Message.Messager.Dispatch(cmd:  52);
            Message.Messager.Dispatch(cmd:  53);
        }
        public void GameShowFromHomeCallBackChrysalis()
        {
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != false)
            {
                    return;
            }
            
            Message.Messager.Dispatch(cmd:  64);
        }
        public void GameShowFromHomeCallBack()
        {
            Message.Messager.Dispatch(cmd:  65);
        }
        public GameAnimatorCallback()
        {
        
        }
    
    }

}
