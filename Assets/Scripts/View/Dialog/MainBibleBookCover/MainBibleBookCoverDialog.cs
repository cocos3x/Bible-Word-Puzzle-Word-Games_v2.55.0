using UnityEngine;

namespace View.Dialog.MainBibleBookCover
{
    public class MainBibleBookCoverDialog : Dialog
    {
        // Fields
        private UnityEngine.UI.Button closeBtn;
        private UnityEngine.UI.Image imageBook;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.closeBtn.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(View.Dialog.MainBibleBookCover.MainBibleBookCoverDialog).__il2cppRuntimeField_1E8));
        }
        public override void OnTransmitParams(object[] pars)
        {
            this.OnTransmitParams(pars:  pars);
            object val_2 = pars[0];
            this.SetTexture(bibleSection:  Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  16027648));
        }
        private void SetTexture(Data.Bean.BibleSection bibleSection)
        {
            if(bibleSection == null)
            {
                    return;
            }
            
            Utils.Unity.ImageExtension.SetSpriteForPath(self:  this.imageBook, path:  Common.Singleton<Logic.BibleController>.Instance.GetBibleSpriteName(name:  bibleSection.res));
            Utils.Unity.ImageExtension.CreateSpriteForUrl(self:  this.imageBook, url:  System.String.Format(format:  "http://kjv-cdn.idailybread.com/kjv/plan/{0}.png", arg0:  bibleSection.res));
        }
        public MainBibleBookCoverDialog()
        {
        
        }
    
    }

}
