using UnityEngine;

namespace Data.Guide
{
    public class GuideDataManager : Singleton<Data.Guide.GuideDataManager>
    {
        // Fields
        private bool <IsGiftReconfirmToggleIsOn>k__BackingField;
        private bool <IsLetterGiftReconfirmToggleIsOn>k__BackingField;
        
        // Properties
        public bool ShouldShowHomeDailyPoint { get; set; }
        public bool ShouldShowBonusWordGuideDialog { get; set; }
        public bool ShouldShowHomeDailyDialog { get; set; }
        public bool IsDailyNewGuide { get; set; }
        public bool IsReconfirmWatchVideo { get; set; }
        public bool IsLetterGiftReconfirm { get; set; }
        public bool HasShowFireworkGuide { get; set; }
        public bool IsHaveMapReelGuide { get; set; }
        public bool IsGiftReconfirmToggleIsOn { get; set; }
        public bool IsLetterGiftReconfirmToggleIsOn { get; set; }
        
        // Methods
        public void Init()
        {
            bool val_1 = this.IsReconfirmWatchVideo;
            this.<IsGiftReconfirmToggleIsOn>k__BackingField = val_1;
            this.<IsLetterGiftReconfirmToggleIsOn>k__BackingField = val_1.IsLetterGiftReconfirm;
        }
        public bool get_ShouldShowHomeDailyPoint()
        {
            return (bool)Store.GuideData.__il2cppRuntimeField_name;
        }
        private void set_ShouldShowHomeDailyPoint(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_10 = value;
        }
        public bool get_ShouldShowBonusWordGuideDialog()
        {
            return (bool)typeof(Store.GuideData).__il2cppRuntimeField_11;
        }
        private void set_ShouldShowBonusWordGuideDialog(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_11 = value;
        }
        public bool get_ShouldShowHomeDailyDialog()
        {
            return (bool)typeof(Store.GuideData).__il2cppRuntimeField_12;
        }
        private void set_ShouldShowHomeDailyDialog(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_12 = value;
        }
        public bool get_IsDailyNewGuide()
        {
            return (bool)typeof(Store.GuideData).__il2cppRuntimeField_13;
        }
        private void set_IsDailyNewGuide(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_13 = value;
        }
        public bool get_IsReconfirmWatchVideo()
        {
            return (bool)typeof(Store.GuideData).__il2cppRuntimeField_14;
        }
        private void set_IsReconfirmWatchVideo(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_14 = value;
        }
        public bool get_IsLetterGiftReconfirm()
        {
            return (bool)typeof(Store.GuideData).__il2cppRuntimeField_15;
        }
        private void set_IsLetterGiftReconfirm(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_15 = value;
        }
        public bool get_HasShowFireworkGuide()
        {
            return (bool)typeof(Store.GuideData).__il2cppRuntimeField_16;
        }
        private void set_HasShowFireworkGuide(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_16 = value;
        }
        public bool get_IsHaveMapReelGuide()
        {
            return (bool)Store.GuideData.__il2cppRuntimeField_namespaze;
        }
        private void set_IsHaveMapReelGuide(bool value)
        {
            typeof(Store.GuideData).__il2cppRuntimeField_18 = value;
        }
        public bool ShouldShowGuide()
        {
            return (bool)(((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) | (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex)) == 0) ? 1 : 0;
        }
        public bool ShouldShowGuide1_2()
        {
            var val_6;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == 0)
            {
                    return (bool)((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) == 1) ? 1 : 0;
            }
            
            val_6 = 0;
            return (bool)((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) == 1) ? 1 : 0;
        }
        public bool ShouldShowGuide1_3()
        {
            var val_8;
            var val_12 = 1152921512608190960;
            Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1.UnlockSectionIndex != 0)
            {
                    return false;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_3 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_3.UnlockLevelIndex != 2)
            {
                    return false;
            }
            
            Data.GameRecord.GameRecordDataManager val_5 = Common.Singleton<Data.GameRecord.GameRecordDataManager>.Instance;
            if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.Collections.Generic.List<System.String> val_6 = val_5.LevelBoxProgress;
            if(val_6 == null)
            {
                    return false;
            }
            
            if(1152921512608622592 < 1)
            {
                    return false;
            }
            
            List.Enumerator<T> val_7 = val_6.GetEnumerator();
            goto label_10;
            label_13:
            if((val_8 + 16) < 1)
            {
                goto label_10;
            }
            
            var val_12 = 0;
            label_12:
            if((val_8.Chars[0] & 65535) == '1')
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            if(val_12 < (val_8 + 16))
            {
                goto label_12;
            }
            
            label_10:
            if(MoveNext() == true)
            {
                goto label_13;
            }
            
            goto label_14;
            label_11:
            label_14:
            Dispose();
            return false;
        }
        public bool GetShouldShowHomeDailyPoint()
        {
            var val_6;
            if(this.ShouldShowHomeDailyPoint != false)
            {
                    var val_5 = (((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) + 1) > 1) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public void SetShouldShowHomeDailyPoint(bool isShould)
        {
            this.ShouldShowHomeDailyPoint = isShould;
        }
        public void SetShouldShowBonusWordGuideDialog(bool isShould)
        {
            this.ShouldShowBonusWordGuideDialog = isShould;
        }
        public void SetShouldShowHomeDailyDialog(bool isShould)
        {
            this.ShouldShowHomeDailyDialog = isShould;
        }
        public void SetDailyNewGuide(bool isGuide)
        {
            this.IsDailyNewGuide = isGuide;
        }
        public void SetReconfirmWatchVideo(bool isReconfirm)
        {
            this.IsReconfirmWatchVideo = isReconfirm;
        }
        public void SetLetterGiftReconfirm(bool isReconfirm)
        {
            this.IsLetterGiftReconfirm = isReconfirm;
        }
        public bool get_IsGiftReconfirmToggleIsOn()
        {
            return (bool)this.<IsGiftReconfirmToggleIsOn>k__BackingField;
        }
        public void set_IsGiftReconfirmToggleIsOn(bool value)
        {
            this.<IsGiftReconfirmToggleIsOn>k__BackingField = value;
        }
        public bool get_IsLetterGiftReconfirmToggleIsOn()
        {
            return (bool)this.<IsLetterGiftReconfirmToggleIsOn>k__BackingField;
        }
        public void set_IsLetterGiftReconfirmToggleIsOn(bool value)
        {
            this.<IsLetterGiftReconfirmToggleIsOn>k__BackingField = value;
        }
        public void SetHasShowFireworkGuide(bool isHave)
        {
            this.HasShowFireworkGuide = isHave;
        }
        public void SetHaveMapReelGuide(bool isValue)
        {
            this.IsHaveMapReelGuide = isValue;
        }
        public bool GetHaveMapReelGuide()
        {
            bool val_2 = Common.Singleton<Data.Login.LoginDataManager>.Instance.LimitFirstVersion(version:  "2.46.0");
            if(val_2 == false)
            {
                    return false;
            }
            
            return val_2.IsHaveMapReelGuide;
        }
        public GuideDataManager()
        {
        
        }
    
    }

}
