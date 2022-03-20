using UnityEngine;

namespace View.Dialog.WordTreasure
{
    public class WordTreasureDialog : Dialog
    {
        // Fields
        public View.Dialog.WordTreasure.WordTreasureTotalItem TotalItem;
        public View.Dialog.WordTreasure.WordTreasureItem[] Items;
        public UnityEngine.UI.Button ButtonClose;
        public UnityEngine.UI.Button ButtonOk;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text OkText;
        
        // Methods
        public void OnClickOkButton()
        {
            goto typeof(View.Dialog.WordTreasure.WordTreasureDialog).__il2cppRuntimeField_1E0;
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "112");
            this.OkText.text = Locale.LocaleManager.Translate(key:  "36");
        }
        private void UpdateWordTreasure()
        {
            this.ButtonClose.gameObject.SetActive(value:  false);
            this.ButtonOk.gameObject.SetActive(value:  false);
            this.TotalItem.UpdateTotalItem();
            int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            var val_15 = 4;
            label_16:
            int val_5 = val_15 - 4;
            if(val_5 >= this.Items.Length)
            {
                goto label_9;
            }
            
            this.Items[0].UpdateItem(index:  val_5, isAni:  false);
            DG.Tweening.Sequence val_6 = this.Items[0].CheckMission();
            if(val_6 != null)
            {
                    DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  val_6);
            }
            
            val_15 = val_15 + 1;
            if(this.Items != null)
            {
                goto label_16;
            }
            
            label_9:
            DG.Tweening.Sequence val_8 = this.TotalItem.CheckMissionReward();
            if(val_8 != null)
            {
                    DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  val_8);
            }
            
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.WordTreasure.WordTreasureDialog::<UpdateWordTreasure>b__8_0()));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_4, id:  this);
        }
        private void CollectAllFinishReward()
        {
            Common.Singleton<Logic.Treasure.TreasureController>.Instance.UpdateOldProgress();
        }
        protected override void OnEnable()
        {
            var val_4;
            this.OnEnable();
            Logic.Treasure.TreasureController val_1 = Common.Singleton<Logic.Treasure.TreasureController>.Instance;
            if(val_1.MissionsCount == this.Items.Length)
            {
                    this.UpdateWordTreasure();
                return;
            }
            
            this.ButtonClose.gameObject.SetActive(value:  true);
            this.ButtonOk.gameObject.SetActive(value:  true);
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "WordTreasureDialog OnEnable 数据不匹配... ", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void OnDisable()
        {
            this.CollectAllFinishReward();
        }
        public WordTreasureDialog()
        {
        
        }
        private void <UpdateWordTreasure>b__8_0()
        {
            this.ButtonClose.gameObject.SetActive(value:  true);
            this.ButtonOk.gameObject.SetActive(value:  true);
        }
    
    }

}
