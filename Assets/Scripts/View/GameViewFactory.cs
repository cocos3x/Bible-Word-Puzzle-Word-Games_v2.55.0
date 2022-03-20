using UnityEngine;

namespace View
{
    public static class GameViewFactory
    {
        // Methods
        public static View.Loading.LoadingView CreateLoadingView(UnityEngine.Transform parent)
        {
            return Resource.ResManager.Load<UnityEngine.GameObject>(path:  "Prefab/Loading/LoadingView", parent:  parent).GetComponent<View.Loading.LoadingView>();
        }
        public static View.Home.HomeView CreateHomeView(UnityEngine.Transform parent)
        {
            return Resource.ResManager.Load<UnityEngine.GameObject>(path:  "Prefab/Home/HomeView", parent:  parent).GetComponent<View.Home.HomeView>();
        }
        public static View.Game.GameView CreateGameView(UnityEngine.Transform parent)
        {
            return Resource.ResManager.Load<UnityEngine.GameObject>(path:  "Prefab/Game/GameView", parent:  parent).GetComponent<View.Game.GameView>();
        }
        public static View.DailyPrayer.DailyPrayerView CreateDailyPrayerView(UnityEngine.Transform parent)
        {
            return Resource.ResManager.Load<UnityEngine.GameObject>(path:  "Prefab/DailyPrayer/DailyPrayerView", parent:  parent).GetComponent<View.DailyPrayer.DailyPrayerView>();
        }
        public static View.CommonItem.Combo.ComboNormal CreateComboNormal(UnityEngine.Transform parent, string path)
        {
            return Resource.ResManager.Load<UnityEngine.GameObject>(path:  path, parent:  parent).GetComponent<View.CommonItem.Combo.ComboNormal>();
        }
        public static View.Home.TitleWords CreateTitleWord(UnityEngine.Transform parent, string path)
        {
            return Resource.ResManager.Load<UnityEngine.GameObject>(path:  path, parent:  parent).GetComponent<View.Home.TitleWords>();
        }
    
    }

}
