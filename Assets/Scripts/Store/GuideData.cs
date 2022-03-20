using UnityEngine;

namespace Store
{
    public class GuideData : IStoreData
    {
        // Fields
        public bool ShouldShowHomeDailyPoint;
        public bool ShouldShowBonusWordGuideDialog;
        public bool ShouldShowHomeDailyDialog;
        public bool IsDailyNewGuide;
        public bool IsReconfirmWatchVideo;
        public bool IsLetterGiftReconfirm;
        public bool HasShowFireworkGuide;
        public bool HasShowExtraCoinGuide;
        public bool IsHaveMapReelGuide;
        
        // Methods
        public void Reset()
        {
            this.IsHaveMapReelGuide = true;
            this.ShouldShowHomeDailyPoint = false;
            this.ShouldShowBonusWordGuideDialog = true;
            this.ShouldShowHomeDailyDialog = true;
            this.IsDailyNewGuide = true;
            this.IsReconfirmWatchVideo = true;
            this.IsLetterGiftReconfirm = true;
            this.HasShowFireworkGuide = false;
            this.HasShowExtraCoinGuide = false;
        }
        public GuideData()
        {
            this.IsHaveMapReelGuide = true;
        }
    
    }

}
