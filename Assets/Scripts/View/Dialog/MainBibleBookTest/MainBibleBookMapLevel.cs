using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleBookMapLevel : MonoBehaviour
    {
        // Fields
        private const float TimeDelayAni = 1.3;
        public TMPro.TextMeshProUGUI TextLevelNo;
        public View.Dialog.MainBibleBookTest.MainBibleBookMapCompleted MapCompleted;
        public View.Dialog.MainBibleBookTest.MainBibleBookMapChest MapChest;
        private Data.Bible.BibleChestType _chestType;
        private Data.Bean.BibleSection _bibleSection;
        private int _bibleSectionIndex;
        private int _bibleIndex;
        private bool _isHaveChest;
        
        // Methods
        public void SetMapLevelInfo(Data.Bean.BibleSection bibleSection, int bibleSectionIndex, int bibleIndex, Data.Bible.BibleChestType type)
        {
            var val_10;
            this.gameObject.SetActive(value:  true);
            this._bibleSection = bibleSection;
            this._isHaveChest = false;
            this._bibleSectionIndex = bibleSectionIndex;
            this._bibleIndex = bibleIndex;
            this._chestType = type;
            this.TextLevelNo.text = bibleIndex + 1.ToString();
            var val_10 = this._bibleSection.collectCount;
            Data.Bible.BibleDataManager val_5 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            val_10 = val_10 - (val_5.<IsExistCollectAni>k__BackingField);
            if(val_10 <= bibleIndex)
            {
                    val_10 = 0;
            }
            
            this.MapCompleted.SetLevelCompleteInfo(bibleSectionIndex:  bibleSectionIndex, bibleIndex:  bibleIndex, state:  (val_10 == this._bibleSection.maxCount) ? (1 + 1) : 1);
            this.MapChest.SetChestInfo(type:  (val_10 <= bibleIndex) ? type : 0);
        }
        public void PlayCompleteAni(bool isAll)
        {
            if(this._chestType != 0)
            {
                    this._isHaveChest = true;
                this.MapChest.OpenChest();
                return;
            }
            
            isAll = isAll;
            this.MapCompleted.ShowLevelComplete(isAll:  isAll);
            Message.Messager.Dispatch(cmd:  12);
        }
        public void SetMalLevelAllState()
        {
            int val_1 = this._bibleSection.maxCount;
            this.MapCompleted.SetMalLevelAllState(maxCount:  0);
            this.MapCompleted.PlayEffect();
        }
        public void ResetMapLevel()
        {
            this.MapCompleted.SetLevelCompleteInfo(bibleSectionIndex:  0, bibleIndex:  0, state:  0);
            this.MapChest.SetChestInfo(type:  0);
            this.gameObject.SetActive(value:  false);
        }
        private void OpenChestCallback()
        {
            if(this._isHaveChest == false)
            {
                    return;
            }
            
            this._isHaveChest = false;
            this.MapCompleted.ShowLevelComplete(isAll:  false);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapLevel::DelayCompletedAniEnd()));
            Common.TimerEvent.Add(time:  1.3f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapLevel::DelayCompletedAniEnd()), isrepeat:  false);
        }
        private void DelayCompletedAniEnd()
        {
            Message.Messager.Dispatch(cmd:  12);
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  13, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapLevel::OpenChestCallback()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  13, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapLevel::OpenChestCallback()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapLevel::DelayCompletedAniEnd()));
        }
        public MainBibleBookMapLevel()
        {
        
        }
    
    }

}
