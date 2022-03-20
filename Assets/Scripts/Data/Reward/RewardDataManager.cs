using UnityEngine;

namespace Data.Reward
{
    public class RewardDataManager : Singleton<Data.Reward.RewardDataManager>
    {
        // Fields
        private System.Collections.Generic.List<int> _rewards_1;
        private System.Collections.Generic.List<float> _chances_1;
        private System.Collections.Generic.List<int> _rewards_2;
        private System.Collections.Generic.List<float> _chances_2;
        private System.DateTime _lastRewardDateTime;
        private Data.Reward.RecallRewardType <RecallRewardType>k__BackingField;
        
        // Properties
        public string LastRewardDate { get; set; }
        public int RewardDayCount { get; set; }
        public int RewardVideoCount { get; set; }
        public int BoxLowestRewardTotal1 { get; set; }
        public int BoxLowestRewardTotal2 { get; set; }
        public System.DateTime LastRewardDateTime { get; set; }
        public Data.Reward.RecallRewardType RecallRewardType { get; }
        
        // Methods
        public void Init()
        {
            System.DateTime val_2 = Common.EzDate.GetDateTime(dateString:  this.LastRewardDate, format:  0);
            this._lastRewardDateTime = val_2;
            bool val_3 = Common.GlobalMethods.IsToday(des:  new System.DateTime() {dateData = val_2.dateData}, res:  new System.Nullable<System.DateTime>() {HasValue = false});
            if(val_3 != false)
            {
                    return;
            }
            
            val_3.RewardDayCount = 0;
        }
        public string get_LastRewardDate()
        {
            return (string)Store.RewardData.__il2cppRuntimeField_name;
        }
        private void set_LastRewardDate(string value)
        {
            typeof(Store.RewardData).__il2cppRuntimeField_10 = value;
        }
        public int get_RewardDayCount()
        {
            return (int)Store.RewardData.__il2cppRuntimeField_namespaze;
        }
        private void set_RewardDayCount(int value)
        {
            typeof(Store.RewardData).__il2cppRuntimeField_18 = value;
        }
        public int get_RewardVideoCount()
        {
            return (int)typeof(Store.RewardData).__il2cppRuntimeField_1C;
        }
        private void set_RewardVideoCount(int value)
        {
            typeof(Store.RewardData).__il2cppRuntimeField_1C = value;
        }
        public int get_BoxLowestRewardTotal1()
        {
            return (int)Store.RewardData.__il2cppRuntimeField_byval_arg;
        }
        private void set_BoxLowestRewardTotal1(int value)
        {
            typeof(Store.RewardData).__il2cppRuntimeField_20 = value;
        }
        public int get_BoxLowestRewardTotal2()
        {
            return (int)typeof(Store.RewardData).__il2cppRuntimeField_24;
        }
        private void set_BoxLowestRewardTotal2(int value)
        {
            typeof(Store.RewardData).__il2cppRuntimeField_24 = value;
        }
        public System.DateTime get_LastRewardDateTime()
        {
            return (System.DateTime)this._lastRewardDateTime;
        }
        public void set_LastRewardDateTime(System.DateTime value)
        {
            this._lastRewardDateTime = value;
            string val_1 = Common.EzDate.GetDateString(dateTime:  new System.DateTime() {dateData = value.dateData}, format:  0);
            val_1.LastRewardDate = val_1;
        }
        public void SetRewardDayCount(int count)
        {
            this.RewardDayCount = count;
        }
        public void AddRewardDayCount()
        {
            int val_1 = this.RewardDayCount;
            val_1.RewardDayCount = val_1 + 1;
        }
        public void AddRewardVideoCount()
        {
            int val_1 = this.RewardVideoCount;
            val_1.RewardVideoCount = val_1 + 1;
        }
        public void AddBoxLowestRewardTotal1()
        {
            int val_1 = this.BoxLowestRewardTotal1;
            val_1.BoxLowestRewardTotal1 = val_1 + 1;
        }
        public void SetBoxLowestRewardTotal1(int total)
        {
            this.BoxLowestRewardTotal1 = total;
        }
        public void AddBoxLowestRewardTotal2()
        {
            int val_1 = this.BoxLowestRewardTotal2;
            val_1.BoxLowestRewardTotal2 = val_1 + 1;
        }
        public void SetBoxLowestRewardTotal2(int total)
        {
            this.BoxLowestRewardTotal2 = total;
        }
        public Data.Reward.RecallRewardType get_RecallRewardType()
        {
            return (Data.Reward.RecallRewardType)this.<RecallRewardType>k__BackingField;
        }
        public int GetBoxRewardCount1()
        {
            System.Collections.Generic.List<System.Int32> val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this;
            bool val_5 = true;
            val_6 = 0;
            var val_6 = 0;
            label_7:
            if(val_6 >= val_5)
            {
                goto label_2;
            }
            
            val_5 = val_5 & 4294967295;
            if(val_6 >= val_5)
            {
                    val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            if((UnityEngine.Random.Range(min:  0f, max:  1f)) <= (((true & 4294967295) + 0) + 32))
            {
                    if(val_6 < val_5)
            {
                goto label_6;
            }
            
            }
            
            val_6 = val_6 + 1;
            if(this._chances_1 != null)
            {
                goto label_7;
            }
            
            label_2:
            val_7 = 0;
            goto label_9;
            label_6:
            if(val_5 <= val_6)
            {
                    val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_7 = mem[(((true & 4294967295) + 0) + 0) + 32];
            val_7 = (((true & 4294967295) + 0) + 0) + 32;
            label_9:
            if(val_5 == 0)
            {
                    val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + ((val_5 - 1) << 2);
            if(val_7 == (((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32))
            {
                    val_8 = this.BoxLowestRewardTotal1 + 1;
            }
            else
            {
                    val_8 = 0;
            }
            
            this.BoxLowestRewardTotal1 = 0;
            int val_4 = this.BoxLowestRewardTotal1;
            if(val_4 != 4)
            {
                    return (int)val_7;
            }
            
            val_4.BoxLowestRewardTotal1 = 0;
            val_5 = this._rewards_1;
            if((((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = mem[((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32 + 36];
            val_7 = ((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32 + 36;
            return (int)val_7;
        }
        public int GetBoxRewardCount2()
        {
            System.Collections.Generic.List<System.Int32> val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this;
            bool val_5 = true;
            val_6 = 0;
            var val_6 = 0;
            label_7:
            if(val_6 >= val_5)
            {
                goto label_2;
            }
            
            val_5 = val_5 & 4294967295;
            if(val_6 >= val_5)
            {
                    val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            if((UnityEngine.Random.Range(min:  0f, max:  1f)) <= (((true & 4294967295) + 0) + 32))
            {
                    if(val_6 < val_5)
            {
                goto label_6;
            }
            
            }
            
            val_6 = val_6 + 1;
            if(this._chances_2 != null)
            {
                goto label_7;
            }
            
            label_2:
            val_7 = 0;
            goto label_9;
            label_6:
            if(val_5 <= val_6)
            {
                    val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_7 = mem[(((true & 4294967295) + 0) + 0) + 32];
            val_7 = (((true & 4294967295) + 0) + 0) + 32;
            label_9:
            if(val_5 == 0)
            {
                    val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + ((val_5 - 1) << 2);
            if(val_7 == (((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32))
            {
                    val_8 = this.BoxLowestRewardTotal2 + 1;
            }
            else
            {
                    val_8 = 0;
            }
            
            this.BoxLowestRewardTotal2 = 0;
            int val_4 = this.BoxLowestRewardTotal2;
            if(val_4 != 4)
            {
                    return (int)val_7;
            }
            
            val_4.BoxLowestRewardTotal2 = 0;
            val_5 = this._rewards_2;
            if((((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = mem[((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32 + 32];
            val_7 = ((((true & 4294967295) + 0) + 0) + (((((true & 4294967295) + 0) + 0) - 1)) << 2) + 32 + 32;
            return (int)val_7;
        }
        public RewardDataManager()
        {
            Add(item:  120);
            Add(item:  80);
            Add(item:  60);
            Add(item:  40);
            this._rewards_1 = new System.Collections.Generic.List<System.Int32>();
            Add(item:  0.1f);
            Add(item:  0.3f);
            Add(item:  0.6f);
            Add(item:  1f);
            this._chances_1 = new System.Collections.Generic.List<System.Single>();
            Add(item:  80);
            Add(item:  50);
            Add(item:  40);
            Add(item:  30);
            this._rewards_2 = new System.Collections.Generic.List<System.Int32>();
            Add(item:  0.1f);
            Add(item:  0.3f);
            Add(item:  0.6f);
            Add(item:  1f);
            this._chances_2 = new System.Collections.Generic.List<System.Single>();
        }
    
    }

}
