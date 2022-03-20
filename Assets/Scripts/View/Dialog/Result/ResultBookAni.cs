using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultBookAni : MonoBehaviour
    {
        // Fields
        private const float TimeMove = 0.95;
        public UnityEngine.Transform TransformBook;
        public UnityEngine.Transform SlotBook;
        public UnityEngine.AnimationCurve CurveMove;
        
        // Methods
        public void PlayBookAni(UnityEngine.Vector3 pos, System.Action callBack)
        {
            object val_1 = new System.Object();
            typeof(ResultBookAni.<>c__DisplayClass4_0).__il2cppRuntimeField_10 = callBack;
            typeof(ResultBookAni.<>c__DisplayClass4_0).__il2cppRuntimeField_18 = this;
            Message.Messager.Dispatch<System.Boolean>(cmd:  66, t:  false);
            this.gameObject.SetActive(value:  true);
            this.TransformBook.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_bible_move", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            int val_4 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_6 = this.SlotBook.position;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.TransformBook, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.95f, snapping:  false), animCurve:  this.CurveMove));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  0.05f);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ResultBookAni.<>c__DisplayClass4_0::<PlayBookAni>b__0()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_5, interval:  0.05f);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ResultBookAni.<>c__DisplayClass4_0::<PlayBookAni>b__1())), id:  this);
        }
        public ResultBookAni()
        {
        
        }
    
    }

}
