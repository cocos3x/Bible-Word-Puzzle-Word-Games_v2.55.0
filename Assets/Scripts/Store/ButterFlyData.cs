using UnityEngine;

namespace Store
{
    public class ButterFlyData : IStoreData
    {
        // Fields
        public int LevelChrysalisCount;
        public int ChrysalisCount;
        public System.Collections.Generic.List<int> ButterFlyList;
        public bool ShouldShowButterFlyGuide;
        public int OldCollectButterFly;
        
        // Methods
        public void Reset()
        {
            this.LevelChrysalisCount = 0;
            this.ChrysalisCount = 0;
            this.ButterFlyList.Clear();
            this.ShouldShowButterFlyGuide = true;
            this.OldCollectButterFly = 0;
        }
        public ButterFlyData()
        {
            this.ButterFlyList = new System.Collections.Generic.List<System.Int32>();
        }
    
    }

}
