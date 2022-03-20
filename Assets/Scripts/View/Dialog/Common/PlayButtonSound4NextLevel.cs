using UnityEngine;

namespace View.Dialog.Common
{
    public class PlayButtonSound4NextLevel : MonoBehaviour
    {
        // Methods
        private void Awake()
        {
            if((this.GetComponent<UnityEngine.UI.Button>()) == 0)
            {
                    return;
            }
            
            val_1.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Common.PlayButtonSound4NextLevel::<Awake>b__0_0()));
        }
        public void Play()
        {
            Logic.Game.GameManager.gameSound.PlayButton();
        }
        public PlayButtonSound4NextLevel()
        {
        
        }
        private void <Awake>b__0_0()
        {
            this.Play();
        }
    
    }

}
