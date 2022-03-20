using UnityEngine;

namespace View.Dialog.MapChestTest
{
    public class MapChestTestDialog : Dialog
    {
        // Fields
        private const int CoinSmallCount = 50;
        private const int CoinBigCount = 100;
        private UnityEngine.GameObject chestBox1;
        private TMPro.TextMeshProUGUI textSmallReward;
        private UnityEngine.GameObject chessBox2;
        private TMPro.TextMeshProUGUI textBigReward;
        private View.UIButton closeButton1;
        private View.UIButton closeButton2;
        private UnityEngine.Transform coinFlyStart;
        private TMPro.TMP_Text claimText1;
        private TMPro.TMP_Text claimText2;
        private float chestBoxLasted;
        private Data.Bible.BibleChestType bibleChestType;
        private int _rewardCount;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.MapChestTest.MapChestTestDialog::OnClickClaimButton()));
            AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.MapChestTest.MapChestTestDialog::OnClickClaimButton()));
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            this.claimText1.text = Locale.LocaleManager.Translate(key:  "44");
            this.claimText2.text = Locale.LocaleManager.Translate(key:  "44");
        }
        public override void OnTransmitParams(object[] pars)
        {
            this.OnTransmitParams(pars:  pars);
            object val_9 = pars[0];
            this.bibleChestType = null;
            this.chessBox2.SetActive(value:  (1152921504622874625 == 3) ? 1 : 0);
            this.chestBox1.SetActive(value:  (1152921504622874625 != 3) ? 1 : 0);
            Logic.Game.GameManager.gameSound.Play(clipName:  "chest_open", volumeScale:  1f, loop:  false, delay:  0f);
            this._rewardCount = (this.bibleChestType == 2) ? 100 : 50;
            if(this.bibleChestType == 3)
            {
                    int val_5 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.GetMissionChestReward();
                this._rewardCount = val_5;
            }
            
            this.textSmallReward.text = System.String.Format(format:  "+{0}", arg0:  val_5);
            this.textBigReward.text = System.String.Format(format:  "+{0}", arg0:  this._rewardCount);
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoins(value:  this._rewardCount, from:  "level_pass");
        }
        private void OnClickClaimButton()
        {
            Message.Messager.Dispatch(cmd:  13);
            if(this.bibleChestType == 3)
            {
                    UnityEngine.Vector3 val_2 = this.coinFlyStart.position;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                0 = this._rewardCount;
                Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  0, from:  "mission", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
            }
        
        }
        public MapChestTestDialog()
        {
        
        }
    
    }

}
