using UnityEngine;

namespace I2.Loc
{
    public class ResourceManager : MonoBehaviour
    {
        // Fields
        private static I2.Loc.ResourceManager mInstance;
        public System.Collections.Generic.List<I2.Loc.IResourceManager_Bundles> mBundleManagers;
        public UnityEngine.Object[] Assets;
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Object> mResourcesCache;
        
        // Properties
        public static I2.Loc.ResourceManager pInstance { get; }
        
        // Methods
        public static I2.Loc.ResourceManager get_pInstance()
        {
            bool val_15 = UnityEngine.Object.op_Equality(x:  I2.Loc.ResourceManager.mInstance, y:  0);
            if(I2.Loc.ResourceManager.mInstance == 0)
            {
                    I2.Loc.ResourceManager.mInstance = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            if(I2.Loc.ResourceManager.mInstance == 0)
            {
                    System.Type[] val_6 = new System.Type[1];
                val_6[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.GameObject val_8 = new UnityEngine.GameObject(name:  "I2ResourceManager", components:  val_6);
                hideFlags = hideFlags | 61;
                I2.Loc.ResourceManager.mInstance = GetComponent<I2.Loc.ResourceManager>();
                UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  0, method:  public static System.Void I2.Loc.ResourceManager::MyOnLevelWasLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
            }
            
            if(val_15 == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
            }
            
            val_15 = I2.Loc.ResourceManager.mInstance.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_15);
            return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
        }
        public static void MyOnLevelWasLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            I2.Loc.ResourceManager.pInstance.CleanResourceCache();
            bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
        }
        public T GetAsset<T>(string Name)
        {
            UnityEngine.Object val_3;
            UnityEngine.Object val_1 = this.FindAsset(Name:  Name);
            if(X0 == false)
            {
                goto label_4;
            }
            
            val_3 = X0;
            if(X0 == true)
            {
                goto label_5;
            }
            
            label_4:
            val_3 = 0;
            label_5:
            if(val_3 != 0)
            {
                    return (I2.Loc.LanguageSourceAsset)val_3;
            }
        
        }
        private UnityEngine.Object FindAsset(string Name)
        {
            UnityEngine.Object val_4;
            if((this.Assets == null) || (this.Assets.Length < 1))
            {
                    return 0;
            }
            
            var val_8 = 4;
            do
            {
                var val_1 = val_8 - 4;
                val_4 = this.Assets[0];
                if(val_4 != 0)
            {
                    if((System.String.op_Equality(a:  this.Assets[0].name, b:  Name)) == true)
            {
                goto label_10;
            }
            
            }
            
                if((val_8 - 3) >= (long)this.Assets.Length)
            {
                    return 0;
            }
            
                val_8 = val_8 + 1;
            }
            while(this.Assets != null);
            
            throw new NullReferenceException();
            label_10:
            var val_6 = val_8 - 4;
            UnityEngine.Object val_9 = this.Assets[0];
            return 0;
        }
        public bool HasAsset(UnityEngine.Object Obj)
        {
            UnityEngine.Object[] val_3 = this.Assets;
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            val_3 = ((System.Array.IndexOf<UnityEngine.Object>(array:  val_3 = this.Assets, value:  Obj)) >> 31) ^ 1;
            return (bool)val_3;
        }
        public T LoadFromResources<T>(string Path)
        {
            string val_18;
            UnityEngine.Object val_19;
            UnityEngine.Object val_20;
            System.Collections.Generic.Dictionary<System.String, UnityEngine.Object> val_21;
            var val_22;
            var val_23;
            val_18 = Path;
            val_19 = this;
            UnityEngine.Object val_2 = 0;
            if((System.String.IsNullOrEmpty(value:  val_18)) == false)
            {
                goto label_1;
            }
            
            label_82:
            val_20 = 0;
            return (object)val_20;
            label_1:
            val_21 = this.mResourcesCache;
            if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(((val_21.TryGetValue(key:  val_18, value: out  val_2)) == false) || (val_2 == 0))
            {
                goto label_7;
            }
            
            val_19 = X0;
            val_22 = mem[__RuntimeMethodHiddenParam + 48];
            val_22 = __RuntimeMethodHiddenParam + 48;
            if(val_19 == false)
            {
                goto label_82;
            }
            
            val_20 = X0;
            if(X0 == true)
            {
                    return (object)val_20;
            }
            
            val_21 = val_19;
            label_7:
            if(val_18 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_18.EndsWith(value:  "]", comparisonType:  5)) == false)
            {
                goto label_13;
            }
            
