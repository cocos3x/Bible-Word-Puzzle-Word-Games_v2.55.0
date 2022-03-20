using UnityEngine;

namespace Data.Treasure
{
    public class TreasureDataManager : Singleton<Data.Treasure.TreasureDataManager>
    {
        // Fields
        private string _tempName;
        
        // Properties
        public int FinishMissionsChestCount { get; set; }
        public int MissionsChestProgress { get; set; }
        public System.Collections.Generic.Dictionary<string, int> MissionProgress { get; }
        public bool ShouldShowTreasureGuide { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public int get_FinishMissionsChestCount()
        {
            return (int)Store.TreasureData.__il2cppRuntimeField_name;
        }
        private void set_FinishMissionsChestCount(int value)
        {
            typeof(Store.TreasureData).__il2cppRuntimeField_10 = value;
        }
        public int get_MissionsChestProgress()
        {
            return (int)typeof(Store.TreasureData).__il2cppRuntimeField_14;
        }
        private void set_MissionsChestProgress(int value)
        {
            typeof(Store.TreasureData).__il2cppRuntimeField_14 = value;
        }
        public System.Collections.Generic.Dictionary<string, int> get_MissionProgress()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)Store.TreasureData.__il2cppRuntimeField_namespaze;
        }
        public bool get_ShouldShowTreasureGuide()
        {
            return (bool)Store.TreasureData.__il2cppRuntimeField_byval_arg;
        }
        private void set_ShouldShowTreasureGuide(bool value)
        {
            typeof(Store.TreasureData).__il2cppRuntimeField_20 = value;
        }
        public void AddFinishMissionsChestCount()
        {
            int val_1 = this.FinishMissionsChestCount;
            val_1.FinishMissionsChestCount = val_1 + 1;
        }
        public void AddMissionsChestProgress()
        {
            int val_1 = this.MissionsChestProgress;
            val_1.MissionsChestProgress = val_1 + 1;
        }
        public void SetMissionsChestProgress(int count)
        {
            this.MissionsChestProgress = count;
        }
        public int GetFinishQuantityForIndex(int index)
        {
            string val_1 = System.String.Format(format:  "f_{0}", arg0:  index);
            this._tempName = val_1;
            int val_3 = 0;
            bool val_4 = val_1.MissionProgress.TryGetValue(key:  this._tempName, value: out  val_3);
            return val_3;
        }
        public void SetFinishQuantityForIndex(int index, int count)
        {
            string val_1 = System.String.Format(format:  "f_{0}", arg0:  index);
            this._tempName = val_1;
            bool val_3 = val_1.MissionProgress.ContainsKey(key:  this._tempName);
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = val_3.MissionProgress;
            if(val_3 != false)
            {
                    val_4.set_Item(key:  this._tempName, value:  count);
                return;
            }
            
            val_4.Add(key:  this._tempName, value:  count);
        }
        public void AddFinishQuantityForIndex(int index)
        {
            string val_1 = System.String.Format(format:  "f_{0}", arg0:  index);
            this._tempName = val_1;
            bool val_3 = val_1.MissionProgress.ContainsKey(key:  this._tempName);
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = val_3.MissionProgress;
            if(val_3 != false)
            {
                    val_4.set_Item(key:  this._tempName, value:  val_4.Item[this._tempName] + 1);
                return;
            }
            
            val_4.Add(key:  this._tempName, value:  1);
        }
        public int GetMissionIndexForIndex(int index)
        {
            var val_6;
            string val_1 = System.String.Format(format:  "i_{0}", arg0:  index);
            this._tempName = val_1;
            bool val_3 = val_1.MissionProgress.ContainsKey(key:  this._tempName);
            if(val_3 != false)
            {
                    int val_5 = val_3.MissionProgress.Item[this._tempName];
                return (int)val_6;
            }
            
            val_6 = 0;
            return (int)val_6;
        }
        public void SetMissionIndexForIndex(int index, int dataIndex)
        {
            string val_1 = System.String.Format(format:  "i_{0}", arg0:  index);
            this._tempName = val_1;
            bool val_3 = val_1.MissionProgress.ContainsKey(key:  this._tempName);
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = val_3.MissionProgress;
            if(val_3 != false)
            {
                    val_4.set_Item(key:  this._tempName, value:  dataIndex);
                return;
            }
            
            val_4.Add(key:  this._tempName, value:  dataIndex);
        }
        public void SetShouldShowTreasureGuide(bool isShould)
        {
            this.ShouldShowTreasureGuide = isShould;
        }
        public TreasureDataManager()
        {
        
        }
    
    }

}
