using UnityEngine;

namespace View.CommonItem
{
    public class ShopRewardItem : RecyclableItem
    {
        // Fields
        private readonly UnityEngine.Vector3 ScaleCoin;
        private readonly UnityEngine.Vector3 ScaleHint;
        public UnityEngine.Sprite[] SpriteIcons;
        public UnityEngine.UI.Image ImageIcon;
        public UnityEngine.UI.Text TextCount;
        
        // Methods
        public static View.CommonItem.ShopRewardItem Create(UnityEngine.Transform parent, View.CommonItem.ShopRewardItem prefab)
        {
            View.CommonItem.ShopRewardItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.ShopRewardItem>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            return val_1;
        }
        public void SetRewardItemInfo(Data.Bean.RewardItem data)
        {
            string val_9;
            UnityEngine.UI.Image val_10;
            val_9 = data.type;
            if((val_9.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_COIN)) == false)
            {
                goto label_5;
            }
            
            val_10 = this;
            this.ImageIcon.sprite = this.SpriteIcons[0];
            UnityEngine.Transform val_2 = this.ImageIcon.transform;
            goto label_21;
            label_5:
            val_9 = data.type;
            if((val_9.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_HINT)) == false)
            {
                goto label_15;
            }
            
            val_10 = this;
            this.ImageIcon.sprite = this.SpriteIcons[1];
            UnityEngine.Transform val_4 = this.ImageIcon.transform;
            goto label_21;
            label_15:
            val_9 = data.type;
            val_10 = this.ImageIcon;
            if((val_9.Equals(value:  Data.Shop.ShopRewardItemName.ITEM_FIREWORK)) == false)
            {
                goto label_25;
            }
            
            this.ImageIcon.sprite = this.SpriteIcons[2];
            val_9 = mem[this.ImageIcon].transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            label_21:
            val_9.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            label_25:
            string val_8 = "x" + data.count;
        }
        public ShopRewardItem()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.27f);
            this.ScaleCoin = val_2;
            mem[1152921512901653612] = val_2.y;
            mem[1152921512901653616] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.9f);
            this.ScaleHint = val_4;
            mem[1152921512901653624] = val_4.y;
            mem[1152921512901653628] = val_4.z;
        }
    
    }

}
