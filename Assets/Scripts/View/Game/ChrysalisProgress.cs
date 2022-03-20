using UnityEngine;

namespace View.Game
{
    public class ChrysalisProgress : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform ChrysalisContent;
        public View.CommonItem.ChrysalisIcon Icon;
        public TMPro.TextMeshProUGUI TextProgress;
        public UnityEngine.Transform TransformSlot;
        private UnityEngine.Vector2 _insidePos;
        private UnityEngine.Vector2 _outSidePos;
        private UnityEngine.RectTransform _rectChrysalis;
        private bool _isShow;
        
        // Methods
        public void OnClickChrysalisContentButton()
        {
            var val_3;
            var val_4;
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "enter_click", label:  "game", value:  0);
            val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            Platform.Analytics.EzAnalytics.SendActivScrShow(scrName:  new ScrNameEnum() {<Value>k__BackingField = ActivScrShow.ScrNameEnum.ScrNameButterflyScr}, source:  new SourceEnum() {<Value>k__BackingField = ActivScrShow.SourceEnum.SourceMgScr});
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_1.<IsGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyDialog", type:  0);
        }
        private void CollectChrysalis()
        {
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "collect", label:  "chrysails", value:  0);
            Logic.Game.GameManager.gameSound.Play(clipName:  "butterfly_light", volumeScale:  1f, loop:  false, delay:  0f);
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.AddLevelChrysalisCount();
            if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ChrysalisCount) == 0)
            {
                    if((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount) == 1)
            {
                    View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyHelpDialog", type:  0);
            }
            
            }
            
            this.UpdateProgress();
        }
        private void UpdateProgress()
        {
            Data.ButterFly.ButterFlyDataManager val_3 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            this.TextProgress.text = System.String.Format(format:  "{0}/{1}", arg0:  Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.LevelChrysalisCount, arg1:  val_3.<LevelChrysalisMaxCount>k__BackingField);
        }
        private void ShowChrysalis()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this._isShow = true;
            this._rectChrysalis.anchoredPosition = new UnityEngine.Vector2() {x = this._outSidePos};
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this._rectChrysalis, endValue:  new UnityEngine.Vector2() {x = this._insidePos}, duration:  0.5f, snapping:  false), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Game.ChrysalisProgress::<ShowChrysalis>b__11_0())), id:  this);
        }
        private void HideChrysalis()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this._isShow = false;
            this._rectChrysalis.anchoredPosition = new UnityEngine.Vector2() {x = this._insidePos};
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this._rectChrysalis, endValue:  new UnityEngine.Vector2() {x = this._outSidePos}, duration:  0.5f, snapping:  false), ease:  26), id:  this);
        }
        private void UpdateChrysalis()
        {
            if(((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpen()) != false) && ((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) != true))
            {
                    if((Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0)) != false)
            {
                    this.ChrysalisContent.gameObject.SetActive(value:  true);
                this.ShowChrysalis();
                this.Icon.SetChrysalisIcon(level:  Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.GetCollectChrysalisLevel());
                this.UpdateProgress();
                return;
            }
            
            }
            
            this.ChrysalisContent.gameObject.SetActive(value:  false);
        }
        private void ShowSideButton()
        {
            if(this._isShow != false)
            {
                    return;
            }
            
            this.UpdateChrysalis();
        }
        private void HideSideButton()
        {
            if(this._isShow == false)
            {
                    return;
            }
            
            this.HideChrysalis();
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            if((val_1 != null) && (null == null))
            {
                    this._rectChrysalis = val_1;
                UnityEngine.Vector2 val_2 = val_1.anchoredPosition;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  -25f, y:  val_2.y);
                this._insidePos = val_3.x;
                UnityEngine.Vector2 val_4 = this._rectChrysalis.anchoredPosition;
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  215f, y:  val_4.y);
                this._outSidePos = val_5.x;
                return;
            }
            
            this._rectChrysalis = 0;
            throw new NullReferenceException();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  108, action:  new System.Action(object:  this, method:  System.Void View.Game.ChrysalisProgress::CollectChrysalis()));
            Message.Messager.Add(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.Game.ChrysalisProgress::ShowSideButton()));
            Message.Messager.Add(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.Game.ChrysalisProgress::HideSideButton()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  108, action:  new System.Action(object:  this, method:  System.Void View.Game.ChrysalisProgress::CollectChrysalis()));
            Message.Messager.Remove(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.Game.ChrysalisProgress::ShowSideButton()));
            Message.Messager.Remove(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.Game.ChrysalisProgress::HideSideButton()));
        }
        public ChrysalisProgress()
        {
        
        }
        private void <ShowChrysalis>b__11_0()
        {
            UnityEngine.Vector3 val_1 = this.TransformSlot.position;
            Message.Messager.Dispatch<UnityEngine.Vector3>(cmd:  109, t:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
    
    }

}
