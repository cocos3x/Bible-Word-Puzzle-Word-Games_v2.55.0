using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignDayProgress : MonoBehaviour
    {
        // Fields
        private const int MaxProgress = 3;
        private const float TimeProgressInterval = 0.6;
        public UnityEngine.Transform TransformContent;
        public View.CommonItem.DailyProgressBarItem ProgressItemPrefab;
        public TMPro.TextMeshProUGUI TextMonth;
        public TMPro.TextMeshProUGUI TextDay;
        public UnityEngine.Animator AnimatorSolved;
        public UnityEngine.UI.Text TextSolved;
        private System.Collections.Generic.List<View.CommonItem.DailyProgressBarItem> _progressItems;
        private View.CommonItem.DailyProgressBarItem _tempItem;
        private int _levelCount;
        
        // Methods
        private void SetProgress(int beforeLevelIndex, int currentLevelIndex)
        {
            int val_16;
            var val_17;
            int val_1 = UnityEngine.Mathf.Clamp(value:  this._levelCount, min:  0, max:  3);
            val_16 = val_1;
            if(val_1 < 1)
            {
                goto label_3;
            }
            
            var val_3 = (beforeLevelIndex > 3) ? (beforeLevelIndex - 2) : (0 + 1);
            val_3 = val_3 + 2;
            var val_16 = 0;
            var val_17 = 0;
            var val_6 = val_3 - 2;
            label_11:
            if(val_16 >= val_3)
            {
                goto label_5;
            }
            
            val_3 = val_3 & 4294967295;
            if(val_16 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            this._tempItem = (((beforeLevelIndex > 3 ? (beforeLevelIndex - 2) : (0 + 1) + 2) & 4294967295) + 0) + 32;
            if(((((beforeLevelIndex > 3 ? (beforeLevelIndex - 2) : (0 + 1) + 2) & 4294967295) + 0) + 32) != 0)
            {
                goto label_7;
            }
            
            label_5:
            View.CommonItem.DailyProgressBarItem val_8 = View.CommonItem.DailyProgressBarItem.Create(parent:  this.TransformContent, prefab:  this.ProgressItemPrefab, progress:  val_6 + val_16);
            this._tempItem = val_8;
            this._progressItems.Add(item:  val_8);
            label_7:
            int val_9 = val_6 + val_16;
            this._tempItem.SetProgress(progress:  val_9, currentLevelIndex:  beforeLevelIndex + 1, isLast:  ((currentLevelIndex - 1) == val_16) ? 1 : 0);
            var val_11 = (val_9 <= currentLevelIndex) ? 1 : 0;
            val_16 = val_16 + 1;
            val_11 = ((val_9 > beforeLevelIndex) ? 1 : 0) & val_11;
            val_17 = val_17 | val_11;
            if(val_16 < (long)val_16)
            {
                goto label_11;
            }
            
            val_16 = val_16;
            val_17 = val_17 ^ 1;
            goto label_12;
            label_3:
            val_17 = 1;
            label_12:
            this.AnimatorSolved.gameObject.SetActive(value:  ((val_16 == currentLevelIndex) ? 1 : 0) & val_17);
        }
        private void PlayProgressAni(int beforeLevelIndex, int currentLevelIndex)
        {
            int val_19;
            var val_20;
            val_19 = UnityEngine.Mathf.Clamp(value:  this._levelCount, min:  0, max:  3);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            if(val_19 >= 1)
            {
                    var val_19 = 0;
                val_20 = (((beforeLevelIndex > 3) ? (beforeLevelIndex - 2) : (0 + 1)) + 2) - 2;
                do
            {
                if(val_19 < 1152921504807591936)
            {
                    if(val_19 >= 21264152)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                typeof(DailySignDayProgress.<>c__DisplayClass12_0).__il2cppRuntimeField_10 = public Data.Bean.BibleSection System.Collections.Generic.List<Data.Bean.BibleSection>::get_Item(int index);
            }
            else
            {
                    View.CommonItem.DailyProgressBarItem val_10 = View.CommonItem.DailyProgressBarItem.Create(parent:  this.TransformContent, prefab:  this.ProgressItemPrefab, progress:  val_20 + val_19);
                typeof(DailySignDayProgress.<>c__DisplayClass12_0).__il2cppRuntimeField_10 = val_10;
                this._progressItems.Add(item:  val_10);
            }
            
                int val_11 = val_20 + val_19;
                typeof(DailySignDayProgress.<>c__DisplayClass12_0).__il2cppRuntimeField_10.SetProgress(progress:  val_11, currentLevelIndex:  beforeLevelIndex + 1, isLast:  ((currentLevelIndex - 1) == val_19) ? 1 : 0);
                if((val_11 <= currentLevelIndex) && (val_11 > beforeLevelIndex))
            {
                    DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void DailySignDayProgress.<>c__DisplayClass12_0::<PlayProgressAni>b__0()));
                DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  0.6f);
            }
            
                val_19 = val_19 + 1;
            }
            while(val_19 < (long)val_19);
            
                val_19 = val_19;
                if((1 & 1) != 0)
            {
                    return;
            }
            
            }
            
            this.AnimatorSolved.gameObject.SetActive(value:  (val_19 == currentLevelIndex) ? 1 : 0);
            Data.DailyRecord.DailyRecordDataManager val_18 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_18.<DailySignIsCanOperate>k__BackingField = true;
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
        }
        private void UpdateDailySignDayProgress(int day)
        {
            int val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailySignBeforeRecordFromDate(day:  day);
            int val_4 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailySignRecordFromDate(day:  day);
            this.SetProgress(beforeLevelIndex:  val_2 & (~(val_2 >> 31)), currentLevelIndex:  val_4 & (~(val_4 >> 31)));
            this.TextDay.text = day.ToString();
        }
        private void DailySignShowCallback()
        {
            Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailySignBeforeRecordFromDate(day:  val_2.<CurrentDailyDay>k__BackingField);
            Data.DailyRecord.DailyRecordDataManager val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_6 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailySignRecordFromDate(day:  val_5.<CurrentDailyDay>k__BackingField);
            int val_7 = val_3 & (~(val_3 >> 31));
            int val_8 = val_6 & (~(val_6 >> 31));
            if(val_8 > val_7)
            {
                    this.PlayProgressAni(beforeLevelIndex:  val_7, currentLevelIndex:  val_8);
            }
            else
            {
                    Data.DailyRecord.DailyRecordDataManager val_9 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                val_9.<DailySignIsCanOperate>k__BackingField = true;
            }
            
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SynchronizationDailySignRecord();
        }
        private void PlayCollectStarsAnimatorEnd(bool isLast)
        {
            if(isLast == false)
            {
                    return;
            }
            
            Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailySignRecordFromDate(day:  val_2.<CurrentDailyDay>k__BackingField);
            if(this._levelCount != (val_3 & (~(val_3 >> 31))))
            {
                    return;
            }
            
            this.AnimatorSolved.gameObject.SetActive(value:  true);
            this.AnimatorSolved.Play(stateName:  "SolvedShow_2");
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Int32>(cmd:  93, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDayProgress::UpdateDailySignDayProgress(int day)));
            Message.Messager.Add(cmd:  96, action:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDayProgress::DailySignShowCallback()));
            Message.Messager.Add<System.Boolean>(cmd:  95, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDayProgress::PlayCollectStarsAnimatorEnd(bool isLast)));
            this._levelCount = Logic.Game.GameManager.gameDailyPrayer.GetDailyPrayerLevelCountBySignDate();
            this.AnimatorSolved.gameObject.SetActive(value:  false);
            this.LocaleTranslate();
            this.ClearProgress();
            Data.DailyRecord.DailyRecordDataManager val_6 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            this.UpdateDailySignDayProgress(day:  val_6.<CurrentDailyDay>k__BackingField);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Int32>(cmd:  93, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDayProgress::UpdateDailySignDayProgress(int day)));
            Message.Messager.Remove(cmd:  96, action:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDayProgress::DailySignShowCallback()));
            Message.Messager.Remove<System.Boolean>(cmd:  95, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDayProgress::PlayCollectStarsAnimatorEnd(bool isLast)));
        }
        private void LocaleTranslate()
        {
            Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_5 = val_1.<CurrentMonth>k__BackingField;
            val_5 = val_5 + 168;
            this.TextMonth.text = Locale.LocaleManager.Translate(key:  val_5.ToString());
            string val_4 = Locale.LocaleManager.Translate(key:  "3");
        }
        public DailySignDayProgress()
        {
            this._progressItems = new System.Collections.Generic.List<View.CommonItem.DailyProgressBarItem>();
        }
    
    }

}
