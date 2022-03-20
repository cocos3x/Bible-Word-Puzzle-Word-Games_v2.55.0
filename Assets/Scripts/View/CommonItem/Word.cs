using UnityEngine;

namespace View.CommonItem
{
    public class Word : RecyclableItem
    {
        // Fields
        public View.CommonItem.LetterBox letterBoxPrefab;
        private View.CommonItem.LetterBox _letterBoxTemp;
        private string _word;
        private bool _isAnswered;
        private bool initCenterPosition;
        private UnityEngine.Vector3 _centerPosition;
        private bool <isBonus>k__BackingField;
        private UnityEngine.RectTransform rectTransform;
        private UnityEngine.UI.HorizontalLayoutGroup horizontalLayout;
        private System.Collections.Generic.List<View.CommonItem.LetterBox> letterBoxes;
        private System.Collections.Generic.List<View.CommonItem.LetterBox> _doveLetterBoxes;
        private char[] progress;
        
        // Properties
        public string word { get; set; }
        public UnityEngine.Vector3 anchoredPosition { get; set; }
        public UnityEngine.Vector3 localScale { get; set; }
        public float spacing { set; }
        public float size { set; }
        public bool isAnswered { get; set; }
        public UnityEngine.Vector3 centerPosition { get; }
        public bool isBonus { get; set; }
        
