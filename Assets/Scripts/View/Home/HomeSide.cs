using UnityEngine;

namespace View.Home
{
    public class HomeSide : MonoBehaviour
    {
        // Fields
        public View.Home.ButterFlyActivity ButterFly;
        
        // Methods
        private void OnEnable()
        {
            this.CheckButterFlyActivityIsOpen();
        }
        private void CheckButterFlyActivityIsOpen()
        {
            this.ButterFly.gameObject.SetActive(value:  Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.HomeIsShowButterFlyActivity());
        }
        public HomeSide()
        {
        
        }
    
    }

}
