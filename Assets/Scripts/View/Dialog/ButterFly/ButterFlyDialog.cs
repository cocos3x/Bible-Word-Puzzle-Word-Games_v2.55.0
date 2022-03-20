using UnityEngine;

namespace View.Dialog.ButterFly
{
    public class ButterFlyDialog : Dialog
    {
        // Fields
        private const float TimeFly = 0.6;
        public View.Dialog.ButterFly.WaypointSlots Waypoint;
        public View.Dialog.ButterFly.ButterFlyFly ButterFlyFlyPrefab;
        public UnityEngine.Transform TransformContent;
        public UnityEngine.Transform TransformAsset;
        public UnityEngine.UI.Image ImageDot;
        public UnityEngine.UI.Text TextDot;
        public UnityEngine.GameObject EffectClick;
        public UnityEngine.GameObject EffectGuide;
        public UnityEngine.ParticleSystem ParticleSystem;
        public View.Dialog.ButterFly.ButterFlyChrysalisProgress ChrysalisProgress;
        public UnityEngine.UI.Text TitleText;
        public TMPro.TMP_Text ContinueText;
        private System.Collections.Generic.List<View.Dialog.ButterFly.ButterFlyFly> _butterFlys;
        private int _butterFlysCount;
        private View.Dialog.ButterFly.ButterFlyFly _tempButterFly;
        private UnityEngine.Vector3 _tempInputPos;
        
