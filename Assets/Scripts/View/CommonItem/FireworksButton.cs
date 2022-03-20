using UnityEngine;

namespace View.CommonItem
{
    public class FireworksButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform firework;
        private UnityEngine.UI.Button fireworkBtn;
        private UnityEngine.UI.Image icon;
        private UnityEngine.Sprite lockSprite;
        private UnityEngine.Sprite fireworksSprite;
        private UnityEngine.GameObject freeEffect;
        private UnityEngine.RectTransform _rectTransform;
        private UnityEngine.GameObject redDot;
        private UnityEngine.GameObject coinIcon;
        private UnityEngine.UI.Text redDotCont;
        private bool _isPlay;
        
        // Methods
        private void Awake()
        {
            this._rectTransform = this.GetComponent<UnityEngine.RectTransform>();
            this.fireworkBtn.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void View.CommonItem.FireworksButton::OnFireworkButtonClick()));
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  103, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::OnAnimFinish()));
            Message.Messager.Add(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::ShowFirework()));
            Message.Messager.Add(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::HideFirework()));
            Message.Messager.Add(cmd:  72, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::RefreshCoinAndRedDot()));
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.HasShowFireworkGuide) != false)
            {
                    this.RefreshCoinAndRedDot();
            }
            
            this.RefreshIcon();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  103, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::OnAnimFinish()));
            Message.Messager.Remove(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::ShowFirework()));
            Message.Messager.Remove(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::HideFirework()));
            Message.Messager.Remove(cmd:  72, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::RefreshCoinAndRedDot()));
        }
        private void ShowFirework()
        {
            this.firework.gameObject.SetActive(value:  true);
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.HasShowFireworkGuide) == false)
            {
                goto label_4;
            }
            
            label_13:
            this.ShowAnim(action:  0);
            return;
            label_4:
            if((UnityEngine.Object.op_Implicit(exists:  View.Game.GameController.GetInstance())) == false)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameLevel.IsPassLevelForUnlockLevel(sectionIndex:  3, levelIndex:  3)) == false)
            {
                    return;
            }
            
            Data.UserPlayer.UserPlayerDataManager val_7 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((val_7.<CurrentLevelIndex>k__BackingField) == 0)
            {
                    return;
            }
            
            Logic.Gameplay.GameplayController val_8 = Common.SingletonController<Logic.Gameplay.GameplayController>.Instance;
            val_8.<GameSceneShouldAd>k__BackingField = false;
            System.Action val_9 = new System.Action(object:  this, method:  System.Void View.CommonItem.FireworksButton::ShowFireworkGuide());
            goto label_13;
        }
        private void ShowFireworkGuide()
        {
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.HasShowFireworkGuide) != false)
            {
                    return;
            }
            
            Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.AddFireworkCount(count:  1);
            object[] val_4 = new object[1];
            val_4[0] = this;
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "FireworksHintClickGuideDialog", type:  2, pars:  val_4);
            this.RefreshIcon();
        }
        private void HideFirework()
        {
            this.HideAnim();
        }
        private void RefreshCoinAndRedDot()
        {
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.FireworkCount) >= 1)
            {
                    this.redDot.SetActive(value:  true);
                this.coinIcon.SetActive(value:  false);
                this = this.redDotCont;
                string val_5 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.FireworkCount.ToString();
                return;
            }
            
            this.redDot.SetActive(value:  false);
            this.coinIcon.SetActive(value:  true);
        }
        private void RefreshIcon()
        {
            UnityEngine.Sprite val_3;
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.HasShowFireworkGuide) != false)
            {
                    val_3 = this.fireworksSprite;
            }
            else
            {
                    val_3 = this.lockSprite;
            }
            
            this.icon.sprite = val_3;
        }
        private void ShowAnim(System.Action action)
        {
            typeof(FireworksButton.<>c__DisplayClass19_0).__il2cppRuntimeField_10 = action;
            this._isPlay = false;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this._rectTransform, endValue:  25f, duration:  0.5f, snapping:  false), ease:  27), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void FireworksButton.<>c__DisplayClass19_0::<ShowAnim>b__0())), id:  this);
        }
        private void HideAnim()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this._rectTransform, endValue:  -215f, duration:  0.5f, snapping:  false), ease:  26), id:  this);
        }
        private void OnAnimFinish()
        {
            this._isPlay = false;
        }
        private void OnFireworkButtonClick()
        {
            int val_19;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "main_actions", label:  "firework", value:  0);
            if(this._isPlay == true)
            {
                    return;
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "DailyGuideDialog")) == true)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  View.Game.GameController.GetInstance())) != false)
            {
                    Logic.Game.GameControllers val_4 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if((val_4.<IsGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
                Logic.Game.GameControllers val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if(val_5._levelBean == null)
            {
                    return;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  View.DailyPrayer.DailyPrayerController.GetInstance())) != false)
            {
                    View.DailyPrayer.DailyPrayerController val_8 = View.DailyPrayer.DailyPrayerController.GetInstance();
                if((val_8.<isGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
                View.DailyPrayer.DailyPrayerController val_9 = View.DailyPrayer.DailyPrayerController.GetInstance();
                if(val_9.wordContent._levelItem == null)
            {
                    return;
            }
            
            }
            
            View.Controller.MainController val_10 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_10._bibleGameState != 3)
            {
                goto label_20;
            }
            
            Logic.Game.GameControllers val_11 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            val_19 = val_11.<NowCurLevelUseFireworkCount>k__BackingField;
            goto label_22;
            label_20:
            View.Controller.MainController val_12 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_12._bibleGameState != 4)
            {
                goto label_24;
            }
            
            Logic.DailyPrayer.DailyPrayerControllers val_13 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_19 = val_13.<NowCurLevelUseFireworkCount>k__BackingField;
            label_22:
            int val_19 = val_19;
            val_19 = val_19 + 1;
            mem2[0] = val_19;
            label_24:
            Data.UserPlayer.UserPlayerDataManager val_16 = Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance;
            if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.FireworkCount) < 1)
            {
                goto label_28;
            }
            
            val_16.ReduceFireworkCount(count:  1);
            goto label_29;
            label_28:
            if((val_16.CostCoins(value:  124, from:  "tips")) == false)
            {
                goto label_30;
            }
            
            label_29:
            this.RunFireworks();
            return;
            label_30:
            Platform.Analytics.EzAnalytics.LogEvent(category:  "fireworks", action:  "action", label:  "fail", value:  0);
            View.Dialog.Common.Dialog val_18 = Logic.Game.GameManager.gameDialog.Open(name:  "ShopTestDialog", type:  0);
        }
        private void RunFireworks()
        {
            null = null;
            Platform.Analytics.EzAnalytics.SendPropUse(propName:  new PropNameEnum() {<Value>k__BackingField = PropUse.PropNameEnum.PropNameFirework});
            this._isPlay = true;
            this.RefreshCoinAndRedDot();
            Message.Messager.Dispatch(cmd:  102);
        }
        public void SetFireworkFree(UnityEngine.Vector3 startPos)
        {
            this.freeEffect.transform.position = new UnityEngine.Vector3() {x = startPos.x, y = startPos.y, z = startPos.z};
            this.freeEffect.gameObject.SetActive(value:  true);
            int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  0.05f);
            UnityEngine.Vector3 val_8 = this.redDotCont.transform.position;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.freeEffect.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.7f, snapping:  false));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  0.15f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.FireworksButton::<SetFireworkFree>b__24_0()));
        }
        public FireworksButton()
        {
        
        }
        private void <SetFireworkFree>b__24_0()
        {
            this.freeEffect.gameObject.SetActive(value:  false);
            this.RefreshCoinAndRedDot();
        }
    
    }

}
