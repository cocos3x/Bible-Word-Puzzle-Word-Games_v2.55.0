using UnityEngine;

namespace Platform.Ad
{
    public class ADPlacementLogProcessor
    {
        // Fields
        private string mAdPlacementId;
        private string mAdType;
        private string mCategory;
        private bool hasAddDefaultLog;
        private System.Collections.Generic.Dictionary<Platform.Ad.ADLogEventType, System.Collections.Generic.List<Platform.Ad.ADPlacementLogEvent>> logEvents;
        
        // Methods
        public ADPlacementLogProcessor(string adPlacementId, string adType, string category)
        {
            this.mAdPlacementId = "";
            this.mAdType = "";
            this.mCategory = "";
            this.logEvents = new System.Collections.Generic.Dictionary<Platform.Ad.ADLogEventType, System.Collections.Generic.List<Platform.Ad.ADPlacementLogEvent>>();
            val_2 = new System.Object();
            this.mAdPlacementId = adPlacementId;
            this.mAdType = val_2;
            this.mCategory = category;
        }
        public string GetShortID(string adTaskID)
        {
            if(adTaskID != null)
            {
                    if()
            {
                    return (string)adTaskID;
            }
            
                return adTaskID.Substring(startIndex:  adTaskID.m_stringLength - 4);
            }
            
            throw new NullReferenceException();
        }
        public Platform.Ad.ADPlacementLogProcessor AddLogEvent(Platform.Ad.ADLogEventType adEventType, string action, string lable)
        {
            return this.AddLogEvent(adEventType:  adEventType, logEvent:  new Platform.Ad.ADPlacementLogEvent(category:  this.mCategory, action:  action, lable:  lable));
        }
        public Platform.Ad.ADPlacementLogProcessor AddLogEvent(Platform.Ad.ADLogEventType adEventType, Platform.Ad.ADPlacementLogEvent logEvent)
        {
            System.Collections.Generic.List<Platform.Ad.ADPlacementLogEvent> val_1 = 0;
            bool val_2 = this.logEvents.TryGetValue(key:  adEventType, value: out  val_1);
            if(val_1 == 0)
            {
                    this.logEvents.Add(key:  adEventType, value:  new System.Collections.Generic.List<Platform.Ad.ADPlacementLogEvent>());
            }
            
            Add(item:  logEvent);
            return (Platform.Ad.ADPlacementLogProcessor)this;
        }
        public Platform.Ad.ADPlacementLogProcessor AddDefaultLogEvent()
        {
            if(this.hasAddDefaultLog == true)
            {
                    return (Platform.Ad.ADPlacementLogProcessor)this;
            }
            
            this.hasAddDefaultLog = true;
            Platform.Ad.ADPlacementLogProcessor val_4 = this.AddLogEvent(adEventType:  7, logEvent:  new Platform.Ad.ADPlacementLogEvent(category:  ((System.String.IsNullOrEmpty(value:  this.mCategory)) != true) ? "%p_ad_%t" : this.mCategory, action:  "a1_ad_show", lable:  "%s"));
            return (Platform.Ad.ADPlacementLogProcessor)this;
        }
        public void OnEvent(Platform.Ad.ADLogEventType adEventType, string adTaskID)
        {
            string val_9;
            if((this.logEvents.ContainsKey(key:  adEventType)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = this.logEvents.Item[adEventType].GetEnumerator();
            label_8:
            if(0.MoveNext() == false)
            {
                goto label_5;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_9 = 11993091;
            if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    val_9 = 11993091;
            }
            
            Platform.Ad.ADPlacementLogProcessor.SendLog(category:  this.getEventString(str:  val_9, adTaskID:  adTaskID), action:  this.getEventString(str:  4960416, adTaskID:  adTaskID), lable:  this.getEventString(str:  64, adTaskID:  adTaskID));
            goto label_8;
            label_5:
            0.Dispose();
        }
        public static void SendLog(string category, string action, string lable)
        {
            int val_3;
            var val_4;
            string[] val_1 = new string[6];
            val_3 = val_1.Length;
            val_1[0] = "[send_log] category=";
            if(category != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[1] = category;
            val_3 = val_1.Length;
            val_1[2] = ",action=";
            if(action != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[3] = action;
            val_3 = val_1.Length;
            val_1[4] = ", lable=";
            if(lable != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[5] = lable;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            ADSDKv3.Common.AdLog.Log(content:  +val_1, prs:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Platform.Analytics.EzAnalytics.LogEvent(category:  category, action:  action, label:  lable, value:  0);
        }
        private string getEventString(string str, string adTaskID)
        {
            string val_5 = str;
            if(((val_5.IndexOf(value:  "%p")) & 2147483648) == 0)
            {
                    val_5 = val_5.Replace(oldValue:  "%p", newValue:  this.mAdPlacementId);
            }
            
            int val_3 = val_5.IndexOf(value:  "%s");
            if((val_3 & 2147483648) != 0)
            {
                    return (string)val_5;
            }
            
            return val_5.Replace(oldValue:  "%s", newValue:  val_3.GetShortID(adTaskID:  adTaskID));
        }
    
    }

}
