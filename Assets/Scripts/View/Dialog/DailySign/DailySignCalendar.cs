using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignCalendar : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TextMonth;
        public View.Dialog.DailySign.DailySignDays DailySignDaysPrefab;
        public UnityEngine.Transform TransformDays;
        private UnityEngine.UI.Text[] textWeeks;
        private System.Collections.Generic.List<View.Dialog.DailySign.DailySignDays> days;
        private View.Dialog.DailySign.DailySignDays _tempDay;
        
        // Methods
        public void LocaleTranslate()
        {
            var val_3;
            var val_4;
            val_3 = this;
            if(this.textWeeks.Length == 7)
            {
                    if(this.textWeeks.Length < 1)
            {
                    return;
            }
            
                var val_5 = 0;
                do
            {
                UnityEngine.UI.Text val_4 = this.textWeeks[val_5];
                var val_1 = val_5 + 162;
                string val_3 = Locale.LocaleManager.Translate(key:  val_1.ToString());
                val_5 = val_1 - 161;
            }
            while(val_5 < this.textWeeks.Length);
            
                return;
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Log.D.Error(message:  "DailySignCalendar LocaleTranslate 数据不匹配...", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void UpdateCalendarInfos()
        {
            var val_24;
            int val_25;
            var val_26;
            this.ClearDays();
            System.DateTime val_1 = System.DateTime.Now;
            Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            int val_24 = val_2.<CurrentMonth>k__BackingField;
            val_24 = val_24 + 168;
            string val_4 = Locale.LocaleManager.Translate(key:  val_24.ToString());
            var val_25 = 1;
            val_25 = val_25 - val_1.dateData.Day;
            System.DateTime val_6 = val_1.dateData.AddDays(value:  (double)val_25);
            int val_26 = System.Convert.ToInt32(value:  val_6.dateData.DayOfWeek.ToString(format:  "d"));
            val_24 = 1;
            System.DateTime val_10 = val_6.dateData.AddMonths(months:  1);
            System.DateTime val_11 = val_10.dateData.AddDays(value:  -1);
            var val_12 = (val_26 == 7) ? 0 : (val_26);
            int val_14 = val_11.dateData.Day + val_12;
            if(val_14 >= 1)
            {
                    var val_27 = 0;
                do
            {
                if(val_27 < val_12)
            {
                    this._tempDay = View.Dialog.DailySign.DailySignDays.Create(parent:  this.TransformDays, prefab:  this.DailySignDaysPrefab, day:  0);
                val_25 = 0;
                val_26 = 0;
            }
            else
            {
                    val_26 = (val_24 - val_12) + val_27;
                View.Dialog.DailySign.DailySignDays val_17 = View.Dialog.DailySign.DailySignDays.Create(parent:  this.TransformDays, prefab:  this.DailySignDaysPrefab, day:  val_26);
                this._tempDay = val_17;
                val_24 = val_17;
                val_25 = val_26;
            }
            
                val_24.SetDayInfos(day:  val_25, isEnable:  (val_26 <= (Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.SignToday)) ? 1 : 0);
                this.days.Add(item:  this._tempDay);
                val_27 = val_27 + 1;
            }
            while(val_27 < val_14);
            
            }
            
            System.DateTime val_21 = System.DateTime.Now;
            string val_23 = val_21.dateData.ToString(format:  "MMMM", provider:  System.Globalization.CultureInfo.CreateSpecificCulture(name:  "en-GB"));
        }
        private void ClearDays()
        {
            if(this.days < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            if(val_2 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            View.Dialog.DailySign.DailySignDays val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.Dialog.DailySign.DailySignDays>(obj:  (public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 0) + 32, isUi:  true);
            val_2 = val_2 + 1;
            this.days.Clear();
        }
        private void OnEnable()
        {
            this.UpdateCalendarInfos();
        }
        public DailySignCalendar()
        {
            this.days = new System.Collections.Generic.List<View.Dialog.DailySign.DailySignDays>();
        }
    
    }

}
