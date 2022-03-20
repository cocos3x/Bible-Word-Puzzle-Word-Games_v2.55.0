using UnityEngine;

namespace View.CommonItem
{
    public class ShopSale : MonoBehaviour
    {
        // Fields
        private static bool isUnfold;
        public UnityEngine.Animator AnimatorSale;
        public UnityEngine.UI.Text TextSale;
        
        // Methods
        private void PlayShowAni()
        {
            string val_1;
            if(View.CommonItem.ShopSale.isUnfold != false)
            {
                    val_1 = "saleBanner_unfolded";
            }
            else
            {
                    View.CommonItem.ShopSale.isUnfold = true;
                val_1 = "saleBanner_unfold";
            }
            
            this.AnimatorSale.Play(stateName:  val_1);
        }
        private void CheckShopSale()
        {
            UnityEngine.GameObject val_3 = this.AnimatorSale.gameObject;
            if((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.IsHaveLimitedTimePack()) != false)
            {
                    val_3.SetActive(value:  true);
                this.PlayShowAni();
                return;
            }
            
            val_3.SetActive(value:  false);
        }
        private void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "57");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void Awake()
        {
            this.LocaleTranslate();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  79, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopSale::CheckShopSale()));
            this.CheckShopSale();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  79, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopSale::CheckShopSale()));
        }
        public ShopSale()
        {
        
        }
    
    }

}
