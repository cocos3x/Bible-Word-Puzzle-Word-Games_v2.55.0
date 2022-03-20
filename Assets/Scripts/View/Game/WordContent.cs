using UnityEngine;

namespace View.Game
{
    public class WordContent : MonoBehaviour
    {
        // Fields
        private const int NotFoundAnswerTimeHint = 30;
        private const float WordHeight = 230;
        private const string BonusLengthTips = "131";
        private const string AlreadyTips = "30";
        private const string AlreadyExtraTips = "194";
        private const string ExtraNotAvailable = "Extra words are not available";
        public View.CommonItem.Word wordPrefab;
        public float wordVerticalRatioSpacing;
        public float wordHorizontalRatioSpacing;
        public float letterRatioSpacing;
        public float maxSize;
        public UnityEngine.GameObject selectedPanelObj;
        public View.CommonItem.HintButton hintButton;
        public bool isComplete;
        private float width;
        private float height;
        private System.Collections.Generic.List<View.CommonItem.Word> words;
        private System.Collections.Generic.HashSet<int> wordsLengthSet;
        private string lastFailWord;
        private int allFailCount;
        private int comboCount;
        private int continuousFailCount;
        private int checkAnswerCount;
        private int <answerCount>k__BackingField;
        private View.CommonItem.Word _word;
        private View.CommonItem.Word _wordTemp;
        private System.Collections.Generic.List<View.CommonItem.LetterBox> _tempLetterBoxes;
        private System.Collections.Generic.List<View.CommonItem.LetterBox> letterBoxes;
        private View.CommonItem.Combo.ComboNormal combo;
        
        // Properties
        private int answerCount { get; set; }
        
        // Methods
        private int get_answerCount()
        {
            return (int)this.<answerCount>k__BackingField;
        }
        private void set_answerCount(int value)
        {
            this.<answerCount>k__BackingField = value;
        }
        public void InitWordContent()
        {
            var val_52;
            View.CommonItem.Word val_53;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            float val_58;
            bool val_59;
            this.ClearWordContent();
            this.InitSize();
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._levelBean == null)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            System.Collections.Generic.List<System.String> val_3 = val_2._levelBean.answerList;
            if(val_1._levelBean == null)
            {
                    return;
            }
            
            int val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelAnswerListCount();
            var val_6 = (val_5 >= 11) ? (2 + 1) : 2;
            var val_7 = (val_5 >= 5) ? (val_6) : (0 + 1);
            float val_49 = (float)val_5;
            val_49 = val_49 / (float)val_7;
            var val_8 = W24 - 1;
            var val_50 = 0;
            int val_9 = val_5 - 1;
            do
            {
                val_50 = val_50 + 1;
                val_52 = (Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelAnswerCount(index:  (val_8 < val_5) ? (val_8) : (val_9))) + 0;
                val_53 = val_8 + W24;
            }
            while(val_50 < val_7);
            
            float val_53 = this.wordVerticalRatioSpacing;
            float val_51 = this.wordHorizontalRatioSpacing;
            float val_52 = this.letterRatioSpacing;
            val_6 = val_52 - val_7;
            val_51 = val_51 * ((float)val_7 - 1);
            val_52 = val_52 * (float)val_6;
            float val_14 = this.height / (float)W24;
            val_53 = val_14 * val_53;
            val_51 = val_51 + val_52;
            val_53 = val_53 + 230f;
            float val_15 = val_51 + (float)val_52;
            val_53 = val_14 / val_53;
            float val_19 = UnityEngine.Mathf.Min(a:  this.maxSize, b:  UnityEngine.Mathf.Min(a:  this.width / val_15, b:  S12 * 230f));
            val_55 = this.width;
            this.wordsLengthSet.Clear();
            if(val_5 >= 1)
            {
                    val_19 = val_15 * val_19;
                val_56 = -0.5f;
                val_19 = val_55 - val_19;
                val_57 = 0f;
                val_54 = val_19 * 0.5f;
                do
            {
                Logic.Game.GameControllers val_21 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                System.Collections.Generic.List<System.String> val_22 = val_21._levelBean.answerList;
                if(1152921512643510624 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((this.wordsLengthSet.Contains(item:  public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10>>0&0xFFFFFFFF)) != true)
            {
                    bool val_24 = this.wordsLengthSet.Add(item:  public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10>>0&0xFFFFFFFF);
            }
            
                var val_27 = 0 - ((0 / W24) * W24);
                var val_54 = -val_27;
                val_54 = (val_8 + 0) + val_54;
                int val_30 = Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelAnswerCount(index:  (val_54 < val_5) ? (val_54) : (val_9));
                val_58 = val_54 + val_57;
                if(val_5 <= 4)
            {
                    float val_55 = this.letterRatioSpacing;
                val_56 = (float)(val_30 - public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10);
                val_55 = val_55 + 1f;
                val_55 = val_55 * val_56;
                val_55 = val_19 * val_55;
                val_55 = val_55 * 0.5f;
                val_58 = val_58 + val_55;
            }
            
                if((val_27 + 1) == W24)
            {
                    float val_57 = this.wordHorizontalRatioSpacing;
                float val_56 = this.letterRatioSpacing;
                val_56 = val_56 * ((float)(public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10 - 1));
                val_56 = val_56 + ((float)public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10);
                val_57 = val_57 + val_56;
                val_57 = val_19 * val_57;
                val_57 = val_57 + val_57;
            }
            
                if(0 < (val_5 - (Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonusCount())))
            {
                    val_59 = 0;
            }
            else
            {
                    val_59 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0);
            }
            
                View.CommonItem.Word val_40 = View.CommonItem.Word.Create(parent:  this.transform, wordPrefab:  this.wordPrefab, isBonus:  val_59, word:  public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext());
                float val_58 = (float)val_27;
                val_58 = val_14 * val_58;
                val_55 = (val_14 * val_56) - val_58;
                val_53 = val_40;
                val_40.size = val_19;
                val_53.spacing = this.letterRatioSpacing;
                UnityEngine.Vector3 val_41 = new UnityEngine.Vector3(x:  val_58, y:  val_55);
                val_53.anchoredPosition = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z};
                this.words.Add(item:  val_53);
                val_52 = 0 + 1;
            }
            while(val_52 < val_5);
            
            }
            
