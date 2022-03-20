using UnityEngine;

namespace View
{
    public class UIButton : Button
    {
        // Fields
        private Coffee.UIEffects.UIEffect[] allUIEffect;
        private UnityEngine.UI.Selectable[] allSelectable;
        private UnityEngine.UI.Image[] allImage;
        private UnityEngine.Color ColorGray;
        
        // Methods
        protected override void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
        {
            Coffee.UIEffects.UIEffect[] val_6;
            var val_7;
            UnityEngine.UI.Selectable[] val_8;
            val_6 = this.allUIEffect;
            if(val_6 != null)
            {
                goto label_1;
            }
            
            T[] val_1 = this.GetComponentsInChildren<Coffee.UIEffects.UIEffect>();
            this.allUIEffect = val_1;
            if(val_1 == null)
            {
                goto label_14;
            }
            
            label_1:
            if(state != 4)
            {
                goto label_3;
            }
            
            var val_10 = 4;
            label_11:
            val_7 = val_10 - 4;
            if(val_7 >= val_1.Length)
            {
                goto label_14;
            }
            
            val_1[0].effectMode = 1;
            this.allUIEffect[0].effectFactor = 1f;
            val_10 = val_10 + 1;
            if(this.allUIEffect != null)
            {
                goto label_11;
            }
            
            label_3:
            var val_13 = 4;
            label_20:
            val_7 = val_13 - 4;
            if(val_7 >= val_1.Length)
            {
                goto label_14;
            }
            
            val_1[0].effectMode = 0;
            this.allUIEffect[0].effectFactor = 1f;
            val_13 = val_13 + 1;
            if(this.allUIEffect != null)
            {
                goto label_20;
            }
            
            label_14:
            val_8 = this.allSelectable;
            if(val_8 != null)
            {
                goto label_22;
            }
            
            T[] val_2 = this.GetComponentsInChildren<UnityEngine.UI.Selectable>();
            this.allSelectable = val_2;
            if(val_2 == null)
            {
                goto label_37;
            }
            
            label_22:
            if(state != 4)
            {
                goto label_24;
            }
            
            val_7 = 4;
            label_34:
            if((val_7 - 4) >= (val_2.Length << ))
            {
                goto label_37;
            }
            
            if(val_2[0] != this)
            {
                    this.allSelectable[0].interactable = false;
            }
            
            val_7 = val_7 + 1;
            if(this.allSelectable != null)
            {
                goto label_34;
            }
            
            label_24:
            val_7 = 4;
            label_45:
            if((val_7 - 4) >= (val_2.Length << ))
            {
                goto label_37;
            }
            
            if(val_2[0] != this)
            {
                    this.allSelectable[0].interactable = true;
            }
            
            val_7 = val_7 + 1;
            if(this.allSelectable != null)
            {
                goto label_45;
            }
            
            throw new NullReferenceException();
            label_37:
            this.DoStateTransition(state:  state, instant:  instant);
        }
        public UIButton()
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  0.78f, g:  0.78f, b:  0.78f, a:  1f);
            mem2[0] = val_1.r;
        }
    
    }

}
