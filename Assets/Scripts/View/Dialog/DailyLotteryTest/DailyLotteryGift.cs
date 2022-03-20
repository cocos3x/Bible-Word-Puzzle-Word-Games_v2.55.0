using UnityEngine;

namespace View.Dialog.DailyLotteryTest
{
    public class DailyLotteryGift : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorGift;
        public UnityEngine.UI.Button ButtonVideo;
        public UnityEngine.Animator AnimatorHint;
        public UnityEngine.Animator AnimatorCoin;
        public UnityEngine.CanvasGroup CanvasVideo;
        public UnityEngine.UI.Text TextHint;
        public UnityEngine.UI.Text TextCoin;
        private System.Action _callback;
        private int _rewardCount;
        private bool _isHint;
        private int _giftIndex;
        private bool _isOpened;
        
        // Methods
        public void OnClickVideoButton()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            string val_12;
            var val_13;
            var val_14;
            var val_15;
            string val_16;
            var val_17;
            val_7 = null;
            val_7 = null;
            string val_1 = System.String.Format(format:  "{0}{1}", arg0:  Platform.Ad.GameAdPosition.DailyGiftFormat, arg1:  this._rewardCount);
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            if(this._rewardCount == 20)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = 1152921504829853728;
            }
            else
            {
                    val_13 = null;
                if(this._rewardCount == 80)
            {
                    val_14 = null;
                val_12 = 1152921504829853704;
            }
            else
            {
                    val_15 = null;
                val_12 = 1152921504829853712;
            }
            
            }
            
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameDailyRewardBox}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceDailyReward}, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  Platform.Ad.GameAdPosition.DailyGift), placementType:  new PlacementTypeEnum() {<Value>k__BackingField = BtnClick.PlacementTypeEnum.PlacementTypeReward}, position:  new PositionEnum() {<Value>k__BackingField = val_12});
            if(this._rewardCount == 1)
            {
                    val_16 = "hint";
            }
            else
            {
                    val_16 = this._rewardCount.ToString();
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "daily_reward", action:  "click_btn_video", label:  val_16, value:  0);
            val_17 = null;
            val_17 = null;
            Platform.Ad.RewardPlacement val_5 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
            typeof(Platform.Ad.RewardPlacement).__il2cppRuntimeField_50 = new System.Action<System.String, System.Boolean>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryGift::<OnClickVideoButton>b__12_0(string adTaskID, bool isReward));
            RegisterDefaultLogEvent(adFrom:  val_1);
            RegisterDefaultLogEvent(adFrom:  val_1);
        }
        public void SetGiftIndex(int index)
        {
            this._giftIndex = index;
        }
        public void SetRewardCount(int count, bool isHint = False)
        {
            this._rewardCount = count;
            this._isHint = isHint;
            string val_2 = count.ToString();
            string val_3 = count.ToString();
        }
        public void SetGiftBoxState(bool isOpened, float delay)
        {
            this._isOpened = isOpened;
            if(isOpened != false)
            {
                    this.AnimatorGift.Play(stateName:  "DailyBonusGift_OpenIdle");
                return;
            }
            
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  delay);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryGift::<SetGiftBoxState>b__15_0())), id:  this);
        }
        public void SetGiftBoxInfo(bool isHaveOpened)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            this.CanvasVideo.alpha = 1f;
            UnityEngine.GameObject val_1 = this.ButtonVideo.gameObject;
            if(isHaveOpened == false)
            {
                goto label_3;
            }
            
            var val_2 = (this._isOpened == false) ? 1 : 0;
            if(val_1 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_7 = 0;
            label_4:
            val_1.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.AnimatorHint.gameObject;
            if(isHaveOpened == false)
            {
                goto label_8;
            }
            
            var val_4 = (this._isHint == true) ? 1 : 0;
            if(val_3 != null)
            {
                goto label_9;
            }
            
            label_8:
            val_8 = 0;
            label_9:
            val_3.SetActive(value:  false);
            UnityEngine.GameObject val_5 = this.AnimatorCoin.gameObject;
            if(isHaveOpened == false)
            {
                goto label_13;
            }
            
            var val_6 = (this._isHint == false) ? 1 : 0;
            if(val_5 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_9 = 0;
            label_14:
            val_5.SetActive(value:  false);
            if(isHaveOpened == false)
            {
                    return;
            }
            
            if(this._isOpened != false)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game_ad_reward", action:  "ad_enter_show", label:  Platform.Ad.GameAdPosition.DailyReward, value:  0);
        }
        public void OpenGift()
        {
            Platform.Analytics.EzAnalytics.DailyRewardFirstTime();
            this.PlayOpenGiftAni(isPlayTextAni:  true);
        }
        private void GiftRewardVideoCallback(int index)
        {
            if(this._giftIndex != index)
            {
                    return;
            }
            
            this.PlayOpenGiftAni(isPlayTextAni:  false);
        }
        private void PlayOpenGiftAni(bool isPlayTextAni = False)
        {
            int val_15;
            var val_16;
            string val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            object val_1 = new System.Object();
            typeof(DailyLotteryGift.<>c__DisplayClass19_0).__il2cppRuntimeField_10 = this;
            typeof(DailyLotteryGift.<>c__DisplayClass19_0).__il2cppRuntimeField_18 = isPlayTextAni;
            this._isOpened = true;
            this.ButtonVideo.gameObject.SetActive(value:  false);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_dr_chest_open", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            this.AnimatorGift.Play(stateName:  "DailyBonusGift_Open");
            Message.Messager.Dispatch<System.Int32>(cmd:  88, t:  this._giftIndex);
            if(this._isHint != false)
            {
                    val_15 = this._rewardCount;
            }
            else
            {
                    val_15 = this;
                Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  this._rewardCount);
            }
            
            if(this._rewardCount == 20)
            {
                    val_16 = null;
                val_16 = null;
                val_17 = 1152921504829693992;
            }
            else
            {
                    val_18 = null;
                if(this._rewardCount == 80)
            {
                    val_19 = null;
                val_17 = 1152921504829694152;
            }
            else
            {
                    val_20 = null;
                val_17 = 1152921504829694000;
            }
            
            }
            
            val_21 = null;
            val_21 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = val_17}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceDrDlg});
            int val_6 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            if((typeof(DailyLotteryGift.<>c__DisplayClass19_0).__il2cppRuntimeField_18) != false)
            {
                    DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_7, interval:  0.5f);
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DailyLotteryGift.<>c__DisplayClass19_0::<PlayOpenGiftAni>b__0()));
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_7, interval:  0.75f);
            }
            
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DailyLotteryGift.<>c__DisplayClass19_0::<PlayOpenGiftAni>b__1())), id:  this);
        }
        private void ShowDailyLotteryVideoButton(bool isAni)
        {
            this.ButtonVideo.gameObject.SetActive(value:  (this._isOpened == false) ? 1 : 0);
            if(this._isOpened != false)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasVideo, endValue:  1f, duration:  0.67f);
            if(this._isHint == false)
            {
                goto label_4;
            }
            
            if(this.AnimatorHint.gameObject.activeSelf != true)
            {
                    this.AnimatorHint.gameObject.SetActive(value:  true);
                this.AnimatorHint.Play(stateName:  "DailyBonusUI_Show");
            }
            
            if(this.AnimatorCoin != null)
            {
                goto label_11;
            }
            
            label_4:
            if(this.AnimatorCoin.gameObject.activeSelf != true)
            {
                    this.AnimatorCoin.gameObject.SetActive(value:  true);
                this.AnimatorCoin.Play(stateName:  "DailyBonusUI_Show");
            }
            
            label_11:
            this.AnimatorHint.gameObject.SetActive(value:  false);
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Boolean>(cmd:  89, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryGift::ShowDailyLotteryVideoButton(bool isAni)));
            Message.Messager.Add<System.Int32>(cmd:  90, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryGift::GiftRewardVideoCallback(int index)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Boolean>(cmd:  89, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryGift::ShowDailyLotteryVideoButton(bool isAni)));
            Message.Messager.Remove<System.Int32>(cmd:  90, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailyLotteryTest.DailyLotteryGift::GiftRewardVideoCallback(int index)));
        }
        public DailyLotteryGift()
        {
        
        }
        private void <OnClickVideoButton>b__12_0(string adTaskID, bool isReward)
        {
            if(isReward == false)
            {
                    return;
            }
            
            Message.Messager.Dispatch<System.Int32>(cmd:  90, t:  this._giftIndex);
        }
        private void <SetGiftBoxState>b__15_0()
        {
            this.AnimatorGift.Play(stateName:  "DailyBonusGift_Idle");
        }
    
    }

}
