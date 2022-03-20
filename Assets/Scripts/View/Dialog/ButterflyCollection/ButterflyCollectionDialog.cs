using UnityEngine;

namespace View.Dialog.ButterflyCollection
{
    public class ButterflyCollectionDialog : Dialog
    {
        // Fields
        public View.Dialog.ButterflyCollection.ButterFlyCollectionIcon[] Icons;
        public UnityEngine.UI.Text TitleText;
        
        // Methods
        public void OnClickCloseButton()
        {
            this.Close();
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "120");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void UpdateCollectionInfos()
        {
            var val_9 = 0;
            do
            {
                System.Collections.Generic.List<System.Int32> val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ButterFlyList;
                if(val_9 >= true)
            {
                    return;
            }
            
                if(val_9 < (this.Icons.Length << ))
            {
                    System.Collections.Generic.List<System.Int32> val_4 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ButterFlyList;
                if(val_9 >= this.Icons[val_9])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this.Icons[val_9].SetButterFlyInfo(index:  0, isCollect:  (this.Icons[val_9][0] == 1) ? 1 : 0);
            }
            
                val_9 = val_9 + 1;
            }
            while((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance) != null);
            
            throw new NullReferenceException();
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameTypeLast(type:  W21, name:  this.name)) == false)
            {
                    return;
            }
            
            this.Close();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.UpdateCollectionInfos();
        }
        public ButterflyCollectionDialog()
        {
            mem[1152921512803248664] = 257;
            mem[1152921512803248667] = 1;
            mem[1152921512803248672] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
