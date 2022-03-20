using UnityEngine;

namespace View.Dialog.Extra
{
    public class ExtraWordItem : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TextWord;
        
        // Methods
        public static View.Dialog.Extra.ExtraWordItem Create(UnityEngine.Transform parent, View.Dialog.Extra.ExtraWordItem itemPrefab)
        {
            View.Dialog.Extra.ExtraWordItem val_1 = UnityEngine.Object.Instantiate<View.Dialog.Extra.ExtraWordItem>(original:  itemPrefab);
            val_1.name = itemPrefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public UnityEngine.GameObject GetExtraWordItemObject()
        {
            return this.gameObject;
        }
        public void SetWord(string word)
        {
            if(this.TextWord != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public ExtraWordItem()
        {
        
        }
    
    }

}
