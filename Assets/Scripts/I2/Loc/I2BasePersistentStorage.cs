using UnityEngine;

namespace I2.Loc
{
    public abstract class I2BasePersistentStorage
    {
        // Methods
        public virtual void SetSetting_String(string key, string value)
        {
            var val_7;
            object val_8;
            int val_9;
            string val_10;
            val_8 = key;
            if(value != null)
            {
                    val_9 = value.m_stringLength;
                if(val_9 > 8000)
            {
                    float val_7 = 8000f;
                val_7 = (float)val_9 / val_7;
                int val_1 = UnityEngine.Mathf.CeilToInt(f:  val_7);
                if(val_1 >= 1)
            {
                    var val_9 = 0;
                object val_8 = 0;
                val_7 = 8000;
                do
            {
                UnityEngine.PlayerPrefs.SetString(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  val_8, arg1:  val_8), value:  value.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  64, b:  val_9)));
                val_8 = val_8 + 1;
                val_9 = val_9 + 7999;
                val_9 = val_9 + 8000;
                val_8 = val_8;
            }
            while(val_8 < val_1);
            
            }
            
                UnityEngine.PlayerPrefs.SetString(key:  val_8, value:  "[$I2#@div$]" + val_1);
                return;
            }
            
                UnityEngine.PlayerPrefs.SetString(key:  val_8, value:  value);
                return;
            }
            
            val_10 = val_8;
            throw new NullReferenceException();
        }
        public virtual string GetSetting_String(string key, string defaultValue)
        {
            string val_10;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  defaultValue);
            val_10 = val_1;
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return (string)val_10;
            }
            
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_10.StartsWith(value:  "[I2split]")) == false)
            {
                    return (string)val_10;
            }
            
            int val_5 = System.Int32.Parse(s:  val_10.Substring(startIndex:  "[I2split]".__il2cppRuntimeField_10>>0&0xFFFFFFFF));
            val_10 = "";
            if(val_5 < 1)
            {
                    return (string)val_10;
            }
            
            object val_10 = 0;
            do
            {
                val_10 = val_10 + 1;
                val_10 = val_10 + UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  val_10, arg1:  key), defaultValue:  "")(UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  val_10, arg1:  key), defaultValue:  ""));
            }
            while(val_10 < val_5);
            
            return (string)val_10;
        }
        public virtual void DeleteSetting(string key)
        {
            var val_8;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_1)) != true)
            {
                    if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_8 = "[I2split]";
                if((val_1.StartsWith(value:  "[I2split]")) != false)
            {
                    int val_5 = System.Int32.Parse(s:  val_1.Substring(startIndex:  "[I2split]".__il2cppRuntimeField_10>>0&0xFFFFFFFF));
                if(val_5 >= 1)
            {
                    do
            {
                UnityEngine.PlayerPrefs.DeleteKey(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  0, arg1:  key));
                val_8 = 0 + 1;
            }
            while(val_8 < val_5);
            
            }
            
            }
            
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  key);
        }
        public virtual void ForceSaveSettings()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        public virtual bool HasSetting(string key)
        {
            return UnityEngine.PlayerPrefs.HasKey(key:  key);
        }
        public virtual bool CanAccessFiles()
        {
            return true;
        }
        private string UpdateFilename(I2.Loc.PersistentStorage.eFileType fileType, string fileName)
        {
            if(fileType != 3)
            {
                    if(fileType == 2)
            {
                    return UnityEngine.Application.temporaryCachePath + "/"("/") + fileName;
            }
            
                if(fileType != 1)
            {
                    return (string)fileName;
            }
            
                string val_1 = UnityEngine.Application.persistentDataPath;
                return UnityEngine.Application.temporaryCachePath + "/"("/") + fileName;
            }
            
            string val_2 = UnityEngine.Application.streamingAssetsPath;
            return UnityEngine.Application.temporaryCachePath + "/"("/") + fileName;
        }
        public virtual bool SaveFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = True)
        {
            string val_5;
            string val_6;
            var val_7;
            val_5 = data;
            val_6 = fileName;
            if((this & 1) != 0)
            {
                    System.IO.File.WriteAllText(path:  this.UpdateFilename(fileType:  fileType, fileName:  val_6), contents:  val_5, encoding:  System.Text.Encoding.UTF8);
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public virtual string LoadFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            string val_6;
            eFileType val_7;
            var val_8;
            val_6 = fileName;
            val_7 = fileType;
            if((this & 1) != 0)
            {
                    val_7 = this.UpdateFilename(fileType:  val_7, fileName:  val_6);
                string val_3 = System.IO.File.ReadAllText(path:  val_7, encoding:  System.Text.Encoding.UTF8);
                return (string)val_8;
            }
            
            val_8 = 0;
            return (string)val_8;
        }
        public virtual bool DeleteFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            System.Object[] val_4;
            string val_5;
            var val_6;
            val_4 = logExceptions;
            val_5 = fileName;
            if((this & 1) != 0)
            {
                    System.IO.File.Delete(path:  this.UpdateFilename(fileType:  fileType, fileName:  val_5));
                val_6 = 1;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public virtual bool HasFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            System.Object[] val_5;
            string val_6;
            var val_7;
            val_5 = logExceptions;
            val_6 = fileName;
            if((this & 1) != 0)
            {
                    bool val_2 = System.IO.File.Exists(path:  this.UpdateFilename(fileType:  fileType, fileName:  val_6));
            }
            else
            {
                    val_7 = 0;
            }
            
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        protected I2BasePersistentStorage()
        {
        
        }
    
    }

}
