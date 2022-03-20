using UnityEngine;
private sealed class GameAdManager.<>c__DisplayClass18_0
{
    // Fields
    public string position;
    public Platform.Ad.AdPlacement adPlacement;
    public System.Action callBackOnFail;
    public System.Action callBackOnShow;
    
    // Methods
    public GameAdManager.<>c__DisplayClass18_0()
    {
    
    }
    internal void <ShowInterAd>b__0(bool isReady)
    {
        int val_9;
        object val_10;
        object[] val_1 = new object[4];
        val_9 = val_1.Length;
        val_1[0] = this.position;
        if(this.adPlacement.placementID != null)
        {
                val_9 = val_1.Length;
        }
        
        val_1[1] = this.adPlacement.placementID;
        val_1[2] = Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  this.position);
        val_1[3] = isReady;
        val_10 = System.String.Format(format:  "Try to show position = {0} , placementID = {1}, adShowId = {2} , isReady = {3}", args:  val_1);
        UnityEngine.Debug.Log(message:  val_10);
        if(isReady != false)
        {
                if(this.callBackOnShow != null)
        {
                this.callBackOnShow.Invoke();
        }
        
            val_10 = this.adPlacement.placementID;
            ADSDKv3.MeeviiAd.Get().Show(placementId:  val_10, positionId:  this.position, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  this.position));
            return;
        }
        
        if(this.callBackOnFail == null)
        {
                return;
        }
        
        this.callBackOnFail.Invoke();
    }

}
