using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class BibleContentAniCallback : MonoBehaviour
    {
        // Methods
        public void BibleContentOpenAudio()
        {
            Logic.Game.GameManager.gameSound.Play(clipName:  "bible_swipe", volumeScale:  1f, loop:  false, delay:  0f);
        }
        public void BibleContentOpenCallback()
        {
            Message.Messager.Dispatch(cmd:  14);
        }
        public void BibleContentShowTopCallback()
        {
            Message.Messager.Dispatch(cmd:  15);
        }
        public void BibleContentShowBottomCallback()
        {
            Message.Messager.Dispatch(cmd:  16);
        }
        public void BibleContentHideCallback()
        {
            Message.Messager.Dispatch(cmd:  17);
        }
        public void BibleContentPageCallback()
        {
            Message.Messager.Dispatch(cmd:  18);
        }
        public void BibleContentPageUpdate()
        {
            Message.Messager.Dispatch(cmd:  19);
        }
        public BibleContentAniCallback()
        {
        
        }
    
    }

}
