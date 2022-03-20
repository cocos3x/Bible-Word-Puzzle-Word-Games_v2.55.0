using UnityEngine;

namespace View.Dialog.WordTreasure
{
    public class WordTreasureItem : MonoBehaviour
    {
        // Fields
        private const float TimeAddProgress = 0.5;
        private const float TimeAlpha = 0.25;
        private readonly string[] DescFormats;
        public UnityEngine.CanvasGroup CanvasItem;
        public UnityEngine.Transform CoinFlyStart;
        public UnityEngine.UI.Text TextDesc;
        public UnityEngine.UI.Slider SliderProgress;
        public TMPro.TextMeshProUGUI TextCount;
        private int _missionIndex;
        private DG.Tweening.Sequence _sequence;
        
        // Methods
        public void UpdateItem(int index, bool isAni = False)
        {
            bool val_14 = isAni;
            if(val_14 != true)
            {
                    this.CanvasItem.alpha = 1f;
                val_14 = this.CanvasItem.transform;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
                val_14.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            }
            
            this._missionIndex = index;
            if(((Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetMissionItemForIndex(missionIndex:  this._missionIndex)) != null) && (this._missionIndex < this.DescFormats.Length))
            {
                    val_14 = Locale.LocaleManager.Translate(key:  this.DescFormats[this._missionIndex]);
                Data.Treasure.MissionItem val_7 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetMissionItemForIndex(missionIndex:  this._missionIndex);
                string val_8 = System.String.Format(format:  val_14, arg0:  val_7.quantity);
            }
            
            float val_10 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetOldMissionProgressForIndex(missionIndex:  this._missionIndex);
            this.TextCount.text = System.String.Format(format:  "x{0}", arg0:  Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetMissionRewardForIndex(missionIndex:  this._missionIndex));
        }
        public DG.Tweening.Sequence CheckMission()
        {
            object val_28;
            DG.Tweening.Sequence val_29;
            DG.Tweening.Core.DOGetter<System.Single> val_30;
            val_28 = this;
            float val_2 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetNowMissionProgressForIndex(missionIndex:  this._missionIndex);
            float val_4 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetOldMissionProgressForIndex(missionIndex:  this._missionIndex);
            if((val_2 <= val_4) && (val_4 < 1f))
            {
                    val_29 = this._sequence;
                return (DG.Tweening.Sequence)this._sequence;
            }
            
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            val_29 = val_28;
            this._sequence = val_5;
            DG.Tweening.Core.DOGetter<System.Single> val_6 = null;
            val_30 = val_6;
            val_6 = new DG.Tweening.Core.DOGetter<System.Single>(object:  this, method:  System.Single View.Dialog.WordTreasure.WordTreasureItem::<CheckMission>b__11_0());
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.DOTween.To(getter:  val_30, setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this, method:  System.Void View.Dialog.WordTreasure.WordTreasureItem::<CheckMission>b__11_1(float x)), endValue:  val_2, duration:  0.5f));
            if(val_2 < 1f)
            {
                    return (DG.Tweening.Sequence)this._sequence;
            }
            
            Common.Singleton<Logic.Treasure.TreasureController>.Instance.FinishMissionForIndex(missionIndex:  this._missionIndex);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.WordTreasure.WordTreasureItem::<CheckMission>b__11_2()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this._sequence, interval:  1f);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasItem, endValue:  0.3f, duration:  0.25f));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  this._sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleY(target:  this.CanvasItem.transform, endValue:  0f, duration:  0.25f), ease:  1));
            DG.Tweening.TweenCallback val_20 = null;
            val_30 = val_20;
            val_20 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.WordTreasure.WordTreasureItem::<CheckMission>b__11_3());
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this._sequence, callback:  val_30);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  this._sequence, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasItem, endValue:  1f, duration:  0.25f));
            val_28 = this._sequence;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_28, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScaleY(target:  this.CanvasItem.transform, endValue:  1f, duration:  0.25f), ease:  1));
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
        public WordTreasureItem()
        {
            int val_2;
            string[] val_1 = new string[3];
            val_2 = val_1.Length;
            val_1[0] = "114";
            val_2 = val_1.Length;
            val_1[1] = "115";
            val_2 = val_1.Length;
            val_1[2] = "116";
            this.DescFormats = val_1;
        }
        private float <CheckMission>b__11_0()
        {
            if(this.SliderProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <CheckMission>b__11_1(float x)
        {
            if(this.SliderProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <CheckMission>b__11_2()
        {
            Data.Treasure.MissionItem val_3 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetMissionItemForIndex(missionIndex:  this._missionIndex);
            UnityEngine.Vector3 val_4 = this.CoinFlyStart.position;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  val_3.reward, from:  "mission", centerPosition:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
        }
        private void <CheckMission>b__11_3()
        {
            this.UpdateItem(index:  this._missionIndex, isAni:  true);
        }
    
    }

}
