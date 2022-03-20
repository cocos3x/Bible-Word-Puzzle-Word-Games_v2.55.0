using UnityEngine;

namespace View.Home
{
    public class LoadingContent : MonoBehaviour
    {
        // Fields
        public View.CommonItem.LoadingItem Item;
        
        // Methods
        public void ShowLoading()
        {
            bool val_2 = Common.Singleton<Data.Login.LoginDataManager>.Instance.IsFirstLoginToVersion();
            this.gameObject.SetActive(value:  true);
        }
        public LoadingContent()
        {
        
        }
    
    }

}
