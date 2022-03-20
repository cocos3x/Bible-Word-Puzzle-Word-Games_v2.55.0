using UnityEngine;

namespace Logic.Game
{
    public class GameConfig : MonoBehaviour
    {
        // Fields
        private Data.Bean.PropertyBeans _propertyBeans;
        private Data.Bean.ProductsBean _productsBean;
        
        // Methods
        public void InitPropertyConfig()
        {
            UnityEngine.TextAsset val_1 = Resource.ResManager.GetConfig(configName:  "Config/Game/Property/property");
            if(val_1 == 0)
            {
                    return;
            }
            
            Data.Bean.PropertyBeans val_5 = UnityEngine.JsonUtility.FromJson<Data.Bean.PropertyBeans>(json:  Common.EzFile.RijndaelDecrypt(pString:  val_1.text, pKey:  ""));
            this._propertyBeans = val_5;
            if(val_5 != null)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "PropertyBeans Init failed: propertyAsset json to object is null");
        }
        public Data.Bean.PropertyBean GetPropertyConfig()
        {
            Data.Bean.PropertyBeans val_1;
            Data.Bean.PropertyBean val_2;
            val_1 = this._propertyBeans;
            if(val_1 != null)
            {
                    val_1 = this._propertyBeans;
                val_2 = this._propertyBeans.testReward;
                return (Data.Bean.PropertyBean)val_2;
            }
            
            val_2 = 0;
            return (Data.Bean.PropertyBean)val_2;
        }
        public void InitProductsConfig()
        {
            UnityEngine.TextAsset val_1 = Resource.ResManager.GetConfig(configName:  "Config/Game/Shop/products");
            if(val_1 == 0)
            {
                    return;
            }
            
            Data.Bean.ProductsBean val_5 = UnityEngine.JsonUtility.FromJson<Data.Bean.ProductsBean>(json:  Common.EzFile.RijndaelDecrypt(pString:  val_1.text, pKey:  ""));
            this._productsBean = val_5;
            if(val_5 != null)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "ProductsBean Init failed: productAsset json to object is null");
        }
        public Data.Bean.ProductsBean GetProductsConfig()
        {
            return (Data.Bean.ProductsBean)this._productsBean;
        }
        public GameConfig()
        {
        
        }
    
    }

}
