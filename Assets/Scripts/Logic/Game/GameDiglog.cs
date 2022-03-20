using UnityEngine;

namespace Logic.Game
{
    public class GameDiglog : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, View.Dialog.Common.Dialog> dialogPrefabs;
        private System.Collections.Generic.Dictionary<string, View.Dialog.Common.Dialog> dialogPool;
        private System.Collections.Generic.Dictionary<string, View.Dialog.Common.Dialog> dialogShowings;
        private System.Collections.Generic.List<string> dialogShowSequence;
        private string ResourcesFolder;
        private const string PrefabFullPath = "Prefab/Dialog/{0}/{1}Dialog";
        private const string PrefabPath = "Prefab/Dialog/{0}Dialog";
        private string NowPrefabPath;
        
        // Methods
        public View.Dialog.Common.Dialog Open(string name, Logic.Define.DialogType type = 0)
        {
            string val_21;
            View.Dialog.Common.Dialog val_22;
            UnityEngine.Object val_23;
            val_21 = name;
            if((val_21.EndsWith(value:  "Dialog")) != false)
            {
                    val_21 = val_21.Replace(oldValue:  "Dialog", newValue:  "");
            }
            
            if(type == 2)
            {
                    if((this.IsDialogShowingSameType(type:  2)) != false)
            {
                    val_22 = 0;
                return val_22;
            }
            
            }
            
            View.Dialog.Common.Dialog val_4 = 0;
            bool val_5 = this.dialogPool.TryGetValue(key:  val_21, value: out  val_4);
            if(val_4 == 0)
            {
                    if((this.dialogPrefabs.ContainsKey(key:  val_21)) != true)
            {
                    string val_8 = System.String.Format(format:  "Prefab/Dialog/{0}/{1}Dialog", arg0:  val_21, arg1:  val_21);
                this.NowPrefabPath = val_8;
                val_23 = UnityEngine.Resources.Load<View.Dialog.Common.Dialog>(path:  val_8);
                if(val_23 == 0)
            {
                    val_23 = UnityEngine.Resources.Load<View.Dialog.Common.Dialog>(path:  System.String.Format(format:  "Prefab/Dialog/{0}Dialog", arg0:  val_21));
            }
            
                this.dialogPrefabs.Add(key:  val_21, value:  val_23);
            }
            
                if(this.dialogPrefabs.Item[val_21] != 0)
            {
                    View.Dialog.Common.Dialog val_16 = UnityEngine.Object.Instantiate<View.Dialog.Common.Dialog>(original:  this.dialogPrefabs.Item[val_21]);
                val_16.name = val_21;
                if((this.dialogPool.ContainsKey(key:  val_21)) != false)
            {
                    this.dialogPool.set_Item(key:  val_21, value:  val_16);
            }
            else
            {
                    this.dialogPool.Add(key:  val_21, value:  val_16);
            }
            
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_16)) != false)
            {
                    val_16.SetDialogType(type:  type);
                if(type != 1)
            {
                    if((this.dialogShowings.ContainsKey(key:  val_21)) != true)
            {
                    this.dialogShowings.Add(key:  val_21, value:  val_16);
                this.dialogShowSequence.Add(item:  val_21);
            }
            
            }
            
                val_16.transform.SetAsLastSibling();
            }
            
            val_22 = val_16;
            return val_22;
        }
        public View.Dialog.Common.Dialog OpenAddParams(string name, object[] pars)
        {
            View.Dialog.Common.Dialog val_1 = this.Open(name:  name, type:  0);
            if(pars.Length == 0)
            {
                    return val_1;
            }
            
            if(val_1 == 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        public View.Dialog.Common.Dialog OpenAddParams(string name, Logic.Define.DialogType type, object[] pars)
        {
            View.Dialog.Common.Dialog val_1 = this.Open(name:  name, type:  type);
            if(pars.Length == 0)
            {
                    return val_1;
            }
            
            if(val_1 == 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        public bool DestroyDialog(View.Dialog.Common.Dialog dialog)
        {
            return this.DestroyDialog(name:  dialog.name);
        }
        private bool DestroyDialog(string name)
        {
            string val_8;
            var val_9;
            val_8 = name;
            if((val_8.EndsWith(value:  "Dialog")) != false)
            {
                    val_8 = val_8.Replace(oldValue:  "Dialog", newValue:  "");
            }
            
            if((this.dialogShowings.ContainsKey(key:  val_8)) != false)
            {
                    bool val_4 = this.dialogShowings.Remove(key:  val_8);
                bool val_5 = this.dialogShowSequence.Remove(item:  val_8);
            }
            
            if((this.dialogPool.ContainsKey(key:  val_8)) != false)
            {
                    bool val_7 = this.dialogPool.Remove(key:  val_8);
                val_9 = 1;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public void DisPlayDialog(View.Dialog.Common.Dialog dialog)
        {
            if((this.dialogShowings.ContainsKey(key:  dialog.name)) == false)
            {
                    return;
            }
            
            bool val_4 = this.dialogShowings.Remove(key:  dialog.name);
            bool val_6 = this.dialogShowSequence.Remove(item:  this.name);
        }
        public bool IsDialogShowing(string dialogName)
        {
            string val_7 = dialogName;
            if((System.String.IsNullOrEmpty(value:  val_7 = dialogName)) != true)
            {
                    if((val_7.EndsWith(value:  "Dialog")) != false)
            {
                    val_7 = val_7.Replace(oldValue:  "Dialog", newValue:  "");
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  val_7)) == false)
            {
                    return this.dialogShowings.ContainsKey(key:  val_7);
            }
            
            return (bool)(this.dialogShowings.Count > 0) ? 1 : 0;
        }
        public bool IsDialogShowingSameType(Logic.Define.DialogType type)
        {
            var val_4;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.dialogShowings.GetEnumerator();
            label_7:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                goto label_7;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(1 != type)
            {
                goto label_7;
            }
            
            val_4 = 1;
            goto label_8;
            label_2:
            val_4 = 0;
            label_8:
            0.Dispose();
            return (bool)val_4;
        }
        public bool IsDialogShowingSameTypeLast(Logic.Define.DialogType type, string name)
        {
            string val_6;
            UnityEngine.Object val_7;
            var val_8;
            val_6 = name;
            int val_1 = this.dialogShowSequence.IndexOf(item:  val_6);
            if((val_1 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_6 = val_1;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.dialogShowings.GetEnumerator();
            label_11:
            if(0.MoveNext() == false)
            {
                goto label_4;
            }
            
            val_7 = 0;
            if(val_7 == 0)
            {
                goto label_11;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(1 != type)
            {
                goto label_11;
            }
            
            val_7 = this.dialogShowSequence;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_7.IndexOf(item:  0)) <= val_6)
            {
                goto label_11;
            }
            
            val_8 = 0;
            goto label_12;
            label_4:
            val_8 = 1;
            label_12:
            0.Dispose();
            return (bool)val_8;
            label_2:
            val_8 = 0;
            return (bool)val_8;
        }
        public GameDiglog()
        {
            this.dialogPrefabs = new System.Collections.Generic.Dictionary<System.String, View.Dialog.Common.Dialog>();
            this.dialogPool = new System.Collections.Generic.Dictionary<System.String, View.Dialog.Common.Dialog>();
            this.dialogShowings = new System.Collections.Generic.Dictionary<System.String, View.Dialog.Common.Dialog>();
            this.dialogShowSequence = new System.Collections.Generic.List<System.String>();
            this.ResourcesFolder = "";
            this.NowPrefabPath = "";
        }
    
    }

}
