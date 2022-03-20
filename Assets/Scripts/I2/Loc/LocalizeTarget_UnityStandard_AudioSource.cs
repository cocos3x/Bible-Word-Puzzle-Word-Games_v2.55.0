using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<UnityEngine.AudioSource>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_AudioSource()
        {
            I2.Loc.LocalizeTarget_UnityStandard_AudioSource.AutoRegister();
        }
        private static void AutoRegister()
        {
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_18 = 100;
            typeof(I2.Loc.LocalizeTargetDesc_Type<T, G>).__il2cppRuntimeField_10 = "AudioSource";
            I2.Loc.LocalizationManager.RegisterTarget(desc:  new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.AudioSource, I2.Loc.LocalizeTarget_UnityStandard_AudioSource>());
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 3;
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
            int val_5;
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  9762.clip);
            if(val_2 != false)
            {
                    string val_4 = val_2.clip.name;
            }
            else
            {
                    val_5 = System.String.alignConst;
            }
            
            primaryTerm = val_5;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_10;
            bool val_1 = 9761.isPlaying;
            if(val_1 == true)
            {
                goto label_2;
            }
            
            bool val_2 = val_1.loop;
            if(val_2 == false)
            {
                goto label_4;
            }
            
            label_2:
            val_10 = UnityEngine.Application.isPlaying;
            goto label_5;
            label_4:
            val_10 = 0;
            label_5:
            UnityEngine.AudioClip val_5 = cmp.FindTranslatedObject<UnityEngine.AudioClip>(value:  mainTranslation);
            bool val_6 = UnityEngine.Object.op_Inequality(x:  val_2.clip, y:  val_5);
            if(val_6 != false)
            {
                    val_6.clip = val_5;
            }
            
            if(val_10 == 0)
            {
                    return;
            }
            
            bool val_8 = UnityEngine.Object.op_Implicit(exists:  val_6.clip);
            if(val_8 == false)
            {
                    return;
            }
            
            val_8.Play();
        }
        public LocalizeTarget_UnityStandard_AudioSource()
        {
        
        }
    
    }

}
