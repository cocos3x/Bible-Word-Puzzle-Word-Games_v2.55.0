using UnityEngine;

namespace View.Dialog.PersonalInfo
{
    public class PersonalInfoDialog : Dialog
    {
        // Fields
        private const float ScaleTime = 0.25;
        private const float ScaleTime_2 = 0.15;
        private const float MoveDayTime = 0.6;
        private const float FadeTime = 0.3;
        public UnityEngine.CanvasGroup CanvasGroupContent;
        public UnityEngine.UI.Button ButtonClose;
        public UnityEngine.UI.Text dayText;
        public UnityEngine.UI.Text socreText;
        public UnityEngine.UI.Text wordText;
        public UnityEngine.UI.Text levelText;
        public UnityEngine.UI.Text verseText;
        public UnityEngine.UI.Text bookText;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text DayDesText;
        public UnityEngine.UI.Text ScoreDesText;
        public UnityEngine.UI.Text WordDesText;
        public UnityEngine.UI.Text LevelDesText;
        public UnityEngine.UI.Text VerseDesText;
        public UnityEngine.UI.Text BooksDesText;
        public UnityEngine.UI.Text TipsText;
        public TMPro.TMP_Text SunText;
        public TMPro.TMP_Text MonText;
        public TMPro.TMP_Text TuesText;
        public TMPro.TMP_Text WednesText;
        public TMPro.TMP_Text ThursText;
        public TMPro.TMP_Text FirText;
        public TMPro.TMP_Text SaturText;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.ButtonClose.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void View.Dialog.PersonalInfo.PersonalInfoDialog::OnClickCloseButton()));
        }
        protected override void OnEnable()
        {
            mem[1152921512722821964] = 0;
            this.OnEnable();
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "98");
            string val_2 = Locale.LocaleManager.Translate(key:  "99");
            string val_3 = Locale.LocaleManager.Translate(key:  "100");
            string val_4 = Locale.LocaleManager.Translate(key:  "101");
            string val_5 = Locale.LocaleManager.Translate(key:  "102");
            string val_6 = Locale.LocaleManager.Translate(key:  "103");
            string val_7 = Locale.LocaleManager.Translate(key:  "104");
            string val_8 = Locale.LocaleManager.Translate(key:  "105");
            this.SunText.text = Locale.LocaleManager.Translate(key:  "207");
            this.MonText.text = Locale.LocaleManager.Translate(key:  "208");
            this.TuesText.text = Locale.LocaleManager.Translate(key:  "209");
            this.WednesText.text = Locale.LocaleManager.Translate(key:  "210");
            this.ThursText.text = Locale.LocaleManager.Translate(key:  "211");
            this.FirText.text = Locale.LocaleManager.Translate(key:  "212");
            this.SaturText.text = Locale.LocaleManager.Translate(key:  "213");
        }
        public override View.Dialog.Common.Dialog Open()
        {
            string val_3 = Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginDays.ToString();
            string val_6 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GameScore.ToString();
            string val_9 = Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.GetAllConnectWord().ToString();
            string val_12 = Common.Singleton<Data.Bible.BibleDataManager>.Instance.BookCollectCount.ToString();
            string val_15 = Common.Singleton<Data.Bible.BibleDataManager>.Instance.VerseCollectCount.ToString();
            string val_22 = (Logic.Game.GameManager.gameLevel.GetPassLevel(unlockSectionIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex, unlockLevelIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex)) + 1.ToString();
            this.dayText.gameObject.SetActive(value:  true);
            this.UpdateDialogState();
            return (View.Dialog.Common.Dialog)this.Open();
        }
        public override void Close()
        {
            this.CloseAniFromActive(onComplete:  new System.Action(object:  this, method:  System.Void View.Dialog.PersonalInfo.PersonalInfoDialog::<Close>b__31_0()));
        }
        public void OnClickCloseButton()
        {
            goto typeof(View.Dialog.PersonalInfo.PersonalInfoDialog).__il2cppRuntimeField_1E0;
        }
        private void OpenAni()
        {
            this.CanvasGroupContent.alpha = 1f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  0f, g:  0f, b:  0f, a:  0.7f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished, endValue:  0f, duration:  0.5f))), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.25f)), ease:  27));
        }
        private void CloseAniFromActive(System.Action onComplete)
        {
            typeof(PersonalInfoDialog.<>c__DisplayClass34_0).__il2cppRuntimeField_10 = onComplete;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished, endValue:  0f, duration:  0.3f)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  26)), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void PersonalInfoDialog.<>c__DisplayClass34_0::<CloseAniFromActive>b__0()));
        }
        private void UpdateDialogState()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.dayText.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.ButtonClose.gameObject.SetActive(value:  true);
            this.OpenAni();
        }
        public PersonalInfoDialog()
        {
        
        }
        private void <Close>b__31_0()
        {
            this.Close();
        }
    
    }

}
