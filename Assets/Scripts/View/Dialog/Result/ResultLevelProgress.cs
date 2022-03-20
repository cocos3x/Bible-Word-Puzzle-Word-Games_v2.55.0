using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultLevelProgress : MonoBehaviour
    {
        // Fields
        private const int MaxProgress = 8;
        private const float TimeFly = 0.5;
        private const float ReelBigScale = 2;
        public UnityEngine.Transform TransformContent;
        public View.Dialog.Result.ResultProgressItem ProgressItemPrefab;
        public UnityEngine.Animator AnimatorReel;
        public UnityEngine.Transform TransformReel;
        public UnityEngine.Transform SlotReelBegin;
        public UnityEngine.Transform SlotReelEnd;
        private System.Collections.Generic.List<View.Dialog.Result.ResultProgressItem> _progressItems;
        private View.Dialog.Result.ResultProgressItem _nextProgressItem;
        private View.Dialog.Result.ResultProgressItem _tempItem;
        private bool _isPassAllLevel;
        
        // Methods
        public void SetProgress(int currentLevelIndex, int sectionLevelCount)
        {
            int val_12 = sectionLevelCount;
            this.ClearProgress();
            int val_1 = (currentLevelIndex == 0) ? (val_12) : currentLevelIndex;
            this._isPassAllLevel = (val_1 == val_12) ? 1 : 0;
            int val_3 = UnityEngine.Mathf.Clamp(value:  val_12 = sectionLevelCount, min:  0, max:  8);
            var val_4 = val_1 - 7;
            var val_5 = (val_1 > 8) ? (val_4) : (0 + 1);
            if(val_3 >= 1)
            {
                    val_12 = val_3;
                var val_12 = 0;
                do
            {
                int val_7 = val_5 + val_12;
                View.Dialog.Result.ResultProgressItem val_8 = View.Dialog.Result.ResultProgressItem.Create(parent:  this.TransformContent, prefab:  this.ProgressItemPrefab, progress:  val_7);
                this._tempItem = val_8;
                val_4 = (val_5 - val_1) + val_12;
                if(val_4 != 0)
            {
                    val_8.SetProgress(progress:  val_7, isDone:  (val_7 < val_1) ? 1 : 0);
            }
            else
            {
                    val_8.SetProgress(progress:  val_1, isDone:  false);
                this._nextProgressItem = this._tempItem;
            }
            
                this._progressItems.Add(item:  this._tempItem);
                val_12 = val_12 + 1;
            }
            while(val_12 < val_12);
            
            }
            
            UnityEngine.Coroutine val_11 = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultLevelProgress::<SetProgress>b__13_0()), seconds:  0.03f);
        }
        public void PlayAddProgressAni()
        {
            if(this._nextProgressItem == 0)
            {
                    return;
            }
            
            this._nextProgressItem.PlayProgressDoneAni();
        }
        public void PlayFlyReelAni(System.Action callback)
        {
            typeof(ResultLevelProgress.<>c__DisplayClass15_0).__il2cppRuntimeField_10 = this;
            typeof(ResultLevelProgress.<>c__DisplayClass15_0).__il2cppRuntimeField_18 = callback;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_scroll_move", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            UnityEngine.Vector3 val_3 = this.SlotReelBegin.position;
            this.TransformReel.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.TransformReel, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.5f);
            UnityEngine.Vector3 val_7 = this.SlotReelEnd.position;
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.TransformReel, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.5f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ResultLevelProgress.<>c__DisplayClass15_0::<PlayFlyReelAni>b__0()));
        }
        private void ClearProgress()
        {
            if(this._progressItems < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            if(val_2 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            View.Dialog.Result.ResultProgressItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.Result.ResultProgressItem>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
            val_2 = val_2 + 1;
            this._progressItems.Clear();
            this._nextProgressItem = 0;
        }
        private void ProgressIncrease()
        {
            if(this._isPassAllLevel != false)
            {
                    return;
            }
            
            this.AnimatorReel.Play(stateName:  "ResultBibleReelCollect");
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  87, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultLevelProgress::ProgressIncrease()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  87, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Result.ResultLevelProgress::ProgressIncrease()));
            this.ClearProgress();
        }
        public ResultLevelProgress()
        {
            this._progressItems = new System.Collections.Generic.List<View.Dialog.Result.ResultProgressItem>();
        }
        private void <SetProgress>b__13_0()
        {
            this.TransformReel.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_2 = this.SlotReelBegin.position;
            this.TransformReel.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.TransformReel.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
    
    }

}
