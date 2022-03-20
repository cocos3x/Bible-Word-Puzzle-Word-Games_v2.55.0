using UnityEngine;

namespace Common.EnterShow
{
    public class EnterShow : Singleton<Common.EnterShow.EnterShow>
    {
        // Methods
        public bool CheckStarterPack(bool isHasBonus = False)
        {
            var val_7;
            isHasBonus = isHasBonus;
            if((this.IsHaveGuide(isHasBonus:  isHasBonus)) != true)
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.UnlockSectionIndex) >= 3)
            {
                    var val_6 = ((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackageShowTimeForName(name:  "64")) == 0) ? 1 : 0;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public bool CheckDoubleCoins(bool isHasBonus = False)
        {
            var val_9;
            isHasBonus = isHasBonus;
            if(((this.IsHaveGuide(isHasBonus:  isHasBonus)) != true) && ((Common.Singleton<Data.LifeActivities.LifeActivitiesDataManager>.Instance.IsHaveNoviceBankruptcy) != true))
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.Coin) <= 99)
            {
                    var val_8 = ((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackageShowTimeForName(name:  "60")) == 0) ? 1 : 0;
                return (bool)val_9;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public bool CheckSurpriseSuperBundle(bool isHasBonus = False)
        {
            bool val_7;
            var val_8;
            val_7 = isHasBonus;
            isHasBonus = val_7;
            if((this.IsHaveGuide(isHasBonus:  isHasBonus)) != true)
            {
                    val_7 = 1152921512622626304;
                if((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.IsHaveSurpriseSuperBundle()) != false)
            {
                    var val_6 = ((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackageShowTimeForName(name:  "65")) == 0) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public bool CheckRemoveAdsBundle(bool isHasBonus = False)
        {
            bool val_10;
            var val_11;
            val_10 = isHasBonus;
            isHasBonus = val_10;
            if((this.IsHaveGuide(isHasBonus:  isHasBonus)) != true)
            {
                    val_10 = 1152921512622626304;
                if((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackageShowTimeForName(name:  "63")) != 0)
            {
                    if((((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetPackageShowTimeForName(name:  "63")) != 1) || ((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetOverdueSecondForName(name:  "63")) < 1)) || ((Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance.GetOverdueSecondForName(name:  "63")) >= 86400))
            {
                goto label_9;
            }
            
            }
            
                val_11 = 1;
                return (bool)val_11;
            }
            
            label_9:
            val_11 = 0;
            return (bool)val_11;
        }
        public bool CheckPiggyBank(bool isHasBonus)
        {
            isHasBonus = isHasBonus;
            if((this.IsHaveGuide(isHasBonus:  isHasBonus)) == false)
            {
                    return Common.SingletonController<Logic.PiggyBank.PiggyBankController>.Instance.ShouldPopPiggyBank();
            }
            
            return false;
        }
        public void ShowLimitTimePackForName(string name)
        {
            object[] val_1 = new object[1];
            val_1[0] = name;
            View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "ShopActivityDialog", pars:  val_1);
        }
        public void CheckAndShowLimitTimePack()
        {
            string val_4;
            bool val_1 = this.CheckStarterPack(isHasBonus:  false);
            if(val_1 != false)
            {
                    val_4 = "64";
            }
            else
            {
                    bool val_2 = val_1.CheckDoubleCoins(isHasBonus:  false);
                if(val_2 != false)
            {
                    val_4 = "60";
            }
            else
            {
                    bool val_3 = val_2.CheckSurpriseSuperBundle(isHasBonus:  false);
                if(val_3 == false)
            {
                    return;
            }
            
                val_4 = "65";
            }
            
            }
            
            val_3.ShowLimitTimePackForName(name:  val_4);
        }
        private bool IsHaveGuide(bool isHasBonus)
        {
            var val_28;
            var val_29;
            val_28 = isHasBonus;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                goto label_2;
            }
            
            if((((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide()) == true) || ((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide1_2()) == true)) || ((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide1_3()) == true))
            {
                goto label_30;
            }
            
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowBonusWordGuideDialog) != false)
            {
                    if(val_28 == true)
            {
                goto label_30;
            }
            
            }
            
            if(((Common.Singleton<Data.Guide.GuideDataManager>.Instance.HasShowFireworkGuide) == true) || ((Logic.Game.GameManager.gameLevel.IsPassLevelForUnlockLevel(sectionIndex:  3, levelIndex:  3)) == false))
            {
                goto label_15;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_13 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_13.<CurrentLevelIndex>k__BackingField) != 0)
            {
                goto label_30;
            }
            
            label_15:
            if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameType(type:  2)) == true)
            {
                goto label_30;
            }
            
            goto label_36;
            label_2:
            View.Controller.MainController val_15 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_15._bibleGameState != 4)
            {
                goto label_36;
            }
            
            val_28 = 1152921512608773520;
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.IsDailyNewGuide) != false)
            {
                    if((Common.Singleton<Data.Login.LoginDataManager>.Instance.LimitFirstVersion(version:  "2.26.0")) == true)
            {
                goto label_30;
            }
            
            }
            
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginDays) <= 1)
            {
                    if((Common.Singleton<Data.Login.LoginDataManager>.Instance.LimitFirstVersion(version:  "2.26.0")) == false)
            {
                goto label_30;
            }
            
            }
            
            if(((Common.Singleton<Data.Guide.GuideDataManager>.Instance.HasShowFireworkGuide) == true) || ((Logic.Game.GameManager.gameLevel.IsPassLevelForUnlockLevel(sectionIndex:  3, levelIndex:  3)) == false))
            {
                goto label_36;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_27 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_27.<CurrentLevelIndex>k__BackingField) == 0)
            {
                goto label_36;
            }
            
            label_30:
            val_29 = 1;
            return (bool)val_29;
            label_36:
            val_29 = 0;
            return (bool)val_29;
        }
        public EnterShow()
        {
        
        }
    
    }

}
