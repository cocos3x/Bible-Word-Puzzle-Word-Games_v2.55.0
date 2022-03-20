using UnityEngine;

namespace View.Game
{
    public class WordTreasureIcon : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject effectPrefab;
        public UnityEngine.Transform aniCenter;
        public UnityEngine.GameObject RedDot;
        public UnityEngine.GameObject EffectFinish;
        public UnityEngine.Animator AnimatorChest;
        private UnityEngine.Vector2 _insidePos;
        private UnityEngine.Vector2 _outSidePos;
        private UnityEngine.RectTransform _rectAni;
        private bool _isShow;
        private UnityEngine.Vector3 _beginPos;
        private bool _isPlaying;
        private bool _isFinish;
        
        // Methods
        public void OnClickTreasureIcon()
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState == 3)
            {
                    Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if((val_2.<IsGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            }
            
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState == 4)
            {
                    Logic.DailyPrayer.DailyPrayerControllers val_4 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
                if((val_4.<IsGameComplete>k__BackingField) == true)
            {
                    return;
            }
            
            }
            
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "DailyGuideDialog")) != false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.Open(name:  "WordTreasureDialog", type:  0);
        }
        public void SetAniPos(UnityEngine.Vector3 pos)
        {
            this._beginPos = pos;
            mem[1152921512652753952] = pos.y;
            mem[1152921512652753956] = pos.z;
        }
        private void UpdateTreasureIcon()
        {
            this._isFinish = Common.Singleton<Logic.Treasure.TreasureController>.Instance.CheckHaveFinishMission();
            this.SetTreasureIconState();
            this.CheckGuide();
        }
        private void SetTreasureIconState()
        {
            this.RedDot.SetActive(value:  this._isFinish);
            this.EffectFinish.SetActive(value:  this._isFinish);
            this.AnimatorChest.Play(stateName:  (this._isFinish == false) ? "WordTreasureMissionDefault" : "WordTreasureMissionCompleted3");
        }
        private void CheckGuide()
        {
            Logic.Game.GameDiglog val_8;
            if(this._isFinish == false)
            {
                    return;
            }
            
            bool val_2 = Common.Singleton<Data.Treasure.TreasureDataManager>.Instance.ShouldShowTreasureGuide;
            if(val_2 == false)
            {
                    return;
            }
            
            if(val_2.IsGameComplete() == true)
            {
                    return;
            }
            
            if(this._isShow == false)
            {
                    return;
            }
            
            val_8 = Logic.Game.GameManager.gameDialog;
            object[] val_4 = new object[1];
            UnityEngine.Vector3 val_6 = this.transform.position;
            val_4[0] = val_6;
            View.Dialog.Common.Dialog val_7 = val_8.OpenAddParams(name:  "WordTreasureEntranceGuideDialog", type:  2, pars:  val_4);
        }
        private void ShowSideButton()
        {
            this._isPlaying = false;
            if(this._isShow == true)
            {
                    return;
            }
            
            if((Common.Singleton<Logic.Treasure.TreasureController>.Instance.TreasureActivityIsOpen()) == false)
            {
                    return;
            }
            
            Common.Singleton<Logic.Treasure.TreasureController>.Instance.UpdateMissions();
            this._rectAni.gameObject.SetActive(value:  true);
            int val_5 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this._isShow = true;
            this._rectAni.anchoredPosition = new UnityEngine.Vector2() {x = this._outSidePos};
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this._rectAni, endValue:  new UnityEngine.Vector2() {x = this._insidePos}, duration:  0.5f, snapping:  false), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Game.WordTreasureIcon::UpdateTreasureIcon())), id:  this);
        }
        private void HideSideButton()
        {
            if(this._isShow == false)
            {
                    return;
            }
            
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            this._isShow = false;
            this._rectAni.anchoredPosition = new UnityEngine.Vector2() {x = this._insidePos};
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this._rectAni, endValue:  new UnityEngine.Vector2() {x = this._outSidePos}, duration:  0.5f, snapping:  false), ease:  26), id:  this);
        }
        private bool IsGameComplete()
        {
            var val_5;
            var val_6;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 4)
            {
                goto label_2;
            }
            
            val_5 = 1152921512608825040;
            goto label_3;
            label_2:
            View.Controller.MainController val_2 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_2._bibleGameState != 3)
            {
                goto label_5;
            }
            
            val_5 = 1152921512609388752;
            label_3:
            Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            var val_4 = ((val_3.<IsGameComplete>k__BackingField) == true) ? 1 : 0;
            return (bool)val_6;
            label_5:
            val_6 = 1;
            return (bool)val_6;
        }
        private void FinishMission()
        {
            bool val_2 = Common.Singleton<Logic.Treasure.TreasureController>.Instance.CheckHaveFinishMission();
            this._isFinish = val_2;
            if(this._isPlaying != true)
            {
                    if(val_2.IsGameComplete() == false)
            {
                goto label_3;
            }
            
            }
            
            this.SetTreasureIconState();
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::CheckGuide()));
            Common.TimerEvent.Add(time:  0.1f, callback:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::CheckGuide()), isrepeat:  false);
            return;
            label_3:
            typeof(WordTreasureIcon.<>c__DisplayClass20_0).__il2cppRuntimeField_18 = this;
            this._isPlaying = true;
            UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.effectPrefab, parent:  this.transform);
            typeof(WordTreasureIcon.<>c__DisplayClass20_0).__il2cppRuntimeField_10 = val_9;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  this._beginPos, y:  null);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_9.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            typeof(WordTreasureIcon.<>c__DisplayClass20_0).__il2cppRuntimeField_10.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  0.5f);
            DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOScale(target:  typeof(WordTreasureIcon.<>c__DisplayClass20_0).__il2cppRuntimeField_10.transform, endValue:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, duration:  0.5f);
            UnityEngine.Vector3 val_20 = this.aniCenter.position;
            DG.Tweening.Tweener val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  typeof(WordTreasureIcon.<>c__DisplayClass20_0).__il2cppRuntimeField_10.transform, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  0.5f, snapping:  false), ease:  1), ease:  1), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void WordTreasureIcon.<>c__DisplayClass20_0::<FinishMission>b__0()));
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            if((val_1 != null) && (null == null))
            {
                    this._rectAni = val_1;
                UnityEngine.Vector2 val_2 = val_1.anchoredPosition;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  25f, y:  val_2.y);
                this._insidePos = val_3.x;
                UnityEngine.Vector2 val_4 = this._rectAni.anchoredPosition;
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  -215f, y:  val_4.y);
                this._outSidePos = val_5.x;
                return;
            }
            
            this._rectAni = 0;
            throw new NullReferenceException();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::ShowSideButton()));
            Message.Messager.Add(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::HideSideButton()));
            Message.Messager.Add(cmd:  48, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::FinishMission()));
            Message.Messager.Add(cmd:  49, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::UpdateTreasureIcon()));
            this._isFinish = false;
            this.SetTreasureIconState();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::ShowSideButton()));
            Message.Messager.Remove(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::HideSideButton()));
            Message.Messager.Remove(cmd:  48, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::FinishMission()));
            Message.Messager.Remove(cmd:  49, action:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::UpdateTreasureIcon()));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Game.WordTreasureIcon::CheckGuide()));
        }
        public WordTreasureIcon()
        {
        
        }
    
    }

}
