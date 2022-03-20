using UnityEngine;
private sealed class LetterContent.<Level1_2GuideWaitStart>d__55 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View.Game.LetterContent <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LetterContent.<Level1_2GuideWaitStart>d__55(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_9;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_12;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.IsLevel1_2GuideWaiting) == true)
        {
            goto label_12;
        }
        
        val_9 = true;
        this.<>4__this.IsLevel1_2GuideWaiting = val_9;
        if((this.<>4__this.IsLevel1_2GuideFirst) == false)
        {
            goto label_6;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  3.5f);
        this.<>1__state = val_9;
        return (bool)val_9;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.IsLevel1_2GuideFirst = false;
        label_6:
        val_9 = 0;
        this.<>4__this.IsLevel1_2GuideWaiting = false;
        if((this.<>4__this.IsKeyButtonClick) == true)
        {
                return (bool)val_9;
        }
        
        if(View.Game.GameController.GetInstance() != 0)
        {
                View.Game.GameController val_4 = View.Game.GameController.GetInstance();
            this.<>4__this.guideWords = val_4.wordContent.GetGuideWords();
            this.<>2__current = this.<>4__this.StartCoroutine(routine:  this.<>4__this.StartShowGuide(delay:  1.5f, duration:  0.8f, onComplet:  new System.Action(object:  this.<>4__this, method:  System.Void View.Game.LetterContent::ShowLevel1_2Guide())));
            this.<>1__state = 2;
            val_9 = 1;
            return (bool)val_9;
        }
        
        label_12:
        val_9 = 0;
        return (bool)val_9;
        label_1:
        val_9 = 0;
        this.<>1__state = 0;
        return (bool)val_9;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