        // Methods
        public void OnClickCloseButton()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            Platform.Analytics.EzAnalytics.SendActivBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = ActivBtnClick.BtnNameEnum.BtnNameCloseBtn}, source:  new SourceEnum() {<Value>k__BackingField = ActivBtnClick.SourceEnum.SourceButterflyScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "main_click", label:  "close", value:  0);
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCanCollectButterFly()) != false)
            {
                    return;
            }
            
            this.Close();
        }
        public void OnClickHelpButton()
        {
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCanCollectButterFly()) != false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyHelpDialog", type:  0);
        }
        public void OnClickContinueButton()
        {
            string val_11;
            System.Object[] val_12;
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCanCollectButterFly()) != false)
            {
                    return;
            }
            
            val_11 = 0;
            val_12 = 1152921512608631808;
            View.Controller.MainController val_4 = Common.SingletonController<View.Controller.MainController>.Instance;
            if((Logic.Game.GameManager.gameLevel.IsAllLevelPass(section:  0, level:  0)) == false)
            {
                goto label_5;
            }
            
            if(val_4._bibleGameState != 2)
            {
                goto label_6;
            }
            
            object[] val_5 = new object[1];
            val_12 = val_5;
            val_12[0] = Locale.LocaleManager.Translate(key:  "133");
            val_11 = "ToastDialog";
            View.Dialog.Common.Dialog val_7 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  val_11, type:  1, pars:  val_5);
            goto label_22;
            label_5:
            if(val_4._bibleGameState != 2)
            {
                goto label_14;
            }
            
            val_11 = 0;
            Common.SingletonController<View.Controller.MainController>.Instance.OpenGame(gameFrom:  val_11);
            goto label_22;
            label_6:
            Message.Messager.Dispatch(cmd:  34);
            val_11 = 3;
            Common.SingletonController<View.Controller.MainController>.Instance.OpenHome(homeFrom:  val_11);
            goto label_22;
            label_14:
            if(val_8._bibleGameState == 3)
            {
                    Logic.Game.GameControllers val_10 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if((val_10.<IsGameComplete>k__BackingField) != false)
            {
                    val_11 = 0;
                Message.Messager.Dispatch(cmd:  82);
            }
            
            }
            
            label_22:
            this.Close();
        }
        public void OnClickAssetButton()
        {
            var val_7;
            var val_8;
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCanCollectButterFly()) != false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            Platform.Analytics.EzAnalytics.SendActivBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = ActivBtnClick.BtnNameEnum.BtnNameCollectionBtn}, source:  new SourceEnum() {<Value>k__BackingField = ActivBtnClick.SourceEnum.SourceButterflyScr});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "main_click", label:  "collection", value:  0);
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyCollectionDialog", type:  0);
            Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.SetOldCollectButterFly(value:  Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount());
            this.UpdateRedDot();
        }
        protected override void LocaleTranslate()
        {
            string val_1 = Locale.LocaleManager.Translate(key:  "119");
            this.ContinueText.text = Locale.LocaleManager.Translate(key:  "73");
        }
        private void ReadyFly()
        {
            int val_12;
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  false);
            Data.ButterFly.ButterFlyDataManager val_2 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance;
            int val_11 = val_2.SampleShowButterFlyMaxCount;
            val_12 = Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCanCollectButterFly();
            System.Collections.Generic.List<System.Int32> val_6 = Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyList();
            if(0 < 1)
            {
                goto label_7;
            }
            
            val_11 = val_11 - val_12;
            label_9:
            int val_8 = UnityEngine.Random.Range(min:  0, max:  0);
            int val_12 = this._butterFlysCount;
            if(val_12 >= val_11)
            {
                goto label_7;
            }
            
            val_12 = val_8 - ((val_8 / val_12) * val_12);
            if(val_12 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (val_12 << 2);
            View.Dialog.ButterFly.ButterFlyFly val_10 = this.CreateButterFly(index:  (this._butterFlysCount + (val_8 - ((val_8 / this._butterFlysCount) * this._butterFlysCount)) << 2) + 32, isJustCollect:  false);
            val_6.RemoveAt(index:  val_12);
            if(val_12 > 0)
            {
                goto label_9;
            }
            
            label_7:
            val_6.CheckHaveCanCollectButterFly();
        }
        private void ClearButterFlys()
        {
            bool val_1 = true;
            this._butterFlysCount = 0;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.ClearButterfly();
                val_2 = val_2 + 1;
            }
            while(val_2 < val_1);
        
        }
        private View.Dialog.ButterFly.ButterFlyFly CreateButterFly(int index, bool isJustCollect = False)
        {
            bool val_3 = true;
            if(val_3 <= this._butterFlysCount)
            {
                goto label_2;
            }
            
            if(val_3 <= this._butterFlysCount)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + ((this._butterFlysCount) << 3);
            this._tempButterFly = (true + (this._butterFlysCount) << 3) + 32;
            if(((true + (this._butterFlysCount) << 3) + 32) != 0)
            {
                goto label_4;
            }
            
            label_2:
            View.Dialog.ButterFly.ButterFlyFly val_1 = View.Dialog.ButterFly.ButterFlyFly.Create(parent:  this.TransformContent, prefab:  this.ButterFlyFlyPrefab);
            this._tempButterFly = val_1;
            this._butterFlys.Add(item:  val_1);
            label_4:
            this._tempButterFly.SetButterflyInfo(waypointSlots:  this.Waypoint, index:  index, isJustCollect:  isJustCollect);
            int val_4 = this._butterFlysCount;
            val_4 = val_4 + 1;
            this._butterFlysCount = val_4;
            return (View.Dialog.ButterFly.ButterFlyFly)this._tempButterFly;
        }
        private void CheckHaveCanCollectButterFly()
        {
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCanCollectButterFly()) == false)
            {
                    return;
            }
            
            View.Dialog.Common.Dialog val_3 = Logic.Game.GameManager.gameDialog.Open(name:  "ButterFlyHatchesDialog", type:  0);
        }
        private void UpdateRedDot()
        {
            this.ImageDot.gameObject.SetActive(value:  ((Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.OldCollectButterFly) < (Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount())) ? 1 : 0);
            string val_12 = (Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.GetCollectButterFlyCount()) - (Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.OldCollectButterFly).ToString();
        }
        private void CollectButterFly(int index, UnityEngine.Vector3 BeginPos)
        {
            if((this._butterFlysCount >= val_1.SampleShowButterFlyMaxCount) && (W9 >= 1))
            {
                    Common.Singleton<Data.ButterFly.ButterFlyDataManager>.Instance.ClearButterfly();
                this._butterFlys.RemoveAt(index:  0);
                int val_10 = this._butterFlysCount;
                val_10 = val_10 - 1;
                this._butterFlysCount = val_10;
            }
            
            this.CreateButterFly(index:  index, isJustCollect:  true).transform.position = new UnityEngine.Vector3() {x = BeginPos.x, y = BeginPos.y, z = BeginPos.z};
            Logic.Game.GameManager.gameSound.Play(clipName:  "butterfly_light", volumeScale:  1f, loop:  false, delay:  0f);
            this.EffectGuide.transform.position = new UnityEngine.Vector3() {x = BeginPos.x, y = BeginPos.y, z = BeginPos.z};
            this.EffectGuide.SetActive(value:  true);
            UnityEngine.Vector3 val_6 = this.TransformAsset.position;
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.EffectGuide.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.6f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyDialog::<CollectButterFly>b__27_0()));
        }
        private void Update()
        {
            Logic.Define.DialogType val_16;
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
                if(phase == 0)
            {
                    if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameTypeLast(type:  W21, name:  this.name)) != false)
            {
                    this.EffectClick.SetActive(value:  false);
                this.EffectClick.SetActive(value:  true);
                UnityEngine.Vector3 val_7 = UnityEngine.Input.mousePosition;
                UnityEngine.Vector3 val_8 = Utils.Extensions.CameraExtension.ScreenToWorldPointExt(camera:  UnityEngine.Camera.main, pointPosition:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                this._tempInputPos = val_8;
                mem[1152921512808693412] = val_8.y;
                mem[1152921512808693416] = val_8.z;
                UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  this._tempInputPos, y:  val_8.y, z:  0f);
                this.EffectClick.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                Platform.Analytics.EzAnalytics.LogEvent(category:  "butterfly", action:  "main_click", label:  "page", value:  0);
                return;
            }
            
            }
            
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            val_16 = W21;
            if((Logic.Game.GameManager.gameDialog.IsDialogShowingSameTypeLast(type:  val_16, name:  this.name)) == false)
            {
                    return;
            }
            
            View.Controller.MainController val_14 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_14._bibleGameState == 3)
            {
                    Logic.Game.GameControllers val_15 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                if((val_15.<IsGameComplete>k__BackingField) != false)
            {
                    val_16 = 1;
                Message.Messager.Dispatch<System.Boolean>(cmd:  67, t:  true);
            }
            
            }
            
            this.Close();
        }
        protected override void OnEnable()
        {
            var val_10;
            this.OnEnable();
            Message.Messager.Add<System.Int32, UnityEngine.Vector3>(cmd:  111, action:  new System.Action<System.Int32, UnityEngine.Vector3>(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyDialog::CollectButterFly(int index, UnityEngine.Vector3 BeginPos)));
            Logic.Game.GameManager.gameMusic.PlayButterFly();
            this.ClearButterFlys();
            this.UpdateRedDot();
            UnityEngine.GameObject val_2 = this.ChrysalisProgress.gameObject;
            if((Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.ButterFlyActivityIsOpenForHome()) == false)
            {
                goto label_6;
            }
            
            val_10 = (Common.Singleton<Logic.ButterFly.ButterFlyController>.Instance.IsCollectAllButterFly()) ^ 1;
            if(val_2 != null)
            {
                goto label_8;
            }
            
            label_6:
            val_10 = 0;
            label_8:
            val_2.SetActive(value:  val_10 & 1);
            this.EffectClick.SetActive(value:  false);
            this.EffectGuide.SetActive(value:  false);
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyDialog::ReadyFly()));
            Common.TimerEvent.Add(time:  0.5f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyDialog::ReadyFly()), isrepeat:  false);
            Message.Messager.Dispatch(cmd:  75);
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Int32, UnityEngine.Vector3>(cmd:  111, action:  new System.Action<System.Int32, UnityEngine.Vector3>(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyDialog::CollectButterFly(int index, UnityEngine.Vector3 BeginPos)));
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.ButterFly.ButterFlyDialog::ReadyFly()));
            View.Controller.MainController val_3 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_3._bibleGameState != 2)
            {
                goto label_6;
            }
            
            Logic.Game.GameManager.gameMusic.PlayHome();
            goto label_23;
            label_6:
            View.Controller.MainController val_4 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_4._bibleGameState != 3)
            {
                goto label_12;
            }
            
            Logic.Game.GameControllers val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((val_5.<IsGameComplete>k__BackingField) == false)
            {
                goto label_12;
            }
            
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() == false)
            {
                goto label_16;
            }
            
            Logic.Game.GameManager.gameMusic.PlayResult();
            goto label_23;
            label_12:
            this = Logic.Game.GameManager.gameMusic;
            View.Game.LevelPassTime val_7 = Common.Singleton<View.Game.LevelPassTime>.Instance;
            this.PlayGame(useNewMusic:  (val_7._dailyTime == 0f) ? 1 : 0);
            label_23:
            Message.Messager.Dispatch(cmd:  74);
            Common.SingletonController<View.Controller.MainController>.Instance.SetGameCanvasVisible(isVisible:  true);
            return;
            label_16:
            Logic.Game.GameManager.gameMusic.Pause(pause:  true);
            goto label_23;
        }
        public ButterFlyDialog()
        {
            mem[1152921512809199400] = 257;
            this._butterFlys = new System.Collections.Generic.List<View.Dialog.ButterFly.ButterFlyFly>();
            mem[1152921512809199403] = 1;
            mem[1152921512809199408] = ;
            this = new UnityEngine.MonoBehaviour();
        }
        private void <CollectButterFly>b__27_0()
        {
            this.UpdateRedDot();
            this.CheckHaveCanCollectButterFly();
            this.EffectGuide.SetActive(value:  false);
        }
    
    }

}
