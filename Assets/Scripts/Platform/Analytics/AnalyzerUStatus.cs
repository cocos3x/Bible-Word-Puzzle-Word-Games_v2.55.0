using UnityEngine;

namespace Platform.Analytics
{
    public static class AnalyzerUStatus
    {
        // Methods
        public static void InstallDays(int days)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "days", label:  days.ToString(), value:  0);
        }
        public static void OpenDays(int days)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "openDays", label:  days.ToString(), value:  0);
        }
        public static void CurrentLevel(int chapter, int index)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "currentLevel", label:  System.String.Format(format:  "{0}_{1}", arg0:  chapter, arg1:  index), value:  0);
        }
        public static void CurrentCurrency(int count)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "currentRubies", label:  count.ToString(), value:  0);
        }
        public static void Purchased(bool value)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "purchased", label:  (value != true) ? "yes" : "no", value:  0);
        }
        public static void RemoveAds(bool value)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "noads", label:  (value != true) ? "yes" : "no", value:  0);
        }
        public static void PhoneInfo(string info)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "u_states", action:  "phone", label:  info, value:  0);
        }
    
    }

}
