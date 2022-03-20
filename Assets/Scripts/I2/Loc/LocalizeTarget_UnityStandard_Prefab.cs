using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<UnityEngine.GameObject>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_Prefab()
        {
            I2.Loc.LocalizeTarget_UnityStandard_Prefab.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Prefab).__il2cppRuntimeField_18 = 250;
            typeof(I2.Loc.LocalizeTargetDesc_Prefab).__il2cppRuntimeField_10 = "Prefab";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Prefab());
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            return true;
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
            var val_14;
            I2.Loc.Localize val_15;
            string val_16;
            val_15 = cmp;
            if((System.String.IsNullOrEmpty(value:  mainTranslation)) == true)
            {
                    return;
            }
            
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  21061632);
            if(val_2 != false)
            {
                    if((System.String.op_Equality(a:  val_2.name, b:  mainTranslation)) == true)
            {
                    return;
            }
            
            }
            
            val_14 = val_15.transform;
            System.Char[] val_14 = I2.Loc.LanguageSourceData.CategorySeparators;
            int val_6 = mainTranslation.LastIndexOfAny(anyOf:  val_14);
            val_16 = mainTranslation;
            if((val_6 & 2147483648) == 0)
            {
                    val_14 = val_6 + 1;
                val_16 = mainTranslation.Substring(startIndex:  val_14);
            }
            
            UnityEngine.Transform val_8 = this.InstantiateNewPrefab(cmp:  val_15, mainTranslation:  mainTranslation);
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8.name = val_16;
            val_15 = val_14.childCount - 1;
            if(<0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_11 = val_14.GetChild(index:  val_15);
                if(val_11 != val_8)
            {
                    UnityEngine.Object.Destroy(obj:  val_11.gameObject);
            }
            
                val_15 = val_15 - 1;
            }
            while(>=0);
        
        }
        private UnityEngine.Transform InstantiateNewPrefab(I2.Loc.Localize cmp, string mainTranslation)
        {
            var val_11;
            UnityEngine.Transform val_12;
            UnityEngine.GameObject val_1 = cmp.FindTranslatedObject<UnityEngine.GameObject>(value:  mainTranslation);
            val_11 = 0;
            if(val_1 == 0)
            {
                    return (UnityEngine.Transform)val_11;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1);
            mem[1152921513228856280] = val_3;
            val_11 = 0;
            if(val_3 == 0)
            {
                    return (UnityEngine.Transform)val_11;
            }
            
            val_12 = cmp.transform;
            UnityEngine.Transform val_6 = transform;
            val_11 = val_6;
            val_6.SetParent(p:  val_12);
            if((UnityEngine.Object.op_Implicit(exists:  21061632)) != false)
            {
                    val_12 = transform;
            }
            
            UnityEngine.Quaternion val_9 = val_12.rotation;
            val_11.rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            UnityEngine.Vector3 val_10 = val_12.position;
            val_11.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            return (UnityEngine.Transform)val_11;
        }
        public LocalizeTarget_UnityStandard_Prefab()
        {
        
        }
    
    }

}
