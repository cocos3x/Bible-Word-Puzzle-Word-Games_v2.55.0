using UnityEngine;

namespace SuperScrollView
{
    public class ItemPool
    {
        // Fields
        private UnityEngine.GameObject mPrefabObj;
        private string mPrefabName;
        private int mInitCreateCount;
        private float mPadding;
        private float mStartPosOffset;
        private System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> mTmpPooledItemList;
        private System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> mPooledItemList;
        private static int mCurItemIdCount;
        private UnityEngine.RectTransform mItemParent;
        
        // Methods
        public ItemPool()
        {
            this.mInitCreateCount = 1;
            this.mTmpPooledItemList = new System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>();
            this.mPooledItemList = new System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>();
        }
        public void Init(UnityEngine.GameObject prefabObj, float padding, float startPosOffset, int createCount, UnityEngine.RectTransform parent)
        {
            this.mPrefabObj = prefabObj;
            this.mPrefabName = prefabObj.name;
            this.mInitCreateCount = createCount;
            this.mPadding = padding;
            this.mStartPosOffset = startPosOffset;
            this.mItemParent = parent;
            this.mPrefabObj.SetActive(value:  false);
            if(this.mInitCreateCount < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.RecycleItemReal(item:  this.CreateItem());
                val_3 = val_3 + 1;
            }
            while(val_3 < this.mInitCreateCount);
        
        }
        public SuperScrollView.LoopListViewItem2 GetItem()
        {
            var val_3;
            var val_4;
            var val_5;
            int val_3 = SuperScrollView.ItemPool.mCurItemIdCount;
            val_3 = val_3 + 1;
            SuperScrollView.ItemPool.mCurItemIdCount = val_3;
            val_3 = 1152921504832622591;
            if()
            {
                goto label_2;
            }
            
            val_4 = mem[1152921506638827544];
            val_5 = public System.Void System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>::RemoveAt(int index);
            goto label_3;
            label_2:
            if(SuperScrollView.ItemPool.mCurItemIdCount == 0)
            {
                goto label_5;
            }
            
            val_3 = 1152921504832622591;
            val_3 = val_3 + 1806204920;
            val_4 = mem[((SuperScrollView.ItemPool.mCurItemIdCount + 1) + 1806204920) + 32];
            val_4 = ((SuperScrollView.ItemPool.mCurItemIdCount + 1) + 1806204920) + 32;
            val_5 = public System.Void System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>::RemoveAt(int index);
            label_3:
            this.mPooledItemList.RemoveAt(index:  225775615);
            val_4.gameObject.SetActive(value:  true);
            label_8:
            mem2[0] = this.mPadding;
            mem2[0] = SuperScrollView.ItemPool.mCurItemIdCount;
            return (SuperScrollView.LoopListViewItem2)val_4;
            label_5:
            if(this.CreateItem() != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
        }
        public void DestroyAllItem()
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_2;
            var val_3;
            bool val_2 = true;
            this.ClearTmpRecycledItem();
            val_2 = this.mPooledItemList;
            val_3 = 0;
            label_7:
            if(val_3 >= W22)
            {
                goto label_2;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            UnityEngine.Object.DestroyImmediate(obj:  (true + 0) + 32.gameObject);
            val_2 = this.mPooledItemList;
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2.Clear();
        }
        public SuperScrollView.LoopListViewItem2 CreateItem()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.mPrefabObj, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, parent:  this.mItemParent);
            val_3.SetActive(value:  true);
            UnityEngine.RectTransform val_4 = val_3.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            val_4.localEulerAngles = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_8.mItemPrefabName = this.mPrefabName;
            val_8.mStartPosOffset = this.mStartPosOffset;
            return (SuperScrollView.LoopListViewItem2)val_3.GetComponent<SuperScrollView.LoopListViewItem2>();
        }
        private void RecycleItemReal(SuperScrollView.LoopListViewItem2 item)
        {
            item.gameObject.SetActive(value:  false);
            this.mPooledItemList.Add(item:  item);
        }
        public void RecycleItem(SuperScrollView.LoopListViewItem2 item)
        {
            this.mTmpPooledItemList.Add(item:  item);
        }
        public void ClearTmpRecycledItem()
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_1;
            bool val_1 = true;
            val_1 = this.mTmpPooledItemList;
            if(W21 == 0)
            {
                    return;
            }
            
            var val_2 = 0;
            label_5:
            if(val_2 >= X21)
            {
                goto label_3;
            }
            
            if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            this.RecycleItemReal(item:  (true + 0) + 32);
            val_1 = this.mTmpPooledItemList;
            val_2 = val_2 + 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_3:
            val_1.Clear();
        }
    
    }

}
