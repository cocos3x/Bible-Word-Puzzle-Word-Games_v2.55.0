using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultLevelContent : UIElement
    {
        // Fields
        private const float TimeAlpha_2 = 0.5;
        private const string TitleLevel = "result_title_levelclear";
        private const string TitleChapter = "result_title_chapterclear";
        public UnityEngine.Animator AnimatorTitle;
        public UnityEngine.Animator AnimatorProgress;
        public UnityEngine.UI.Image ImageTitle;
        public UnityEngine.GameObject EffectTitle;
        public View.Dialog.Result.BibleBooks Books;
        public View.Dialog.Result.ResultFaiths Faiths;
        public View.Dialog.Result.ResultLevelProgress LevelProgress;
        public UnityEngine.CanvasGroup CanvasGroupContent;
        public View.Dialog.Result.ResultBottoms Bottoms;
        private int _sectionLevelCount;
        private bool _isLastLevel;
        private bool _isSectionPass;
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
            this.Faiths.LocaleTranslate();
            this.Bottoms.LocaleTranslate();
        }
        public void ShowLevelContent(bool isSectionPass, int sectionLevelCount, bool isLastLevel)
        {
            this._sectionLevelCount = sectionLevelCount;
            this._isLastLevel = isLastLevel;
            this._isSectionPass = isSectionPass;
            this.gameObject.SetActive(value:  true);
            this.EffectTitle.SetActive(value:  false);
            this.SetTitle(isLastLevel:  false);
            this.Books.gameObject.SetActive(value:  false);
            this.Faiths.gameObject.SetActive(value:  false);
            this.AnimatorProgress.gameObject.SetActive(value:  false);
            this.Bottoms.gameObject.SetActive(value:  false);
            this.CanvasGroupContent.alpha = 1f;
            if(this._isLastLevel != false)
            {
                    this.CanvasGroupContent.alpha = 1f;
                this.PlayOpenBookAni();
            }
            else
            {
                    this.SetNotLast();
            }
            
            this.Bottoms.ShowBottoms(isSectionPass:  this._isSectionPass);
        }
        public void ShowChapterContent(Data.Bean.BibleSection bibleSection)
        {
            this.gameObject.SetActive(value:  true);
            this.EffectTitle.SetActive(value:  false);
            this.CanvasGroupContent.alpha = 0f;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupContent, endValue:  1f, duration:  0.5f);
            this.Books.PlayShowBookAni();
            this.SetTitle(isLastLevel:  true);
            this.LevelProgress.gameObject.SetActive(value:  false);
            Common.SingletonController<Logic.Game.GameControllers>.Instance.ScoreUpdateData(score:  100);
            Logic.Game.GameControllers val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            this.Faiths.SetFaith(value:  val_5.<OldScore>k__BackingField);
            this.PlayChapterAni();
        }
        private void SetTitle(bool isLastLevel)
        {
            if((System.String.IsNullOrEmpty(value:  this._atlasName)) != false)
            {
                    return;
            }
            
            this.ImageTitle.sprite = Resource.ResManager.GetSpriteFromPool(atlas:  this._atlasName, spriteName:  (isLastLevel != true) ? "result_title_chapterclear" : "result_title_levelclear");
        }
        public void HideLevelContent(System.Action callback, bool isToBible)
        {
            typeof(ResultLevelContent.<>c__DisplayClass20_0).__il2cppRuntimeField_10 = this;
            typeof(ResultLevelContent.<>c__DisplayClass20_0).__il2cppRuntimeField_18 = callback;
            if(isToBible == false)
            {
                    return;
            }
            
            this.LevelProgress.PlayFlyReelAni(callback:  new System.Action(object:  new System.Object(), method:  System.Void ResultLevelContent.<>c__DisplayClass20_0::<HideLevelContent>b__0()));
        }
        public void PlayHideBookAni()
        {
            if(this.Books != null)
            {
                    this.Books.PlayHideBookAni();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayCollectBookEffect()
        {
            if(this.Books != null)
            {
                    this.Books.PlayBookEffect();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void PlayFaithAddAni(bool isLevel)
        {
            this.Faiths.PlayFaithAni(endValue:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GameScore, isLevel:  isLevel);
        }
        private void SetNotLast()
        {
            this.AnimatorTitle.Play(stateName:  "ResultTitleAni");
            this.EffectTitle.SetActive(value:  true);
            this.Bottoms.gameObject.SetActive(value:  true);
        }
        private void PlayOpenBookAni()
        {
            var val_26;
            DG.Tweening.TweenCallback val_28;
            var val_29;
            DG.Tweening.TweenCallback val_31;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            this.Faiths.SetFaith(value:  val_1.<OldScore>k__BackingField);
            this.AnimatorTitle.Play(stateName:  "ResultTitleAni");
            this.EffectTitle.SetActive(value:  true);
            this.Books.PlayOpenBookAni();
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  1f);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Result.ResultLevelContent::<PlayOpenBookAni>b__25_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  1.4f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Result.ResultLevelContent::<PlayOpenBookAni>b__25_1()));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  1.6f);
            if(this._isSectionPass != true)
            {
                    if((Common.SingletonController<Logic.PiggyBank.PiggyBankController>.Instance.ShouldHavePiggyBankForResult()) != false)
            {
                    val_26 = null;
                val_26 = null;
                val_28 = ResultLevelContent.<>c.<>9__25_2;
                if(val_28 == null)
            {
                    DG.Tweening.TweenCallback val_13 = null;
                val_28 = val_13;
                val_13 = new DG.Tweening.TweenCallback(object:  ResultLevelContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ResultLevelContent.<>c::<PlayOpenBookAni>b__25_2());
                ResultLevelContent.<>c.<>9__25_2 = val_28;
            }
            
                DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_28);
                DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  2f);
            }
            
                if(((this._isSectionPass != true) && ((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpenForResult()) != false)) && ((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) != true))
            {
                    val_29 = null;
                val_29 = null;
                val_31 = ResultLevelContent.<>c.<>9__25_3;
                if(val_31 == null)
            {
                    DG.Tweening.TweenCallback val_20 = null;
                val_31 = val_20;
                val_20 = new DG.Tweening.TweenCallback(object:  ResultLevelContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ResultLevelContent.<>c::<PlayOpenBookAni>b__25_3());
                ResultLevelContent.<>c.<>9__25_3 = val_31;
            }
            
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_31);
                DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  2f);
            }
            
            }
            
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Result.ResultLevelContent::<PlayOpenBookAni>b__25_4()));
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_3, id:  this);
        }
        private void PlayChapterAni()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Result.ResultLevelContent::<PlayChapterAni>b__26_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Result.ResultLevelContent::<PlayChapterAni>b__26_1()));
        }
        public ResultLevelContent()
        {
        
        }
        private void <PlayOpenBookAni>b__25_0()
        {
            this.PlayFaithAddAni(isLevel:  true);
        }
        private void <PlayOpenBookAni>b__25_1()
        {
            this.AnimatorProgress.gameObject.SetActive(value:  true);
            this.AnimatorProgress.Play(stateName:  "ResultProgressAllShow");
            this.LevelProgress.gameObject.SetActive(value:  true);
            Data.UserPlayer.UserPlayerDataManager val_3 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            this.LevelProgress.SetProgress(currentLevelIndex:  val_3.<CurrentLevelIndex>k__BackingField, sectionLevelCount:  this._sectionLevelCount);
            this.LevelProgress.PlayAddProgressAni();
        }
        private void <PlayOpenBookAni>b__25_4()
        {
            if(this._isSectionPass != false)
            {
                    Message.Messager.Dispatch(cmd:  80);
                this.Bottoms.gameObject.SetActive(value:  false);
                return;
            }
            
            this.Bottoms.gameObject.SetActive(value:  true);
            this.Bottoms.PlayShowBottomAni();
        }
        private void <PlayChapterAni>b__26_0()
        {
            this.PlayFaithAddAni(isLevel:  false);
        }
        private void <PlayChapterAni>b__26_1()
        {
            this.Bottoms.gameObject.SetActive(value:  true);
            this.Bottoms.ShowBottoms(isSectionPass:  true);
            this.Bottoms.PlayShowBottomAni();
        }
    
    }

}
