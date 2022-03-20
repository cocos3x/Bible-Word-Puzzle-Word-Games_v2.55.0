using UnityEngine;

namespace Data.Login
{
    public class LoginDataManager : Singleton<Data.Login.LoginDataManager>
    {
        // Fields
        private int _userInstallDays;
        private System.DateTime _userInstallTime;
        private System.DateTime _firstLoginDateTime;
        private System.DateTime _lastLoginDateTime;
        private System.DateTime _lastLoginNetDateTime;
        private bool <ShouldLogPrepareCreate>k__BackingField;
        private bool <IsActiveUserIn7>k__BackingField;
        
        // Properties
        public string FirstLoginVersion { get; set; }
        public string AppVersion { get; set; }
        public bool IsFirstLogin { get; }
        public int UserLoginDays { get; set; }
        public string UserInstallDaysTime { get; set; }
        public int UserLoginCount { get; set; }
        private string FirstLoginTime { set; }
        public int UserLoginCountIn7 { get; set; }
        public string LastLoginTime { get; set; }
        public string LastLoginNetTime { get; set; }
        private System.DateTime LastPauseTime { set; }
        public bool ShouldLogPrepareCreate { get; set; }
        public System.DateTime FirstLoginDateTime { get; set; }
        public bool IsActiveUserIn7 { get; set; }
        public System.DateTime LastLoginDateTime { get; set; }
        public System.DateTime LastLoginNetDateTime { get; set; }
        
        // Methods
        public void Init()
        {
            this.SetAppFirstVersion();
            this.UpdateAppVersion();
            this.UpdateUserInstallDays();
            int val_1 = this.UserLoginCount;
            val_1.UserLoginCount = val_1 + 1;
            if(val_1.UserLoginCount == 1)
            {
                    System.DateTime val_4 = System.DateTime.Now;
                this.FirstLoginDateTime = new System.DateTime() {dateData = val_4.dateData};
            }
            
            System.DateTime val_6 = Common.EzDate.GetDateTime(dateString:  this.LastLoginTime, format:  0);
            this._lastLoginDateTime = val_6;
            System.DateTime val_8 = Common.EzDate.GetDateTime(dateString:  val_6.dateData.LastLoginNetTime, format:  0);
            this._lastLoginNetDateTime = val_8;
            if((this._lastLoginNetDateTime.Equals(value:  new System.DateTime() {dateData = Common.EzDate.defaultDateTime})) != false)
            {
                    System.DateTime val_10 = System.DateTime.Now;
                this.LastLoginNetDateTime = new System.DateTime() {dateData = val_10.dateData};
            }
            
            this.UpdateDataFromDay();
        }
        public string get_FirstLoginVersion()
        {
            return (string)Store.LoginData.__il2cppRuntimeField_name;
        }
        private void set_FirstLoginVersion(string value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_10 = value;
        }
        public string get_AppVersion()
        {
            return (string)Store.LoginData.__il2cppRuntimeField_namespaze;
        }
        private void set_AppVersion(string value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_18 = value;
        }
        public bool get_IsFirstLogin()
        {
            return (bool)Store.LoginData.__il2cppRuntimeField_byval_arg;
        }
        public int get_UserLoginDays()
        {
            return (int)typeof(Store.LoginData).__il2cppRuntimeField_24;
        }
        private void set_UserLoginDays(int value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_24 = value;
        }
        public string get_UserInstallDaysTime()
        {
            return (string)typeof(Store.LoginData).__il2cppRuntimeField_28;
        }
        private void set_UserInstallDaysTime(string value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_28 = value;
        }
        public int get_UserLoginCount()
        {
            return (int)Store.LoginData.__il2cppRuntimeField_this_arg;
        }
        private void set_UserLoginCount(int value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_30 = value;
        }
        private void set_FirstLoginTime(string value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_38 = value;
        }
        public int get_UserLoginCountIn7()
        {
            return (int)Store.LoginData.__il2cppRuntimeField_element_class;
        }
        private void set_UserLoginCountIn7(int value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_40 = value;
        }
        public string get_LastLoginTime()
        {
            return (string)Store.LoginData.__il2cppRuntimeField_castClass;
        }
        private void set_LastLoginTime(string value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_48 = value;
        }
        public string get_LastLoginNetTime()
        {
            return (string)Store.LoginData.__il2cppRuntimeField_declaringType;
        }
        private void set_LastLoginNetTime(string value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_50 = value;
        }
        private void set_LastPauseTime(System.DateTime value)
        {
            typeof(Store.LoginData).__il2cppRuntimeField_58 = value.dateData;
        }
        public bool get_ShouldLogPrepareCreate()
        {
            return (bool)this.<ShouldLogPrepareCreate>k__BackingField;
        }
        public void set_ShouldLogPrepareCreate(bool value)
        {
            this.<ShouldLogPrepareCreate>k__BackingField = value;
        }
        public void SetLastPauseTime(System.DateTime dateTime)
        {
            this.LastPauseTime = new System.DateTime() {dateData = dateTime.dateData};
        }
        public bool LimitFirstVersion(string version)
        {
            var val_6;
            bool val_2 = System.String.IsNullOrEmpty(value:  this.FirstLoginVersion);
            if(val_2 != false)
            {
                    val_6 = 0;
                return (bool)val_6;
            }
            
            val_6 = ((Common.EzVersionComparer.VerCompare(ver1:  val_2.FirstLoginVersion, Ver2:  version)) >> 31) ^ 1;
            return (bool)val_6;
        }
        public void AddUserLoginDays()
        {
            int val_1 = this.UserLoginDays;
            val_1.UserLoginDays = val_1 + 1;
        }
        public int GetUserInstallDays()
        {
            return (int)this._userInstallDays;
        }
        public void UpdateUserInstallDays()
        {
            if((System.String.IsNullOrEmpty(value:  this.UserInstallDaysTime)) != false)
            {
                    System.DateTime val_3 = System.DateTime.Now;
                string val_4 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = val_3.dateData}, format:  0);
                val_4.UserInstallDaysTime = val_4;
            }
            
