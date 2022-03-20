using UnityEngine;

namespace View.Dialog.Result
{
    public class ResultBibleContent : UIElement
    {
        // Fields
        private const float TimeAlpha = 0.5;
        private const float TimeHideLetter = 0.5;
        public UnityEngine.Animator AnimatorBible;
        public UnityEngine.CanvasGroup CanvasGroupContent;
        public UnityEngine.UI.GridLayoutGroup TextGridLayout;
        public UnityEngine.Transform ReferenceParent;
        public View.CommonItem.ResultBibleTextItem TextItemPrefab;
        public View.CommonItem.ResultBibleTextItem ReferenceItemPrefab;
        public UnityEngine.CanvasGroup CanvasLetterContent;
        public Spine.Unity.SkeletonGraphic SkeletonGraphicReel;
        public UnityEngine.GameObject EffectVersesLight;
        public UnityEngine.UI.Button ButtonCollect;
        public TMPro.TextMeshProUGUI TextCollect;
        public UnityEngine.GameObject VerseStamp;
        public UnityEngine.CanvasGroup CanvasVerseSteam;
        private System.Collections.Generic.List<View.CommonItem.ResultBibleTextItem> _referenceItems;
        private System.Collections.Generic.List<View.CommonItem.ResultBibleTextItem> _allContentTextItems;
        private System.Collections.Generic.List<View.CommonItem.ResultBibleTextItem> _allTextItems;
        private int _maxLine;
        private float _reduceScale;
        private bool _isClickCollect;
        
        // Methods
        public void LocaleTranslate()
        {
            this.TextCollect.text = Locale.LocaleManager.Translate(key:  "22");
        }
        public void ShowBibleContent()
        {
            this.gameObject.SetActive(value:  true);
            this.ButtonCollect.enabled = true;
            this.VerseStamp.SetActive(value:  false);
            this.UpdateBibleContent();
        }
        public void HideBibleContent()
        {
            this.gameObject.SetActive(value:  false);
        }
        public void OnClickCollectButton()
        {
            this.ButtonCollect.enabled = false;
            this.ClickCollect();
        }
        private void ClickCollect()
        {
            this.EffectVersesLight.SetActive(value:  false);
            if(this._isClickCollect != false)
            {
                    return;
            }
            
            this._isClickCollect = true;
            DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasLetterContent, endValue:  0f, duration:  0.5f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.Result.ResultBibleContent::<ClickCollect>b__25_0()));
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasVerseSteam, endValue:  0f, duration:  0.5f);
        }
        private void UpdateBibleContent()
        {
            string val_10;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_10 = "eff_result_scroll_open";
            }
            else
            {
                    val_10 = "verse_start";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_10, volumeScale:  1f, loop:  false, delay:  0f);
            this.EffectVersesLight.SetActive(value:  false);
            this._isClickCollect = false;
            this.CanvasGroupContent.alpha = 0f;
            this.ButtonCollect.gameObject.SetActive(value:  false);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupContent, endValue:  1f, duration:  0.5f);
            this.SkeletonGraphicReel.Skeleton.SetToSetupPose();
            this.SkeletonGraphicReel.AnimationState.ClearTracks();
            Spine.TrackEntry val_7 = this.SkeletonGraphicReel.AnimationState.SetAnimation(trackIndex:  0, animationName:  "open_reel", loop:  false);
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.CreateItem());
        }
        private System.Collections.IEnumerator CreateItem()
        {
            typeof(ResultBibleContent.<CreateItem>d__27).__il2cppRuntimeField_10 = 0;
            typeof(ResultBibleContent.<CreateItem>d__27).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private System.Collections.IEnumerator CloseReel()
        {
            typeof(ResultBibleContent.<CloseReel>d__28).__il2cppRuntimeField_10 = 0;
            typeof(ResultBibleContent.<CloseReel>d__28).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private System.Collections.IEnumerator PlayItemAni()
        {
            typeof(ResultBibleContent.<PlayItemAni>d__29).__il2cppRuntimeField_10 = 0;
            typeof(ResultBibleContent.<PlayItemAni>d__29).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void ClearBibleContent()
        {
            View.CommonItem.ResultBibleTextItem val_2;
            var val_3;
            var val_10;
            var val_11;
            List.Enumerator<T> val_1 = this._allTextItems.GetEnumerator();
            label_6:
            val_10 = public System.Boolean List.Enumerator<View.CommonItem.ResultBibleTextItem>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_11 = mem[public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184];
            val_11 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184;
            View.CommonItem.ResultBibleTextItem val_5 = val_11.Recycle<View.CommonItem.ResultBibleTextItem>(obj:  val_2, isUi:  true);
            goto label_6;
            label_2:
            val_3.Dispose();
            this._allTextItems.Clear();
            List.Enumerator<T> val_6 = this._referenceItems.GetEnumerator();
            label_13:
            val_10 = public System.Boolean List.Enumerator<View.CommonItem.ResultBibleTextItem>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_9;
            }
            
            val_11 = mem[public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184];
            val_11 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184;
            View.CommonItem.ResultBibleTextItem val_8 = val_11.Recycle<View.CommonItem.ResultBibleTextItem>(obj:  val_2, isUi:  true);
            goto label_13;
            label_9:
            val_3.Dispose();
            this._referenceItems.Clear();
            this._allContentTextItems.Clear();
        }
        private void Awake()
        {
            this._referenceItems = new System.Collections.Generic.List<View.CommonItem.ResultBibleTextItem>();
            this._allContentTextItems = new System.Collections.Generic.List<View.CommonItem.ResultBibleTextItem>();
            this._allTextItems = new System.Collections.Generic.List<View.CommonItem.ResultBibleTextItem>();
        }
        private void OnDisable()
        {
            this.ClearBibleContent();
        }
        public ResultBibleContent()
        {
            this._maxLine = 9;
            this._reduceScale = 5.510186E-41f;
        }
        private void <ClickCollect>b__25_0()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasGroupContent, endValue:  0f, duration:  0.5f);
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != true)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "verse_collect", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            this.SkeletonGraphicReel.Skeleton.SetToSetupPose();
            this.SkeletonGraphicReel.AnimationState.ClearTracks();
            Spine.TrackEntry val_6 = this.SkeletonGraphicReel.AnimationState.SetAnimation(trackIndex:  0, animationName:  "close_reel", loop:  false);
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.CloseReel());
        }
    
    }

}
