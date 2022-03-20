using UnityEngine;

namespace Utils.Util.File
{
    public class FileUtil
    {
        // Methods
        public static string GetShortName(string path)
        {
            System.StringComparison val_3 = 4;
            string val_2 = "/";
            int val_1 = path.LastIndexOf(value:  val_2, comparisonType:  val_3);
            if(val_1 < 1)
            {
                    return (string)path;
            }
            
            val_2 = val_1 + 1;
            val_3 = path.m_stringLength + (~val_1);
            return path.Substring(startIndex:  val_2, length:  val_3);
        }
        public static string GetShortNameNoSuffix(string path)
        {
            string val_1 = Utils.Util.File.FileUtil.GetShortName(path:  path);
            int val_2 = val_1.LastIndexOf(value:  ".", comparisonType:  4);
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            return val_1.Substring(startIndex:  0, length:  val_2);
        }
        public static string GetSuffix(string path)
        {
            string val_3 = path;
            if((System.String.IsNullOrEmpty(value:  val_3 = path)) != false)
            {
                    val_3 = "";
                return (string)val_3;
            }
            
            System.StringComparison val_4 = 4;
            string val_3 = ".";
            int val_2 = val_3.LastIndexOf(value:  val_3, comparisonType:  val_4);
            if(val_2 < 1)
            {
                    return (string)val_3;
            }
            
            val_3 = val_2 + 1;
            val_4 = path.m_stringLength + (~val_2);
            return val_3.Substring(startIndex:  val_3, length:  val_4);
        }
        public static Utils.Util.File.FileUtil.FileOperationResult ReadAllBytes(string path)
        {
            var val_8;
            var val_9;
            if((System.String.IsNullOrEmpty(value:  path)) != false)
            {
                    object val_2 = null;
                val_8 = "Invalid path.";
                val_9 = val_2;
                val_2 = new System.Object();
            }
            else
            {
                    string val_3 = path.Replace(oldChar:  '\', newChar:  '/');
                if((System.IO.File.Exists(path:  val_3)) != false)
            {
                    object val_6 = null;
                val_9 = val_6;
                val_6 = new System.Object();
                typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_10 = 1;
                typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_18 = System.IO.File.ReadAllBytes(path:  val_3);
                typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_20 = 0;
                return (FileOperationResult)val_9;
            }
            
                object val_7 = null;
                val_9 = val_7;
                val_8 = "Invalid path.";
                val_7 = new System.Object();
            }
            
            typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_10 = 0;
            typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_18 = 0;
            typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_20 = val_8;
            return (FileOperationResult)val_9;
        }
        public static Utils.Util.File.FileUtil.FileOperationResult WriteAllBytes(string path, byte[] bytes)
        {
            var val_7;
            var val_8;
            if((System.String.IsNullOrEmpty(value:  path)) != false)
            {
                    object val_2 = null;
                val_7 = "Invalid path";
                val_8 = val_2;
                val_2 = new System.Object();
            }
            else
            {
                    string val_3 = path.Replace(oldChar:  '\', newChar:  '/');
                if((Utils.Util.File.FileUtil.ValidatePath(path:  val_3)) != false)
            {
                    System.IO.File.WriteAllBytes(path:  val_3, bytes:  bytes);
                object val_5 = null;
                val_8 = val_5;
                val_5 = new System.Object();
                typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_10 = 1;
                typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_18 = 0;
                typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_20 = 0;
                return (FileOperationResult)val_8;
            }
            
                object val_6 = null;
                val_8 = val_6;
                val_7 = "Create directory failed.";
                val_6 = new System.Object();
            }
            
            typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_10 = 0;
            typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_18 = 0;
            typeof(FileUtil.FileOperationResult).__il2cppRuntimeField_20 = val_7;
            return (FileOperationResult)val_8;
        }
        private static bool ValidatePath(string path)
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  path)) != false)
            {
                    val_6 = 0;
                return (bool)val_6;
            }
            
            string val_3 = path.Substring(startIndex:  0, length:  path.LastIndexOf(value:  '/'));
            if((System.IO.Directory.Exists(path:  val_3)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            System.IO.DirectoryInfo val_5 = System.IO.Directory.CreateDirectory(path:  val_3);
            return System.IO.Directory.Exists(path:  val_3);
        }
        public FileUtil()
        {
        
        }
    
    }

}
