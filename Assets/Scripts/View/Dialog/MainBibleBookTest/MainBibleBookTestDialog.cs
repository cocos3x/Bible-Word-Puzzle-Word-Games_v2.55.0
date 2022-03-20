using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleBookTestDialog : Dialog
    {
        // Fields
        private const string NextLevel = "38";
        private const string Continue = "73";
        private const string GoToQuiz = "231";
        private const string BookPageFormat = " <#4c1600>{0}</color>";
        private const float TimeDelayUnlock = 0.6;
        private const float TimeDelayUnlockEnd = 1;
        public UnityEngine.Animator AnimatorBible;
        public Spine.Unity.SkeletonGraphic SkeletonGraphicBible;
        public View.Dialog.MainBibleBookTest.MainBibleBookInfo BibleBookInfo;
        public View.Dialog.MainBibleBookTest.MainBibleBookMap BibleBookMap;
        public TMPro.TextMeshProUGUI TextBookPage;
        public UnityEngine.UI.Button ButtonLeft;
        public UnityEngine.UI.Button ButtonRight;
        public TMPro.TextMeshProUGUI TextLeft;
        public TMPro.TextMeshProUGUI TextRight;
        public TMPro.TextMeshProUGUI TextCenter;
        private Data.Bible.BibleOpenFrom _openFrom;
        private int _currentSectionIndex;
        private bool _isShowAni;
        
        // Methods
        public void OnClickLeftButton()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "verse_collect", action:  "switch_chapter", label:  "left", value:  0);
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_1.<IsPlayPageAni>k__BackingField) != false)
            {
                    return;
            }
            
            int val_4 = this._currentSectionIndex;
            val_4 = val_4 - 1;
            this._currentSectionIndex = val_4;
            Data.Bible.BibleDataManager val_2 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_2.<IsPageForward>k__BackingField = true;
            Data.Bible.BibleDataManager val_3 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_3.<IsPlayPageAni>k__BackingField = true;
            this.SetSwitchButtonState(isEnable:  false);
            this.AnimatorBible.Play(stateName:  "BibleContentPage");
        }
        public void OnClickRightButton()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "verse_collect", action:  "switch_chapter", label:  "right", value:  0);
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_1.<IsPlayPageAni>k__BackingField) != false)
            {
                    return;
            }
            
            int val_4 = this._currentSectionIndex;
            val_4 = val_4 + 1;
            this._currentSectionIndex = val_4;
            Data.Bible.BibleDataManager val_2 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_2.<IsPageForward>k__BackingField = false;
            Data.Bible.BibleDataManager val_3 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_3.<IsPlayPageAni>k__BackingField = true;
            this.SetSwitchButtonState(isEnable:  false);
            this.AnimatorBible.Play(stateName:  "BibleContentPage");
        }
        public void OnClickCenterButton()
        {
            if(this._openFrom == 0)
            {
                    Message.Messager.Dispatch(cmd:  50);
            }
            
            this.PlayHideBibleContentAni();
        }
        public override void OnTransmitParams(object[] pars)
        {
            var val_15;
            var val_16;
            int val_17;
            TMPro.TextMeshProUGUI val_18;
            string val_19;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            this.OnTransmitParams(pars:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this._openFrom = Common.GlobalMethods.GetBaseVale<Data.Bible.BibleOpenFrom>(inputs:  pars, idx:  0, defaultVal:  0);
            int val_5 = Logic.Game.GameManager.gameBible.GetCurrentBibleSectionIndex(sectionIndex:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) - 1);
            this._currentSectionIndex = val_5;
            Data.Bean.BibleSection val_6 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  val_5);
            if(this._openFrom != 0)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "verse_collect", action:  "page_show", label:  "game", value:  0);
                val_16 = val_6.collectCount;
                val_17 = this._currentSectionIndex;
                if(val_16 == val_6.maxCount)
            {
                    val_17 = val_17 + 1;
                this._currentSectionIndex = val_17;
            }
            
                this._currentSectionIndex = val_17;
                Data.Bible.BibleDataManager val_9 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
                val_9.<IsExistCollectAni>k__BackingField = false;
                val_18 = this.TextCenter;
                val_19 = "73";
            }
            else
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "verse_collect", action:  "page_show", label:  "result", value:  0);
                Data.Bible.BibleDataManager val_10 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
                val_10.<IsExistCollectAni>k__BackingField = true;
                val_18 = this.TextCenter;
                val_19 = "38";
            }
            
            val_18.text = Locale.LocaleManager.Translate(key:  val_19);
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.IsInQuizLevel) != false)
            {
                    this.TextCenter.text = Locale.LocaleManager.Translate(key:  "231");
            }
            
            this._isShowAni = true;
            Logic.Game.GameManager.gameMusic.Pause(pause:  false);
            this.UpdateBibleBook();
            this.PlayBibleOpenAni();
        }
        private void UpdateBibleBook()
        {
            if()
            {
                    Data.Bean.BibleSection val_3 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  this._currentSectionIndex - 1);
                this.ButtonLeft.gameObject.SetActive(value:  true);
                if(this.ButtonLeft == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this.TextLeft.text = 1;
            }
            else
            {
                    this.ButtonLeft.gameObject.SetActive(value:  false);
            }
            
            if(this._currentSectionIndex < (Logic.Game.GameManager.gameBible.GetBibleSectionCount() - 1))
            {
                    Data.Bean.BibleSection val_8 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  this._currentSectionIndex + 1);
                this.ButtonRight.gameObject.SetActive(value:  true);
                if(this.ButtonRight == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this.TextRight.text = 1;
            }
            else
            {
                    this.ButtonRight.gameObject.SetActive(value:  false);
            }
            
            Data.Bible.BibleDataManager val_11 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_11.<IsPlayPageAni>k__BackingField) != true)
            {
                    this.SetSwitchButtonState(isEnable:  true);
            }
            
            int val_15 = this._currentSectionIndex;
            val_15 = val_15 + 1;
            this.TextBookPage.text = Locale.LocaleManager.Translate(key:  "70")(Locale.LocaleManager.Translate(key:  "70")) + System.String.Format(format:  " <#4c1600>{0}</color>", arg0:  val_15)(System.String.Format(format:  " <#4c1600>{0}</color>", arg0:  val_15));
            this.BibleBookInfo.UpdateBibleBookInfo(bibleSectionIndex:  this._currentSectionIndex);
            this.BibleBookMap.UpdateBibleBookMap(bibleSectionIndex:  this._currentSectionIndex);
        }
        private void PlayBibleOpenAni()
        {
            this.ClearAnimationState();
            this.AnimatorBible.Play(stateName:  "BibleContentOpen");
            this.PlaySkeletonAnimation(trackIndex:  0, name:  "bible_open");
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::OpenAniEnd()));
            Common.TimerEvent.Add(time:  0.58f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::OpenAniEnd()), isrepeat:  false);
        }
        private void OpenAniEnd()
        {
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  false);
        }
        private void PlayBiblePageForwardAni()
        {
            Logic.Game.GameManager.gameSound.Play(clipName:  "bible_swipe_back", volumeScale:  1f, loop:  false, delay:  0f);
            this.ClearAnimationState();
            this.PlaySkeletonAnimation(trackIndex:  1, name:  "bible_page_forward");
        }
        private void PlayBiblePageBackwardAni()
        {
            Logic.Game.GameManager.gameSound.Play(clipName:  "bible_swipe", volumeScale:  1f, loop:  false, delay:  0f);
            this.ClearAnimationState();
            this.PlaySkeletonAnimation(trackIndex:  2, name:  "bible_page_backward");
        }
        private void PlaySkeletonAnimation(int trackIndex, string name)
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  0f);
            this.SkeletonGraphicBible.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            Spine.TrackEntry val_3 = this.SkeletonGraphicBible.AnimationState.SetAnimation(trackIndex:  trackIndex, animationName:  name, loop:  false);
            UnityEngine.Coroutine val_5 = Utils.Extensions.MonoBehaviourExtension.WaitFramesDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::<PlaySkeletonAnimation>b__28_0()), frames:  1);
        }
        private void ClearAnimationState()
        {
            this.SkeletonGraphicBible.startingAnimation = 0;
            this.SkeletonGraphicBible.Skeleton.SetToSetupPose();
            this.SkeletonGraphicBible.AnimationState.ClearTracks();
        }
        private void BibleContentOpenCallback()
        {
            this.AnimatorBible.Play(stateName:  "BibleContentShowTop");
        }
        private void BibleContentShowTopCallback()
        {
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_1.<IsPlayPageAni>k__BackingField) != false)
            {
                    this.SetSwitchButtonState(isEnable:  true);
                Data.Bible.BibleDataManager val_2 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
                val_2.<IsPlayPageAni>k__BackingField = false;
                return;
            }
            
            Data.Bible.BibleDataManager val_3 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_3.<IsExistCollectAni>k__BackingField) != false)
            {
                    this.BibleBookMap.PlayCollectBibleAni();
                return;
            }
            
            this.AnimatorBible.Play(stateName:  "BibleContentShowBottom");
            this.SetSwitchButtonState(isEnable:  false);
        }
        private void BibleContentShowBottomCallback()
        {
            this.BibleBookMap.CheckNewGuide();
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_1.<IsExistCollectAni>k__BackingField = false;
            this._isShowAni = false;
            this.SetSwitchButtonState(isEnable:  true);
        }
        private void CollectAllVerseFromSection()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.6f);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::<CollectAllVerseFromSection>b__33_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::<CollectAllVerseFromSection>b__33_1()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_2, id:  this);
        }
        private void ShowBibleContentBottom()
        {
            this.SetSwitchButtonState(isEnable:  false);
            this.AnimatorBible.Play(stateName:  "BibleContentShowBottom");
        }
        private void BibleContentHideCallback()
        {
            goto typeof(View.Dialog.MainBibleBookTest.MainBibleBookTestDialog).__il2cppRuntimeField_1E0;
        }
        private void BibleContentPageUpdate()
        {
            this.UpdateBibleBook();
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_1.<IsPageForward>k__BackingField) != false)
            {
                    this.PlayBiblePageForwardAni();
                return;
            }
            
            this.PlayBiblePageBackwardAni();
        }
        private void BibleContentPageCallback()
        {
            this.AnimatorBible.Play(stateName:  "BibleContentShowTop");
        }
        private void PlayHideBibleContentAni()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::OpenAniEnd()));
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  true);
            this.AnimatorBible.Play(stateName:  "BibleContentHide");
        }
        private void SetSwitchButtonState(bool isEnable)
        {
            bool val_1 = isEnable;
            this.ButtonLeft.enabled = val_1;
            this.ButtonRight.enabled = val_1;
        }
        private void ResetBibleBook()
        {
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_1.<IsPlayPageAni>k__BackingField = false;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add(cmd:  14, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentOpenCallback()));
            Message.Messager.Add(cmd:  15, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentShowTopCallback()));
            Message.Messager.Add(cmd:  16, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentShowBottomCallback()));
            Message.Messager.Add(cmd:  17, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentHideCallback()));
            Message.Messager.Add(cmd:  19, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentPageUpdate()));
            Message.Messager.Add(cmd:  18, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentPageCallback()));
            Message.Messager.Add(cmd:  20, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::CollectAllVerseFromSection()));
            Message.Messager.Add(cmd:  21, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::ShowBibleContentBottom()));
            Message.Messager.Dispatch(cmd:  75);
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  14, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentOpenCallback()));
            Message.Messager.Remove(cmd:  15, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentShowTopCallback()));
            Message.Messager.Remove(cmd:  16, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentShowBottomCallback()));
            Message.Messager.Remove(cmd:  17, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentHideCallback()));
            Message.Messager.Remove(cmd:  19, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentPageUpdate()));
            Message.Messager.Remove(cmd:  18, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::BibleContentPageCallback()));
            Message.Messager.Remove(cmd:  20, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::CollectAllVerseFromSection()));
            Message.Messager.Remove(cmd:  21, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::ShowBibleContentBottom()));
            Message.Messager.Dispatch(cmd:  74);
            this.ResetBibleBook();
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookTestDialog::OpenAniEnd()));
            Resource.ResManager.ForceUnloadAssets();
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            Data.Bible.BibleDataManager val_2 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_2.<IsExistCollectAni>k__BackingField) == true)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameType(type:  2)) == true)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameTypeLast(type:  W21, name:  this.name)) == false)
            {
                    return;
            }
            
            if(this._openFrom == 0)
            {
                    Message.Messager.Dispatch(cmd:  50);
            }
            
            this.PlayHideBibleContentAni();
        }
        public MainBibleBookTestDialog()
        {
        
        }
        private void <PlaySkeletonAnimation>b__28_0()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.SkeletonGraphicBible.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        private void <CollectAllVerseFromSection>b__33_0()
        {
            if(this.BibleBookInfo != null)
            {
                    this.BibleBookInfo.PlayUnLockAni();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <CollectAllVerseFromSection>b__33_1()
        {
            Data.Bible.BibleDataManager val_2 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_2.<IsExistCollectAni>k__BackingField = false;
            int val_5 = this._currentSectionIndex;
            if(val_5 < (Logic.Game.GameManager.gameBible.GetBibleSectionCount() - 1))
            {
                    val_5 = val_5 + 1;
                this._currentSectionIndex = val_5;
                Data.Bible.BibleDataManager val_4 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
                val_4.<IsPageForward>k__BackingField = false;
                this.AnimatorBible.Play(stateName:  "BibleContentPage");
                this.PlayBiblePageBackwardAni();
                return;
            }
            
            Message.Messager.Dispatch(cmd:  50);
            this.PlayHideBibleContentAni();
        }
    
    }

}