        // Methods
        public static View.CommonItem.Word Create(UnityEngine.Transform parent, View.CommonItem.Word wordPrefab, bool isBonus, string word)
        {
            View.CommonItem.Word val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.Word>(prefab:  wordPrefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = wordPrefab.name + "_" + word;
            val_1.<isBonus>k__BackingField = isBonus;
            val_1._word = word;
            val_1.InitLetterBox();
            return val_1;
        }
        public string get_word()
        {
            return (string)this._word;
        }
        public void set_word(string value)
        {
            this._word = value;
            this.InitLetterBox();
        }
        public UnityEngine.Vector3 get_anchoredPosition()
        {
            UnityEngine.Vector2 val_1 = this.rectTransform.anchoredPosition;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public void set_anchoredPosition(UnityEngine.Vector3 value)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
            this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public UnityEngine.Vector3 get_localScale()
        {
            return this.transform.localScale;
        }
        public void set_localScale(UnityEngine.Vector3 value)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
        public void set_spacing(float value)
        {
            UnityEngine.Rect val_1 = this.rectTransform.rect;
            float val_2 = val_1.m_XMin.height;
            val_2 = val_2 * value;
            this.horizontalLayout.spacing = val_2;
        }
        public void set_size(float value)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  value);
            UnityEngine.Rect val_3 = this.rectTransform.rect;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_3.m_XMin.height);
            this.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public bool get_isAnswered()
        {
            return (bool)this._isAnswered;
        }
        public void set_isAnswered(bool value)
        {
            this._isAnswered = value;
        }
        public void SetIsAnswered(bool value)
        {
            this._isAnswered = value;
        }
        public void CollectBonusCoin()
        {
            var val_8;
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_9;
            float val_11;
            string val_14;
            var val_15;
            var val_16;
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1);
            val_8 = 0;
            val_9 = this.letterBoxes;
            var val_9 = 4;
            do
            {
                var val_3 = val_9 - 4;
                if(val_3 >= 15228928)
            {
                    return;
            }
            
                if(val_3 == 15228927)
            {
                    if(val_3 >= 15228928)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_5 = 1735290732.contentPosition;
                val_11 = val_5.y;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_11, z = val_5.z});
                val_14 = "bonus_word";
                val_15 = 0;
                val_16 = Common.GlobalProperty.GetBonusReward();
            }
            else
            {
                    if(val_3 >= 15228928)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_7 = 1735290732.contentPosition;
                val_11 = val_7.y;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_11, z = val_7.z});
                val_14 = "bonus_word";
                val_15 = 0;
                val_16 = 0;
            }
            
                GainCoinEffect(amount:  0, from:  val_14, centerPosition:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, time:  0.6f, delay:  0f, onFinish:  0, count:  0);
                val_9 = this.letterBoxes;
                val_9 = val_9 + 1;
            }
            while(val_9 != null);
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 get_centerPosition()
        {
            float val_10;
            float val_11;
            float val_12;
            if(this.initCenterPosition != false)
            {
                    return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            }
            
            this.initCenterPosition = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_10 = val_1.x;
            val_11 = val_1.y;
            val_12 = val_1.z;
            List.Enumerator<T> val_2 = this.letterBoxes.GetEnumerator();
            goto label_6;
            label_10:
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_3 = 0.contentPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_10 = val_4.x;
            val_11 = val_4.y;
            val_12 = val_4.z;
            label_6:
            if(0.MoveNext() == true)
            {
                goto label_10;
            }
            
            0.Dispose();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12}, d:  2.123345E+07f);
            this._centerPosition = val_6;
            mem[1152921512904771624] = val_6.y;
            mem[1152921512904771628] = val_6.z;
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public bool get_isBonus()
        {
            return (bool)this.<isBonus>k__BackingField;
        }
        public void set_isBonus(bool value)
        {
            this.<isBonus>k__BackingField = value;
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            this.rectTransform = val_1;
            this.horizontalLayout = this.GetComponent<UnityEngine.UI.HorizontalLayoutGroup>();
            return;
            label_2:
        }
        private void InitLetterBox()
        {
            string val_7 = this._word;
            this.progress = new char[0];
            var val_8 = 0;
            do
            {
                if(val_8 >= this._word.m_stringLength)
            {
                    return;
            }
            
                char val_2 = val_7.Chars[0];
                if(val_8 < val_7)
            {
                    val_7 = val_7 & 4294967295;
                if(val_8 >= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                View.CommonItem.LetterBox val_3 = System.String.__il2cppRuntimeField_byval_arg.SetLetterSprite(_letter:  val_2);
            }
            else
            {
                    View.CommonItem.LetterBox val_5 = View.CommonItem.LetterBox.Create(parent:  this.transform, letterBoxPrefab:  this.letterBoxPrefab, letter:  val_2);
            }
            
                this.progress[0] = ((val_5.<isShow>k__BackingField) == true) ? (48 + 1) : 48;
                val_5.isBonus = this.<isBonus>k__BackingField;
                if(val_8 >= this.progress[0])
            {
                    this.letterBoxes.Add(item:  val_5);
            }
            
                val_8 = val_8 + 1;
            }
            while(this._word != null);
            
            throw new NullReferenceException();
        }
        public void ShowAnswer(UnityEngine.Vector3 from, System.Action onComplete)
        {
            System.Action val_2;
            var val_3;
            this._isAnswered = true;
            var val_5 = 0;
            label_13:
            if(val_5 >= 15228928)
            {
                    return;
            }
            
            if(15228928 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            mem[8439871481544863703] = true;
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_3 = this.letterBoxes;
            if(val_5 != (val_3 - 1))
            {
                goto label_6;
            }
            
            float val_2 = 0f;
            val_2 = val_2 * 0.1f;
            val_2 = onComplete;
            goto label_7;
            label_6:
            val_3 = val_3 - 2;
            float val_4 = 0f;
            val_4 = val_4 * 0.1f;
            if(val_5 != val_3)
            {
                goto label_8;
            }
            
            val_3 = 1;
            val_2 = 0;
            goto label_9;
            label_8:
            val_2 = 0;
            label_7:
            val_3 = 0;
            label_9:
            1735290732.PlayShow(delay:  val_4, from:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z}, onComplete:  val_2, useSound:  false);
            if(val_5 < this.progress.Length)
            {
                    this.progress[0] = '1';
            }
            
            val_5 = val_5 + 1;
            if(this.letterBoxes != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
        }
        public string GetNotFoundLetters()
        {
            var val_3;
            string val_4;
            val_3 = 0;
            val_4 = "";
            do
            {
                if(val_3 >= "")
            {
                    return (string)val_4;
            }
            
                if("" <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(mem[1152921512905711515] != true)
            {
                    val_4 = val_4 + mem[1152921512905711520] + 24.ToString()(mem[1152921512905711520] + 24.ToString());
            }
            
                val_3 = val_3 + 1;
            }
            while(this.letterBoxes != null);
            
            throw new NullReferenceException();
        }
        public View.CommonItem.LetterBox GetFireworkLetter()
        {
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_6;
            var val_7;
            System.Predicate<View.CommonItem.LetterBox> val_9;
            var val_10;
            bool val_6 = true;
            int val_1 = this.GetHintBoxIndex();
            val_6 = this.letterBoxes;
            if(val_1 < val_6)
            {
                    if(val_6 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + (val_1 << 3);
                mem2[0] = 1;
                this.progress[((long)(int)(val_1)) << 1] = '1';
                val_7 = null;
                val_7 = null;
                val_9 = Word.<>c.<>9__40_0;
                if(val_9 == null)
            {
                    System.Predicate<View.CommonItem.LetterBox> val_2 = null;
                val_9 = val_2;
                val_2 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<GetFireworkLetter>b__40_0(View.CommonItem.LetterBox x));
                Word.<>c.<>9__40_0 = val_9;
            }
            
                val_6 = this.letterBoxes;
                bool val_5 = UnityEngine.Object.op_Equality(x:  this.letterBoxes.Find(match:  val_9), y:  0);
                this._isAnswered = val_5;
                if(val_5 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + (((long)(int)(val_1)) << 3);
                val_10 = mem[((val_4 & 1) + ((long)(int)(val_1)) << 3) + 32];
                val_10 = ((val_4 & 1) + ((long)(int)(val_1)) << 3) + 32;
                return (View.CommonItem.LetterBox)val_10;
            }
            
            val_10 = 0;
            return (View.CommonItem.LetterBox)val_10;
        }
        public System.Collections.Generic.List<View.CommonItem.LetterBox> GetDoveLetterBoxes(char doveLetter)
        {
            var val_1;
            this._doveLetterBoxes.Clear();
            val_1 = 0;
            do
            {
                if(val_1 >= 1152921512644114000)
            {
                    return (System.Collections.Generic.List<View.CommonItem.LetterBox>)this._doveLetterBoxes;
            }
            
                if(1152921512644114000 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((((mem[1152921512834738928] + 24) == doveLetter) && (mem[1152921512834738923] != true)) && (mem[1152921512834738922] != true))
            {
                    this._doveLetterBoxes.Add(item:  "isArray");
            }
            
                val_1 = val_1 + 1;
            }
            while(this.letterBoxes != null);
            
            throw new NullReferenceException();
        }
        public bool CheckShowLettersFromAnswer(string answer)
        {
            var val_3;
            var val_4;
            bool val_3 = true;
            val_3 = 0;
            label_10:
            if(val_3 >= val_3)
            {
                goto label_2;
            }
            
            if(val_3 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(((true + 0) + 32 + 107) != 0)
            {
                    if((val_3 >= answer.m_stringLength) || ((answer.Chars[0] & 65535) != ((true + 0) + 32 + 112 + 24)))
            {
                goto label_9;
            }
            
            }
            
            val_3 = val_3 + 1;
            if(this.letterBoxes != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_9:
            val_4 = 0;
            return (bool)val_4;
            label_2:
            val_4 = 1;
            return (bool)val_4;
        }
        public bool WordIsContainLetterBox(View.CommonItem.LetterBox letterBox)
        {
            typeof(Word.<>c__DisplayClass43_0).__il2cppRuntimeField_10 = letterBox;
            return UnityEngine.Object.op_Inequality(x:  this.letterBoxes.Find(match:  new System.Predicate<View.CommonItem.LetterBox>(object:  new System.Object(), method:  System.Boolean Word.<>c__DisplayClass43_0::<WordIsContainLetterBox>b__0(View.CommonItem.LetterBox x))), y:  0);
        }
        public View.CommonItem.LetterBox WordIsContainLetterGiftBox()
        {
            var val_2;
            System.Predicate<View.CommonItem.LetterBox> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = Word.<>c.<>9__44_0;
            if(val_4 != null)
            {
                    return this.letterBoxes.Find(match:  val_4 = val_1);
            }
            
            System.Predicate<View.CommonItem.LetterBox> val_1 = null;
            val_1 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<WordIsContainLetterGiftBox>b__44_0(View.CommonItem.LetterBox x));
            Word.<>c.<>9__44_0 = val_4;
            return this.letterBoxes.Find(match:  val_4);
        }
        public System.Collections.Generic.List<View.CommonItem.LetterBox> WordIsUnShowLetterBox()
        {
            var val_2;
            System.Predicate<View.CommonItem.LetterBox> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = Word.<>c.<>9__45_0;
            if(val_4 != null)
            {
                    return this.letterBoxes.FindAll(match:  val_4 = val_1);
            }
            
            System.Predicate<View.CommonItem.LetterBox> val_1 = null;
            val_1 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<WordIsUnShowLetterBox>b__45_0(View.CommonItem.LetterBox x));
            Word.<>c.<>9__45_0 = val_4;
            return this.letterBoxes.FindAll(match:  val_4);
        }
        public void Shake()
        {
            bool val_1 = true;
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.Shake();
                val_2 = val_2 + 1;
            }
            while(this.letterBoxes != null);
            
            throw new NullReferenceException();
        }
        public int GetHintBoxIndex()
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            do
            {
                if(val_1 >= val_1)
            {
                    return (int)val_1;
            }
            
                if(val_1 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                if(((true + 0) + 32 + 107) == 0)
            {
                    return (int)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(this.letterBoxes != null);
            
            throw new NullReferenceException();
        }
        public int GetHintBoxIndex(View.CommonItem.LetterBox letterBox)
        {
            var val_2;
            bool val_2 = true;
            val_2 = 0;
            do
            {
                if(val_2 >= val_2)
            {
                    return (int)val_2;
            }
            
                val_2 = val_2 & 4294967295;
                if(val_2 >= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                if((((true & 4294967295) + 0) + 32) == letterBox)
            {
                    return (int)val_2;
            }
            
                val_2 = val_2 + 1;
            }
            while(this.letterBoxes != null);
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetHintBoxPosition()
        {
            bool val_3 = true;
            int val_1 = this.GetHintBoxIndex();
            if(val_1 >= val_3)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if(val_3 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_1 << 3);
            return Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  (true + (val_1) << 3) + 32.transform);
        }
        public UnityEngine.Vector3 GetStarBoxPosition()
        {
            if(true != 0)
            {
                    return Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  0.transform);
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            return Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  0.transform);
        }
        public void ShowHint(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, float time, float delay)
        {
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_6;
            var val_7;
            System.Predicate<View.CommonItem.LetterBox> val_9;
            bool val_6 = true;
            int val_1 = this.GetHintBoxIndex();
            val_6 = this.letterBoxes;
            if(val_1 < val_6)
            {
                    if(val_6 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + (val_1 << 3);
                var val_7 = (true + (val_1) << 3) + 32;
                mem2[0] = 1;
                if(val_7 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + (((long)(int)(val_1)) << 3);
                ((true + (val_1) << 3) + 32 + ((long)(int)(val_1)) << 3) + 32.PlayHint(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = endPosition.x, y = endPosition.y, z = endPosition.z}, time:  time, delay:  delay);
                this.progress[((long)(int)(val_1)) << 1] = '1';
                val_6 = this.letterBoxes;
            }
            
            val_7 = null;
            val_7 = null;
            val_9 = Word.<>c.<>9__51_0;
            if(val_9 == null)
            {
                    System.Predicate<View.CommonItem.LetterBox> val_2 = null;
                val_9 = val_2;
                val_2 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<ShowHint>b__51_0(View.CommonItem.LetterBox x));
                Word.<>c.<>9__51_0 = val_9;
            }
            
            this._isAnswered = UnityEngine.Object.op_Equality(x:  val_6.Find(match:  val_9), y:  0);
        }
        public void ShowHint(View.CommonItem.LetterBox letterBox)
        {
            var val_6;
            System.Predicate<View.CommonItem.LetterBox> val_8;
            int val_1 = this.GetHintBoxIndex(letterBox:  letterBox);
            bool val_6 = true;
            letterBox.<isShow>k__BackingField = val_6;
            if(val_6 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_1 << 3);
            (true + (val_1) << 3) + 32.PlayHint();
            this.progress[((long)(int)(val_1)) << 1] = '1';
            val_6 = null;
            val_6 = null;
            val_8 = Word.<>c.<>9__52_0;
            if(val_8 == null)
            {
                    System.Predicate<View.CommonItem.LetterBox> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<ShowHint>b__52_0(View.CommonItem.LetterBox x));
                Word.<>c.<>9__52_0 = val_8;
            }
            
            this._isAnswered = UnityEngine.Object.op_Equality(x:  this.letterBoxes.Find(match:  val_8), y:  0);
        }
        public void ShowFreeHint()
        {
            var val_8;
            System.Predicate<View.CommonItem.LetterBox> val_10;
            View.CommonItem.LetterBox val_1 = this.WordIsContainLetterGiftBox();
            this._letterBoxTemp = val_1;
            if(val_1 == 0)
            {
                    return;
            }
            
            int val_3 = this.GetHintBoxIndex(letterBox:  this._letterBoxTemp);
            View.CommonItem.LetterBox val_8 = this._letterBoxTemp;
            this._letterBoxTemp.<isShow>k__BackingField = true;
            if(val_8 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_3 << 3);
            (this._letterBoxTemp + (val_3) << 3).ImageBg.PlayFreeHint();
            this.progress[((long)(int)(val_3)) << 1] = '1';
            val_8 = null;
            val_8 = null;
            val_10 = Word.<>c.<>9__53_0;
            if(val_10 == null)
            {
                    System.Predicate<View.CommonItem.LetterBox> val_4 = null;
                val_10 = val_4;
                val_4 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<ShowFreeHint>b__53_0(View.CommonItem.LetterBox x));
                Word.<>c.<>9__53_0 = val_10;
            }
            
            this._isAnswered = UnityEngine.Object.op_Equality(x:  this.letterBoxes.Find(match:  val_10), y:  0);
        }
        public void ShowStar()
        {
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            mem2[-4611686018427387797] = 1;
        }
        public string GetProgress()
        {
            return 0.CreateString(val:  this.progress);
        }
        public bool IsEmptyWord()
        {
            var val_3;
            System.Predicate<View.CommonItem.LetterBox> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = Word.<>c.<>9__56_0;
            if(val_5 != null)
            {
                    return UnityEngine.Object.op_Equality(x:  this.letterBoxes.Find(match:  val_5 = val_1), y:  0);
            }
            
            System.Predicate<View.CommonItem.LetterBox> val_1 = null;
            val_1 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<IsEmptyWord>b__56_0(View.CommonItem.LetterBox x));
            Word.<>c.<>9__56_0 = val_5;
            return UnityEngine.Object.op_Equality(x:  this.letterBoxes.Find(match:  val_5), y:  0);
        }
        public bool IsHaveEmptyLetter()
        {
            var val_3;
            System.Predicate<View.CommonItem.LetterBox> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = Word.<>c.<>9__57_0;
            if(val_5 != null)
            {
                    return UnityEngine.Object.op_Inequality(x:  this.letterBoxes.Find(match:  val_5 = val_1), y:  0);
            }
            
            System.Predicate<View.CommonItem.LetterBox> val_1 = null;
            val_1 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<IsHaveEmptyLetter>b__57_0(View.CommonItem.LetterBox x));
            Word.<>c.<>9__57_0 = val_5;
            return UnityEngine.Object.op_Inequality(x:  this.letterBoxes.Find(match:  val_5), y:  0);
        }
        public bool IsFindLetter(char letter)
        {
            typeof(Word.<>c__DisplayClass58_0).__il2cppRuntimeField_10 = letter;
            return UnityEngine.Object.op_Inequality(x:  this.letterBoxes.Find(match:  new System.Predicate<View.CommonItem.LetterBox>(object:  new System.Object(), method:  System.Boolean Word.<>c__DisplayClass58_0::<IsFindLetter>b__0(View.CommonItem.LetterBox x))), y:  0);
        }
        public void SetProgress(string progress)
        {
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_11;
            System.Collections.Generic.List<View.CommonItem.LetterBox> val_12;
            int val_13;
            bool val_14;
            var val_15;
            bool val_14 = true;
            if(progress == null)
            {
                goto label_1;
            }
            
            val_11 = this.letterBoxes;
            int val_11 = progress.m_stringLength;
            if(val_11 != W9)
            {
                goto label_3;
            }
            
            if(val_11 < 1)
            {
                goto label_14;
            }
            
            var val_13 = 1;
            label_15:
            int val_1 = val_13 - 1;
            if(val_11 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_1 << 3);
            var val_4 = ((progress.Chars[val_1] & 65535) == '1') ? 1 : 0;
            mem2[0] = val_4;
            if(val_4 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (((long)(int)((1 - 1))) << 3);
            var val_12 = (val_3 == '1' ? 1 : 0 + ((long)(int)((1 - 1))) << 3) + 32 + 107;
            if(val_12 != 0)
            {
                    if(val_12 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + (((long)(int)((1 - 1))) << 3);
            }
            
            if(val_13 >= progress.m_stringLength)
            {
                goto label_14;
            }
            
            val_13 = val_13 + 1;
            if(this.letterBoxes != null)
            {
                goto label_15;
            }
            
            label_1:
            val_12 = this.letterBoxes;
            var val_15 = 0;
            label_21:
            if(val_15 >= val_14)
            {
                goto label_40;
            }
            
            if(val_14 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            mem2[0] = 0;
            val_15 = val_15 + 1;
            if(this.letterBoxes != null)
            {
                goto label_21;
            }
            
            label_3:
            object[] val_5 = new object[4];
            val_5[0] = "Word set progress error, progress length not match, progress.Length : ";
            val_13 = val_5.Length;
            val_5[1] = progress.m_stringLength;
            val_13 = val_5.Length;
            val_5[2] = ", count :";
            val_5[3] = this.letterBoxes;
            UnityEngine.Debug.LogWarning(message:  +val_5);
            val_12 = this.letterBoxes;
            var val_16 = 0;
            label_43:
            if(val_16 >= null)
            {
                goto label_40;
            }
            
            if(null <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Debug.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_6B = 0;
            val_12 = this.letterBoxes;
            val_16 = val_16 + 1;
            if(val_12 != null)
            {
                goto label_43;
            }
            
            throw new NullReferenceException();
            label_40:
            val_14 = 0;
            goto label_44;
            label_14:
            this.progress = progress.ToCharArray();
            val_11 = 1152921504815046656;
            val_15 = null;
            val_15 = null;
            val_12 = Word.<>c.<>9__59_0;
            if(val_12 == null)
            {
                    System.Predicate<View.CommonItem.LetterBox> val_8 = null;
                val_12 = val_8;
                val_8 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<SetProgress>b__59_0(View.CommonItem.LetterBox x));
                Word.<>c.<>9__59_0 = val_12;
            }
            
            val_14 = UnityEngine.Object.op_Equality(x:  this.letterBoxes.Find(match:  val_12), y:  0);
            label_44:
            this._isAnswered = val_14;
        }
        public void ChangeToGuideCanvas()
        {
            List.Enumerator<T> val_1 = this.letterBoxes.GetEnumerator();
            label_4:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  0.gameObject, name:  "Dialog", order:  6);
            goto label_4;
            label_2:
            0.Dispose();
        }
        public void ChangeToGuideCanvas(int order)
        {
            List.Enumerator<T> val_1 = this.letterBoxes.GetEnumerator();
            label_4:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  0.gameObject, name:  "Dialog", order:  order);
            goto label_4;
            label_2:
            0.Dispose();
        }
        public void ChangeToGuideBox(bool isGuide)
        {
            List.Enumerator<T> val_1 = this.letterBoxes.GetEnumerator();
            label_4:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.ChangeToGuideBox(isGuide:  isGuide);
            goto label_4;
            label_2:
            0.Dispose();
        }
        public void CheckLetterGiftBoxPos()
        {
            var val_4;
            System.Predicate<View.CommonItem.LetterBox> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = Word.<>c.<>9__63_0;
            if(val_6 == null)
            {
                    System.Predicate<View.CommonItem.LetterBox> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Predicate<View.CommonItem.LetterBox>(object:  Word.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Word.<>c::<CheckLetterGiftBoxPos>b__63_0(View.CommonItem.LetterBox x));
                Word.<>c.<>9__63_0 = val_6;
            }
            
            View.CommonItem.LetterBox val_2 = this.letterBoxes.Find(match:  val_6);
            this._letterBoxTemp = val_2;
            if(val_2 == 0)
            {
                    return;
            }
            
            this._letterBoxTemp.ShowGiftBox();
        }
        public void DestroyBoxes()
        {
            List.Enumerator<T> val_1 = this.letterBoxes.GetEnumerator();
            label_6:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            View.CommonItem.LetterBox val_3 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.CommonItem.LetterBox>(obj:  0, isUi:  true);
            goto label_6;
            label_2:
            0.Dispose();
            this.letterBoxes.Clear();
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this._isAnswered = false;
            this.initCenterPosition = false;
            this.progress = 0;
            this.letterBoxes.Clear();
        }
        public Word()
        {
            this.letterBoxes = new System.Collections.Generic.List<View.CommonItem.LetterBox>();
            this._doveLetterBoxes = new System.Collections.Generic.List<View.CommonItem.LetterBox>();
        }
    
    }

}
