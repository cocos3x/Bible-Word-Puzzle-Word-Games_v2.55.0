using UnityEngine;

namespace View.Dialog.MapReelGuide
{
    public class MapReelGuideDialog : Dialog
    {
        // Fields
        public UnityEngine.Transform MapLevelGuide;
        public UnityEngine.UI.Text ContentText;
        private UnityEngine.Vector3 _mapLevelPos;
        private int _bibleSectionIndex;
        private int _bibleIndex;
        
        // Methods
        public void OnClickButton()
        {
            object[] val_1 = new object[2];
            val_1[0] = this._bibleSectionIndex;
            val_1[1] = this._bibleIndex;
            View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MainBibleContentDialog", pars:  val_1);
        }
        public override void OnTransmitParams(object[] pars)
        {
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.SetHaveMapReelGuide(isValue:  false);
            UnityEngine.Vector3 val_2 = Common.GlobalMethods.GetBaseVale<UnityEngine.Vector3>(inputs:  pars, idx:  0, defaultVal:  0);
            this._mapLevelPos = val_2;
            mem[1152921512726977244] = val_2.y;
            mem[1152921512726977248] = val_2.z;
            this._bibleSectionIndex = Common.GlobalMethods.GetBaseVale<System.Int32>(inputs:  pars, idx:  1, defaultVal:  0);
            this._bibleIndex = Common.GlobalMethods.GetBaseVale<System.Int32>(inputs:  pars, idx:  2, defaultVal:  0);
            this.MapLevelGuide.transform.position = new UnityEngine.Vector3() {x = this._mapLevelPos, y = val_2.y, z = val_2.z};
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "71");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        public MapReelGuideDialog()
        {
        
        }
    
    }

}