            if((Platform.AbTest.GameABTestManager.IsGameSoundTest() != true) && ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false))
            {
                    if((Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonus()) != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "bonus_level_start", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            }
            
            Data.ButterFly.ButterFlyDataManager val_47 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            val_47.<LevelChrysalisMaxCount>k__BackingField = (val_5 > 10) ? (2 + 1) : 2;
            this.RestoreLevelProgress();
            this.isComplete = false;
            this.CheckLetterGift();
        }
        private void InitSize()
        {
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            UnityEngine.Transform val_3 = this.transform.parent;
            if(val_3 != null)
            {
                    if(null != null)
            {
                goto label_5;
            }
            
            }
            
            UnityEngine.Transform val_6 = this.transform.parent.parent;
            if(null == null)
            {
                    UnityEngine.Rect val_7 = val_6.rect;
                UnityEngine.Vector2 val_9 = val_1.offsetMax;
                UnityEngine.Vector2 val_10 = val_3.offsetMax;
                UnityEngine.Vector2 val_11 = val_1.offsetMin;
                UnityEngine.Vector2 val_12 = val_3.offsetMin;
                float val_13 = val_7.m_XMin.width + val_9.x;
                val_13 = val_13 + val_10.x;
                val_13 = val_13 - val_11.x;
                val_12.x = val_13 - val_12.x;
                this.width = val_12.x;
                UnityEngine.Rect val_14 = val_6.rect;
                UnityEngine.Vector2 val_16 = val_1.offsetMax;
                UnityEngine.Vector2 val_17 = val_3.offsetMax;
                UnityEngine.Vector2 val_18 = val_1.offsetMin;
                UnityEngine.Vector2 val_19 = val_3.offsetMin;
                float val_20 = val_14.m_XMin.height + val_16.y;
                val_20 = val_20 + val_17.y;
                val_20 = val_20 - val_18.y;
                val_20 = val_20 - val_19.y;
                this.height = val_20;
                return;
            }
            
            label_2:
            label_5:
        }
        private void CheckLetterGift()
        {
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_3 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
                if((val_3.<IsHaveLetterGiftFromGame>k__BackingField) != false)
            {
                    this.CheckLetterGiftBoxPos();
            }
            
            }
            
            Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance.ClearLetterGiftCount();
        }
        private void CheckChrysalisBox()
        {
            var val_24;
            var val_25;
            var val_26;
            System.Predicate<View.CommonItem.Word> val_28;
            var val_29;
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpen()) == false)
            {
                    return;
            }
            
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) == true)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            val_24 = 1152921512618525072;
            Data.ButterFly.ButterFlyDataManager val_9 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) >= (val_9.<LevelChrysalisMaxCount>k__BackingField))
            {
                    return;
            }
            
            Data.ButterFly.ButterFlyDataManager val_10 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            val_24 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount;
            this._tempLetterBoxes.Clear();
            val_25 = 1152921504800669696;
            val_26 = null;
            val_26 = null;
            val_28 = WordContent.<>c.<>9__34_0;
            if(val_28 == null)
            {
                    System.Predicate<View.CommonItem.Word> val_13 = null;
                val_28 = val_13;
                val_13 = new System.Predicate<View.CommonItem.Word>(object:  WordContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WordContent.<>c::<CheckChrysalisBox>b__34_0(View.CommonItem.Word x));
                WordContent.<>c.<>9__34_0 = val_28;
            }
            
            System.Collections.Generic.List<T> val_14 = this.words.FindAll(match:  val_28);
            if(val_14 == null)
            {
                    return;
            }
            
            int val_15 = (val_10.<LevelChrysalisMaxCount>k__BackingField) - val_24;
            if(val_28 < val_15)
            {
                    return;
            }
            
            if(val_15 < 1)
            {
                    return;
            }
            
            val_25 = 1152921512644126288;
            val_29 = 1;
            goto label_22;
            label_32:
            val_29 = 2;
            label_22:
            var val_24 = null;
            int val_18 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Random.Range(min:  0, max:  4739072), min:  0, max:  W27 - 1);
            if(val_24 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = val_24 + (val_18 << 3);
            this._tempLetterBoxes = System.Linq.Enumerable.ToList<View.CommonItem.LetterBox>(source:  (null + (val_18) << 3) + 32.WordIsUnShowLetterBox());
            val_14.RemoveAt(index:  val_18);
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_25 = this._tempLetterBoxes;
            int val_23 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Random.Range(min:  0, max:  val_18), min:  0, max:  val_25 - 1);
            val_24 = val_23;
            if(val_25 <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + (val_24 << 3);
            0.ShowChrysalisBox();
            if(val_29 < val_15)
            {
                goto label_32;
            }
        
        }
        private View.CommonItem.Word FindWordFromTest(string answer)
        {
            UnityEngine.Object val_13;
            WordContent.<>c__DisplayClass35_0 val_1 = new WordContent.<>c__DisplayClass35_0();
            typeof(WordContent.<>c__DisplayClass35_0).__il2cppRuntimeField_10 = answer;
            View.CommonItem.Word val_3 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean WordContent.<>c__DisplayClass35_0::<FindWordFromTest>b__0(View.CommonItem.Word x)));
            this._word = val_3;
            val_13 = val_3;
            if(val_13 != 0)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            if((this.CheckWordLength(answer:  typeof(WordContent.<>c__DisplayClass35_0).__il2cppRuntimeField_10)) == false)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            if((Data.ExtraWordData.ExtraWordDataMngr.IsWordExist(word:  typeof(WordContent.<>c__DisplayClass35_0).__il2cppRuntimeField_10)) == true)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            View.CommonItem.Word val_8 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean WordContent.<>c__DisplayClass35_0::<FindWordFromTest>b__1(View.CommonItem.Word x)));
            this._word = val_8;
            val_13 = val_8;
            if(val_13 == 0)
            {
                    View.CommonItem.Word val_11 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean WordContent.<>c__DisplayClass35_0::<FindWordFromTest>b__2(View.CommonItem.Word x)));
                this._word = val_11;
                val_13 = val_11;
                if(val_13 == 0)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            }
            
            this._word.word = typeof(WordContent.<>c__DisplayClass35_0).__il2cppRuntimeField_10;
            return (View.CommonItem.Word)this._word;
        }
        private void AnswerRight(string answer)
        {
            string val_9;
            float val_10;
            UnityEngine.Vector3 val_2 = this.selectedPanelObj.transform.position;
            this._word.ShowAnswer(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, onComplete:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "finish", value:  0);
            if(this.continuousFailCount < 5)
            {
                    this.AddCombo();
            }
            else
            {
                    this.ShowYouMadeIt();
                if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_9 = "eff_combo_youmadeIt";
            }
            else
            {
                    val_9 = "you_made_it";
            }
            
                Logic.Game.GameManager.gameSound.Play(clipName:  val_9, volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            if((this._word.<isBonus>k__BackingField) != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "bonusword", value:  0);
                Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddBonusWordsCount();
                Platform.Analytics.EzAnalytics.BonusWordsTimes();
                this._word.CollectBonusCoin();
                val_10 = 1f;
            }
            else
            {
                    val_10 = 0f;
            }
            
            this.AddAnswerCount(delayTime:  ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != true) ? 1f : 0f);
            this.hintButton.<time>k__BackingField = UnityEngine.Time.realtimeSinceStartup;
            this.continuousFailCount = 0;
        }
        private void AnswerRepeat(string answer)
        {
            this._word.Shake();
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_word_repeat", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            object[] val_2 = new object[1];
            val_2[0] = Locale.LocaleManager.Translate(key:  "30");
            View.Dialog.Common.Dialog val_4 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_2);
        }
        private void AnswerExtra(string answer)
        {
            Logic.Game.GameDiglog val_9;
            System.Object[] val_10;
            object val_11;
            string val_12;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                goto label_2;
            }
            
            if((Data.ExtraWordData.ExtraWordDataMngr.IsWordExist(word:  answer)) == false)
            {
                goto label_3;
            }
            
            val_9 = Logic.Game.GameManager.gameDialog;
            val_10 = new object[1];
            val_11 = Locale.LocaleManager.Translate(key:  "194");
            val_10[0] = val_11;
            if(val_9 != null)
            {
                goto label_8;
            }
            
            label_2:
            val_9 = Logic.Game.GameManager.gameDialog;
            object[] val_6 = new object[1];
            val_11 = "Extra words are not available";
            val_10 = val_6;
            val_10[0] = "Extra words are not available";
            label_8:
            View.Dialog.Common.Dialog val_7 = val_9.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_6);
            return;
            label_3:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "finish", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "extraword", value:  0);
            this.AddExtraWord(answer:  answer);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_12 = "eff_btn_click";
            }
            else
            {
                    val_12 = "extra_word";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_12, volumeScale:  1f, loop:  false, delay:  0f);
        }
        private void AnswerWrong(string answer)
        {
            string val_12;
            string val_13;
            val_12 = answer;
            this.comboCount = 0;
            if((System.String.IsNullOrEmpty(value:  this.lastFailWord)) != true)
            {
                    if((this.lastFailWord.Equals(value:  val_12)) != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_fail_word", label:  System.String.Format(format:  "{0}_{1}", arg0:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), arg1:  val_12), value:  0);
                val_12 = "";
            }
            
            }
            
            this.lastFailWord = val_12;
            Logic.Game.GameControllers val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            int val_12 = val_5.<NowCurLevelWrongCount>k__BackingField;
            val_12 = val_12 + 1;
            val_5.<NowCurLevelWrongCount>k__BackingField = val_12;
            int val_13 = this.continuousFailCount;
            val_13 = val_13 + 1;
            this.continuousFailCount = val_13;
            if(val_13 == 0)
            {
                    this.hintButton.Light();
            }
            
            if(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false) && (Platform.AbTest.GameABTestManager.IsReward() != false))
            {
                    View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_9 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
                if(((val_9.<IsHaveLetterGiftFromGame>k__BackingField) != true) && (this.continuousFailCount == 3))
            {
                    this.CheckLetterGiftBoxPos();
            }
            
            }
            
            int val_10 = this.allFailCount + 1;
            this.allFailCount = val_10;
            Platform.Analytics.EzAnalytics.FailTimes(failCount:  val_10);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_13 = "eff_word_fail";
            }
            else
            {
                    val_13 = "connect_fail";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_13, volumeScale:  1f, loop:  false, delay:  0f);
        }
        private View.Game.CheckAnswerType CheckAnswerFromTest(string answer)
        {
            var val_7;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_1._levelBean.WordIsAnswer(word:  answer)) == false)
            {
                goto label_3;
            }
            
            View.CommonItem.Word val_3 = this.FindWordFromTest(answer:  answer);
            this._word = val_3;
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
            {
                goto label_6;
            }
            
            if(this._word._isAnswered == false)
            {
                goto label_8;
            }
            
            this.AnswerRepeat(answer:  0);
            val_7 = 1;
            return (View.Game.CheckAnswerType)val_7;
            label_3:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "fail", value:  0);
            this.AnswerWrong(answer:  answer);
            label_13:
            val_7 = 3;
            return (View.Game.CheckAnswerType)val_7;
            label_6:
            if((this.CheckWordLength(answer:  answer)) == false)
            {
                goto label_11;
            }
            
            this.AnswerExtra(answer:  answer);
            val_7 = 2;
            goto label_12;
            label_11:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "fail", value:  0);
            PlayWordLengthTipsAni();
            goto label_13;
            label_8:
            this.AnswerRight(answer:  0);
            val_7 = 0;
            label_12:
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddAllConnectWord();
            return (View.Game.CheckAnswerType)val_7;
        }
        private bool CheckWordLength(string answer)
        {
            return this.wordsLengthSet.Contains(item:  answer.m_stringLength);
        }
        private void GetFireworkWords()
        {
            var val_11;
            var val_12;
            this.letterBoxes.Clear();
            val_11 = 0;
            val_12 = 1;
            label_42:
            if(<0)
            {
                goto label_3;
            }
            
            var val_14 = 0;
            label_40:
            if(1152921512644114000 <= 21247439)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = mem[42494911] + 48;
            if(val_12 != 0)
            {
                goto label_23;
            }
            
            if(val_12 <= 21247439)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 21247471;
            if(((mem[42494911] + 48 + 21247471) + 0) != 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                string val_2 = this.MatchAnswerForWord(word:  0);
                if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                word = val_2;
            }
            
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            View.CommonItem.LetterBox val_6 = GetFireworkLetter();
            if(val_6 == 0)
            {
                goto label_23;
            }
            
            this.letterBoxes.Add(item:  val_6);
            if(1152921512645525600 <= 21247439)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = mem[42440767] + 48;
            if(val_13 != 0)
            {
                    if(val_13 <= 21247439)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + 21247471;
                this._word = (mem[42440767] + 48 + 21247471) + 0;
                Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishWords();
                this.AddAnswerCount(delayTime:  0f);
                Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddAllConnectWord();
                if(1152921512645544032 <= 21247439)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  mem[42461551] + 40);
            }
            else
            {
                    this.SaveLevelProgress(isAnswer:  false);
            }
            
            val_11 = val_11 + 1;
            if(val_11 >= 5)
            {
                goto label_38;
            }
            
            label_23:
            if(21247438 < 0)
            {
                goto label_39;
            }
            
            val_14 = val_14 - 1;
            if(this.words != null)
            {
                goto label_40;
            }
            
            label_39:
            val_12 = val_12;
            label_3:
            var val_11 = val_12 + 1;
            if(val_12 < 5)
            {
                goto label_42;
            }
            
            label_38:
            Message.Messager.Dispatch<System.Collections.Generic.List<View.CommonItem.LetterBox>>(cmd:  101, t:  this.letterBoxes);
        }
        private void PlayWordLengthTipsAni()
        {
            object[] val_1 = new object[1];
            val_1[0] = Locale.LocaleManager.Translate(key:  "131");
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_1);
        }
        public View.Game.CheckAnswerType CheckAnswer(string answer)
        {
            this.checkAnswerCount = this.checkAnswerCount + 1;
            if(this.checkAnswerCount == 0)
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_level_action", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            }
            
            }
            
            if((this.wordsLengthSet.Contains(item:  answer.m_stringLength)) != true)
            {
                    Logic.Game.GameControllers val_6 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                bool val_7 = val_6._levelBean.WordIsAnswer(word:  answer);
                if(val_7 != true)
            {
                    val_7.PlayWordLengthTipsAni();
            }
            
            }
            
            View.Game.CheckAnswerType val_8 = this.CheckAnswerFromTest(answer:  answer);
            if(val_8 != 0)
            {
                    return val_8;
            }
            
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  answer);
            return val_8;
        }
        private void LogEventFailCount()
        {
            if(this.allFailCount < 1)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_fail_times", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName() + "_" + this.allFailCount, value:  0);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddFailCountCurLevel(count:  this.allFailCount);
        }
        private void ShowYouMadeIt()
        {
            int val_6 = this.comboCount;
            val_6 = val_6 + 1;
            this.comboCount = val_6;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(this.comboCount <= (val_2.<NowCurLevelMaxComboCount>k__BackingField))
            {
                    Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                this = val_3.<NowCurLevelMaxComboCount>k__BackingField;
            }
            
            val_1.<NowCurLevelMaxComboCount>k__BackingField = this;
            View.CommonItem.Combo.ComboNormal val_5 = View.Game.GameController.GetInstance().CreatYouMadeIt();
        }
        private void AddCombo()
        {
            int val_6 = this.comboCount;
            val_6 = val_6 + 1;
            this.comboCount = val_6;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(this.comboCount <= (val_2.<NowCurLevelMaxComboCount>k__BackingField))
            {
                    Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                this = val_3.<NowCurLevelMaxComboCount>k__BackingField;
            }
            
            val_1.<NowCurLevelMaxComboCount>k__BackingField = this;
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddCombos();
            Common.TimerEvent.Add(time:  0.15f, callback:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::PlayCombo()), isrepeat:  false);
        }
        private void PlayCombo()
        {
            if(this.comboCount == 0)
            {
                    return;
            }
            
            Logic.Game.GameManager.gameSound.PlayCombo(index:  this.comboCount);
            this.combo = View.Game.GameController.GetInstance().CreateCombo(comboCount:  this.comboCount);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            if(this.comboCount < 2)
            {
                    return;
            }
            
            if((Common.GlobalProperty.GetComboReward(comboCount:  this.comboCount)) < 1)
            {
                    return;
            }
            
            this.Invoke(methodName:  "GainCoin", time:  0.6f);
        }
        private void GainCoin()
        {
            UnityEngine.Vector3 val_4 = this.combo.transform.position;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  Common.GlobalProperty.GetComboReward(comboCount:  this.comboCount), from:  "combo", centerPosition:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, time:  0.5f, delay:  0.2f, onFinish:  0, count:  0);
        }
        private void AddAnswerCount(float delayTime = 0)
        {
            int val_9 = this.<answerCount>k__BackingField;
            val_9 = val_9 + 1;
            this.<answerCount>k__BackingField = val_9;
            if(val_9 == this.words)
            {
                    Message.Messager.Dispatch<System.Single>(cmd:  46, t:  delayTime);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "level_clear", value:  0);
                if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishLevels();
                System.Collections.Generic.List<System.String> val_5 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.GetWords();
                this = Logic.Game.GameManager.gameLevel.GetCurrentLevelName();
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a2_level_extrawords", label:  this + "_" + ???(???), value:  0);
                Data.ExtraWord.ExtraWordDataManager val_8 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance;
                val_8.ClearWords();
            }
            
                val_8.ClearLevelProgress();
                return;
            }
            
            this.SaveLevelProgress(isAnswer:  false);
        }
        private void AddExtraWord(string answer)
        {
            UnityEngine.Vector3 val_2 = this.selectedPanelObj.transform.position;
            Message.Messager.Dispatch<System.String, UnityEngine.Vector3>(cmd:  55, t:  answer, u:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        private void HintClick()
        {
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus) >= 1)
            {
                    this.HintClick(isFree:  true, delay:  0f);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_button_tips_click", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
                Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ReduceHintFreeStatus(hint:  1);
                Message.Messager.Dispatch(cmd:  71);
                this.hintButton.StopHintFree();
                return;
            }
            
            this.HintClick(isFree:  false, delay:  0f);
        }
        public void HintClick(bool isFree, float delay = 0)
        {
            var val_12;
            var val_13;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_1.<IsGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_2._levelBean == null)
            {
                    return;
            }
            
            if(isFree == false)
            {
                goto label_5;
            }
            
            val_12 = null;
            val_12 = null;
            Platform.Analytics.EzAnalytics.SendPropUse(propName:  new PropNameEnum() {<Value>k__BackingField = PropUse.PropNameEnum.PropNameHint});
            goto label_8;
            label_5:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.CostCoins(value:  120, from:  "tips")) == false)
            {
                goto label_10;
            }
            
            val_13 = null;
            val_13 = null;
            Platform.Analytics.EzAnalytics.SendPropUse(propName:  new PropNameEnum() {<Value>k__BackingField = PropUse.PropNameEnum.PropNameHint});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_button_tips_click", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            label_8:
            this.ShowHintWord(delay:  delay);
            return;
            label_10:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_shop_dialog", action:  "a1_dialog_shop_show", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.IsHaveNoviceBankruptcy) != false)
            {
                    object[] val_9 = new object[1];
                val_9[0] = true;
                View.Dialog.Common.Dialog val_10 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "NoviceRewardDialog", pars:  val_9);
                return;
            }
            
            View.Dialog.Common.Dialog val_11 = Logic.Game.GameManager.gameDialog.Open(name:  "ShopTestDialog", type:  0);
        }
        private View.CommonItem.Word FindFirstNotFoundAnswer()
        {
            string val_6;
            var val_7;
            System.Predicate<View.CommonItem.Word> val_9;
            val_6 = this;
            val_7 = null;
            val_7 = null;
            val_9 = WordContent.<>c.<>9__55_0;
            if(val_9 == null)
            {
                    System.Predicate<View.CommonItem.Word> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Predicate<View.CommonItem.Word>(object:  WordContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WordContent.<>c::<FindFirstNotFoundAnswer>b__55_0(View.CommonItem.Word x));
                WordContent.<>c.<>9__55_0 = val_9;
            }
            
            View.CommonItem.Word val_2 = this.words.Find(match:  val_9);
            if(val_2 == 0)
            {
                    return val_2;
            }
            
            string val_4 = this.MatchAnswerForWord(word:  val_2);
            val_6 = val_4;
            if((System.String.IsNullOrEmpty(value:  val_4)) == true)
            {
                    return val_2;
            }
            
            val_2.word = val_6;
            return val_2;
        }
        private string MatchAnswerForWord(View.CommonItem.Word word)
        {
            int val_11;
            var val_12;
            System.Predicate<System.String> val_13;
            IntPtr val_14;
            System.Collections.Generic.List<View.CommonItem.Word> val_15;
            WordContent.<>c__DisplayClass56_0 val_1 = new WordContent.<>c__DisplayClass56_0();
            typeof(WordContent.<>c__DisplayClass56_0).__il2cppRuntimeField_10 = this;
            typeof(WordContent.<>c__DisplayClass56_0).__il2cppRuntimeField_18 = word;
            val_11 = System.String.alignConst;
            if(word.IsEmptyWord() != false)
            {
                    Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                val_12 = val_3._levelBean.AllAnswerList;
                val_13 = null;
                val_14 = 1152921512647611696;
            }
            else
            {
                    val_15 = this.words;
                if((val_15.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean WordContent.<>c__DisplayClass56_0::<MatchAnswerForWord>b__0(View.CommonItem.Word x)))) == null)
            {
                    return (string)val_11;
            }
            
                Logic.Game.GameControllers val_7 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                val_12 = val_7._levelBean.AllAnswerList;
                val_13 = null;
                val_14 = 1152921512647634224;
            }
            
            val_15 = val_13;
            val_13 = new System.Predicate<System.String>(object:  val_1, method:  val_14);
            val_11 = val_12.Find(match:  val_15);
            return (string)val_11;
        }
        private void ShowHintWord(float delay)
        {
            string val_12;
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddUseHintCount();
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            int val_12 = val_2.<NowCurLevelUseHintCount>k__BackingField;
            val_12 = val_12 + 1;
            val_2.<NowCurLevelUseHintCount>k__BackingField = val_12;
            Platform.Analytics.EzAnalytics.HintTipsTimes();
            View.CommonItem.Word val_3 = this.FindFirstNotFoundAnswer();
            if(val_3 == 0)
            {
                    return;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_12 = "eff_hint";
            }
            else
            {
                    val_12 = "hint";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_12, volumeScale:  1f, loop:  false, delay:  0f);
            UnityEngine.Vector3 val_7 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  this.hintButton.transform);
            UnityEngine.Vector3 val_8 = val_3.GetHintBoxPosition();
            val_3.ShowHint(startPosition:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, endPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, time:  0.4f, delay:  delay);
            if(val_3._isAnswered != false)
            {
                    this._word = val_3;
                Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishWords();
                this.AddAnswerCount(delayTime:  0f);
                Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddAllConnectWord();
                Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  val_3._word);
                return;
            }
            
            this.SaveLevelProgress(isAnswer:  false);
        }
        private void RestoreLevelProgress()
        {
            var val_18;
            System.Collections.Generic.List<View.CommonItem.Word> val_20;
            System.Collections.Generic.List<View.CommonItem.Word> val_21;
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.SetRightAnswer(words:  0);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.GetLevelBoxProgressIsTest()) == false)
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<System.String> val_7 = Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.GetLevelBoxProgressTest();
            if(((val_7 == null) || (W9 != this.words)) || ((Common.SingletonController<Logic.Game.GameControllers>.Instance.CheckWordExact(words:  val_7)) == false))
            {
                goto label_23;
            }
            
            if(1152921512609388752 >= 1)
            {
                    var val_21 = 4;
                do
            {
                val_18 = 0;
                if(val_18 >= 1152921512609388752)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(as. 
               
               
              
            
            
            
             != 0)
            {
                    if(val_18 >= (public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>()))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_18 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>().__il2cppRuntimeField_20.word = public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>().__il2cppRuntimeField_20;
            }
            
                var val_10 = val_21 - 3;
                val_21 = val_21 + 1;
            }
            while(val_10 < (public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>()));
            
            }
            
            if((Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.GetLevelBoxProgress()) == null)
            {
                goto label_23;
            }
            
            val_20 = this.words;
            if((public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>()) != val_10)
            {
                goto label_23;
            }
            
            if((public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>()) < 1)
            {
                goto label_37;
            }
            
            val_18 = 1152921504689328128;
            var val_23 = 4;
            label_38:
            if((val_23 - 4) >= (public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>()))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((public UnityEngine.Renderer UnityEngine.Component::GetComponent<UnityEngine.Renderer>().__il2cppRuntimeField_20) != 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32.SetProgress(progress:  UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32);
                val_21 = this.words;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                int val_22 = this.<answerCount>k__BackingField;
                val_22 = val_22 + 1;
                this.<answerCount>k__BackingField = val_22;
            }
            
            if((val_23 - 3) >= val_22)
            {
                goto label_37;
            }
            
            val_23 = val_23 + 1;
            if(this.words != null)
            {
                goto label_38;
            }
            
            return;
            label_5:
            Data.ButterFly.ButterFlyDataManager val_16 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            val_16.SetLevelChrysalisCount(count:  0);
            val_16.ClearLevelProgress();
            return;
            label_23:
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.SetLevelChrysalisCount(count:  0);
            return;
            label_37:
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.SetRightAnswer(words:  Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.GetGameRightAnswerList());
        }
        private void SaveLevelProgress(bool isAnswer = False)
        {
            var val_5;
            var val_6;
            System.Collections.Generic.List<System.String> val_16;
            string val_18;
            var val_19;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.String> val_3 = null;
            val_16 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_4 = this.words.GetEnumerator();
            label_7:
            val_18 = public System.Boolean List.Enumerator<View.CommonItem.Word>::MoveNext();
            if(val_6.MoveNext() == false)
            {
                goto label_4;
            }
            
            val_19 = val_5;
            if(val_19 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_18 = val_19.GetProgress();
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(item:  val_18);
            goto label_7;
            label_4:
            val_6.Dispose();
            List.Enumerator<T> val_10 = this.words.GetEnumerator();
            label_12:
            val_18 = public System.Boolean List.Enumerator<View.CommonItem.Word>::MoveNext();
            if(val_6.MoveNext() == false)
            {
                goto label_9;
            }
            
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(item:  val_5 + 40);
            goto label_12;
            label_9:
            val_6.Dispose();
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SetLevelBoxProgressIsTest(value:  "Test");
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SaveLevelBoxProgressTest(data:  new System.Collections.Generic.List<System.String>());
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SaveLevelBoxProgress(data:  val_16);
        }
        private void ClearLevelProgress()
        {
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SaveLevelBoxProgressTest(data:  0);
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SaveLevelBoxProgress(data:  0);
            Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance.SaveGameRightAnswerList(data:  0);
        }
        public System.Collections.Generic.List<string> GetGuideWords()
        {
            System.Collections.Generic.List<View.CommonItem.Word> val_2;
            var val_3;
            val_2 = this.words;
            val_3 = 4;
            do
            {
                var val_2 = val_3 - 4;
                if(val_2 >= 1152921507302932960)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
                if(1152921507302932960 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(W9 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                "The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal.".__il2cppRuntimeField_20.ChangeToGuideCanvas();
                val_2 = this.words;
                val_3 = val_3 + 1;
            }
            while(val_2 != null);
            
            throw new NullReferenceException();
        }
        public System.Collections.Generic.List<View.CommonItem.Word> GetBonusGuideWords()
        {
            System.Collections.Generic.List<View.CommonItem.Word> val_2;
            var val_3;
            val_2 = this.words;
            val_3 = 4;
            do
            {
                var val_2 = val_3 - 4;
                if(val_2 >= 1152921512648701984)
            {
                    return (System.Collections.Generic.List<View.CommonItem.Word>)new System.Collections.Generic.List<View.CommonItem.Word>();
            }
            
                if(1152921512648701984 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                Add(item:  public System.Void ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator::Reset().__il2cppRuntimeField_40 + 32);
                val_2 = this.words;
                val_3 = val_3 + 1;
            }
            while(val_2 != null);
            
            throw new NullReferenceException();
        }
        public View.CommonItem.Word ChangeToGuideCanvas(string word)
        {
            typeof(WordContent.<>c__DisplayClass63_0).__il2cppRuntimeField_10 = word;
            View.CommonItem.Word val_3 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  new WordContent.<>c__DisplayClass63_0(), method:  System.Boolean WordContent.<>c__DisplayClass63_0::<ChangeToGuideCanvas>b__0(View.CommonItem.Word x)));
            if(val_3 == 0)
            {
                    return val_3;
            }
            
            val_3.ChangeToGuideCanvas();
            val_3.ChangeToGuideBox(isGuide:  true);
            return val_3;
        }
        private void DestroyBoxes()
        {
            UnityEngine.Object val_2;
            var val_3;
            UnityEngine.Object val_8;
            UnityEngine.Object val_9;
            if(this.words == null)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.words.GetEnumerator();
            label_11:
            if(val_3.MoveNext() == false)
            {
                goto label_3;
            }
            
            val_8 = val_2;
            val_9 = 0;
            if(val_8 == val_9)
            {
                goto label_11;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_9 = 0;
            val_2.DestroyBoxes();
            val_8 = mem[public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184];
            val_8 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184;
            View.CommonItem.Word val_6 = val_8.Recycle<View.CommonItem.Word>(obj:  val_2, isUi:  true);
            goto label_11;
            label_3:
            val_3.Dispose();
            this.words.Clear();
        }
        public void ClearWordContent()
        {
            this.<answerCount>k__BackingField = 0;
            this.allFailCount = 0;
            this.comboCount = 0;
            this.continuousFailCount = 0;
            this.checkAnswerCount = 0;
            this.lastFailWord = "";
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_1.<NowCurLevelMaxComboCount>k__BackingField = 0;
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_2.<NowCurLevelWrongCount>k__BackingField = 0;
            Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_3.<NowCurLevelUseHintCount>k__BackingField = 0;
            this.DestroyBoxes();
        }
        private void SetBonusGuideWordsState(bool isGuide)
        {
            System.Collections.Generic.List<View.CommonItem.Word> val_1 = this.GetBonusGuideWords();
            if(true < 1)
            {
                    return;
            }
            
            var val_5 = 4;
            if(true <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            0.ChangeToGuideCanvas(order:  (isGuide != true) ? 12 : (0 + 1));
            if(true <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            0.ChangeToGuideBox(isGuide:  isGuide);
            if(true <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Message.Messager.Dispatch<View.CommonItem.Word>(cmd:  33, t:  0);
            val_5 = val_5 + 1;
            var val_4 = val_5 - 4;
        }
        private void CheckLetterGiftBoxPos()
        {
            System.Collections.Generic.List<View.CommonItem.Word> val_5;
            if(this.words < 1)
            {
                    return;
            }
            
            if((Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance.IsHaveLetterGiftBox()) == false)
            {
                    return;
            }
            
            val_5 = this.words;
            if((public static View.Dialog.FreeGiftTest.Controller.FreeGiftTestController Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>::get_Instance()) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_5 = this.words;
            }
            
            this._wordTemp = System.Int32 System.Array::InternalArray__IndexOf<HitInfo>(HitInfo item);
            label_37:
            var val_3 = 5 - 4;
            if(val_3 >= (System.Int32 System.Array::InternalArray__IndexOf<HitInfo>(HitInfo item)))
            {
                goto label_8;
            }
            
            if((System.Int32 System.Array::InternalArray__IndexOf<HitInfo>(HitInfo item)) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((System.Int32 System.Array::InternalArray__IndexOf<HitInfo>(HitInfo item).__il2cppRuntimeField_28 + 40 + 16 + 40 + 48 + 40.IsHaveEmptyLetter()) == true)
            {
                goto label_22;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(this._wordTemp._isAnswered == false)
            {
                goto label_34;
            }
            
            if(this._wordTemp._isAnswered <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this._wordTemp._isAnswered + 40.IsHaveEmptyLetter()) == false)
            {
                goto label_34;
            }
            
            label_22:
            if(this._wordTemp._isAnswered <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this._wordTemp = this._wordTemp._isAnswered + 40;
            label_34:
            var val_6 = 5 + 1;
            if(this.words != null)
            {
                goto label_37;
            }
            
            label_8:
            if(this._wordTemp._isAnswered != false)
            {
                    return;
            }
            
            this._wordTemp.CheckLetterGiftBoxPos();
        }
        private void GiftBoxGiveFreeHint()
        {
            var val_9;
            System.Predicate<View.CommonItem.Word> val_11;
            string val_12;
            val_9 = null;
            val_9 = null;
            val_11 = WordContent.<>c.<>9__68_0;
            if(val_11 == null)
            {
                    System.Predicate<View.CommonItem.Word> val_1 = null;
                val_11 = val_1;
                val_1 = new System.Predicate<View.CommonItem.Word>(object:  WordContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WordContent.<>c::<GiftBoxGiveFreeHint>b__68_0(View.CommonItem.Word x));
                WordContent.<>c.<>9__68_0 = val_11;
            }
            
            View.CommonItem.Word val_2 = this.words.Find(match:  val_11);
            if(val_2 == 0)
            {
                    return;
            }
            
            if(val_2._isAnswered != false)
            {
                    return;
            }
            
            string val_4 = this.MatchAnswerForWord(word:  val_2);
            if((System.String.IsNullOrEmpty(value:  val_4)) != true)
            {
                    val_2.word = val_4;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_12 = "eff_hint";
            }
            else
            {
                    val_12 = "hint";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_12, volumeScale:  1f, loop:  false, delay:  0f);
            val_2.ShowFreeHint();
            if(val_2._isAnswered != false)
            {
                    Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishWords();
                this.AddAnswerCount(delayTime:  0f);
                Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  val_2._word);
                return;
            }
            
            this.SaveLevelProgress(isAnswer:  false);
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Boolean>(cmd:  22, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.WordContent::SetBonusGuideWordsState(bool isGuide)));
            Message.Messager.Add(cmd:  57, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::HintClick()));
            Message.Messager.Add(cmd:  69, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::GiftBoxGiveFreeHint()));
            Message.Messager.Add(cmd:  70, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::LogEventFailCount()));
            Message.Messager.Add(cmd:  100, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::GetFireworkWords()));
            Message.Messager.Add(cmd:  64, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::CheckChrysalisBox()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Boolean>(cmd:  22, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.WordContent::SetBonusGuideWordsState(bool isGuide)));
            Message.Messager.Remove(cmd:  57, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::HintClick()));
            Message.Messager.Remove(cmd:  69, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::GiftBoxGiveFreeHint()));
            Message.Messager.Remove(cmd:  70, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::LogEventFailCount()));
            Message.Messager.Remove(cmd:  100, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::GetFireworkWords()));
            Message.Messager.Remove(cmd:  64, action:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::CheckChrysalisBox()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.WordContent::PlayCombo()));
        }
        public WordContent()
        {
            this.wordVerticalRatioSpacing = ;
            this.wordHorizontalRatioSpacing = ;
            this.letterRatioSpacing = 0.08f;
            this.maxSize = 120f;
            System.Collections.Generic.List<View.CommonItem.Word> val_1 = 1152921512650002848;
            val_1 = new System.Collections.Generic.List<View.CommonItem.Word>();
            this.words = val_1;
            this.wordsLengthSet = new System.Collections.Generic.HashSet<System.Int32>();
            this.lastFailWord = "";
            this._tempLetterBoxes = new System.Collections.Generic.List<View.CommonItem.LetterBox>();
            this.letterBoxes = new System.Collections.Generic.List<View.CommonItem.LetterBox>(capacity:  5);
        }
    
    }

}
