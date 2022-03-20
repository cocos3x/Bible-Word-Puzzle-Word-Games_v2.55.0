using UnityEngine;

namespace Store
{
    public class PiggyBankData : IStoreData
    {
        // Fields
        public int PiggyBankCoin;
        public bool PiggyBankFullUnPop;
        public bool IsAlreadyPopPiggyBank;
        
        // Methods
        public void Reset()
        {
            this.PiggyBankCoin = 0;
            this.PiggyBankFullUnPop = true;
            this.IsAlreadyPopPiggyBank = false;
        }
        public PiggyBankData()
        {
        
        }
    
    }

}
