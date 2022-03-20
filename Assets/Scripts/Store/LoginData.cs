using UnityEngine;

namespace Store
{
    public class LoginData : IStoreData
    {
        // Fields
        public string FirstLoginVersion;
        public string AppVersion;
        public bool IsFirstLogin;
        public int UserLoginDays;
        public string UserInstallDaysTime;
        public int UserLoginCount;
        public string FirstLoginTime;
        public int UserLoginCountIn7;
        public string LastLoginTime;
        public string LastLoginNetTime;
        public System.DateTime LastPauseTime;
        public System.DateTime LastResumeTime;
        
        // Methods
        public void Reset()
        {
            this.FirstLoginVersion = System.String.alignConst;
            this.IsFirstLogin = true;
            this.UserLoginDays = 0;
            this.AppVersion = System.String.alignConst;
            this.UserLoginCount = 0;
            this.UserInstallDaysTime = System.String.alignConst;
            this.UserLoginCountIn7 = 0;
            this.FirstLoginTime = System.String.alignConst;
            this.LastLoginTime = System.String.alignConst;
            this.LastLoginNetTime = System.String.alignConst;
            System.DateTime val_1 = System.DateTime.Now;
            this.LastPauseTime = val_1;
            System.DateTime val_2 = System.DateTime.Now;
            this.LastResumeTime = val_2;
        }
        public LoginData()
        {
            this.FirstLoginVersion = System.String.alignConst;
            this.AppVersion = System.String.alignConst;
            System.DateTime val_1 = System.DateTime.Now;
            this.LastPauseTime = val_1;
            System.DateTime val_2 = System.DateTime.Now;
            this.LastResumeTime = val_2;
        }
    
    }

}
