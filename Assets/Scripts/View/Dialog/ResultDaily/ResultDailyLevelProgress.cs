using UnityEngine;

namespace View.Dialog.ResultDaily
{
    public class ResultDailyLevelProgress : MonoBehaviour
    {
        // Fields
        private const int MaxProgress = 5;
        private const float TimeFly = 0.5;
        private const float ReelBigScale = 2;
        public UnityEngine.Transform TransformContent;
        public View.CommonItem.DailyProgressBarItem ProgressItemPrefab;
        public UnityEngine.Animator AnimatorReel;
        public UnityEngine.Transform TransformReel;
        public UnityEngine.Transform SlotReelBegin;
        public UnityEngine.Transform SlotReelEnd;
        private System.Collections.Generic.List<View.CommonItem.DailyProgressBarItem> _progressItems;
        private View.CommonItem.DailyProgressBarItem _nextProgressItem;
        private View.CommonItem.DailyProgressBarItem _tempItem;
        private bool _isPassAllLevel;
        
        // Methods
        public void SetProgress(int currentLevelIndex, int levelCount, bool isExist = False)
        {
            int val_10;
            this.ClearProgress();
            this._isPassAllLevel = (currentLevelIndex == levelCount) ? 1 : 0;
            int val_2 = UnityEngine.Mathf.Clamp(value:  levelCount, min:  0, max:  5);
            var val_4 = (currentLevelIndex > 5) ? (currentLevelIndex - 4) : (0 + 1);
            if(val_2 >= 1)
            {
                    var val_9 = -4;
                val_9 = val_9 - val_4;
                val_9 = currentLevelIndex + val_9;
                var val_10 = 0;
                do
            {
                val_10 = val_4 + val_10;
                View.CommonItem.DailyProgressBarItem val_6 = View.CommonItem.DailyProgressBarItem.Create(parent:  this.TransformContent, prefab:  this.ProgressItemPrefab, progress:  val_10);
                this._tempItem = val_6;
                val_6.SetProgress(progress:  val_10, currentLevelIndex:  currentLevelIndex, isLast:  false);
                if((val_9 + 4) == val_10)
            {
                    this._nextProgressItem = this._tempItem;
            }
            
                this._progressItems.Add(item:  this._tempItem);
                val_10 = val_10 + 1;
            }
            while(val_10 < val_2);
            
            }
            
            if(isExist != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_8 = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelProgress::<SetProgress>b__13_0()), seconds:  0.03f);
        }
        public void PlayAddProgressAni(bool isExist = False)
        {
            if(this._nextProgressItem == 0)
            {
                    return;
            }
            
            this._nextProgressItem.PlayProgressDoneAni(isExist:  isExist);
        }
        public void PlayFlyReelAni(System.Action callback)
        {
            typeof(ResultDailyLevelProgress.<>c__DisplayClass15_0).__il2cppRuntimeField_10 = this;
            typeof(ResultDailyLevelProgress.<>c__DisplayClass15_0).__il2cppRuntimeField_18 = callback;
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
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.TransformReel, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.5f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ResultDailyLevelProgress.<>c__DisplayClass15_0::<PlayFlyReelAni>b__0()));
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
            
            View.CommonItem.DailyProgressBarItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.CommonItem.DailyProgressBarItem>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
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
            Message.Messager.Add(cmd:  87, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelProgress::ProgressIncrease()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  87, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelProgress::ProgressIncrease()));
        }
        public ResultDailyLevelProgress()
        {
            this._progressItems = new System.Collections.Generic.List<View.CommonItem.DailyProgressBarItem>();
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
