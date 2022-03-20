using UnityEngine;

namespace View.Dialog.PurchaseSuccess
{
    public class PurchaseRewardItem : RecyclableItem
    {
        // Fields
        private readonly UnityEngine.Vector3 ScaleCoin;
        private readonly UnityEngine.Vector3 ScaleHint;
        private readonly UnityEngine.Vector3 ScaleFirework;
        public UnityEngine.Sprite[] SpriteIcons;
        public UnityEngine.UI.Image ImageIcon;
        public UnityEngine.UI.Text TextCount;
        
        // Methods
        public static View.Dialog.PurchaseSuccess.PurchaseRewardItem Create(UnityEngine.Transform parent, View.Dialog.PurchaseSuccess.PurchaseRewardItem prefab)
        {
            View.Dialog.PurchaseSuccess.PurchaseRewardItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.PurchaseSuccess.PurchaseRewardItem>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            return val_1;
        }
        public void SetRewardItemInfo(Data.Bean.RewardItem data)
        {
            UnityEngine.UI.Image val_8;
            if((data.type.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_COIN)) == false)
            {
                goto label_5;
            }
            
            val_8 = this;
            this.ImageIcon.sprite = this.SpriteIcons[0];
            UnityEngine.Transform val_2 = this.ImageIcon.transform;
            goto label_21;
            label_5:
            if((data.type.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_HINT)) == false)
            {
                goto label_15;
            }
            
            val_8 = this;
            this.ImageIcon.sprite = this.SpriteIcons[1];
            UnityEngine.Transform val_4 = this.ImageIcon.transform;
            goto label_21;
            label_15:
            val_8 = this.ImageIcon;
            if((data.type.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_FIREWORK)) == false)
            {
                goto label_25;
            }
            
            this.ImageIcon.sprite = this.SpriteIcons[2];
            label_21:
            mem[this.ImageIcon].transform.localScale = new UnityEngine.Vector3() {x = this.ScaleFirework};
            label_25:
            string val_7 = "x" + data.count;
        }
        public PurchaseRewardItem()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.216f);
            this.ScaleCoin = val_2;
            mem[1152921512720907212] = val_2.y;
            mem[1152921512720907216] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.71f);
            this.ScaleHint = val_4;
            mem[1152921512720907224] = val_4.y;
            mem[1152921512720907228] = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.8f);
            this.ScaleFirework = val_6;
            mem[1152921512720907236] = val_6.y;
            mem[1152921512720907240] = val_6.z;
        }
    
    }

}
