using UnityEngine;

namespace View.Game
{
    public class GameBottomFit : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject ObjHoldBanner;
        
        // Methods
        private void UpdateBottom(float delay = 0)
        {
            Logic.Game.GameLevel val_5;
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) == false)
            {
                goto label_2;
            }
            
            val_5 = 0;
            if(this.ObjHoldBanner != null)
            {
                goto label_3;
            }
            
            label_2:
            val_5 = Logic.Game.GameManager.gameLevel;
            label_3:
            this.ObjHoldBanner.SetActive(value:  val_5.IsPassLevelForCurrentLevel(sectionIndex:  1, levelIndex:  1));
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Single>(cmd:  44, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameBottomFit::UpdateBottom(float delay)));
            this.UpdateBottom(delay:  null);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Single>(cmd:  44, action:  new System.Action<System.Single>(object:  this, method:  System.Void View.Game.GameBottomFit::UpdateBottom(float delay)));
        }
        public GameBottomFit()
        {
        
        }
    
    }

}