            System.DateTime val_5 = System.DateTime.Now;
            System.DateTime val_7 = Common.EzDate.GetDateTime(dateString:  val_5.dateData.UserInstallDaysTime, format:  0);
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_5.dateData}, d2:  new System.DateTime() {dateData = val_7.dateData});
            this._userInstallDays = val_8._ticks.Days + 1;
        }
        public System.DateTime GetUserInstallTime()
        {
            if((System.String.IsNullOrEmpty(value:  this.UserInstallDaysTime)) != false)
            {
                    System.DateTime val_3 = System.DateTime.Now;
                string val_4 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = val_3.dateData}, format:  0);
                val_4.UserInstallDaysTime = val_4;
            }
            
            System.DateTime val_6 = Common.EzDate.GetDateTime(dateString:  val_4.UserInstallDaysTime, format:  0);
            this._userInstallTime = val_6;
            return (System.DateTime)val_6.dateData;
        }
        public void AddUserLoginCount()
        {
            int val_1 = this.UserLoginCount;
            val_1.UserLoginCount = val_1 + 1;
        }
        public System.DateTime get_FirstLoginDateTime()
        {
            return (System.DateTime)this._firstLoginDateTime;
        }
        public void set_FirstLoginDateTime(System.DateTime value)
        {
            this._firstLoginDateTime = value;
            string val_1 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0);
            val_1.FirstLoginTime = val_1;
        }
        public void AddUserLoginCountIn7()
        {
            int val_1 = this.UserLoginCountIn7;
            val_1.UserLoginCountIn7 = val_1 + 1;
        }
        public bool IsIn7Day()
        {
            System.DateTime val_1 = System.DateTime.Now;
            System.TimeSpan val_2 = val_1.dateData.Subtract(value:  new System.DateTime() {dateData = this._firstLoginDateTime});
            System.TimeSpan val_3 = System.TimeSpan.FromDays(value:  7);
            return (bool)System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_2._ticks}, t2:  new System.TimeSpan() {_ticks = val_3._ticks});
        }
        public bool get_IsActiveUserIn7()
        {
            return (bool)this.<IsActiveUserIn7>k__BackingField;
        }
        public void set_IsActiveUserIn7(bool value)
        {
            this.<IsActiveUserIn7>k__BackingField = value;
        }
        public System.DateTime get_LastLoginDateTime()
        {
            return (System.DateTime)this._lastLoginDateTime;
        }
        public void set_LastLoginDateTime(System.DateTime value)
        {
            this._lastLoginDateTime = value;
            string val_1 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0);
            val_1.LastLoginTime = val_1;
        }
        public System.DateTime get_LastLoginNetDateTime()
        {
            return (System.DateTime)this._lastLoginNetDateTime;
        }
        public void set_LastLoginNetDateTime(System.DateTime value)
        {
            this._lastLoginNetDateTime = value;
            string val_1 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0);
            val_1.LastLoginNetTime = val_1;
        }
        public void UpdateDataFromDay()
        {
            bool val_1 = Common.GlobalMethods.IsToday(des:  new System.DateTime() {dateData = this._lastLoginDateTime}, res:  new System.Nullable<System.DateTime>() {HasValue = false});
            if(val_1 == true)
            {
                    return;
            }
            
            int val_2 = val_1.UserLoginDays;
            val_2.UserLoginDays = val_2 + 1;
            this.UpdateUserInstallDays();
            this.<ShouldLogPrepareCreate>k__BackingField = true;
            Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowHomeDailyPoint = true;
            System.DateTime val_5 = System.DateTime.Now;
            this.LastLoginDateTime = new System.DateTime() {dateData = val_5.dateData};
            int val_6 = this.UserLoginCountIn7;
            val_6.UserLoginCountIn7 = val_6 + 1;
            if(val_6.UserLoginCountIn7 != 4)
            {
                    return;
            }
            
            this.<IsActiveUserIn7>k__BackingField = true;
        }
        public bool IsFirstLoginToVersion()
        {
            if(this.IsFirstLogin == false)
            {
                    return false;
            }
            
            return this.LimitFirstVersion(version:  "2.29.0");
        }
        private void SetAppFirstVersion()
        {
            if((System.String.IsNullOrEmpty(value:  this.AppVersion)) == false)
            {
                    return;
            }
            
            string val_3 = UnityEngine.Application.version;
            val_3.FirstLoginVersion = val_3;
        }
        private void UpdateAppVersion()
        {
            if((System.String.op_Inequality(a:  this.AppVersion, b:  UnityEngine.Application.version)) == false)
            {
                    return;
            }
            
            string val_4 = UnityEngine.Application.version;
            val_4.AppVersion = val_4;
        }
        public LoginDataManager()
        {
        
        }
    
    }

}
