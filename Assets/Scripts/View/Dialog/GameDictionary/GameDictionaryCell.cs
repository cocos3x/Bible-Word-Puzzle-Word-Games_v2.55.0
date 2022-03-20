using UnityEngine;

namespace View.Dialog.GameDictionary
{
    public class GameDictionaryCell : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshProUGUI TextContent;
        private const string DefinesFormat = "{0}.{1}";
        
        // Methods
        public static View.Dialog.GameDictionary.GameDictionaryCell Create(UnityEngine.Transform parent, View.Dialog.GameDictionary.GameDictionaryCell itemPrefab)
        {
            View.Dialog.GameDictionary.GameDictionaryCell val_1 = UnityEngine.Object.Instantiate<View.Dialog.GameDictionary.GameDictionaryCell>(original:  itemPrefab);
            val_1.name = itemPrefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            return val_1;
        }
        public void SetDefines(int index, string defines)
        {
            this.TextContent.text = System.String.Format(format:  "{0}.{1}", arg0:  index + 1, arg1:  defines);
        }
        public GameDictionaryCell()
        {
        
        }
    
    }

}
