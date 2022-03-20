using UnityEngine;

namespace View.Dialog.ShopTest
{
    public class ShopMoreOffers : RecyclableItem
    {
        // Fields
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.Animator AnimatorMoreOffers;
        
        // Methods
        public static View.Dialog.ShopTest.ShopMoreOffers Create(UnityEngine.Transform parent, View.Dialog.ShopTest.ShopMoreOffers prefab)
        {
            View.Dialog.ShopTest.ShopMoreOffers val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.ShopTest.ShopMoreOffers>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.name = prefab.name;
            string val_4 = Locale.LocaleManager.Translate(key:  "51");
            return val_1;
        }
        public void OnClickMoreOffersButton()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            val_2 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameMoreOfferBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceShopScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "shop_dialog", action:  "more_offer", label:  "click", value:  0);
            Message.Messager.Dispatch(cmd:  104);
        }
        public void ShowItem()
        {
            this.AnimatorMoreOffers.Play(stateName:  "MoreOffersShow");
        }
        public void HideItem()
        {
            this.AnimatorMoreOffers.Play(stateName:  "MoreOffersHide");
        }
        public ShopMoreOffers()
        {
        
        }
    
    }

}
