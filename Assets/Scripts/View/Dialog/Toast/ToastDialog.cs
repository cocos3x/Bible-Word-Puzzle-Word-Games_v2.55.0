using UnityEngine;

namespace View.Dialog.Toast
{
    public class ToastDialog : Dialog
    {
        // Fields
        private const float IntervalTime = 2;
        public TMPro.TextMeshProUGUI TextToast;
        
        // Methods
        public override void OnTransmitParams(object[] pars)
        {
            object val_14;
            var val_15;
            string val_16;
            val_14 = this;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            this.OnTransmitParams(pars:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            string val_1 = Common.GlobalMethods.GetBaseVale<System.String>(inputs:  pars, idx:  0, defaultVal:  0);
            val_16 = val_1;
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
            {
                    val_16 = ???;
                val_14 = ???;
            }
            else
            {
                    val_14 + 88.text = val_16;
                int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  val_14, complete:  false);
                DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  2f);
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  val_14, method:  System.Void View.Dialog.Toast.ToastDialog::<OnTransmitParams>b__2_0()));
            }
        
        }
        public ToastDialog()
        {
        
        }
        private void <OnTransmitParams>b__2_0()
        {
            goto typeof(View.Dialog.Toast.ToastDialog).__il2cppRuntimeField_1E0;
        }
    
    }

}
