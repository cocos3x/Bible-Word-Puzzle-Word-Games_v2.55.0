using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerDoves : MonoBehaviour
    {
        // Fields
        public View.DailyPrayer.DailyPrayerDove DovePrefab;
        private System.Collections.Generic.List<View.DailyPrayer.DailyPrayerDove> _doves;
        private View.DailyPrayer.DailyPrayerDove _dove;
        private char _doveLetter;
        private System.Collections.Generic.List<char> _selectDoveLetter;
        
        // Methods
        private void DailyCreateDoveFromVacancy(View.CommonItem.LetterBlock letterBlock, bool isLeft = False)
        {
            if(letterBlock == 0)
            {
                    if(this._dove != 0)
            {
                    this._dove.ClearDove();
            }
            
                this._dove = 0;
                this.ClearDoves();
                return;
            }
            
            this._doveLetter = letterBlock.<letter>k__BackingField._letter;
            if(this._dove == 0)
            {
                    View.DailyPrayer.DailyPrayerDove val_5 = View.DailyPrayer.DailyPrayerDove.Create(parent:  this.transform, dovePrefab:  this.DovePrefab);
                this._dove = val_5;
                val_5.PlayDoveShowAni(slotDove:  letterBlock._slotDove);
                return;
            }
            
            this._dove.PlayDoveHideToShowAni(slotDove:  letterBlock._slotDove);
        }
        private void DailyFlyDoveReachVacancy(System.Collections.Generic.List<View.CommonItem.LetterBox> allDoveLetterBoxes)
        {
            if(this.CheckSelectLetterContainDove() != false)
            {
                    if((allDoveLetterBoxes != null) && (this._dove != 0))
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_dove", label:  "dove", value:  0);
                this._doves.Add(item:  this._dove);
                this._dove.PlayFlyAni(letterBox:  allDoveLetterBoxes.Find(match:  new System.Predicate<View.CommonItem.LetterBox>(object:  this, method:  System.Boolean View.DailyPrayer.DailyPrayerDoves::<DailyFlyDoveReachVacancy>b__6_0(View.CommonItem.LetterBox x))), callback:  0);
                this._dove = 0;
                return;
            }
            
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_puzzle", action:  "word_dove", label:  "normal", value:  0);
        }
        private void SetSelectDoveLetter(System.Collections.Generic.List<char> selectLetter)
        {
            this._selectDoveLetter = selectLetter;
        }
        private void ShuffleLetterBlock(View.CommonItem.LetterBlock letterBlock)
        {
            this.DailyCreateDoveFromVacancy(letterBlock:  letterBlock, isLeft:  false);
        }
        private void BackHomeClear()
        {
            if(this._dove != 0)
            {
                    this._dove.ClearDove();
            }
            
            this._dove = 0;
            this.ClearDoves();
        }
        private bool CheckSelectLetterContainDove()
        {
            if(this._selectDoveLetter == null)
            {
                    return false;
            }
            
            if(true < 1)
            {
                    return false;
            }
            
            return this._selectDoveLetter.Contains(item:  this._doveLetter);
        }
        private void ClearDoves()
        {
            System.Collections.Generic.List<View.DailyPrayer.DailyPrayerDove> val_1;
            bool val_1 = true;
            val_1 = this._doves;
            var val_2 = 0;
            label_5:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (true + 0) + 32.ClearDove();
            val_1 = this._doves;
            val_2 = val_2 + 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1.Clear();
        }
        private void OnEnable()
        {
            Message.Messager.Add<View.CommonItem.LetterBlock, System.Boolean>(cmd:  27, action:  new System.Action<View.CommonItem.LetterBlock, System.Boolean>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::DailyCreateDoveFromVacancy(View.CommonItem.LetterBlock letterBlock, bool isLeft)));
            Message.Messager.Add<System.Collections.Generic.List<View.CommonItem.LetterBox>>(cmd:  28, action:  new System.Action<System.Collections.Generic.List<View.CommonItem.LetterBox>>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::DailyFlyDoveReachVacancy(System.Collections.Generic.List<View.CommonItem.LetterBox> allDoveLetterBoxes)));
            Message.Messager.Add<System.Collections.Generic.List<System.Char>>(cmd:  29, action:  new System.Action<System.Collections.Generic.List<System.Char>>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::SetSelectDoveLetter(System.Collections.Generic.List<char> selectLetter)));
            Message.Messager.Add<View.CommonItem.LetterBlock>(cmd:  30, action:  new System.Action<View.CommonItem.LetterBlock>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::ShuffleLetterBlock(View.CommonItem.LetterBlock letterBlock)));
            Message.Messager.Add(cmd:  34, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::BackHomeClear()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<View.CommonItem.LetterBlock, System.Boolean>(cmd:  27, action:  new System.Action<View.CommonItem.LetterBlock, System.Boolean>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::DailyCreateDoveFromVacancy(View.CommonItem.LetterBlock letterBlock, bool isLeft)));
            Message.Messager.Remove<System.Collections.Generic.List<View.CommonItem.LetterBox>>(cmd:  28, action:  new System.Action<System.Collections.Generic.List<View.CommonItem.LetterBox>>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::DailyFlyDoveReachVacancy(System.Collections.Generic.List<View.CommonItem.LetterBox> allDoveLetterBoxes)));
            Message.Messager.Remove<System.Collections.Generic.List<System.Char>>(cmd:  29, action:  new System.Action<System.Collections.Generic.List<System.Char>>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::SetSelectDoveLetter(System.Collections.Generic.List<char> selectLetter)));
            Message.Messager.Remove<View.CommonItem.LetterBlock>(cmd:  30, action:  new System.Action<View.CommonItem.LetterBlock>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::ShuffleLetterBlock(View.CommonItem.LetterBlock letterBlock)));
            Message.Messager.Remove(cmd:  34, action:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerDoves::BackHomeClear()));
        }
        public DailyPrayerDoves()
        {
            this._doves = new System.Collections.Generic.List<View.DailyPrayer.DailyPrayerDove>();
        }
        private bool <DailyFlyDoveReachVacancy>b__6_0(View.CommonItem.LetterBox x)
        {
            return (bool)((x.<letter>k__BackingField._letter) == this._doveLetter) ? 1 : 0;
        }
    
    }

}
