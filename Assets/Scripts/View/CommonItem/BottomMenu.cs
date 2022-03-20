using UnityEngine;

namespace View.CommonItem
{
    public class BottomMenu : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Button ButtonHint;
        public UnityEngine.UI.Button ButtonShuffle;
        
        // Methods
        public void OnClickShuffleButton()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "refresh", value:  0);
            Message.Messager.Dispatch(cmd:  58);
        }
        private void SetBottomButtonState(bool isEnable)
        {
            bool val_1 = isEnable;
            this.ButtonHint.enabled = val_1;
            this.ButtonShuffle.enabled = val_1;
        }
        private void ChangeBottomBtnCanvasSorting(bool isGuide)
        {
            UnityEngine.GameObject val_1 = this.ButtonHint.gameObject;
            if(isGuide != false)
            {
                    Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  val_1, name:  "Dialog", order:  12);
                Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  this.ButtonShuffle.gameObject, name:  "Dialog", order:  12);
                return;
            }
            
            Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  val_1, name:  "Default", order:  1);
            Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  this.ButtonShuffle.gameObject, name:  "Default", order:  1);
            UnityEngine.UI.GraphicRaycaster val_5 = this.ButtonHint.gameObject.AddComponent<UnityEngine.UI.GraphicRaycaster>();
            UnityEngine.UI.GraphicRaycaster val_7 = this.ButtonShuffle.gameObject.AddComponent<UnityEngine.UI.GraphicRaycaster>();
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Boolean>(cmd:  59, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.CommonItem.BottomMenu::SetBottomButtonState(bool isEnable)));
            Message.Messager.Add<System.Boolean>(cmd:  60, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.CommonItem.BottomMenu::ChangeBottomBtnCanvasSorting(bool isGuide)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Boolean>(cmd:  59, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.CommonItem.BottomMenu::SetBottomButtonState(bool isEnable)));
            Message.Messager.Remove<System.Boolean>(cmd:  60, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.CommonItem.BottomMenu::ChangeBottomBtnCanvasSorting(bool isGuide)));
        }
        public BottomMenu()
        {
        
        }
    
    }

}
