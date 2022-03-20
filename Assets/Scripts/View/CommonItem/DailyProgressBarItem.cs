using UnityEngine;

namespace View.CommonItem
{
    public class DailyProgressBarItem : RecyclableItem
    {
        // Fields
        public UnityEngine.Animator AnimatorProgress;
        public TMPro.TextMeshProUGUI TextProgress;
        public UnityEngine.Transform TransformStar;
        private bool _isLastProgress;
        private bool _isCollected;
        
        // Methods
        public static View.CommonItem.DailyProgressBarItem Create(UnityEngine.Transform parent, View.CommonItem.DailyProgressBarItem prefab, int progress)
        {
            View.CommonItem.DailyProgressBarItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.DailyProgressBarItem>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            val_1.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_1.name = prefab.name + "_" + progress;
            return val_1;
        }
        public void ResultProgressDoneAudio()
        {
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() == false)
            {
                    return;
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_progress", volumeScale:  1f, loop:  false, delay:  0f);
        }
        public void ResultProgressDoneCallback()
        {
            Message.Messager.Dispatch(cmd:  87);
            UnityEngine.Vector3 val_1 = this.TransformStar.position;
            Message.Messager.Dispatch<UnityEngine.Vector3, System.Boolean>(cmd:  94, t:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, u:  this._isLastProgress);
        }
        public void SetProgress(int progress, int currentLevelIndex, bool isLast = False)
        {
            string val_3;
            this.TextProgress.text = progress.ToString();
            this._isLastProgress = isLast;
            if(progress < currentLevelIndex)
            {
                    val_3 = "DailyResultProgressDoneState";
            }
            else
            {
                    this._isCollected = false;
                val_3 = "DailyResultProgressNone";
            }
            
            this.AnimatorProgress.Play(stateName:  val_3);
        }
        public void PlayProgressDoneAni(bool isExist = False)
        {
            string val_1;
            if(this._isCollected != false)
            {
                    return;
            }
            
            this._isCollected = true;
            if(isExist != false)
            {
                    val_1 = "DailyResultProgressDoneState";
            }
            else
            {
                    val_1 = "DailyResultProgressDone";
            }
            
            this.AnimatorProgress.Play(stateName:  val_1);
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.AnimatorProgress.Play(stateName:  "DailyResultProgressNone");
            this._isCollected = false;
        }
        private void OnEnable()
        {
            this._isCollected = false;
        }
        public DailyProgressBarItem()
        {
        
        }
    
    }

}
