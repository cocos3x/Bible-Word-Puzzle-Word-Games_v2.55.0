using UnityEngine;

namespace Platform.Ad
{
    public class AdPlacement : IADListener
    {
        // Fields
        public string placementID;
        public string adType;
        protected Platform.Ad.ADPlacementLogProcessor placementLog;
        public System.Action<string> onADClick;
        public System.Action<string> onADClose;
        public System.Action<string> onAdLoad;
        public System.Action onAdLoadFailed;
        public System.Action<string> onAdShow;
        
        // Methods
        protected AdPlacement(string placementID)
        {
            this.placementID = "";
            this.adType = "";
            this.placementID = placementID;
            ADSDKv3.MeeviiAd.Get().SetADListener(placementId:  this.placementID, listener:  this);
        }
        protected void SetADType(string adType)
        {
            this.adType = adType;
        }
        public Platform.Ad.ADPlacementLogProcessor RegisterLogEvent(string category)
        {
            Platform.Ad.ADPlacementLogProcessor val_3;
            Platform.Ad.ADPlacementLogProcessor val_4 = this.placementLog;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            Platform.Ad.ADPlacementLogProcessor val_1 = null;
            val_3 = val_1;
            val_1 = new Platform.Ad.ADPlacementLogProcessor(adPlacementId:  this.placementID, adType:  this.adType, category:  category);
            this.placementLog = val_3;
            Platform.Ad.ADPlacementLogProcessor val_2 = AddDefaultLogEvent();
            val_4 = this.placementLog;
            return val_4;
        }
        public override void OnADClick(string platform)
        {
            if(this.placementLog != null)
            {
                    this.placementLog.OnEvent(adEventType:  4, adTaskID:  this.placementID);
            }
            
            if(this.onADClick == null)
            {
                    return;
            }
            
            this.onADClick.Invoke(obj:  this.placementID);
        }
        public override void OnADClose(string platform)
        {
            if(this.placementLog != null)
            {
                    this.placementLog.OnEvent(adEventType:  5, adTaskID:  this.placementID);
            }
            
            if(this.onADClose == null)
            {
                    return;
            }
            
            this.onADClose.Invoke(obj:  this.placementID);
        }
        public override void OnADLoaded(string platform)
        {
            if(this.placementLog != null)
            {
                    this.placementLog.OnEvent(adEventType:  2, adTaskID:  this.placementID);
            }
            
            if(this.onAdLoad == null)
            {
                    return;
            }
            
            this.onAdLoad.Invoke(obj:  this.placementID);
        }
        public override void OnError(string platform, ADSDKv3.Common.AdError adError)
        {
            if(this.placementLog != null)
            {
                    this.placementLog.OnEvent(adEventType:  3, adTaskID:  "");
            }
            
            if(this.onAdLoadFailed == null)
            {
                    return;
            }
            
            this.onAdLoadFailed.Invoke();
        }
        public override void OnADShow(string platform)
        {
            if(this.placementLog != null)
            {
                    this.placementLog.OnEvent(adEventType:  7, adTaskID:  this.placementID);
            }
            
            if(this.onAdShow == null)
            {
                    return;
            }
            
            this.onAdShow.Invoke(obj:  this.placementID);
        }
        public virtual void ShowAD(string position, System.Action callBackOnShow, System.Action callBackOnFail)
        {
            int val_3;
            var val_4;
            string[] val_1 = new string[6];
            val_3 = val_1.Length;
            val_1[0] = "[adui] ShowAD type = ";
            if(this.adType != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[1] = this.adType;
            val_3 = val_1.Length;
            val_1[2] = ", id = ";
            if(this.placementID != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[3] = this.placementID;
            val_3 = val_1.Length;
            val_1[4] = " , position = ";
            if(position != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[5] = position;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  +val_1, prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(this.placementLog == null)
            {
                    return;
            }
            
            this.placementLog.OnEvent(adEventType:  1, adTaskID:  "");
        }
    
    }

}
