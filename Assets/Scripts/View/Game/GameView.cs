using UnityEngine;

namespace View.Game
{
    public class GameView : UIView
    {
        // Fields
        private static View.Game.GameView _instance;
        public UnityEngine.Animator AnimatorGame;
        
        // Methods
        public static View.Game.GameView Create(UnityEngine.Transform parent)
        {
            if(View.Game.GameView._instance != 0)
            {
                    return (View.Game.GameView)View.Game.GameView._instance;
            }
            
            View.Game.GameView._instance = View.GameViewFactory.CreateGameView(parent:  parent);
            return (View.Game.GameView)View.Game.GameView._instance;
        }
        public void ShowGameView(Logic.Define.OpenGameFrom gameFrom)
        {
            this.gameObject.SetActive(value:  true);
            Logic.Gameplay.GameplayController val_2 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            val_2.<GameSceneShouldAd>k__BackingField = false;
            if((gameFrom != 0) || (Platform.AbTest.GameABTestManager.IsGameSoundTest() == false))
            {
                goto label_6;
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  "eff_home_to_game", volumeScale:  1f, loop:  false, delay:  0f);
            goto label_9;
            label_6:
            if((gameFrom - 2) < 2)
            {
                goto label_9;
            }
            
            if(gameFrom == 4)
            {
                goto label_14;
            }
            
            if(gameFrom != 0)
            {
                goto label_11;
            }
            
            label_9:
            label_14:
            this.AnimatorGame.Play(stateName:  "GameShowFromHome");
            return;
            label_11:
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.GameView::ShowHomeFromOther()));
            Common.TimerEvent.Add(time:  1f, callback:  new System.Action(object:  this, method:  System.Void View.Game.GameView::ShowHomeFromOther()), isrepeat:  false);
        }
        public void HideGameView(bool isAni)
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(isAni != false)
            {
                    Message.Messager.Dispatch(cmd:  62);
                this.AnimatorGame.Play(stateName:  "GameHideToHome");
                return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        private void PlayGameCompleteAni()
        {
            this.AnimatorGame.Play(stateName:  "GameComplete");
        }
        private void RestartNextGame()
        {
            this.AnimatorGame.Play(stateName:  "GameRestart");
        }
        private void GameHideToHomeCallBack()
        {
            this.gameObject.SetActive(value:  false);
        }
        private void ShowHomeFromOther()
        {
            Message.Messager.Dispatch(cmd:  65);
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != false)
            {
                    return;
            }
            
            Message.Messager.Dispatch(cmd:  52);
            Message.Messager.Dispatch(cmd:  53);
            Message.Messager.Dispatch(cmd:  64);
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  47, action:  new System.Action(object:  this, method:  System.Void View.Game.GameView::PlayGameCompleteAni()));
            Message.Messager.Add(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.Game.GameView::RestartNextGame()));
            Message.Messager.Add(cmd:  61, action:  new System.Action(object:  this, method:  System.Void View.Game.GameView::GameHideToHomeCallBack()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  47, action:  new System.Action(object:  this, method:  System.Void View.Game.GameView::PlayGameCompleteAni()));
            Message.Messager.Remove(cmd:  45, action:  new System.Action(object:  this, method:  System.Void View.Game.GameView::RestartNextGame()));
            Message.Messager.Remove(cmd:  61, action:  new System.Action(object:  this, method:  System.Void View.Game.GameView::GameHideToHomeCallBack()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.GameView::ShowHomeFromOther()));
        }
        public GameView()
        {
        
        }
    
    }

}
