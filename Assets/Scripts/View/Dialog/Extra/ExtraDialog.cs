using UnityEngine;

namespace View.Dialog.Extra
{
    public class ExtraDialog : Dialog
    {
        // Fields
        private const int LimitCount = 20;
        public View.CommonItem.ProgressBar progressBar;
        public View.Dialog.Extra.ExtraWordsGrid extraWordsGrid;
        public UnityEngine.RectTransform rubbyFlyStart;
        public TMPro.TextMeshProUGUI claimButtonText;
        public UnityEngine.UI.Text progressText;
        public UnityEngine.UI.Text gemCountText;
        public UnityEngine.UI.Text TitleText;
        public UnityEngine.UI.Text TipsText;
        public TMPro.TMP_Text CollectText;
        private int reward;
        private int rewardDisplay;
        private int claim_extra;
        private int left5Count;
        private float progress;
        private int extraProgress;
        private int extraTragetCount;
        private bool isDialogShowed;
        
        // Methods
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "34");
            string val_2 = Locale.LocaleManager.Translate(key:  "35");
            this.CollectText.text = Locale.LocaleManager.Translate(key:  "22");
        }
        private void RefreshData()
        {
            int val_16;
            int val_17;
            int val_18;
            var val_19;
            this.rewardDisplay = 50;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() != null)
            {
                    Data.Bean.PropertyBean val_2 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                this.rewardDisplay = val_2.extraReward;
            }
            
            this.reward = 0;
            this.claim_extra = 0;
            this.extraProgress = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ExtraProgress;
            this.left5Count = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.Left5Count;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() == null)
            {
                goto label_8;
            }
            
            Data.Bean.PropertyBean val_8 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            Data.Bean.PropertyBean val_9 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            val_16 = this.left5Count - 1;
            if()
            {
                goto label_13;
            }
            
            val_17 = this.extraProgress;
            var val_15 = 0;
            val_19 = val_17;
            this.extraTragetCount = (val_17 > val_8.extraProgressCount) ? val_8.extraProgressCount : val_9.extraLeft5ProgressCount;
            label_15:
            if((-val_9.extraLeft5ProgressCount) < 0)
            {
                goto label_14;
            }
            
            int val_16 = this.reward;
            val_15 = val_15 + 1;
            val_19 = val_19 - val_9.extraLeft5ProgressCount;
            val_16 = this.rewardDisplay + val_16;
            this.claim_extra = this.claim_extra + val_9.extraLeft5ProgressCount;
            this.left5Count = val_16;
            val_16 = val_16 - 1;
            this.reward = val_16;
            if(val_15 < this.left5Count)
            {
                goto label_15;
            }
            
            label_14:
            if(val_19 < val_8.extraProgressCount)
            {
                goto label_18;
            }
            
            int val_17 = this.reward;
            val_19 = val_19 / val_8.extraProgressCount;
            val_17 = val_17 + (val_19 * this.rewardDisplay);
            this.reward = val_17;
            this.claim_extra = this.claim_extra + (val_19 * val_8.extraProgressCount);
            goto label_18;
            label_8:
            val_17 = this.extraProgress;
            val_18 = this.extraTragetCount;
            goto label_18;
            label_13:
            val_17 = this.extraProgress;
            this.extraTragetCount = val_8.extraProgressCount;
            if(val_17 >= val_8.extraProgressCount)
            {
                    int val_18 = this.reward;
                int val_13 = val_17 / val_8.extraProgressCount;
                val_18 = val_18 + (val_13 * this.rewardDisplay);
                this.reward = val_18;
                this.claim_extra = this.claim_extra + (val_13 * val_8.extraProgressCount);
            }
            
            val_18 = val_8.extraProgressCount;
            label_18:
            float val_19 = (float)val_17;
            val_19 = val_19 / (float)val_18;
            this.progress = val_19;
        }
        private void Update()
        {
            if(this.isDialogShowed != false)
            {
                    return;
            }
            
            this.isDialogShowed = true;
            this.OnDialogShow();
        }
        private View.Dialog.Extra.ExtraWordsGrid GetExtraWordsGridCtrl()
        {
            return (View.Dialog.Extra.ExtraWordsGrid)this.extraWordsGrid;
        }
        public void OnClaimBtnClick()
        {
            if(this.reward != 0)
            {
                    this.Claim();
            }
        
        }
        public override View.Dialog.Common.Dialog Open()
        {
            this.isDialogShowed = false;
            return this.Open();
        }
        private void OnDialogShow()
        {
            this.RefreshData();
            this.extraWordsGrid.SetWords(words: ref  Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.GetWords());
            this.UpdateUI();
        }
        private void CloseDialog()
        {
            goto typeof(View.Dialog.Extra.ExtraDialog).__il2cppRuntimeField_1E0;
        }
        private void Claim()
        {
            if(this.reward == 0)
            {
                    return;
            }
            
            Logic.Game.GameManager.gameSound.PlayButton();
            UnityEngine.Vector3 val_2 = this.rubbyFlyStart.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this.reward, from:  "extra_word", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.Extra.ExtraDialog::CloseDialog()), count:  0);
            int val_7 = this.extraProgress;
            val_7 = val_7 - this.claim_extra;
            this.extraProgress = val_7;
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.SetExtraProgress(progress:  this.extraProgress);
            Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.SetLeft5Count(count:  this.left5Count);
            Message.Messager.Dispatch(cmd:  51);
            this.RefreshData();
            this.UpdateUI();
        }
        private void UpdateUI()
        {
            this.progressBar.UpdateProgress(progress:  this.progress, time:  0.5f, reCalculateWidth:  false);
            string val_1 = System.String.Format(format:  "{0}/{1}", arg0:  this.extraProgress, arg1:  this.extraTragetCount);
            this.claimButtonText.text = (this.reward > 0) ? "Collect" : "OK";
            string val_4 = "x" + this.rewardDisplay.ToString();
        }
        public ExtraDialog()
        {
            mem[1152921512762529736] = 257;
            mem[1152921512762529739] = 1;
            mem[1152921512762529744] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
