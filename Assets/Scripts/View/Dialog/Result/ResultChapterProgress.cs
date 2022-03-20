using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultChapterProgress : MonoBehaviour
    {
        // Fields
        private const int MaxProgress = 6;
        private const float TimeFly = 1;
        private readonly string BookInfoFormat;
        public UnityEngine.Transform TransformContent;
        public View.Dialog.Result.ResultProgressItem ProgressItemPrefab;
        public UnityEngine.UI.Image ImageBook;
        public TMPro.TextMeshProUGUI TextInfo;
        public UnityEngine.Transform BibleReel;
        public UnityEngine.Transform SlotReelGegin;
        private System.Collections.Generic.List<View.Dialog.Result.ResultProgressItem> _progressItems;
        private View.Dialog.Result.ResultProgressItem _nextProgressItem;
        private View.Dialog.Result.ResultProgressItem _tempItem;
        
        // Methods
        public void SetProgress(int currentLevelIndex, int sectionLevelCount, string bibleName)
        {
            var val_12;
            this.ClearProgress();
            int val_1 = UnityEngine.Mathf.Clamp(value:  sectionLevelCount, min:  0, max:  6);
            if(currentLevelIndex < 7)
            {
                    val_12 = 1;
            }
            else
            {
                    val_12 = (((currentLevelIndex + 3) > sectionLevelCount) ? -5 : -3) + currentLevelIndex;
            }
            
            if(val_1 >= 1)
            {
                    var val_11 = 0;
                do
            {
                int val_5 = val_12 + val_11;
                View.Dialog.Result.ResultProgressItem val_6 = View.Dialog.Result.ResultProgressItem.Create(parent:  this.TransformContent, prefab:  this.ProgressItemPrefab, progress:  val_5);
                this._tempItem = val_6;
                val_6.SetProgress(progress:  val_5, isDone:  (val_5 < currentLevelIndex) ? 1 : 0);
                if((currentLevelIndex - val_12) == val_11)
            {
                    this._nextProgressItem = this._tempItem;
            }
            
                this._progressItems.Add(item:  this._tempItem);
                val_11 = val_11 + 1;
            }
            while(val_11 < val_1);
            
            }
            
            this.ImageBook.transform.SetAsLastSibling();
            this.TextInfo.text = System.String.Format(format:  this.BookInfoFormat, arg0:  currentLevelIndex, arg1:  sectionLevelCount, arg2:  bibleName);
            this.BibleReel.gameObject.SetActive(value:  false);
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
            typeof(ResultChapterProgress.<>c__DisplayClass14_0).__il2cppRuntimeField_10 = callback;
            typeof(ResultChapterProgress.<>c__DisplayClass14_0).__il2cppRuntimeField_18 = this;
            this.BibleReel.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = this.SlotReelGegin.position;
            this.BibleReel.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = this.ImageBook.transform.position;
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.BibleReel, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  1f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ResultChapterProgress.<>c__DisplayClass14_0::<PlayFlyReelAni>b__0()));
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
        private void OnDisable()
        {
            this.ClearProgress();
        }
        public ResultChapterProgress()
        {
            this.BookInfoFormat = "You’ve collect {0}/{1} of <color=#FFC61D>{2}</color>";
            this._progressItems = new System.Collections.Generic.List<View.Dialog.Result.ResultProgressItem>();
        }
    
    }

}