            string val_19 = "[";
            int val_6 = val_18.LastIndexOf(value:  val_19, comparisonType:  5);
            var val_18 = -2;
            val_18 = val_18 - val_6;
            val_19 = val_6 + 1;
            string val_9 = val_18.Substring(startIndex:  0, length:  val_6);
            val_18 = val_9;
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(W24 < 1)
            {
                goto label_26;
            }
            
            if(W24 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_23 = 0;
            label_21:
            string val_10 = System.String.__il2cppRuntimeField_byval_arg.name;
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_10.Equals(value:  val_18.Substring(startIndex:  val_19, length:  val_18 + Path.m_stringLength))) == true)
            {
                goto label_19;
            }
            
            val_23 = val_23 + 1;
            if(val_23 >= W24)
            {
                goto label_26;
            }
            
            if(val_23 < (__RuntimeMethodHiddenParam + 48 + 8))
            {
                goto label_21;
            }
            
            throw new IndexOutOfRangeException();
            label_13:
            UnityEngine.Object val_13 = UnityEngine.Resources.Load(path:  val_18, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
            if(X0 == false)
            {
                goto label_26;
            }
            
            val_20 = X0;
            if(X0 == true)
            {
                goto label_28;
            }
            
            label_26:
            val_20 = 0;
            goto label_28;
            label_19:
            if(val_23 >= (__RuntimeMethodHiddenParam + 48 + 8))
            {
                    throw new IndexOutOfRangeException();
            }
            
            label_28:
            val_22 = 1152921504689328128;
            val_21 = System.String.__il2cppRuntimeField_byval_arg;
            if(val_21 == 0)
            {
                    if(val_19 == false)
            {
                    throw new NullReferenceException();
            }
            
                val_20 = val_19;
            }
            
            if(val_20 == 0)
            {
                    return (object)val_20;
            }
            
            val_21 = mem[X0 + 40];
            val_21 = X0 + 40;
            if(val_21 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_21.set_Item(key:  val_18, value:  val_20);
            return (object)val_20;
        }
        public T LoadFromBundle<T>(string path)
        {
            var val_4;
            UnityEngine.Object val_5;
            bool val_4 = true;
            if(W25 < 1)
            {
                goto label_22;
            }
            
            var val_9 = 0;
            label_23:
            if(val_9 >= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            var val_5 = (true + 0) + 32;
            if(val_5 == 0)
            {
                goto label_4;
            }
            
            if(val_9 >= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            var val_8 = ((true + 0) + 32 + 0) + 32;
            if((((true + 0) + 32 + 0) + 32 + 294) == 0)
            {
                goto label_13;
            }
            
            var val_6 = ((true + 0) + 32 + 0) + 32 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_12:
            if(((((true + 0) + 32 + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (((true + 0) + 32 + 0) + 32 + 294))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_8 = val_8 + (((((true + 0) + 32 + 0) + 32 + 176 + 8)) << 4);
            val_4 = val_8 + 304;
            label_13:
            UnityEngine.Object val_2 = ((true + 0) + 32 + 0) + 32.LoadFromBundle(path:  path, assetType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            if(X0 == false)
            {
                goto label_16;
            }
            
            val_5 = X0;
            if(X0 == true)
            {
                goto label_17;
            }
            
            goto label_18;
            label_16:
            val_5 = 0;
            label_17:
            if(val_5 != 0)
            {
                    return (object)val_5;
            }
            
            label_4:
            val_9 = val_9 + 1;
            if(val_9 >= X25)
            {
                goto label_22;
            }
            
            if(this.mBundleManagers != null)
            {
                goto label_23;
            }
            
            throw new NullReferenceException();
            label_22:
            val_5 = 0;
            return (object)val_5;
            label_18:
        }
        public void CleanResourceCache()
        {
            this.mResourcesCache.Clear();
            UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
            this.CancelInvoke();
        }
        public ResourceManager()
        {
            var val_3;
            this.mBundleManagers = new System.Collections.Generic.List<I2.Loc.IResourceManager_Bundles>();
            val_3 = null;
            val_3 = null;
            this.mResourcesCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer._ordinal);
        }
    
    }

}
