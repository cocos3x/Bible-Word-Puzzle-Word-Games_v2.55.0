using UnityEngine;

namespace View.CommonItem
{
    public class ExtraBottle : MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform pos1;
        private UnityEngine.RectTransform pos2;
        private UnityEngine.UI.Text TextBonus;
        public UnityEngine.Transform Transformbottle;
        public UnityEngine.Animator AnimatorFull;
        public UnityEngine.GameObject extraEffect;
        public UnityEngine.Transform extraCenter;
        private UnityEngine.RectTransform _rectTransform;
        private int extraTragetCount;
        private int extraProgress;
        private int index;
        private float time;
        private bool hasShowBottle;
        
        // Properties
        set; }
        
        // Methods
        private void set_progress(float value)
        {
            var val_4;
            float val_1 = UnityEngine.Mathf.Clamp01(value:  value);
            val_1 = val_1 * (float)this.extraTragetCount;
            val_4 = (int)val_1 - 1;
            this.SetIndex(value:  (this.extraProgress < 1) ? (val_4) : 0);
        }
        public void OnClickBottleButton()
        {
            var val_5;
            if(View.Game.GameController.GetInstance() != 0)
            {
                    View.Game.GameController val_3 = View.Game.GameController.GetInstance();
                if((val_3.<isGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            }
            
            val_5 = null;
            val_5 = null;
            Platform.Analytics.EzAnalytics.SendGameBtnClick(btnName:  new BtnNameEnum() {<Value>k__BackingField = GameBtnClick.BtnNameEnum.BtnNameExtraWordBtn}, levelName:  "");
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_button_extra_word_click", label:  "", value:  0);
            View.Dialog.Common.Dialog val_4 = Logic.Game.GameManager.gameDialog.Open(name:  "ExtraDialog", type:  0);
        }
        private void RefreshBottleProgress()
        {
            int val_2 = Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ExtraProgress;
            this.extraProgress = val_2;
            int val_3 = val_2.GetProgressCount();
            this.extraTragetCount = val_3;
            float val_4 = (float)this.extraProgress;
            val_4 = val_4 / (float)val_3;
            this.progress = val_4;
        }
        private void HideBottle()
        {
            this.hasShowBottle = false;
            this.Transformbottle.gameObject.SetActive(value:  false);
        }
        private void ShowBottle()
        {
            if(this.hasShowBottle != true)
            {
                    this.hasShowBottle = true;
                this.Transformbottle.gameObject.SetActive(value:  true);
                int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
                DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this._rectTransform, endValue:  25f, duration:  0.5f, snapping:  false), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.ExtraBottle::CheckExtraFull())), id:  this);
            }
            
            this.RefreshBottleProgress();
        }
        private bool isCanShow()
        {
            if((Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.HasExtraFirst) == false)
            {
                    return false;
            }
            
            return Common.Singleton<Data.UserPlayer.UserPlayerDataManager>.Instance.IsLast(section:  0, level:  0);
        }
        private void SetIndex(int value)
        {
            if(this.index == value)
            {
                    return;
            }
            
            this.index = value;
            int val_3 = this.extraTragetCount;
            val_3 = val_3 - 1;
            this.AnimatorFull.gameObject.SetActive(value:  (this.index == val_3) ? 1 : 0);
            this.CheckExtraFull();
        }
        private void CheckExtraFull()
        {
            int val_1 = this.extraTragetCount;
            val_1 = val_1 - 1;
            if(this.index != val_1)
            {
                    return;
            }
            
            this.AnimatorFull.Play(stateName:  "GameExtraFull_Full");
        }
        private void AddExtraWord(string answer, UnityEngine.Vector3 beginPos)
        {
            typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_10 = answer;
            typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_18 = this;
            this.ShowBottle();
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.extraEffect, parent:  this.transform);
            typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20 = val_3;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  beginPos.x, y:  beginPos.y);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            val_3.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20, name:  "Dialog", order:  12);
            UnityEngine.Vector3 val_8 = this.extraCenter.transform.position;
            UnityEngine.Vector3 val_10 = typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20.transform.position;
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_8.x, y:  val_10.y);
            UnityEngine.Vector3[] val_12 = new UnityEngine.Vector3[3];
            UnityEngine.Vector3 val_14 = typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20.transform.position;
            val_12[0] = val_14;
            val_12[0] = val_14.y;
            val_12[1] = val_14.z;
            val_12[1] = val_11.x;
            val_12[2] = val_11.z;
            UnityEngine.Vector3 val_16 = this.extraCenter.transform.position;
            val_12[3] = val_16;
            val_12[3] = val_16.y;
            val_12[4] = val_16.z;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  0.5f);
            DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOScale(target:  typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20.transform, endValue:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  0.5f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_29 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  typeof(ExtraBottle.<>c__DisplayClass22_0).__il2cppRuntimeField_20.transform, path:  Common.EzBezier.GetBezierList(startPoint:  new UnityEngine.Vector3() {x = val_12[0], y = val_12[0], z = val_12[1]}, controlPoint:  new UnityEngine.Vector3() {x = val_12[1], y = val_12[2], z = val_12[2]}, endPoint:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.z}, segmentNum:  20), duration:  0.5f, pathType:  0, pathMode:  1, resolution:  10, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  5), ease:  1), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ExtraBottle.<>c__DisplayClass22_0::<AddExtraWord>b__0()));
        }
        private void PlayAddExtraWordAni()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.1f);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.1f), loops:  2, loopType:  1);
            this.RefreshBottleProgress();
        }
        private void ShowExtraBottle()
        {
            if(this.isCanShow() != false)
            {
                    this.ShowBottle();
                return;
            }
            
            this.HideBottle();
        }
        private void HideExtraBottle()
        {
            if(this.hasShowBottle == false)
            {
                    return;
            }
            
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this._rectTransform, endValue:  -215f, duration:  0.5f, snapping:  false), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.ExtraBottle::HideBottle())), id:  this);
        }
        private void Awake()
        {
            UnityEngine.RectTransform val_5;
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            this._rectTransform = val_5;
            UnityEngine.Vector3 val_3 = this.pos2.position;
            val_5.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            string val_4 = Locale.LocaleManager.Translate(key:  "7");
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  51, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ExtraBottle::RefreshBottleProgress()));
            System.Action<System.String, UnityEngine.Vector3> val_6 = new System.Action<System.String, UnityEngine.Vector3>(object:  this, method:  System.Void View.CommonItem.ExtraBottle::AddExtraWord(string answer, UnityEngine.Vector3 beginPos));
            Message.Messager.Add<System.String, UnityEngine.Vector3>(cmd:  55, action:  51);
            Message.Messager.Add(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ExtraBottle::ShowExtraBottle()));
            Message.Messager.Add(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ExtraBottle::HideExtraBottle()));
            this.time = UnityEngine.Time.realtimeSinceStartup;
            this.extraTragetCount = this.GetProgressCount();
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  51, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ExtraBottle::RefreshBottleProgress()));
            Message.Messager.Remove<System.String, UnityEngine.Vector3>(cmd:  55, action:  new System.Action<System.String, UnityEngine.Vector3>(object:  this, method:  System.Void View.CommonItem.ExtraBottle::AddExtraWord(string answer, UnityEngine.Vector3 beginPos)));
            Message.Messager.Remove(cmd:  52, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ExtraBottle::ShowExtraBottle()));
            Message.Messager.Remove(cmd:  54, action:  new System.Action(object:  this, method:  System.Void View.CommonItem.ExtraBottle::HideExtraBottle()));
        }
        private int GetProgressCount()
        {
            int val_8;
            if(Logic.Game.GameManager.gameConfig.GetPropertyConfig() == null)
            {
                goto label_4;
            }
            
            Data.Bean.PropertyBean val_6 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            val_8 = val_6.extraProgressCount;
            if((Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.Left5Count) < 1)
            {
                    return val_8;
            }
            
            Data.Bean.PropertyBean val_7 = Logic.Game.GameManager.gameConfig.GetPropertyConfig();
            if((Common.Singleton<Data.ExtraWord.ExtraWordDataManager>.Instance.ExtraProgress) <= val_8)
            {
                goto label_10;
            }
            
            val_8 = val_7.extraProgressCount;
            return val_8;
            label_4:
            val_8 = 5;
            return val_8;
            label_10:
            val_8 = val_7.extraLeft5ProgressCount;
            return val_8;
        }
        public ExtraBottle()
        {
            this.index = 0;
        }
    
    }

}
