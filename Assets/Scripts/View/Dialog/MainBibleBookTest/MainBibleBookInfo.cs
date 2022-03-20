using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleBookInfo : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshProUGUI TextBibleName;
        public TMPro.TextMeshProUGUI TextBibleDesc;
        public UnityEngine.UI.Image ImageLock;
        public UnityEngine.UI.Image ImageFull;
        public UnityEngine.GameObject EffectPicHide;
        private int _bibleSectionIndex;
        private Data.Bean.BibleSection _bibleSection;
        private bool _unLock;
        
        // Methods
        public void OnClickBibleCoverButton()
        {
            if(this._unLock != false)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "verse_collect", action:  "pic_click", label:  "collected", value:  0);
                object[] val_1 = new object[1];
                val_1[0] = this._bibleSectionIndex;
                View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MainBibleBookCoverDialog", pars:  val_1);
                return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "verse_collect", action:  "pic_click", label:  "uncollected", value:  0);
            object[] val_3 = new object[1];
            val_3[0] = Locale.LocaleManager.Translate(key:  "72");
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_3);
        }
        public void UpdateBibleBookInfo(int bibleSectionIndex)
        {
            this.EffectPicHide.SetActive(value:  false);
            this._bibleSectionIndex = bibleSectionIndex;
            this._bibleSection = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  bibleSectionIndex);
            this.TextBibleName.text = val_1.name;
            this.TextBibleDesc.text = this._bibleSection.desc;
            Utils.Unity.ImageExtension.SetSpriteForPath(self:  this.ImageLock, path:  Common.Singleton<Logic.BibleController>.Instance.GetBibleSpriteName(name:  this._bibleSection.res));
            Utils.Unity.ImageExtension.SetSpriteForPath(self:  this.ImageFull, path:  Common.Singleton<Logic.BibleController>.Instance.GetBibleSpriteName(name:  this._bibleSection.res));
            this.RefreshProgress();
        }
        public void PlayUnLockAni()
        {
            this._unLock = true;
            Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_scroll_light", volumeScale:  1f, loop:  false, delay:  0f);
            this.EffectPicHide.SetActive(value:  true);
            this.SetBibleBookGray(isGray:  false);
        }
        private void RefreshProgress()
        {
            var val_6;
            if(this._bibleSection == null)
            {
                    return;
            }
            
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_1.<IsExistCollectAni>k__BackingField) != false)
            {
                    val_6 = 0;
            }
            else
            {
                    bool val_4 = (this._bibleSection.collectCount == this._bibleSection.maxCount) ? 1 : 0;
            }
            
            this._unLock = val_4;
            this.SetBibleBookGray(isGray:  (val_4 == 0) ? 1 : 0);
        }
        private void SetBibleBookGray(bool isGray)
        {
            this.ImageLock.gameObject.SetActive(value:  isGray);
            this.ImageFull.gameObject.SetActive(value:  (~isGray) & 1);
        }
        public MainBibleBookInfo()
        {
        
        }
    
    }

}
