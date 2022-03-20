using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleBookMapChest : MonoBehaviour
    {
        // Fields
        public UnityEngine.Sprite[] SpriteChests;
        public UnityEngine.UI.Image ImageChest;
        private Data.Bible.BibleChestType _type;
        
        // Methods
        public void SetChestInfo(Data.Bible.BibleChestType type)
        {
            this._type = type;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(type == 0)
            {
                goto label_2;
            }
            
            val_1.SetActive(value:  true);
            if(type != 1)
            {
                goto label_4;
            }
            
            if(this.ImageChest != null)
            {
                goto label_6;
            }
            
            label_2:
            val_1.SetActive(value:  false);
            return;
            label_4:
            label_6:
            this.ImageChest.sprite = null;
            UnityEngine.Transform val_2 = this.ImageChest.transform;
            if(type != 1)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            if(val_2 != null)
            {
                goto label_14;
            }
            
            label_11:
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.28f);
            label_14:
            val_2.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void OpenChest()
        {
            this.gameObject.SetActive(value:  false);
            object[] val_2 = new object[1];
            val_2[0] = this._type;
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MapChestTestDialog", pars:  val_2);
        }
        public MainBibleBookMapChest()
        {
        
        }
    
    }

}
