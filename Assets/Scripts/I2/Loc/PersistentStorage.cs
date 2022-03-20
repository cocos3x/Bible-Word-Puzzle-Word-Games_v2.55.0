using UnityEngine;

namespace I2.Loc
{
    public static class PersistentStorage
    {
        // Fields
        private static I2.Loc.I2CustomPersistentStorage mStorage;
        
        // Methods
        public static void SetSetting_String(string key, string value)
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 == null)
            {
                    I2.Loc.I2CustomPersistentStorage val_1 = null;
                val_2 = val_1;
                val_1 = new I2.Loc.I2CustomPersistentStorage();
                I2.Loc.PersistentStorage.mStorage = val_2;
                val_3 = I2.Loc.PersistentStorage.mStorage;
            }
            
            SetSetting_String(key:  key, value:  value);
        }
        public static string GetSetting_String(string key, string defaultValue)
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return GetSetting_String(key:  key, defaultValue:  defaultValue);
            }
            
            I2.Loc.I2CustomPersistentStorage val_1 = null;
            val_2 = val_1;
            val_1 = new I2.Loc.I2CustomPersistentStorage();
            I2.Loc.PersistentStorage.mStorage = val_2;
            val_3 = I2.Loc.PersistentStorage.mStorage;
            return GetSetting_String(key:  key, defaultValue:  defaultValue);
        }
        public static void DeleteSetting(string key)
        {
            I2.Loc.I2CustomPersistentStorage val_2 = I2.Loc.PersistentStorage.mStorage;
            if(val_2 == null)
            {
                    I2.Loc.PersistentStorage.mStorage = new I2.Loc.I2CustomPersistentStorage();
                val_2 = I2.Loc.PersistentStorage.mStorage;
            }
            
            DeleteSetting(key:  key);
        }
        public static bool HasSetting(string key)
        {
            I2.Loc.I2CustomPersistentStorage val_2 = I2.Loc.PersistentStorage.mStorage;
            if(val_2 != null)
            {
                    return HasSetting(key:  key);
            }
            
            I2.Loc.PersistentStorage.mStorage = new I2.Loc.I2CustomPersistentStorage();
            val_2 = I2.Loc.PersistentStorage.mStorage;
            return HasSetting(key:  key);
        }
        public static void ForceSaveSettings()
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 == null)
            {
                    I2.Loc.I2CustomPersistentStorage val_1 = null;
                val_2 = val_1;
                val_1 = new I2.Loc.I2CustomPersistentStorage();
                I2.Loc.PersistentStorage.mStorage = val_2;
                val_3 = I2.Loc.PersistentStorage.mStorage;
            }
            
            ForceSaveSettings();
        }
        public static bool CanAccessFiles()
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return CanAccessFiles();
            }
            
            I2.Loc.I2CustomPersistentStorage val_1 = null;
            val_2 = val_1;
            val_1 = new I2.Loc.I2CustomPersistentStorage();
            I2.Loc.PersistentStorage.mStorage = val_2;
            val_3 = I2.Loc.PersistentStorage.mStorage;
            return CanAccessFiles();
        }
        public static bool SaveFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3;
            I2.Loc.I2CustomPersistentStorage val_4 = I2.Loc.PersistentStorage.mStorage;
            if(val_4 != null)
            {
                    return SaveFile(fileType:  fileType, fileName:  fileName, data:  data, logExceptions:  logExceptions);
            }
            
            I2.Loc.I2CustomPersistentStorage val_1 = null;
            val_3 = val_1;
            val_1 = new I2.Loc.I2CustomPersistentStorage();
            I2.Loc.PersistentStorage.mStorage = val_3;
            val_4 = I2.Loc.PersistentStorage.mStorage;
            return SaveFile(fileType:  fileType, fileName:  fileName, data:  data, logExceptions:  logExceptions);
        }
        public static string LoadFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return LoadFile(fileType:  fileType, fileName:  fileName, logExceptions:  logExceptions);
            }
            
            I2.Loc.PersistentStorage.mStorage = new I2.Loc.I2CustomPersistentStorage();
            val_3 = I2.Loc.PersistentStorage.mStorage;
            return LoadFile(fileType:  fileType, fileName:  fileName, logExceptions:  logExceptions);
        }
        public static bool DeleteFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return DeleteFile(fileType:  fileType, fileName:  fileName, logExceptions:  logExceptions);
            }
            
            I2.Loc.PersistentStorage.mStorage = new I2.Loc.I2CustomPersistentStorage();
            val_3 = I2.Loc.PersistentStorage.mStorage;
            return DeleteFile(fileType:  fileType, fileName:  fileName, logExceptions:  logExceptions);
        }
        public static bool HasFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return HasFile(fileType:  fileType, fileName:  fileName, logExceptions:  logExceptions);
            }
            
            I2.Loc.PersistentStorage.mStorage = new I2.Loc.I2CustomPersistentStorage();
            val_3 = I2.Loc.PersistentStorage.mStorage;
            return HasFile(fileType:  fileType, fileName:  fileName, logExceptions:  logExceptions);
        }
    
    }

}
