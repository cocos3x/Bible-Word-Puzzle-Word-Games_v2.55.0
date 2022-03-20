using UnityEngine;

namespace View.Dialog.BonusWordGuide
{
    public class BonusWordGuideDialog : Dialog
    {
        // Fields
        public UnityEngine.Transform MaskContent;
        public View.CommonItem.GuideMask GuideMaskPrefab;
        public UnityEngine.UI.Text ContentText;
        public TMPro.TMP_Text GotItText;
        
        // Methods
        private void Start()
        {
            Message.Messager.Dispatch<System.Boolean>(cmd:  22, t:  true);
            View.Dialog.Common.Dialog val_2 = this.OnCancel(action:  new System.Action(object:  this, method:  System.Void View.Dialog.BonusWordGuide.BonusWordGuideDialog::RecoverBeforeGuide()));
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "25");
            this.GotItText.text = Locale.LocaleManager.Translate(key:  "24");
        }
        private void RecoverBeforeGuide()
        {
            Message.Messager.Dispatch<System.Boolean>(cmd:  22, t:  false);
        }
        private void CreateBonusGuideMasks(View.CommonItem.Word word)
        {
            var val_15;
            var val_16;
            if(word == 0)
            {
                    return;
            }
            
            Message.Messager.Dispatch<System.Boolean>(cmd:  32, t:  false);
            View.CommonItem.GuideMask val_2 = UnityEngine.Object.Instantiate<View.CommonItem.GuideMask>(original:  this.GuideMaskPrefab);
            val_2.transform.SetParent(parent:  this.MaskContent, worldPositionStays:  false);
            UnityEngine.Transform val_4 = word.transform;
            if(val_4 != null)
            {
                    var val_5 = (null == null) ? (val_4) : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.Transform val_6 = val_2.transform;
            if(val_6 != null)
            {
                    var val_7 = (null == null) ? (val_6) : 0;
            }
            else
            {
                    val_16 = 0;
            }
            
            UnityEngine.Vector3 val_10 = word.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector2 val_11 = val_15.sizeDelta;
            val_16.sizeDelta = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            UnityEngine.Vector3 val_14 = word.transform.localScale;
            val_2.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            val_2.SetGuideMaskBgState(isShow:  true);
        }
        public override void Cancel()
        {
            this.Cancel();
            Common.Singleton<Common.EnterShow.EnterShow>.Instance.CheckAndShowLimitTimePack();
        }
        protected override void OnEnable()
        {
            Message.Messager.Add<View.CommonItem.Word>(cmd:  33, action:  new System.Action<View.CommonItem.Word>(object:  this, method:  System.Void View.Dialog.BonusWordGuide.BonusWordGuideDialog::CreateBonusGuideMasks(View.CommonItem.Word word)));
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetShouldShowBonusWordGuideDialog(isShould:  false);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<View.CommonItem.Word>(cmd:  33, action:  new System.Action<View.CommonItem.Word>(object:  this, method:  System.Void View.Dialog.BonusWordGuide.BonusWordGuideDialog::CreateBonusGuideMasks(View.CommonItem.Word word)));
        }
        public BonusWordGuideDialog()
        {
        
        }
    
    }

}
