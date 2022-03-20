using UnityEngine;

namespace SuperScrollView
{
    public class LoopListView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SuperScrollView.ItemPool> mItemPoolDict;
        private System.Collections.Generic.List<SuperScrollView.ItemPool> mItemPoolList;
        private System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData> mItemPrefabDataList;
        private SuperScrollView.ListItemArrangeType mArrangeType;
        private System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> mItemList;
        private UnityEngine.RectTransform mContainerTrans;
        private UnityEngine.UI.ScrollRect mScrollRect;
        private UnityEngine.RectTransform mScrollRectTransform;
        private UnityEngine.RectTransform mViewPortRectTransform;
        private float mItemDefaultWithPaddingSize;
        private int mItemTotalCount;
        private bool mIsVertList;
        private System.Func<SuperScrollView.LoopListView2, int, SuperScrollView.LoopListViewItem2> mOnGetItemByIndex;
        private UnityEngine.Vector3[] mItemWorldCorners;
        private UnityEngine.Vector3[] mViewPortRectLocalCorners;
        private int mCurReadyMinItemIndex;
        private int mCurReadyMaxItemIndex;
        private bool mNeedCheckNextMinItem;
        private bool mNeedCheckNextMaxItem;
        private SuperScrollView.ItemPosMgr mItemPosMgr;
        private float mDistanceForRecycle0;
        private float mDistanceForNew0;
        private float mDistanceForRecycle1;
        private float mDistanceForNew1;
        private bool mSupportScrollBar;
        private bool mIsDraging;
        private UnityEngine.EventSystems.PointerEventData mPointerEventData;
        public System.Action mOnBeginDragAction;
        public System.Action mOnDragingAction;
        public System.Action mOnEndDragAction;
        private int mLastItemIndex;
        private float mLastItemPadding;
        private float mSmoothDumpVel;
        private float mSmoothDumpRate;
        private float mSnapFinishThreshold;
        private float mSnapVecThreshold;
        private bool mItemSnapEnable;
        private UnityEngine.Vector3 mLastFrameContainerPos;
        public System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2> mOnSnapItemFinished;
        public System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2> mOnSnapNearestChanged;
        private int mCurSnapNearestItemIndex;
        private UnityEngine.Vector2 mAdjustedVec;
        private bool mNeedAdjustVec;
        private int mLeftSnapUpdateExtraCount;
        private UnityEngine.Vector2 mViewPortSnapPivot;
        private UnityEngine.Vector2 mItemSnapPivot;
        private SuperScrollView.ClickEventListener mScrollBarClickEventListener;
        private SuperScrollView.LoopListView2.SnapData mCurSnapData;
        private UnityEngine.Vector3 mLastSnapCheckPos;
        private bool mListViewInited;
        private int mListUpdateCheckFrameCount;
        
        // Properties
        public SuperScrollView.ListItemArrangeType ArrangeType { get; set; }
        public bool IsVertList { get; }
        public int ItemTotalCount { get; }
        public UnityEngine.RectTransform ContainerTrans { get; }
        public UnityEngine.UI.ScrollRect ScrollRect { get; }
        public bool IsDraging { get; }
        public bool ItemSnapEnable { get; set; }
        public bool SupportScrollBar { get; set; }
        public int ShownItemCount { get; }
        public float ViewPortSize { get; }
        public float ViewPortWidth { get; }
        public float ViewPortHeight { get; }
        public int CurSnapNearestItemIndex { get; }
        
