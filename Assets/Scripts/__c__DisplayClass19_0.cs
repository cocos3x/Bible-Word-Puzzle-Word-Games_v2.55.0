using UnityEngine;
private sealed class GameAdManager.<>c__DisplayClass19_0
{
    // Fields
    public string position;
    public Platform.Ad.AdPlacement adPlacement;
    public System.Action callBackOnFail;
    public System.Action callBackOnShow;
    
    // Methods
    public GameAdManager.<>c__DisplayClass19_0()
    {
    
    }
    internal void <ShowRewardAd>b__0(bool isReady)
    {
        Logic.Game.GameDiglog val_12;
        int val_13;
        string val_14;
        val_12 = this;
        object[] val_1 = new object[4];
        val_13 = val_1.Length;
        val_1[0] = this.position;
        if(this.adPlacement.placementID != null)
        {
                val_13 = val_1.Length;
        }
        
        val_1[1] = this.adPlacement.placementID;
        val_1[2] = Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  this.position);
        val_1[3] = isReady;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Try to show position = {0} , placementID = {1}, adShowId = {2}, isReady = {3}", args:  val_1));
        if(isReady != false)
        {
                if(this.callBackOnShow != null)
        {
                this.callBackOnShow.Invoke();
        }
        
            val_14 = this.adPlacement.placementID;
            ADSDKv3.MeeviiAd.Get().Show(placementId:  val_14, positionId:  this.position, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  this.position));
            return;
        }
        
        if(this.callBackOnFail != null)
        {
                this.callBackOnFail.Invoke();
        }
        
        Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "toast_video_load", action:  "show", lable:  this.position);
        val_12 = Logic.Game.GameManager.gameDialog;
        object[] val_9 = new object[1];
        val_14 = Locale.LocaleManager.Translate(key:  "110");
        val_9[0] = val_14;
        View.Dialog.Common.Dialog val_11 = val_12.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_9);
    }

}
