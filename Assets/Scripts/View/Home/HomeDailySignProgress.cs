using UnityEngine;

namespace View.Home
{
    public class HomeDailySignProgress : MonoBehaviour
    {
        // Fields
        public UnityEngine.Sprite[] SpriteGifts;
        public UnityEngine.UI.Image ImageGift;
        public UnityEngine.UI.Text TextProgress;
        
        // Methods
        public void SetDailySignProgress()
        {
            int val_11;
            var val_12;
            val_11 = 1152921512608795232;
            Data.DailyRecord.DailyRecordDataManager val_1 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if(val_1.StarBoxProgress.Length == 0)
            {
                goto label_3;
            }
            
            int val_3 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance.DailySignCollectStarRecord;
            Data.DailyRecord.DailyRecordDataManager val_4 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            var val_12 = 8;
            label_12:
            val_12 = val_12 - 8;
            if(val_12 >= val_4.StarBoxProgress.Length)
            {
                goto label_7;
            }
            
            Data.DailyRecord.DailyRecordDataManager val_5 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            if(val_5.StarBoxProgress[0] > val_3)
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            if((Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance) != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_3:
            UnityEngine.GameObject val_7 = this.gameObject;
            if(val_7 != null)
            {
                goto label_20;
            }
            
            label_7:
            val_12 = 0;
            val_11 = 0;
            goto label_15;
            label_11:
            Data.DailyRecord.DailyRecordDataManager val_8 = Common.Singleton<Data.DailyRecord.DailyRecordDataManager>.Instance;
            val_11 = val_8.StarBoxProgress[0];
            label_15:
            if(val_11 > val_3)
            {
                    this.gameObject.SetActive(value:  true);
                this.ImageGift.sprite = this.SpriteGifts[val_12];
                string val_10 = System.String.Format(format:  "{0}/{1}", arg0:  val_3, arg1:  val_11);
                return;
            }
            
            label_20:
            val_7.SetActive(value:  false);
        }
        public HomeDailySignProgress()
        {
        
        }
    
    }

}
