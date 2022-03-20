using UnityEngine;

namespace View.Dialog.ButterflyResultGuideEntrance
{
    public class ButterflyResultGuideEntranceDialog : Dialog
    {
        // Fields
        public View.Dialog.Result.ResultChrysalisProgress ChrysalisProgress;
        public UnityEngine.UI.Text BgText;
        private UnityEngine.Vector3 _chrysalisProgressPos;
        
        // Methods
        public void OnClickProgressButton()
        {
            this.ChrysalisProgress.gameObject.SetActive(value:  false);
            this.Close();
            View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyDialog", type:  0);
        }
        public override void OnTransmitParams(object[] pars)
        {
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.SetShouldShowButterFlyGuide(isShould:  false);
            UnityEngine.Vector3 val_2 = Common.GlobalMethods.GetBaseVale<UnityEngine.Vector3>(inputs:  pars, idx:  0, defaultVal:  0);
            this._chrysalisProgressPos = val_2;
            mem[1152921512801454012] = val_2.y;
            mem[1152921512801454016] = val_2.z;
            this.ChrysalisProgress.SetChrysalisActive(isActive:  false);
            this.ChrysalisProgress.SetProgress(isGuide:  true);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterflyResultGuideEntrance.ButterflyResultGuideEntranceDialog::OnDelay()));
            Common.TimerEvent.Add(time:  V8.16B, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterflyResultGuideEntrance.ButterflyResultGuideEntranceDialog::OnDelay()), isrepeat:  false);
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "127");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void OnDelay()
        {
            this.ChrysalisProgress.gameObject.SetActive(value:  true);
            this.ChrysalisProgress.SetChrysalisProgressPos(pos:  new UnityEngine.Vector3() {x = this._chrysalisProgressPos});
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterflyResultGuideEntrance.ButterflyResultGuideEntranceDialog::OnDelay()));
        }
        public ButterflyResultGuideEntranceDialog()
        {
            mem[1152921512801992136] = 257;
            mem[1152921512801992139] = 1;
            mem[1152921512801992144] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
