using UnityEngine;

namespace Platform.Ad
{
    public class GameAdManager
    {
        // Fields
        private static Platform.Ad.GameAdManager <Instance>k__BackingField;
        private bool _isShowBannering;
        
        // Properties
        public static Platform.Ad.GameAdManager Instance { get; set; }
        
        // Methods
        public static Platform.Ad.GameAdManager get_Instance()
        {
            return (Platform.Ad.GameAdManager)Platform.Ad.GameAdManager.<Instance>k__BackingField;
        }
        private static void set_Instance(Platform.Ad.GameAdManager value)
        {
            Platform.Ad.GameAdManager.<Instance>k__BackingField = value;
        }
        public static void Create(bool isDebug, bool isDebugConfig)
        {
            Platform.Ad.GameAdManager val_4;
            object val_1 = null;
            if((Platform.Ad.GameAdManager.<Instance>k__BackingField) == null)
            {
                    val_4 = val_1;
                val_1 = new System.Object();
                Platform.Ad.GameAdManager.<Instance>k__BackingField = val_4;
            }
            
            Init(isDebug:  isDebug, isDebugConfig:  isDebugConfig);
        }
        private void Init(bool isDebug, bool isDebugConfig)
        {
            var val_22;
            var val_23;
            bool val_23 = isDebugConfig;
            bool val_22 = isDebug;
            val_22 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_22 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_22 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_22 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "GameAdManager init start", prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Platform.Analytics.AfData val_1 = Platform.Analytics.EzAnalytics.<Instance>k__BackingField.GetAfData();
            ADSDKv3.MeeviiAdSettings val_2 = new ADSDKv3.MeeviiAdSettings();
            val_22 = val_22 & val_23;
            val_23 = val_22;
            System.DateTime val_17 = Common.Singleton<Data.Login.LoginDataManager>.Instance.GetUserInstallTime();
            ADSDKv3.MeeviiAd.Get().Init(settings:  SetProductionId(productionId:  Platform.PlatformDefine.<ProductionId>k__BackingField).SetAppStoreUrl(appStoreUrl:  "", appStoreId:  "").SetDebug(isDebug:  val_23).SetShowLog(isShowLog:  val_23).SetTestMode(isTestMode:  val_22).SetEventListener(eventListener:  new Platform.Ad.AdAnalyzeListener()).SetLuid(value:  Platform.Luid.GameLuidManager.<Luid>k__BackingField).SetInitListener(initListener:  new Platform.Ad.AdInitListener(onSuccess:  new System.Action(object:  this, method:  System.Void Platform.Ad.GameAdManager::OnInitSuccess()), onError:  0)).SetCampaignId(campaignId:  val_1.CampaignId).SetInstallTime(installTime:  new System.DateTime() {dateData = val_17.dateData}).SetMediaSource(mediaSource:  val_1.MediaSource));
            Platform.Analytics.EzAnalytics.<Instance>k__BackingField.GetAfDataAsync(callback:  new System.Action<Platform.Analytics.AfData>(object:  this, method:  System.Void Platform.Ad.GameAdManager::GetAfDataCallback(Platform.Analytics.AfData afData)));
            val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "GameAdManager init end", prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void GetAfDataCallback(Platform.Analytics.AfData afData)
        {
            ADSDKv3.MeeviiAd.Get().RequestForCampaign(mediaSource:  afData.MediaSource, campaignId:  afData.CampaignId, afStatus:  afData.AfStatus);
        }
        private void OnInitSuccess()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "[AdManager.OnInitSuccess] Succeed!", prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            InitBanner();
            InitInter();
            InitReward();
        }
        private void InitBanner()
        {
            var val_7;
            ADSDKv3.MeeviiAd.Get().SetBannerSize(placementId:  Platform.Ad.GameAdID.BannerID, bannerSize:  60);
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) != false)
            {
                    return;
            }
            
