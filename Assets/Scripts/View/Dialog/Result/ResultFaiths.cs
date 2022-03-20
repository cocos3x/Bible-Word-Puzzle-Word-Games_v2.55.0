using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultFaiths : MonoBehaviour
    {
        // Fields
        private const float TimeFaithAdd = 1;
        public UnityEngine.Animator AnimatorFaith;
        public TMPro.TextMeshProUGUI TextFaith;
        public TMPro.TextMeshProUGUI TextFaithNum;
        private float _cellHeight;
        private UnityEngine.Vector2 _topPos;
        private int _faithValue;
        private int _faithEndValue;
        
        // Methods
        public void LocaleTranslate()
        {
            this.TextFaith.text = Locale.LocaleManager.Translate(key:  "37");
        }
        public void PlayFaithAni(int endValue, bool isLevel = True)
        {
            float val_22;
            var val_23;
            DG.Tweening.TweenCallback val_25;
            this.gameObject.SetActive(value:  true);
            val_22 = 0f;
            if(isLevel != false)
            {
                    this.AnimatorFaith.Play(stateName:  "ResultFaithAni");
                val_22 = 0.8f;
            }
            
            this._faithEndValue = endValue;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            int val_4 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  val_22);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_23 = null;
                val_23 = null;
                val_25 = ResultFaiths.<>c.<>9__9_0;
                if(val_25 == null)
            {
                    DG.Tweening.TweenCallback val_8 = null;
                val_25 = val_8;
                val_8 = new DG.Tweening.TweenCallback(object:  ResultFaiths.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ResultFaiths.<>c::<PlayFaithAni>b__9_0());
                ResultFaiths.<>c.<>9__9_0 = val_25;
            }
            
                DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  val_25);
            }
            
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  this, method:  System.Int32 View.Dialog.Result.ResultFaiths::<PlayFaithAni>b__9_1()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  this, method:  System.Void View.Dialog.Result.ResultFaiths::<PlayFaithAni>b__9_2(int value)), endValue:  this._faithEndValue, duration:  1f), ease:  12));
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  1.2f);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, duration:  1f), ease:  12));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_5, id:  this);
        }
        public void SetFaith(int value)
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.2f);
            this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this._faithValue = value;
            mem[1152921512708073152] = value;
            this.TextFaithNum.text = this._faithValue.ToString();
        }
        public ResultFaiths()
        {
        
        }
        private int <PlayFaithAni>b__9_1()
        {
            return (int)this._faithValue;
        }
        private void <PlayFaithAni>b__9_2(int value)
        {
            if((Platform.AbTest.GameABTestManager.IsGameSoundTest() != false) && (this._faithValue != value))
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_fp_up", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            this._faithValue = value;
            this.TextFaithNum.text = this._faithValue.ToString();
        }
    
    }

}
