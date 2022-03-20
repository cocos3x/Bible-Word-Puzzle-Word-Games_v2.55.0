using UnityEngine;

namespace View.CommonItem
{
    public class SelectedLetter : MonoBehaviour
    {
        // Fields
        private View.CommonItem.Letter <letter>k__BackingField;
        
        // Properties
        public View.CommonItem.Letter letter { get; set; }
        
        // Methods
        public static View.CommonItem.SelectedLetter Create(UnityEngine.Transform parent, View.CommonItem.SelectedLetter selectedLetterPrefab, char letter)
        {
            View.CommonItem.SelectedLetter val_1 = UnityEngine.Object.Instantiate<View.CommonItem.SelectedLetter>(original:  selectedLetterPrefab);
            val_1.name = selectedLetterPrefab.name + "_" + letter.ToString();
            val_1.<letter>k__BackingField.letter = letter;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public View.CommonItem.Letter get_letter()
        {
            return (View.CommonItem.Letter)this.<letter>k__BackingField;
        }
        public void set_letter(View.CommonItem.Letter value)
        {
            this.<letter>k__BackingField = value;
        }
        private void Awake()
        {
            this.<letter>k__BackingField = this.GetComponentInChildren<View.CommonItem.Letter>();
        }
        public SelectedLetter()
        {
        
        }
    
    }

}
