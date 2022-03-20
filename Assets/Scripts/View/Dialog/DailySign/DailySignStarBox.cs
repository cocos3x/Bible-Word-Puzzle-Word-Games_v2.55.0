using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignStarBox : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator AnimatorBox;
        public UnityEngine.Transform TransformBox;
        public UnityEngine.UI.Text TextProgress;
        public UnityEngine.UI.Image ImageFinished;
        public UnityEngine.UI.Text TextReward;
        private int _rewardCount;
        private int _boxIndex;
        
        // Methods
        public void SetBoxInfo(int rewardCount, int progress, bool isOpened, int index)
        {
            this._rewardCount = rewardCount;
            this._boxIndex = index;
            string val_1 = progress.ToString();
            this.AnimatorBox.Play(stateName:  (isOpened != true) ? "GiftLittie_OpenIdle" : "GiftLittie_Idle");
            this.ImageFinished.gameObject.SetActive(value:  isOpened);
            this.TextProgress.gameObject.SetActive(value:  (~isOpened) & 1);
        }
        public void OpenBoxReward()
        {
            string val_1 = this._rewardCount.ToString();
            this.SendEvent();
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "scr_daily_calender", parameterName:  "reward_gain", parameterValue:  this._boxIndex);
            this.AnimatorBox.Play(stateName:  "GiftLittie_Open");
            this.ImageFinished.gameObject.SetActive(value:  true);
            this.TextProgress.gameObject.SetActive(value:  false);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarBox::CollectCoin()));
            Common.TimerEvent.Add(time:  1.6f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarBox::CollectCoin()), isrepeat:  false);
        }
        private void CollectCoin()
        {
            UnityEngine.Vector3 val_2 = this.TransformBox.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Logic.Game.GameManager.gameDialog.Open(name:  "CoinAnimationDialog", type:  1).GainCoin(amount:  this._rewardCount, from:  "daily_sign_box", centerPosition:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, time:  0.5f, delay:  0f, onFinish:  0, count:  0);
        }
        private void SendEvent()
        {
            var val_1 = null;
            int val_1 = this._boxIndex;
            val_1 = val_1 - 1;
            if(val_1 <= 3)
            {
                    var val_2 = 15231128 + ((this._boxIndex - 1)) << 2;
                val_2 = val_2 + 15231128;
            }
            else
            {
                    Platform.Analytics.EzAnalytics.SendCalendarRewardGain(rewardIndex:  new RewardIndexEnum() {});
            }
        
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.DailySign.DailySignStarBox::CollectCoin()));
        }
        public DailySignStarBox()
        {
        
        }
    
    }

}
