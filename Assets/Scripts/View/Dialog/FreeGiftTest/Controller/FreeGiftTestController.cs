using UnityEngine;

namespace View.Dialog.FreeGiftTest.Controller
{
    public class FreeGiftTestController : SingletonController<View.Dialog.FreeGiftTest.Controller.FreeGiftTestController>
    {
        // Fields
        private bool <IsHaveLetterGiftFromGame>k__BackingField;
        private bool <IsHaveLetterGiftFromDaily>k__BackingField;
        private string <IsAppearedLetterGiftFromGame>k__BackingField;
        private int <IsAppearedLetterGiftFromGameCount>k__BackingField;
        private string <IsAppearedLetterGiftFromDaily>k__BackingField;
        private int <IsAppearedLetterGiftFromDailyCount>k__BackingField;
        private bool _isGiftBoxCooling;
        
        // Properties
        public bool IsHaveLetterGiftFromGame { get; set; }
        public bool IsHaveLetterGiftFromDaily { get; set; }
        public string IsAppearedLetterGiftFromGame { get; set; }
        public int IsAppearedLetterGiftFromGameCount { get; set; }
        public string IsAppearedLetterGiftFromDaily { get; set; }
        public int IsAppearedLetterGiftFromDailyCount { get; set; }
        public bool IsGiftBoxCooling { get; set; }
        
        // Methods
        public bool get_IsHaveLetterGiftFromGame()
        {
            return (bool)this.<IsHaveLetterGiftFromGame>k__BackingField;
        }
        public void set_IsHaveLetterGiftFromGame(bool value)
        {
            this.<IsHaveLetterGiftFromGame>k__BackingField = value;
        }
        public bool get_IsHaveLetterGiftFromDaily()
        {
            return (bool)this.<IsHaveLetterGiftFromDaily>k__BackingField;
        }
        public void set_IsHaveLetterGiftFromDaily(bool value)
        {
            this.<IsHaveLetterGiftFromDaily>k__BackingField = value;
        }
        public string get_IsAppearedLetterGiftFromGame()
        {
            return (string)this.<IsAppearedLetterGiftFromGame>k__BackingField;
        }
        public void set_IsAppearedLetterGiftFromGame(string value)
        {
            this.<IsAppearedLetterGiftFromGame>k__BackingField = value;
        }
        public int get_IsAppearedLetterGiftFromGameCount()
        {
            return (int)this.<IsAppearedLetterGiftFromGameCount>k__BackingField;
        }
        public void set_IsAppearedLetterGiftFromGameCount(int value)
        {
            this.<IsAppearedLetterGiftFromGameCount>k__BackingField = value;
        }
        public string get_IsAppearedLetterGiftFromDaily()
        {
            return (string)this.<IsAppearedLetterGiftFromDaily>k__BackingField;
        }
        public void set_IsAppearedLetterGiftFromDaily(string value)
        {
            this.<IsAppearedLetterGiftFromDaily>k__BackingField = value;
        }
        public int get_IsAppearedLetterGiftFromDailyCount()
        {
            return (int)this.<IsAppearedLetterGiftFromDailyCount>k__BackingField;
        }
        public void set_IsAppearedLetterGiftFromDailyCount(int value)
        {
            this.<IsAppearedLetterGiftFromDailyCount>k__BackingField = value;
        }
        public bool get_IsGiftBoxCooling()
        {
            return (bool)this._isGiftBoxCooling;
        }
        public void set_IsGiftBoxCooling(bool value)
        {
            this._isGiftBoxCooling = value;
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.FreeGiftTest.Controller.FreeGiftTestController::UpdateGiftBoxCooling()));
            if(value == false)
            {
                    return;
            }
            
            Common.TimerEvent.Add(time:  60f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.FreeGiftTest.Controller.FreeGiftTestController::UpdateGiftBoxCooling()), isrepeat:  false);
        }
        public bool IsHaveLetterGiftBox()
        {
            var val_4;
            int val_5;
            if(this._isGiftBoxCooling == false)
            {
                goto label_1;
            }
            
            label_7:
            val_4 = 0;
            return (bool)(val_5 < 2) ? 1 : 0;
            label_1:
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState == 3)
            {
                    val_5 = this.<IsAppearedLetterGiftFromGameCount>k__BackingField;
                return (bool)(val_5 < 2) ? 1 : 0;
            }
            
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState != 4)
            {
                goto label_7;
            }
            
            val_5 = this.<IsAppearedLetterGiftFromDailyCount>k__BackingField;
            return (bool)(val_5 < 2) ? 1 : 0;
        }
        public void ClearLetterGiftCount()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                goto label_2;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((System.String.op_Inequality(a:  this.<IsAppearedLetterGiftFromGame>k__BackingField, b:  Logic.Game.GameManager.gameBible.GetBibleProgress(sectionIndex:  val_2.<CurrentSectionIndex>k__BackingField))) == false)
            {
                goto label_10;
            }
            
            this.<IsAppearedLetterGiftFromGameCount>k__BackingField = 0;
            goto label_10;
            label_2:
            View.Controller.MainController val_5 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_5._bibleGameState == 4)
            {
                    Data.DailyRecord.DailyRecordDataManager val_6 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                if((System.String.op_Inequality(a:  this.<IsAppearedLetterGiftFromDaily>k__BackingField, b:  val_6.<DailyLevel>k__BackingField)) != false)
            {
                    this.<IsAppearedLetterGiftFromDailyCount>k__BackingField = 0;
            }
            
            }
            
            label_10:
            this.IsGiftBoxCooling = false;
        }
        private int GetLetterGiftBoxMaxCount()
        {
            return 2;
        }
        private void UpdateGiftBoxCooling()
        {
            this.IsGiftBoxCooling = false;
        }
        public FreeGiftTestController()
        {
        
        }
    
    }

}
