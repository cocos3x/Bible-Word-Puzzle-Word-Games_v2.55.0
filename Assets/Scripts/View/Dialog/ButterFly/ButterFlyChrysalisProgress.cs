using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class ButterFlyChrysalisProgress : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Slider SliderProgress;
        public View.Dialog.ButterFly.ButterFlyChrysalisLevel[] ChrysalisLevels;
        private float _progress;
        
        // Methods
        private void UpdateProgress()
        {
            int val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount;
            Data.ButterFly.ButterFlyDataManager val_3 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            Data.ButterFly.ButterFlyDataManager val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            int val_5 = val_2 / val_3.ChrysalisOnceMaxCount;
            val_5 = val_2 - (val_5 * val_3.ChrysalisOnceMaxCount);
            float val_6 = (float)val_4.ChrysalisOnceMaxCount;
            val_6 = (float)val_5 / val_6;
            this._progress = val_6;
            goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_420;
        }
        private void UpdateChrysalisState()
        {
            var val_13;
            int val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount();
            var val_4 = (val_2 < 0) ? (val_2 + 3) : (val_2);
            val_4 = val_4 & 4294967292;
            var val_14 = 0;
            label_6:
            if(val_14 >= this.ChrysalisLevels.Length)
            {
                goto label_3;
            }
            
            this.ChrysalisLevels[val_14].SetChrysalisState(isCollect:  (val_14 < (val_2 - val_4)) ? 1 : 0);
            val_14 = val_14 + 1;
            if(this.ChrysalisLevels != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            UnityEngine.GameObject val_7 = this.gameObject;
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpenForHome()) == false)
            {
                goto label_8;
            }
            
            val_13 = (Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) ^ 1;
            if(val_7 != null)
            {
                goto label_10;
            }
            
            label_8:
            val_13 = 0;
            label_10:
            val_7.SetActive(value:  val_13 & 1);
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  110, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyChrysalisProgress::UpdateChrysalisState()));
            this.UpdateProgress();
            this.UpdateChrysalisState();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  110, action:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyChrysalisProgress::UpdateChrysalisState()));
        }
        public ButterFlyChrysalisProgress()
        {
        
        }
    
    }

}
