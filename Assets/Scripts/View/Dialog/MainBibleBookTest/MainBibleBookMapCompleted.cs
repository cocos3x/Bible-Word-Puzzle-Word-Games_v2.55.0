using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleBookMapCompleted : MonoBehaviour
    {
        // Fields
        private const float TimeDelayEffect = 0.25;
        public UnityEngine.Animator AnimatorComplete;
        public UnityEngine.Sprite[] SpriteMapBg;
        public UnityEngine.UI.Image ImageMapBg;
        public TMPro.TextMeshProUGUI TextCompleteNo;
        public UnityEngine.GameObject EffectLight;
        public UnityEngine.GameObject EffectLight2;
        private int _bibleSectionIndex;
        private int _bibleIndex;
        
        // Methods
        public void OnClickMapLevelButton()
        {
            Data.Bible.BibleDataManager val_1 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            if((val_1.<IsExistCollectAni>k__BackingField) != false)
            {
                    if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.GetHaveMapReelGuide()) == true)
            {
                    return;
            }
            
            }
            
            object[] val_4 = new object[2];
            val_4[0] = this._bibleSectionIndex;
            this = this._bibleIndex;
            val_4[1] = this;
            View.Dialog.Common.Dialog val_5 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MainBibleContentDialog", pars:  val_4);
        }
        public void SetLevelCompleteInfo(int bibleSectionIndex, int bibleIndex, Data.Bible.MapCompletedState state)
        {
            this.EffectLight.SetActive(value:  false);
            this.EffectLight2.SetActive(value:  false);
            this._bibleSectionIndex = bibleSectionIndex;
            this._bibleIndex = bibleIndex;
            this.TextCompleteNo.text = bibleIndex + 1.ToString();
            if(state == 0)
            {
                goto label_4;
            }
            
            if(state != 1)
            {
                goto label_6;
            }
            
            if(this.ImageMapBg != null)
            {
                goto label_8;
            }
            
            label_4:
            this.gameObject.SetActive(value:  false);
            return;
            label_6:
            label_8:
            this.ImageMapBg.sprite = null;
            this.gameObject.SetActive(value:  true);
            this.AnimatorComplete.Play(stateName:  "MapLevelCompletedEnd");
        }
        public void SetMalLevelAllState(int maxCount)
        {
            Logic.Game.GameManager.gameSound.Play(clipName:  "mainBible_verse_collect", volumeScale:  1f, loop:  false, delay:  0f);
            this.ImageMapBg.sprite = this.SpriteMapBg[1];
            this.gameObject.SetActive(value:  true);
            this.AnimatorComplete.Play(stateName:  "MapLevelCompletedEnd");
        }
        public void ShowLevelComplete(bool isAll)
        {
            if(isAll == false)
            {
                goto label_2;
            }
            
            if(this.ImageMapBg != null)
            {
                goto label_4;
            }
            
            label_2:
            label_4:
            this.ImageMapBg.sprite = null;
            if(isAll != false)
            {
                    return;
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  "mainBible_verse_collect", volumeScale:  1f, loop:  false, delay:  0f);
            this.gameObject.SetActive(value:  true);
            this.AnimatorComplete.Play(stateName:  "MapLevelCompletedShow");
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapCompleted::DelayPlayEffect()));
            Common.TimerEvent.Add(time:  0.25f, callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapCompleted::DelayPlayEffect()), isrepeat:  false);
        }
        public void PlayEffect()
        {
            this.EffectLight.SetActive(value:  false);
            this.EffectLight2.SetActive(value:  false);
            this.EffectLight.SetActive(value:  true);
            this.EffectLight2.SetActive(value:  true);
        }
        private void DelayPlayEffect()
        {
            this.PlayEffect();
        }
        private void OnDisable()
        {
            Common.TimerEvent.remove(callback:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMapCompleted::DelayPlayEffect()));
        }
        public MainBibleBookMapCompleted()
        {
        
        }
    
    }

}
