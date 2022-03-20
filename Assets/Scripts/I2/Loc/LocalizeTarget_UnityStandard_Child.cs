using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<UnityEngine.GameObject>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_Child()
        {
            I2.Loc.LocalizeTarget_UnityStandard_Child.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Child).__il2cppRuntimeField_18 = 200;
            typeof(I2.Loc.LocalizeTargetDesc_Child).__il2cppRuntimeField_10 = "Child";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Child());
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            return (bool)(cmp.transform.childCount > 1) ? 1 : 0;
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 4;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override bool CanUseSecondaryTerm()
        {
            return false;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return false;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            primaryTerm = cmp.name;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_11;
            string val_12 = mainTranslation;
            if((System.String.IsNullOrEmpty(value:  val_12 = mainTranslation)) == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = cmp.transform;
            val_11 = 1152921504834215936;
            System.Char[] val_11 = I2.Loc.LanguageSourceData.CategorySeparators;
            int val_3 = val_12.LastIndexOfAny(anyOf:  val_11);
            if((val_3 & 2147483648) == 0)
            {
                    val_11 = val_3 + 1;
                val_12 = val_12.Substring(startIndex:  val_11);
            }
            
            if(val_2.childCount < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_6 = val_2.GetChild(index:  0);
                string val_12 = val_12;
                val_12 = System.String.op_Equality(a:  val_6.name, b:  val_12);
                val_6.gameObject.SetActive(value:  val_12);
                val_11 = 0 + 1;
            }
            while(val_11 < val_2.childCount);
        
        }
        public LocalizeTarget_UnityStandard_Child()
        {
        
        }
    
    }

}
