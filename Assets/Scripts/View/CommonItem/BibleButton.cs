using UnityEngine;

namespace View.CommonItem
{
    public class BibleButton : MonoBehaviour
    {
        // Fields
        public string from;
        
        // Methods
        private void Awake()
        {
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            val_1.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.CommonItem.BibleButton::<Awake>b__1_0()));
        }
        public BibleButton()
        {
        
        }
        private void <Awake>b__1_0()
        {
            Logic.Game.GameDiglog val_5;
            var val_6;
            val_5 = this;
            if(Logic.Game.GameManager.gameBible.IsDataEmpty() == true)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_2.<IsGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendGameBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = GameBtnClick.BtnNameEnum.BtnNameBibleBtn}, levelName:  "");
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_button_verse_click", label:  this.from, value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "bible", value:  0);
            val_5 = Logic.Game.GameManager.gameDialog;
            object[] val_3 = new object[1];
            val_3[0] = 1;
            View.Dialog.Common.Dialog val_4 = val_5.OpenAddParams(name:  "MainBibleBookTestDialog", pars:  val_3);
        }
    
    }

}
