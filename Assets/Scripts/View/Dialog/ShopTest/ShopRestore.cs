using UnityEngine;

namespace View.Dialog.ShopTest
{
    public class ShopRestore : RecyclableItem
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public View.UIButton RestoreBtn;
        public UnityEngine.Animator AnimatorRestore;
        
        // Methods
        private void OnEnable()
        {
            AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void View.Dialog.ShopTest.ShopRestore::OnClickRestoreButton()));
        }
        private void OnDisable()
        {
            this.RemoveAllListeners();
        }
        public static View.Dialog.ShopTest.ShopRestore Create(UnityEngine.Transform parent, View.Dialog.ShopTest.ShopRestore prefab)
        {
            View.Dialog.ShopTest.ShopRestore val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.ShopTest.ShopRestore>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            string val_4 = Locale.LocaleManager.Translate(key:  "56");
            return val_1;
        }
        public void OnClickRestoreButton()
        {
            Logic.Game.GameManager.iap.RestorePurchases();
        }
        public void ShowItem()
        {
            this.AnimatorRestore.Play(stateName:  "RestoreShow");
        }
        public void HideItem()
        {
            this.AnimatorRestore.Play(stateName:  "RestoreHide");
        }
        public ShopRestore()
        {
        
        }
    
    }

}
