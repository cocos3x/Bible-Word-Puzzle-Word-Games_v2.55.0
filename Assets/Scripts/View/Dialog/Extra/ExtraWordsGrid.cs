using UnityEngine;

namespace View.Dialog.Extra
{
    public class ExtraWordsGrid : MonoBehaviour
    {
        // Fields
        public View.Dialog.Extra.ExtraWordItem extraWordItemPrefab;
        private int nLineItemCount;
        private UnityEngine.Transform[] Panel;
        private System.Collections.Generic.List<View.Dialog.Extra.ExtraWordItem> extraWordItems;
        
        // Methods
        private void Awake()
        {
            object val_4 = 0;
            do
            {
                if(val_4 >= this.Panel.Length)
            {
                    return;
            }
            
                this.Panel[val_4] = this.transform.Find(n:  "Panel_" + val_4);
                val_4 = val_4 + 1;
            }
            while(this.Panel != null);
            
            throw new NullReferenceException();
        }
        public void SetWords(ref System.Collections.Generic.List<string> words)
        {
            this.ClearExtraWordItems();
            if(val_1 == null)
            {
                    return;
            }
            
            if((mem[words + 24]) < 1)
            {
                    return;
            }
            
            this.CreateExtraWordItems(words: ref  System.Collections.Generic.List<System.String> val_1 = words);
        }
        private void CreateExtraWordItems(ref System.Collections.Generic.List<string> words)
        {
            View.Dialog.Extra.ExtraWordItem val_2;
            var val_5 = 0;
            do
            {
                if(val_5 >= (mem[words + 24]))
            {
                    return;
            }
            
                int val_2 = this.nLineItemCount;
                val_2 = val_5 / val_2;
                if(val_2 >= this.Panel.Length)
            {
                    return;
            }
            
                val_2 = View.Dialog.Extra.ExtraWordItem.Create(parent:  this.Panel[val_2], itemPrefab:  this.extraWordItemPrefab);
                if(val_5 >= (mem[words + 24]))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_4 = mem[words + 16];
                val_4 = val_4 + 0;
                this.extraWordItems.Add(item:  val_2);
                val_5 = val_5 + 1;
            }
            while(words != null);
            
            throw new NullReferenceException();
        }
        private void ClearExtraWordItems()
        {
            System.Collections.Generic.List<View.Dialog.Extra.ExtraWordItem> val_4;
            bool val_4 = true;
            val_4 = this.extraWordItems;
            if(val_4 >= 1)
            {
                    var val_5 = 0;
                do
            {
                if(val_4 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                if(((true + 0) + 32.gameObject) != 0)
            {
                    if(null <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Object.Destroy(obj:  UnityEngine.Object.__il2cppRuntimeField_byval_arg.gameObject);
            }
            
                val_4 = this.extraWordItems;
                val_5 = val_5 + 1;
            }
            while(val_5 < null);
            
            }
            
            val_4.Clear();
        }
        public ExtraWordsGrid()
        {
            this.nLineItemCount = 3;
            this.Panel = new UnityEngine.Transform[5];
            this.extraWordItems = new System.Collections.Generic.List<View.Dialog.Extra.ExtraWordItem>();
        }
    
    }

}
