using UnityEngine;

namespace View.Dialog.ResultDaily
{
    public class ResultDailyLevelContent : UIElement
    {
        // Fields
        private const string TitleLevel = "result_title_levelclear";
        private const float TimeAlpha = 0.5;
        public UnityEngine.Animator AnimatorTitle;
        public UnityEngine.Animator AnimatorCoin;
        public UnityEngine.Animator AnimatorProgress;
        public UnityEngine.UI.Image ImageTitle;
        public UnityEngine.GameObject EffectTitle;
        public View.Dialog.ResultDaily.ResultDailyLevelProgress LevelProgress;
        public UnityEngine.CanvasGroup CanvasGroupContent;
        public View.Dialog.ResultDaily.ResultDailyBottom Bottoms;
        public TMPro.TextMeshProUGUI TextReward;
        public UnityEngine.Transform TransformCoinStart;
        private int _levelCount;
        private int _curLevelIndex;
        private bool _isAllPass;
        private int _rewardCount;
        private string _atlasName;
        
        // Methods
        public void LocaleTranslate()
        {
            string val_2;
            this._atlasName = "Atlas/DialogMulti3";
            Locale.LocaleE val_1 = Locale.LocaleManager.GetCurLanguage();
            if(val_1 == 1)
            {
                goto label_1;
            }
            
            if(val_1 == 3)
            {
                goto label_2;
            }
            
            if(val_1 != 2)
            {
                goto label_3;
            }
            
            val_2 = "Atlas/LocaleSpanish";
            goto label_5;
            label_2:
            val_2 = "Atlas/LocaleFrench";
            goto label_5;
            label_1:
            val_2 = "Atlas/LocalePortuguese";
            label_5:
            this._atlasName = val_2;
            label_3:
            this.Bottoms.LocaleTranslate();
            this.SetTitle();
        }
        public void ShowLevelContent()
        {
            this.gameObject.SetActive(value:  true);
            this.EffectTitle.SetActive(value:  false);
            this.AnimatorProgress.gameObject.SetActive(value:  false);
            this.Bottoms.gameObject.SetActive(value:  false);
            this.Bottoms.ShowBottoms();
            this.CanvasGroupContent.alpha = 1f;
            int val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentLevelReward();
            this._rewardCount = val_5;
            this.TextReward.text = System.String.Format(format:  "x{0}", arg0:  val_5);
            this.PlayLevelContentAni();
            this._levelCount = Logic.Game.GameManager.gameDailyPrayer.GetDailyPrayerLevelCountBySignDate();
            int val_9 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex();
            this._curLevelIndex = val_9;
            this._isAllPass = (this._levelCount == (val_9 + 1)) ? 1 : 0;
        }
        public void ShowChapterContent()
        {
            this.gameObject.SetActive(value:  true);
            this.EffectTitle.SetActive(value:  false);
            this.CanvasGroupContent.alpha = 0f;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupContent, endValue:  1f, duration:  0.5f);
            this.PlayChapterAni();
        }
        private void SetTitle()
        {
            if((System.String.IsNullOrEmpty(value:  this._atlasName)) != false)
            {
                    return;
            }
            
            this.ImageTitle.sprite = Resource.ResManager.GetSpriteFromPool(atlas:  this._atlasName, spriteName:  "result_title_levelclear");
        }
        public void HideLevelContent(System.Action callback, bool isToBible)
        {
            typeof(ResultDailyLevelContent.<>c__DisplayClass21_0).__il2cppRuntimeField_10 = this;
            typeof(ResultDailyLevelContent.<>c__DisplayClass21_0).__il2cppRuntimeField_18 = callback;
            if(isToBible == false)
            {
                    return;
            }
            
            this.LevelProgress.PlayFlyReelAni(callback:  new System.Action(object:  new ResultDailyLevelContent.<>c__DisplayClass21_0(), method:  System.Void ResultDailyLevelContent.<>c__DisplayClass21_0::<HideLevelContent>b__0()));
        }
        private void PlayLevelContentAni()
        {
            this.AnimatorTitle.Play(stateName:  "ResultTitleAni");
            this.EffectTitle.SetActive(value:  true);
            this.AnimatorCoin.Play(stateName:  "ResultDailyCoinShow");
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelContent::<PlayLevelContentAni>b__22_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1.6f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelContent::<PlayLevelContentAni>b__22_1()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_2, id:  this);
        }
        private void PlayChapterAni()
        {
            static_value_0141682D = true;
            this.LevelProgress.SetProgress(currentLevelIndex:  this._curLevelIndex + 1, levelCount:  this._levelCount, isExist:  true);
            this.LevelProgress.PlayAddProgressAni(isExist:  true);
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.8f);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelContent::<PlayChapterAni>b__23_0()));
        }
        private void LevelPassReward()
        {
            UnityEngine.Vector3 val_2 = this.TransformCoinStart.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this._rewardCount, from:  "daily_level_pass", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelContent::OnGainCoinCallback()), count:  0);
        }
        private void OnGainCoinCallback()
        {
            Message.Messager.Dispatch(cmd:  1);
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  4, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelContent::LevelPassReward()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  4, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ResultDaily.ResultDailyLevelContent::LevelPassReward()));
        }
        public ResultDailyLevelContent()
        {
        
        }
        private void <PlayLevelContentAni>b__22_0()
        {
            this.AnimatorProgress.gameObject.SetActive(value:  true);
            this.AnimatorProgress.Play(stateName:  "ResultProgressAllShow");
            this.LevelProgress.SetProgress(currentLevelIndex:  this._curLevelIndex + 1, levelCount:  this._levelCount, isExist:  false);
            this.LevelProgress.PlayAddProgressAni(isExist:  false);
        }
        private void <PlayLevelContentAni>b__22_1()
        {
            if(this._isAllPass != false)
            {
                    Message.Messager.Dispatch(cmd:  80);
                this.Bottoms.gameObject.SetActive(value:  false);
                return;
            }
            
            this.Bottoms.gameObject.SetActive(value:  true);
            this.Bottoms.PlayShowBottomAni();
        }
        private void <PlayChapterAni>b__23_0()
        {
            this.Bottoms.gameObject.SetActive(value:  true);
            this.Bottoms.ShowBottoms();
            this.Bottoms.PlayShowBottomAni();
        }
    
    }

}
