using UnityEngine;

namespace Data.PiggyBank
{
    public class PiggyBankDataManager : Singleton<Data.PiggyBank.PiggyBankDataManager>
    {
        // Fields
        public int PiggyBankMaxNum;
        public int PiggyBankStartUpNum;
        public int PiggyBankCollectNum;
        public string ProductId;
        public float PiggyBankPrice;
        public Data.Bean.RewardItem PiggyBankRewardItem;
        
        // Properties
        public int PiggyBankCoin { get; set; }
        private bool PiggyBankFullUnPop { set; }
        public bool IsAlreadyPopPiggyBank { get; }
        
        // Methods
        public void Init()
        {
        
        }
        public int get_PiggyBankCoin()
        {
            return (int)Store.PiggyBankData.__il2cppRuntimeField_name;
        }
        private void set_PiggyBankCoin(int value)
        {
            typeof(Store.PiggyBankData).__il2cppRuntimeField_10 = value;
        }
        private void set_PiggyBankFullUnPop(bool value)
        {
            typeof(Store.PiggyBankData).__il2cppRuntimeField_14 = value;
        }
        public bool get_IsAlreadyPopPiggyBank()
        {
            return (bool)typeof(Store.PiggyBankData).__il2cppRuntimeField_15;
        }
        public int GetPiggyBankCoinNumber()
        {
            return this.PiggyBankCoin;
        }
        public void SetPiggyBankCoinNumber(int num)
        {
            this.PiggyBankCoin = num;
        }
        public void AddPiggyBankCoinNum(int num)
        {
            int val_5;
            int val_1 = this.PiggyBankCoin;
            val_5 = this.PiggyBankMaxNum;
            if(val_1 < (val_5 - num))
            {
                    int val_3 = val_1.PiggyBankCoin;
                val_5 = val_3 + num;
            }
            
            val_3.PiggyBankCoin = val_5;
        }
        public void SetPiggyBankFullUnPop(bool isUnPop)
        {
            this.PiggyBankFullUnPop = isUnPop;
        }
        public bool GetAlreadyPopPiggyBank()
        {
            return this.IsAlreadyPopPiggyBank;
        }
        public PiggyBankDataManager()
        {
            this.PiggyBankCollectNum = 80;
            this.PiggyBankMaxNum = 2880;
            this.PiggyBankStartUpNum = 1440;
            this.PiggyBankPrice = 2.99f;
            this.ProductId = "products_piggy_bank_2.99";
            typeof(Data.Bean.RewardItem).__il2cppRuntimeField_18 = 720;
            typeof(Data.Bean.RewardItem).__il2cppRuntimeField_10 = Data.Shop.ShopRewardItemName.ITEM_COIN;
            this.PiggyBankRewardItem = new System.Object();
        }
    
    }

}
