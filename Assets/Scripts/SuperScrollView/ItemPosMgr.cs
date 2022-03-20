using UnityEngine;

namespace SuperScrollView
{
    public class ItemPosMgr
    {
        // Fields
        public const int mItemMaxCountPerGroup = 100;
        private System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> mItemSizeGroupList;
        private int mDirtyBeginIndex;
        public float mTotalSize;
        public float mItemDefaultSize;
        
        // Methods
        public ItemPosMgr(float itemDefaultSize)
        {
            this.mItemSizeGroupList = new System.Collections.Generic.List<SuperScrollView.ItemSizeGroup>();
            this.mDirtyBeginIndex = 2147483647;
            this.mItemDefaultSize = 20f;
            this.mItemDefaultSize = itemDefaultSize;
        }
        public void SetItemMaxCount(int maxCount)
        {
            var val_7;
            var val_8;
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_9;
            var val_10;
            int val_1 = (0 > 0) ? (0 + 1) : 0;
            var val_2 = (0 < 1) ? 100 : 0;
            this.mDirtyBeginIndex = 0;
            this.mTotalSize = 0f;
            if(0 > 1)
            {
                    this.mItemSizeGroupList.RemoveRange(index:  val_1, count:  W22 - val_1);
            }
            else
            {
                    if(0 < 1)
            {
                    var val_4 = val_1 - W22;
                if(val_4 >= 1)
            {
                    val_8 = 1152921504832405504;
                var val_6 = 0;
                do
            {
                object val_5 = null;
                val_7 = W22 + val_6;
                typeof(SuperScrollView.ItemSizeGroup).__il2cppRuntimeField_24 = 100;
                val_5 = new System.Object();
                typeof(SuperScrollView.ItemSizeGroup).__il2cppRuntimeField_34 = val_7;
                typeof(SuperScrollView.ItemSizeGroup).__il2cppRuntimeField_38 = this.mItemDefaultSize;
                Init();
                this.mItemSizeGroupList.Add(item:  val_5);
                val_6 = val_6 + 1;
            }
            while(val_6 < val_4);
            
            }
            
            }
            
            }
            
            val_9 = this.mItemSizeGroupList;
            if(null == 0)
            {
                    return;
            }
            
            if(1152921504832405503 >= 1)
            {
                    var val_7 = 0;
                val_8 = 100;
                do
            {
                if(val_5 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                SuperScrollView.ItemSizeGroup.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_20 = 100;
                SuperScrollView.ItemSizeGroup.__il2cppRuntimeField_byval_arg.RecalcGroupSize();
                val_9 = this.mItemSizeGroupList;
                val_7 = val_7 + 1;
            }
            while(val_7 < 1152921504832405503);
            
            }
            else
            {
                    val_10 = val_5;
            }
            
            if(val_10 <= 1152921504832405503)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = mem[1152921506636873752] + 32;
            if(val_8 != val_2)
            {
                    mem2[0] = val_2;
                mem[1152921506636873752].RecalcGroupSize();
            }
            
            if(val_5 < 1)
            {
                    return;
            }
            
            float val_9 = this.mTotalSize;
            do
            {
                if(val_8 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + 0;
                val_7 = 0 + 1;
                val_9 = val_9 + ((mem[1152921506636873752] + 32 + 0) + 32 + 40);
                this.mTotalSize = val_9;
            }
            while(val_7 < val_5);
        
        }
        public void SetItemSize(int itemIndex, float size)
        {
            var val_2 = 0;
            if(W9 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            itemIndex = itemIndex - (0 * 100);
            float val_1 = (0 + 0) + 32.SetItemSize(index:  itemIndex, size:  size);
            if((val_1 != 0f) && (0 < this.mDirtyBeginIndex))
            {
                    this.mDirtyBeginIndex = 0;
            }
            
            val_1 = val_1 + this.mTotalSize;
            this.mTotalSize = val_1;
        }
        public float GetItemPos(int itemIndex)
        {
            this.Update(updateAll:  true);
            var val_2 = 0;
            if(W9 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            return (0 + 0) + 32.GetItemStartPos(index:  itemIndex - (0 * 100));
        }
        public void GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
        {
            var val_6;
            this.Update(updateAll:  true);
            index = 0;
            itemPos = 0f;
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_5 = this.mItemSizeGroupList;
            if(val_5 == null)
            {
                    return;
            }
            
            val_6 = val_5 - 1;
            if(<0)
            {
                    return;
            }
            
            var val_6 = 0;
            label_12:
            val_5 = val_6 + val_6;
            var val_1 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            var val_2 = val_1 >> 1;
            if(W9 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (val_2 << 3);
            float val_7 = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 44;
            if(val_7 <= pos)
            {
                    if(((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 44 + 4) >= pos)
            {
                goto label_8;
            }
            
            }
            
            if(((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 44 + 4) >= 0)
            {
                goto label_9;
            }
            
            val_6 = val_2 + 1;
            if(val_2 < val_6)
            {
                goto label_12;
            }
            
            return;
            label_9:
            val_6 = val_2 - 1;
            if(val_6 < val_2)
            {
                goto label_12;
            }
            
            return;
            label_8:
            val_7 = pos - val_7;
            int val_3 = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32.GetItemIndexByPos(pos:  val_7);
            if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
            int val_8 = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 52;
            val_8 = val_3 + (val_8 * 100);
            index = val_8;
            itemPos = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32.GetItemStartPos(index:  val_3);
        }
        public void Update(bool updateAll)
        {
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_8;
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_9;
            bool val_7 = true;
            val_8 = this.mItemSizeGroupList;
            if(W22 == 0)
            {
                    return;
            }
            
            if(this.mDirtyBeginIndex >= W22)
            {
                    return;
            }
            
            var val_9 = 1;
            do
            {
                val_9 = this.mDirtyBeginIndex + val_9;
                int val_1 = val_9 - 1;
                if(val_7 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + (val_1 << 3);
                val_8 = mem[(true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32];
                val_8 = (true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32;
                int val_2 = this.mDirtyBeginIndex + 1;
                this.mDirtyBeginIndex = val_2;
                val_8.UpdateAllItemStartPos();
                if(val_9 == 1)
            {
                    mem2[0] = 0;
                mem2[0] = (true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32 + 40;
            }
            else
            {
                    val_9 = this.mItemSizeGroupList;
                int val_4 = (this.mDirtyBeginIndex + val_9) - 2;
                if(val_2 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (val_4 << 3);
                float val_8 = (true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32 + 40;
                val_8 = (((this.mDirtyBeginIndex + 1) + (((this.mDirtyBeginIndex + 1) - 2)) << 3) + 32 + 48) + val_8;
                mem2[0] = ((this.mDirtyBeginIndex + 1) + (((this.mDirtyBeginIndex + 1) - 2)) << 3) + 32 + 48;
                mem2[0] = val_8;
            }
            
                var val_5 = (val_9 < 2) ? 1 : 0;
                val_5 = val_5 | updateAll;
                if(val_5 == false)
            {
                    return;
            }
            
                if((this.mDirtyBeginIndex + val_9) >= W22)
            {
                    return;
            }
            
                val_8 = this.mItemSizeGroupList;
                val_9 = val_9 + 1;
            }
            while(val_8 != null);
            
            throw new NullReferenceException();
        }
    
    }

}
