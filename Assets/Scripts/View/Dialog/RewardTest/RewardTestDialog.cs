using UnityEngine;

namespace View.Dialog.RewardTest
{
    public class RewardTestDialog : Dialog
    {
        // Fields
        public TMPro.TextMeshProUGUI rewardText;
        public UnityEngine.Transform coinFlyStart;
        public UnityEngine.Sprite[] SpriteCoins;
        public UnityEngine.UI.Image ImageCoin;
        public UnityEngine.UI.Image ImageHint;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text ClaimText;
        public UnityEngine.UI.Text TipsText;
        private int _rewardCount;
        private Logic.Define.RewardedVideoTriggerType triggerType;
        private bool isClaimClicked;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.isClaimClicked = false;
            this.AddTodayPlayCount();
        }
        protected override void LocaleTranslate()
        {
            this.LocaleTranslate();
            string val_1 = Locale.LocaleManager.Translate(key:  "197");
            this.ClaimText.text = Locale.LocaleManager.Translate(key:  "44");
            string val_3 = Locale.LocaleManager.Translate(key:  "106");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void OnCloseUI()
        {
            if(this.triggerType == 2)
            {
                    Message.Messager.Dispatch(cmd:  2);
            }
        
        }
        public void OnClaim()
        {
            if(this.isClaimClicked != false)
            {
                    return;
            }
            
            this.isClaimClicked = true;
            if(this._rewardCount == 1)
            {
                    Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddHintFreeStatus(hint:  this._rewardCount);
                Message.Messager.Dispatch(cmd:  71);
            }
            else
            {
                    UnityEngine.Vector3 val_3 = this.coinFlyStart.position;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this._rewardCount, from:  "video_play", centerPosition:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
            }
            
            this.OnCloseUI();
        }
        private int GetTodayPlayCount()
        {
            return Common.Singleton<Data.Reward.RewardDataManager>.Instance.RewardDayCount;
        }
        private void AddTodayPlayCount()
        {
            Data.Reward.RewardDataManager val_1 = Common.Singleton<Data.Reward.RewardDataManager>.Instance;
            Data.Reward.RewardDataManager val_3 = Common.Singleton<Data.Reward.RewardDataManager>.Instance;
            if((Common.GlobalMethods.IsToday(des:  new System.DateTime() {dateData = val_1._lastRewardDateTime}, res:  new System.Nullable<System.DateTime>() {HasValue = false})) != false)
            {
                    val_3.AddRewardDayCount();
                return;
            }
            
            System.DateTime val_4 = System.DateTime.Now;
            val_3.LastRewardDateTime = new System.DateTime() {dateData = val_4.dateData};
            Common.Singleton<Data.Reward.RewardDataManager>.Instance.SetRewardDayCount(count:  1);
        }
        public void SetTriggerType(Logic.Define.RewardedVideoTriggerType type)
        {
            this.triggerType = type;
        }
        public void SetRewardCount(int count, int extra = 0)
        {
            this._rewardCount = count;
            if(count == 1)
            {
                    this.SetRewardInfo(isHint:  true);
                return;
            }
            
            this.SetRewardInfo(isHint:  false);
            this.rewardText.text = "x" + this._rewardCount.ToString();
            if(this.SpriteCoins.Length > 1)
            {
                    var val_3 = (this._rewardCount > 40) ? 40 : 32;
                this.ImageCoin.sprite = null;
            }
            
            if(extra >= 1)
            {
                    this = this._rewardCount;
                DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  this, method:  System.Int32 View.Dialog.RewardTest.RewardTestDialog::<SetRewardCount>b__18_0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  this, method:  System.Void View.Dialog.RewardTest.RewardTestDialog::<SetRewardCount>b__18_1(int v)), endValue:  this + extra, duration:  1f), delay:  1f), ease:  9);
            }
            
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  this._rewardCount + extra);
        }
        private void SetRewardInfo(bool isHint)
        {
            this.ImageCoin.gameObject.SetActive(value:  (~isHint) & 1);
            this.ImageHint.gameObject.SetActive(value:  isHint);
        }
        private void OnDialogShow()
        {
            this.isClaimClicked = false;
            this.AddTodayPlayCount();
        }
        public RewardTestDialog()
        {
            this.triggerType = 3;
        }
        private int <SetRewardCount>b__18_0()
        {
            return (int)this._rewardCount;
        }
        private void <SetRewardCount>b__18_1(int v)
        {
            this.rewardText.text = System.String.Format(format:  "x{0}", arg0:  v);
        }
    
    }

}
