using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignStarProgress : MonoBehaviour
    {
        // Fields
        private const int MaxStarCount = 80;
        public UnityEngine.Animator AnimatorStar;
        public View.Dialog.DailySign.DailySignStarBox[] StarBoxs;
        public TMPro.TextMeshProUGUI TextStar;
        public UnityEngine.UI.Slider SliderProgress;
        private int _beforeCollectStar;
        
        // Methods
        private void UpdateDailySignStarProgress()
        {
            int val_13;
            int val_16 = 0;
            label_26:
            Data.DailyRecord.DailyRecordDataManager val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if(val_16 >= this.StarBoxs.Length)
            {
                goto label_4;
            }
            
            Data.DailyRecord.DailyRecordDataManager val_4 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if(val_16 < val_3.StarBoxProgress.Length)
            {
                    val_13 = val_4.StarBoxProgress[0];
                Data.DailyRecord.DailyRecordDataManager val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            }
            else
            {
                    Data.DailyRecord.DailyRecordDataManager val_6 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                int val_13 = val_6.StarBoxProgress.Length;
                val_13 = val_13 - 1;
                val_13 = val_4.StarBoxProgress[val_13];
                Data.DailyRecord.DailyRecordDataManager val_7 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                Data.DailyRecord.DailyRecordDataManager val_8 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                int val_14 = val_8.StarBoxProgress.Length;
                val_14 = val_14 - 1;
            }
            
            val_16 = val_16 + 1;
            this.StarBoxs[val_16].SetBoxInfo(rewardCount:  1651466480, progress:  val_13, isOpened:  ((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignBeforeCollectStarRecord) >= val_13) ? 1 : 0, index:  val_16);
            if(this.StarBoxs != null)
            {
                goto label_26;
            }
            
            label_4:
            this._beforeCollectStar = val_3.<DailySignBeforeCollectStar>k__BackingField;
            Data.DailyRecord.DailyRecordDataManager val_10 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            this.TextStar.text = val_10.<DailySignBeforeCollectStar>k__BackingField.ToString();
            Data.DailyRecord.DailyRecordDataManager val_12 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            float val_17 = (float)val_12.<DailySignBeforeCollectStar>k__BackingField;
            val_17 = val_17 / 80f;
        }
        private void PlayCollectStarsAnimatorEnd(bool isLast)
        {
            this.AnimatorStar.Play(stateName:  "DailyStarShinny");
            int val_10 = this._beforeCollectStar;
            val_10 = val_10 + 1;
            this._beforeCollectStar = val_10;
            this.TextStar.text = this._beforeCollectStar.ToString();
            if(isLast == false)
            {
                    return;
            }
            
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  this, method:  System.Single View.Dialog.DailySign.DailySignStarProgress::<PlayCollectStarsAnimatorEnd>b__7_0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarProgress::<PlayCollectStarsAnimatorEnd>b__7_1(float v)), endValue:  ((float)Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord) / 80f, duration:  0.6f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarProgress::<PlayCollectStarsAnimatorEnd>b__7_2()));
        }
        private void CollectReward(int beforeStarNum, int nowStarNum)
        {
            var val_4;
            var val_6 = 0;
            do
            {
                if(val_6 >= this.StarBoxs.Length)
            {
                    return;
            }
            
                Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                if(val_6 < (val_1.StarBoxProgress.Length << ))
            {
                    val_4 = val_6;
            }
            else
            {
                    Data.DailyRecord.DailyRecordDataManager val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                val_4 = val_3.StarBoxProgress.Length - 1;
            }
            
                int val_4 = val_2.StarBoxProgress[val_4];
                if(((val_4 <= nowStarNum) && (nowStarNum > beforeStarNum)) && (val_4 > beforeStarNum))
            {
                    this.StarBoxs[val_6].OpenBoxReward();
            }
            
                val_6 = val_6 + 1;
            }
            while(this.StarBoxs != null);
            
            throw new NullReferenceException();
        }
        private void DailySignShowCallback()
        {
            Data.DailyRecord.DailyRecordDataManager val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SetDailySignBeforeCollectStarRecord(value:  val_3.<DailySignBeforeCollectStar>k__BackingField);
            this.CollectReward(beforeStarNum:  Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignBeforeCollectStarRecord, nowStarNum:  val_3.<DailySignBeforeCollectStar>k__BackingField);
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Boolean>(cmd:  95, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarProgress::PlayCollectStarsAnimatorEnd(bool isLast)));
            Message.Messager.Add(cmd:  96, action:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarProgress::DailySignShowCallback()));
            this.UpdateDailySignStarProgress();
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Boolean>(cmd:  95, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarProgress::PlayCollectStarsAnimatorEnd(bool isLast)));
            Message.Messager.Remove(cmd:  96, action:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarProgress::DailySignShowCallback()));
        }
        public DailySignStarProgress()
        {
        
        }
        private float <PlayCollectStarsAnimatorEnd>b__7_0()
        {
            if(this.SliderProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <PlayCollectStarsAnimatorEnd>b__7_1(float v)
        {
            if(this.SliderProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <PlayCollectStarsAnimatorEnd>b__7_2()
        {
            this.TextStar.text = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord.ToString();
            int val_7 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord;
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SetDailySignBeforeCollectStarRecord(value:  val_7);
            this.CollectReward(beforeStarNum:  Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignBeforeCollectStarRecord, nowStarNum:  val_7);
            Data.DailyRecord.DailyRecordDataManager val_9 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_9.<DailySignIsCanOperate>k__BackingField = true;
        }
    
    }

}
