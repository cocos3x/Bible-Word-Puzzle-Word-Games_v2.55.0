using UnityEngine;

namespace Platform.Ad
{
    public class BannerPlacement : AdPlacement
    {
        // Methods
        public BannerPlacement(string placementID)
        {
            mem[1152921513119818760] = "banner";
        }
        public override void OnADClick(string platform)
        {
            this.OnADClick(platform:  platform);
        }
        public override void OnADClose(string platform)
        {
            this.OnADClose(platform:  platform);
        }
        public override void ShowAD(string position, System.Action callBackOnShow, System.Action callBackOnFail)
        {
            if((Common.Singleton<Data.Shop.ShopDataManager>.Instance.IsBuyItem) != false)
            {
                    return;
            }
            
            this.ShowAD(position:  position, callBackOnShow:  callBackOnShow, callBackOnFail:  callBackOnFail);
            Platform.Ad.GameAdManager.<Instance>k__BackingField.ShowBannerAd(adPlacement:  this);
        }
    
    }

}
