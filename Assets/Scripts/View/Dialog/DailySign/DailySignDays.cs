using UnityEngine;

namespace View.Dialog.DailySign
{
    public class DailySignDays : RecyclableItem
    {
        // Fields
        public UnityEngine.UI.Button ButtonDay;
        public UnityEngine.Transform TransformContent;
        public UnityEngine.UI.Image ImageCurrent;
        public TMPro.TextMeshProUGUI TextDay;
        public UnityEngine.Transform TransformStars;
        public View.Dialog.DailySign.DailySignDayStars[] Stars;
        private int _day;
        private bool _isEnable;
        private readonly UnityEngine.Color NormalColor;
        private readonly UnityEngine.Color GrayColor;
        
        // Methods
        public static View.Dialog.DailySign.DailySignDays Create(UnityEngine.Transform parent, View.Dialog.DailySign.DailySignDays prefab, int day)
        {
            int val_5 = day;
            View.Dialog.DailySign.DailySignDays val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.Dialog.DailySign.DailySignDays>(prefab:  prefab, bufferSize:  10);
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_5 = val_5 & (~(val_5 >> 31));
            val_1.name = prefab.name + "_" + val_5;
            return val_1;
        }
        public void OnClickDayButton()
        {
            var val_6;
            var val_7;
            if(this._day < 1)
            {
                    return;
            }
            
            Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if((val_1.<DailySignIsCanOperate>k__BackingField) == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            Platform.Analytics.EzAnalytics.SendBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = BtnClick.BtnNameEnum.BtnNameOtherDayBtn}, source:  new SourceEnum() {<Value>k__BackingField = BtnClick.SourceEnum.SourceDccScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "scr_daily_calender", action:  "other_day", label:  "click", value:  0);
            if(this._isEnable != false)
            {
                    Data.DailyRecord.DailyRecordDataManager val_2 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
                val_2.<CurrentDailyDay>k__BackingField = this._day;
                Message.Messager.Dispatch<System.Int32>(cmd:  93, t:  this._day);
                return;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = Locale.LocaleManager.Translate(key:  "95");
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ToastDialog", type:  1, pars:  val_3);
        }
        public void SetDayInfos(int day, bool isEnable = False)
        {
            var val_12;
            this._day = day;
            this.ImageCurrent.gameObject.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.TransformContent.gameObject;
            if((day & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_2.SetActive(value:  true);
            this.ButtonDay.enabled = true;
            if(isEnable == false)
            {
                goto label_7;
            }
            
            val_12 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.GetCurrentDailyLevelIndex(day:  day);
            goto label_9;
            label_5:
            val_2.SetActive(value:  false);
            this.ButtonDay.enabled = false;
            return;
            label_7:
            val_12 = 0;
            label_9:
            this._isEnable = isEnable;
            this.TextDay.text = day.ToString();
            this.TransformStars.gameObject.SetActive(value:  isEnable & (~0));
            var val_13 = 0;
            label_18:
            if(val_13 >= this.Stars.Length)
            {
                goto label_15;
            }
            
            this.Stars[val_13].SetStarState(isLight:  (val_13 < val_12) ? 1 : 0);
            val_13 = val_13 + 1;
            if(this.Stars != null)
            {
                goto label_18;
            }
            
            throw new NullReferenceException();
            label_15:
            Data.DailyRecord.DailyRecordDataManager val_11 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            this.SelectSignDay(day:  val_11.<CurrentDailyDay>k__BackingField);
        }
        private void SelectSignDay(int day)
        {
            if((this._day & 2147483648) != 0)
            {
                    return;
            }
            
            this.ImageCurrent.gameObject.SetActive(value:  (this._day == day) ? 1 : 0);
            if(this._day != day)
            {
                goto label_3;
            }
            
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            label_7:
            this.TextDay.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            return;
            label_3:
            if(this._isEnable == false)
            {
                goto label_5;
            }
            
            if(this.TextDay != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_5:
            if(this.TextDay != null)
            {
                goto label_7;
            }
        
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Int32>(cmd:  93, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDays::SelectSignDay(int day)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Int32>(cmd:  93, action:  new System.Action<System.Int32>(object:  this, method:  System.Void View.Dialog.DailySign.DailySignDays::SelectSignDay(int day)));
        }
        public DailySignDays()
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  0.2666667f, g:  0.2666667f, b:  0.2666667f, a:  1f);
            UnityEngine.Color val_2;
            this.NormalColor = val_1.r;
            val_2 = new UnityEngine.Color(r:  0.6666667f, g:  0.6666667f, b:  0.6666667f, a:  1f);
            this.GrayColor = val_2.r;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
