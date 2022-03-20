using UnityEngine;

namespace View.CommonItem.Combo
{
    public class ComboNormal : RecyclableItem
    {
        // Fields
        private UnityEngine.UI.Image[] imageTexts;
        public UnityEngine.GameObject Effect1;
        private int _combo;
        private int _spriteIndex;
        
        // Methods
        public void PlayComboAni(int combo = 0)
        {
            this._combo = combo;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "combo", value:  0);
            if(this._combo != 0)
            {
                    Platform.Analytics.EzAnalytics.LogEvent(eventName:  "game", parameterName:  "combos", parameterValue:  this._combo);
            }
            else
            {
                    Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "you_made_it", value:  0);
            }
            
            this.Effect1.gameObject.SetActive(value:  true);
            this.gameObject.SetActive(value:  true);
        }
        public void SetComboInfo(int index)
        {
            var val_4;
            string val_5;
            if(this._spriteIndex == index)
            {
                    return;
            }
            
            this._spriteIndex = index;
            val_4 = "Atlas/Game";
            Locale.LocaleE val_1 = Locale.LocaleManager.GetCurLanguage();
            if(val_1 == 3)
            {
                goto label_2;
            }
            
            if(val_1 == 2)
            {
                goto label_3;
            }
            
            if(val_1 != 1)
            {
                goto label_4;
            }
            
            val_5 = "Atlas/LocalComboPortuguese";
            goto label_6;
            label_2:
            val_5 = "Atlas/LocalComboFrench";
            goto label_6;
            label_3:
            val_5 = "Atlas/LocalComboSpanish";
            label_6:
            label_4:
            var val_7 = 4;
            do
            {
                object val_2 = val_7 - 4;
                if(val_2 >= this.imageTexts.Length)
            {
                    return;
            }
            
                this.imageTexts[0].sprite = Resource.ResManager.GetSpriteFromPool(atlas:  val_5, spriteName:  System.String.Format(format:  "icon_combo_{0}_{1}", arg0:  index, arg1:  val_2));
                UnityEngine.UI.Image val_6 = this.imageTexts[0];
                val_7 = val_7 + 1;
            }
            while(this.imageTexts != null);
            
            throw new NullReferenceException();
        }
        public void AnimationCallBack()
        {
            Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishWords();
            if(this._combo == 4)
            {
                    Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishGodBeWithYou();
            }
            
            this.gameObject.SetActive(value:  false);
        }
        public ComboNormal()
        {
            this._spriteIndex = 0;
        }
    
    }

}
