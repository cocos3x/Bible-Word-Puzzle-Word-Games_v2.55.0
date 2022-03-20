using UnityEngine;

namespace View.Dialog.MainBibleBookCollect
{
    public class MainBibleBookCollectDialog : Dialog
    {
        // Fields
        private UnityEngine.UI.Image imageBook;
        private TMPro.TextMeshProUGUI contentText;
        private View.UIButton closeButton;
        private UnityEngine.UI.Image imageTitle;
        private TMPro.TMP_Text amenText;
        private string defaultName;
        private int sectionIndex;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(View.Dialog.MainBibleBookCollect.MainBibleBookCollectDialog).__il2cppRuntimeField_1E8));
        }
        protected override void LocaleTranslate()
        {
            var val_4;
            string val_5;
            this.LocaleTranslate();
            val_4 = "Atlas/DialogMulti3";
            Locale.LocaleE val_1 = Locale.LocaleManager.GetCurLanguage();
            if(val_1 == 3)
            {
                goto label_1;
            }
            
            if(val_1 == 2)
            {
                goto label_2;
            }
            
            if(val_1 != 1)
            {
                goto label_3;
            }
            
            val_5 = "Atlas/LocalePortuguese";
            goto label_5;
            label_2:
            val_5 = "Atlas/LocaleSpanish";
            goto label_5;
            label_1:
            val_5 = "Atlas/LocaleFrench";
            label_5:
            label_3:
            this.imageTitle.sprite = Resource.ResManager.GetSpriteFromPool(atlas:  val_5, spriteName:  "result_title_bookclear");
            this.amenText.text = Locale.LocaleManager.Translate(key:  "74");
        }
        public override void OnTransmitParams(object[] pars)
        {
            this.OnTransmitParams(pars:  pars);
            int val_1 = Common.GlobalMethods.GetBaseVale<System.Int32>(inputs:  pars, idx:  0, defaultVal:  0);
            this.sectionIndex = val_1;
            Data.Bean.BibleSection val_2 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  val_1);
            this.SetTexture(bibleSection:  val_2);
            this.SetText(bibleSection:  val_2);
        }
        public override void Close()
        {
            this.Close();
            Message.Messager.Dispatch(cmd:  20);
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
        private void SetText(Data.Bean.BibleSection bibleSection)
        {
            string val_3;
            if(bibleSection != null)
            {
                    val_3 = bibleSection.name;
            }
            else
            {
                    val_3 = this.defaultName;
            }
            
            this.contentText.text = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "75"), arg0:  val_3);
        }
        public MainBibleBookCollectDialog()
        {
            this.defaultName = "Genesis";
        }
    
    }

}
