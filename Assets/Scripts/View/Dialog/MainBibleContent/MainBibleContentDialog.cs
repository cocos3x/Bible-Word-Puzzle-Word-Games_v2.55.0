using UnityEngine;

namespace View.Dialog.MainBibleContent
{
    public class MainBibleContentDialog : Dialog
    {
        // Fields
        private TMPro.TextMeshProUGUI referenceText;
        private TMPro.TextMeshProUGUI contentText;
        private Spine.Unity.SkeletonGraphic skeletonGraphicReel;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.Color defaultColor;
        private int sectionIndex;
        private int bibleIndex;
        
        // Methods
        public override void OnTransmitParams(object[] pars)
        {
            this.OnTransmitParams(pars:  pars);
            object val_1 = pars[0];
            this.sectionIndex = null;
            object val_2 = pars[1];
            this.bibleIndex = null;
            this.ShowBibleContent();
        }
        protected override void Awake()
        {
            this.Awake();
            this.closeButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(View.Dialog.MainBibleContent.MainBibleContentDialog).__il2cppRuntimeField_1E8));
            UnityEngine.Color32 val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.defaultColor});
            this.referenceText.faceColor = new UnityEngine.Color32() {r = val_2.r & 4294967295, g = val_2.r & 4294967295, b = val_2.r & 4294967295, a = val_2.r & 4294967295};
            UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.defaultColor});
            this.contentText.faceColor = new UnityEngine.Color32() {r = val_4.r & 4294967295, g = val_4.r & 4294967295, b = val_4.r & 4294967295, a = val_4.r & 4294967295};
            this.skeletonGraphicReel.timeScale = 0f;
            Spine.TrackEntry val_7 = this.skeletonGraphicReel.AnimationState.SetAnimation(trackIndex:  0, animationName:  "open_reel", loop:  false);
            Spine.TrackEntry val_9 = this.skeletonGraphicReel.AnimationState.GetCurrent(trackIndex:  0);
            val_9.animationStart = val_9.animationEnd;
            this.skeletonGraphicReel.timeScale = 1f;
        }
        private void ShowBibleContent()
        {
            System.Collections.Generic.List<Data.Bean.BibleBean> val_2;
            int val_3;
            Data.Bean.BibleSection val_1 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  this.sectionIndex);
            val_2 = val_1.bibles;
            val_3 = this.bibleIndex;
            val_3 = 1152921504818937855;
            this.bibleIndex = val_3;
            val_2 = val_1.bibles;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.referenceText.text = mem[1152921506515664920] + 32 + 8;
            this.contentText.text = mem[1152921506515664920] + 32;
        }
        public MainBibleContentDialog()
        {
        
        }
    
    }

}
