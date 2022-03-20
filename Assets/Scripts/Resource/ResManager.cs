using UnityEngine;

namespace Resource
{
    public static class ResManager
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<string, Resource.Pool.AtlasPool> AtlasPools;
        
        // Methods
        public static void ForceUnloadAssets()
        {
            UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
        }
        public static T Load<T>(string path, UnityEngine.Transform parent)
        {
            IntPtr val_5;
            var val_6;
            val_5 = 1152921504619626496;
            val_6 = 0;
            if(path == 0)
            {
                    return (object)val_6;
            }
            
            val_5 = null;
            if((System.Type.op_Inequality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5}))) != false)
            {
                    val_6 = path;
                return (object)val_6;
            }
        
        }
        private static Resource.Pool.AtlasPool GetAtlasPool(string atlas)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((Resource.ResManager.AtlasPools.TryGetValue(key:  atlas, value: out  0)) == true)
            {
                    return val_3;
            }
            
            Resource.Pool.AtlasPool val_3 = new Resource.Pool.AtlasPool(atlasName:  atlas);
            val_5 = null;
            val_5 = null;
            Resource.ResManager.AtlasPools.Add(key:  atlas, value:  val_3);
            return val_3;
        }
        public static UnityEngine.Sprite GetSpriteFromPool(string atlas, string spriteName)
        {
            return Resource.ResManager.GetAtlasPool(atlas:  atlas).LoadSprite(spriteName:  spriteName);
        }
        public static UnityEngine.TextAsset GetConfig(string configName)
        {
            UnityEngine.TextAsset val_1 = Resource.ResManager.Load<UnityEngine.TextAsset>(path:  configName, parent:  0);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = configName;
            Log.D.Error(message:  "[ResManager] load config fail {0}", args:  val_3);
            return val_1;
        }
        public static UnityEngine.Texture2D GetTextureForUrl(string url, System.Action<UnityEngine.Texture2D> callback)
        {
            var val_7;
            typeof(ResManager.<>c__DisplayClass9_0).__il2cppRuntimeField_28 = callback;
            val_7 = null;
            val_7 = null;
            typeof(ResManager.<>c__DisplayClass9_0).__il2cppRuntimeField_18 = System.IO.Path.Combine(path1:  Logic.Define.ApplicationConfig.TextureCachePath, path2:  Utils.Util.MD5Util.GetStringMD5(target:  url));
            UnityEngine.Networking.UnityWebRequest val_4 = UnityEngine.Networking.UnityWebRequestTexture.GetTexture(uri:  url);
            typeof(ResManager.<>c__DisplayClass9_0).__il2cppRuntimeField_10 = val_4;
            typeof(ResManager.<>c__DisplayClass9_0).__il2cppRuntimeField_20 = 0;
            val_4.SendWebRequest().add_completed(value:  new System.Action<UnityEngine.AsyncOperation>(object:  new System.Object(), method:  System.Void ResManager.<>c__DisplayClass9_0::<GetTextureForUrl>b__0(UnityEngine.AsyncOperation _)));
            return (UnityEngine.Texture2D)typeof(ResManager.<>c__DisplayClass9_0).__il2cppRuntimeField_20;
        }
        private static ResManager()
        {
            Resource.ResManager.AtlasPools = new System.Collections.Generic.Dictionary<System.String, Resource.Pool.AtlasPool>();
        }
    
    }

}
