using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultProgressItem : RecyclableItem
    {
        // Fields
        public UnityEngine.Animator AnimatorProgress;
        public TMPro.TextMeshProUGUI TextProgress;
        
        // Methods
        public static View.Dialog.Result.ResultProgressItem Create(UnityEngine.Transform parent, View.Dialog.Result.ResultProgressItem prefab, int progress)
        {
            View.Dialog.Result.ResultProgressItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.Result.ResultProgressItem>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
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
        }
        public void SetProgress(int progress, bool isDone)
        {
            this.TextProgress.text = progress.ToString();
            if(isDone == false)
            {
                    return;
            }
            
            this.AnimatorProgress.Play(stateName:  "ResultProgressDoneState");
        }
        public void PlayProgressDoneAni()
        {
            this.AnimatorProgress.Play(stateName:  "ResultProgressDone");
        }
        public ResultProgressItem()
        {
        
        }
    
    }

}
