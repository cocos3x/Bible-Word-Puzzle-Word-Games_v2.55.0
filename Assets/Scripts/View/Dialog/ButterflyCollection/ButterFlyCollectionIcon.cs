using UnityEngine;

namespace View.Dialog.ButterflyCollection
{
    public class ButterFlyCollectionIcon : MonoBehaviour
    {
        // Fields
        public ButterFlyIcon Icon;
        public TMPro.TextMeshProUGUI TextName;
        
        // Methods
        public void SetButterFlyInfo(int index, bool isCollect)
        {
            bool val_4;
            string val_5;
            val_4 = isCollect;
            isCollect = val_4;
            this.Icon.SetButterFlyIcon(index:  index, isCollect:  isCollect);
            if(val_4 == false)
            {
                goto label_5;
            }
            
            val_4 = 1152921512618525072;
            Data.ButterFly.ButterFlyDataManager val_1 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            if(val_1.ButterFlyNames.Length <= index)
            {
                goto label_5;
            }
            
            Data.ButterFly.ButterFlyDataManager val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            val_5 = Locale.LocaleManager.Translate(key:  val_2.ButterFlyNames[index]);
            goto label_10;
            label_5:
            val_5 = "?";
            label_10:
            this.TextName.text = val_5;
        }
        public ButterFlyCollectionIcon()
        {
        
        }
    
    }

}
