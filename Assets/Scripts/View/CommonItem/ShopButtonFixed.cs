using UnityEngine;

namespace View.CommonItem
{
    public class ShopButtonFixed : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image _imagePanel;
        private UnityEngine.Transform _transformCoin;
        private UnityEngine.GameObject effectGain;
        private UnityEngine.UI.Button _buttonShop;
        private bool _isShowDialogUp;
        
        // Methods
        private void Awake()
        {
            var val_13;
            UnityEngine.Events.UnityAction val_15;
            this._imagePanel = this.transform.Find(n:  "Button").GetComponent<UnityEngine.UI.Image>();
            this._transformCoin = this.transform.Find(n:  "Button/Coin");
            this.effectGain = this.transform.Find(n:  "Button/Coin/eff_coins_gain").gameObject;
            this._buttonShop = this.transform.Find(n:  "Button").GetComponent<UnityEngine.UI.Button>();
            val_13 = null;
            val_13 = null;
            val_15 = ShopButtonFixed.<>c.<>9__5_0;
            if(val_15 == null)
            {
                    UnityEngine.Events.UnityAction val_12 = null;
                val_15 = val_12;
                val_12 = new UnityEngine.Events.UnityAction(object:  ShopButtonFixed.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopButtonFixed.<>c::<Awake>b__5_0());
                ShopButtonFixed.<>c.<>9__5_0 = val_15;
            }
            
            val_11.m_OnClick.AddListener(call:  val_15);
        }
        private void GetCoinIconPosition()
        {
            UnityEngine.Vector3 val_1 = this._transformCoin.position;
            Message.Messager.Dispatch<UnityEngine.Vector3>(cmd:  25, t:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        private void CoinChangeNotify()
        {
            this.effectGain.gameObject.SetActive(value:  false);
            this.effectGain.gameObject.SetActive(value:  true);
        }
        private void OnEnable()
        {
            this.effectGain.gameObject.SetActive(value:  false);
            Message.Messager.Add(cmd:  24, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopButtonFixed::GetCoinIconPosition()));
            Message.Messager.Add(cmd:  78, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopButtonFixed::CoinChangeNotify()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  24, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopButtonFixed::GetCoinIconPosition()));
            Message.Messager.Remove(cmd:  78, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ShopButtonFixed::CoinChangeNotify()));
        }
        public ShopButtonFixed()
        {
        
        }
    
    }

}