        // Methods
        public SuperScrollView.ListItemArrangeType get_ArrangeType()
        {
            return (SuperScrollView.ListItemArrangeType)this.mArrangeType;
        }
        public void set_ArrangeType(SuperScrollView.ListItemArrangeType value)
        {
            this.mArrangeType = value;
        }
        public bool get_IsVertList()
        {
            return (bool)this.mIsVertList;
        }
        public int get_ItemTotalCount()
        {
            return (int)this.mItemTotalCount;
        }
        public UnityEngine.RectTransform get_ContainerTrans()
        {
            return (UnityEngine.RectTransform)this.mContainerTrans;
        }
        public UnityEngine.UI.ScrollRect get_ScrollRect()
        {
            return (UnityEngine.UI.ScrollRect)this.mScrollRect;
        }
        public bool get_IsDraging()
        {
            return (bool)this.mIsDraging;
        }
        public bool get_ItemSnapEnable()
        {
            return (bool)this.mItemSnapEnable;
        }
        public void set_ItemSnapEnable(bool value)
        {
            this.mItemSnapEnable = value;
        }
        public bool get_SupportScrollBar()
        {
            return (bool)this.mSupportScrollBar;
        }
        public void set_SupportScrollBar(bool value)
        {
            this.mSupportScrollBar = value;
        }
        public SuperScrollView.ItemPrefabConfData GetItemPrefabConfData(string prefabName)
        {
            var val_2;
            var val_3;
            UnityEngine.Object val_8;
            string val_9;
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            val_9 = prefabName;
            List.Enumerator<T> val_1 = this.mItemPrefabDataList.GetEnumerator();
            label_11:
            val_10 = public System.Boolean List.Enumerator<SuperScrollView.ItemPrefabConfData>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_12 = val_2;
            if(val_12 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = mem[val_2 + 16];
            val_8 = val_2 + 16;
            val_10 = 0;
            if(val_8 != val_10)
            {
                goto label_6;
            }
            
            UnityEngine.Debug.LogError(message:  "A item prefab is null ");
            goto label_11;
            label_6:
            val_11 = mem[val_2 + 16];
            val_11 = val_2 + 16;
            if(val_11 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.String.op_Equality(a:  val_9, b:  val_11.name)) == false)
            {
                goto label_11;
            }
            
            goto label_12;
            label_2:
            val_12 = 0;
            label_12:
            val_3.Dispose();
            return (SuperScrollView.ItemPrefabConfData)val_12;
        }
        public void OnItemPrefabChanged(string prefabName)
        {
            var val_10;
            float val_11;
            float val_12;
            float val_13;
            if((this.GetItemPrefabConfData(prefabName:  prefabName)) == null)
            {
                    return;
            }
            
            if((this.mItemPoolDict.TryGetValue(key:  prefabName, value: out  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            if(W9 >= 1)
            {
                    val_10 = 4960416;
                UnityEngine.Vector3 val_6 = 0.CachedRectTransform.anchoredPosition3D;
                val_11 = val_6.x;
                val_12 = val_6.y;
                val_13 = val_6.z;
            }
            else
            {
                    val_11 = val_4.x;
                val_12 = val_4.y;
                val_13 = val_4.z;
                val_10 = 0;
            }
            
            this.RecycleAllItem();
            this.ClearAllTmpRecycledItem();
            val_2.DestroyAllItem();
            val_2.Init(prefabObj:  val_1.mItemPrefab, padding:  val_1.mPadding, startPosOffset:  val_1.mStartPosOffset, createCount:  val_1.mInitCreateCount, parent:  this.mContainerTrans);
            if(0 != 0)
            {
                    return;
            }
            
            this.RefreshAllShownItemWithFirstIndexAndPos(firstItemIndex:  0, pos:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13});
        }
        public void InitListView(int itemTotalCount, System.Func<SuperScrollView.LoopListView2, int, SuperScrollView.LoopListViewItem2> onGetItemByIndex, SuperScrollView.LoopListViewInitParam initParam)
        {
            SuperScrollView.ItemPosMgr val_11;
            var val_12;
            if(initParam != null)
            {
                    this.mDistanceForRecycle0 = initParam.mDistanceForRecycle0;
                this.mDistanceForNew0 = initParam.mDistanceForNew0;
                this.mDistanceForRecycle1 = initParam.mDistanceForRecycle1;
                this.mDistanceForNew1 = initParam.mDistanceForNew1;
                this.mSmoothDumpRate = initParam.mSmoothDumpRate;
                this.mSnapFinishThreshold = initParam.mSnapFinishThreshold;
                this.mSnapVecThreshold = initParam.mSnapVecThreshold;
                this.mItemDefaultWithPaddingSize = initParam.mItemDefaultWithPaddingSize;
            }
            
            UnityEngine.UI.ScrollRect val_2 = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>();
            this.mScrollRect = val_2;
            if(val_2 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "ListView Init Failed! ScrollRect component not found!");
                return;
            }
            
            if(this.mDistanceForRecycle0 <= this.mDistanceForNew0)
            {
                    UnityEngine.Debug.LogError(message:  "mDistanceForRecycle0 should be bigger than mDistanceForNew0");
            }
            
            if(this.mDistanceForRecycle1 <= this.mDistanceForNew1)
            {
                    UnityEngine.Debug.LogError(message:  "mDistanceForRecycle1 should be bigger than mDistanceForNew1");
            }
            
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mItemPosMgr = new SuperScrollView.ItemPosMgr(itemDefaultSize:  this.mItemDefaultWithPaddingSize);
            this.mScrollRectTransform = this.mScrollRect.GetComponent<UnityEngine.RectTransform>();
            this.mContainerTrans = this.mScrollRect.m_Content;
            this.mViewPortRectTransform = this.mScrollRect.m_Viewport;
            if(this.mScrollRect.m_Viewport == 0)
            {
                    this.mViewPortRectTransform = this.mScrollRectTransform;
            }
            
            if(this.mScrollRect.m_HorizontalScrollbarVisibility == 2)
            {
                    if(this.mScrollRect.m_HorizontalScrollbar != 0)
            {
                    UnityEngine.Debug.LogError(message:  "ScrollRect.horizontalScrollbarVisibility cannot be set to AutoHideAndExpandViewport");
            }
            
            }
            
            if(this.mScrollRect.m_VerticalScrollbarVisibility == 2)
            {
                    if(this.mScrollRect.m_VerticalScrollbar != 0)
            {
                    UnityEngine.Debug.LogError(message:  "ScrollRect.verticalScrollbarVisibility cannot be set to AutoHideAndExpandViewport");
            }
            
            }
            
            this.mIsVertList = (this.mArrangeType < 2) ? 1 : 0;
            this.mScrollRect.m_Horizontal = (this.mArrangeType > 1) ? 1 : 0;
            this.mScrollRect.m_Vertical = this.mIsVertList;
            this.SetScrollbarListener();
            this.AdjustPivot(rtf:  this.mViewPortRectTransform);
            this.AdjustAnchor(rtf:  this.mContainerTrans);
            this.AdjustContainerPivot(rtf:  this.mContainerTrans);
            this.InitItemPool();
            this.mOnGetItemByIndex = onGetItemByIndex;
            if(this.mListViewInited != false)
            {
                    UnityEngine.Debug.LogError(message:  "LoopListView2.InitListView method can be called only once.");
            }
            
            this.mListViewInited = true;
            this.ResetListView(resetPos:  true);
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mItemTotalCount = itemTotalCount;
            if((itemTotalCount & 2147483648) != 0)
            {
                goto label_40;
            }
            
            val_11 = this.mItemPosMgr;
            if(this.mSupportScrollBar == false)
            {
                goto label_41;
            }
            
            val_12 = itemTotalCount;
            goto label_43;
            label_40:
            val_11 = this.mItemPosMgr;
            this.mSupportScrollBar = false;
            label_41:
            val_12 = 0;
            label_43:
            val_11.SetItemMaxCount(maxCount:  0);
            this.mCurReadyMinItemIndex = 0;
            this.mCurReadyMaxItemIndex = 0;
            this.mLeftSnapUpdateExtraCount = 1;
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            this.UpdateContentSize();
        }
        private void SetScrollbarListener()
        {
            UnityEngine.UI.Scrollbar val_8;
            UnityEngine.Object val_9;
            UnityEngine.UI.Scrollbar val_10;
            this.mScrollBarClickEventListener = 0;
            if(this.mIsVertList == false)
            {
                goto label_1;
            }
            
            if(this.mScrollRect.m_VerticalScrollbar == 0)
            {
                goto label_5;
            }
            
            val_8 = this.mScrollRect.m_VerticalScrollbar;
            goto label_7;
            label_1:
            val_8 = 0;
            val_9 = 0;
            goto label_8;
            label_5:
            val_8 = 0;
            label_7:
            val_9 = val_8;
            if(this.mIsVertList == true)
            {
                goto label_13;
            }
            
            label_8:
            val_10 = this.mScrollRect.m_HorizontalScrollbar;
            if(val_10 != 0)
            {
                    val_8 = this.mScrollRect.m_HorizontalScrollbar;
                val_9 = val_8;
            }
            
            label_13:
            if(val_9 == 0)
            {
                    return;
            }
            
            this.mScrollBarClickEventListener = SuperScrollView.ClickEventListener.Get(obj:  val_9.gameObject);
            val_5.mOnPointerUpHandler = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopListView2::OnPointerUpInScrollBar(UnityEngine.GameObject obj));
            System.Action<UnityEngine.GameObject> val_7 = null;
            val_10 = val_7;
            val_7 = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopListView2::OnPointerDownInScrollBar(UnityEngine.GameObject obj));
            val_5.mOnPointerDownHandler = val_10;
        }
        private void OnPointerDownInScrollBar(UnityEngine.GameObject obj)
        {
            if(this.mCurSnapData != null)
            {
                    this.mCurSnapData.mSnapStatus = 0;
                this.mCurSnapData.mIsForceSnapTo = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnPointerUpInScrollBar(UnityEngine.GameObject obj)
        {
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        public void ResetListView(bool resetPos = True)
        {
            this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
            if(resetPos != false)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
                this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            }
            
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        public void SetListItemCount(int itemCount, bool resetPos = True)
        {
            SuperScrollView.ItemPosMgr val_3;
            var val_4;
            var val_5;
            if(this.mItemTotalCount == itemCount)
            {
                    return;
            }
            
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mItemTotalCount = itemCount;
            if((itemCount & 2147483648) != 0)
            {
                goto label_3;
            }
            
            val_3 = this.mItemPosMgr;
            if(this.mSupportScrollBar == false)
            {
                goto label_4;
            }
            
            val_4 = itemCount;
            goto label_6;
            label_3:
            val_3 = this.mItemPosMgr;
            this.mSupportScrollBar = false;
            label_4:
            val_4 = 0;
            label_6:
            val_3.SetItemMaxCount(maxCount:  0);
            if(this.mItemTotalCount == 0)
            {
                goto label_8;
            }
            
            if(this.mCurReadyMaxItemIndex >= this.mItemTotalCount)
            {
                    this.mCurReadyMaxItemIndex = this.mItemTotalCount - 1;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            if(resetPos == true)
            {
                goto label_12;
            }
            
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_2 = this.mItemList;
            if(257 == 0)
            {
                goto label_12;
            }
            
            val_2 = val_2 + 2048;
            val_5 = this.mItemTotalCount - 1;
            if(val_2 <= val_5)
            {
                goto label_14;
            }
            
            goto label_15;
            label_12:
            val_5 = 0;
            label_15:
            this.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
            return;
            label_8:
            this.mNeedCheckNextMinItem = false;
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMinItemIndex = 0;
            this.mCurReadyMaxItemIndex = 0;
            this.RecycleAllItem();
            this.ClearAllTmpRecycledItem();
            this.UpdateContentSize();
            return;
            label_14:
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
        }
        public SuperScrollView.LoopListViewItem2 GetShownItemByItemIndex(int itemIndex)
        {
            return 0;
        }
        public int get_ShownItemCount()
        {
            return 9919;
        }
        public float get_ViewPortSize()
        {
            UnityEngine.Rect val_1 = this.mViewPortRectTransform.rect;
            if(this.mIsVertList == false)
            {
                    return (float)val_1.m_XMin.width;
            }
            
            float val_2 = val_1.m_XMin.height;
            return (float)val_1.m_XMin.width;
        }
        public float get_ViewPortWidth()
        {
            UnityEngine.Rect val_1 = this.mViewPortRectTransform.rect;
            return (float)val_1.m_XMin.width;
        }
        public float get_ViewPortHeight()
        {
            UnityEngine.Rect val_1 = this.mViewPortRectTransform.rect;
            return (float)val_1.m_XMin.height;
        }
        public SuperScrollView.LoopListViewItem2 GetShownItemByIndex(int index)
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            if((index & 2147483648) != 0)
            {
                    return (SuperScrollView.LoopListViewItem2)val_1;
            }
            
            if(val_1 <= index)
            {
                    return (SuperScrollView.LoopListViewItem2)val_1;
            }
            
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            val_1 = mem[(true + (index) << 3) + 32];
            val_1 = (true + (index) << 3) + 32;
            return (SuperScrollView.LoopListViewItem2)val_1;
        }
        public SuperScrollView.LoopListViewItem2 GetShownItemByIndexWithoutCheck(int index)
        {
            bool val_1 = true;
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            return (SuperScrollView.LoopListViewItem2)(true + (index) << 3) + 32;
        }
        public int GetIndexInShownItemList(SuperScrollView.LoopListViewItem2 item)
        {
            var val_3;
            if((item == 0) || (W24 < 1))
            {
                goto label_10;
            }
            
            val_3 = 0;
            label_11:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 0) + 32) == item)
            {
                    return (int)val_3;
            }
            
            val_3 = val_3 + 1;
            if(val_3 >= X24)
            {
                goto label_10;
            }
            
            if(this.mItemList != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_10:
            val_3 = 0;
            return (int)val_3;
        }
        public void DoActionForEachShownItem(System.Action<SuperScrollView.LoopListViewItem2, object> action, object param)
        {
            bool val_1 = true;
            if(action == null)
            {
                    return;
            }
            
            if(21069824 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                action.Invoke(arg1:  (true + 0) + 32, arg2:  param);
                val_2 = val_2 + 1;
                if(val_2 >= 21069824)
            {
                    return;
            }
            
            }
            while(this.mItemList != null);
            
            throw new NullReferenceException();
        }
        public SuperScrollView.LoopListViewItem2 NewListViewItem(string itemPrefabName)
        {
            var val_8;
            if((this.mItemPoolDict.TryGetValue(key:  itemPrefabName, value: out  0)) != false)
            {
                    SuperScrollView.LoopListViewItem2 val_3 = val_1.GetItem();
                val_8 = val_3;
                UnityEngine.RectTransform val_4 = val_3.GetComponent<UnityEngine.RectTransform>();
                val_4.SetParent(p:  this.mContainerTrans);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
                val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
                val_4.localEulerAngles = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                val_3.mParentListView = this;
                return (SuperScrollView.LoopListViewItem2)val_8;
            }
            
            val_8 = 0;
            return (SuperScrollView.LoopListViewItem2)val_8;
        }
        public void OnItemSizeChanged(int itemIndex)
        {
            SuperScrollView.LoopListViewItem2 val_1 = this.GetShownItemByItemIndex(itemIndex:  itemIndex);
            if(val_1 == 0)
            {
                    return;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_4 = val_1.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_5 = val_4.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  itemIndex, itemSize:  val_4.m_XMin.width, padding:  val_1.mPadding);
            }
            
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
        }
        public void RefreshItemByItemIndex(int itemIndex)
        {
            if(true == 0)
            {
                    return;
            }
            
            if((X10 + 24) > itemIndex)
            {
                    return;
            }
        
        }
        public void FinishSnapImmediately()
        {
            this.UpdateSnapMove(immediate:  true, forceSendEvent:  false);
        }
        public void MovePanelToItemIndex(int itemIndex, float offset)
        {
            UnityEngine.Object val_22;
            float val_23;
            var val_26;
            var val_27;
            val_23 = offset;
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            if(this.mItemTotalCount == 0)
            {
                    return;
            }
            
            if((itemIndex & 2147483648) != 0)
            {
                goto label_4;
            }
            
            var val_2 = (this.mItemTotalCount < itemIndex) ? itemIndex : (this.mItemTotalCount - 1);
            label_11:
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_26 = val_3.x;
            val_27 = val_3.y;
            float val_4 = this.ViewPortSize;
            val_23 = val_4;
            float val_5 = (S12 > val_4) ? (val_4) : (S12);
            if(this.mArrangeType > 3)
            {
                goto label_15;
            }
            
            var val_18 = 15769616 + (this.mArrangeType) << 2;
            val_18 = val_18 + 15769616;
            goto (15769616 + (this.mArrangeType) << 2 + 15769616);
            label_4:
            if(this.mItemTotalCount >= 1)
            {
                    return;
            }
            
            goto label_11;
            label_15:
            this.RecycleAllItem();
            val_22 = this.GetNewItemByIndex(index:  itemIndex);
            if(val_22 == 0)
            {
                    this.ClearAllTmpRecycledItem();
                return;
            }
            
             = (this.mIsVertList == true) ? val_10.mStartPosOffset : ();
            val_22.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {y = (this.mIsVertList == true) ? () : val_10.mStartPosOffset, z = V9.16B};
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_15 = val_22.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_16 = val_15.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  itemIndex, itemSize:  val_15.m_XMin.width, padding:  val_10.mPadding);
            }
            
            this.mItemList.Add(item:  val_22);
            this.UpdateContentSize();
            float val_20 = 100f;
            val_20 = val_23 + val_20;
            this.UpdateListView(distanceForRecycle0:  val_20, distanceForRecycle1:  val_20, distanceForNew0:  val_23, distanceForNew1:  val_23);
            this.AdjustPanelPos();
            this.ClearAllTmpRecycledItem();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            this.UpdateSnapMove(immediate:  false, forceSendEvent:  true);
        }
        public void RefreshAllShownItem()
        {
            if(W9 == 0)
            {
                    return;
            }
            
            this.RefreshAllShownItemWithFirstIndex(firstItemIndex:  0);
        }
        public void RefreshAllShownItemWithFirstIndex(int firstItemIndex)
        {
            UnityEngine.Object val_13;
            var val_14;
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = 9904.CachedRectTransform.anchoredPosition3D;
            val_14 = val_2.x;
            this.RecycleAllItem();
            if(W23 < 1)
            {
                goto label_8;
            }
            
            var val_13 = 0;
            label_16:
            int val_3 = firstItemIndex + val_13;
            val_13 = this.GetNewItemByIndex(index:  val_3);
            if(val_13 == 0)
            {
                goto label_8;
            }
            
            val_13.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = (this.mIsVertList == true) ? val_4.mStartPosOffset : (val_14), y = (this.mIsVertList == true) ? val_2.y : val_4.mStartPosOffset, z = val_2.z};
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_10 = val_13.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_11 = val_10.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  val_3, itemSize:  val_10.m_XMin.width, padding:  val_4.mPadding);
            }
            
            this.mItemList.Add(item:  val_13);
            val_13 = val_13 + 1;
            if(val_13 < W23)
            {
                goto label_16;
            }
            
            label_8:
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
            this.ClearAllTmpRecycledItem();
        }
        public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, UnityEngine.Vector3 pos)
        {
            this.RecycleAllItem();
            SuperScrollView.LoopListViewItem2 val_1 = this.GetNewItemByIndex(index:  firstItemIndex);
            if(val_1 == 0)
            {
                    return;
            }
            
            pos.x = (this.mIsVertList == true) ? val_1.mStartPosOffset : pos.x;
            pos.y = (this.mIsVertList == true) ? pos.y : val_1.mStartPosOffset;
            val_1.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_5 = val_1.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_6 = val_5.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  firstItemIndex, itemSize:  val_5.m_XMin.width, padding:  val_1.mPadding);
            }
            
            this.mItemList.Add(item:  val_1);
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
            this.UpdateListView(distanceForRecycle0:  this.mDistanceForRecycle0, distanceForRecycle1:  this.mDistanceForRecycle1, distanceForNew0:  this.mDistanceForNew0, distanceForNew1:  this.mDistanceForNew1);
            this.ClearAllTmpRecycledItem();
        }
        private void RecycleItemTmp(SuperScrollView.LoopListViewItem2 item)
        {
            if(item == 0)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  item.mItemPrefabName)) == true)
            {
                    return;
            }
            
            if((this.mItemPoolDict.TryGetValue(key:  item.mItemPrefabName, value: out  0)) == false)
            {
                    return;
            }
            
            val_3.RecycleItem(item:  item);
        }
        private void ClearAllTmpRecycledItem()
        {
            bool val_1 = true;
            if(21069824 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.ClearTmpRecycledItem();
                val_2 = val_2 + 1;
                if(val_2 >= 21069824)
            {
                    return;
            }
            
            }
            while(this.mItemPoolList != null);
            
            throw new NullReferenceException();
        }
        private void RecycleAllItem()
        {
            List.Enumerator<T> val_1 = this.mItemList.GetEnumerator();
            label_3:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            this.RecycleItemTmp(item:  0);
            goto label_3;
            label_2:
            0.Dispose();
            this.mItemList.Clear();
        }
        private void AdjustContainerPivot(UnityEngine.RectTransform rtf)
        {
            UnityEngine.Vector2 val_1 = rtf.pivot;
            if(this.mArrangeType <= 3)
            {
                    var val_2 = 15769600 + (this.mArrangeType) << 2;
                val_2 = val_2 + 15769600;
            }
            else
            {
                    rtf.pivot = new UnityEngine.Vector2() {x = 1f, y = val_1.y};
            }
        
        }
        private void AdjustPivot(UnityEngine.RectTransform rtf)
        {
            UnityEngine.Vector2 val_1 = rtf.pivot;
            if(this.mArrangeType <= 3)
            {
                    var val_2 = 15769568 + (this.mArrangeType) << 2;
                val_2 = val_2 + 15769568;
            }
            else
            {
                    rtf.pivot = new UnityEngine.Vector2() {x = 1f, y = val_1.y};
            }
        
        }
        private void AdjustContainerAnchor(UnityEngine.RectTransform rtf)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Vector2 val_1 = rtf.anchorMin;
            val_3 = val_1.x;
            UnityEngine.Vector2 val_2 = rtf.anchorMax;
            val_4 = val_2.x;
            if(this.mArrangeType <= 3)
            {
                    var val_3 = 15769664 + (this.mArrangeType) << 2;
                val_3 = val_3 + 15769664;
            }
            else
            {
                    val_5 = val_2.y;
                rtf.anchorMin = new UnityEngine.Vector2() {x = val_3, y = val_1.y};
                rtf.anchorMax = new UnityEngine.Vector2() {x = val_4, y = val_5};
            }
        
        }
        private void AdjustAnchor(UnityEngine.RectTransform rtf)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Vector2 val_1 = rtf.anchorMin;
            val_3 = val_1.x;
            UnityEngine.Vector2 val_2 = rtf.anchorMax;
            val_4 = val_2.x;
            if(this.mArrangeType <= 3)
            {
                    var val_3 = 15769584 + (this.mArrangeType) << 2;
                val_3 = val_3 + 15769584;
            }
            else
            {
                    val_5 = val_2.y;
                rtf.anchorMin = new UnityEngine.Vector2() {x = val_3, y = val_1.y};
                rtf.anchorMax = new UnityEngine.Vector2() {x = val_4, y = val_5};
            }
        
        }
        private void InitItemPool()
        {
            var val_2;
            var val_3;
            UnityEngine.Object val_16;
            System.Collections.Generic.Dictionary<System.String, SuperScrollView.ItemPool> val_17;
            List.Enumerator<T> val_1 = this.mItemPrefabDataList.GetEnumerator();
            label_31:
            val_16 = public System.Boolean List.Enumerator<SuperScrollView.ItemPrefabConfData>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            if((val_2 + 16) != val_16)
            {
                goto label_6;
            }
            
            UnityEngine.Debug.LogError(message:  "A item prefab is null ");
            goto label_31;
            label_6:
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            string val_6 = val_17.name;
            val_17 = this.mItemPoolDict;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = val_6;
            if((val_17.ContainsKey(key:  val_16)) == false)
            {
                goto label_12;
            }
            
            UnityEngine.Debug.LogError(message:  "A item prefab with name " + val_6 + " has existed!"(" has existed!"));
            goto label_31;
            label_12:
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.RectTransform val_9 = val_17.GetComponent<UnityEngine.RectTransform>();
            if(val_9 != 0)
            {
                goto label_19;
            }
            
            UnityEngine.Debug.LogError(message:  "RectTransform component is not found in the prefab " + val_6);
            goto label_31;
            label_19:
            this.AdjustAnchor(rtf:  val_9);
            val_16 = val_9;
            this.AdjustPivot(rtf:  val_16);
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            if((val_17.GetComponent<SuperScrollView.LoopListViewItem2>()) == val_16)
            {
                    val_17 = mem[val_2 + 16];
                val_17 = val_2 + 16;
                if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_16 = public SuperScrollView.LoopListViewItem2 UnityEngine.GameObject::AddComponent<SuperScrollView.LoopListViewItem2>();
                SuperScrollView.LoopListViewItem2 val_14 = val_17.AddComponent<SuperScrollView.LoopListViewItem2>();
            }
            
            val_17 = null;
            val_17 = new SuperScrollView.ItemPool();
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = mem[val_2 + 16];
            val_16 = val_2 + 16;
            Init(prefabObj:  val_16, padding:  val_2 + 24, startPosOffset:  val_2 + 32, createCount:  val_2 + 28, parent:  this.mContainerTrans);
            val_17 = this.mItemPoolDict;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = val_6;
            val_17.Add(key:  val_16, value:  val_17);
            val_17 = this.mItemPoolList;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17.Add(item:  val_17);
            goto label_31;
            label_2:
            val_3.Dispose();
        }
        public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.mIsDraging = true;
            this.CacheDragPointerEventData(eventData:  eventData);
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            if(this.mOnBeginDragAction == null)
            {
                    return;
            }
            
            this.mOnBeginDragAction.Invoke();
        }
        public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.mIsDraging = false;
            this.mPointerEventData = 0;
            if(this.mOnEndDragAction != null)
            {
                    this.mOnEndDragAction.Invoke();
            }
            
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.CacheDragPointerEventData(eventData:  eventData);
            if(this.mOnDragingAction == null)
            {
                    return;
            }
            
            this.mOnDragingAction.Invoke();
        }
        private void CacheDragPointerEventData(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.EventSystems.PointerEventData val_3 = this.mPointerEventData;
            if(val_3 == null)
            {
                    UnityEngine.EventSystems.PointerEventData val_2 = null;
                val_3 = val_2;
                val_2 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.EventSystems.EventSystem.current);
                this.mPointerEventData = val_3;
            }
            
            typeof(UnityEngine.EventSystems.PointerEventData).__il2cppRuntimeField_12C = eventData.<button>k__BackingField;
            this.mPointerEventData.<position>k__BackingField = eventData.<position>k__BackingField;
        }
        private SuperScrollView.LoopListViewItem2 GetNewItemByIndex(int index)
        {
            if((index & 2147483648) != 0)
            {
                    if(this.mSupportScrollBar == true)
            {
                    return 0;
            }
            
            }
            
            if((this.mItemTotalCount >= 1) && (this.mItemTotalCount <= index))
            {
                    return 0;
            }
            
            if((this.mOnGetItemByIndex.Invoke(arg1:  this, arg2:  index)) == 0)
            {
                    return 0;
            }
            
            val_1.mItemIndex = index;
            val_1.mItemCreatedCheckFrameCount = this.mListUpdateCheckFrameCount;
            return 0;
        }
        private void SetItemSize(int itemIndex, float itemSize, float padding)
        {
            itemSize = itemSize + padding;
            this.mItemPosMgr.SetItemSize(itemIndex:  itemIndex, size:  itemSize);
            if(this.mLastItemIndex > itemIndex)
            {
                    return;
            }
            
            this.mLastItemIndex = itemIndex;
            this.mLastItemPadding = padding;
        }
        private void GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
        {
            if(this.mItemPosMgr != null)
            {
                    this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  pos, index: ref  int val_1 = index, itemPos: ref  float val_2 = -6.398613E+37f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private float GetItemPos(int itemIndex)
        {
            if(this.mItemPosMgr != null)
            {
                    return this.mItemPosMgr.GetItemPos(itemIndex:  itemIndex);
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetItemCornerPosInViewPort(SuperScrollView.LoopListViewItem2 item, SuperScrollView.ItemCornerEnum corner = 0)
        {
            item.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3[] val_2 = this.mItemWorldCorners;
            val_2 = val_2 + ((long)corner * 12);
            return this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 32, y = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 32 + 4, z = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 40});
        }
        private void AdjustPanelPos()
        {
            if(this.mItemList == null)
            {
                    return;
            }
            
            this.UpdateAllShownItemsPos();
            float val_1 = this.ViewPortSize;
            float val_2 = this.GetContentPanelSize();
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_42 = 15769648 + (this.mArrangeType) << 2;
            val_42 = val_42 + 15769648;
            goto (15769648 + (this.mArrangeType) << 2 + 15769648);
        }
        private void Update()
        {
            if(this.mListViewInited == false)
            {
                    return;
            }
            
            if(this.mNeedAdjustVec == false)
            {
                goto label_6;
            }
            
            this.mNeedAdjustVec = false;
            if(this.mIsVertList == false)
            {
                goto label_3;
            }
            
            if((S1 * S0) <= 0f)
            {
                goto label_6;
            }
            
            mem2[0] = ???;
            this.mScrollRect.m_Velocity = this.mAdjustedVec;
            goto label_6;
            label_3:
            UnityEngine.Vector2 val_3 = this.mScrollRect.m_Velocity;
            val_3 = val_3 * this.mAdjustedVec;
            if(val_3 > 0f)
            {
                    this.mScrollRect.m_Velocity = this.mAdjustedVec;
                mem2[0] = this.mIsVertList;
            }
            
            label_6:
            if(this.mSupportScrollBar != false)
            {
                    this.mItemPosMgr.Update(updateAll:  false);
            }
            
            this.UpdateSnapMove(immediate:  false, forceSendEvent:  false);
            this.UpdateListView(distanceForRecycle0:  this.mDistanceForRecycle0, distanceForRecycle1:  this.mDistanceForRecycle1, distanceForNew0:  this.mDistanceForNew0, distanceForNew1:  this.mDistanceForNew1);
            this.ClearAllTmpRecycledItem();
            UnityEngine.Vector3 val_2 = this.mContainerTrans.anchoredPosition3D;
            this.mLastFrameContainerPos = val_2;
            mem[1152921513170114264] = val_2.y;
            mem[1152921513170114268] = val_2.z;
        }
        private void UpdateSnapMove(bool immediate = False, bool forceSendEvent = False)
        {
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(this.mIsVertList != false)
            {
                    this.UpdateSnapVertical(immediate:  immediate, forceSendEvent:  forceSendEvent);
                return;
            }
            
            this.UpdateSnapHorizontal(immediate:  immediate, forceSendEvent:  forceSendEvent);
        }
        public void UpdateAllShownItemSnapData()
        {
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(W21 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            if(this.mItemList == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.mItemList.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_50 = 15769680 + (this.mArrangeType) << 2;
            val_50 = val_50 + 15769680;
            goto (15769680 + (this.mArrangeType) << 2 + 15769680);
        }
        private void UpdateSnapVertical(bool immediate = False, bool forceSendEvent = False)
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_41;
            int val_42;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            float val_50;
            var val_51;
            var val_52;
            float val_53;
            SnapData val_54;
            float val_55;
            float val_59;
            val_41 = forceSendEvent;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            val_46 = val_1.y;
            this.mLastSnapCheckPos = val_1;
            mem[1152921513171385260] = val_1.y;
            mem[1152921513171385264] = val_1.z;
            if(val_1.y != val_1.x)
            {
                goto label_5;
            }
            
            int val_34 = this.mLeftSnapUpdateExtraCount;
            val_34 = val_34 - 1;
            if(val_1.y < val_1.x)
            {
                goto label_58;
            }
            
            this.mLeftSnapUpdateExtraCount = val_34;
            label_5:
            if(val_34 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            (this.mLeftSnapUpdateExtraCount - 1) + 32.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            if(this.mArrangeType == 1)
            {
                goto label_11;
            }
            
            if(this.mArrangeType != 0)
            {
                goto label_46;
            }
            
            UnityEngine.Rect val_3 = this.mViewPortRectTransform.rect;
            val_47 = val_3.m_XMin.height;
            UnityEngine.Vector3 val_5 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_48 = val_5.y;
            val_49 = mem[(this.mLeftSnapUpdateExtraCount - 1) + 32 + 64];
            val_49 = (this.mLeftSnapUpdateExtraCount - 1) + 32 + 64;
            float val_7 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            val_50 = 1f;
            val_49 = 3.402823E+38f;
            val_51 = 1152921504686825472;
            val_5.y = val_50 - val_5.y;
            val_7 = val_7 * val_5.y;
            val_52 = 0;
            float val_10 = val_48 - (((this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize) + val_49);
            val_47 = val_48 - val_7;
            goto label_18;
            label_28:
            if(1 >= X23)
            {
                goto label_36;
            }
            
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_12 = -1.ItemSize;
            float val_38 = mem[11922829213759];
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + val_38;
            val_38 = val_10 - val_12;
            float val_13 = -1.ItemSize;
            val_52 = 1;
            val_5.y = val_50 - val_5.y;
            val_13 = val_13 * val_5.y;
            val_47 = val_10 - val_13;
            val_49 = val_48;
            label_18:
            val_48 = (-((val_50 - S15) * val_47)) ?? val_47;
            if(val_48 < 0)
            {
                goto label_28;
            }
            
            goto label_29;
            label_11:
            UnityEngine.Rect val_14 = this.mViewPortRectTransform.rect;
            val_47 = val_14.m_XMin.height;
            UnityEngine.Vector3 val_16 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            val_48 = val_16.y;
            val_49 = mem[(this.mLeftSnapUpdateExtraCount - 1) + 32 + 64];
            val_49 = (this.mLeftSnapUpdateExtraCount - 1) + 32 + 64;
            float val_42 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            float val_18 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            val_49 = 3.402823E+38f;
            val_51 = 1152921504686825472;
            val_18 = val_18 * val_16.y;
            val_52 = 0;
            val_50 = S14 * val_47;
            val_42 = val_48 + (val_42 + val_49);
            val_47 = val_48 + val_18;
            goto label_35;
            label_45:
            if(1 >= X23)
            {
                goto label_36;
            }
            
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_20 = -1.ItemSize;
            float val_43 = mem[11922829213759];
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + val_43;
            val_43 = val_42 + val_20;
            float val_21 = -1.ItemSize;
            val_52 = 1;
            val_21 = val_21 * val_16.y;
            val_47 = val_42 + val_21;
            val_49 = val_48;
            label_35:
            val_48 = val_50 ?? val_47;
            if(val_48 < 0)
            {
                goto label_45;
            }
            
            label_29:
            val_52 = val_52 - 1;
            label_36:
            if((val_52 & 2147483648) != 0)
            {
                goto label_46;
            }
            
            val_42 = this.mCurSnapNearestItemIndex;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.mCurSnapNearestItemIndex = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_52 - 1)) << 3) + 32 + 24;
            if(val_41 != true)
            {
                    val_41 = this.mItemList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_41 = this.mOnSnapNearestChanged;
            if(val_41 == null)
            {
                goto label_58;
            }
            
            val_42 = this.mItemList;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_41.Invoke(arg1:  this, arg2:  (((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_52 - 1)) << 3) + 32 + 24 + ((long)(int)((val_52 - 1))) << 3) + 32 + 24 + ((long)(int)((val_52 - 1))) << 3) + 32);
            goto label_58;
            label_46:
            this.mCurSnapNearestItemIndex = 0;
            label_58:
            if(this.CanSnap() == false)
            {
                goto label_59;
            }
            
            this.UpdateCurSnapData();
            val_42 = this.mCurSnapData;
            if(this.mCurSnapData.mSnapStatus != 2)
            {
                    return;
            }
            
            if((S8 != 0f) && (S8 <= _TYPE_MAX_))
            {
                    val_42 = this.mCurSnapData;
            }
            
            val_48 = this.mSmoothDumpRate;
            val_41 = this.mSmoothDumpVel;
            val_53 = this.mCurSnapData.mTargetSnapVal;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.SmoothDamp(current:  this.mCurSnapData.mCurSnapVal, target:  val_53, currentVelocity: ref  val_41, smoothTime:  val_48);
            val_54 = this.mCurSnapData;
            if(immediate == true)
            {
                goto label_73;
            }
            
            val_48 = this.mCurSnapData.mTargetSnapVal;
            val_49 = this.mCurSnapData.mCurSnapVal;
            val_53 = val_48 ?? val_49;
            if(val_53 >= 0)
            {
                goto label_76;
            }
            
            val_54 = this.mCurSnapData;
            label_73:
            this.mCurSnapData.mSnapStatus = 3;
            val_55 = val_46 + this.mCurSnapData.mTargetSnapVal;
            val_46 = val_55 - this.mCurSnapData.mCurSnapVal;
            if(this.mOnSnapItemFinished == null)
            {
                goto label_83;
            }
            
            SuperScrollView.LoopListViewItem2 val_25 = this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapNearestItemIndex);
            if(val_25 == 0)
            {
                goto label_83;
            }
            
            this.mOnSnapItemFinished.Invoke(arg1:  this, arg2:  val_25);
            goto label_83;
            label_59:
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            return;
            label_76:
            val_55 = val_49 - this.mCurSnapData.mCurSnapVal;
            val_46 = val_46 + val_55;
            label_83:
            if(this.mArrangeType != 1)
            {
                    if(this.mArrangeType != 0)
            {
                    return;
            }
            
                val_49 = this.mViewPortRectLocalCorners[0];
                UnityEngine.Rect val_27 = this.mContainerTrans.rect;
                float val_29 = val_49 + val_27.m_XMin.height;
                val_59 = val_46;
            }
            else
            {
                    val_49 = this.mViewPortRectLocalCorners[1];
                UnityEngine.Rect val_30 = this.mContainerTrans.rect;
                val_59 = val_46;
            }
            
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_1.x, y = UnityEngine.Mathf.Clamp(value:  val_59, min:  val_49 - val_30.m_XMin.height, max:  0f), z = val_1.z};
        }
        private void UpdateCurSnapData()
        {
            SnapData val_5;
            SnapData val_6;
            SnapData val_7;
            val_5 = this.mCurSnapData;
            if(this.mItemList == null)
            {
                goto label_3;
            }
            
            if(this.mCurSnapData.mSnapStatus == 3)
            {
                    if(this.mCurSnapData.mSnapTargetIndex == this.mCurSnapNearestItemIndex)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapStatus = 0;
                val_6 = this.mCurSnapData;
            }
            
            if(this.mCurSnapData.mSnapStatus == 2)
            {
                    if(this.mCurSnapData.mSnapTargetIndex == this.mCurSnapNearestItemIndex)
            {
                    return;
            }
            
                if(this.mCurSnapData.mIsForceSnapTo == true)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapStatus = 0;
                val_6 = this.mCurSnapData;
            }
            
            if(this.mCurSnapData.mSnapStatus == 0)
            {
                    if((this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapNearestItemIndex)) == 0)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapTargetIndex = this.mCurSnapNearestItemIndex;
                this.mCurSnapData.mSnapStatus = 1;
                this.mCurSnapData.mIsForceSnapTo = false;
                val_6 = this.mCurSnapData;
            }
            
            if(this.mCurSnapData.mSnapStatus != 1)
            {
                    return;
            }
            
            if((this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapData.mSnapTargetIndex)) != 0)
            {
                goto label_22;
            }
            
            val_7 = this.mCurSnapData;
            label_3:
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            return;
            label_22:
            this.UpdateAllShownItemSnapData();
            this.mCurSnapData.mTargetSnapVal = val_3.mDistanceWithViewPortSnapCenter;
            this.mCurSnapData.mCurSnapVal = 0f;
            this.mCurSnapData.mSnapStatus = 2;
        }
        public void ClearSnapData()
        {
            if(this.mCurSnapData != null)
            {
                    this.mCurSnapData.mSnapStatus = 0;
                this.mCurSnapData.mIsForceSnapTo = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SetSnapTargetItemIndex(int itemIndex)
        {
            this.mCurSnapData.mSnapTargetIndex = itemIndex;
            this.mCurSnapData.mSnapStatus = 1;
            this.mCurSnapData.mIsForceSnapTo = 1;
        }
        public int get_CurSnapNearestItemIndex()
        {
            return (int)this.mCurSnapNearestItemIndex;
        }
        public void ForceSnapUpdateCheck()
        {
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        private void UpdateSnapHorizontal(bool immediate = False, bool forceSendEvent = False)
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_40;
            int val_41;
            float val_45;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            var val_50;
            var val_51;
            float val_52;
            SnapData val_53;
            float val_54;
            val_40 = forceSendEvent;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            val_45 = val_1.x;
            this.mLastSnapCheckPos = val_1;
            mem[1152921513172868268] = val_1.y;
            mem[1152921513172868272] = val_1.z;
            if(val_45 != this.mLastSnapCheckPos)
            {
                goto label_5;
            }
            
            int val_34 = this.mLeftSnapUpdateExtraCount;
            val_34 = val_34 - 1;
            if(val_45 < this.mLastSnapCheckPos)
            {
                goto label_58;
            }
            
            this.mLeftSnapUpdateExtraCount = val_34;
            label_5:
            if(val_34 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            (this.mLeftSnapUpdateExtraCount - 1) + 32.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            if(this.mArrangeType == 2)
            {
                goto label_11;
            }
            
            if(this.mArrangeType != 3)
            {
                goto label_46;
            }
            
            UnityEngine.Rect val_3 = this.mViewPortRectTransform.rect;
            val_46 = val_3.m_XMin.width;
            UnityEngine.Vector3 val_5 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            val_47 = val_5.x;
            val_48 = mem[(this.mLeftSnapUpdateExtraCount - 1) + 32 + 64];
            val_48 = (this.mLeftSnapUpdateExtraCount - 1) + 32 + 64;
            float val_7 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            UnityEngine.Vector2 val_38 = this.mItemSnapPivot;
            val_49 = 1f;
            val_48 = 3.402823E+38f;
            val_50 = 1152921504686825472;
            val_38 = val_49 - val_38;
            val_7 = val_7 * val_38;
            val_51 = 0;
            float val_10 = val_47 - (((this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize) + val_48);
            val_46 = val_47 - val_7;
            goto label_18;
            label_28:
            if(1 >= X23)
            {
                goto label_36;
            }
            
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_12 = -1.ItemSize;
            float val_39 = mem[11922829213759];
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + val_39;
            val_39 = val_10 - val_12;
            float val_13 = -1.ItemSize;
            UnityEngine.Vector2 val_40 = this.mItemSnapPivot;
            val_51 = 1;
            val_40 = val_49 - val_40;
            val_13 = val_13 * val_40;
            val_46 = val_10 - val_13;
            val_48 = val_47;
            label_18:
            val_47 = (-((val_49 - this.mViewPortSnapPivot) * val_46)) ?? val_46;
            if(val_47 < 0)
            {
                goto label_28;
            }
            
            goto label_29;
            label_11:
            val_49 = this.mViewPortSnapPivot;
            UnityEngine.Rect val_14 = this.mViewPortRectTransform.rect;
            val_46 = val_14.m_XMin.width;
            UnityEngine.Vector3 val_16 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_47 = val_16.x;
            val_48 = mem[(this.mLeftSnapUpdateExtraCount - 1) + 32 + 64];
            val_48 = (this.mLeftSnapUpdateExtraCount - 1) + 32 + 64;
            float val_44 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            float val_18 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            val_48 = 3.402823E+38f;
            val_50 = 1152921504686825472;
            val_18 = val_18 * this.mItemSnapPivot;
            val_51 = 0;
            val_49 = val_49 * val_46;
            val_44 = val_47 + (val_44 + val_48);
            val_46 = val_47 + val_18;
            goto label_35;
            label_45:
            if(1 >= X23)
            {
                goto label_36;
            }
            
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_20 = -1.ItemSize;
            float val_45 = mem[11922829213759];
            if(1 >= 15720448)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + val_45;
            val_45 = val_44 + val_20;
            float val_21 = -1.ItemSize;
            val_51 = 1;
            val_21 = val_21 * this.mItemSnapPivot;
            val_46 = val_44 + val_21;
            val_48 = val_47;
            label_35:
            val_47 = val_49 ?? val_46;
            if(val_47 < 0)
            {
                goto label_45;
            }
            
            label_29:
            val_51 = val_51 - 1;
            label_36:
            if((val_51 & 2147483648) != 0)
            {
                goto label_46;
            }
            
            val_41 = this.mCurSnapNearestItemIndex;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.mCurSnapNearestItemIndex = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_51 - 1)) << 3) + 32 + 24;
            if(val_40 != true)
            {
                    val_40 = this.mItemList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_40 = this.mOnSnapNearestChanged;
            if(val_40 == null)
            {
                goto label_58;
            }
            
            val_41 = this.mItemList;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_40.Invoke(arg1:  this, arg2:  (((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_51 - 1)) << 3) + 32 + 24 + ((long)(int)((val_51 - 1))) << 3) + 32 + 24 + ((long)(int)((val_51 - 1))) << 3) + 32);
            goto label_58;
            label_46:
            this.mCurSnapNearestItemIndex = 0;
            label_58:
            if(this.CanSnap() == false)
            {
                goto label_59;
            }
            
            val_48 = this.mScrollRect.m_Velocity;
            this.UpdateCurSnapData();
            val_41 = this.mCurSnapData;
            if(this.mCurSnapData.mSnapStatus != 2)
            {
                    return;
            }
            
            if((val_48 != 0f) && (val_48 <= _TYPE_MAX_))
            {
                    val_41 = this.mCurSnapData;
            }
            
            val_47 = this.mSmoothDumpRate;
            val_40 = this.mSmoothDumpVel;
            val_52 = this.mCurSnapData.mTargetSnapVal;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.SmoothDamp(current:  this.mCurSnapData.mCurSnapVal, target:  val_52, currentVelocity: ref  val_40, smoothTime:  val_47);
            val_53 = this.mCurSnapData;
            if(immediate == true)
            {
                goto label_73;
            }
            
            val_47 = this.mCurSnapData.mTargetSnapVal;
            val_48 = this.mCurSnapData.mCurSnapVal;
            val_52 = val_47 ?? val_48;
            if(val_52 >= 0)
            {
                goto label_76;
            }
            
            val_53 = this.mCurSnapData;
            label_73:
            this.mCurSnapData.mSnapStatus = 3;
            val_54 = val_45 + this.mCurSnapData.mTargetSnapVal;
            val_45 = val_54 - this.mCurSnapData.mCurSnapVal;
            if(this.mOnSnapItemFinished == null)
            {
                goto label_83;
            }
            
            SuperScrollView.LoopListViewItem2 val_25 = this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapNearestItemIndex);
            if(val_25 == 0)
            {
                goto label_83;
            }
            
            this.mOnSnapItemFinished.Invoke(arg1:  this, arg2:  val_25);
            goto label_83;
            label_59:
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            return;
            label_76:
            val_54 = val_48 - this.mCurSnapData.mCurSnapVal;
            val_45 = val_45 + val_54;
            label_83:
            if(this.mArrangeType != 3)
            {
                    if(this.mArrangeType != 2)
            {
                    return;
            }
            
                val_48 = this.mViewPortRectLocalCorners[2];
                UnityEngine.Rect val_27 = this.mContainerTrans.rect;
                float val_29 = val_48 - val_27.m_XMin.width;
            }
            else
            {
                    val_48 = this.mViewPortRectLocalCorners[1];
                UnityEngine.Rect val_30 = this.mContainerTrans.rect;
            }
            
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = UnityEngine.Mathf.Clamp(value:  val_45, min:  0f, max:  val_48 + val_30.m_XMin.width), y = val_1.y, z = val_1.z};
        }
        private bool CanSnap()
        {
            float val_16;
            UnityEngine.Vector2 val_17;
            if(this.mIsDraging != false)
            {
                    return false;
            }
            
            if(this.mScrollBarClickEventListener != 0)
            {
                    if(this.mScrollBarClickEventListener.mIsPressed == true)
            {
                    return false;
            }
            
            }
            
            UnityEngine.Rect val_2 = this.mContainerTrans.rect;
            if(this.mIsVertList != false)
            {
                    val_16 = val_2.m_XMin.height;
                float val_4 = this.ViewPortHeight;
            }
            else
            {
                    val_16 = val_2.m_XMin.width;
            }
            
            if(val_16 <= this.ViewPortWidth)
            {
                    return false;
            }
            
            if(this.mIsVertList != false)
            {
                
            }
            else
            {
                    val_17 = this.mScrollRect.m_Velocity;
            }
            
            float val_16 = System.Math.Abs(val_17);
            if(val_16 > this.mSnapVecThreshold)
            {
                    return false;
            }
            
            if(val_16 < 0)
            {
                    return false;
            }
            
            UnityEngine.Vector3 val_7 = this.mContainerTrans.anchoredPosition3D;
            if(this.mArrangeType > 3)
            {
                    return false;
            }
            
            var val_17 = 15769696 + (this.mArrangeType) << 2;
            val_17 = val_17 + 15769696;
            goto (15769696 + (this.mArrangeType) << 2 + 15769696);
        }
        public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            object val_4;
            object val_6;
            val_4 = this;
            int val_4 = this.mListUpdateCheckFrameCount;
            object val_5 = 1;
            val_4 = val_4 + 1;
            this.mListUpdateCheckFrameCount = val_4;
            if(this.mIsVertList == false)
            {
                goto label_6;
            }
            
            label_3:
            if(val_5 >= 9999)
            {
                goto label_2;
            }
            
            val_5 = val_5 + 1;
            if((this.UpdateForVertList(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1)) == true)
            {
                goto label_3;
            }
            
            return;
            label_6:
            if(val_5 >= 9999)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            if((this.UpdateForHorizontalList(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1)) == true)
            {
                goto label_6;
            }
            
            return;
            label_2:
            val_6 = "UpdateListView Vertical while loop ";
            goto label_8;
            label_5:
            val_6 = "UpdateListView  Horizontal while loop ";
            label_8:
            val_4 = val_6 + val_5 + " times! something is wrong!"(" times! something is wrong!");
            UnityEngine.Debug.LogError(message:  val_4);
        }
        private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_84;
            float val_85;
            UnityEngine.Vector3 val_87;
            UnityEngine.Vector3 val_88;
            SuperScrollView.LoopListViewItem2 val_89;
            UnityEngine.Vector3[] val_90;
            int val_91;
            int val_92;
            int val_93;
            UnityEngine.Object val_94;
            bool val_95;
            int val_96;
            UnityEngine.Object val_97;
            var val_98;
            UnityEngine.Vector3 val_102;
            UnityEngine.Vector3[] val_103;
            int val_104;
            int val_105;
            bool val_106;
            int val_107;
            float val_108;
            float val_109;
            float val_110;
            float val_114;
            float val_118;
            float val_119;
            val_84 = distanceForNew0;
            val_85 = distanceForRecycle0;
            if(this.mItemTotalCount == 0)
            {
                goto label_1;
            }
            
            if(this.mArrangeType == 0)
            {
                goto label_3;
            }
            
            if(this.mItemTotalCount == 0)
            {
                goto label_4;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_3 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            if(this.mIsDraging == true)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_86 = this.mViewPortRectLocalCorners[0];
            val_86 = val_86 - val_2.y;
            if(val_86 > val_85)
            {
                goto label_17;
            }
            
            label_14:
            if(this.mViewPortRectLocalCorners == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_87 = this.mViewPortRectLocalCorners[(this.mViewPortRectLocalCorners - 1) << 3];
            val_87.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_6 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_85 = val_6.y;
            val_88 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_7 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_88, z = this.mItemWorldCorners[0]});
            if((this.mIsDraging == true) || ((mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 72]) == this.mListUpdateCheckFrameCount))
            {
                goto label_32;
            }
            
            UnityEngine.Vector3 val_92 = this.mViewPortRectLocalCorners[1];
            val_92 = val_7.y - val_92;
            if(val_92 <= distanceForRecycle1)
            {
                goto label_32;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            val_89 = val_87;
            goto label_34;
            label_1:
            if(this.mItemList < 1)
            {
                goto label_121;
            }
            
            this.RecycleAllItem();
            goto label_121;
            label_3:
            if(this.mItemTotalCount == 0)
            {
                goto label_38;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_10 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_11 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            bool val_102 = this.mIsDraging;
            if(val_102 == true)
            {
                goto label_51;
            }
            
            UnityEngine.Vector3 val_99 = this.mViewPortRectLocalCorners[1];
            val_99 = val_11.y - val_99;
            if(val_99 <= val_85)
            {
                goto label_51;
            }
            
            label_17:
            this.mItemList.RemoveAt(index:  0);
            val_89 = 21069824;
            label_34:
            this.RecycleItemTmp(item:  static_value_01418000);
            if(this.mSupportScrollBar == true)
            {
                goto label_173;
            }
            
            label_95:
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            goto label_173;
            label_32:
            val_90 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_100 = val_90[1];
            val_100 = val_85 - val_100;
            if(val_100 >= 0)
            {
                goto label_60;
            }
            
            val_91 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            val_92 = this.mCurReadyMaxItemIndex;
            if(val_91 > val_92)
            {
                    this.mCurReadyMaxItemIndex = val_91;
                this.mNeedCheckNextMaxItem = true;
                val_92 = val_91;
                val_91 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            }
            
            val_93 = val_91 + 1;
            if(val_93 > val_92)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_60;
            }
            
            }
            
            val_94 = this.GetNewItemByIndex(index:  val_93);
            if(val_94 != 0)
            {
                goto label_63;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.CheckIfNeedUpdataItemPos();
            val_90 = this.mViewPortRectLocalCorners;
            label_60:
            UnityEngine.Vector3 val_101 = val_90[0];
            val_101 = val_101 - val_3.y;
            if(val_101 >= 0)
            {
                goto label_121;
            }
            
            val_95 = static_value_01418018;
            val_96 = this.mCurReadyMinItemIndex;
            if(val_95 < val_96)
            {
                    this.mCurReadyMinItemIndex = val_95;
                this.mNeedCheckNextMinItem = true;
                val_96 = val_95;
                val_95 = static_value_01418018;
            }
            
            val_87 = val_95 - 1;
            if(val_87 < val_96)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_121;
            }
            
            }
            
            val_97 = this.GetNewItemByIndex(index:  val_87);
            if(val_97 != 0)
            {
                goto label_72;
            }
            
            val_98 = 0;
            this.mNeedCheckNextMinItem = false;
            return (bool)val_98;
            label_4:
            UnityEngine.Vector3 val_16 = this.mContainerTrans.anchoredPosition3D;
            int val_17 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_75;
            }
            
            this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -0f, index: ref  val_17, itemPos: ref  float val_18 = -1.18016E+38f);
            val_87 = val_17;
            goto label_77;
            label_51:
            if(val_102 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_102 = val_102 + ((val_102 - 1) << 3);
            val_87 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32];
            val_87 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32;
            val_87.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_21 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_85 = val_21.y;
            val_102 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_22 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_102, z = this.mItemWorldCorners[0]});
            if((this.mIsDraging == true) || (((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 72) == this.mListUpdateCheckFrameCount))
            {
                goto label_92;
            }
            
            UnityEngine.Vector3 val_108 = this.mViewPortRectLocalCorners[0];
            val_108 = val_108 - val_85;
            if(val_108 <= distanceForRecycle1)
            {
                goto label_92;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            this.RecycleItemTmp(item:  val_87);
            if(this.mSupportScrollBar == true)
            {
                goto label_173;
            }
            
            goto label_95;
            label_92:
            val_103 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_109 = val_103[0];
            val_109 = val_109 - val_22.y;
            if(val_109 >= 0)
            {
                goto label_101;
            }
            
            val_104 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24];
            val_104 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            val_105 = this.mCurReadyMaxItemIndex;
            if(val_104 > val_105)
            {
                    this.mCurReadyMaxItemIndex = val_104;
                this.mNeedCheckNextMaxItem = true;
                val_105 = val_104;
                val_104 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            }
            
            val_93 = val_104 + 1;
            if(val_93 > val_105)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_101;
            }
            
            }
            
            val_94 = this.GetNewItemByIndex(index:  val_93);
            if(val_94 != 0)
            {
                goto label_104;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            this.CheckIfNeedUpdataItemPos();
            val_103 = this.mViewPortRectLocalCorners;
            label_101:
            UnityEngine.Vector3 val_110 = val_103[1];
            val_110 = val_10.y - val_110;
            if(val_110 >= 0)
            {
                goto label_121;
            }
            
            val_106 = static_value_01418018;
            val_107 = this.mCurReadyMinItemIndex;
            if(val_106 < val_107)
            {
                    this.mCurReadyMinItemIndex = val_106;
                this.mNeedCheckNextMinItem = true;
                val_107 = val_106;
                val_106 = static_value_01418018;
            }
            
            val_87 = val_106 - 1;
            if(val_87 < val_107)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_121;
            }
            
            }
            
            val_97 = this.GetNewItemByIndex(index:  val_87);
            if(val_97 != 0)
            {
                goto label_113;
            }
            
            val_98 = 0;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = static_value_01418018;
            return (bool)val_98;
            label_38:
            UnityEngine.Vector3 val_28 = this.mContainerTrans.anchoredPosition3D;
            val_84 = -0f;
            int val_29 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_116;
            }
            
            this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  0f, index: ref  val_29, itemPos: ref  float val_30 = -1.180168E+38f);
            val_108 = val_84;
            val_87 = val_29;
            val_84 = -val_108;
            goto label_118;
            label_75:
            val_87 = 0;
            label_77:
            SuperScrollView.LoopListViewItem2 val_31 = this.GetNewItemByIndex(index:  0);
            if(val_31 == 0)
            {
                goto label_121;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_34 = val_31.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_34.m_XMin.height, padding:  val_31.mPadding);
            }
            
            this.mItemList.Add(item:  val_31);
            val_109 = -0f;
            val_87 = val_31.CachedRectTransform;
            goto label_127;
            label_63:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_38 = val_94.CachedRectTransform.rect;
                val_110 = val_12.mPadding;
                this.SetItemSize(itemIndex:  val_93, itemSize:  val_38.m_XMin.height, padding:  val_110);
            }
            
            this.mItemList.Add(item:  val_94);
            UnityEngine.Vector3 val_41 = val_87.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_43 = val_87.CachedRectTransform.rect;
            float val_44 = val_43.m_XMin.height;
            val_44 = val_41.y + val_44;
            val_84 = val_44 + (mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 64]);
            goto label_135;
            label_116:
            val_87 = 0;
            label_118:
            SuperScrollView.LoopListViewItem2 val_45 = this.GetNewItemByIndex(index:  0);
            if(val_45 != 0)
            {
                goto label_138;
            }
            
            label_121:
            val_98 = 0;
            return (bool)val_98;
            label_138:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_48 = val_45.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_48.m_XMin.height, padding:  val_45.mPadding);
            }
            
            this.mItemList.Add(item:  val_45);
            val_87 = val_45.CachedRectTransform;
            val_109 = val_84;
            label_127:
            UnityEngine.Vector3 val_51 = new UnityEngine.Vector3(x:  val_45.mStartPosOffset, y:  val_109, z:  0f);
            val_87.anchoredPosition3D = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
            this.UpdateContentSize();
            goto label_173;
            label_72:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_53 = val_97.CachedRectTransform.rect;
                val_114 = val_14.mPadding;
                this.SetItemSize(itemIndex:  val_87, itemSize:  val_53.m_XMin.height, padding:  val_114);
            }
            
            this.mItemList.Insert(index:  0, item:  val_97);
            UnityEngine.Vector3 val_56 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_58 = val_97.CachedRectTransform.rect;
            float val_59 = val_58.m_XMin.height;
            val_59 = val_56.y - val_59;
            val_84 = val_59 - val_14.mPadding;
            goto label_154;
            label_104:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_61 = val_94.CachedRectTransform.rect;
                val_118 = val_24.mPadding;
                this.SetItemSize(itemIndex:  val_93, itemSize:  val_61.m_XMin.height, padding:  val_118);
            }
            
            this.mItemList.Add(item:  val_94);
            UnityEngine.Vector3 val_64 = val_87.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_66 = val_87.CachedRectTransform.rect;
            float val_67 = val_66.m_XMin.height;
            val_67 = val_64.y - val_67;
            val_84 = val_67 - ((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 64);
            label_135:
            UnityEngine.Vector3 val_69 = new UnityEngine.Vector3(x:  val_24.mStartPosOffset, y:  val_84, z:  0f);
            val_94.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_93 <= this.mCurReadyMaxItemIndex)
            {
                goto label_173;
            }
            
            this.mCurReadyMaxItemIndex = val_93;
            goto label_173;
            label_113:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_71 = val_97.CachedRectTransform.rect;
                val_119 = val_26.mPadding;
                this.SetItemSize(itemIndex:  val_87, itemSize:  val_71.m_XMin.height, padding:  val_119);
            }
            
            this.mItemList.Insert(index:  0, item:  val_97);
            UnityEngine.Vector3 val_74 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_76 = val_97.CachedRectTransform.rect;
            float val_77 = val_76.m_XMin.height;
            val_77 = val_74.y + val_77;
            val_84 = val_77 + val_26.mPadding;
            label_154:
            UnityEngine.Vector3 val_79 = new UnityEngine.Vector3(x:  val_26.mStartPosOffset, y:  val_84, z:  0f);
            val_97.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_87 < this.mCurReadyMinItemIndex)
            {
                    this.mCurReadyMinItemIndex = val_87;
            }
            
            label_173:
            val_98 = 1;
            return (bool)val_98;
        }
        private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_84;
            float val_85;
            UnityEngine.Vector3 val_87;
            UnityEngine.Vector3 val_88;
            SuperScrollView.LoopListViewItem2 val_89;
            UnityEngine.Vector3 val_90;
            UnityEngine.Vector3[] val_91;
            UnityEngine.Vector3 val_92;
            int val_93;
            int val_94;
            int val_95;
            UnityEngine.Object val_96;
            bool val_97;
            int val_98;
            UnityEngine.Object val_99;
            float val_100;
            UnityEngine.Vector3[] val_104;
            int val_105;
            int val_106;
            bool val_107;
            int val_108;
            var val_109;
            float val_113;
            float val_114;
            float val_115;
            float val_119;
            float val_120;
            val_84 = distanceForNew0;
            val_85 = distanceForRecycle0;
            if(this.mItemTotalCount == 0)
            {
                goto label_1;
            }
            
            if(this.mArrangeType != 2)
            {
                goto label_3;
            }
            
            if(this.mItemTotalCount == 0)
            {
                goto label_4;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_87 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_3 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_87, z = this.mItemWorldCorners[2]});
            if(this.mIsDraging == true)
            {
                goto label_14;
            }
            
            val_87 = this.mViewPortRectLocalCorners[1];
            val_3.x = val_87 - val_3.x;
            if(val_3.x > val_85)
            {
                goto label_17;
            }
            
            label_14:
            if(this.mViewPortRectLocalCorners == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_88 = this.mViewPortRectLocalCorners[(this.mViewPortRectLocalCorners - 1) << 3];
            val_88.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_6 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_85 = val_6.x;
            UnityEngine.Vector3 val_7 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            if((this.mIsDraging == true) || ((mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 72]) == this.mListUpdateCheckFrameCount))
            {
                goto label_32;
            }
            
            UnityEngine.Vector3 val_91 = this.mViewPortRectLocalCorners[2];
            val_91 = val_85 - val_91;
            if(val_91 <= distanceForRecycle1)
            {
                goto label_32;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            this.RecycleItemTmp(item:  val_88);
            if(this.mSupportScrollBar == true)
            {
                goto label_172;
            }
            
            goto label_35;
            label_1:
            if(this.mItemList < 1)
            {
                goto label_128;
            }
            
            this.RecycleAllItem();
            goto label_128;
            label_3:
            if(this.mItemTotalCount == 0)
            {
                goto label_39;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_10 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_11 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            bool val_99 = this.mIsDraging;
            if(val_99 == true)
            {
                goto label_52;
            }
            
            UnityEngine.Vector3 val_98 = this.mViewPortRectLocalCorners[2];
            val_98 = val_10.x - val_98;
            if(val_98 <= val_85)
            {
                goto label_52;
            }
            
            label_17:
            this.mItemList.RemoveAt(index:  0);
            val_89 = 21069824;
            goto label_54;
            label_52:
            if(val_99 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_99 = val_99 + ((val_99 - 1) << 3);
            val_88 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32];
            val_88 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32;
            val_88.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_85 = val_14.x;
            val_90 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_15 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_90, z = this.mItemWorldCorners[2]});
            if((this.mIsDraging == true) || (((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 72) == this.mListUpdateCheckFrameCount))
            {
                goto label_69;
            }
            
            val_90 = this.mViewPortRectLocalCorners[1];
            val_15.x = val_90 - val_15.x;
            if(val_15.x <= distanceForRecycle1)
            {
                goto label_69;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            val_89 = val_88;
            label_54:
            this.RecycleItemTmp(item:  val_89);
            if(this.mSupportScrollBar == true)
            {
                goto label_172;
            }
            
            label_35:
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            goto label_172;
            label_32:
            val_91 = this.mViewPortRectLocalCorners;
            val_92 = val_91[2];
            val_7.x = val_7.x - val_92;
            if(val_7.x >= 0)
            {
                goto label_78;
            }
            
            val_93 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            val_94 = this.mCurReadyMaxItemIndex;
            if(val_93 > val_94)
            {
                    this.mCurReadyMaxItemIndex = val_93;
                this.mNeedCheckNextMaxItem = true;
                val_94 = val_93;
                val_93 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            }
            
            val_95 = val_93 + 1;
            if(val_95 > val_94)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_78;
            }
            
            }
            
            val_96 = this.GetNewItemByIndex(index:  val_95);
            if(val_96 != 0)
            {
                goto label_81;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            this.CheckIfNeedUpdataItemPos();
            val_91 = this.mViewPortRectLocalCorners;
            label_78:
            UnityEngine.Vector3 val_105 = val_91[1];
            val_105 = val_105 - val_2.x;
            if(val_105 >= 0)
            {
                goto label_128;
            }
            
            val_97 = static_value_01418018;
            val_98 = this.mCurReadyMinItemIndex;
            if(val_97 < val_98)
            {
                    this.mCurReadyMinItemIndex = val_97;
                this.mNeedCheckNextMinItem = true;
                val_98 = val_97;
                val_97 = static_value_01418018;
            }
            
            val_88 = val_97 - 1;
            if(val_88 < val_98)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_128;
            }
            
            }
            
            val_99 = this.GetNewItemByIndex(index:  val_88);
            if(val_99 == 0)
            {
                goto label_90;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_22 = val_99.CachedRectTransform.rect;
                val_100 = val_19.mPadding;
                this.SetItemSize(itemIndex:  val_88, itemSize:  val_22.m_XMin.width, padding:  val_100);
            }
            
            this.mItemList.Insert(index:  0, item:  val_99);
            UnityEngine.Vector3 val_25 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_27 = val_99.CachedRectTransform.rect;
            float val_28 = val_27.m_XMin.width;
            val_28 = val_25.x - val_28;
            val_84 = val_28 - val_19.mPadding;
            goto label_98;
            label_69:
            val_104 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_106 = val_104[1];
            val_106 = val_106 - val_85;
            if(val_106 >= 0)
            {
                goto label_104;
            }
            
            val_105 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24];
            val_105 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            val_106 = this.mCurReadyMaxItemIndex;
            if(val_105 > val_106)
            {
                    this.mCurReadyMaxItemIndex = val_105;
                this.mNeedCheckNextMaxItem = true;
                val_106 = val_105;
                val_105 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            }
            
            val_95 = val_105 + 1;
            if(val_95 > val_106)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_104;
            }
            
            }
            
            val_96 = this.GetNewItemByIndex(index:  val_95);
            if(val_96 != 0)
            {
                goto label_107;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            this.CheckIfNeedUpdataItemPos();
            val_104 = this.mViewPortRectLocalCorners;
            label_104:
            UnityEngine.Vector3 val_107 = val_104[2];
            val_107 = val_11.x - val_107;
            if(val_107 >= 0)
            {
                goto label_128;
            }
            
            val_107 = static_value_01418018;
            val_108 = this.mCurReadyMinItemIndex;
            if(val_107 < val_108)
            {
                    this.mCurReadyMinItemIndex = val_107;
                this.mNeedCheckNextMinItem = true;
                val_108 = val_107;
                val_107 = static_value_01418018;
            }
            
            val_88 = val_107 - 1;
            if(val_88 < val_108)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_128;
            }
            
            }
            
            val_99 = this.GetNewItemByIndex(index:  val_88);
            if(val_99 != 0)
            {
                goto label_116;
            }
            
            label_90:
            val_109 = 0;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = static_value_01418018;
            return (bool)val_109;
            label_4:
            UnityEngine.Vector3 val_33 = this.mContainerTrans.anchoredPosition3D;
            int val_34 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_119;
            }
            
            this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -val_33.x, index: ref  val_34, itemPos: ref  float val_35 = -1.385095E+38f);
            val_88 = val_34;
            goto label_121;
            label_39:
            UnityEngine.Vector3 val_36 = this.mContainerTrans.anchoredPosition3D;
            val_84 = -val_36.x;
            int val_37 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_123;
            }
            
            this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  val_36.x, index: ref  val_37, itemPos: ref  float val_38 = -1.385087E+38f);
            val_113 = val_84;
            val_88 = val_37;
            val_84 = -val_113;
            goto label_125;
            label_119:
            val_88 = 0;
            label_121:
            SuperScrollView.LoopListViewItem2 val_39 = this.GetNewItemByIndex(index:  0);
            if(val_39 == 0)
            {
                goto label_128;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_42 = val_39.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_42.m_XMin.width, padding:  val_39.mPadding);
            }
            
            this.mItemList.Add(item:  val_39);
            val_114 = val_39.mStartPosOffset;
            val_88 = val_39.CachedRectTransform;
            goto label_134;
            label_123:
            val_88 = 0;
            label_125:
            SuperScrollView.LoopListViewItem2 val_45 = this.GetNewItemByIndex(index:  0);
            if(val_45 != 0)
            {
                goto label_137;
            }
            
            label_128:
            val_109 = 0;
            return (bool)val_109;
            label_137:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_48 = val_45.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_48.m_XMin.width, padding:  val_45.mPadding);
            }
            
            this.mItemList.Add(item:  val_45);
            val_114 = val_45.mStartPosOffset;
            val_88 = val_45.CachedRectTransform;
            label_134:
            UnityEngine.Vector3 val_51 = new UnityEngine.Vector3(x:  val_84, y:  val_114, z:  0f);
            val_88.anchoredPosition3D = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
            this.UpdateContentSize();
            goto label_172;
            label_81:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_53 = val_96.CachedRectTransform.rect;
                val_115 = val_17.mPadding;
                this.SetItemSize(itemIndex:  val_95, itemSize:  val_53.m_XMin.width, padding:  val_115);
            }
            
            this.mItemList.Add(item:  val_96);
            UnityEngine.Vector3 val_56 = val_88.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_58 = val_88.CachedRectTransform.rect;
            float val_59 = val_58.m_XMin.width;
            val_59 = val_56.x + val_59;
            val_84 = val_59 + (mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 64]);
            goto label_153;
            label_107:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_61 = val_96.CachedRectTransform.rect;
                val_119 = val_29.mPadding;
                this.SetItemSize(itemIndex:  val_95, itemSize:  val_61.m_XMin.width, padding:  val_119);
            }
            
            this.mItemList.Add(item:  val_96);
            UnityEngine.Vector3 val_64 = val_88.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_66 = val_88.CachedRectTransform.rect;
            float val_67 = val_66.m_XMin.width;
            val_67 = val_64.x - val_67;
            val_84 = val_67 - ((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 64);
            label_153:
            UnityEngine.Vector3 val_69 = new UnityEngine.Vector3(x:  val_84, y:  val_29.mStartPosOffset, z:  0f);
            val_96.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_95 <= this.mCurReadyMaxItemIndex)
            {
                goto label_172;
            }
            
            this.mCurReadyMaxItemIndex = val_95;
            goto label_172;
            label_116:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_71 = val_99.CachedRectTransform.rect;
                val_120 = val_31.mPadding;
                this.SetItemSize(itemIndex:  val_88, itemSize:  val_71.m_XMin.width, padding:  val_120);
            }
            
            this.mItemList.Insert(index:  0, item:  val_99);
            UnityEngine.Vector3 val_74 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_76 = val_99.CachedRectTransform.rect;
            float val_77 = val_76.m_XMin.width;
            val_77 = val_74.x + val_77;
            val_84 = val_77 + val_31.mPadding;
            label_98:
            UnityEngine.Vector3 val_79 = new UnityEngine.Vector3(x:  val_84, y:  val_31.mStartPosOffset, z:  0f);
            val_99.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_88 < this.mCurReadyMinItemIndex)
            {
                    this.mCurReadyMinItemIndex = val_88;
            }
            
            label_172:
            val_109 = 1;
            return (bool)val_109;
        }
        private float GetContentPanelSize()
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_5;
            var val_6;
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_7;
            float val_9;
            val_5 = this;
            bool val_5 = this.mSupportScrollBar;
            if(val_5 != false)
            {
                    val_6 = 0f;
                if(this.mItemPosMgr.mTotalSize <= 0f)
            {
                    return (float)val_4;
            }
            
                val_6 = this.mItemPosMgr.mTotalSize - this.mLastItemPadding;
                return (float)val_4;
            }
            
            val_7 = this.mItemList;
            if(val_5 == false)
            {
                    return (float)val_4;
            }
            
            bool val_1 = val_5 - 1;
            if()
            {
                    return this.mSupportScrollBar + 32.ItemSize;
            }
            
            if(val_5 == true)
            {
                    val_5 = this.mItemList;
                if(val_5 <= true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = (this.mSupportScrollBar + 32.ItemSize) + (this.mSupportScrollBar + 32 + 64);
            }
            else
            {
                    if(val_1 >= true)
            {
                    var val_6 = 0;
                do
            {
                if(val_5 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 0;
                float val_3 = (this.mSupportScrollBar + 0) + 32.ItemSize;
                val_7 = this.mItemList;
                val_6 = val_6 + 1;
                val_3 = val_3 + ((this.mSupportScrollBar + 0) + 32 + 64);
                val_9 = 0f + val_3;
            }
            while(val_6 < val_1);
            
            }
            else
            {
                    val_9 = 0f;
            }
            
                if(val_5 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + (val_1 << 3);
            }
            
            float val_4 = (this.mSupportScrollBar + ((this.mSupportScrollBar - 1)) << 3) + 32.ItemSize;
            val_4 = val_9 + val_4;
            return (float)val_4;
        }
        private void CheckIfNeedUpdataItemPos()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_21 = 15769712 + (this.mArrangeType) << 2;
            val_21 = val_21 + 15769712;
            goto (15769712 + (this.mArrangeType) << 2 + 15769712);
        }
        private void UpdateAllShownItemsPos()
        {
            var val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            if(W22 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.mLastFrameContainerPos, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  UnityEngine.Time.deltaTime);
            val_44 = 1152921504686878720;
            val_45 = val_4.x;
            val_46 = val_4.z;
            val_47 = val_45;
            val_48 = val_4.y;
            val_49 = val_46;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_47, y = val_48, z = val_49});
            this.mAdjustedVec = val_5;
            mem[1152921513178405016] = val_5.y;
            if(this.mArrangeType <= 3)
            {
                    var val_44 = 15769632 + (this.mArrangeType) << 2;
                val_44 = val_44 + 15769632;
            }
            else
            {
                    if(this.mIsDraging == false)
            {
                    return;
            }
            
                this.mScrollRect.m_Velocity = this.mAdjustedVec.x;
                this.mNeedAdjustVec = true;
            }
        
        }
        private void UpdateContentSize()
        {
            Axis val_6;
            float val_1 = this.GetContentPanelSize();
            UnityEngine.Rect val_2 = this.mContainerTrans.rect;
            if(this.mIsVertList != false)
            {
                    if(val_2.m_XMin.height == val_1)
            {
                    return;
            }
            
                val_6 = 1;
            }
            else
            {
                    if(val_2.m_XMin.width == val_1)
            {
                    return;
            }
            
                val_6 = 0;
            }
            
            this.mContainerTrans.SetSizeWithCurrentAnchors(axis:  val_6, size:  val_1);
        }
        public LoopListView2()
        {
            this.mItemPoolDict = new System.Collections.Generic.Dictionary<System.String, SuperScrollView.ItemPool>();
            this.mItemPoolList = new System.Collections.Generic.List<SuperScrollView.ItemPool>();
            this.mItemPrefabDataList = new System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData>();
            this.mItemList = new System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>();
            this.mItemDefaultWithPaddingSize = 20f;
            this.mItemWorldCorners = new UnityEngine.Vector3[4];
            this.mDistanceForRecycle0 = ;
            this.mDistanceForNew0 = ;
            this.mDistanceForRecycle1 = 300f;
            this.mDistanceForNew1 = 200f;
            this.mViewPortRectLocalCorners = new UnityEngine.Vector3[4];
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            this.mSupportScrollBar = true;
            this.mSnapVecThreshold = 145f;
            this.mSmoothDumpRate = 0.3f;
            this.mSnapFinishThreshold = 0.1f;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.mLastFrameContainerPos = val_7;
            mem[1152921513178832824] = val_7.y;
            mem[1152921513178832828] = val_7.z;
            this.mLeftSnapUpdateExtraCount = true;
            this.mCurSnapNearestItemIndex = 0;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
            this.mViewPortSnapPivot = val_8;
            mem[1152921513178832872] = val_8.y;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            this.mItemSnapPivot = val_9;
            mem[1152921513178832880] = val_9.y;
            this.mCurSnapData = new System.Object();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.mLastSnapCheckPos = val_11;
            mem[1152921513178832908] = val_11.y;
            mem[1152921513178832912] = val_11.z;
        }
    
    }

}
