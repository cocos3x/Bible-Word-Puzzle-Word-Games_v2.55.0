using UnityEngine;

namespace View.Dialog.GameDictionary
{
    public class DictionaryWordContent : MonoBehaviour
    {
        // Fields
        public View.Dialog.GameDictionary.GameDictionaryCell CellItemPrefab;
        public UnityEngine.UI.ScrollRect ScrollViewDefines;
        public UnityEngine.Transform Content;
        public UnityEngine.UI.Text TextWord;
        public UnityEngine.UI.Button ButtonLeft;
        public UnityEngine.UI.Button ButtonRight;
        public UnityEngine.UI.Text TextMark;
        private System.Collections.Generic.List<View.Dialog.GameDictionary.GameDictionaryCell> _cells;
        private Data.GameDictionary.DictionaryWordData _wordData;
        private System.Collections.Generic.List<string> _rightAnswer;
        private int _nowPageIndex;
        
        // Methods
        public void ShowWordContents()
        {
            View.Dialog.GameDictionary.Controller.GameDictionaryController val_1 = Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance;
            this._wordData = val_1._wordData;
            View.Dialog.GameDictionary.Controller.GameDictionaryController val_2 = Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance;
            System.Collections.Generic.List<System.String> val_3 = val_2._rightAnswer;
            this._rightAnswer = val_3;
            val_3 = val_3 - 1;
            this._nowPageIndex = val_3;
            this.UpdateNowPageContent();
        }
        public void OnClickLeftButton()
        {
            int val_1 = this._nowPageIndex;
            val_1 = val_1 - 1;
            this._nowPageIndex = val_1;
            this.UpdateNowPageContent();
        }
        public void OnClickRightButton()
        {
            int val_1 = this._nowPageIndex;
            val_1 = val_1 + 1;
            this._nowPageIndex = val_1;
            this.UpdateNowPageContent();
        }
        public void UpdateNowPageContent()
        {
            UnityEngine.RectTransform val_12;
            System.Collections.Generic.List<System.String> val_13;
            val_12 = this;
            this.ButtonLeft.gameObject.SetActive(value:  (this._nowPageIndex > 0) ? 1 : 0);
            System.Collections.Generic.List<System.String> val_16 = this._rightAnswer;
            val_16 = val_16 - 1;
            this.ButtonRight.gameObject.SetActive(value:  (this._nowPageIndex < val_16) ? 1 : 0);
            this.HideAllCells();
            val_13 = this._rightAnswer;
            if(this._nowPageIndex >= val_16)
            {
                    return;
            }
            
            if(val_16 <= this._nowPageIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + ((this._nowPageIndex) << 3);
            int val_17 = this._nowPageIndex;
            val_17 = val_17 + 1;
            string val_5 = val_17 + "/"("/") + this._rightAnswer;
            var val_18 = 1152921512645544032;
            val_13 = this._rightAnswer;
            if(val_18 <= this._nowPageIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + ((this._nowPageIndex) << 3);
            if((Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance.FindDefinesFromWord(word:  (1152921512645544032 + (this._nowPageIndex) << 3) + 32)) != null)
            {
                    if(val_18 >= 1)
            {
                    var val_19 = 4;
                do
            {
                var val_8 = val_19 - 4;
                if((this._cells != null) && (val_8 < val_18))
            {
                    val_18 = val_18 & 4294967295;
                if(val_8 >= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                ((1152921512645544032 + (this._nowPageIndex) << 3) & 4294967295) + 32.gameObject.SetActive(value:  true);
                if(val_8 >= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = mem[((1152921512645544032 + (this._nowPageIndex) << 3) & 4294967295) + 32];
                val_13 = ((1152921512645544032 + (this._nowPageIndex) << 3) & 4294967295) + 32;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_13.SetDefines(index:  val_19 - 4, defines:  ((1152921512645544032 + (this._nowPageIndex) << 3) & 4294967295) + 32);
            }
            else
            {
                    val_13 = View.Dialog.GameDictionary.GameDictionaryCell.Create(parent:  this.Content, itemPrefab:  this.CellItemPrefab);
                if(val_8 >= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13.SetDefines(index:  val_19 - 4, defines:  (1152921512645544032 + (this._nowPageIndex) << 3) + 32);
                this._cells.Add(item:  val_13);
            }
            
                val_19 = val_19 + 1;
            }
            while((val_19 - 3) < val_18);
            
            }
            
                val_12 = this.ScrollViewDefines.m_Content;
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
                val_12.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "dictionary", action:  "failword", label:  "fail", value:  0);
        }
        private void ErrorContent()
        {
        
        }
        private void HideAllCells()
        {
            bool val_2 = true;
            if(this._cells == null)
            {
                    return;
            }
            
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                (true + 0) + 32.gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(val_3 < val_2);
        
        }
        private View.Dialog.GameDictionary.GameDictionaryCell CreateCell()
        {
            return View.Dialog.GameDictionary.GameDictionaryCell.Create(parent:  this.Content, itemPrefab:  this.CellItemPrefab);
        }
        public DictionaryWordContent()
        {
            this._cells = new System.Collections.Generic.List<View.Dialog.GameDictionary.GameDictionaryCell>();
        }
    
    }

}
