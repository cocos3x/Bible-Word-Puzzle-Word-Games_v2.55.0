using UnityEngine;

namespace Utils.Util
{
    public class PathUtil
    {
        // Methods
        public static bool IsRemote(string url)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input:  url, pattern:  "((http|ftp|https)://)(([a-zA-Z0-9\\._-]+\\.[a-zA-Z]{2,6})|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(:[0-9]{1,4})*(/[a-zA-Z0-9\\&%_\\./-~-]*)?");
        }
        public static string GetDirectoryName(string path)
        {
            string val_1 = System.IO.Path.GetDirectoryName(path:  path);
            if(val_1 == null)
            {
                    return val_1;
            }
            
            return val_1.Replace(oldChar:  '\', newChar:  '/');
        }
        public static string GetFileName(string path)
        {
            return System.IO.Path.GetFileName(path:  path);
        }
        public static string GetFileNameWithoutExtension(string path)
        {
            return System.IO.Path.GetFileNameWithoutExtension(path:  path);
        }
        public static string GetFolderPath(string assetPath)
        {
            return assetPath.Substring(startIndex:  0, length:  UnityEngine.Mathf.Clamp(value:  assetPath.LastIndexOf(value:  '/'), min:  0, max:  assetPath.m_stringLength - 1));
        }
        public static string Combine(string[] paths)
        {
            int val_5;
            var val_6;
            string val_7;
            if(paths.Length == 0)
            {
                    return 0;
            }
            
            if(<0)
            {
                goto label_9;
            }
            
            val_5 = paths.Length & 4294967295;
            val_6 = (long)paths.Length - 1;
            int val_2 = paths.Length - 2;
            label_10:
            val_7 = paths[val_6];
            if(val_7 != null)
            {
                goto label_5;
            }
            
            val_7 = System.String.alignConst;
            if(val_7 == 0)
            {
                goto label_6;
            }
            
            label_5:
            val_5 = paths.Length;
            label_6:
            paths[val_6] = val_7;
            if((val_2 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            val_6 = val_6 - 1;
            val_2 = val_2 - 1;
            if(val_6 < paths.Length)
            {
                goto label_10;
            }
            
            throw new IndexOutOfRangeException();
            label_9:
            string val_3 = System.IO.Path.Combine(paths:  paths);
            if(val_3 == null)
            {
                    return 0;
            }
            
            return val_3.Replace(oldChar:  '\', newChar:  '/');
        }
        public PathUtil()
        {
        
        }
    
    }

}
