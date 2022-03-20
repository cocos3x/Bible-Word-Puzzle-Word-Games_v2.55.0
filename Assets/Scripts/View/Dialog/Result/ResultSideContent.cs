using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultSideContent : MonoBehaviour
    {
        // Fields
        public View.Dialog.Result.ResultChrysalisProgress ChrysalisProgress;
        
        // Methods
        public void HideSideButton()
        {
            this.ChrysalisProgress.gameObject.SetActive(value:  false);
        }
        public void HideSideEffect()
        {
            if(this.ChrysalisProgress != null)
            {
                    this.ChrysalisProgress.HideSideEffect();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void CheckChrysalisProgress()
        {
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpenForResult()) == false)
            {
                    return;
            }
            
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) != false)
            {
                    return;
            }
            
            this.ChrysalisProgress.gameObject.SetActive(value:  true);
            this.ChrysalisProgress.CollectAndAddProgress();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  86, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultSideContent::CheckChrysalisProgress()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  86, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultSideContent::CheckChrysalisProgress()));
        }
        public ResultSideContent()
        {
        
        }
    
    }

}
