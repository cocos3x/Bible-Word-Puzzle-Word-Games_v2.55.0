using UnityEngine;

namespace Platform.Ad
{
    public class RewardPlacement : AdPlacement
    {
        // Fields
        public System.Action<string, bool> onAdRewarded;
        private bool isReward;
        
        // Methods
        public RewardPlacement(string placementID)
        {
            mem[1152921513123934776] = "reward";
        }
        public override void OnADLoaded(string platform)
        {
            this.OnADLoaded(platform:  platform);
        }
        public override void OnRewardedVideoCompleted(string platform)
        {
            this.isReward = true;
        }
        public override void OnADClose(string platform)
        {
            var val_3;
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStart();
            if(this.onAdRewarded != null)
            {
                    this.onAdRewarded.Invoke(arg1:  0, arg2:  this.isReward);
            }
            
            this.OnADClose(platform:  platform);
            Logic.Game.GameManager.gameMusic.Pause(pause:  false);
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "[adui] placement = "("[adui] placement = ") + 0 + " OnAdClosed finished!"(" OnAdClosed finished!"), prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public override void OnADShow(string platform)
        {
            var val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "[adui] placement = "("[adui] placement = ") + platform + " OnAdShow!"(" OnAdShow!"), prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingPause();
            Logic.Game.GameManager.gameMusic.Pause(pause:  true);
            this.OnADShow(platform:  platform);
            Common.Singleton<Data.Reward.RewardDataManager>.Instance.AddRewardVideoCount();
            if((Common.Singleton<Data.Reward.RewardDataManager>.Instance.RewardVideoCount) != 56)
            {
                    return;
            }
            
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.IsIn7Day()) == false)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_rewarded_ads", eventValues:  0, platform:  2);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "marketing_user_rewarded_ads", eventValues:  0, platform:  1);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "marketing_user", action:  "rewarded_ads_user", label:  "", value:  0);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_rewarded_ads_user", eventValues:  0, platform:  2);
            Platform.Analytics.EzAnalytics.LogEvent(eventName:  "grt_retention_rewarded_ads_user", eventValues:  0, platform:  1);
            Platform.Analytics.EzAnalytics.LogEvent(category:  "grt_retention", action:  "rewarded_ads_user", label:  "", value:  0);
        }
        public void RegisterDefaultLogEvent(string adFrom)
        {
            Platform.Ad.ADPlacementLogProcessor val_2 = this.RegisterLogEvent(category:  "game_ad_reward").AddLogEvent(adEventType:  7, action:  "a1_show_from", lable:  adFrom);
        }
        public override void ShowAD(string position, System.Action callBackOnShow, System.Action callBackOnFail)
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "[adui] ShowAD type = reward, id = "("[adui] ShowAD type = reward, id = ") + position, prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.ShowAD(position:  position, callBackOnShow:  callBackOnShow, callBackOnFail:  callBackOnFail);
            6936.ShowRewardAd(adPlacement:  this, position:  position, callBackOnShow:  callBackOnShow, callBackOnFail:  callBackOnFail);
        }
    
    }

}
