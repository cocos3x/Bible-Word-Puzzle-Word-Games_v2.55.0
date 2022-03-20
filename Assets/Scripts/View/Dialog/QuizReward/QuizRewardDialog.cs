using UnityEngine;

namespace View.Dialog.QuizReward
{
    public class QuizRewardDialog : Dialog
    {
        // Fields
        public TMPro.TextMeshProUGUI rewardText;
        public UnityEngine.Transform coinFlyStart;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text ClaimText;
        private int _rewardCount;
        private bool isClaimClicked;
        
        // Methods
        protected override void OnEnable()
        {
            int val_6;
            this.OnEnable();
            this.isClaimClicked = false;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() != null)
            {
                    Data.Bean.PropertyBean val_2 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
                val_6 = this;
                this._rewardCount = val_2.quizReward;
            }
            else
            {
                    val_6 = this._rewardCount;
            }
            
            this.rewardText.text = "x" + val_6.ToString();
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  val_6);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "202");
            this.ClaimText.text = Locale.LocaleManager.Translate(key:  "44");
        }
        public void OnClaim()
        {
            var val_5;
            var val_6;
            if(this.isClaimClicked != false)
            {
                    return;
            }
            
            this.isClaimClicked = true;
            UnityEngine.Vector3 val_2 = this.coinFlyStart.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this._rewardCount, from:  "video_play", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            Platform.Analytics.EzAnalytics.SendGameScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = GameScrShow.ScrNameEnum.ScrNameMgScr}, curLevel:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), source:  new SourceEnum() {<Value>k__BackingField = GameScrShow.SourceEnum.SourceResultScr});
            Message.Messager.Dispatch(cmd:  45);
            goto typeof(View.Dialog.QuizReward.QuizRewardDialog).__il2cppRuntimeField_1E0;
        }
        public QuizRewardDialog()
        {
            this._rewardCount = 40;
        }
    
    }

}
