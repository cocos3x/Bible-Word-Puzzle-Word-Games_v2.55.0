using UnityEngine;

namespace View.Dialog.Loading
{
    public class LoadingDialog : Dialog
    {
        // Methods
        private void HideLoading()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.Loading.LoadingDialog::TimeOutCallback()));
            goto typeof(View.Dialog.Loading.LoadingDialog).__il2cppRuntimeField_1E0;
        }
        private void TimeOutCallback()
        {
            object[] val_1 = new object[1];
            val_1[0] = Locale.LocaleManager.Translate(key:  "52");
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_1);
            this.HideLoading();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Message.Messager.Add(cmd:  38, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Loading.LoadingDialog::HideLoading()));
            Common.TimerEvent.Add(time:  9f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.Loading.LoadingDialog::TimeOutCallback()), isrepeat:  false);
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  38, action:  new System.Action(object:  this, method:  System.Void View.Dialog.Loading.LoadingDialog::HideLoading()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.Loading.LoadingDialog::TimeOutCallback()));
        }
        public LoadingDialog()
        {
        
        }
    
    }

}
