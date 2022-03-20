using UnityEngine;

namespace SuperScrollView
{
    public class LoopListViewItem2 : MonoBehaviour
    {
        // Fields
        private int mItemIndex;
        private int mItemId;
        private SuperScrollView.LoopListView2 mParentListView;
        private bool mIsInitHandlerCalled;
        private string mItemPrefabName;
        private UnityEngine.RectTransform mCachedRectTransform;
        private float mPadding;
        private float mDistanceWithViewPortSnapCenter;
        private int mItemCreatedCheckFrameCount;
        private float mStartPosOffset;
        private object mUserObjectData;
        private int mUserIntData1;
        private int mUserIntData2;
        private string mUserStringData1;
        private string mUserStringData2;
        
        // Properties
        public object UserObjectData { get; set; }
        public int UserIntData1 { get; set; }
        public int UserIntData2 { get; set; }
        public string UserStringData1 { get; set; }
        public string UserStringData2 { get; set; }
        public float DistanceWithViewPortSnapCenter { get; set; }
        public float StartPosOffset { get; set; }
        public int ItemCreatedCheckFrameCount { get; set; }
        public float Padding { get; set; }
        public UnityEngine.RectTransform CachedRectTransform { get; }
        public string ItemPrefabName { get; set; }
        public int ItemIndex { get; set; }
        public int ItemId { get; set; }
        public bool IsInitHandlerCalled { get; set; }
        public SuperScrollView.LoopListView2 ParentListView { get; set; }
        public float TopY { get; }
        public float BottomY { get; }
        public float LeftX { get; }
        public float RightX { get; }
        public float ItemSize { get; }
        public float ItemSizeWithPadding { get; }
        
