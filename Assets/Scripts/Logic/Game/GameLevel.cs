using UnityEngine;

namespace Logic.Game
{
    public class GameLevel
    {
        // Fields
        private bool <finishInited>k__BackingField;
        public System.Action onInitedLoadABLevel;
        private Data.Bean.LevelInfoBean levelInfos;
        private Data.Bean.DynamicLevelInfoBean _dynamicLevelInfos;
        
        // Properties
        public bool finishInited { get; set; }
        
        // Methods
        public bool get_finishInited()
        {
            return (bool)this.<finishInited>k__BackingField;
        }
        public void set_finishInited(bool value)
        {
            this.<finishInited>k__BackingField = value;
        }
        public void InitLevels()
        {
            var val_9;
            this.levelInfos = UnityEngine.JsonUtility.FromJson<Data.Bean.LevelInfoBean>(json:  Common.EzFile.RijndaelDecrypt(pString:  Resource.ResManager.GetConfig(configName:  this.GetLevelConfigName()).text, pKey:  ""));
            float val_7 = UnityEngine.Time.realtimeSinceStartup;
            val_7 = val_7 - UnityEngine.Time.realtimeSinceStartup;
            UnityEngine.Debug.Log(message:  "GameLevel load level use time = "("GameLevel load level use time = ") + val_7);
            if(this.levelInfos == null)
            {
                    val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Log.D.Error(message:  "LevelInfoBean Init failed: levelAsset json to object is null", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            this.<finishInited>k__BackingField = true;
            if(this.onInitedLoadABLevel == null)
            {
                    return;
            }
            
            this.onInitedLoadABLevel.Invoke();
            this.onInitedLoadABLevel = 0;
        }
        private string GetLevelConfigName()
        {
            var val_3;
            if((Locale.LocaleManager.GetCurLanguage() - 1) <= 2)
            {
                    val_3 = mem[19752608 + ((val_1 - 1)) << 3];
                val_3 = 19752608 + ((val_1 - 1)) << 3;
                return (string)val_3;
            }
            
            val_3 = "Config/Game/Level/Android/android_level_test_3";
            return (string)val_3;
        }
        public int GetCount(int section = -1)
        {
            var val_1;
            Data.Bean.LevelInfoBean val_1 = this.levelInfos;
            if((val_1 != null) && (this.levelInfos.levelInfos != null))
            {
                    if(section == 1)
            {
                    return (int)val_1;
            }
            
                if(7058 > section)
            {
                    if(7058 <= section)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (section << 3);
                return (int)val_1;
            }
            
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public int GetAllScore(int unlockSectionIndex, int unlockLevelIndex)
        {
            var val_11;
            var val_12;
            val_11 = unlockSectionIndex;
            if(this.levelInfos == null)
            {
                goto label_1;
            }
            
            if(val_11 < 1)
            {
                goto label_2;
            }
            
            val_12 = 0;
            label_14:
            var val_13 = 0;
            do
            {
                if(this.levelInfos <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Data.Bean.LevelBean val_1 = this.GetLevel(sectionIndex:  0, levelIndex:  0);
                if(val_1 != null)
            {
                    System.Collections.Generic.List<System.String> val_2 = val_1.answerList;
                int val_12 = val_1.l.m_stringLength;
                val_12 = val_12 - 2;
                val_12 = val_12 + (val_12 * (-2));
                val_12 = val_12 + 2;
            }
            
                val_13 = val_13 + 1;
            }
            while(this.levelInfos != null);
            
            if((0 + 1) >= val_11)
            {
                goto label_13;
            }
            
            if(this.levelInfos != null)
            {
                goto label_14;
            }
            
            label_1:
            val_12 = 0;
            return (int)val_12;
            label_2:
            val_12 = 0;
            label_13:
            val_11 = 0;
            do
            {
                if(val_11 >= (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex))
            {
                    return (int)val_12;
            }
            
                Data.Bean.LevelBean val_8 = this.GetLevel(sectionIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex, levelIndex:  0);
                if(val_8 != null)
            {
                    System.Collections.Generic.List<System.String> val_9 = val_8.answerList;
                int val_14 = val_8.l.m_stringLength;
                val_14 = val_14 - 2;
                val_14 = val_12 + (val_14 * (W9 - 2));
                val_12 = val_14 + 2;
            }
            
                val_11 = val_11 + 1;
            }
            while((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance) != null);
            
            throw new NullReferenceException();
        }
        public int GetAllConnectWords(int unlockSectionIndex, int unlockLevelIndex)
        {
            var val_10;
            var val_11;
            val_10 = unlockSectionIndex;
            if(this.levelInfos == null)
            {
                goto label_1;
            }
            
            if(val_10 < 1)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_13:
            var val_11 = 0;
            do
            {
                if(this.levelInfos <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Data.Bean.LevelBean val_1 = this.GetLevel(sectionIndex:  0, levelIndex:  0);
                if(val_1 != null)
            {
                    System.Collections.Generic.List<System.String> val_2 = val_1.answerList;
            }
            
                val_11 = val_11 + 1;
            }
            while(this.levelInfos != null);
            
            if((0 + 1) >= val_10)
            {
                goto label_12;
            }
            
            if(this.levelInfos != null)
            {
                goto label_13;
            }
            
            label_1:
            val_11 = 0;
            return 1152921504822927360;
            label_2:
            val_11 = 0;
            label_12:
            val_10 = 0;
            do
            {
                if(val_10 >= (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex))
            {
                    return 1152921504822927360;
            }
            
                Data.Bean.LevelBean val_8 = this.GetLevel(sectionIndex:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex, levelIndex:  0);
                if(val_8 != null)
            {
                    System.Collections.Generic.List<System.String> val_9 = val_8.answerList;
            }
            
                val_10 = val_10 + 1;
            }
            while((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance) != null);
            
            throw new NullReferenceException();
        }
        public int GetPassLevel(int unlockSectionIndex, int unlockLevelIndex)
        {
            int val_1 = unlockLevelIndex;
            if(unlockSectionIndex == 0)
            {
                    return (int)(Data.Bean.LevelInfoBean.__il2cppRuntimeField_byval_arg + 16 + 24 + unlockLevelIndex);
            }
            
            if(unlockSectionIndex < 1)
            {
                    return (int)(Data.Bean.LevelInfoBean.__il2cppRuntimeField_byval_arg + 16 + 24 + unlockLevelIndex);
            }
            
            var val_1 = 0;
            do
            {
                if(this.levelInfos <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 1;
                if(val_1 >= unlockSectionIndex)
            {
                    return (int)(Data.Bean.LevelInfoBean.__il2cppRuntimeField_byval_arg + 16 + 24 + unlockLevelIndex);
            }
            
            }
            while(this.levelInfos != null);
            
            throw new NullReferenceException();
        }
        public Data.Bean.LevelBean CurrentLevel()
        {
            System.Collections.Generic.List<Data.Bean.SectionBean> val_6;
            var val_7;
            val_6 = this;
            Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((this.IsAllLevelPass(section:  val_1.<CurrentSectionIndex>k__BackingField, level:  val_2.<CurrentLevelIndex>k__BackingField)) != false)
            {
                    val_7 = 0;
                return 0;
            }
            
            Data.Bean.LevelInfoBean val_6 = this.levelInfos;
            Data.UserPlayer.UserPlayerDataManager val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if(val_6 <= (val_4.<CurrentSectionIndex>k__BackingField))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + ((val_4.<CurrentSectionIndex>k__BackingField) << 3);
            val_6 = (this.levelInfos + (val_4.<CurrentSectionIndex>k__BackingField) << 3).levelInfos;
            Data.UserPlayer.UserPlayerDataManager val_5 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if(val_6 <= (val_5.<CurrentLevelIndex>k__BackingField))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + ((val_5.<CurrentLevelIndex>k__BackingField) << 3);
            return 0;
        }
        public int GetDifficultyLevelCount(int partIndex)
        {
            if((partIndex & 2147483648) != 0)
            {
                    return (int)0;
            }
            
            Data.Bean.DynamicLevelInfoBean val_1 = this._dynamicLevelInfos;
            if(val_1 == null)
            {
                    return (int)0;
            }
            
            if(val_1 > partIndex)
            {
                    if(val_1 <= partIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (partIndex << 3);
                return (int)0;
            }
            
            0 = 0;
            return (int)0;
        }
        public string GetCurrentLevelName()
        {
            object val_7;
            var val_8;
            val_7 = this;
            Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((this.IsAllLevelPass(section:  val_1.<CurrentSectionIndex>k__BackingField, level:  val_2.<CurrentLevelIndex>k__BackingField)) != false)
            {
                    val_8 = "";
                return (string)System.String.Format(format:  "{0}-{1}", arg0:  val_7 = val_7 + 1, arg1:  val_8 = val_8 + 1);
            }
            
            Data.UserPlayer.UserPlayerDataManager val_4 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            int val_7 = val_4.<CurrentSectionIndex>k__BackingField;
            val_7 = val_7;
            Data.UserPlayer.UserPlayerDataManager val_5 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            int val_8 = val_5.<CurrentLevelIndex>k__BackingField;
            return (string)System.String.Format(format:  "{0}-{1}", arg0:  val_7, arg1:  val_8);
        }
        public bool IsPassLevelForUnlockLevel(int sectionIndex, int levelIndex)
        {
            var val_8;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) > sectionIndex)
            {
                    val_8 = 1;
                return (bool)val_8;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) == sectionIndex)
            {
                    var val_7 = ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) >= levelIndex) ? 1 : 0;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public bool IsPassLevelForCurrentLevel(int sectionIndex, int levelIndex)
        {
            var val_5;
            Data.UserPlayer.UserPlayerDataManager val_1 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_1.<CurrentSectionIndex>k__BackingField) > sectionIndex)
            {
                    val_5 = 1;
                return (bool)val_5;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_2 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_2.<CurrentSectionIndex>k__BackingField) == sectionIndex)
            {
                    Data.UserPlayer.UserPlayerDataManager val_3 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
                var val_4 = ((val_3.<CurrentLevelIndex>k__BackingField) >= levelIndex) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public Data.Bean.LevelBean GetLevel(int sectionIndex, int levelIndex)
        {
            System.Collections.Generic.List<Data.Bean.SectionBean> val_1;
            var val_2;
            val_1 = this;
            val_2 = 0;
            if((sectionIndex & 2147483648) != 0)
            {
                    return (Data.Bean.LevelBean)val_2;
            }
            
            Data.Bean.LevelInfoBean val_1 = this.levelInfos;
            if(val_1 == null)
            {
                    return (Data.Bean.LevelBean)val_2;
            }
            
            if(val_1 > sectionIndex)
            {
                    if(val_1 <= sectionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (sectionIndex << 3);
                if(((this.levelInfos + (sectionIndex) << 3).levelInfos) > levelIndex)
            {
                    Data.Bean.LevelInfoBean val_2 = this.levelInfos;
                val_1 = this.levelInfos.levelInfos;
                if(val_2 <= sectionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (((long)(int)(sectionIndex)) << 3);
                if(val_2 <= levelIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (levelIndex << 3);
                return (Data.Bean.LevelBean)val_2;
            }
            
            }
            
            val_2 = 0;
            return (Data.Bean.LevelBean)val_2;
        }
        public bool IsAllLevelPass(int section = -1, int level = -1)
        {
            int val_14;
            Data.Bean.LevelInfoBean val_15;
            bool val_16;
            var val_17;
            Data.Bean.LevelInfoBean val_18;
            var val_19;
            var val_20;
            val_14 = section;
            val_15 = this.levelInfos;
            if(val_15 == null)
            {
                    return true;
            }
            
            if(val_14 == 1)
            {
                goto label_2;
            }
            
            val_16 = true;
            val_15 = this.levelInfos;
            if(val_15 == null)
            {
                goto label_5;
            }
            
            val_16 = this.levelInfos.levelInfos;
            if(val_16 == null)
            {
                goto label_5;
            }
            
            val_16 = 0;
            goto label_6;
            label_2:
            val_14 = 1152921512608190960;
            val_18 = this.levelInfos;
            if(val_18 != null)
            {
                    val_18 = this.levelInfos.levelInfos;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) >= val_18)
            {
                    return true;
            }
            
            if((this.levelInfos == null) || (this.levelInfos.levelInfos == null))
            {
                goto label_15;
            }
            
            val_19 = this.levelInfos.levelInfos - 1;
            goto label_16;
            label_5:
            val_17 = 0;
            label_6:
            if(level == 1)
            {
                goto label_17;
            }
            
            if(val_17 <= val_14)
            {
                    return true;
            }
            
            if(((val_16 & 1) != 0) || (this.levelInfos.levelInfos == null))
            {
                goto label_20;
            }
            
            val_20 = this.levelInfos.levelInfos - 1;
            goto label_21;
            label_17:
            var val_5 = (val_17 <= val_14) ? 1 : 0;
            return true;
            label_20:
            val_20 = 0;
            label_21:
            if(val_20 != val_14)
            {
                    return true;
            }
            
            var val_7 = ((this.GetCount(section:  val_14)) < level) ? 1 : 0;
            return true;
            label_15:
            val_19 = 0;
            label_16:
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) != val_19)
            {
                    return true;
            }
            
            var val_13 = ((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockLevelIndex) >= (this.GetCount(section:  Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex))) ? 1 : 0;
            return true;
        }
        public GameLevel()
        {
        
        }
    
    }

}
