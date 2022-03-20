using UnityEngine;

namespace Utils.Extensions
{
    public static class DateTimeExtension
    {
        // Methods
        public static bool IsSameDay(System.DateTime curDateTime, System.DateTime dateTime)
        {
            var val_8;
            if(curDateTime.dateData.Day == dateTime.dateData.Day)
            {
                    if(curDateTime.dateData.Month == dateTime.dateData.Month)
            {
                    var val_7 = (curDateTime.dateData.Year == dateTime.dateData.Year) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
    
    }

}