        // Methods
        public object get_UserObjectData()
        {
            return (object)this.mUserObjectData;
        }
        public void set_UserObjectData(object value)
        {
            this.mUserObjectData = value;
        }
        public int get_UserIntData1()
        {
            return (int)this.mUserIntData1;
        }
        public void set_UserIntData1(int value)
        {
            this.mUserIntData1 = value;
        }
        public int get_UserIntData2()
        {
            return (int)this.mUserIntData2;
        }
        public void set_UserIntData2(int value)
        {
            this.mUserIntData2 = value;
        }
        public string get_UserStringData1()
        {
            return (string)this.mUserStringData1;
        }
        public void set_UserStringData1(string value)
        {
            this.mUserStringData1 = value;
        }
        public string get_UserStringData2()
        {
            return (string)this.mUserStringData2;
        }
        public void set_UserStringData2(string value)
        {
            this.mUserStringData2 = value;
        }
        public float get_DistanceWithViewPortSnapCenter()
        {
            return (float)this.mDistanceWithViewPortSnapCenter;
        }
        public void set_DistanceWithViewPortSnapCenter(float value)
        {
            this.mDistanceWithViewPortSnapCenter = value;
        }
        public float get_StartPosOffset()
        {
            return (float)this.mStartPosOffset;
        }
        public void set_StartPosOffset(float value)
        {
            this.mStartPosOffset = value;
        }
        public int get_ItemCreatedCheckFrameCount()
        {
            return (int)this.mItemCreatedCheckFrameCount;
        }
        public void set_ItemCreatedCheckFrameCount(int value)
        {
            this.mItemCreatedCheckFrameCount = value;
        }
        public float get_Padding()
        {
            return (float)this.mPadding;
        }
        public void set_Padding(float value)
        {
            this.mPadding = value;
        }
        public UnityEngine.RectTransform get_CachedRectTransform()
        {
            UnityEngine.RectTransform val_4;
            if(this.mCachedRectTransform == 0)
            {
                    this.mCachedRectTransform = this.gameObject.GetComponent<UnityEngine.RectTransform>();
                return val_4;
            }
            
            val_4 = this.mCachedRectTransform;
            return val_4;
        }
        public string get_ItemPrefabName()
        {
            return (string)this.mItemPrefabName;
        }
        public void set_ItemPrefabName(string value)
        {
            this.mItemPrefabName = value;
        }
        public int get_ItemIndex()
        {
            return (int)this.mItemIndex;
        }
        public void set_ItemIndex(int value)
        {
            this.mItemIndex = value;
        }
        public int get_ItemId()
        {
            return (int)this.mItemId;
        }
        public void set_ItemId(int value)
        {
            this.mItemId = value;
        }
        public bool get_IsInitHandlerCalled()
        {
            return (bool)this.mIsInitHandlerCalled;
        }
        public void set_IsInitHandlerCalled(bool value)
        {
            this.mIsInitHandlerCalled = value;
        }
        public SuperScrollView.LoopListView2 get_ParentListView()
        {
            return (SuperScrollView.LoopListView2)this.mParentListView;
        }
        public void set_ParentListView(SuperScrollView.LoopListView2 value)
        {
            this.mParentListView = value;
        }
        public float get_TopY()
        {
            if(this.mParentListView.mArrangeType != 1)
            {
                    if(this.mParentListView.mArrangeType != 0)
            {
                    return (float)val_7;
            }
            
                UnityEngine.Vector3 val_2 = this.CachedRectTransform.anchoredPosition3D;
                return (float)val_7;
            }
            
            UnityEngine.Vector3 val_4 = this.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_6 = this.CachedRectTransform.rect;
            float val_7 = val_6.m_XMin.height;
            val_7 = val_4.y + val_7;
            return (float)val_7;
        }
        public float get_BottomY()
        {
            if(this.mParentListView.mArrangeType != 1)
            {
                    if(this.mParentListView.mArrangeType != 0)
            {
                    return (float)val_7.y;
            }
            
                UnityEngine.Vector3 val_2 = this.CachedRectTransform.anchoredPosition3D;
                UnityEngine.Rect val_4 = this.CachedRectTransform.rect;
                float val_5 = val_4.m_XMin.height;
                val_5 = val_2.y - val_5;
                return (float)val_7.y;
            }
            
            UnityEngine.Vector3 val_7 = this.CachedRectTransform.anchoredPosition3D;
            return (float)val_7.y;
        }
        public float get_LeftX()
        {
            if(this.mParentListView.mArrangeType != 3)
            {
                    if(this.mParentListView.mArrangeType != 2)
            {
                    return (float)val_7;
            }
            
                UnityEngine.Vector3 val_2 = this.CachedRectTransform.anchoredPosition3D;
                return (float)val_7;
            }
            
            UnityEngine.Vector3 val_4 = this.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_6 = this.CachedRectTransform.rect;
            float val_7 = val_6.m_XMin.width;
            val_7 = val_4.x - val_7;
            return (float)val_7;
        }
        public float get_RightX()
        {
            if(this.mParentListView.mArrangeType != 3)
            {
                    if(this.mParentListView.mArrangeType != 2)
            {
                    return (float)val_7.x;
            }
            
                UnityEngine.Vector3 val_2 = this.CachedRectTransform.anchoredPosition3D;
                UnityEngine.Rect val_4 = this.CachedRectTransform.rect;
                float val_5 = val_4.m_XMin.width;
                val_5 = val_2.x + val_5;
                return (float)val_7.x;
            }
            
            UnityEngine.Vector3 val_7 = this.CachedRectTransform.anchoredPosition3D;
            return (float)val_7.x;
        }
        public float get_ItemSize()
        {
            UnityEngine.Rect val_2 = this.CachedRectTransform.rect;
            if(this.mParentListView.mIsVertList == false)
            {
                    return (float)val_2.m_XMin.width;
            }
            
            float val_3 = val_2.m_XMin.height;
            return (float)val_2.m_XMin.width;
        }
        public float get_ItemSizeWithPadding()
        {
            float val_1 = this.ItemSize;
            val_1 = val_1 + this.mPadding;
            return (float)val_1;
        }
        public LoopListViewItem2()
        {
            this.mItemIndex = -1;
            this.mItemId = -1;
        }
    
    }

}
