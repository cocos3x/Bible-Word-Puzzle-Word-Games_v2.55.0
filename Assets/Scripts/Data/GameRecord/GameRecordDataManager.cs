using UnityEngine;

namespace Data.GameRecord
{
    public class GameRecordDataManager : Singleton<Data.GameRecord.GameRecordDataManager>
    {
        // Properties
        public string IsTestLevelBoxProgress { get; set; }
        public System.Collections.Generic.List<string> LevelBoxProgress { get; set; }
        public System.Collections.Generic.List<string> LevelBoxProgressTest { get; set; }
        public System.Collections.Generic.List<string> GameRightAnswerList { get; }
        public bool IsInQuizLevel { get; set; }
        public int DifficultyPartyIndex { get; }
        public int DifficultyLevelIndex { get; set; }
        
        // Methods
        public void Init()
        {
        
        }
        public string get_IsTestLevelBoxProgress()
        {
            return (string)Store.GameRecordData.__il2cppRuntimeField_name;
        }
        private void set_IsTestLevelBoxProgress(string value)
        {
            typeof(Store.GameRecordData).__il2cppRuntimeField_10 = value;
        }
        public System.Collections.Generic.List<string> get_LevelBoxProgress()
        {
            return (System.Collections.Generic.List<System.String>)Store.GameRecordData.__il2cppRuntimeField_namespaze;
        }
        private void set_LevelBoxProgress(System.Collections.Generic.List<string> value)
        {
            typeof(Store.GameRecordData).__il2cppRuntimeField_18 = value;
        }
        public System.Collections.Generic.List<string> get_LevelBoxProgressTest()
        {
            return (System.Collections.Generic.List<System.String>)Store.GameRecordData.__il2cppRuntimeField_byval_arg;
        }
        private void set_LevelBoxProgressTest(System.Collections.Generic.List<string> value)
        {
            typeof(Store.GameRecordData).__il2cppRuntimeField_20 = value;
        }
        public System.Collections.Generic.List<string> get_GameRightAnswerList()
        {
            return (System.Collections.Generic.List<System.String>)typeof(Store.GameRecordData).__il2cppRuntimeField_28;
        }
        public bool get_IsInQuizLevel()
        {
            return (bool)Store.GameRecordData.__il2cppRuntimeField_this_arg;
        }
        private void set_IsInQuizLevel(bool value)
        {
            typeof(Store.GameRecordData).__il2cppRuntimeField_30 = value;
        }
        public int get_DifficultyPartyIndex()
        {
            return (int)typeof(Store.GameRecordData).__il2cppRuntimeField_34;
        }
        public int get_DifficultyLevelIndex()
        {
            return (int)typeof(Store.GameRecordData).__il2cppRuntimeField_38;
        }
        private void set_DifficultyLevelIndex(int value)
        {
            typeof(Store.GameRecordData).__il2cppRuntimeField_38 = value;
        }
        public void SaveLevelBoxProgress(System.Collections.Generic.List<string> data)
        {
            if(data != null)
            {
                    this.LevelBoxProgress = data;
                return;
            }
            
            this.LevelBoxProgress.Clear();
        }
        public System.Collections.Generic.List<string> GetLevelBoxProgress()
        {
            return this.LevelBoxProgress;
        }
        public void SaveLevelBoxProgressTest(System.Collections.Generic.List<string> data)
        {
            if(data != null)
            {
                    this.LevelBoxProgressTest = data;
                return;
            }
            
            this.LevelBoxProgressTest.Clear();
        }
        public System.Collections.Generic.List<string> GetLevelBoxProgressTest()
        {
            return this.LevelBoxProgressTest;
        }
        public void SaveGameRightAnswerList(System.Collections.Generic.List<string> data)
        {
            System.Collections.Generic.List<System.String> val_1 = this.GameRightAnswerList;
            val_1.Clear();
            if(data == null)
            {
                    return;
            }
            
            if(1152921508357928576 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                if(val_3 >= 1152921508357928576)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1.GameRightAnswerList.Add(item:  "mission");
                val_3 = val_3 + 1;
            }
            while(val_3 < 21133048);
        
        }
        public System.Collections.Generic.List<string> GetGameRightAnswerList()
        {
            return this.GameRightAnswerList;
        }
        public bool GetLevelBoxProgressIsTest()
        {
            return System.String.op_Equality(a:  this.IsTestLevelBoxProgress, b:  "Test");
        }
        public void SetLevelBoxProgressIsTest(string value)
        {
            this.IsTestLevelBoxProgress = value;
        }
        public void SetInQuizLevel(bool isIn)
        {
            this.IsInQuizLevel = isIn;
        }
        public void SetDifficultyLevelIndex(int index)
        {
            int val_4 = this.DifficultyPartyIndex;
            int val_2 = Logic.Game.GameManager.gameLevel.GetDifficultyLevelCount(partIndex:  val_4);
            if(val_2 < 1)
            {
                    return;
            }
            
            val_4 = index - ((index / val_2) * val_2);
            val_2.DifficultyLevelIndex = val_4;
        }
        public int GetDifficultyLevelIndex()
        {
            int val_5 = this.DifficultyPartyIndex;
            int val_2 = Logic.Game.GameManager.gameLevel.GetDifficultyLevelCount(partIndex:  val_5);
            if(val_2 < 1)
            {
                    return val_3.DifficultyLevelIndex;
            }
            
            int val_3 = val_2.DifficultyLevelIndex;
            val_5 = val_3 - ((val_3 / val_2) * val_2);
            val_3.DifficultyLevelIndex = val_5;
            return val_3.DifficultyLevelIndex;
        }
        public GameRecordDataManager()
        {
        
        }
    
    }

}
