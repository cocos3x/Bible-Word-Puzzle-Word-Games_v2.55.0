using UnityEngine;

namespace View.Dialog.NoviceReward
{
    public class NoviceRewardDialog : Dialog
    {
        // Fields
        public TMPro.TextMeshProUGUI TextContent;
        public TMPro.TextMeshProUGUI TextRewardCount;
        public UnityEngine.Transform CoinFlyStart;
        public UnityEngine.Sprite[] SpriteCoins;
        public UnityEngine.UI.Image ImageCoin;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text CollectText;
        private bool _isCollectClicked;
        private int _rewardCount;
        
        // Methods
        public void OnClickCollectButton()
        {
            this.CollectRewards();
        }
        public void OnClickCloseButton()
        {
            if(this._isCollectClicked != false)
            {
                
            }
            else
            {
                    this.CollectRewards();
            }
        
        }
        public override void OnTransmitParams(object[] pars)
        {
            var val_10;
            var val_11;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            this.OnTransmitParams(pars:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this._isCollectClicked = false;
            if((Common.GlobalMethods.GetBaseVale<System.Boolean>(inputs:  pars, idx:  0, defaultVal:  0)) == false)
            {
                goto label_7;
            }
            
            this.TextContent.text = Locale.LocaleManager.Translate(key:  "214");
            val_11 = this;
            mem[1152921512725136900] = 120;
            if(Platform.AbTest.GameABTestManager.IsReward() == false)
            {
                goto label_12;
            }
            
            if(this.ImageCoin != null)
            {
                goto label_14;
            }
            
            label_7:
            this._rewardCount = 300;
            this.TextContent.text = System.String.Format(format:  Locale.LocaleManager.Translate(key:  "27"), arg0:  this._rewardCount);
            val_11 = this;
            this.ImageCoin.sprite = this.SpriteCoins[1];
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.SetHaveNoviceReward(isHave:  false);
            goto label_21;
            label_12:
            label_14:
            this.ImageCoin.sprite = null;
            Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.SetHaveNoviceBankruptcy(isHave:  false);
            label_21:
            this.TextRewardCount.text = "x" + this._rewardCount;
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  this._rewardCount);
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "26");
            this.CollectText.text = Locale.LocaleManager.Translate(key:  "22");
        }
        private void CollectRewards()
        {
            if(this._isCollectClicked != false)
            {
                    return;
            }
            
            this._isCollectClicked = true;
            UnityEngine.Vector3 val_2 = this.CoinFlyStart.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this._rewardCount, from:  "video_play", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(View.Dialog.NoviceReward.NoviceRewardDialog).__il2cppRuntimeField_1E8), count:  0);
        }
        public NoviceRewardDialog()
        {
        
        }
    
    }

}
