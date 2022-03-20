using UnityEngine;

namespace View.Dialog.CoinAnimation
{
    public class CoinAnimation : MonoBehaviour
    {
        // Fields
        private static readonly UnityEngine.Vector3 StartScale;
        private static readonly UnityEngine.Vector3 EndScale;
        public UnityEngine.Transform contentParent;
        public View.Dialog.CoinAnimation.CoinAnimationContent contentPrefab;
        public Common.AutoDestroy fireworkEffectPrefab;
        
        // Methods
        public void GainCoin(int amount, string from, UnityEngine.Vector2 centerPosition, float time = 1, float delay = 0, UnityEngine.Events.UnityAction onComplete, int count = -1)
        {
            UnityEngine.Events.UnityAction val_16;
            object val_17;
            string val_18;
            string val_19;
            val_16 = onComplete;
            typeof(CoinAnimation.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = amount;
            typeof(CoinAnimation.<>c__DisplayClass5_0).__il2cppRuntimeField_18 = from;
            typeof(CoinAnimation.<>c__DisplayClass5_0).__il2cppRuntimeField_20 = val_16;
            System.Action val_4 = null;
            var val_3 = (count == 1) ? ((amount > 9) ? 5 : (0 + 1)) : count;
            val_17 = new System.Object();
            val_4 = new System.Action(object:  val_17, method:  System.Void CoinAnimation.<>c__DisplayClass5_0::<GainCoin>b__0());
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() == false)
            {
                goto label_4;
            }
            
            if(val_3 != 1)
            {
                goto label_6;
            }
            
            val_18 = "eff_coins_single";
            Logic.Game.GameManager.gameSound.Play(clipName:  val_18, volumeScale:  1f, loop:  false, delay:  0f);
            goto label_7;
            label_4:
            if(val_3 != 1)
            {
                goto label_8;
            }
            
            label_7:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = centerPosition.x, y = centerPosition.y});
            View.Dialog.CoinAnimation.CoinAnimationContent.Create(parent:  this.contentParent, prefab:  this.contentPrefab).Play(startPosition:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, startScale:  1.3f, endTransform:  this.transform, time:  time, delay:  delay, startType:  1, startTime:  0.5f, keepTime:  0f, useBeizer:  true, onComplete:  val_4);
            return;
            label_6:
            val_19 = "eff_coins";
            Logic.Game.GameManager.gameSound.Play(clipName:  val_19, volumeScale:  1f, loop:  false, delay:  0f);
            label_8:
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_17 = 0;
            do
            {
                val_16 = View.Dialog.CoinAnimation.CoinAnimationContent.Create(parent:  this.contentParent, prefab:  this.contentPrefab);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = centerPosition.x, y = centerPosition.y});
                float val_16 = 0f;
                val_16 = val_16 * 0.12f;
                UnityEngine.Vector3 val_15 = Utils.Extensions.RectTransformExtension.GetCenterPosition(tf:  this.transform);
                val_16.Play(startPosition:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, endPosition:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, startScale:  1.5f, endScale:  0.7f, time:  time, delay:  val_16 + delay, startType:  1, startTime:  0.05f, keepTime:  0f, useBeizer:  true, onComplete:  ((val_3 - 1) == val_17) ? (val_4) : 0);
                val_17 = val_17 + 1;
            }
            while(val_17 < val_3);
        
        }
        public CoinAnimation()
        {
        
        }
        private static CoinAnimation()
        {
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  1.3f, y:  1.3f, z:  1.3f);
            UnityEngine.Vector3 val_2;
            View.Dialog.CoinAnimation.CoinAnimation.StartScale = val_1.x;
            View.Dialog.CoinAnimation.CoinAnimation.StartScale.__il2cppRuntimeField_8 = val_1.z;
            val_2 = new UnityEngine.Vector3(x:  1f, y:  1f, z:  1f);
            View.Dialog.CoinAnimation.CoinAnimation.EndScale = val_2.x;
            View.Dialog.CoinAnimation.CoinAnimation.StartScale.__il2cppRuntimeField_14 = val_2.z;
        }
    
    }

}
