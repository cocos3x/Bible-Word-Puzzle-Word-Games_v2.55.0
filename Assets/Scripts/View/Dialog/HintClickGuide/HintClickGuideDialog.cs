using UnityEngine;

namespace View.Dialog.HintClickGuide
{
    public class HintClickGuideDialog : Dialog
    {
        // Fields
        public UnityEngine.Transform btnTrans;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text GotItText;
        
        // Methods
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "19");
            this.GotItText.text = Locale.LocaleManager.Translate(key:  "24");
        }
        private void Start()
        {
            Message.Messager.Dispatch<System.Boolean>(cmd:  60, t:  true);
            View.Dialog.Common.Dialog val_2 = this.OnClose(action:  new System.Action(object:  this, method:  System.Void View.Dialog.HintClickGuide.HintClickGuideDialog::SetHintOrderNormal()));
        }
        private void SetHintOrderNormal()
        {
            Message.Messager.Dispatch<System.Boolean>(cmd:  60, t:  false);
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.HintFreeStatus) > 0)
            {
                    return;
            }
            
            if(View.Game.GameController.GetInstance() == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.btnTrans.position;
            Message.Messager.Dispatch<UnityEngine.Vector3, UnityEngine.Events.UnityAction>(cmd:  73, t:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, u:  0);
        }
        public HintClickGuideDialog()
        {
        
        }
    
    }

}
