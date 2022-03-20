using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<UnityEngine.MeshRenderer>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_MeshRenderer()
        {
            I2.Loc.LocalizeTarget_UnityStandard_MeshRenderer.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 800;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "MeshRenderer";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.MeshRenderer, I2.Loc.LocalizeTarget_UnityStandard_MeshRenderer>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 8;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 6;
        }
        public override bool CanUseSecondaryTerm()
        {
            return true;
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
            var val_13;
            UnityEngine.Object val_14;
            var val_15;
            bool val_1 = UnityEngine.Object.op_Equality(x:  21061632, y:  0);
            if(val_1 != false)
            {
                    val_13 = 0;
                secondaryTerm = 0;
            }
            else
            {
                    UnityEngine.MeshFilter val_2 = val_1.GetComponent<UnityEngine.MeshFilter>();
                val_13 = 0;
                if(val_2 != 0)
            {
                    val_13 = 0;
            }
            
            }
            
            primaryTerm = val_2.sharedMesh.name;
            val_15 = 0;
            if(primaryTerm != 0)
            {
                    val_14 = val_15.sharedMaterial;
                val_15 = 0;
            }
            
            secondaryTerm = val_15.sharedMaterial.name;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Object val_12;
            string val_1 = mainTranslation;
            val_12 = cmp.GetSecondaryTranslatedObj<UnityEngine.Material>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            bool val_4 = UnityEngine.Object.op_Inequality(x:  val_12, y:  0);
            if(val_4 != false)
            {
                    bool val_6 = UnityEngine.Object.op_Inequality(x:  val_4.sharedMaterial, y:  val_12);
                if(val_6 != false)
            {
                    val_6.material = val_12;
            }
            
            }
            
            UnityEngine.Mesh val_7 = cmp.FindTranslatedObject<UnityEngine.Mesh>(value:  val_1);
            UnityEngine.MeshFilter val_8 = GetComponent<UnityEngine.MeshFilter>();
            if(val_7 == 0)
            {
                    return;
            }
            
            val_12 = val_8.sharedMesh;
            if(val_12 == val_7)
            {
                    return;
            }
            
            val_8.mesh = val_7;
        }
        public LocalizeTarget_UnityStandard_MeshRenderer()
        {
        
        }
    
    }

}
