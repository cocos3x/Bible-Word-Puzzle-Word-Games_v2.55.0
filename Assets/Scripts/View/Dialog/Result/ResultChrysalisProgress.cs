using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultChrysalisProgress : MonoBehaviour
    {
        // Fields
        private const float TimeProgress = 0.6;
        public UnityEngine.Animator AnimatorChrysalis;
        public View.CommonItem.ChrysalisIcon Icon;
        public View.CommonItem.ChrysalisIcon[] IconAnis;
        public TMPro.TextMeshProUGUI TextProgress;
        public UnityEngine.UI.Image ImageProgress;
        public UnityEngine.GameObject EffectFull;
        public UnityEngine.Transform TransformSlot;
        private int _needChrysalis;
        private int _oldChrysalisCount;
        private int _nowChrysalisCount;
        
        // Methods
        public void PlayAudio()
        {
            Logic.Game.GameManager.gameSound.Play(clipName:  "butterfly_reward_collect", volumeScale:  1f, loop:  false, delay:  0f);
        }
        public void CollectCallback()
        {
            int val_2 = this._oldChrysalisCount;
            val_2 = val_2 + 1;
            this._oldChrysalisCount = val_2;
            this.TextProgress.text = System.String.Format(format:  "{0}/{1}", arg0:  val_2, arg1:  this._needChrysalis);
        }
        public void OnClickProgressButton()
        {
            var val_2;
            var val_3;
            this.EffectFull.SetActive(value:  false);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "enter_click", label:  "reward", value:  0);
            val_2 = null;
            val_2 = null;
            val_3 = null;
            val_3 = null;
            Platform.Analytics.EzAnalytics.SendActivScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = ActivScrShow.ScrNameEnum.ScrNameButterflyScr}, source:  new SourceEnum() {<Value>k__BackingField = ActivScrShow.SourceEnum.SourceLevelResultDlg});
            Message.Messager.Dispatch<System.Boolean>(cmd:  67, t:  false);
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyDialog", type:  0);
        }
        public void CollectAndAddProgress()
        {
            TMPro.TextMeshProUGUI val_26;
            object val_1 = new System.Object();
            typeof(ResultChrysalisProgress.<>c__DisplayClass14_0).__il2cppRuntimeField_10 = this;
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) != 0)
            {
                    this.AnimatorChrysalis.Play(stateName:  ((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) == 2) ? "ResultChrysalisProgressAdd_2" : "ResultChrysalisProgressAdd_3");
                this._needChrysalis = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.CollectNextButterFlyNeedChrysalis();
                Logic.Game.GameControllers val_9 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                this._oldChrysalisCount = val_9.<OldChrysalisCount>k__BackingField;
                this.SetChrysalisIcon();
                val_26 = this.TextProgress;
                val_26.text = System.String.Format(format:  "{0}/{1}", arg0:  this._oldChrysalisCount, arg1:  this._needChrysalis);
                float val_12 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisProgress(oldCount:  this._oldChrysalisCount);
                typeof(ResultChrysalisProgress.<>c__DisplayClass14_0).__il2cppRuntimeField_18 = val_12;
                this.ImageProgress.fillAmount = val_12;
                this.EffectFull.SetActive(value:  false);
                typeof(ResultChrysalisProgress.<>c__DisplayClass14_0).__il2cppRuntimeField_18 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisProgress(oldCount:  0);
                int val_18 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
                val_26 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single ResultChrysalisProgress.<>c__DisplayClass14_0::<CollectAndAddProgress>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void ResultChrysalisProgress.<>c__DisplayClass14_0::<CollectAndAddProgress>b__1(float x)), endValue:  typeof(ResultChrysalisProgress.<>c__DisplayClass14_0).__il2cppRuntimeField_18, duration:  0.6f);
                DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_25 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  val_26, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ResultChrysalisProgress.<>c__DisplayClass14_0::<CollectAndAddProgress>b__2())), delay:  ((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) == 2) ? 1.16f : 1.5f), id:  this);
                return;
            }
            
            this.SetProgress(isGuide:  false);
        }
        public void SetProgress(bool isGuide = False)
        {
            if(isGuide != true)
            {
                    this.SetChrysalisIcon();
            }
            
            this._needChrysalis = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.CollectNextButterFlyNeedChrysalis();
            int val_4 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetNowRoundChrysalisCount();
            this._nowChrysalisCount = val_4;
            this.TextProgress.text = System.String.Format(format:  "{0}/{1}", arg0:  val_4, arg1:  this._needChrysalis);
            float val_7 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisProgress(oldCount:  0);
            this.ImageProgress.fillAmount = val_7;
            this.EffectFull.SetActive(value:  (val_7 >= 1f) ? 1 : 0);
        }
        public void SetChrysalisProgressPos(UnityEngine.Vector3 pos)
        {
            this.gameObject.SetActive(value:  true);
            this.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        }
        public void SetChrysalisActive(bool isActive)
        {
            this.gameObject.SetActive(value:  isActive);
        }
        public void HideSideEffect()
        {
            if(this.EffectFull != null)
            {
                    this.EffectFull.SetActive(value:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void SetChrysalisIcon()
        {
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            this.Icon.SetChrysalisIcon(level:  val_1.<OldCollectChrysalisLevel>k__BackingField);
            var val_4 = 0;
            do
            {
                if(val_4 >= this.IconAnis.Length)
            {
                    return;
            }
            
                Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                this.IconAnis[val_4].SetChrysalisIcon(level:  val_2.<OldCollectChrysalisLevel>k__BackingField);
                val_4 = val_4 + 1;
            }
            while(this.IconAnis != null);
            
            throw new NullReferenceException();
        }
        public ResultChrysalisProgress()
        {
        
        }
    
    }

}
