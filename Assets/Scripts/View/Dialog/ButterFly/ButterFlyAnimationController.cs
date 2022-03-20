using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class ButterFlyAnimationController : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorButterFly;
        private string _nextPlayAniName;
        
        // Methods
        public void FlyAniCallback()
        {
            if((System.String.IsNullOrEmpty(value:  this._nextPlayAniName)) == true)
            {
                    return;
            }
            
            this.AnimatorButterFly.Play(stateName:  this._nextPlayAniName);
            this._nextPlayAniName = System.String.alignConst;
        }
        public void PlayStopAni(int butterFlyStyle)
        {
            this._nextPlayAniName = System.String.Format(format:  "ButterFlyStop{0}", arg0:  butterFlyStyle + 1);
        }
        public void PlayBeginFlyAni(int butterFlyStyle)
        {
            this._nextPlayAniName = System.String.alignConst;
            this.AnimatorButterFly.Play(stateName:  System.String.Format(format:  "ButterFlyStop_begin{0}", arg0:  butterFlyStyle + 1));
        }
        public void PlayDefaultFlyAni()
        {
            this._nextPlayAniName = System.String.alignConst;
            this.AnimatorButterFly.Play(stateName:  "ButterFlyFly");
        }
        private void OnEnable()
        {
            this._nextPlayAniName = System.String.alignConst;
            this.PlayDefaultFlyAni();
        }
        private void OnDisable()
        {
            this.AnimatorButterFly.ResetTrigger(name:  "ButterFlyFly");
        }
        public ButterFlyAnimationController()
        {
        
        }
    
    }

}
