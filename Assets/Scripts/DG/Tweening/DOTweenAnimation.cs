using UnityEngine;

namespace DG.Tweening
{
    public class DOTweenAnimation : ABSAnimationComponent
    {
        // Fields
        public float delay;
        public float duration;
        public DG.Tweening.Ease easeType;
        public UnityEngine.AnimationCurve easeCurve;
        public DG.Tweening.LoopType loopType;
        public int loops;
        public string id;
        public bool isRelative;
        public bool isFrom;
        public bool isIndependentUpdate;
        public bool autoKill;
        public bool isActive;
        public bool isValid;
        public UnityEngine.Component target;
        public DG.Tweening.Core.DOTweenAnimationType animationType;
        public DG.Tweening.Core.TargetType targetType;
        public DG.Tweening.Core.TargetType forcedTargetType;
        public bool autoPlay;
        public bool useTargetAsV3;
        public float endValueFloat;
        public UnityEngine.Vector3 endValueV3;
        public UnityEngine.Vector2 endValueV2;
        public UnityEngine.Color endValueColor;
        public string endValueString;
        public UnityEngine.Rect endValueRect;
        public UnityEngine.Transform endValueTransform;
        public bool optionalBool0;
        public float optionalFloat0;
        public int optionalInt0;
        public DG.Tweening.RotateMode optionalRotationMode;
        public DG.Tweening.ScrambleMode optionalScrambleMode;
        public string optionalString;
        private bool _tweenCreated;
        private int _playCount;
        
        // Methods
        private void Awake()
        {
            if(this.isActive == false)
            {
                    return;
            }
            
            if(this.isValid == false)
            {
                    return;
            }
            
            if(this.animationType == 1)
            {
                    if(this.useTargetAsV3 == true)
            {
                    return;
            }
            
            }
            
            this.CreateTween();
            this._tweenCreated = true;
        }
        private void Start()
        {
            if(this._tweenCreated != false)
            {
                    return;
            }
            
            this.CreateTween();
            this._tweenCreated = true;
        }
        private void OnDestroy()
        {
            if((this != null) && (this.endValueString != null))
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this, complete:  false);
            }
            
