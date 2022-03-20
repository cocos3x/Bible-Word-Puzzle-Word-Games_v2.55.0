using UnityEngine;

namespace View.Dialog.RecallReward
{
    public class RecallRewardDialog : Dialog
    {
        // Fields
        public TMPro.TextMeshProUGUI rewardText;
        public UnityEngine.Transform coinFlyStart;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text ClaimText;
        private bool isClaimClicked;
        private int _rewardCount;
        
        // Methods
        protected override void OnEnable()
        {
            var val_6;
            this.OnEnable();
            this.isClaimClicked = false;
            Data.Reward.RewardDataManager val_1 = Common.Singleton<Data.Reward.RewardDataManager>.Instance;
            if((val_1.<RecallRewardType>k__BackingField) > 3)
            {
                goto label_2;
            }
            
            var val_5 = 15448188 + (val_1.<RecallRewardType>k__BackingField) << 2;
            val_5 = val_5 + 15448188;
            goto (15448188 + (val_1.<RecallRewardType>k__BackingField) << 2 + 15448188);
            label_13:
            this.rewardText.text = "x" + ToString();
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  200);
            return;
            label_2:
            this._rewardCount = 50;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "[RecallRewardDialog] RecallRewardType no exist", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            goto label_13;
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "199");
            this.ClaimText.text = Locale.LocaleManager.Translate(key:  "44");
        }
        public void OnClaim()
        {
            if(this.isClaimClicked != false)
            {
                    return;
            }
            
            this.isClaimClicked = true;
            UnityEngine.Vector3 val_2 = this.coinFlyStart.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this._rewardCount, from:  "push", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
            Message.Messager.Dispatch(cmd:  45);
            goto typeof(View.Dialog.RecallReward.RecallRewardDialog).__il2cppRuntimeField_1E0;
        }
        public RecallRewardDialog()
        {
            this._rewardCount = 50;
        }
    
    }

}
