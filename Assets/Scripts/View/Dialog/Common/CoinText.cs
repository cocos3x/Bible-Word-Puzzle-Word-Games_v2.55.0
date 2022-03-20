using UnityEngine;

namespace View.Dialog.Common
{
    public class CoinText : MonoBehaviour
    {
        // Fields
        private TMPro.TextMeshProUGUI coinText;
        private int oldValue;
        
        // Methods
        private void Awake()
        {
            this.coinText = this.GetComponent<TMPro.TextMeshProUGUI>();
        }
        private void OnEnable()
        {
            this.oldValue = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin;
            this.coinText.text = this.oldValue.ToString();
        }
        private void Update()
        {
            if(this.oldValue == (Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin))
            {
                    return;
            }
            
            typeof(CoinText.<>c__DisplayClass4_0).__il2cppRuntimeField_10 = this.oldValue;
            this.oldValue = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin;
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  new System.Object(), method:  System.Int32 CoinText.<>c__DisplayClass4_0::<Update>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  this, method:  System.Void View.Dialog.Common.CoinText::<Update>b__4_1(int v)), endValue:  this.oldValue, duration:  1f), ease:  9);
        }
        public CoinText()
        {
        
        }
        private void <Update>b__4_1(int v)
        {
            this.coinText.text = v.ToString();
        }
    
    }

}
