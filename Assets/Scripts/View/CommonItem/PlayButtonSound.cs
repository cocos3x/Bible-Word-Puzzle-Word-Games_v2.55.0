using UnityEngine;

namespace View.CommonItem
{
    public class PlayButtonSound : MonoBehaviour
    {
        // Methods
        private void Awake()
        {
            if((this.GetComponent<UnityEngine.UI.Button>()) == 0)
            {
                    return;
            }
            
            val_1.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.CommonItem.PlayButtonSound::<Awake>b__0_0()));
        }
        public void Play()
        {
            Logic.Game.GameManager.gameSound.PlayButton();
        }
        public PlayButtonSound()
        {
        
        }
        private void <Awake>b__0_0()
        {
            this.Play();
        }
    
    }

}
