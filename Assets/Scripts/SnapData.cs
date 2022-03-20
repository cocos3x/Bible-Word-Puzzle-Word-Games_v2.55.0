using UnityEngine;
private class LoopListView2.SnapData
{
    // Fields
    public SuperScrollView.SnapStatus mSnapStatus;
    public int mSnapTargetIndex;
    public float mTargetSnapVal;
    public float mCurSnapVal;
    public bool mIsForceSnapTo;
    
    // Methods
    public void Clear()
    {
        this.mSnapStatus = 0;
        this.mIsForceSnapTo = false;
    }
    public LoopListView2.SnapData()
    {
    
    }

}
