using UnityEngine;

namespace View.Game
{
    public class QuizOptionContent : MonoBehaviour
    {
        // Fields
        private readonly float TimeDelay;
        private readonly float TimeAlpha;
        public View.Game.QuizOption[] Options;
        public UnityEngine.CanvasGroup[] CanvasOptions;
        private Data.Bean.QuizLevelBean _quizLevelBean;
        
        // Methods
        public void InitContent(Data.Bean.QuizLevelBean bean)
        {
            View.Game.QuizOption[] val_2;
            var val_3;
            var val_4;
            this._quizLevelBean = bean;
            this.PlayShowAni();
            val_2 = this.Options;
            val_3 = 4;
            label_9:
            var val_1 = val_3 - 4;
            if(val_1 >= (long)this.Options.Length)
            {
                goto label_4;
            }
            
            if(val_1 < this._quizLevelBean)
            {
                    if(val_1 >= (this._quizLevelBean & 4294967295))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2[0].SetOptionInfos(option:  (this._quizLevelBean & 4294967295).quizAnswer);
                val_2 = this.Options;
            }
            
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_4:
            if(this._quizLevelBean <= this.Options.Length)
            {
                    return;
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Log.D.Error(message:  "QuizOptionContent InitContent 数据不匹配。。。 ", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.Options[0].SetOptionInfos(option:  this._quizLevelBean.rightAnswer);
        }
        public void ClearContent()
        {
            this.ResetOption();
        }
        private void ResetOption()
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this.Options.Length)
            {
                    return;
            }
            
                this.Options[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(this.Options != null);
            
            throw new NullReferenceException();
        }
        private void PlayShowAni()
        {
            var val_7;
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  this.TimeDelay);
            val_7 = 4;
            do
            {
                if((val_7 - 4) >= this.Options.Length)
            {
                    return;
            }
            
                this.Options[0].gameObject.SetActive(value:  true);
                this.CanvasOptions[0].alpha = 0f;
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasOptions[0], endValue:  1f, duration:  this.TimeAlpha));
                val_7 = val_7 + 1;
            }
            while(this.Options != null);
            
            throw new NullReferenceException();
        }
        private void PlayHideAni()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            int val_5 = this.Options.Length;
            val_5 = val_5 - 1;
            if(<0)
            {
                    return;
            }
            
            var val_7 = (long)val_5;
            do
            {
                DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CanvasOptions[val_7], endValue:  0f, duration:  this.TimeAlpha + this.TimeAlpha), id:  this);
                val_7 = val_7 - 1;
            }
            while((val_7 & 2147483648) == 0);
        
        }
        private void BackHomeClear()
        {
            this.PlayHideAni();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  34, action:  new System.Action(object:  this, method:  System.Void View.Game.QuizOptionContent::BackHomeClear()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  34, action:  new System.Action(object:  this, method:  System.Void View.Game.QuizOptionContent::BackHomeClear()));
        }
        public QuizOptionContent()
        {
            this.TimeDelay = 0.5f;
            this.TimeAlpha = 0.15f;
        }
    
    }

}
