using UnityEngine;

namespace View.Dialog.Result
{
    public class BibleBooks : MonoBehaviour
    {
        // Fields
        public Spine.Unity.SkeletonGraphic SkeletonGraphicBook;
        public UnityEngine.GameObject EffectBook;
        
        // Methods
        public void PlayOpenBookAni()
        {
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    Logic.Game.GameManager.gameSound.Play(clipName:  "eff_result_bible_open", volumeScale:  1f, loop:  false, delay:  0f);
            }
            
            this.gameObject.SetActive(value:  true);
            this.EffectBook.SetActive(value:  false);
            this.ClearAnimationState();
            Spine.TrackEntry val_4 = this.SkeletonGraphicBook.AnimationState.SetAnimation(trackIndex:  0, animationName:  "open", loop:  false);
        }
        public void PlayShowBookAni()
        {
            this.EffectBook.SetActive(value:  false);
            this.ClearAnimationState();
            Spine.TrackEntry val_2 = this.SkeletonGraphicBook.AnimationState.SetAnimation(trackIndex:  0, animationName:  "show", loop:  false);
        }
        public void PlayHideBookAni()
        {
            this.EffectBook.SetActive(value:  false);
            this.ClearAnimationState();
            Spine.TrackEntry val_2 = this.SkeletonGraphicBook.AnimationState.SetAnimation(trackIndex:  0, animationName:  "hide", loop:  false);
        }
        public void SetBookEndState()
        {
            this.gameObject.SetActive(value:  true);
            this.EffectBook.SetActive(value:  false);
            this.ClearAnimationState();
            Spine.TrackEntry val_3 = this.SkeletonGraphicBook.AnimationState.SetAnimation(trackIndex:  0, animationName:  "show", loop:  false);
            Spine.TrackEntry val_5 = this.SkeletonGraphicBook.AnimationState.GetCurrent(trackIndex:  0);
            val_5.animationStart = val_5.animationEnd;
            this.SkeletonGraphicBook.timeScale = 1f;
        }
        public void PlayBookEffect()
        {
            if(this.EffectBook != null)
            {
                    this.EffectBook.SetActive(value:  true);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void ClearAnimationState()
        {
            this.SkeletonGraphicBook.Skeleton.SetToSetupPose();
            this.SkeletonGraphicBook.AnimationState.ClearTracks();
        }
        public BibleBooks()
        {
        
        }
    
    }

}
