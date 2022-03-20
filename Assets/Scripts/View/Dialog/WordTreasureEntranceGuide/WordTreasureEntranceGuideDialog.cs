using UnityEngine;

namespace View.Dialog.WordTreasureEntranceGuide
{
    public class WordTreasureEntranceGuideDialog : Dialog
    {
        // Fields
        public UnityEngine.Transform TreasureIcon;
        public UnityEngine.UI.Text ContentText;
        private UnityEngine.Vector3 _iconPos;
        
        // Methods
        public void OnClickIconButton()
        {
            this.TreasureIcon.gameObject.SetActive(value:  false);
            goto typeof(View.Dialog.WordTreasureEntranceGuide.WordTreasureEntranceGuideDialog).__il2cppRuntimeField_1E0;
        }
        public override void OnTransmitParams(object[] pars)
        {
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetShouldShowTreasureGuide(isShould:  false);
            UnityEngine.Vector3 val_2 = Common.GlobalMethods.GetBaseVale<UnityEngine.Vector3>(inputs:  pars, idx:  0, defaultVal:  0);
            this._iconPos = val_2;
            mem[1152921512654921820] = val_2.y;
            mem[1152921512654921824] = val_2.z;
            this.TreasureIcon.gameObject.SetActive(value:  false);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.WordTreasureEntranceGuide.WordTreasureEntranceGuideDialog::OnDelay()));
            Common.TimerEvent.Add(time:  V8.16B, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.WordTreasureEntranceGuide.WordTreasureEntranceGuideDialog::OnDelay()), isrepeat:  false);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "117");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void OnDelay()
        {
            this.TreasureIcon.gameObject.SetActive(value:  true);
            this.TreasureIcon.transform.position = new UnityEngine.Vector3() {x = this._iconPos};
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.WordTreasureEntranceGuide.WordTreasureEntranceGuideDialog::OnDelay()));
        }
        public WordTreasureEntranceGuideDialog()
        {
        
        }
    
    }

}
