using UnityEngine;

namespace Logic.PiggyBank
{
    public class PiggyBankController : SingletonController<Logic.PiggyBank.PiggyBankController>
    {
        // Methods
        public bool ShouldPopPiggyBank()
        {
            return false;
        }
        public bool ShouldHavePiggyBankForResult()
        {
            return false;
        }
        public PiggyBankController()
        {
        
        }
    
    }

}
