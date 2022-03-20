using UnityEngine;

namespace View.Dialog.Firework
{
    public class FireworksHintClickGuideDialog : Dialog
    {
        // Fields
        private UnityEngine.UI.Button closeBtn;
        private UnityEngine.RectTransform fireworksHint;
        private View.CommonItem.FireworksButton _fireworksButton;
        private View.Dialog.Firework.FireworksContent fireworksContent;
        private UnityEngine.UI.Text contentText;
        private TMPro.TMP_Text okText;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.closeBtn.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Firework.FireworksHintClickGuideDialog::OnCloseButtonClick()));
            this.Invoke(methodName:  "ShowContent", time:  2.2f);
        }
        public override void Cancel()
        {
            this.Cancel();
            Common.Singleton<Common.EnterShow.EnterShow>.Instance.CheckAndShowLimitTimePack();
        }
        public override void OnTransmitParams(object[] pars)
        {
            var val_5;
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetHasShowFireworkGuide(isHave:  true);
            object val_5 = pars[0];
            val_5 = 0;
            this._fireworksButton = ;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this._fireworksButton.transform.position;
            this.fireworksHint.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "28");
            this.okText.text = Locale.LocaleManager.Translate(key:  "36");
        }
        private void ShowContent()
        {
            if(this.fireworksContent != null)
            {
                    this.fireworksContent.Open();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnCloseButtonClick()
        {
            typeof(FireworksHintClickGuideDialog.<>c__DisplayClass11_0).__il2cppRuntimeField_10 = this;
            UnityEngine.Vector3 val_3 = this.closeBtn.transform.position;
            typeof(FireworksHintClickGuideDialog.<>c__DisplayClass11_0).__il2cppRuntimeField_18 = val_3.x;
            typeof(FireworksHintClickGuideDialog.<>c__DisplayClass11_0).__il2cppRuntimeField_1C = val_3.y;
            typeof(FireworksHintClickGuideDialog.<>c__DisplayClass11_0).__il2cppRuntimeField_20 = val_3.z;
            this.fireworksContent.Close(action:  new System.Action(object:  new System.Object(), method:  System.Void FireworksHintClickGuideDialog.<>c__DisplayClass11_0::<OnCloseButtonClick>b__0()));
        }
        public FireworksHintClickGuideDialog()
        {
            mem[1152921512760785736] = 257;
            mem[1152921512760785739] = 1;
            mem[1152921512760785744] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
