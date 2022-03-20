using UnityEngine;

namespace Platform.Ad
{
    public class AdShowId : Singleton<Platform.Ad.AdShowId>
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, string> _adShowIds;
        
        // Methods
        public void UpdateAdShowId(string position)
        {
            string val_4;
            var val_5;
            val_4 = position;
            if((val_4.Contains(value:  Platform.Ad.GameAdPosition.DailyGiftFormat)) != false)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Platform.Ad.GameAdPosition.DailyGift;
            }
            
            string val_3 = 6936.CreateAdShowId();
            if((this._adShowIds.ContainsKey(key:  val_4)) != false)
            {
                    this._adShowIds.set_Item(key:  val_4, value:  val_3);
                return;
            }
            
            this._adShowIds.Add(key:  val_4, value:  val_3);
        }
        public string GetAdShowId(string position)
        {
            string val_4;
            System.Collections.Generic.Dictionary<System.String, System.String> val_5;
            var val_6;
            var val_7;
            val_4 = position;
            val_5 = 1152921504828145664;
            if((val_4.Contains(value:  Platform.Ad.GameAdPosition.DailyGiftFormat)) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_4 = Platform.Ad.GameAdPosition.DailyGift;
            }
            
            if((this._adShowIds.ContainsKey(key:  val_4)) == true)
            {
                    return this._adShowIds.Item[val_4];
            }
            
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "AdShowId GetAdShowId 未提前获取到AdShowId...", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_5 = this._adShowIds;
            val_5.Add(key:  val_4, value:  6936.CreateAdShowId());
            return this._adShowIds.Item[val_4];
        }
        public AdShowId()
        {
            this._adShowIds = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