            mem[1152921515420717432] = 0;
        }
        public void CreateTween()
        {
            UnityEngine.Component val_118;
            UnityEngine.Object val_119;
            bool val_123;
            val_118 = this.target;
            if(val_118 == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0} :: This tween\'s target is NULL, because the animation was created with a DOTween Pro version older than 0.9.255. To fix this, exit Play mode then simply select this object, and it will update automatically", arg0:  this.gameObject.name), context:  this.gameObject);
                return;
            }
            
            if(this.forcedTargetType == 0)
            {
                goto label_7;
            }
            
            label_22:
            this.targetType = this.forcedTargetType;
            goto label_8;
            label_7:
            if(this.targetType == 0)
            {
                goto label_9;
            }
            
            label_8:
            DG.Tweening.Core.DOTweenAnimationType val_118 = this.animationType;
            val_118 = val_118 - 1;
            if(val_118 > 20)
            {
                goto label_125;
            }
            
            var val_119 = 15763364 + ((this.animationType - 1)) << 2;
            val_119 = val_119 + 15763364;
            goto (15763364 + ((this.animationType - 1)) << 2 + 15763364);
            label_9:
            DG.Tweening.Core.TargetType val_13 = DG.Tweening.DOTweenAnimation.TypeToDOTargetType(t:  this.target.GetType());
            goto label_22;
            label_125:
            if( == null)
            {
                    return;
            }
            
            val_123 = this.isRelative;
            if(this.isFrom != false)
            {
                    DG.Tweening.Tweener val_79 = DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  null, isRelative:  (val_123 == true) ? 1 : 0);
            }
            else
            {
                    DG.Tweening.Tween val_81 = DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tween>(t:  null, isRelative:  (val_123 == true) ? 1 : 0);
            }
            
            DG.Tweening.Tween val_86 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tween>(t:  null, target:  this.gameObject), delay:  this.delay), loops:  this.loops, loopType:  this.loopType), autoKillOnCompletion:  this.autoKill);
            DG.Tweening.TweenCallback val_87 = null;
            val_119 = val_87;
            val_87 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void DG.Tweening.DOTweenAnimation::<CreateTween>b__37_0());
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::OnKill<DG.Tweening.Tween>(DG.Tweening.Tween t, DG.Tweening.TweenCallback action)) != 0)
            {
                    DG.Tweening.Tween val_89 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.OnKill<DG.Tweening.Tween>(t:  val_86, action:  val_119));
            }
            
            if(this.easeType == 37)
            {
                    DG.Tweening.Tween val_90 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tween>(t:  val_89, animCurve:  this.easeCurve);
            }
            else
            {
                    DG.Tweening.Tween val_91 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tween>(t:  val_89, ease:  this.easeType);
            }
            
            DG.Tweening.Tween val_94 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tween>(t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tween>(t:  System.String.IsNullOrEmpty(value:  this.id), id:  this.id), isIndependentUpdate:  this.isIndependentUpdate);
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_168;
            }
            
            if(val_86 == null)
            {
                goto label_170;
            }
            
            DG.Tweening.Tween val_96 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tween>(t:  val_119, action:  new DG.Tweening.TweenCallback(object:  val_86, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_170;
            label_168:
            mem[1152921515421397944] = 0;
            label_170:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_171;
            }
            
            if(val_86 == null)
            {
                goto label_173;
            }
            
            DG.Tweening.Tween val_98 = DG.Tweening.TweenSettingsExtensions.OnPlay<DG.Tweening.Tween>(t:  val_119, action:  new DG.Tweening.TweenCallback(object:  val_86, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_173;
            label_171:
            mem[1152921515421397952] = 0;
            label_173:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_174;
            }
            
            if(val_86 == null)
            {
                goto label_176;
            }
            
            DG.Tweening.Tween val_100 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tween>(t:  val_119, action:  new DG.Tweening.TweenCallback(object:  val_86, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_176;
            label_174:
            mem[1152921515421397960] = 0;
            label_176:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_177;
            }
            
            if(val_86 == null)
            {
                goto label_179;
            }
            
            DG.Tweening.Tween val_102 = DG.Tweening.TweenSettingsExtensions.OnStepComplete<DG.Tweening.Tween>(t:  val_119, action:  new DG.Tweening.TweenCallback(object:  val_86, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_179;
            label_177:
            mem[1152921515421397968] = 0;
            label_179:
            if((public static DG.Tweening.Tween DG.Tweening.TweenSettingsExtensions::SetUpdate<DG.Tweening.Tween>(DG.Tweening.Tween t, bool isIndependentUpdate)) == 0)
            {
                goto label_180;
            }
            
            if(val_86 == null)
            {
                goto label_182;
            }
            
            DG.Tweening.Tween val_104 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tween>(t:  val_119, action:  new DG.Tweening.TweenCallback(object:  val_86, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
            goto label_182;
            label_180:
            mem[1152921515421397976] = 0;
            label_182:
            if(this.autoPlay != false)
            {
                    DG.Tweening.Tween val_105 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  val_94);
            }
            else
            {
                    DG.Tweening.Tween val_106 = DG.Tweening.TweenExtensions.Pause<DG.Tweening.Tween>(t:  val_94);
            }
            
            if((public static DG.Tweening.Tween DG.Tweening.TweenExtensions::Pause<DG.Tweening.Tween>(DG.Tweening.Tween t)) == 0)
            {
                    return;
            }
            
            if(val_106 == null)
            {
                    return;
            }
            
            val_106.Invoke();
        }
        public override void DOPlay()
        {
            int val_2 = DG.Tweening.DOTween.Play(targetOrId:  this.gameObject);
        }
        public override void DOPlayBackwards()
        {
            int val_2 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  this.gameObject);
        }
        public override void DOPlayForward()
        {
            int val_2 = DG.Tweening.DOTween.PlayForward(targetOrId:  this.gameObject);
        }
        public override void DOPause()
        {
            int val_2 = DG.Tweening.DOTween.Pause(targetOrId:  this.gameObject);
        }
        public override void DOTogglePause()
        {
            int val_2 = DG.Tweening.DOTween.TogglePause(targetOrId:  this.gameObject);
        }
        public override void DORewind()
        {
            this._playCount = 0;
            int val_3 = val_2.Length - 1;
            if(<0)
            {
                    return;
            }
            
            do
            {
                if((DG.Tweening.TweenExtensions.IsInitialized(t:  T[].__il2cppRuntimeField_parent)) != false)
            {
                    DG.Tweening.TweenExtensions.Rewind(t:  T[].__il2cppRuntimeField_parent, includeDelay:  true);
            }
            
                val_3 = val_3 - 1;
                if(val_3 < 0)
            {
                    return;
            }
            
                this.gameObject.GetComponents<DG.Tweening.DOTweenAnimation>()[val_3][32] = (this.gameObject.GetComponents<DG.Tweening.DOTweenAnimation>()[val_3][32]) - 8;
            }
            while(val_3 < val_2.Length);
            
            throw new IndexOutOfRangeException();
        }
        public override void DORestart(bool fromHere = False)
        {
            this._playCount = 0;
            if(true != 0)
            {
                    if((fromHere != false) && (this.isRelative != false))
            {
                    this.ReEvaluateRelativeTween();
            }
            
                int val_2 = DG.Tweening.DOTween.Restart(targetOrId:  this.gameObject, includeDelay:  true);
                return;
            }
            
            if(DG.Tweening.Core.Debugger.logPriority < 2)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogNullTween(t:  0);
        }
        public override void DOComplete()
        {
            int val_2 = DG.Tweening.DOTween.Complete(targetOrId:  this.gameObject, withCallbacks:  false);
        }
        public override void DOKill()
        {
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this.gameObject, complete:  false);
            mem[1152921515423095144] = 0;
        }
        public void DOPlayById(string id)
        {
            int val_2 = DG.Tweening.DOTween.Play(target:  this.gameObject, id:  id);
        }
        public void DOPlayAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Play(targetOrId:  id);
        }
        public void DOPlayNext()
        {
            int val_6 = val_1.Length;
            int val_7 = this._playCount;
            val_6 = val_6 - 1;
            if(val_7 >= val_6)
            {
                    return;
            }
            
            do
            {
                val_7 = val_7 + 1;
                this._playCount = val_7;
                if(((this.GetComponents<DG.Tweening.DOTweenAnimation>()[val_7]) != 0) && ((val_1[(this._playCount + 1)][0] + 88) != 0))
            {
                    if((DG.Tweening.TweenExtensions.IsPlaying(t:  val_1[(this._playCount + 1)][0] + 88)) != true)
            {
                    if((DG.Tweening.TweenExtensions.IsComplete(t:  val_1[(this._playCount + 1)][0] + 88)) == false)
            {
                goto label_10;
            }
            
            }
            
            }
            
                int val_9 = val_1.Length;
                val_9 = val_9 - 1;
            }
            while(this._playCount < val_9);
            
            return;
            label_10:
            DG.Tweening.Tween val_5 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  val_1[(this._playCount + 1)][0] + 88);
        }
        public void DORewindAndPlayNext()
        {
            this._playCount = 0;
            int val_2 = DG.Tweening.DOTween.Rewind(targetOrId:  this.gameObject, includeDelay:  true);
            this.DOPlayNext();
        }
        public void DORestartById(string id)
        {
            this._playCount = 0;
            int val_2 = DG.Tweening.DOTween.Restart(target:  this.gameObject, id:  id, includeDelay:  true);
        }
        public void DORestartAllById(string id)
        {
            this._playCount = 0;
            int val_1 = DG.Tweening.DOTween.Restart(targetOrId:  id, includeDelay:  true);
        }
        public System.Collections.Generic.List<DG.Tweening.Tween> GetTweens()
        {
            return DG.Tweening.DOTween.TweensByTarget(target:  this.gameObject, playingOnly:  false);
        }
        public static DG.Tweening.Core.TargetType TypeToDOTargetType(System.Type t)
        {
            System.Type val_8 = t;
            string val_8 = ".";
            int val_1 = t.LastIndexOf(value:  val_8);
            if(val_1 != 1)
            {
                    val_8 = val_1 + 1;
                val_8 = val_8.Substring(startIndex:  val_8);
            }
            
            object val_7 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  ((System.String.op_Inequality(a:  val_8, b:  "SpriteRenderer")) != true) ? "Renderer" : (val_8));
            return (DG.Tweening.Core.TargetType)null;
        }
        private void ReEvaluateRelativeTween()
        {
            if(this.animationType != 2)
            {
                    if(this.animationType != 1)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_2 = this.transform.position;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = this.transform.localPosition;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.endValueV3, y = V11.16B, z = V10.16B});
        }
        public DOTweenAnimation()
        {
            this.duration = 1f;
            this.easeType = 6;
            UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[2];
            UnityEngine.Keyframe val_2 = new UnityEngine.Keyframe(time:  0f, value:  0f);
            val_1[0] = val_2.m_OutTangent;
            val_1[0] = val_2.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  1f, value:  1f);
            val_1[1] = val_3.m_OutTangent;
            val_1[1] = val_3.m_Time;
            this.easeCurve = new UnityEngine.AnimationCurve(keys:  val_1);
            this.loops = 1;
            this.autoKill = true;
            this.isActive = true;
            this.autoPlay = 1;
            this.id = "";
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  1f);
            UnityEngine.Rect val_6;
            this.endValueColor = val_5.r;
            this.endValueString = "";
            val_6 = new UnityEngine.Rect(x:  0f, y:  0f, width:  0f, height:  0f);
            this.endValueRect = val_6.m_XMin;
            this._playCount = 0;
        }
        private void <CreateTween>b__37_0()
        {
            mem[1152921515424556648] = 0;
        }
    
    }

}
