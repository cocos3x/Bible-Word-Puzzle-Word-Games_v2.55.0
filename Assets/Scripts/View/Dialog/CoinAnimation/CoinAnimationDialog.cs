using UnityEngine;

namespace View.Dialog.CoinAnimation
{
    public class CoinAnimationDialog : Dialog
    {
        // Fields
        public View.Dialog.CoinAnimation.CoinAnimation coinAnimation;
        public View.Dialog.CoinAnimation.CoinAnimationEffect CoinEffectPrefab;
        public UnityEngine.Transform EffectContent;
        private int animationCount;
        private bool isCanPlayAni;
        private UnityEngine.Vector3 _slotCoin;
        private int _amount;
        private string _from;
        private UnityEngine.Vector2 _centerPosition;
        private float _time;
        private float _delay;
        private UnityEngine.Events.UnityAction _onFinish;
        private int _count;
        
        // Methods
        public void GainCoin(int amount, string from, UnityEngine.Vector2 centerPosition, float time = 0.5, float delay = 0, UnityEngine.Events.UnityAction onFinish, int count = -1)
        {
            int val_3 = this.animationCount;
            this._amount = amount;
            this._from = from;
            this._centerPosition = centerPosition;
            mem[1152921512799107604] = centerPosition.y;
            val_3 = val_3 + 1;
            this._time = time;
            this._delay = delay;
            this._onFinish = onFinish;
            this._count = count;
            this.animationCount = val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this._slotCoin, y = delay, z = time}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    this.GainCoinAni();
                return;
            }
            
            this.isCanPlayAni = true;
        }
        private void GainCoinAni()
        {
            this.coinAnimation.transform.position = new UnityEngine.Vector3() {x = this._slotCoin};
            this.coinAnimation.GainCoin(amount:  this._amount, from:  this._from, centerPosition:  new UnityEngine.Vector2() {x = this._centerPosition, y = V9.16B}, time:  this._time, delay:  this._delay, onComplete:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.CoinAnimation.CoinAnimationDialog::<GainCoinAni>b__14_0()), count:  this._count);
        }
        public void GainCoinEffect(int amount, string from, UnityEngine.Vector2 centerPosition, float time = 0.5, float delay = 0, UnityEngine.Events.UnityAction onFinish, int count = -1)
        {
            int val_3 = this.animationCount;
            this._amount = amount;
            this._from = from;
            this._centerPosition = centerPosition;
            mem[1152921512799381780] = centerPosition.y;
            val_3 = val_3 + 1;
            this._time = time;
            this._delay = delay;
            this._onFinish = onFinish;
            this._count = count;
            this.animationCount = val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this._slotCoin, y = delay, z = time}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    this.GainCoinAniEffect();
                return;
            }
            
            this.isCanPlayAni = true;
        }
        private void GainCoinAniEffect()
        {
            View.Dialog.CoinAnimation.CoinAnimationEffect val_1 = View.Dialog.CoinAnimation.CoinAnimationEffect.Create(parent:  this.EffectContent, effectPrefab:  this.CoinEffectPrefab);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this._centerPosition, y = V8.16B});
            val_1.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_1.GainCoin(amount:  this._amount, from:  this._from, centerPosition:  new UnityEngine.Vector2() {x = this._centerPosition, y = this._centerPosition}, endPos:  new UnityEngine.Vector3() {x = this._slotCoin, y = V11.16B, z = V12.16B}, time:  this._time, delay:  this._delay, onComplete:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.Dialog.CoinAnimation.CoinAnimationDialog::<GainCoinAniEffect>b__16_0()), count:  0);
        }
        private void ShopButtonCoinPosition(UnityEngine.Vector3 pos)
        {
            this._slotCoin = pos;
            mem[1152921512799655932] = pos.y;
            mem[1152921512799655936] = pos.z;
            if(this.isCanPlayAni == false)
            {
                    return;
            }
            
            this.GainCoinAni();
        }
        private void OnTimerEnd()
        {
            if(this._onFinish != null)
            {
                    this._onFinish.Invoke();
            }
            
            this.animationCount = 0;
            this.Close();
        }
        protected override void OnEnable()
        {
            var val_5;
            this.OnEnable();
            this.isCanPlayAni = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this._slotCoin = val_1;
            mem[1152921512799894268] = val_1.y;
            mem[1152921512799894272] = val_1.z;
            Message.Messager.Add<UnityEngine.Vector3>(cmd:  25, action:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void View.Dialog.CoinAnimation.CoinAnimationDialog::ShopButtonCoinPosition(UnityEngine.Vector3 pos)));
            Data.DailyRecord.DailyRecordDataManager val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if((val_3.<DailySignIsOpened>k__BackingField) != false)
            {
                    val_5 = 24;
            }
            else
            {
                    val_5 = 23;
            }
            
            Message.Messager.Dispatch(cmd:  23);
            Common.TimerEvent.Add(time:  4f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.CoinAnimation.CoinAnimationDialog::OnTimerEnd()), isrepeat:  false);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<UnityEngine.Vector3>(cmd:  25, action:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void View.Dialog.CoinAnimation.CoinAnimationDialog::ShopButtonCoinPosition(UnityEngine.Vector3 pos)));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.CoinAnimation.CoinAnimationDialog::OnTimerEnd()));
        }
        public CoinAnimationDialog()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this._slotCoin = val_1;
            mem[1152921512800122364] = val_1.y;
            mem[1152921512800122280] = 257;
            mem[1152921512800122368] = val_1.z;
            mem[1152921512800122283] = 1;
            mem[1152921512800122288] = ;
            this = new UnityEngine.MonoBehaviour();
        }
        private void <GainCoinAni>b__14_0()
        {
            if(this._onFinish != null)
            {
                    this._onFinish.Invoke();
            }
            
            int val_2 = this.animationCount;
            val_2 = val_2 - 1;
            this.animationCount = val_2;
            if(val_2 > 0)
            {
                    return;
            }
            
            this.animationCount = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this._slotCoin = val_1;
            mem[1152921512800238540] = val_1.y;
            mem[1152921512800238544] = val_1.z;
            this.Invoke(methodName:  "Close", time:  0.3f);
        }
        private void <GainCoinAniEffect>b__16_0()
        {
            if(this._onFinish != null)
            {
                    this._onFinish.Invoke();
            }
            
            int val_2 = this.animationCount;
            val_2 = val_2 - 1;
            this.animationCount = val_2;
            if(val_2 > 0)
            {
                    return;
            }
            
            this.animationCount = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            this._slotCoin = val_1;
            mem[1152921512800358732] = val_1.y;
            mem[1152921512800358736] = val_1.z;
            this.Invoke(methodName:  "Close", time:  0.3f);
        }
    
    }

}
