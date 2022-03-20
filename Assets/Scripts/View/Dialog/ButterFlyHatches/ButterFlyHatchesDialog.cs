using UnityEngine;

namespace View.Dialog.ButterFlyHatches
{
    public class ButterFlyHatchesDialog : Dialog
    {
        // Fields
        private const float TimeDelayEnd = 3.5;
        public UnityEngine.Animator AnimatorContent;
        public UnityEngine.Sprite[] SpriteChrysalis;
        public UnityEngine.UI.Image ImageChrysalis;
        public View.Dialog.ButterFlyHatches.ButterFlyHatchesCollect Collect;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text HatchText;
        private int _chrysalisLevel;
        private int _butterflyIndex;
        private bool _isClick;
        
        // Methods
        public void OnClickHatchButton()
        {
            if(this._isClick != false)
            {
                    return;
            }
            
            this._isClick = true;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "collect", label:  "butterfly", value:  0);
            Logic.Game.GameManager.gameSound.Play(clipName:  "butterfly_hatch", volumeScale:  1f, loop:  false, delay:  0f);
            this.AnimatorContent.Play(stateName:  "ButterflyHatchDialog3");
            int val_2 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.CollectButterFlyForChrysalisLevel(level:  this._chrysalisLevel);
            this._butterflyIndex = val_2;
            this.Collect.SetButterFlyIcon(index:  val_2);
            Message.Messager.Dispatch(cmd:  110);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  public System.Void View.Dialog.Common.Dialog::Close()));
            Common.TimerEvent.Add(time:  3.5f, callback:  new System.Action(object:  this, method:  public System.Void View.Dialog.Common.Dialog::Close()), isrepeat:  false);
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "123");
            this.HatchText.text = Locale.LocaleManager.Translate(key:  "122");
        }
        private void CollectButterFly()
        {
            UnityEngine.Vector3 val_2 = this.Collect.transform.position;
            Message.Messager.Dispatch<System.Int32, UnityEngine.Vector3>(cmd:  111, t:  this._butterflyIndex, u:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        private void UpdateChrysalis()
        {
            int val_2 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectButterFlyLevel();
            this._chrysalisLevel = val_2;
            int val_3 = val_2 / this.SpriteChrysalis.Length;
            val_3 = val_2 - (val_3 * this.SpriteChrysalis.Length);
            this.ImageChrysalis.sprite = this.SpriteChrysalis[val_3];
            this._isClick = false;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.OnCancel(action:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterFlyHatches.ButterFlyHatchesDialog::CollectButterFly())).UpdateChrysalis();
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  public System.Void View.Dialog.Common.Dialog::Close()));
        }
        public ButterFlyHatchesDialog()
        {
            mem[1152921512804890568] = 257;
            mem[1152921512804890571] = 1;
            mem[1152921512804890576] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
