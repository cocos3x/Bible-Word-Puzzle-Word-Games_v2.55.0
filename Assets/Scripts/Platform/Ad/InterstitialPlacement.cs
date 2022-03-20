using UnityEngine;

namespace Platform.Ad
{
    public class InterstitialPlacement : AdPlacement
    {
        // Methods
        public InterstitialPlacement(string placementID)
        {
            mem[1152921513123412840] = "interstitial";
        }
        public override void OnADClose(string platform)
        {
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingStart();
            this.OnADClose(platform:  0);
            Logic.Game.GameManager.gameMusic.Pause(pause:  false);
        }
        public override void OnADShow(string platform)
        {
            var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "[adui] placement = "("[adui] placement = ") + platform + " OnAdShow!"(" OnAdShow!"), prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Common.Singleton<View.Game.LevelPassTime>.Instance.TimingPause();
            Logic.Game.GameManager.gameMusic.Pause(pause:  true);
            this.OnADShow(platform:  1);
        }
        public override void ShowAD(string position, System.Action callBackOnShow, System.Action callBackOnFail)
        {
            this.ShowAD(position:  position, callBackOnShow:  callBackOnShow, callBackOnFail:  callBackOnFail);
            6936.ShowInterAd(adPlacement:  this, position:  position, callBackOnShow:  callBackOnShow, callBackOnFail:  callBackOnFail);
        }
    
    }

}
