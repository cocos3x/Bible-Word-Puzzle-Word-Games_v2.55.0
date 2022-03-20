using UnityEngine;

namespace Store
{
    public class TreasureData : IStoreData
    {
        // Fields
        public int FinishMissionsChestCount;
        public int MissionsChestProgress;
        public System.Collections.Generic.Dictionary<string, int> MissionProgress;
        public bool ShouldShowTreasureGuide;
        public string OpenTimeTag;
        
        // Methods
        public void Reset()
        {
            this.FinishMissionsChestCount = 0;
            this.MissionsChestProgress = 0;
            this.MissionProgress.Clear();
            this.ShouldShowTreasureGuide = true;
            this.OpenTimeTag = System.String.alignConst;
        }
        public TreasureData()
        {
            this.MissionProgress = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
    
    }

}
