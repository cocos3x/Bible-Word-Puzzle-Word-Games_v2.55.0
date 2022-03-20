using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerWordContent : MonoBehaviour
    {
        // Fields
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
        public UnityEngine.Transform bonusTragetTransform;
        public View.CommonItem.HintButton hintButton;
        private float width;
        private float height;
        private System.Collections.Generic.List<View.CommonItem.Word> words;
        private System.Collections.Generic.HashSet<int> wordsLengthSet;
        private string lastFailWord;
        private int allFailCount;
        private int comboCount;
        private int continuousFailCount;
        private int starProgress;
        private View.CommonItem.Word _wordTemp;
        private char _doveLetter;
        private System.Collections.Generic.List<View.CommonItem.LetterBox> _allDoveLetterBoxes;
        private int <answerCount>k__BackingField;
        private Data.DailyPrayer.DailyPrayerBean _levelItem;
        private View.CommonItem.Word _word;
        public System.Collections.Generic.List<View.CommonItem.LetterBox> letterBoxes;
        
        // Properties
        private int answerCount { get; set; }
        public Data.DailyPrayer.DailyPrayerBean levelBean { get; set; }
        
        // Methods
        private int get_answerCount()
        {
            return (int)this.<answerCount>k__BackingField;
        }
        private void set_answerCount(int value)
        {
            this.<answerCount>k__BackingField = value;
        }
        public Data.DailyPrayer.DailyPrayerBean get_levelBean()
        {
            return (Data.DailyPrayer.DailyPrayerBean)this._levelItem;
        }
        public void set_levelBean(Data.DailyPrayer.DailyPrayerBean value)
        {
            this._levelItem = value;
            this.InitWordContent();
        }
        private void InitWordContent()
        {
            var val_47;
            float val_48;
            var val_49;
            float val_50;
            this.ClearWordContent();
            bool val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.IsTodayDailyPrayerOpened();
            if(val_2 != true)
            {
                    val_2.ClearLevelProgress();
            }
            
            this.InitSize();
            System.Collections.Generic.List<System.String> val_3 = this._levelItem.answerList;
            var val_5 = (W22 >= 5) ? ((W22 >= 11) ? (2 + 1) : 2) : (0 + 1);
            float val_46 = (float)W22;
            val_46 = val_46 / (float)val_5;
            var val_6 = W23 - 1;
            var val_47 = 0;
            var val_48 = val_6;
            do
            {
                System.Collections.Generic.List<System.String> val_7 = this._levelItem.answerList;
                val_47 = val_48;
                System.Collections.Generic.List<System.String> val_8 = this._levelItem.answerList;
                System.Collections.Generic.List<System.String> val_9 = this._levelItem.answerList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_47 = val_47 + 1;
                val_48 = val_48 + W23;
            }
            while(val_47 < val_5);
            
            float val_51 = this.wordVerticalRatioSpacing;
            float val_49 = this.wordHorizontalRatioSpacing;
            float val_50 = this.letterRatioSpacing;
            val_49 = val_49 * ((float)val_5 - 1);
            val_50 = val_50 * ((float)(((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32 + 16 + 0) - W22 >= 0x5 ? W22 >= 0xB ? (2 + 1) : 2 : (0 + 1)));
            float val_11 = this.height / (float)W23;
            val_51 = val_11 * val_51;
            val_49 = val_49 + val_50;
            val_51 = val_51 + 230f;
            float val_12 = val_49 + ((float)((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32 + 16 + 0));
            val_51 = val_11 / val_51;
            float val_16 = UnityEngine.Mathf.Min(a:  this.maxSize, b:  UnityEngine.Mathf.Min(a:  this.width / val_12, b:  S12 * 230f));
            this.wordsLengthSet.Clear();
            val_16 = val_12 * val_16;
            val_48 = -0.5f;
            val_16 = this.width - val_16;
            var val_58 = 0;
            float val_55 = 0f;
            label_49:
            System.Collections.Generic.List<System.String> val_19 = this._levelItem.answerList;
            if(val_58 >= 1152921512643510624)
            {
                goto label_22;
            }
            
            System.Collections.Generic.List<System.String> val_20 = this._levelItem.answerList;
            if(1152921512643510624 <= val_58)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this.wordsLengthSet.Contains(item:  public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10>>0&0xFFFFFFFF)) != true)
            {
                    bool val_22 = this.wordsLengthSet.Add(item:  public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10>>0&0xFFFFFFFF);
            }
            
            System.Collections.Generic.List<System.String> val_23 = this._levelItem.answerList;
            var val_25 = val_58 - ((val_58 / W23) * W23);
            var val_27 = (val_6 + val_58) + (-val_25);
            System.Collections.Generic.List<System.String> val_28 = this._levelItem.answerList;
            if(this._levelItem <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_49 = this._levelItem + (val_27 << 3);
            val_50 = (val_16 * 0.5f) + val_55;
            if(W22 <= 4)
            {
                    float val_52 = this.letterRatioSpacing;
                val_48 = (float)((this._levelItem + ((this._levelItem - 1)) << 3).reference.m_stringLength - public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10);
                val_52 = val_52 + 1f;
                val_52 = val_52 * val_48;
                val_52 = val_16 * val_52;
                val_52 = val_52 * 0.5f;
                val_50 = val_50 + val_52;
            }
            
            if((val_25 + 1) == W23)
            {
                    float val_54 = this.wordHorizontalRatioSpacing;
                float val_53 = this.letterRatioSpacing;
                val_53 = val_53 * ((float)(public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10 - 1));
                val_53 = val_53 + ((float)public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext().__il2cppRuntimeField_10);
                val_54 = val_54 + val_53;
                val_54 = val_16 * val_54;
                val_55 = val_55 + val_54;
            }
            
            Data.DailyPrayer.DailyPrayerBean val_56 = this._levelItem;
            System.Collections.Generic.List<System.String> val_34 = val_56.answerList;
            val_56 = val_56 - this._levelItem.HasBonusCount();
            View.CommonItem.Word val_37 = View.CommonItem.Word.Create(parent:  this.transform, wordPrefab:  this.wordPrefab, isBonus:  (val_58 >= val_56) ? 1 : 0, word:  public System.Boolean Dictionary.Enumerator<TypeNameKey, System.Object>::MoveNext());
            float val_57 = (float)val_25;
            val_57 = val_11 * val_57;
            val_37.size = val_16;
            val_37.spacing = this.letterRatioSpacing;
            UnityEngine.Vector3 val_39 = new UnityEngine.Vector3(x:  val_50, y:  (val_11 * val_48) - val_57);
            val_37.anchoredPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
            this.words.Add(item:  val_37);
            val_58 = val_58 + 1;
            if(this._levelItem != null)
            {
                goto label_49;
            }
            
            label_22:
            if((Platform.AbTest.GameABTestManager.IsGameSoundTest() != true) && ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false))
            {
                    if(this._levelItem.HasBonus() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "bonus_level_start", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            }
            
            this.RestoreLevelProgress();
            this.CheckLetterGift();
            UnityEngine.Coroutine val_45 = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::<InitWordContent>b__35_0()), seconds:  0.5f);
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
                mem[40] = val_2;
                InitLetterBox();
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
                this._wordTemp = (mem[42440767] + 48 + 21247471) + 0;
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
                    this.SaveLevelProgress();
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
        private void CheckLetterGift()
        {
            View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_1 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
            if((val_1.<IsHaveLetterGiftFromDaily>k__BackingField) != false)
            {
                    this.CheckLetterGiftBoxPos();
            }
            
            Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance.ClearLetterGiftCount();
        }
        private char GetDoveLetter(bool isNew = True)
        {
            var val_14;
            string val_15;
            object val_3 = new System.Object();
            typeof(DailyPrayerWordContent.<>c__DisplayClass38_0).__il2cppRuntimeField_18 = this;
            typeof(DailyPrayerWordContent.<>c__DisplayClass38_0).__il2cppRuntimeField_10 = 0;
            label_29:
            if(0 >= null)
            {
                    return this._levelItem.RandomDoveLetter(allWords:  new System.Collections.Generic.List<System.String>(), isNew:  isNew);
            }
            
            if(null <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((DailyPrayerWordContent.<>c__DisplayClass38_0.__il2cppRuntimeField_byval_arg.IsEmptyWord()) == false)
            {
                goto label_7;
            }
            
            if((this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_3, method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass38_0::<GetDoveLetter>b__0(View.CommonItem.Word w)))) == 0)
            {
                goto label_11;
            }
            
            string val_9 = this._levelItem.AllAnswerList.Find(match:  new System.Predicate<System.String>(object:  val_3, method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass38_0::<GetDoveLetter>b__1(string x)));
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                goto label_22;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            View.DailyPrayer.DailyPrayerWordContent.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_28 = val_9;
            View.DailyPrayer.DailyPrayerWordContent.__il2cppRuntimeField_byval_arg.InitLetterBox();
            Add(item:  val_9);
            goto label_22;
            label_7:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            string val_11 = DailyPrayerWordContent.<>c__DisplayClass38_0.__il2cppRuntimeField_byval_arg.GetNotFoundLetters();
            if((System.String.IsNullOrEmpty(value:  val_11)) == true)
            {
                goto label_22;
            }
            
            val_14 = 1152921507302947296;
            val_15 = val_11;
            goto label_24;
            label_11:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_15 = mem[UnityEngine.Object.__il2cppRuntimeField_byval_arg + 40];
            val_15 = UnityEngine.Object.__il2cppRuntimeField_byval_arg + 40;
            val_14 = 1152921507302947296;
            label_24:
            Add(item:  val_15);
            label_22:
            typeof(DailyPrayerWordContent.<>c__DisplayClass38_0).__il2cppRuntimeField_10 = (typeof(DailyPrayerWordContent.<>c__DisplayClass38_0).__il2cppRuntimeField_10 + 1);
            if(this.words != null)
            {
                goto label_29;
            }
            
            return this._levelItem.RandomDoveLetter(allWords:  new System.Collections.Generic.List<System.String>(), isNew:  isNew);
        }
        private void GetAllDoveLetterBoxes()
        {
            this._allDoveLetterBoxes.Clear();
            var val_6 = 0;
            label_8:
            if(val_6 >= 1152921512644114000)
            {
                goto label_3;
            }
            
            if(1152921512644114000 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(21247440 >= 1)
            {
                    this._allDoveLetterBoxes = System.Linq.Enumerable.ToList<View.CommonItem.LetterBox>(source:  System.Linq.Enumerable.Concat<View.CommonItem.LetterBox>(first:  this._allDoveLetterBoxes, second:  GetDoveLetterBoxes(doveLetter:  this._doveLetter)));
            }
            
            val_6 = val_6 + 1;
            if(this.words != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_3:
            Message.Messager.Dispatch<System.Collections.Generic.List<View.CommonItem.LetterBox>>(cmd:  28, t:  this._allDoveLetterBoxes);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GetNewDoveLetter()));
            Common.TimerEvent.Add(time:  0.5f, callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GetNewDoveLetter()), isrepeat:  false);
        }
        private void GetNewDoveLetter()
        {
            char val_1 = this.GetDoveLetter(isNew:  true);
            this._doveLetter = val_1;
            Message.Messager.Dispatch<System.Char>(cmd:  26, t:  val_1);
        }
        private int GetEmptyWordCount(System.Collections.Generic.List<string> progress)
        {
            var val_2;
            bool val_2 = true;
            if((progress != null) && (val_2 >= 1))
            {
                    var val_4 = 0;
                do
            {
                if(val_2 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                var val_3 = ~((true + 0) + 32.Contains(value:  "1"));
                val_3 = val_3 & 1;
                val_4 = val_4 + 1;
                val_2 = 0 + val_3;
            }
            while(val_4 < val_2);
            
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
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
            
            if(null != null)
            {
                goto label_9;
            }
            
            UnityEngine.Rect val_7 = this.transform.parent.parent.rect;
            UnityEngine.Vector2 val_9 = val_1.offsetMax;
            UnityEngine.Vector2 val_10 = val_1.offsetMin;
            val_10.x = (val_7.m_XMin.width + val_9.x) - val_10.x;
            this.width = val_10.x;
            UnityEngine.Rect val_12 = val_3.rect;
            UnityEngine.Vector2 val_14 = val_1.offsetMax;
            UnityEngine.Vector2 val_15 = val_1.offsetMin;
            float val_16 = val_12.m_XMin.height + val_14.y;
            val_16 = val_16 - val_15.y;
            this.height = val_16;
            return;
            label_2:
            label_5:
            label_9:
        }
        private bool IsExtraWords(string answer)
        {
            if(this._levelItem.extras == null)
            {
                    return (bool)this._levelItem.extras;
            }
            
            return this._levelItem.extras.Contains(item:  answer);
        }
        private bool CheckWordLength(string answer)
        {
            return this.wordsLengthSet.Contains(item:  answer.m_stringLength);
        }
        private void PlayWordLengthTipsAni()
        {
            object[] val_1 = new object[1];
            val_1[0] = Locale.LocaleManager.Translate(key:  "131");
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_1);
        }
        private View.CommonItem.Word FindWordFromTest(string answer)
        {
            UnityEngine.Object val_13;
            object val_1 = new System.Object();
            typeof(DailyPrayerWordContent.<>c__DisplayClass46_0).__il2cppRuntimeField_10 = answer;
            View.CommonItem.Word val_3 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass46_0::<FindWordFromTest>b__0(View.CommonItem.Word x)));
            this._word = val_3;
            val_13 = val_3;
            if(val_13 != 0)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            if((this.CheckWordLength(answer:  typeof(DailyPrayerWordContent.<>c__DisplayClass46_0).__il2cppRuntimeField_10)) == false)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            if((Data.ExtraWordData.ExtraWordDataMngr.IsWordExist(word:  typeof(DailyPrayerWordContent.<>c__DisplayClass46_0).__il2cppRuntimeField_10)) == true)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            View.CommonItem.Word val_8 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass46_0::<FindWordFromTest>b__1(View.CommonItem.Word x)));
            this._word = val_8;
            val_13 = val_8;
            if(val_13 == 0)
            {
                    View.CommonItem.Word val_11 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass46_0::<FindWordFromTest>b__2(View.CommonItem.Word x)));
                this._word = val_11;
                val_13 = val_11;
                if(val_13 == 0)
            {
                    return (View.CommonItem.Word)this._word;
            }
            
            }
            
            this._word._word = typeof(DailyPrayerWordContent.<>c__DisplayClass46_0).__il2cppRuntimeField_10;
            this._word.InitLetterBox();
            return (View.CommonItem.Word)this._word;
        }
        private void AnswerRight(string answer)
        {
            string val_13;
            float val_14;
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
                    val_13 = "eff_combo_youmadeIt";
            }
            else
            {
                    val_13 = "you_made_it";
            }
            
                Logic.Game.GameManager.gameSound.Play(clipName:  val_13, volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            if((this._word.<isBonus>k__BackingField) != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "bonusword", value:  0);
                UnityEngine.Vector3 val_6 = this._word.centerPosition;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  Common.GlobalProperty.GetBonusReward(), from:  "bonus_word", centerPosition:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
                Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddBonusWordsCount();
                Platform.Analytics.EzAnalytics.BonusWordsTimes();
                val_14 = 1f;
                this.AddAnswerCount(delayTime:  val_14);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_success", label:  "bonus", value:  0);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_finish", label:  "new", value:  0);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "bonusword", value:  0);
            }
            else
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_success", label:  "answer", value:  0);
                Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_finish", label:  "new", value:  0);
                val_14 = 0f;
                this.AddAnswerCount(delayTime:  ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != true) ? 1f : 0f);
            }
            
            this.hintButton.<time>k__BackingField = UnityEngine.Time.realtimeSinceStartup;
            this.continuousFailCount = 0;
            this.GetAllDoveLetterBoxes();
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
            string val_10;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                goto label_2;
            }
            
            if((Data.ExtraWordData.ExtraWordDataMngr.IsWordExist(word:  answer)) == false)
            {
                goto label_3;
            }
            
            object[] val_4 = new object[1];
            val_4[0] = Locale.LocaleManager.Translate(key:  "194");
            View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_4);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_finish", label:  "repeat", value:  0);
            return;
            label_2:
            object[] val_7 = new object[1];
            val_7[0] = "Extra words are not available";
            View.Dialog.Common.Dialog val_8 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_7);
            return;
            label_3:
            this.AddExtraWord(answer:  answer);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "finish", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "extraword", value:  0);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_10 = "eff_btn_click";
            }
            else
            {
                    val_10 = "extra_word";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_10, volumeScale:  1f, loop:  false, delay:  0f);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_finish", label:  "new", value:  0);
            this.GetAllDoveLetterBoxes();
        }
        private void AnswerWrong(string answer)
        {
            string val_9;
            string val_10;
            val_9 = answer;
            this.comboCount = 0;
            this.lastFailWord = ((this.lastFailWord.Equals(value:  val_9)) != true) ? "" : (val_9);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_finish", label:  "fail", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "fail", value:  0);
            Logic.DailyPrayer.DailyPrayerControllers val_4 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            int val_9 = val_4.<NowCurLevelWrongCount>k__BackingField;
            val_9 = val_9 + 1;
            val_4.<NowCurLevelWrongCount>k__BackingField = val_9;
            int val_10 = this.continuousFailCount;
            val_10 = val_10 + 1;
            this.continuousFailCount = val_10;
            if(val_10 == 0)
            {
                    this.hintButton.Light();
            }
            
            if(Platform.AbTest.GameABTestManager.IsReward() != false)
            {
                    View.Dialog.FreeGiftTest.Controller.FreeGiftTestController val_6 = Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance;
                if(((val_6.<IsHaveLetterGiftFromDaily>k__BackingField) != true) && (this.continuousFailCount == 3))
            {
                    this.CheckLetterGiftBoxPos();
            }
            
            }
            
            int val_7 = this.allFailCount + 1;
            this.allFailCount = val_7;
            Platform.Analytics.EzAnalytics.FailTimes(failCount:  val_7);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_10 = "eff_word_fail";
            }
            else
            {
                    val_10 = "connect_fail";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_10, volumeScale:  1f, loop:  false, delay:  0f);
        }
        private View.Game.CheckAnswerType CheckAnswerFromTest(string answer)
        {
            var val_6;
            if((this._levelItem.WordIsAnswer(word:  answer)) == false)
            {
                goto label_2;
            }
            
            View.CommonItem.Word val_2 = this.FindWordFromTest(answer:  answer);
            this._word = val_2;
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
            {
                goto label_5;
            }
            
            if(this._word._isAnswered == false)
            {
                goto label_7;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_finish", label:  "repeat", value:  0);
            this.AnswerRepeat(answer:  "word_finish");
            val_6 = 1;
            return (View.Game.CheckAnswerType)val_6;
            label_2:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "fail", value:  0);
            this.AnswerWrong(answer:  answer);
            label_12:
            val_6 = 3;
            return (View.Game.CheckAnswerType)val_6;
            label_5:
            if((this.CheckWordLength(answer:  answer)) == false)
            {
                goto label_10;
            }
            
            this.AnswerExtra(answer:  answer);
            val_6 = 2;
            goto label_11;
            label_10:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "fail", value:  0);
            PlayWordLengthTipsAni();
            goto label_12;
            label_7:
            this.AnswerRight(answer:  0);
            val_6 = 0;
            label_11:
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddAllConnectWord();
            return (View.Game.CheckAnswerType)val_6;
        }
        public View.Game.CheckAnswerType CheckAnswer(string answer)
        {
            if((this.wordsLengthSet.Contains(item:  answer.m_stringLength)) != true)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "fail", value:  0);
                PlayWordLengthTipsAni();
            }
            
            View.Game.CheckAnswerType val_2 = this.CheckAnswerFromTest(answer:  answer);
            if(val_2 != 0)
            {
                    return val_2;
            }
            
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  answer);
            return val_2;
        }
        private void LogEventFailCount()
        {
            if(this.allFailCount < 1)
            {
                    return;
            }
            
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
            Logic.DailyPrayer.DailyPrayerControllers val_1 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            if(this.comboCount <= (val_2.<NowCurLevelMaxComboCount>k__BackingField))
            {
                    Logic.DailyPrayer.DailyPrayerControllers val_3 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
                this = val_3.<NowCurLevelMaxComboCount>k__BackingField;
            }
            
            val_1.<NowCurLevelMaxComboCount>k__BackingField = this;
            View.CommonItem.Combo.ComboNormal val_5 = View.DailyPrayer.DailyPrayerController.GetInstance().CreatYouMadeIt();
        }
        private void AddCombo()
        {
            int val_6 = this.comboCount;
            val_6 = val_6 + 1;
            this.comboCount = val_6;
            Logic.DailyPrayer.DailyPrayerControllers val_1 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            if(this.comboCount <= (val_2.<NowCurLevelMaxComboCount>k__BackingField))
            {
                    Logic.DailyPrayer.DailyPrayerControllers val_3 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
                this = val_3.<NowCurLevelMaxComboCount>k__BackingField;
            }
            
            val_1.<NowCurLevelMaxComboCount>k__BackingField = this;
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddCombos();
            Common.TimerEvent.Add(time:  0.15f, callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::PlayCombo()), isrepeat:  false);
        }
        private void PlayCombo()
        {
            if(this.comboCount == 0)
            {
                    return;
            }
            
            Logic.Game.GameManager.gameSound.PlayCombo(index:  this.comboCount);
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
            
            UnityEngine.Vector3 val_9 = View.DailyPrayer.DailyPrayerController.GetInstance().CreateCombo(comboCount:  this.comboCount).transform.position;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  Common.GlobalProperty.GetComboReward(comboCount:  this.comboCount), from:  "combo", centerPosition:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, time:  0.5f, delay:  0.2f, onFinish:  0, count:  0);
        }
        private void AddAnswerCount(float delayTime = 0)
        {
            int val_8 = this.<answerCount>k__BackingField;
            val_8 = val_8 + 1;
            this.<answerCount>k__BackingField = val_8;
            if(val_8 == this.words)
            {
                    if(View.DailyPrayer.DailyPrayerController.GetInstance() != 0)
            {
                    View.DailyPrayer.DailyPrayerController.GetInstance().GameComplete(delay:  delayTime);
            }
            
                Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishLevels();
                Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "level_clear", value:  0);
                if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    Data.ExtraWord.ExtraWordDataManager val_7 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance;
                val_7.ClearWords();
            }
            
                val_7.ClearLevelProgress();
                return;
            }
            
            this.SaveLevelProgress();
        }
        private void AddExtraWord(string answer)
        {
            UnityEngine.Vector3 val_2 = this.selectedPanelObj.transform.position;
            Message.Messager.Dispatch<System.String, UnityEngine.Vector3>(cmd:  55, t:  answer, u:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        private void HintClick()
        {
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "DailyGuideDialog")) != false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus) >= 1)
            {
                    this.HintClick(isFree:  true, delay:  0f);
                Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.ReduceHintFreeStatus(hint:  1);
                Message.Messager.Dispatch(cmd:  71);
                this.hintButton.StopHintFree();
                return;
            }
            
            this.HintClick(isFree:  false, delay:  0f);
        }
        public void HintClick(bool isFree, float delay = 0)
        {
            View.DailyPrayer.DailyPrayerController val_1 = View.DailyPrayer.DailyPrayerController.GetInstance();
            if((val_1.<isGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            if(this._levelItem == null)
            {
                    return;
            }
            
            if(isFree != true)
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.CostCoins(value:  120, from:  "tips")) == false)
            {
                goto label_6;
            }
            
            }
            
            this.ShowHintWord(delay:  delay);
            return;
            label_6:
            if((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.IsHaveNoviceBankruptcy) != false)
            {
                    object[] val_6 = new object[1];
                val_6[0] = true;
                View.Dialog.Common.Dialog val_7 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "NoviceRewardDialog", pars:  val_6);
                return;
            }
            
            View.Dialog.Common.Dialog val_8 = Logic.Game.GameManager.gameDialog.Open(name:  "ShopTestDialog", type:  0);
        }
        private View.CommonItem.Word FindFirstNotFoundAnswer()
        {
            string val_6;
            var val_7;
            System.Predicate<View.CommonItem.Word> val_9;
            val_6 = this;
            val_7 = null;
            val_7 = null;
            val_9 = DailyPrayerWordContent.<>c.<>9__61_0;
            if(val_9 == null)
            {
                    System.Predicate<View.CommonItem.Word> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Predicate<View.CommonItem.Word>(object:  DailyPrayerWordContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DailyPrayerWordContent.<>c::<FindFirstNotFoundAnswer>b__61_0(View.CommonItem.Word x));
                DailyPrayerWordContent.<>c.<>9__61_0 = val_9;
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
            
            val_2._word = val_6;
            val_2.InitLetterBox();
            return val_2;
        }
        private string MatchAnswerForWord(View.CommonItem.Word word)
        {
            int val_9;
            var val_10;
            System.Predicate<System.String> val_11;
            IntPtr val_12;
            object val_1 = new System.Object();
            typeof(DailyPrayerWordContent.<>c__DisplayClass62_0).__il2cppRuntimeField_10 = this;
            typeof(DailyPrayerWordContent.<>c__DisplayClass62_0).__il2cppRuntimeField_18 = word;
            val_9 = System.String.alignConst;
            if(word.IsEmptyWord() != false)
            {
                    val_10 = this._levelItem.AllAnswerList;
                val_11 = null;
                val_12 = 1152921512838214592;
            }
            else
            {
                    if((this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  val_1, method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass62_0::<MatchAnswerForWord>b__0(View.CommonItem.Word x)))) == null)
            {
                    return (string)val_9;
            }
            
                val_10 = this._levelItem.AllAnswerList;
                val_11 = null;
                val_12 = 1152921512838233024;
            }
            
            val_11 = new System.Predicate<System.String>(object:  val_1, method:  val_12);
            val_9 = val_10.Find(match:  val_11);
            return (string)val_9;
        }
        private void ShowHintWord(float delay)
        {
            var val_15;
            UnityEngine.Object val_16;
            string val_17;
            val_15 = null;
            val_15 = null;
            Platform.Analytics.EzAnalytics.SendPropUse(propName:  new PropNameEnum() {<Value>k__BackingField = PropUse.PropNameEnum.PropNameHint});
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddUseHintCount();
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            int val_15 = val_2.<NowCurLevelUseHintCount>k__BackingField;
            val_15 = val_15 + 1;
            val_2.<NowCurLevelUseHintCount>k__BackingField = val_15;
            Platform.Analytics.EzAnalytics.HintTipsTimes();
            val_16 = this.FindFirstNotFoundAnswer();
            if(val_16 == 0)
            {
                    return;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_17 = "eff_hint";
            }
            else
            {
                    val_17 = "hint";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_17, volumeScale:  1f, loop:  false, delay:  0f);
            UnityEngine.Vector3 val_8 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  this.hintButton.transform);
            UnityEngine.Vector3 val_9 = val_16.GetHintBoxPosition();
            val_16.ShowHint(startPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, endPosition:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, time:  0.4f, delay:  delay);
            if(val_3._isAnswered != false)
            {
                    Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishWords();
                this.AddAnswerCount(delayTime:  0f);
                Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.AddAllConnectWord();
                Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  val_3._word);
            }
            else
            {
                    this.SaveLevelProgress();
                val_16 = val_3._word;
            }
            
            if((mem[val_3._word].Chars[val_16.GetHintBoxIndex()] & 65535) != this._doveLetter)
            {
                    return;
            }
            
            this.GetNewDoveLetter();
        }
        private void ShowHintWordFromDove(View.CommonItem.LetterBox letterBox)
        {
            string val_8;
            typeof(DailyPrayerWordContent.<>c__DisplayClass64_0).__il2cppRuntimeField_10 = letterBox;
            View.CommonItem.Word val_3 = this.words.Find(match:  new System.Predicate<View.CommonItem.Word>(object:  new System.Object(), method:  System.Boolean DailyPrayerWordContent.<>c__DisplayClass64_0::<ShowHintWordFromDove>b__0(View.CommonItem.Word x)));
            if(val_3 == 0)
            {
                    return;
            }
            
            if(val_3._isAnswered != false)
            {
                    return;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_8 = "eff_hint";
            }
            else
            {
                    val_8 = "hint";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_8, volumeScale:  1f, loop:  false, delay:  0f);
            val_3.ShowHint(letterBox:  typeof(DailyPrayerWordContent.<>c__DisplayClass64_0).__il2cppRuntimeField_10);
            if(val_3._isAnswered != false)
            {
                    Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishWords();
                this.AddAnswerCount(delayTime:  0f);
                Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.AddRightAnswer(word:  val_3._word);
                return;
            }
            
            this.SaveLevelProgress();
        }
        public System.Collections.Generic.List<string> GetGuideWords()
        {
            Data.DailyPrayer.DailyPrayerBean val_4 = this._levelItem;
            var val_5 = 4;
            label_20:
            var val_2 = val_5 - 4;
            if(val_2 >= val_4)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            val_4 = val_4 & 4294967295;
            if(this._levelItem._doveLetter == 0)
            {
                goto label_4;
            }
            
            if(val_2 >= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((this._levelItem & 4294967295).reference) != null)
            {
                goto label_15;
            }
            
            if(val_2 >= ((this._levelItem & 4294967295).reference))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((0.IsFindLetter(letter:  this._levelItem._doveLetter)) == true)
            {
                goto label_11;
            }
            
            goto label_15;
            label_4:
            if(val_2 >= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((this._levelItem & 4294967295).reference) != null)
            {
                goto label_15;
            }
            
            label_11:
            if(val_2 >= ((this._levelItem & 4294967295).reference))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Add(item:  public System.Void System.Collections.Generic.List<System.String>::.ctor());
            label_15:
            val_5 = val_5 + 1;
            if(this.words != null)
            {
                goto label_20;
            }
            
            throw new NullReferenceException();
        }
        private bool CheckWordExact(System.Collections.Generic.List<string> words)
        {
            var val_5;
            if(((words != null) && (true != 0)) && ((System.String.IsNullOrEmpty(value:  this._levelItem.letters)) != true))
            {
                    if(this._levelItem < 1)
            {
                    return (bool)val_5;
            }
            
                var val_5 = 0;
                if(val_5 >= this._levelItem)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_5 >= null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_4 = 0;
                if(((this._levelItem.letters.IndexOf(value:  Data.DailyPrayer.DailyPrayerBean.__il2cppRuntimeField_byval_arg.Chars[0])) & 2147483648) == 0)
            {
                    val_4 = val_4 + 1;
                val_5 = val_5 + 1;
                val_5 = 1;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        private void RestoreLevelProgress()
        {
            System.Collections.Generic.List<View.CommonItem.Word> val_13;
            System.Collections.Generic.List<View.CommonItem.Word> val_15;
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.SetRightAnswer(words:  0);
            bool val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailyPrayerBoxProgressIsTest();
            if(val_3 == false)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<System.String> val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailyPrayerBoxProgressTest();
            if(val_5 == null)
            {
                    return;
            }
            
            if(W9 != this.words)
            {
                    return;
            }
            
            if((this.CheckWordExact(words:  val_5)) == false)
            {
                    return;
            }
            
            if(this.words >= 1)
            {
                    var val_13 = 4;
                do
            {
                if(0 >= this.words)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.words != null)
            {
                    if(0 >= this.words)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(0 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                mem2[0] = this.words;
                this.words.InitLetterBox();
            }
            
                var val_7 = val_13 - 3;
                val_13 = val_13 + 1;
            }
            while(val_7 < this.words);
            
            }
            
            if((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailyPrayerBoxProgress()) == null)
            {
                    return;
            }
            
            val_13 = this.words;
            if(this.words != val_7)
            {
                    return;
            }
            
            if(this.words < 1)
            {
                goto label_29;
            }
            
            var val_15 = 0;
            label_30:
            if(val_7 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            if(this.words <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            ((4 - 3) + 0) + 32.SetProgress(progress:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg);
            val_15 = this.words;
            if(null <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[typeof(System.Collections.Generic.List<T>).SyncRoot + 32] + 48) != 0)
            {
                    int val_14 = this.<answerCount>k__BackingField;
                val_14 = val_14 + 1;
                this.<answerCount>k__BackingField = val_14;
            }
            
            val_15 = val_15 + 1;
            if(val_15 >= val_14)
            {
                goto label_29;
            }
            
            if(this.words != null)
            {
                goto label_30;
            }
            
            label_3:
            val_3.ClearLevelProgress();
            return;
            label_29:
            Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.SetRightAnswer(words:  Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetDailyRightAnswerList());
        }
        private void SaveLevelProgress()
        {
            var val_3;
            var val_4;
            string val_14;
            List.Enumerator<T> val_2 = this.words.GetEnumerator();
            label_5:
            val_14 = public System.Boolean List.Enumerator<View.CommonItem.Word>::MoveNext();
            if(val_4.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = 0.CreateString(val:  val_3 + 104);
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(item:  val_14);
            goto label_5;
            label_2:
            val_4.Dispose();
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyPrayerBoxProgress(data:  new System.Collections.Generic.List<System.String>());
            List.Enumerator<T> val_9 = this.words.GetEnumerator();
            label_11:
            val_14 = public System.Boolean List.Enumerator<View.CommonItem.Word>::MoveNext();
            if(val_4.MoveNext() == false)
            {
                goto label_8;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Add(item:  val_3 + 40);
            goto label_11;
            label_8:
            val_4.Dispose();
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyPrayerBoxProgressIsTest(data:  "TestMonth");
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyPrayerBoxProgressTest(data:  new System.Collections.Generic.List<System.String>());
        }
        private void ClearLevelProgress()
        {
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyPrayerBoxProgress(data:  0);
            Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SaveDailyRightAnswerList(data:  0);
        }
        public void DestroyBoxes()
        {
            var val_4;
            if(true < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.words.GetEnumerator();
            label_8:
            if(0.MoveNext() == false)
            {
                goto label_3;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.DestroyBoxes();
            val_4 = mem[public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184];
            val_4 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184;
            View.CommonItem.Word val_3 = val_4.Recycle<View.CommonItem.Word>(obj:  0, isUi:  true);
            goto label_8;
            label_3:
            0.Dispose();
            this.words.Clear();
        }
        public void ClearWordContent()
        {
            this.continuousFailCount = 0;
            this.starProgress = 0;
            this._wordTemp = 0;
            this.lastFailWord = "";
            this.allFailCount = 0;
            this.comboCount = 0;
            this._allDoveLetterBoxes.Clear();
            this.<answerCount>k__BackingField = 0;
            Logic.DailyPrayer.DailyPrayerControllers val_1 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_1.<NowCurLevelUseHintCount>k__BackingField = 0;
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_2.<NowCurLevelWrongCount>k__BackingField = 0;
            Logic.DailyPrayer.DailyPrayerControllers val_3 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_3.<NowCurLevelMaxComboCount>k__BackingField = 0;
            this.DestroyBoxes();
        }
        private void CheckLetterGiftBoxPos()
        {
            System.Collections.Generic.List<View.CommonItem.Word> val_3;
            View.CommonItem.Word val_4;
            if(this.words < 1)
            {
                    return;
            }
            
            if((Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>.Instance.IsHaveLetterGiftBox()) == false)
            {
                    return;
            }
            
            val_3 = this.words;
            if((public static View.Dialog.FreeGiftTest.Controller.FreeGiftTestController Common.SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>::get_Instance()) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_3 = this.words;
            }
            
            val_4 = System.Int32 System.Array::InternalArray__IndexOf<HitInfo>(HitInfo item);
            this._wordTemp = val_4;
            if(1152921508081656432 >= 2)
            {
                    var val_4 = 1;
                do
            {
                if(1152921508081656432 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_4 = this._wordTemp;
                bool val_3 = this._wordTemp._isAnswered;
                if(val_3 != false)
            {
                    if(val_3 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 8;
                val_4 = mem[(this._wordTemp._isAnswered + 8) + 32];
                val_4 = (this._wordTemp._isAnswered + 8) + 32;
                this._wordTemp = val_4;
            }
            
                val_3 = this.words;
                val_4 = val_4 + 1;
            }
            while(val_4 < val_3);
            
            }
            
            if(((this._wordTemp._isAnswered + 8) + 32 + 48) != 0)
            {
                    return;
            }
            
            val_4.CheckLetterGiftBoxPos();
        }
        private void GiftBoxGiveFreeHint()
        {
            var val_9;
            System.Predicate<View.CommonItem.Word> val_11;
            string val_12;
            val_9 = null;
            val_9 = null;
            val_11 = DailyPrayerWordContent.<>c.<>9__73_0;
            if(val_11 == null)
            {
                    System.Predicate<View.CommonItem.Word> val_1 = null;
                val_11 = val_1;
                val_1 = new System.Predicate<View.CommonItem.Word>(object:  DailyPrayerWordContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DailyPrayerWordContent.<>c::<GiftBoxGiveFreeHint>b__73_0(View.CommonItem.Word x));
                DailyPrayerWordContent.<>c.<>9__73_0 = val_11;
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
                    val_2._word = val_4;
                val_2.InitLetterBox();
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
            
            this.SaveLevelProgress();
        }
        private void OnEnable()
        {
            Message.Messager.Add<View.CommonItem.LetterBox>(cmd:  31, action:  new System.Action<View.CommonItem.LetterBox>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::ShowHintWordFromDove(View.CommonItem.LetterBox letterBox)));
            Message.Messager.Add(cmd:  57, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::HintClick()));
            Message.Messager.Add(cmd:  69, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GiftBoxGiveFreeHint()));
            Message.Messager.Add(cmd:  70, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::LogEventFailCount()));
            Message.Messager.Add(cmd:  100, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GetFireworkWords()));
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GetNewDoveLetter()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::PlayCombo()));
            Message.Messager.Remove<View.CommonItem.LetterBox>(cmd:  31, action:  new System.Action<View.CommonItem.LetterBox>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::ShowHintWordFromDove(View.CommonItem.LetterBox letterBox)));
            Message.Messager.Remove(cmd:  57, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::HintClick()));
            Message.Messager.Remove(cmd:  69, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GiftBoxGiveFreeHint()));
            Message.Messager.Remove(cmd:  70, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::LogEventFailCount()));
            Message.Messager.Remove(cmd:  100, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerWordContent::GetFireworkWords()));
        }
        public DailyPrayerWordContent()
        {
            this.wordVerticalRatioSpacing = ;
            this.wordHorizontalRatioSpacing = ;
            this.letterRatioSpacing = 0.08f;
            this.maxSize = 120f;
            this.words = new System.Collections.Generic.List<View.CommonItem.Word>();
            this.wordsLengthSet = new System.Collections.Generic.HashSet<System.Int32>();
            this.lastFailWord = "";
            this._allDoveLetterBoxes = new System.Collections.Generic.List<View.CommonItem.LetterBox>();
            this.letterBoxes = new System.Collections.Generic.List<View.CommonItem.LetterBox>(capacity:  5);
        }
        private void <InitWordContent>b__35_0()
        {
            this.GetNewDoveLetter();
        }
    
    }

}
