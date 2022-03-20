using UnityEngine;

namespace View.Dialog.WordTreasure
{
    public class WordTreasureTotalItem : MonoBehaviour
    {
        // Fields
        private const float TimeAlpha = 0.5;
        public UnityEngine.CanvasGroup CanvasItem;
        public TMPro.TextMeshProUGUI TextDesc;
        public UnityEngine.UI.Slider SliderProgress;
        private int _totalQuantity;
        private DG.Tweening.Sequence _sequence;
        
        // Methods
        public void UpdateTotalItem()
        {
            this.TextDesc.text = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "113"), arg0:  Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetMissionTotalQuantity());
            Logic.Treasure.TreasureController val_5 = Common.Singleton<Logic.Treasure.TreasureController>.Instance;
        }
        public DG.Tweening.Sequence CheckMissionReward()
        {
            DG.Tweening.Sequence val_11;
            DG.Tweening.Core.DOGetter<System.Single> val_12;
            float val_2 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetNowMissionChestProgress();
            Logic.Treasure.TreasureController val_3 = Common.Singleton<Logic.Treasure.TreasureController>.Instance;
            if((val_2 <= val_3._oldMissionChestProgress) && (val_3._oldMissionChestProgress < 1f))
            {
                    val_11 = this._sequence;
                return (DG.Tweening.Sequence)this._sequence;
            }
            
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            val_11 = this;
            this._sequence = val_4;
            DG.Tweening.Core.DOGetter<System.Single> val_5 = null;
            val_12 = val_5;
            val_5 = new DG.Tweening.Core.DOGetter<System.Single>(object:  this, method:  System.Single View.Dialog.WordTreasure.WordTreasureTotalItem::<CheckMissionReward>b__7_0());
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.DOTween.To(getter:  val_12, setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this, method:  System.Void View.Dialog.WordTreasure.WordTreasureTotalItem::<CheckMissionReward>b__7_1(float x)), endValue:  val_2, duration:  0.5f));
            if(val_2 < 1f)
            {
                    return (DG.Tweening.Sequence)this._sequence;
            }
            
            DG.Tweening.TweenCallback val_9 = null;
            val_12 = val_9;
            val_9 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.WordTreasure.WordTreasureTotalItem::<CheckMissionReward>b__7_2());
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  val_12);
            return (DG.Tweening.Sequence)this._sequence;
        }
        private void OnDisable()
        {
            if(this._sequence == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this._sequence, complete:  false);
            this._sequence = 0;
        }
        public WordTreasureTotalItem()
        {
        
        }
        private float <CheckMissionReward>b__7_0()
        {
            if(this.SliderProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <CheckMissionReward>b__7_1(float x)
        {
            if(this.SliderProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <CheckMissionReward>b__7_2()
        {
            Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishMissionChest();
            object[] val_2 = new object[1];
            val_2[0] = 3;
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MapChestTestDialog", pars:  val_2);
            this.UpdateTotalItem();
        }
    
    }

}
