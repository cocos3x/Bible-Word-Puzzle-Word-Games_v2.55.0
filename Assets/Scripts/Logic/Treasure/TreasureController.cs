using UnityEngine;

namespace Logic.Treasure
{
    public class TreasureController : Singleton<Logic.Treasure.TreasureController>
    {
        // Fields
        public readonly int MissionsCount;
        private readonly int MissionChestCount;
        private Data.Treasure.MissionsBean _missionsBean;
        private System.Collections.Generic.List<Data.Treasure.MissionItem> _nowMissionItems;
        private System.Collections.Generic.List<float> _oldMissionProgress;
        private float _oldMissionChestProgress;
        
        // Methods
        public void InitMissionData()
        {
            if(this.TreasureActivityIsOpen() == false)
            {
                    return;
            }
            
            this.InitMissions();
            this.UpdateOldProgress();
        }
        public bool TreasureActivityIsOpen()
        {
            return null.IsPassLevelForUnlockLevel(sectionIndex:  5, levelIndex:  1);
        }
        public void UpdateMissions()
        {
            System.Collections.Generic.List<Data.Treasure.MissionItem> val_9;
            int val_10;
            if(this._nowMissionItems == null)
            {
                    System.Collections.Generic.List<Data.Treasure.MissionItem> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Collections.Generic.List<Data.Treasure.MissionItem>(capacity:  this.MissionsCount);
                this._nowMissionItems = val_9;
            }
            
            this.InitMissions();
            if(this.MissionsCount < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            do
            {
                int val_5 = Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetMissionIndexForIndex(index:  0);
                val_10 = val_5;
                if(val_5 == 1)
            {
                    val_10 = UnityEngine.Random.Range(min:  0, max:  59957248);
                Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetMissionIndexForIndex(index:  0, dataIndex:  val_10);
            }
            
                int val_8 = UnityEngine.Mathf.Clamp(value:  val_10, min:  0, max:  this._missionsBean.missions.items - 1);
                Data.Treasure.MissionBean val_9 = this._missionsBean.missions;
                if(val_9 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + (val_8 << 3);
                if(0 < W26)
            {
                    this._nowMissionItems.set_Item(index:  0, value:  val_9);
            }
            else
            {
                    this._nowMissionItems.Add(item:  val_9);
            }
            
                val_9 = 0 + 1;
                val_10 = val_10 + (this._missionsBean.missions.items / this.MissionsCount);
            }
            while(val_9 < this.MissionsCount);
        
        }
        public void UpdateMissionItemForIndex(int missionIndex)
        {
            int val_10;
            int val_11;
            if(this._nowMissionItems == null)
            {
                    return;
            }
            
            if(this._nowMissionItems <= missionIndex)
            {
                    return;
            }
            
            int val_2 = Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetMissionIndexForIndex(index:  missionIndex);
            val_11 = val_2;
            if(val_2 == 1)
            {
                    int val_3 = W23 / this.MissionsCount;
                int val_4 = val_3 * missionIndex;
                val_11 = UnityEngine.Random.Range(min:  val_4, max:  val_4 + val_3);
            }
            
            val_10 = UnityEngine.Mathf.Clamp(value:  val_11, min:  0, max:  W23 - 1);
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetMissionIndexForIndex(index:  missionIndex, dataIndex:  val_10);
            if((public static Data.Treasure.TreasureDataManager Common.Singleton<Data.Treasure.TreasureDataManager>::get_Instance()) <= missionIndex)
            {
                    return;
            }
            
            Data.Treasure.MissionBean val_10 = this._missionsBean.missions;
            if(val_10 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (val_10 << 3);
            this._nowMissionItems.set_Item(index:  missionIndex, value:  val_10);
        }
        public Data.Treasure.MissionItem GetMissionItemForIndex(int missionIndex)
        {
            System.Collections.Generic.List<Data.Treasure.MissionItem> val_1;
            var val_2;
            bool val_1 = true;
            val_1 = this._nowMissionItems;
            if(val_1 != null)
            {
                    if(val_1 > missionIndex)
            {
                goto label_2;
            }
            
            }
            
            this.UpdateMissions();
            val_1 = this._nowMissionItems;
            label_2:
            if(val_1 > missionIndex)
            {
                    if(val_1 <= missionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (missionIndex << 3);
                val_2 = mem[(true + (missionIndex) << 3) + 32];
                val_2 = (true + (missionIndex) << 3) + 32;
                return (Data.Treasure.MissionItem)val_2;
            }
            
            val_2 = 0;
            return (Data.Treasure.MissionItem)val_2;
        }
        public int GetMissionRewardForIndex(int missionIndex)
        {
            int val_3;
            if((this.GetMissionItemForIndex(missionIndex:  missionIndex)) == null)
            {
                    return val_3;
            }
            
            Data.Treasure.MissionItem val_2 = this.GetMissionItemForIndex(missionIndex:  missionIndex);
            val_3 = val_2.reward;
            return val_3;
        }
        public int GetMissionTotalQuantity()
        {
            if(this._missionsBean == null)
            {
                    return 0;
            }
            
            if(this._missionsBean.missions != null)
            {
                    return (int)this._missionsBean.missions.totalQuantity;
            }
            
            throw new NullReferenceException();
        }
        public void UpdateOldProgress()
        {
            if(this._oldMissionProgress == null)
            {
                    this._oldMissionProgress = new System.Collections.Generic.List<System.Single>();
            }
            
            if(this.MissionsCount < 1)
            {
                goto label_2;
            }
            
            var val_8 = 0;
            label_10:
            if((this.GetMissionItemForIndex(missionIndex:  0)) == null)
            {
                goto label_3;
            }
            
            float val_7 = (float)val_2.quantity;
            val_7 = ((float)Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetFinishQuantityForIndex(index:  0)) / val_7;
            if(val_7 <= 1f)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            label_6:
            if(val_8 < this.MissionsCount)
            {
                    this._oldMissionProgress.set_Item(index:  0, value:  0f);
            }
            else
            {
                    this._oldMissionProgress.Add(item:  0f);
            }
            
            val_8 = val_8 + 1;
            if(val_8 < this.MissionsCount)
            {
                goto label_10;
            }
            
            label_2:
            float val_9 = (float)this.MissionChestCount;
            val_9 = ((float)Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.MissionsChestProgress) / val_9;
            this._oldMissionChestProgress = val_9;
        }
        public void UpdateOldProgressForIndex(int missionIndex)
        {
            if(this._oldMissionProgress == null)
            {
                    return;
            }
            
            if(true <= missionIndex)
            {
                    return;
            }
            
            this._oldMissionProgress.set_Item(index:  missionIndex, value:  this.GetNowMissionProgressForIndex(missionIndex:  missionIndex));
        }
        public float GetOldMissionProgressForIndex(int missionIndex)
        {
            bool val_1 = true;
            if(this._oldMissionProgress == null)
            {
                    return (float)(true + (missionIndex) << 2) + 32;
            }
            
            if(val_1 <= missionIndex)
            {
                    return (float)(true + (missionIndex) << 2) + 32;
            }
            
            if(val_1 <= missionIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (missionIndex << 2);
            return (float)(true + (missionIndex) << 2) + 32;
        }
        public float GetNowMissionProgressForIndex(int missionIndex)
        {
            if((this.GetMissionItemForIndex(missionIndex:  missionIndex)) == null)
            {
                    return 0f;
            }
            
            float val_4 = (float)val_1.quantity;
            val_4 = ((float)Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetFinishQuantityForIndex(index:  missionIndex)) / val_4;
            return 0f;
        }
        public float GetOldMissionChestProgress()
        {
            return (float)this._oldMissionChestProgress;
        }
        public float GetNowMissionChestProgress()
        {
            float val_3;
            if(this._missionsBean == null)
            {
                    return (float)val_3;
            }
            
            if(this._missionsBean.missions.totalQuantity < 1)
            {
                    return (float)val_3;
            }
            
            if(this._missionsBean != null)
            {
                    val_3 = (float)this._missionsBean.missions.totalQuantity;
            }
            else
            {
                    val_3 = 0f;
            }
            
            val_3 = ((float)Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.MissionsChestProgress) / val_3;
            return (float)val_3;
        }
        public int GetMissionChestReward()
        {
            var val_5;
            if((Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.FinishMissionsChestCount) == 1)
            {
                    val_5 = 60;
                return (int)val_5;
            }
            
            int val_3 = UnityEngine.Random.Range(min:  3, max:  7);
            val_5 = (val_3 + (val_3 << 2)) << 1;
            return (int)val_5;
        }
        public bool CheckHaveFinishMission()
        {
            var val_4;
            if(this.MissionsCount < 1)
            {
                goto label_0;
            }
            
            var val_4 = 0;
            label_2:
            if((this.GetNowMissionProgressForIndex(missionIndex:  0)) >= 1f)
            {
                goto label_1;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < this.MissionsCount)
            {
                goto label_2;
            }
            
            label_0:
            var val_3 = (this.GetNowMissionChestProgress() >= 1f) ? 1 : 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
        public void FinishMissionForIndex(int missionIndex)
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "mission", action:  "gain", label:  System.String.Format(format:  "mission_{0}", arg0:  (Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetMissionIndexForIndex(index:  missionIndex)) + 1), value:  0);
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.GainCoinsTemp(value:  this.GetMissionRewardForIndex(missionIndex:  missionIndex));
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetMissionIndexForIndex(index:  missionIndex, dataIndex:  0);
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetFinishQuantityForIndex(index:  missionIndex, count:  0);
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.AddMissionsChestProgress();
            this.UpdateOldProgressForIndex(missionIndex:  missionIndex);
            this.UpdateMissionItemForIndex(missionIndex:  missionIndex);
            Message.Messager.Dispatch(cmd:  49);
        }
        public void FinishMissionChest()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "mission", action:  "gain", label:  "chest", value:  0);
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.AddFinishMissionsChestCount();
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.SetMissionsChestProgress(count:  0);
            this._oldMissionChestProgress = 0f;
            Message.Messager.Dispatch(cmd:  49);
        }
        public void FinishWords()
        {
            if(this.TreasureActivityIsOpen() == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.AddFinishQuantityForIndex(index:  0);
            this.CheckFinishMissionForIndex(missionIndex:  0);
            Message.Messager.Dispatch(cmd:  48);
        }
        public void FinishGodBeWithYou()
        {
            if(this.TreasureActivityIsOpen() == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.AddFinishQuantityForIndex(index:  1);
            this.CheckFinishMissionForIndex(missionIndex:  1);
            Message.Messager.Dispatch(cmd:  48);
        }
        public void FinishLevels()
        {
            if(this.TreasureActivityIsOpen() == false)
            {
                    return;
            }
            
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) == false)
            {
                    return;
            }
            
            Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.AddFinishQuantityForIndex(index:  2);
            this.CheckFinishMissionForIndex(missionIndex:  2);
            Message.Messager.Dispatch(cmd:  48);
        }
        private void InitMissions()
        {
            if(this._missionsBean != null)
            {
                    return;
            }
            
            this._missionsBean = UnityEngine.JsonUtility.FromJson<Data.Treasure.MissionsBean>(json:  Common.EzFile.RijndaelDecrypt(pString:  Resource.ResManager.GetConfig(configName:  "Config/Game/Missions/missions").text, pKey:  ""));
        }
        private void CheckFinishMissionForIndex(int missionIndex)
        {
            if((this.GetMissionItemForIndex(missionIndex:  missionIndex)) == null)
            {
                    return;
            }
            
            if((Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetFinishQuantityForIndex(index:  missionIndex)) != val_1.quantity)
            {
                    return;
            }
            
            Platform.Analytics.EzAnalytics.LogEvent(category:  "mission", action:  "finish", label:  System.String.Format(format:  "mission_{0}", arg0:  (Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.GetMissionIndexForIndex(index:  missionIndex)) + 1), value:  0);
        }
        public TreasureController()
        {
            this.MissionsCount = 3;
            this.MissionChestCount = 5;
        }
    
    }

}
