using UnityEngine;

namespace Logic.BibleBook
{
    public class BibleController : Singleton<Logic.BibleBook.BibleController>
    {
        // Methods
        public Data.Bible.BibleChestType IsHaveChestForBible(int bibleIndex, int currentSectionIndex)
        {
            Data.Bean.BibleSection val_5 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  Logic.Game.GameManager.gameBible.GetCurrentBibleSectionIndex(sectionIndex:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) - 1) = Logic.Game.GameManager.gameBible.GetCurrentBibleSectionIndex(sectionIndex:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) - 1));
            Data.Bean.BibleSection val_8 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  currentSectionIndex);
            if(((val_8.collectCount == 0) ? ((Logic.Game.GameManager.gameBible.GetCurrentBibleSectionIndex(sectionIndex:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) - 1)) + 1) : (Logic.Game.GameManager.gameBible.GetCurrentBibleSectionIndex(sectionIndex:  (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) - 1))) != currentSectionIndex)
            {
                    return 0;
            }
            
            if(val_8.collectCount > bibleIndex)
            {
                    return 0;
            }
            
            if(val_8.maxCount == bibleIndex)
            {
                    return 0;
            }
            
            var val_13 = (bibleIndex == 0) ? 1 : 0;
            return 0;
        }
        public BibleController()
        {
        
        }
    
    }

}