            ADSDKv3.MeeviiAd.Get().Load(placementId:  Platform.Ad.GameAdID.BannerID);
            Platform.Ad.BannerPlacement val_5 = new Platform.Ad.BannerPlacement(placementID:  Platform.Ad.GameAdID.BannerID);
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "Load Banner Ad:"("Load Banner Ad:") + Platform.Ad.GameAdID.BannerID, prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void InitInter()
        {
            var val_4;
            ADSDKv3.MeeviiAd.Get().Load(placementId:  Platform.Ad.GameAdID.InterstitalLevelPassID);
            Platform.Ad.InterstitialPlacement val_2 = new Platform.Ad.InterstitialPlacement(placementID:  Platform.Ad.GameAdID.InterstitalLevelPassID);
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "Load Interstital Ad:"("Load Interstital Ad:") + Platform.Ad.GameAdID.InterstitalLevelPassID, prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void InitReward()
        {
            var val_4;
            ADSDKv3.MeeviiAd.Get().Load(placementId:  Platform.Ad.GameAdID.RewardID);
            Platform.Ad.RewardPlacement val_2 = new Platform.Ad.RewardPlacement(placementID:  Platform.Ad.GameAdID.RewardID);
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  "Load Reward Ad:"("Load Reward Ad:") + Platform.Ad.GameAdID.RewardID, prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void ShowBannerAd(Platform.Ad.AdPlacement adPlacement)
        {
            this._isShowBannering = true;
            ADSDKv3.MeeviiAd.Get().ShowBannerAD(placementId:  adPlacement.placementID, positionId:  adPlacement.placementID, position:  0, offset:  0, relativeSafeArea:  false);
        }
        public void HideBannerAd()
        {
            if(this._isShowBannering == false)
            {
                    return;
            }
            
            this._isShowBannering = false;
            ADSDKv3.MeeviiAd.Get().HideBanner(placementId:  Platform.Ad.GameAdID.BannerID);
        }
        public void ShowInterAd(Platform.Ad.AdPlacement adPlacement, string position, System.Action callBackOnShow, System.Action callBackOnFail)
        {
            typeof(GameAdManager.<>c__DisplayClass18_0).__il2cppRuntimeField_10 = position;
            typeof(GameAdManager.<>c__DisplayClass18_0).__il2cppRuntimeField_18 = adPlacement;
            typeof(GameAdManager.<>c__DisplayClass18_0).__il2cppRuntimeField_20 = callBackOnFail;
            typeof(GameAdManager.<>c__DisplayClass18_0).__il2cppRuntimeField_28 = callBackOnShow;
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "ad_inter_timing", action:  "position", lable:  position);
            ADSDKv3.MeeviiAd.Get().IsReady(placementId:  adPlacement + 16, positionId:  typeof(GameAdManager.<>c__DisplayClass18_0).__il2cppRuntimeField_10, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  typeof(GameAdManager.<>c__DisplayClass18_0).__il2cppRuntimeField_10), validCallback:  new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GameAdManager.<>c__DisplayClass18_0::<ShowInterAd>b__0(bool isReady)));
        }
        public void ShowRewardAd(Platform.Ad.AdPlacement adPlacement, string position, System.Action callBackOnShow, System.Action callBackOnFail)
        {
            typeof(GameAdManager.<>c__DisplayClass19_0).__il2cppRuntimeField_10 = position;
            typeof(GameAdManager.<>c__DisplayClass19_0).__il2cppRuntimeField_18 = adPlacement;
            typeof(GameAdManager.<>c__DisplayClass19_0).__il2cppRuntimeField_20 = callBackOnFail;
            typeof(GameAdManager.<>c__DisplayClass19_0).__il2cppRuntimeField_28 = callBackOnShow;
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  "ad_reward_timing", action:  "position", lable:  position);
            ADSDKv3.MeeviiAd.Get().IsReady(placementId:  adPlacement + 16, positionId:  typeof(GameAdManager.<>c__DisplayClass19_0).__il2cppRuntimeField_10, adShowId:  Common.Singleton<Platform.Ad.AdShowId>.Instance.GetAdShowId(position:  typeof(GameAdManager.<>c__DisplayClass19_0).__il2cppRuntimeField_10), validCallback:  new System.Action<System.Boolean>(object:  new System.Object(), method:  System.Void GameAdManager.<>c__DisplayClass19_0::<ShowRewardAd>b__0(bool isReady)));
        }
        public string CreateAdShowId()
        {
            return ADSDKv3.MeeviiAd.Get().CreateAdShowId();
        }
        public GameAdManager()
        {
        
        }
    
    }

}
